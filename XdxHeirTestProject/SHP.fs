module XdxHeirTestProject.SHP
open shpParser

open System.IO
open System.Text
open System
open System.Threading.Tasks
open System.Reactive.Linq

open FSharp.Idioms


let bordersBytes (writeLine:string->unit) (shapes:(uint16*Specification list)list) =
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
                    |> XdxSpecifications.bordersBytes
                return num, SHP.renderSHP num bytes
                })
            .Synchronize()
            .Do(arr.Add)

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

        let filePath = Path.Combine(Dir.outputs,"border.shp")
        File.WriteAllText(filePath, outp, Encoding.ASCII)
        writeLine("生成新文件:")
        writeLine(filePath)
        tcs.SetResult()

    let obs = FSharp.Idioms.CompletionObserver complete
    shapeStream.Subscribe(obs)
    |> ignore

    tcs.Task

let chunks (arr:ResizeArray<uint16*string list>) =
    arr.ToArray()
    |> Array.sortBy fst
    |> Array.chunkBySize (arr.Count / 20 + 1)

let renderModule (i:int) chunk =
    [
        $"module XdxHeirTestProject.Xdx%02d{i}"
        "open shpParser"
        yield!
            chunk
            |> FSharpSpecification.bindShapes "chunk"
    ]
    |> String.concat "\r\n"
