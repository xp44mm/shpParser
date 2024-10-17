module shpParser.SpecificationUtils
open System

let splitIntList (l:string) =
    let separator = [|',';'(';')'|]
    l.Split(separator,StringSplitOptions.RemoveEmptyEntries)
    |> Array.map(fun s -> Number.parseSign (s.Trim()))

let getIntListFromLines (lines: string list) =
    lines
    |> List.collect(splitIntList>>Array.toList)

let getSpecifications (ls:int list) =
    ls
    |> List.unfold(fun state ->
        match state with
        | [] -> None
        | _ -> Some(Specification.from state)
    )

