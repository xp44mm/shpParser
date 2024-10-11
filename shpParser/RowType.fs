namespace shpParser

open System
open System.Text.RegularExpressions

type RowType = 
    | STARROW of string
    | DATAROW of string

    static member from (row: string) =
        if row.[0] = '*' then
            STARROW row.[1..]
        else
            DATAROW row

    member this.getTag() =
        match this with
        | STARROW _ -> "STARROW"
        | DATAROW _ -> "DATAROW"

    member this.getLexeme () = 
        match this with
        | STARROW s
        | DATAROW s -> box s


