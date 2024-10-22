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

type ShapesCompilerTest(output:ITestOutputHelper) =

    [<Theory>]
    [<InlineData("scale/chin2")>]
    [<InlineData("scale/design")>]
    [<InlineData("scale/SBHZ")>]
    [<InlineData("scale/tssdchn")>]
    [<InlineData("scale/XDX")>]
    member _.``print spec``(filename : string) =
        let name = Path.GetFileNameWithoutExtension(filename)
        let src = Path.Combine(Dir.solutionPath, filename+".SHP")
        let tgt = Path.Combine(Dir.solutionPath, filename+".shape")
        let lines = 
            File.ReadAllLines(src,Encoding.UTF8)

        let groups =
            (ShapesCompiler.parse lines)
                .ToObservable()
                .SelectMany(fun (lines) -> task {
                    return GroupType.from lines
                    })

        let mutable ranges = []
        let bigFont =
            groups
                .Where(fun group ->
                    match group with
                    | BigFont rg -> 
                        ranges <- rg
                        true
                    | _ -> false
                )
                .Do(fun group ->
                    match group with
                    | BigFont rg -> 
                        ranges <- rg
                    | _ -> ()
                )
                .Select(fun x -> -1)

        let mutable height = -1
        let mutable width = -1
        let zero =
            groups
                .Where(fun group ->
                    match group with
                    | Zero _ -> true
                    | _ -> false
                )
                .Do(fun group ->
                    match group with
                    | Zero [h;_;0;0] -> 
                        height <- h
                        width <- h
                    | Zero [h;_;w;0] ->
                        height <- h
                        width <- w
                    | _ -> ()
                )
                .Select(fun x -> 0)

        let dict = Dictionary<_,_>()
        let shapeDefs =
            groups
                .Where(fun group ->
                    match group with
                    | ShapeDef _ -> true
                    | _ -> false
                )
                .Select(fun group ->
                    match group with
                    | ShapeDef (i,specs) -> i,specs
                    | _ -> 0us,[]
                )
                ///在此执行任何映射操作
                .Synchronize()
                .Do(fun (num,specs) -> dict.Add(num,specs))
                .Select(fst>>int)

        let tcs = TaskCompletionSource()
        //let countdownEvent = new CountdownEvent(3)

        let complete () =
            let mp =
                dict
                |> Map.fromInterface

            output.WriteLine(stringify ranges)
            output.WriteLine(stringify (height,width))
            for KeyValue(k,v) in mp do
                output.WriteLine(stringify k)
                output.WriteLine(stringify v)

            //let outp = SpecificationUtils.fileShape ranges fontHeight dict
            //File.WriteAllText(path, outp, Encoding.UTF8)
            //output.WriteLine("生成新文件:")
            //output.WriteLine(path)
            //countdownEvent.Signal() |> ignore
            tcs.SetResult()

        Observable
            .Merge(bigFont,zero,shapeDefs)
            .Subscribe({
            new IObserver<_> with
                member this.OnNext i = ()
                member this.OnError err = ()
                member this.OnCompleted() = complete () 
        })
        |> ignore

        tcs.Task
