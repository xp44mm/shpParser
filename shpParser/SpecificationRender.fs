module shpParser.SpecificationRender
open System
open System.Collections.Generic
open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase

let rec render(this:Specification) =
    let printS16 (sc:sbyte) =
        let sgn,num = if sc < 0y then "-",-sc else "",sc
        $"{sgn}0x%X{num}y"

    match this with
    | EndOfShape -> "EndOfShape"
    | PenDown -> "PenDown"
    | PenUp -> "PenUp"
    | Divide x -> $"Divide {x}uy"
    | Multiply x -> $"Multiply {x}uy"
    | Push -> "Push"
    | Pop -> "Pop"
    | Subshape x -> $"Subshape 0x%X{x}uy"
    | Displacement (x,y) -> $"Displacement({x}y,{y}y)"
    | ManyDisplacements ls -> 
        //let s =
        //    ls
        //    |> List.map(fun (x,y)-> $"({x},{y})")
        //    |> String.concat ";"
        $"ManyDisplacements {stringify ls}"
    | OctantArc (r,sc) ->
        $"OctantArc({r}uy,{printS16 sc})"
    | FractionalArc (s,c,r,sc) ->
        $"FractionalArc({s}uy,{c}uy,{r}us,{printS16 sc})"
    | BulgeArc (x,y,h) -> $"BulgeArc({x}y,{y}y,{h}y)"
    | ManyBulgeArc ls ->
        //let ls =
        //    ls
        //    |> List.map(fun (x,y,h) -> $"({x},{y},{h})")
        //    |> String.concat ";"
        $"ManyBulgeArc {stringify ls}"
    | VerticalText spec -> "VerticalText " + render spec
    | Vector x -> $"Vector 0x%X{x}y"

let renderSpecifications (shpnum) (specifications:Specification list) =
    let hanzi = GBK.hanzi shpnum
    [
        $"*{shpnum}" + if Char.IsControl hanzi then "" else $",{hanzi}"
        for spec in specifications do
            "  " + render spec
    ]
    |> String.concat "\r\n"

let fileShape (ranges) (fontHeight) (dict:Dictionary<uint16,Specification list>) =
    [
        $"ranges={stringify ranges}"
        $"fontHeight={fontHeight}"
        for shpnum,specifications in 
            dict 
            |> Seq.map(fun (KeyValue(shpnum,specifications)) -> shpnum,specifications)
            |> Seq.sortBy fst        
            do
            renderSpecifications shpnum specifications
        ""
    ]
    |> String.concat "\r\n"


