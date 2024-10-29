namespace DesignTestProject
open shpParser
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

type DesignTest(output:ITestOutputHelper) =
    [<Fact>]
    member _.``shp to fsharp``() =
        let source = @"min\design"
        let src = Path.Combine(Dir.solutionPath, source+".SHP")
        let tgt = Path.GetDirectoryName(src)
        let name = Path.GetFileNameWithoutExtension source
        
        let arr = ResizeArray<uint16*_>(8000)
        let shapeStream =
            (
                File.ReadAllLines(src,Encoding.UTF8)
                |> ShapesCompiler.parse
            )
                .ToObservable()
                .SelectMany(fun (lines) -> task {
                    return BlobGroup.from lines
                    })

                .Where(fun group ->
                    match group with
                    | BlobShape (num,_) when num > 0us -> true
                    | _ -> false
                )
                .Select(fun group ->
                    match group with
                    | BlobShape (num,lines) -> num,lines
                    | _ -> 0us,[]
                )
                // 在此执行任何映射操作
                .Select(fun (num,lines) ->
                    let specs =
                        lines
                        |> List.tail
                        |> Number.getIntListFromLines
                        |> SpecificationUtils.getSpecifications
                        |> SpecificationUtils.trimPushPop
                        |> List.filter(fun spec ->
                            match spec with
                            | Displacement(0y,0y) -> false
                            | _ -> true
                        )
                    // fsharp 源代码
                    let fs = FSharpSpecification.listShape num specs
                    num, fs
                )
                .Synchronize()
                .Do(arr.Add)

        //let countdownEvent = new CountdownEvent(3)
        let tcs = TaskCompletionSource()

        let complete () =
            let chunks = SHP.chunks arr
            chunks
            |> Seq.iteri(fun i chunk ->
                let tgt = Path.Combine(tgt, $"Design{i}.fs")
                let outp = SHP.renderModule i chunk
                File.WriteAllText(tgt, outp, Encoding.UTF8)
                output.WriteLine(tgt)
            )

            //countdownEvent.Signal() |> ignore
            tcs.SetResult()

        shapeStream.Subscribe(CompletionObserver complete)
        |> ignore

        tcs.Task

    //[<Fact>]
    //member _.``fsharp to SHP`` () =
