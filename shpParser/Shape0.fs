module shpParser.Shape0

open System
open System.Collections.Generic
open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase

let getFontHeight(font:string list) =
    let line = font.Tail.Head
    let ss = line.Split([|','|],2).[0].Trim()
    Number.parse ss
    
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

//let takeZero (shapes:(uint16*int list)list) =
//    match shapes with
//    | (0us,lines) :: t -> lines,t
//    | _ -> [],shapes

let getFontSize (ls:int list) =
    match ls with
    | [h;_;_;0] -> h,h
    | [h;_;_;w;0] -> h,w
    | _ -> failwith "no shape 0 format."

