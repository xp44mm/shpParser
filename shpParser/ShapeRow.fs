namespace shpParser

open System
open System.Text.RegularExpressions

type ShapeRow = 
    | STARROW of string
    | DATAROW of string

    static member from (row: string) =
        if row.[0] = '*' then
            //row.Split([|','|],2).[0]
            //|> Number.parseUint16
            STARROW row.[1..]
        else DATAROW row

    member this.getTag() =
        match this with
        | STARROW _ -> nameof STARROW
        | DATAROW _ -> nameof DATAROW

    member this.getLexeme () =
        match this with
        | STARROW n -> box n
        | DATAROW s -> box s


