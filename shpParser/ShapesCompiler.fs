module shpParser.ShapesCompiler
open System

open FslexFsyacc
open FSharp.Idioms.Literal

let parser = 
    let getTag (tok:string option) = 
        match tok with
        | Some _ -> "LINE"
        | None -> "*"
    let getLexeme (tok:string option) = 
        match tok with
        | Some line -> box line
        | None -> null

    ShapesParseTable.app.getParser<string option>(getTag,getLexeme)

let table = ShapesParseTable.app.getTable parser

let parse(lines:string seq) =
    lines
    |> Seq.filter(fun line -> String.IsNullOrEmpty line |> not)
    |> Seq.collect(fun line -> seq {
            if line.[0] = '*' then
                None; Some line.[1..]
            else Some line
        })
    |> parser.parse
    |> ShapesParseTable.unboxRoot

