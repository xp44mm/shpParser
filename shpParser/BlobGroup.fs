namespace shpParser

open System
open System.Collections.Generic
open System.Text.RegularExpressions

open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.RegularExpressions

/// 为了并行编程，可以让每一块单独计算，尽管单块更多运算
type BlobGroup =
    | BlobBigFont of string
    | BlobShapeDef of uint16 * string list

    static member from (lines:string list) =
        match lines with
        | [] -> failwith "请先过滤掉此种情况"
        | line :: _ ->
        if line.StartsWith("BIGFONT ", StringComparison.OrdinalIgnoreCase) then
            // 丢弃字数
            line.Split([|','|],2).[1]
            |> BlobBigFont
        else
            let number = 
                line.Split([|','|],2).[0] // shape number
                |> Number.parseUint16  
            BlobShapeDef(number,lines) // 完全保留原有字符行，因为是整体替换

