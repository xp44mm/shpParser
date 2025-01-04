namespace XdxHeirTestProject

open shpParser
open Xunit
open Xunit.Abstractions

open System.IO
open System.Text

open FSharp.Idioms
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
        let shapes =
            XdxShape.getAllOfShapes()
        output.WriteLine("测试开始时间:"+System.DateTime.Now.ToShortTimeString())
        SHP.bordersBytes output.WriteLine shapes
    [<Fact>]
    member _.``fsharp to normal SHP`` () =
        let shapes =
            XdxShape.getAllOfShapes()
        output.WriteLine("测试开始时间:"+System.DateTime.Now.ToShortTimeString())
        XdxShape.getBytesFile output.WriteLine shapes

