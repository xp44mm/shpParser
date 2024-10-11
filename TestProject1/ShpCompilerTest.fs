namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms


type ShpCompilerTest(output:ITestOutputHelper) =

    [<Theory>]
    [<InlineData("44B.SHP")>]
    [<InlineData("B36.SHP")>]
    member _.``tokenize``(filename : string) =
        let path = Path.Combine(Dir.solutionPath, filename)
        let text = File.ReadAllText(path, Encoding.UTF8)
        let y = 
            text
            |> ShpTokenUtils.tokenize 0
            |> Seq.toList

        output.WriteLine($"{y}")




    [<Theory>]
    [<InlineData("DESIGN.SHP")>]
    member _.``Practice exercises``(filename : string) =
        let path = Path.Combine(Dir.solutionPath, filename)
        let text = File.ReadAllText(path, Encoding.UTF8)
        let y = ShpCompiler.parse text
        output.WriteLine($"{y}")

