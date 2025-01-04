module XdxHeirTestProject.XdxShape

open shpParser

open System.IO
open System.Text
open System
open System.Threading.Tasks
open System.Reactive.Linq

open FSharp.Idioms

let getAllOfShapes () = [
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

let getBytesFile (writeLine:string->unit) (shapes:(uint16*Specification list)list) =
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
                    |> XdxSpecifications.altogether
                    |> List.collect(fun spec -> spec.getBytes())
                    
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

        let filePath = Path.Combine(Dir.outputs,"gbk.shp")
        File.WriteAllText(filePath, outp, Encoding.ASCII)
        writeLine("生成新文件:")
        writeLine(filePath)
        tcs.SetResult()

    let obs = FSharp.Idioms.CompletionObserver complete
    shapeStream.Subscribe(obs)
    |> ignore

    tcs.Task
