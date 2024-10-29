namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type BigFontTest(output:ITestOutputHelper) =
    [<Theory>]
    [<InlineData("BIGFONT 7219,4,0A1,0A3,0A6,0A7,0A9,0A9,0B0,0F7")>]
    member this.Code(temp:string) =
        let y = BigFont.replace temp 99
        output.WriteLine(y)


