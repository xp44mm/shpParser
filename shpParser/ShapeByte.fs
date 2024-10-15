namespace shpParser

open System

/// 形定义字节。每个定义字节都是一个代码，或者定义矢量长度和方向，或者是特殊代码的对应值之一。
/// 在形定义文件中，定义字节可以用十进制或十六进制值表示。如果形定义字节的第一个字符为 0（零），则后面的两个字符解释为十六进制值。
type SpecByte =
    | Length of int
    | Direction  of int // 0-f 16个方向
    | Special of int
    | EndOfShape // 000
    | PenDown // 001
    | PenUp // 002
    | Divide // 003
    | Multiply // 004
    | Push // 005
    | Pop // 006
    | Subshape // 007 
    | Displacement // 008
    | MultipleDisplacements // 009
    | OctantArc // 00A
    | FractionalArc // 00B 精细圆弧
    | BulgeArc // 00C
    | MultipleBulgeArc // 00D
    | VerticalText // 00E


    static member from (title: string, specbytes: int list list) =
    

//type ShapeByte = 
//    {
//        shapenumber: uint16
//        defbytes: int
//        specbytes: int list list
//    }

//    static member from (title: string, specbytes: int list list) =
        
//        let ss = 
//            title.[1..].Split [|','|]
//            |> Array.map(fun s -> s.Trim())
//        {
//            shapenumber = Number.parse ss.[0]
//            defbytes = Number.parse ss.[1]
//            comment = ss.[2]
//            specbytes = specbytes
//        }

// 删除用全角的空格占位的字形
//    shp.shapenumber = 41377us
//    || shp.rows <> [
//            "17"
//            "3,13,2,14,8,(-64,-127),8,(127,0),14,8,(-64,-64),4,13,0"
//        ]
