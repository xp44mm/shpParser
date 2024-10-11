namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type ShapeDefsTest(output:ITestOutputHelper) =
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
            //|> List.map(fun s -> s.shapenumber)
            |> List.filter(fun s -> s.shapenumber = 0 || s.shapenumber > 127)
            |> List.sort

        let newfile =
            {
                title = y.title
                shapes = ls
            }

        let outp = 
            StringBuilder()
                .AppendLine($"new nchars = {ls.Length}")
                .Append(newfile.render())
                .ToString()

        let path = Path.Combine(Dir.solutionPath, "CHIN3.SHP")
        File.WriteAllText(path, outp, Encoding.ASCII)
        output.WriteLine("生成新文件:")
        output.WriteLine(path)


