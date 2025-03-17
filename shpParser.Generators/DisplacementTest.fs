namespace shpParser

open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.xUnit
open FslexFsyacc
open FslexFsyacc.Fsyacc
open FslexFsyacc.Precedences
open FslexFsyacc.YACCs
open System.IO
open System.Text
open Xunit
open Xunit.Abstractions

type DisplacementTest(output:ITestOutputHelper) =
    let ls = [
        Displacement(-8y,-36y)
        Displacement(-10y,-20y)
        Displacement(-10y,-18y)
        Displacement(-18y,-20y)
        Displacement(-6y,-8y)
        ]

    [<Fact>]
    member _.``order``() =
        ls
        |> List.sortBy(function 
            | Displacement(x,y) when x <> 0y ->
                float y / float x
                |> abs
                |> (~-)
            | _ -> 0.0
        )
        |> List.iter(fun x ->
            output.WriteLine(stringify x)
        )
