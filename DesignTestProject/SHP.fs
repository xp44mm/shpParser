module DesignTestProject.SHP
open shpParser

open System.IO
open System.Text
open System

open FSharp.Idioms
open System.Threading.Tasks
open System.Reactive.Linq
open System.Collections.Generic

let fromFSharp (shapes:(uint16*Specification list)[]) =
    let tgt = Path.Combine(Dir.solutionPath, "punctuation", "design.SHP")

    let titleLine = 
        shapes.Length
        |> BigFont.replace BigFont.template

    let al = ResizeArray<uint16*_>()
    let shapeStream =
        shapes
            .ToObservable()
            .SelectMany(fun (num,specs) -> task {
                let bytes =
                    specs
                    |> List.collect(fun spec -> spec.getBytes())
                    |> SpecificationUtils.fromStartToEndBytes 100y
                return num, SHP.renderSHP num bytes
                })
            .Synchronize()
            .Do(al.Add)
    //let countdownEvent = new CountdownEvent(3)
    let tcs = TaskCompletionSource()

    let complete () =
        let outp = 
            seq {
                titleLine
                "*0,5"
                "127,0,0,100,0"
                yield! 
                    al.ToArray()
                    |> Array.sortBy fst
                    |> Array.map snd
                ""
            }
            |> String.concat "\r\n"

        File.WriteAllText(tgt, outp, Encoding.ASCII)
        Console.WriteLine("生成新文件:")
        Console.WriteLine(tgt)
        tcs.SetResult()

    shapeStream.Subscribe(CompletionObserver complete)
    |> ignore

    tcs.Task

let chunks (arr:ResizeArray<uint16*string list>) =
    arr.ToArray()
    |> Array.sortBy fst
    |> Array.chunkBySize (arr.Count / 20 + 1)

let renderModule (i:int) chunk =
    [
        $"module DesignTestProject.Design%02d{i}"
        "open shpParser"
        yield!
            chunk
            |> FSharpSpecification.bindShapes "chunk"
    ]
    |> String.concat "\r\n"
