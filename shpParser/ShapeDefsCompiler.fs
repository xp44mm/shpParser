module shpParser.ShapeDefsCompiler

open FslexFsyacc
open System
open FSharp.Idioms.Literal

let parser = 
    let getTag (tok:RowType) = tok.getTag()
    let getLexeme (tok:RowType) = tok.getLexeme()
    ShapeDefsParseTable.app.getParser<RowType>(getTag,getLexeme)

let table = ShapeDefsParseTable.app.getTable parser

let parseTokens(tokens:seq<RowType>) =
    tokens
    |> parser.parse
    |> ShapeDefsParseTable.unboxRoot

///
let parse(lines:string seq) =
    if Seq.isEmpty lines then
        failwith "empty string is illeagal."
    let mutable tokens = []
    let mutable states = [(0,null)]

    let stringifyStates() =
        let symbols =
            states
            |> List.map(fun(i,_)-> $"{i}/{table.kernelSymbols.[i]}")
        stringify symbols

    lines
    |> Seq.map(RowType.from)
    //|> Seq.map(fun tok -> // trace
    //    tokens <- tok :: tokens
    //    tok
    //)

    |> Seq.map(fun lookahead ->
        match parser.tryReduce(states,lookahead) with
        | Some reducedstates -> states <- reducedstates
        | None -> ()
        lookahead
    )
    |> Seq.iter(fun tok ->
        states <- parser.shift(states,tok)
    )

    match parser.tryReduce(states) with
    | Some reducedstates -> states <- reducedstates
    | None -> ()

    match states with
    |[(1,lxm);(0,null)] ->
        lxm
        |> ShapeDefsParseTable.unboxRoot
    | _ ->
        failwith $"states:{stringifyStates()}"
