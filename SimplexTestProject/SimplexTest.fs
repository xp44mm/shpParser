namespace SimplexTestProject
open shpParser
open Xunit
open Xunit.Abstractions

open System.IO
open System.Text

open FSharp.Idioms
open System.Threading.Tasks
open System.Reactive.Linq

type SimplexTest(output:ITestOutputHelper) =
    let target = Path.Combine(Dir.solutionPath, "simplex")

    [<Theory>]
    [<InlineData("Monoler")>]
    [<InlineData("Simplex")>]
    [<InlineData("Monosimp")>]
    [<InlineData("Monors")>]
    member _.``SHP to fsharp``(filename: string) =
        let src = Path.Combine(Dir.solutionPath, "shx", filename+".SHP")

        let arr = ResizeArray<uint16*_>(255)

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
                    | BlobShape (num,_) when 0us < num && num < 127us -> true
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
                        |> List.filter(function VerticalText _ -> false | _ -> true)
                        |> List.collect(fun spec -> spec.dissolveManyDisp())

                    // fsharp 源代码
                    let fs = FSharpSpecification.listShape num specs
                    num, fs
                )
                .Synchronize()
                .Do(arr.Add)

        //let countdownEvent = new CountdownEvent(3)
        let tcs = TaskCompletionSource()

        let complete () =

            let target = Path.Combine(target, $"{filename}.fs")
            let outp = SHP.renderModule filename arr
            File.WriteAllText(target, outp, Encoding.UTF8)
            output.WriteLine(target)

            //countdownEvent.Signal() |> ignore
            tcs.SetResult()

        shapeStream.Subscribe(CompletionObserver complete)
        |> ignore

        tcs.Task

    [<Fact>]
    member _.``monors92 fsharp to SHP`` () =
        let tgt = Path.Combine(Dir.solutionPath, "punctuation", "monors92.SHP")

        let shapes = MonorsUtils.getRs92()
        let outp = MonorsUtils.fileSHP shapes
        File.WriteAllText(tgt, outp, Encoding.ASCII)
        output.WriteLine("生成新文件:")
        output.WriteLine(tgt)
        
