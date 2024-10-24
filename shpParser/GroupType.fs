namespace shpParser

open System
open System.Collections.Generic
open System.Text.RegularExpressions

open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.RegularExpressions

/// 为了并行编程，可以让每一块单独计算，尽管单块更多运算
type GroupType =
    | BigFont of int list
    | Zero of int list
    | ShapeDef of uint16 * Specification list

    static member from (lines:string list) =
        match lines with
        | [] -> failwith "请先过滤掉此种情况"
        | line :: restlines ->
        if line.StartsWith("BIGFONT ", StringComparison.OrdinalIgnoreCase) then
            line.Substring(8).Split([|','|],StringSplitOptions.RemoveEmptyEntries).[2..]
            |> Array.map(fun s -> s.Trim() |> Number.parse)
            |> Array.toList
            |> BigFont
        else
            let bytes = Number.getIntListFromLines restlines
            match 
                line.Split([|','|],2).[0] 
                |> Number.parseUint16  
            with
            | 0us -> Zero bytes
            | number ->
                let specs =
                    bytes
                    |> List.unfold(fun state ->
                        match state with
                        | [] -> None
                        | _ -> Some(Specification.from state)
                    )
                ShapeDef(number,specs)

