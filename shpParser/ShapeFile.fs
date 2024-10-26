module shpParser.ShapeFile

open System
open System.Collections.Generic
open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase

let render title zero (mp:Map<uint16,string>) =
    [
        if String.IsNullOrWhiteSpace(title) then 
            () 
        else 
            yield title
        yield zero
        for KeyValue(num,res) in mp do
            yield res
    ]
    |> String.concat "\r\n"


let renderShape (ranges) h w (mp:Map<uint16,string>) =
    let title = BigFont.renderShape ranges
    let zero = Shape0.renderShape h w
    render title zero mp
