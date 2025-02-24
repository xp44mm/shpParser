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
    [<Fact>]
    member _.``fsharp to borders SHP`` () =
        let chunks = XdxShape.getChunks()
        SHP.bordersBytes output.WriteLine chunks

    [<Fact>]
    member _.``fsharp to normal SHP`` () =
        let chunks = XdxShape.getChunksWithPunctuations()
        XdxShape.getBytesFile output.WriteLine chunks

