module shpParser.Number
open System

let parse (s:string) =
    match s.[0] with
    | '0' -> Convert.ToInt32(s,16)
    | _ -> int s
