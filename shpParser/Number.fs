module shpParser.Number
open System

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
