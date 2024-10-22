module shpParser.Shape0

open System
open System.Collections.Generic
open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
    
// todo renderFont5
let renderFont (h:int) =
    [
        "*0,4"
        $"{h},0,0,0"
    ]
    |> String.concat "\r\n"

let renderFont5 (h:int) (w:int) =
    [
        "*0,5"
        $"{h},0,0,{w},0"
    ]
    |> String.concat "\r\n"

let render h w =
    if h = w then
        renderFont h
    else
        renderFont5 h w


/// render .shape
let renderShape h w = 
    if h = w then
        $"Height={h}"
    else
        $"Height={h},Width={w}"


