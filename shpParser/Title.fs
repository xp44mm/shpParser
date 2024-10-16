namespace shpParser

open System
open System.Text.RegularExpressions
open FSharp.Idioms.StringOps

type Title =
    | BigFont of int list
    | NoTitle

    static member from (title:string) =
        if title = "" then
            NoTitle
        else
            if title.Substring(0,8) == "BIGFONT " then
                title.Substring(8).Split([|','|],StringSplitOptions.RemoveEmptyEntries)
                |> Array.map(fun s -> s.Trim() |> Number.parse)
                |> Array.toList
                |> BigFont
            else
                raise <| NotImplementedException title

