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
        Displacement(14y,-13y)
        Displacement(8y,-13y)
        Displacement(13y,-5y)
        Displacement(20y,-10y)
        ]

    [<Fact>]
    member _.``order``() =
        ls
        |> List.sortBy(function 
            | Displacement(x,y) ->
                if x = 0y then
                    System.Double.MaxValue
                else
                     float y / float x
                     |> abs
            | _ -> 0.0
        )
        |> List.iter(fun x ->
            output.WriteLine(stringify x)
        )
