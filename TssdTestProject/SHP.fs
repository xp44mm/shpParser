module TssdTestProject.SHP
open shpParser

open System.IO
open System.Text
open System
open System.Threading.Tasks
open System.Reactive.Linq

open FSharp.Idioms

//open System.Collections.Generic

let fromFSharp (writeLine:string->unit) (shapes:(uint16*Specification list)list) =
    let tgt = Path.Combine(Dir.solutionPath, "punctuation", "tssdchn.SHP")

    let titleLine = 
        shapes.Length
        |> BigFont.replace BigFont.template

    let arr = ResizeArray<uint16*_>()
    let shapeStream =
        shapes
            .ToObservable()
            .SelectMany(fun (num,specs) -> task {
                let bytes =
                    specs
                    |> List.collect(fun spec -> spec.getBytes())
                    |> SpecificationUtils.fromStartToEndBytes 127y
                return num, SHP.renderSHP num bytes
                })
            .Synchronize()
            .Do(arr.Add)
    //let countdownEvent = new CountdownEvent(3)
    let tcs = TaskCompletionSource()

    let complete () =
        let outp = 
            seq {
                titleLine
                "*0,4"
                "127,0,0,0"
                yield! 
                    arr.ToArray()
                    |> Array.sortBy fst
                    |> Array.map snd
                ""
            }
            |> String.concat "\r\n"

        File.WriteAllText(tgt, outp, Encoding.ASCII)
        writeLine("生成新文件:")
        writeLine(tgt)
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
        $"module TssdTestProject.Tssd%02d{i}"
        "open shpParser"
        yield!
            chunk
            |> FSharpSpecification.bindShapes "chunk"
    ]
    |> String.concat "\r\n"
