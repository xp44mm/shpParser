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
                |> SpecificationUtils.getIntListFromLines
                |> SpecificationUtils.getSpecifications
        }

    member this.Hanzi = 
        GBK.hanzi this.number
    /// 定义形用的字节数
    member this.defbytes = 
        this.specifications 
        |> List.map(fun spec -> spec.defbytes)
        |> List.sum

    //member this.render() =

