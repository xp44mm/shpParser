namespace shpParser

open System

type Shape = 
    {
        shapenumber: int
        defbytes: int
        comment: string
        specbytes: int list list
    }

    static member from (title: string, specbytes: int list list) =
        
        let ss = 
            title.[1..].Split [|','|]
            |> Array.map(fun s -> s.Trim())
        {
            shapenumber = Number.parse ss.[0]
            defbytes = Number.parse ss.[1]
            comment = ss.[2]
            specbytes = specbytes
        }
