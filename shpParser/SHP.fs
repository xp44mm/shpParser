module shpParser.SHP

open System
open System.Collections.Generic
open System.Text.RegularExpressions

open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.RegularExpressions

let MAXCOLUMN = 118

///打印整数列表，不超过指定的列数
let renderIntList (maxcol:int) (bytes: int list) =
    let rec loop (lines:string list) (rest: int list) =
        match rest with
        | head :: tail ->
            let yld = 
                match tail with
                | [] -> $"{head}"
                | _ -> $"{head},"
            let line = lines.Head+yld
            if line.Length > maxcol then
                loop (yld::lines) tail
            else
                loop (line::lines.Tail) tail
        | [] -> lines |> List.rev

    match bytes with
    | [] -> []
    | _ -> loop [""] bytes

/// 
let renderSHP (num:uint16) (bytes:int list) =
    [
        $"*{num},{bytes.Length}"
        yield! renderIntList MAXCOLUMN bytes
    ]
    |> String.concat "\r\n"

let fileSHP (ranges:int list) (fontHeight) (fontWidth) (dict:Dictionary<uint16,int list>) =
    [
        BigFont.render dict.Count ranges
        Shape0.render fontHeight fontWidth

        for shpnum,bytes in 
            dict
            |> Seq.map(fun (KeyValue(shpnum,bytes)) -> shpnum, bytes)
            |> Seq.sortBy fst
            do
            renderSHP shpnum bytes
        ""
    ]
    |> String.concat "\r\n"

//每个shpae已经打印好了
let render (title:string) (font:string) (mp:Map<uint16,string>) =
    [
        title
        font
        for KeyValue(num, shapeDef) in mp do
            shapeDef
        ""
    ]
    |> String.concat "\r\n"
