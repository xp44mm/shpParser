namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms
open System.Threading.Tasks
open System.Reactive
open System.Reactive.Linq
open FSharp.Idioms
open System.Collections.Generic
open System.Collections.Concurrent

open FSharp.Idioms.OrdinalIgnoreCase
open System.Reactive.Threading.Tasks
open System.Reactive.Linq
open System.Threading
open System.Numerics

type OctantTest(output:ITestOutputHelper) =

    [<Theory>]
    [<InlineData(-0x32)>]
    [<InlineData(0x12)>]
    member _.``parseSC``(sc : int) =
        let wise, s, spans = Octant.parseSC sc
        let s = s // Math.PI * 180.
        let spans = spans // Math.PI * 180.

        //output.WriteLine(wise)
        output.WriteLine(stringify s)
        output.WriteLine(stringify spans)

    [<Theory>]
    [<InlineData(56,28,0x12)>]
    member _.``parseOffsetSC``(start_offset, end_offset, sc : int) =
        let wise, s, c = Octant.parseOffsetSC start_offset end_offset sc
        let s = s / Math.PI * 180.
        let c = c / Math.PI * 180.

        //output.WriteLine(wise)
        output.WriteLine(stringify s)
        output.WriteLine(stringify c)

    [<Theory>]
    [<InlineData(1,-0x32)>]
    //[<InlineData(3, 0x12)>]
    member _.``get radius vector``(r, sc : int) =
        let wise, s, spans = Octant.parseSC sc

        let os = Complex.FromPolarCoordinates(r,s)
        let e = s + Math.Abs sc 
        let oe = Complex.FromPolarCoordinates(r, float e)

        output.WriteLine($"{os.Magnitude},{os.Phase}")
        output.WriteLine($"{oe.Magnitude},{oe.Phase}")

        //output.WriteLine(stringify s)
        //output.WriteLine(stringify spans)


    [<Fact>]
    member this.``中文标点符号GBK码``() =
        let s = "。？！，、；：“”‘’（）—…《》"

        for c in s do
        output.WriteLine($"{c}")
        let y = GBK.code c
        output.WriteLine($"{y}")

    [<Fact>]
    member this.``所有中文标点符号``() =
        let y =
            Punctuation.Shapes
            |> Punctuation.getBytes
            |> Map.toList
            |> List.map(fun (c,bytes) -> GBK.code c,bytes)
            |> List.sortBy fst

        for (number,bytes) in y do
            let outp = SHP.renderSHP number bytes
            output.WriteLine outp

