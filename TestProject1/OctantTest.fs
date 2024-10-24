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
    member this.``中文破折号``() =
        let specs = [
            //Push
            PenUp
            Displacement(0y,63y)
            PenDown
            Displacement(127y,0y)
            //Pop
            //PenUp
            //Displacement(127y,0y)
            //EndOfShape
        ]

        let bytes =
            specs
            |> List.collect(fun spec -> spec.getBytes())        
            |> SpecificationUtils.fromStartToEndBytes 127y

        let number = 41386us
        let outp = SHP.renderSHP number bytes
        output.WriteLine outp
    

    [<Fact>]
    member this.``中文句号``() =
        let specs = [
            //Push
            PenUp
            Displacement(32y,32y)
            PenDown
            OctantArc(15uy,0x20y)
            //Pop
            //PenUp
            //Displacement(127y,0y)
            //EndOfShape
        ]

        let bytes =
            specs
            |> List.collect(fun spec -> spec.getBytes())        
            |> SpecificationUtils.fromStartToEndBytes 127y

        let number = 41379us
        let outp = SHP.renderSHP number bytes
        output.WriteLine outp

    [<Fact>]
    member this.``中文LPAREN``() =
        let specs = [
            //Push
            PenUp
            Displacement(95y,127y)
            PenDown
            BulgeArc(0y,-127y, 64y)
            //Pop
            //PenUp
            //Displacement(127y,0y)
            //EndOfShape
        ]

        let bytes =
            specs
            |> List.collect(fun spec -> spec.getBytes())        
            |> SpecificationUtils.fromStartToEndBytes 127y

        let number = uint16 41896
        let outp = SHP.renderSHP number bytes
        output.WriteLine outp
    
    [<Fact>]
    member this.``中文RPAREN``() =
        let number = uint16 41897
        let specs = [
            //Push
            PenUp
            Displacement(32y,0y)
            PenDown
            BulgeArc(0y,127y, 64y)
            //Pop
            //PenUp
            //Displacement(127y,0y)
            //EndOfShape
        ]

        let bytes =
            specs
            |> List.collect(fun spec -> spec.getBytes())        
            |> SpecificationUtils.fromStartToEndBytes 127y

        let outp = SHP.renderSHP number bytes
        output.WriteLine outp


    [<Fact>]
    member this.``中文顿号``() =
        let number = GBK.code '、'
        let specs = [
            //Push
            PenUp
            Displacement(49y,17y)
            PenDown
            BulgeArc(-34y,30y, 8y)
            //Pop
            //PenUp
            //Displacement(127y,0y)
            //EndOfShape
        ]

        let bytes =
            specs
            |> List.collect(fun spec -> spec.getBytes())        
            |> SpecificationUtils.fromStartToEndBytes 127y

        let outp = SHP.renderSHP number bytes
        output.WriteLine outp


    [<Fact>]
    member this.``中文感叹号``() =
        let number = GBK.code '！'
        let specs = [
            //Push
            PenUp
            Displacement(30y,32y)
            PenDown
            OctantArc(5uy,0x20y)
            PenUp
            Displacement(0y,12y)
            PenDown
            Displacement(0y,76y)

            //Pop
            //PenUp
            //Displacement(127y,0y)
            //EndOfShape
        ]

        let bytes =
            specs
            |> List.collect(fun spec -> spec.getBytes())        
            |> SpecificationUtils.fromStartToEndBytes 127y

        let outp = SHP.renderSHP number bytes
        output.WriteLine outp


    [<Fact>]
    member this.``中文冒号``() =
        let number = GBK.code '：'
        let specs = [
            //Push
            PenUp
            Displacement(30y,32y)
            PenDown
            OctantArc(6uy,0x20y)
            PenUp
            Displacement(0y,59y)
            PenDown
            OctantArc(6uy,0x20y)

            //Pop
            //PenUp
            //Displacement(127y,0y)
            //EndOfShape
        ]

        let bytes =
            specs
            |> List.collect(fun spec -> spec.getBytes())        
            |> SpecificationUtils.fromStartToEndBytes 127y

        let outp = SHP.renderSHP number bytes
        output.WriteLine outp

    [<Fact>]
    member this.``中文省略号``() =
        let number = GBK.code '…'
        let specs = [
            //Push
            PenUp
            Displacement(10y,63y)
            PenDown
            OctantArc(6uy,0x40y)
            PenUp
            Displacement(48y,0y)
            PenDown
            OctantArc(6uy,0x40y)
            PenUp
            Displacement(48y,0y)
            PenDown
            OctantArc(6uy,0x40y)

            //Pop
            //PenUp
            //Displacement(127y,0y)
            //EndOfShape
        ]

        let bytes =
            specs
            |> List.collect(fun spec -> spec.getBytes())        
            |> SpecificationUtils.fromStartToEndBytes 127y

        let outp = SHP.renderSHP number bytes
        output.WriteLine outp
