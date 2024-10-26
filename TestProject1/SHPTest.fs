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

type SHPTest(output:ITestOutputHelper) =
    [<Fact>]
    member _.``shp to disp from scale``() =
        let rg = [0..50]
        let maxcol = 10
        let y =
            rg
            //|> List.map((*)4)
            |> SHP.renderIntList maxcol
            |> List.map(fun line -> line, line.Length)

        for l,n in y do
        output.WriteLine(stringify (l,n))
