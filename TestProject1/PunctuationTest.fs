namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms
open System.Threading.Tasks
open System.Reactive
open System.Reactive.Linq
open FSharp.Idioms
open System.Collections.Generic
open System.Collections.Concurrent

open FSharp.Idioms.OrdinalIgnoreCase
open System.Reactive.Threading.Tasks
open System.Reactive.Linq
open System.Threading

type PunctuationTest(output:ITestOutputHelper) =

    [<Theory>]
    [<InlineData("min/chin2",41377us,41470us)>]
    [<InlineData("min/SBHZ",41649us,43241us)>]
    member _.``shp to fsharp``(source : string, b:uint16, e:uint16) =
        let src = Path.Combine(Dir.solutionPath, source+".SHP")
        let name = Path.GetFileNameWithoutExtension source
        let tgt = Path.Combine(Dir.solutionPath, "punctuation", name+".fs")
        
        let dict = Dictionary<uint16,_>()
        //let groups =
        let shapeStream =
            (
                File.ReadAllLines(src,Encoding.UTF8)
                |> ShapesCompiler.parse
            )
                .ToObservable()
                .SelectMany(fun (lines) -> task {
                    return BlobGroup.from lines
                    })

            //groups
                .Where(fun group ->
                    match group with
                    | BlobShape (x,_) when b <= x && x <= e -> true
                    | _ -> false
                )
                .Select(fun group ->
                    match group with
                    | BlobShape (num,lines) -> num,lines
                    | _ -> 0us,[]
                )
                ///在此执行任何映射操作
                .Select(fun (num,lines) ->
                    let specs =
                        lines
                        |> List.tail
                        |> Number.getIntListFromLines
                        |> SpecificationUtils.getSpecifications
                        |> SpecificationUtils.trimPushPop

                    // fsharp 源代码
                    let fs = FSharpSpecification.listShape num specs
                    num, fs
                )
                .Synchronize()
                .Do(fun (k,v) -> dict.Add(k,v))
                .Select(fst>>int)

        let tcs = TaskCompletionSource()
        //let countdownEvent = new CountdownEvent(3)

        let complete () =
            let outp = 
                dict
                |> Seq.toArray
                |> Array.map(fun(KeyValue(k,v))->k,v)
                |> Array.sortBy fst
                |> FSharpSpecification.bindShapes (name.ToLower())
                |> String.concat "\r\n"

            File.WriteAllText(tgt, outp, Encoding.UTF8)
            output.WriteLine("生成新文件:")
            output.WriteLine(tgt)

            //countdownEvent.Signal() |> ignore
            tcs.SetResult()

        shapeStream.Subscribe(CompletionObserver complete)
        |> ignore

        tcs.Task

    //[<Fact>]
    //member _.``fsharp to fsharp``() =
    //    let shapes = gains.Punctuation.punctuations

    //    let outp =
    //        shapes
    //        |> Seq.map(fun ((n,specs)) ->
    //            let lines = FSharpSpecification.listShape n specs
    //            n,lines
    //        )
    //        |> FSharpSpecification.bindShapes "punctuations"
    //        |> String.concat "\r\n"

    //    output.WriteLine(outp)

    //[<Fact>]
    //member _.``fsharp to SHP`` () =
    //    let tgt = Path.Combine(Dir.solutionPath, "punctuation", "punctuations.SHP")
    //    let shapes = gains.Punctuation.punctuations

    //    let titleLine = 
    //        shapes.Length
    //        |> BigFont.replace "*BIGFONT 7071,1,0A1,0FE" 

    //    let outp = 
    //        [
    //            titleLine
    //            "*0,4"
    //            "127,0,0,0"
    //            for (num, specs) in shapes do
    //                let bytes =
    //                    specs
    //                    |> List.collect(fun spec -> spec.getBytes())
    //                    |> SpecificationUtils.fromStartToEndBytes 127y
    //                SHP.renderSHP num bytes
    //            ""
    //        ]
    //        |> String.concat "\r\n"

    //    File.WriteAllText(tgt, outp, Encoding.ASCII)
    //    output.WriteLine("生成新文件:")
    //    output.WriteLine(tgt)


