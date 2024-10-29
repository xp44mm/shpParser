namespace Chin2TestProject
open shpParser
open Xunit
open Xunit.Abstractions

open System.IO
open System.Text

open FSharp.Idioms
open System.Threading.Tasks
open System.Reactive.Linq

type Chin2Test(output:ITestOutputHelper) =
    [<Fact>]
    member _.``SHP to fsharp``() =
        let source = @"min\chin2"
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
                let tgt = Path.Combine(tgt, $"Chin2_%02d{i}.fs")
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
            yield! Chin2_00.chunk
            yield! Chin2_01.chunk
            yield! Chin2_02.chunk
            yield! Chin2_03.chunk
            yield! Chin2_04.chunk
            yield! Chin2_05.chunk
            yield! Chin2_06.chunk
            yield! Chin2_07.chunk
            yield! Chin2_08.chunk
            yield! Chin2_09.chunk
            yield! Chin2_10.chunk
            yield! Chin2_11.chunk
            yield! Chin2_12.chunk
            yield! Chin2_13.chunk
            yield! Chin2_14.chunk
            yield! Chin2_15.chunk
            yield! Chin2_16.chunk
            yield! Chin2_17.chunk
            yield! Chin2_18.chunk
            yield! Chin2_19.chunk
            ]

        SHP.fromFSharp output.WriteLine shapes
