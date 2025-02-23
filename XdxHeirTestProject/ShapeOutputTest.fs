namespace XdxHeirTestProject

open shpParser
open Xunit
open Xunit.Abstractions

open System.IO
open System.Text

open FSharp.Idioms.Literal
open System.Threading.Tasks
open System.Reactive.Linq

type ShapeOutputTest (output:ITestOutputHelper) =
    [<Fact(
        Skip = "输出不常变化"
        )>]
    member _.``打印汉字集`` () =
        let shapes =
            XdxShape.getAllOfShapes()
            |> List.map(fun (num,_) -> GBK.hanzi num)
            |> List.chunkBySize 20
            |> List.map(fun ls -> System.String(List.toArray ls) )
        let content = shapes |> String.concat "\r\n"
        let filePath = Path.Combine(Dir.outputs,"hanzi.txt")
        File.WriteAllText(filePath, content, Encoding.UTF8)
        output.WriteLine("生成新文件:")
        output.WriteLine(filePath)

    [<Fact>]
    member _.``fsharp to borders SHP`` () =
        let chunks = XdxShape.getChunks()
        SHP.bordersBytes output.WriteLine chunks

    [<Fact>]
    member _.``fsharp to normal SHP`` () =
        let chunks = XdxShape.getChunksWithPunctuations()
        XdxShape.getBytesFile output.WriteLine chunks

    [<Fact>]
    member _.``查找短线段`` () =
        let shapes =
            XdxShape.getAllOfShapes()
            |> List.choose(fun(n,specs) ->
                match 
                    specs
                    |> List.filter(fun spec -> 
                        match spec with
                        | Displacement(x,y) when abs (int x) + abs (int y) < 4 -> true
                        | _ -> false
                    )
                with
                | [] -> None
                | specs -> Some(n,specs)
            )
        for (n,specs) in shapes do
            output.WriteLine($"{n}:")
            for spec in specs do
                output.WriteLine(stringify spec)
