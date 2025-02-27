﻿namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type SpecificationTest (output:ITestOutputHelper) =

    [<Theory>]
    [<InlineData("014,010,01C,018,012,0")>]
    [<InlineData("8,(-10,3)")>]
    [<InlineData("9,(3,1),(3,2),(2,-3),(0,0)")>]
    [<InlineData("012,10,(1,-032),01E,")>]
    [<InlineData("11,(56,28,0,3,012)")>]
    [<InlineData("13,(0,5,127),(0,5,-127),(0,0)")>]
    [<InlineData("2,14,8,(-2, 6),1,030,012,044,016,038,2,010,1,06C,2,050,14,8,(-4,-3),0")>]
    [<InlineData("2,8,(0,-10),0")>]
    [<InlineData("024,043,04d,02c,2,047,1,040,2,02e,0")>]
    member this.``autocad help examples`` (x:string) =
        output.WriteLine x
        let y = 
            x
            |> Number.splitIntList
            |> List.ofArray

        output.WriteLine(stringify y)

        let y1 = SpecificationUtils.getSpecifications (y)
        for spec in y1 do
        output.WriteLine(SpecificationRender.renderFSharp spec)
        let bytes = 
            y1 |> List.collect(fun sp -> sp.getBytes())
        Should.equal bytes y

    // 计算当前坐标位置
    [<Theory>]
    [<InlineData("?")>]
    [<InlineData("dash")>]

    member this.``from lines`` (x:string) =
        output.WriteLine x
        let bytes0 = 
            Specifications.mp.[x]
            |> Number.getIntListFromLines

        output.WriteLine(stringify bytes0)

        output.WriteLine($"defbytes:{bytes0.Length}")
        let y1 = SpecificationUtils.getSpecifications (bytes0)
        for spec in y1 do
        output.WriteLine(SpecificationRender.renderFSharp spec)
        let bytes = 
            y1 |> List.collect(fun sp -> sp.getBytes())
        Should.equal bytes bytes0
            
    [<Theory>]
    [<InlineData("41377")>]
    [<InlineData("41378")>]
    [<InlineData("empty")>]
    member this.``distinctPen`` (shpnumber:string) =
        let specs = 
            Specifications.design.[shpnumber]
            |> Number.getIntListFromLines
            |> SpecificationUtils.getSpecifications
            |> SpecificationUtils.distinctPen

        for spec in specs do
            output.WriteLine(SpecificationRender.renderFSharp spec)

        let bytes = 
            specs |> List.collect(fun sp -> sp.getBytes())
        output.WriteLine(stringify bytes)
