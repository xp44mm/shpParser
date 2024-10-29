namespace XdxTestProject
open shpParser
open Xunit
open Xunit.Abstractions

open System.IO
open System.Text

open FSharp.Idioms
open System.Threading.Tasks
open System.Reactive.Linq

type XdxTest(output:ITestOutputHelper) =
    [<Fact>]
    member _.``SHP to fsharp``() =
        let source = @"min\xdx"
        let src = Path.Combine(Dir.solutionPath, source+".SHP")
        let tgt = Path.GetDirectoryName(src)
        let mincode = GBK.code '啊'

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
                    | BlobShape (num,_) when num >= mincode -> true
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
                let tgt = Path.Combine(tgt, $"Xdx%02d{i}.fs")
                let outp = SHP.renderModule i chunk
                File.WriteAllText(tgt, outp, Encoding.UTF8)
                output.WriteLine(tgt)
            )

            //countdownEvent.Signal() |> ignore
            tcs.SetResult()

        shapeStream.Subscribe(CompletionObserver complete)
        |> ignore

        tcs.Task

    [<Fact>]
    member _.``fsharp to SHP`` () =
        let shapes = [
            yield! gains.Punctuation.punctuations
            yield! Xdx00.chunk
            yield! Xdx01.chunk
            yield! Xdx02.chunk
            yield! Xdx03.chunk
            yield! Xdx04.chunk
            yield! Xdx05.chunk
            yield! Xdx06.chunk
            yield! Xdx07.chunk
            yield! Xdx08.chunk
            yield! Xdx09.chunk
            yield! Xdx10.chunk
            yield! Xdx11.chunk
            yield! Xdx12.chunk
            yield! Xdx13.chunk
            yield! Xdx14.chunk
            yield! Xdx15.chunk
            yield! Xdx16.chunk
            yield! Xdx17.chunk
            yield! Xdx18.chunk
            yield! Xdx19.chunk
            ]

        SHP.fromFSharp output.WriteLine shapes
