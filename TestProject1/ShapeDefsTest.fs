namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type ShapeDefsTest(output:ITestOutputHelper) =
    [<Fact>]    
    member _.``File Def get Title``() =
        let file =
            {
                title = "BIGFONT 7447,4,161,163,166,167,169,169,176,247"
                shapes = []
            }

        let y = file.getTitle(100)
        let e = "BIGFONT 100,4,161,163,166,167,169,169,176,247"
        Should.equal e y

    [<Theory>]
    [<InlineData("*0,4,HZ..YI.XUN 2/22/88")>]
    [<InlineData("14,0,0,0")>]
    [<InlineData("*1,2")>]
    [<InlineData("5,0")>]
    [<InlineData("*10,5")>]
    [<InlineData("2,8,(0,-20),0")>]
    [<InlineData("*13,2")>]
    [<InlineData("6,0")>]
    [<InlineData("*32,5")>]
    [<InlineData("2,8,(18,0),0")>]
    [<InlineData("*33,159")>]
    member _.StringSplit2(x : string) =
        let y = 
            x.Split([|','|],2)
        output.WriteLine(stringify y)

    [<Theory>]
    [<InlineData("44B.SHP")>]
    [<InlineData("B36.SHP")>]
    [<InlineData("DESIGN.SHP")>]
    [<InlineData("CHIN2.SHP")>]
    [<InlineData("tssdchn.shp")>]
    member _.``Practice exercises``(filename : string) =
        let path = Path.Combine(Dir.solutionPath, filename)
        let lines = File.ReadAllLines(path, Encoding.UTF8)

        let y = 
            lines
            |> ShapeDefsCompiler.parse
            |> FileDef.from

        let ls =
            y.shapes
            |> List.map(fun s -> s.shapenumber)
            |> List.sort
        output.WriteLine($"shapes:{ls.Length}")
        for i in ls do
        output.WriteLine($"{i}")

    [<Fact>]
    member _.``generate chin3 from chin2``() =        
        let path = Path.Combine(Dir.solutionPath, "CHIN2.SHP")
        let lines = File.ReadAllLines(path, Encoding.UTF8)

        let y = 
            lines
            |> ShapeDefsCompiler.parse
            |> FileDef.from

        let ls =
            y.shapes
            |> List.filter(fun s -> s.shapenumber < 33 || s.shapenumber > 127)
            |> List.sortBy(fun s -> s.shapenumber)

        let newfile =
            {
                title = y.getTitle(ls.Length)
                shapes = ls
            }

        let outp = newfile.render()

        let path = Path.Combine(Dir.solutionPath, "CHIN3.SHP")
        File.WriteAllText(path, outp, Encoding.ASCII)
        output.WriteLine("生成新文件:")
        output.WriteLine(path)

    [<Fact>]
    member this.Hanzi() =
        let i = 0xB2E2
        let c = "测"

        let chars = GBK.hanzi(i)
        output.WriteLine(chars)

        Should.equal c chars

        let y = GBK.code c
        Should.equal i y

    [<Theory>]
    [<InlineData("SHP/tssdchn.shp")>]
    member _.``print GBK``(filename : string) =
        let path = Path.Combine(Dir.solutionPath, filename)
        let lines = File.ReadAllLines(path, Encoding.UTF8)

        let y = 
            lines
            |> ShapeDefsCompiler.parse
            |> FileDef.from

        let ls =
            y.shapes
            |> List.map(fun s -> s.shapenumber)
            |> List.filter(fun n -> n > 127)
            |> List.sort
            |> List.map(GBK.hanzi )
            |> List.chunkBySize 80
            |> List.map (String.concat "")
            |> String.concat "\r\n"
        
        //output.WriteLine($"总数：{ls.Length}")
        //let sb = StringBuilder()
        //for i in ls do
        //    sb.Append(i) |> ignore
        //output.WriteLine(sb.ToString())
        let path = Path.Combine(Dir.solutionPath, "gbk.txt")
        File.WriteAllText(path, ls, Encoding.UTF8)
        output.WriteLine("生成新文件:")
        output.WriteLine(path)
