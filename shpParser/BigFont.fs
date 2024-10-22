module shpParser.BigFont
open System
open System.Collections.Generic
open System.Text.RegularExpressions

open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.RegularExpressions

//.StartsWith(value, StringComparison.Ordinal) 
let getRanges (title:string) =
    if title.Substring(0,8) == "BIGFONT " then
        title.Substring(8).Split([|','|],StringSplitOptions.RemoveEmptyEntries)
        |> Array.map(fun s -> s.Trim() |> Number.parse)
        |> Array.toList
        |> List.tail // 丢弃字数，新程序将重新计算字数
    else
        raise <| NotImplementedException title

let renderTitle (count:int) (ranges:int list) =
    let pairs =
        ranges.Tail
        |> List.map(sprintf "0%X")
        |> String.concat ","

    $"*BIGFONT {count},{ranges.Head},{pairs}"
    
let takeRanges (lines:string list) =
    match lines with
    | [] -> [], lines
    | line::rest ->

    match line with
    | Rgi @"^\*BIGFONT +" m ->
        //nchars,nranges,pairs
        let ranges =
            m.Result("$'").Split([|','|],StringSplitOptions.RemoveEmptyEntries).[2..]
            |> Array.map(fun s -> s.Trim() |> Number.parse)
            |> Array.toList
            |> List.chunkBySize 2
            |> List.map(fun ls -> ls.[0],ls.[1])
        ranges,rest
    | _ -> [], lines

let render (count:int) (ranges:(int*int)list) =
    let pairs =
        ranges
        |> List.collect(fun(x,y)->[x;y])
        |> List.map(sprintf "0%X")
        |> String.concat ","
    $"*BIGFONT {count},{ranges.Length},{pairs}"

