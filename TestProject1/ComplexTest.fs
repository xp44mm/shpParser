namespace shpParser

open Xunit
open Xunit.Abstractions

open FSharp.xUnit
open FSharp.Idioms.Literal

type ComplexTest (output:ITestOutputHelper) =

    [<Fact>]
    member _.``加法测试``() =
        let x = 
            [
                Displacement(-4y,-18y)
                Displacement(-6y,-15y)
                Displacement(-3y,-3y)
            ]
        let e =
            Displacement(-13y,-36y)

        let y =
            x
            |> List.map(fun s -> s.complex())
            |> List.reduce(+)
            |> Specification.displacementFromComplex
        output.WriteLine(stringify y)
        Should.equal e y
