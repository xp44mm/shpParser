module shpParser.SHP

open System
open System.Collections.Generic
open System.Text.RegularExpressions

open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.RegularExpressions

/// 改进算法
let renderSHP (num:uint16) (bytes:int list) =
    let COLUMN = 80
    let tryline (text:string) =
        if text = "" then
            None
        elif text.Length <= COLUMN then
            Some(text,"")
        else
            let i = text.[0..COLUMN-1].LastIndexOf ','
            Some(text.[0..i],text.[i+1..])
    let lines =
        bytes 
        |> Seq.map(fun i -> i.ToString()) 
        |> String.concat ","
        |> Seq.unfold(tryline)

    [
        $"*{num},{bytes.Length}"
        yield! lines
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

let render (title:string) (font:string) (mp:Map<uint16,string>) =
    [
        title
        font
        for KeyValue(num, shapeDef) in mp do
            shapeDef
        ""
    ]
    |> String.concat "\r\n"
