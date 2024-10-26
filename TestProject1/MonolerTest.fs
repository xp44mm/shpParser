namespace shpParser
//"D:\Application Data\AutoCAD\Fonts\MONOLER.SHP"

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

type MonolerTest(output:ITestOutputHelper) =

    [<Theory>]
    [<InlineData("SHX/MONOLER")>]
    member _.``shape spec``(filename : string) =        
        let src = Path.Combine(Dir.solutionPath, filename+".SHP")
        let tgt = Path.Combine(Dir.solutionPath, filename+".shape")

        let groups =
            (
                File.ReadAllLines(src,Encoding.UTF8)
                |> ShapesCompiler.parse
            )
                .ToObservable()
                .SelectMany(fun (lines) -> task {
                    return BlobGroup.from lines
                    })

        let mutable title = ""
        let bigFont =
            groups
                .Where(fun group ->
                    match group with
                    | BlobTitle _ -> true
                    | _ -> false
                )
                .Do(fun group ->
                    match group with
                    | BlobTitle rg -> title <- rg
                    | _ -> ()
                )
                .Select(fun x -> -1)

        let mutable zeroDef = []

        let zero =
            groups
                .Where(fun group ->
                    match group with
                    | BlobShape (0us,_) -> true
                    | _ -> false
                )
                .Do(fun group ->
                    match group with
                    | BlobShape (0us,x) -> zeroDef <- x
                    | _ -> ()
                )
                .Select(fun x -> 0)

        let dict = Dictionary<uint16,_>()
        let shapeDefs =
            groups
                .Where(fun group ->
                    match group with
                    | BlobShape (x,_) when x > 0us  -> true
                    | _ -> false
                )
                .Select(fun group ->
                    match group with
                    | BlobShape (i,specs) -> i,specs
                    | _ -> 0us,[]
                )
                ///在此执行任何映射操作
                .Select(fun (num,lines) ->
                    let specs =
                        lines
                        |> List.tail
                        |> Number.getIntListFromLines
                        |> SpecificationUtils.getSpecifications
                        //|> stringify

                    let render = SpecificationRender.renderSpecifications num specs
                    num, render
                )
                .Synchronize()
                .Do(fun (k,v) -> dict.Add(k,v))
                .Select(fst>>int)

        let tcs = TaskCompletionSource()
        //let countdownEvent = new CountdownEvent(3)

        let complete () =

            let zeroOutp =
                zeroDef
                |> String.concat "\r\n"

            let mp =
                dict
                |> Map.fromInterface

            let outp = ShapeFile.render title zeroOutp mp

            File.WriteAllText(tgt, outp, Encoding.UTF8)
            output.WriteLine("生成新文件:")
            output.WriteLine(tgt)

            //countdownEvent.Signal() |> ignore
            tcs.SetResult()

        Observable
            .Merge(bigFont,zero,shapeDefs)
            .Subscribe(CompletionObserver complete)
        |> ignore

        tcs.Task

    [<Theory>]
    [<InlineData("SHX/MONOLER")>]
    member _.``fsharp shape``(filename : string) =        
        let src = Path.Combine(Dir.solutionPath, filename+".SHP")
        let tgt = Path.Combine(Dir.solutionPath, filename+".fs")

        let groups =
            (
                File.ReadAllLines(src,Encoding.UTF8)
                |> ShapesCompiler.parse
            )
                .ToObservable()
                .SelectMany(fun (lines) -> task {
                    return BlobGroup.from lines
                    })

        let mutable titleLine = ""
        let title =
            groups
                .Where(fun group ->
                    match group with
                    | BlobTitle _ -> true
                    | _ -> false
                )
                .Do(fun group ->
                    match group with
                    | BlobTitle ln -> titleLine <- ln
                    | _ -> ()
                )
                .Select(fun x -> -1)

        let mutable zeroLines = []

        let zero =
            groups
                .Where(fun group ->
                    match group with
                    | BlobShape (0us,_) -> true
                    | _ -> false
                )
                .Do(fun group ->
                    match group with
                    | BlobShape (0us,lines) -> zeroLines <- lines
                    | _ -> ()
                )
                .Select(fun x -> 0)

        let dict = Dictionary<uint16,_>()
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
                .Select(fun (num,lines) ->
                    let specs =
                        lines
                        |> List.tail
                        |> Number.getIntListFromLines
                        |> SpecificationUtils.getSpecifications

                    let render = FSharpSpecification.renderShape num specs
                    num, render
                )
                .Synchronize()
                .Do(fun (k,v) -> dict.Add(k,v))
                .Select(fst>>int)

        let tcs = TaskCompletionSource()
        //let countdownEvent = new CountdownEvent(3)

        let complete () =
            let shapes =
                dict
                |> Map.fromInterface

            let outp = 
                [
                    yield! FSharpSpecification.moduleHeadLines "Monoler"
                    yield FSharpSpecification.titleLines titleLine
                    yield! FSharpSpecification.zeroLines zeroLines
                    yield! FSharpSpecification.shapesLines shapes
                ]
                |> String.concat "\r\n"

            File.WriteAllText(tgt, outp, Encoding.UTF8)
            output.WriteLine("生成新文件:")
            output.WriteLine(tgt)

            //countdownEvent.Signal() |> ignore
            tcs.SetResult()

        Observable
            .Merge(title,zero,shapeDefs)
            .Subscribe(CompletionObserver complete)
        |> ignore

        tcs.Task
