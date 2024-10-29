module shpParser.BigFont
open System
open System.Collections.Generic
open System.Text.RegularExpressions

open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.RegularExpressions

/// render .shp
let render (count:int) (ranges: int list) =
    let pairs =
        ranges
        |> List.map(sprintf "0%X")
        |> String.concat ","
    $"*BIGFONT {count},{ranges.Length/2},{pairs}"

/// render .shape
let renderShape (ranges: int list) = $"ranges={stringify ranges}"

let template = "*BIGFONT 0,1,0A1,0FE" 

let replace (temp:string) (count:int) =
    let rgx = Regex(@"\d[^,]*")
    let m = rgx.Match(temp)
    let a = m.Result("$`")
    let b = m.Result("$'")
    $"{a}{count}{b}"
