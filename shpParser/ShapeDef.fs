﻿namespace shpParser

open System
open System.Text.RegularExpressions
type ShapeDef =
    {
        shapenumber: int
        rows: string list
    }
    static member from (rows: string list) =
        let ss = 
            rows.Head.Split([|','|],2)
        {
            shapenumber = Number.parse ss.[0]
            rows = ss.[1] :: rows.Tail
        }

    member this.render() =
        let h = $"*{this.shapenumber},{this.rows.Head}"
        h :: this.rows.Tail
        |> String.concat "\r\n" 