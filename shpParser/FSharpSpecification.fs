module shpParser.FSharpSpecification

open System
open System.Collections.Generic
open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.Line
open System.Text

//let renderShape (shpnum:uint16) (specs:Specification list) =
//    let c =
//        if shpnum < 32us then
//            None
//        elif shpnum < 127us then
//            char shpnum |> Some
//        elif shpnum < 256us then
//            None
//        else GBK.hanzi shpnum |> Some
//        |> Option.map(fun c -> $"// {c}")
//        //|> Option.defaultValue ""
//        //""
//    [
//        match c with Some c -> c | _ -> ()
//        $"dict.[{shpnum}us] <- ["
//        for spec in specs do
//            $"    {SpecificationRender.renderFSharp spec}"
//        "]"
//    ]
    //|> String.concat "\r\n"

let moduleHeadLines (name:string) =
    [
        $"module {name}"
        "open shpParser"
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

//let shapesLines (name:string) (shapes:Map<uint16,string list>) =
//    [
//        $"let {name} ="
//        space4 1 "let dict = Dictionary<uint16,Specification list>()"
//        yield!
//            shapes
//            |> Map.values
//            |> Seq.concat
//            |> Seq.map (space4 1)
//        space4 1 "Map.fromInterface dict"
//    ]

let listShape (num:uint16) (specs:Specification list) =
    // 注释字符
    let c =
        if num < 32us then
            None
        elif num < 127us then
            char num |> Some
        elif num < 256us then
            None
        else GBK.hanzi num |> Some
        |> Option.map(sprintf "// %c")

    [
        match c with Some c -> c | _ -> ()
        $"{num}us, ["
        for spec in specs do
            $"    {SpecificationRender.renderFSharp spec}"
        "]"
    ]

let bindShapes (name:string) (shapes:seq<uint16*string list>) =
    [
        $"let {name} = ["
        yield!
            shapes
            |> Seq.collect(snd)
            |> Seq.map (space4 1)
        space4 1 "]"
    ]
