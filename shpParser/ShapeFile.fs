namespace shpParser

open System
open System.Text.RegularExpressions

type ShapeFile = 
    {
        keyword: string
        nchars: int
        nranges: int
        pairs: (int*int) list
        shapes: Shape list
    }

    static member from (title: string, shapes : Shape list) =
        if title = "" then
            {
                keyword = ""
                nchars = 0
                nranges = 0
                pairs = []
                shapes = shapes
            }
        else
            let m = Regex.Match(title,@"^\*\s*BIGFONT +(.*)",RegexOptions.IgnoreCase)
            let codes = 
                m.Groups.[1].Value.Split [|','|]
                |> Array.map(fun s -> s.Trim()|> Number.parse)
                |> Array.toList
            let nchars,nranges,pairs =
                match codes with
                | a::b::c -> 
                    let c = 
                        c 
                        |> List.chunkBySize 2
                        |> List.map(fun ls -> ls.[0],ls.[1])
                    a,b,c
                | _ -> failwith ""
            {
                keyword = "BIGFONT"
                nchars = nchars
                nranges = nranges
                pairs = pairs
                shapes = shapes
            }
