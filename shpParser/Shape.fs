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

// 删除用全角的空格占位的字形
//    shp.shapenumber = 41377us
//    || shp.rows <> [
//            "17"
//            "3,13,2,14,8,(-64,-127),8,(127,0),14,8,(-64,-64),4,13,0"
//        ]
