namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type ShpFileDefTest (output:ITestOutputHelper) =
    let getShpFileDef (filename : string) =
        let path = Path.Combine(Dir.solutionPath, "SHP", filename+".SHP")
        let lines = File.ReadAllLines(path, Encoding.UTF8)

        lines
        |> ShapeDefsCompiler.parse
        |> ShpFileDef.from

    [<Theory>]
    [<InlineData("hei")>]
    [<InlineData("kai")>]
    [<InlineData("song")>]
    [<InlineData("fang")>]

    member _.``format shp``(filename : string) =
        let ss = getShpFileDef filename
        let outp = stringify ss

        let path = Path.Combine(Dir.solutionPath, "SHP", filename+".shape")
        File.WriteAllText(path, outp, Encoding.ASCII)
        output.WriteLine("生成新文件:")
        output.WriteLine(path)
