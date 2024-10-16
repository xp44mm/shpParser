module shpParser.SpecificationUtils
open System

let getIntList (lines:string list) =
    let separator = [|',';'(';')'|]
    lines
    |> List.collect(fun l ->
        l.Split(separator,StringSplitOptions.RemoveEmptyEntries)
        |> Array.map(fun s -> Number.parseSign (s.Trim()))
        |> Array.toList
    )

let getSpecifications (ls:int list) =
    ls
    |> List.unfold(fun state ->
        match state with
        | [] -> None
        | _ -> Some(Specification.from state)
    )

