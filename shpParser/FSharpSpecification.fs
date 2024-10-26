module shpParser.FSharpSpecification

open System
open System.Collections.Generic
open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.Line
open System.Text

let renderShape (shpnum:uint16) (specs:Specification list) =
    let c =
        if shpnum < 32us then
            None
        elif shpnum < 127us then
            char shpnum |> Some
        elif shpnum < 256us then
            None
        else GBK.hanzi shpnum |> Some
        |> Option.map(fun c -> $"// {c}")
        //|> Option.defaultValue ""
        //""
    [
        match c with Some c -> c | _ -> ()
        $"dict.[{shpnum}us] <- ["
        for spec in specs do
            $"    {SpecificationRender.renderFSharp spec}"
        "]"
    ]
    //|> String.concat "\r\n"

let moduleHeadLines (name:string) =
    [
        $"module shpParser.{name}Specification"
        "open System.Collections.Generic"
        "open FSharp.Idioms"
    ]

let titleLines (title:string) =
    $"let title = {stringify title}"

let zeroLines (lines:string list) =
    [
        "let zero = ["
        for line in lines do
            space4 1 (stringify line)
        "]"
    ]
    //|> String.concat "\r\n"

let shapesLines (shapes:Map<uint16,string list>) =
    [
        //"module shpParser.{}Specification"
        //"open System.Collections.Generic"
        //"open FSharp.Idioms"

        //title
        //zero
        "let Shapes ="
        space4 1 "let dict = Dictionary<uint16,Specification list>()"
        yield!
            shapes
            |> Map.values
            |> Seq.concat
            |> Seq.map (space4 1)
        space4 1 "Map.fromInterface dict"
    ]
    //|> String.concat "\r\n"


