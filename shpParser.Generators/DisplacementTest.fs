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

    [<Fact>]
    member _.``order``() =
        let ls =
            [
            Displacement(-5y,-18y)
            Displacement(-5y,-13y)
            Displacement(-6y,-10y)
            Displacement(-5y,-10y)
            Displacement(-9y,-10y)
            ]

        ls
        |> List.sortBy(function 
            | Displacement(x,y) -> 
                float y / float x
            | _ -> 0.0
        )
        |> List.iter(fun x ->
            output.WriteLine(stringify x)
        )
