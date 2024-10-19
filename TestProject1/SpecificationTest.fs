namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type SpecificationTest (output:ITestOutputHelper) =
    //let getShpFileDef (filename : string) =
    //    let path = Path.Combine(Dir.solutionPath, "SHP", filename+".SHP")
    //    let lines = File.ReadAllLines(path, Encoding.UTF8)

    //    lines
    //    |> ShapeDefsCompiler.parse
    //    |> ShpFileDef.from

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
            |> SpecificationUtils.splitIntList
            |> List.ofArray

        output.WriteLine(stringify y)

        let y1 = SpecificationUtils.getSpecifications (y)
        for spec in y1 do
        output.WriteLine(spec.render())
        let bytes = 
            y1 |> List.collect(fun sp -> sp.getBytes())
        Should.equal bytes y

    // 计算当前坐标位置
    [<Theory>]
    [<InlineData("tssd")>]
    [<InlineData("intecad")>]
    [<InlineData("chin2")>]
    [<InlineData("design")>]
    [<InlineData("SBHZ")>] 
    [<InlineData("XDX")>]

    [<InlineData("SPEC")>]
    [<InlineData("SHP")>]
    [<InlineData("SHX")>]

    member this.``from lines`` (x:string) =
        output.WriteLine x
        let bytes0 = 
            Specifications.mp.[x]
            |> SpecificationUtils.getIntListFromLines

        output.WriteLine(stringify bytes0)

        output.WriteLine($"defbytes:{bytes0.Length}")
        let y1 = SpecificationUtils.getSpecifications (bytes0)
        for spec in y1 do
        output.WriteLine(spec.render())
        let bytes = 
            y1 |> List.collect(fun sp -> sp.getBytes())
        Should.equal bytes bytes0
