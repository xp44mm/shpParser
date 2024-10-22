namespace shpParser

open System
open System.Text.RegularExpressions
open FSharp.Idioms.StringOps

type BigFontFile = 
    {
        ranges: (int*int) list
        fontHeight: int
        fontWidth: int
    }

    member this.render (count:int) =
        let pairs =
            this.ranges
            |> List.collect(fun(x,y)->[x;y])
            |> List.map(sprintf "0%X")
            |> String.concat ","

        let renderFont h w =
            if h = 0 && w = 0 then
                []
            elif h = w then
                [
                    "*0,4"
                    $"{h},0,0,0"
                ]
            else
                [
                    "*0,5"
                    $"{h},0,0,{w},0"
                ]

        [
            if this.ranges.IsEmpty then
                ()
            else
                $"*BIGFONT {count},{this.ranges.Length},{pairs}"

            yield! renderFont this.fontHeight this.fontWidth
        ]
        |> String.concat "\r\n"
