module shpParser.ShpCompiler

open FslexFsyacc
open System
open FSharp.Idioms.Literal

let parser = ShpParseTable.app.getParser<PositionWith<ShpToken>>(ShpTokenUtils.getTag,ShpTokenUtils.getLexeme)
let table = ShpParseTable.app.getTable parser

let parseTokens(tokens:seq<PositionWith<ShpToken>>) =
    tokens
    |> parser.parse
    |> ShpParseTable.unboxRoot

///
let parse(text:string) =
    if String.IsNullOrWhiteSpace text then
        failwith "empty string is illeagal."
    let mutable tokens = []
    let mutable states = [(0,null)]

    let stringifyStates() =
        let symbols =
            states
            |> List.map(fun(i,_)-> $"{i}/{table.kernelSymbols.[i]}")
        stringify symbols

    text
    |> ShpTokenUtils.tokenize 0
    |> Seq.map(fun tok -> // trace
        tokens <- tok :: tokens
        tok
    )
    //|> Seq.filter(fun tok ->
    //    match tok.value with
    //    | WS _ -> false
    //    | _ ->true
    //    )
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
        |> ShpParseTable.unboxRoot
    | _ ->
        failwith $"states:{stringifyStates()}"

