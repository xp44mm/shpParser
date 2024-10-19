namespace shpParser

open System
open System.Text.RegularExpressions
open FSharp.Idioms.StringOps

type RowType = 
    | TITLEROW of string // 不包括*号
    | ZEROROW of string // *0,不包括
    | STARROW of uint16*string
    | DATAROW of string

    static member from (row: string) =
        if row.[0] = '*' then
            let row = row.[1..]
            if Char.IsLetter row.[0] then
                TITLEROW row
            else
                let ss = row.Split([|','|],2)
                match Number.parseUint16 ss.[0] with
                | 0us -> ZEROROW ss.[1]
                | number -> STARROW(number,ss.[1])
        else DATAROW row

    member this.getTag() =
        match this with
        | TITLEROW _ -> nameof TITLEROW
        | ZEROROW _ -> nameof ZEROROW
        | STARROW _ -> nameof STARROW
        | DATAROW _ -> nameof DATAROW

    member this.getLexeme () =
        match this with
        | TITLEROW s -> box s
        | ZEROROW s -> box s
        | STARROW (n,s) -> box (n,s)
        | DATAROW s -> box s


