module XdxHeirTestProject.XdxShape

open shpParser

open System.IO
open System.Text
open System
open System.Threading.Tasks
open System.Reactive.Linq

open FSharp.Idioms

let getChunks() = [
    Xdx00.chunk
    Xdx01.chunk
    Xdx02.chunk
    Xdx03.chunk
    Xdx04.chunk
    Xdx05.chunk
    Xdx06.chunk
    Xdx07.chunk
    Xdx08.chunk
    Xdx09.chunk
    Xdx10.chunk
    Xdx11.chunk
    Xdx12.chunk
    Xdx13.chunk
    Xdx14.chunk
    Xdx15.chunk
    Xdx16.chunk
    Xdx17.chunk
    Xdx18.chunk
    Xdx19.chunk
    ]

let getChunksWithPunctuations() =
    [
        gains.Punctuation.punctuations
        yield! getChunks()
    ]

let getAllOfShapes () = 
    getChunks()
    |> List.collect id

let getBytesFile (writeLine:string->unit) (chunks:(uint16*Specification list)list list) =
    let arr = ResizeArray<uint16*_>()
    let shapeStream =
        chunks
            .ToObservable()
            .SelectMany(fun ck -> ck.ToObservable())
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
        let titleLine = 
            arr.Count
            |> BigFont.replace BigFont.template

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
        writeLine("测试时间:"+System.DateTime.Now.ToShortTimeString())
        writeLine("生成新文件:")
        writeLine(filePath)
        tcs.SetResult()

    let obs = FSharp.Idioms.CompletionObserver complete
    shapeStream.Subscribe(obs)
    |> ignore

    tcs.Task
