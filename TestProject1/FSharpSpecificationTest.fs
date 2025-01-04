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

type FSharpSpecificationTest(output:ITestOutputHelper) =

    [<Theory>]
    [<InlineData("disp/chin2")>]
    [<InlineData("disp/design")>]
    [<InlineData("disp/SBHZ")>]
    [<InlineData("disp/tssdchn")>]
    [<InlineData("disp/XDX")>]
    member _.``获取字符全集``(source: string) =
        let name = Path.GetFileNameWithoutExtension source
        let src = Path.Combine(Dir.solutionPath, source+".SHP")
        let tgt = Path.Combine(Dir.solutionPath,"gbk", name+".txt")
        
        let groups =
            (
                File.ReadAllLines(src,Encoding.UTF8)
                |> ShapesCompiler.parse
            )
                .ToObservable()
                .SelectMany(fun (lines) -> task {
                    return BlobGroup.from lines
                    })

        let st = HashSet<uint16>(HashIdentity.Structural)

        let shapeDefs =
            groups
                .Where(fun group ->
                    match group with
                    | BlobShape (x,_) when x > 0us -> true
                    | _ -> false
                )
                .Select(fun group ->
                    match group with
                    | BlobShape (num,lines) -> num,lines
                    | _ -> 0us,[]
                )
                ///在此执行任何映射操作
                .Select(fun (num,lines) -> num
                )
                .Synchronize()
                .Do(fun num -> st.Add num |> ignore)

        let tcs = TaskCompletionSource()
        //let countdownEvent = new CountdownEvent(3)

        let complete () =
            let outp = 
                st
                |> Set.ofHashSet
                |> Set.toArray
                |> Array.map(GBK.hanzi)
                |> String

            File.WriteAllText(tgt, outp, Encoding.UTF8)
            output.WriteLine("生成新文件:")
            output.WriteLine(tgt)

            //countdownEvent.Signal() |> ignore
            tcs.SetResult()

        shapeDefs.Subscribe(CompletionObserver complete)
        |> ignore

        tcs.Task

    [<Fact>]
    member _.``汇总字符全集``() =
        let folder = Path.Combine(Dir.solutionPath, "gbk")
        let files = [
           "chin2"
           "design"
           "SBHZ"
           "tssdchn"
           "XDX"
        ]

        let getChars (file:string) =
            let src = Path.Combine(folder, file+".txt")
            let txt = File.ReadAllText src
            txt.ToCharArray()

        let fullcodes =
            files
            |> Seq.collect getChars
            |> Seq.map(GBK.code)
            |> Set.ofSeq

        /// 按gbk码排序
        let outp = 
            fullcodes
            |> Set.toArray
            |> Array.map(GBK.hanzi)
            |> String

        let tgt = Path.Combine(folder,"汇总字符全集.txt")
        File.WriteAllText(tgt, outp, Encoding.UTF8)
        output.WriteLine("生成新文件:")
        output.WriteLine(tgt)

    [<Theory>]
    [<InlineData("disp/chin2")>]
    [<InlineData("disp/design")>]
    [<InlineData("disp/SBHZ")>]
    [<InlineData("disp/tssdchn")>]
    [<InlineData("disp/XDX")>]
    member _.``map to min from disp``(filename : string) =        
        let src = Path.Combine(Dir.solutionPath, filename+".SHP")

        let name = Path.GetFileNameWithoutExtension(filename)
        let tgt = Path.Combine(Dir.solutionPath, "min", name+".shp")

        let fullcodes =
            let src = Path.Combine(Dir.solutionPath, @"gbk\min.txt")
            let txt = File.ReadAllText src
            txt.ToCharArray()
            |> Array.map(GBK.code)
            |> Set.ofArray

        let mainStream =
            (
                File.ReadAllLines(src,Encoding.UTF8)
                |> ShapesCompiler.parse
            )
                .ToObservable()
                .SelectMany(fun (lines) -> task {
                    return BlobGroup.from lines
                    })

        let mutable titleLine = ""
        let titleStream =
            mainStream
                .Where(fun group ->
                    match group with
                    | BlobTitle _ -> true
                    | _ -> false
                )
                .Do(fun group ->
                    match group with
                    | BlobTitle ln -> titleLine <- "*"+ln
                    | _ -> ()
                )
                .Select(fun x -> -1)

        let mutable zeroLines = []

        let zeroStream =
            mainStream
                .Where(fun group ->
                    match group with
                    | BlobShape (0us,_) -> true
                    | _ -> false
                )
                .Do(fun group ->
                    match group with
                    | BlobShape (0us,lns) ->                        
                        zeroLines <- "*"+lns.Head::lns.Tail
                    | _ -> ()
                )
                .Select(fun x -> 0)

        let dict = Dictionary<uint16,_>()
        let shapeStream =
            mainStream
                .Where(fun group ->
                    match group with
                    | BlobShape (x,_) when x > 0us  -> true
                    | _ -> false
                )
                .Select(fun group ->
                    match group with
                    | BlobShape (i,lines) -> i,lines
                    | _ -> 0us,[]
                )
                ///在此执行任何映射操作
                .Where(fun(num,lines)-> fullcodes.Contains num)
                .Select(fun (num,lines) -> 
                    num, "*"+lines.Head::lines.Tail       
                    )
                .Synchronize()
                .Do(fun (k,v) -> dict.Add(k,v))
                .Select(fst>>int)

        let tcs = TaskCompletionSource()
        //let countdownEvent = new CountdownEvent(3)

        let complete () =
            let mp =
                dict
                |> Map.fromInterface
            let titleline = BigFont.replace titleLine mp.Count

            let outp = 
                [
                    yield titleLine
                    yield! zeroLines
                    for KeyValue(_,lines) in mp do
                        yield! lines
                ]
                |> String.concat "\r\n"
            File.WriteAllText(tgt, outp, Encoding.UTF8)
            output.WriteLine("生成新文件:")
            output.WriteLine(tgt)

            //countdownEvent.Signal() |> ignore
            tcs.SetResult()

        Observable
            .Merge(titleStream,zeroStream,shapeStream)
            .Subscribe(CompletionObserver complete)
        |> ignore

        tcs.Task

    [<Theory>]
    [<InlineData("min/chin2")>]
    [<InlineData("min/design")>]
    [<InlineData("min/SBHZ")>]
    [<InlineData("min/tssdchn")>]
    [<InlineData("min/XDX")>]
    member _.``shp to fsharp``(source : string) =
        let name = Path.GetFileNameWithoutExtension source
        let src = Path.Combine(Dir.solutionPath, source+".SHP")
        let tgt = Path.Combine(Dir.solutionPath,source+".fs")
        
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
                    | BlobShape (x,_) when x > 0us -> true
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
    //        |> Seq.toArray
    //        |> Array.map(fun (n,specs) ->
    //            //let n = GBK.code c
    //            let lines = FSharpSpecification.listShape n specs
    //            n,lines
    //        )
    //        |> Array.sortBy fst
    //        |> FSharpSpecification.bindShapes "xxx"
    //        |> String.concat "\r\n"

    //        //File.WriteAllText(tgt, outp, Encoding.UTF8)
    //        //output.WriteLine("生成新文件:")
    //    output.WriteLine(outp)
