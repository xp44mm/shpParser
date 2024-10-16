namespace shpParser

open System
open System.Text.RegularExpressions
open FSharp.Idioms.StringOps

type ShapeDefinition = 
    {
        number: uint16
        specifications: Specification list
    }

    static member from(number: uint16, rows: string list) =
        {
            number = number
            specifications = 
                rows
                |> SpecificationUtils.getIntList
                |> SpecificationUtils.getSpecifications
        }

    member this.Hanzi = 
        GBK.hanzi this.number

    member this.bytes = 
        this.specifications 
        |> List.map(fun spec -> spec.bytes)
        |> List.sum

    //member this.render() =

