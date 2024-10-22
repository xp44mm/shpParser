module shpParser.Number
open System

///解析无符号的整数，十进制或零开头十六进制
let parse (s:string) =
    match s.[0] with
    | '0' -> Convert.ToInt32(s,16)
    | _ -> int s

let parseUint16 (s:string) =
    match s.[0] with
    | '0' -> Convert.ToUInt16(s,16)
    | _ -> uint16 s

let parseSign (s:string) =
    match s.[0] with
    | '-' -> - parse s.[1..]
    | _ -> parse s

let sbyteFromFloat (x:float) =
    let x = Math.Round(x)
    if x >= 127. then 127y
    elif x <= -127. then -127y
    else sbyte x

let byteFromFloat (x:float) =
    let x = Math.Round(x)
    if x >= 255. then 255uy
    elif x <= 0. then 0uy
    else byte x
    
let splitIntList (l:string) =
    let separator = [|',';'(';')'|]
    l.Split(separator,StringSplitOptions.RemoveEmptyEntries)
    |> Array.map(fun s -> parseSign (s.Trim()))

let getIntListFromLines (lines: string list) =
    lines
    |> List.collect(splitIntList>>Array.toList)
