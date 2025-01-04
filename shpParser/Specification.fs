namespace shpParser

open System
open FSharp.Idioms.Literal
open type System.Math
open System.Numerics

/// 形定义字节。每个定义字节都是一个代码，或者定义矢量长度和方向，或者是特殊代码的对应值之一。
type Specification =
    | EndOfShape                                   // 000
    | PenDown                                      // 001
    | PenUp                                        // 002
    | Divide of byte                               // 003
    | Multiply of byte                             // 004
    | Push                                         // 005
    | Pop                                          // 006
    | Subshape of byte                        // 007
    | Displacement of sbyte*sbyte                  // 008
    | ManyDisplacements of (sbyte*sbyte) list      // 009
    | OctantArc of byte*sbyte                      // 00A
    | FractionalArc of byte*byte*uint16*sbyte // 00B
    | BulgeArc of sbyte*sbyte*sbyte                // 00C
    | ManyBulgeArc of (sbyte*sbyte*sbyte) list     // 00D
    | VerticalText of Specification                // 00E
    | Vector of byte                               // >= 010

    static member from (ls:int list) =
        let h = ls.Head
        let t = ls.Tail
        match h with
        | 0 ->
            EndOfShape,t
        | 1 ->
            PenDown,t
        | 2 ->
            PenUp,t
        | 3 ->
            let x = byte t.Head
            Divide x, t.Tail
        | 4 ->
            let x = byte t.Head
            Multiply x, t.Tail
        | 5 ->
            Push,t
        | 6 ->
            Pop,t
        | 7 ->
            let x = byte t.Head
            //let y = byte t.Tail.Head
            Subshape x, t.Tail
        | 8 ->
            let x = sbyte t.Head
            let y = sbyte t.Tail.Head
            Displacement (x,y), t.Tail.Tail
        | 9 ->
            let rec take2 (acc: _ list)(remains:int list) =
                let e0 = remains.[0]
                let e1 = remains.[1]
                if  e0 = 0 && e1 = 0 then
                    acc |> List.rev , remains.[2..]
                else
                let acc = (e0,e1) :: acc
                take2 acc remains.[2..]
            let taken, remains = take2 [] t
            let taken = taken |> List.map(fun(a,b)->sbyte a,sbyte b)
            ManyDisplacements taken,remains
        | 0xA ->
            let x = byte t.Head
            let y = sbyte t.Tail.Head
            OctantArc (x,y) ,t.Tail.Tail
        | 0xB ->
            let a = byte t.[0]
            let b = byte t.[1]
            let r = uint16(t.[2]*256+t.[3])

            let e = sbyte t.[4]
            let tt = t.[5..]
            FractionalArc (a,b,r,e),tt
        | 0xC ->
            let a = sbyte t.[0]
            let b = sbyte t.[1]
            let c = sbyte t.[2]
            let tt = t.[3..]
            BulgeArc(a,b,c),tt
        | 0xD ->
            let rec take3 (acc: _ list) (remains:int list) =
                let e0 = remains.[0]
                let e1 = remains.[1]
                if  e0 = 0 && e1 = 0 then
                    acc |> List.rev, remains.[2..]
                else
                let e3 = remains.[2]
                let acc = (sbyte e0,sbyte e1,sbyte e3) :: acc
                take3 acc remains.[3..]
            let ls,remains = take3 [] t

            ManyBulgeArc ls, remains
        | 0xE ->
            let spec,rest = Specification.from t
            VerticalText spec, rest
        | _ ->
            Vector (byte h), t

    member this.getBytes() =
        match this with
        | EndOfShape -> [0]
        | PenDown -> [1]
        | PenUp -> [2]
        | Divide x -> [3;int x]
        | Multiply x -> [4;int x]
        | Push -> [5]
        | Pop -> [6]
        | Subshape x -> [7;int x]
        | Displacement (x,y) -> [8;int x;int y]
        | ManyDisplacements ls -> 
            [
                9
                for (x,y) in ls do
                    int x;int y
                0;0
                ]
        | OctantArc (r,sc) -> [10;int r;int sc]
        | FractionalArc (s,c,r,sc) ->
            let r = int r
            [
                11;int s; int c;
                r / 256
                r % 256
                int sc
                ]
        | BulgeArc (x,y,h) -> [12;int x;int y;int h]
        | ManyBulgeArc ls -> [
            13
            for (x,y,h) in ls do int x;int y;int h
            0;0
            ]
        | VerticalText spec -> [14;yield! spec.getBytes()]
        | Vector x -> [int x]

    member this.scale(i:float) =
        if i <= 0 then 
            failwith "比例系数为一个正数"
        elif i = 1.0 then 
            this
        else

        let scaleSByte (x:sbyte) =
            float x * i |> SByte.fromFloat

        let scaleByte (x:byte) =
            float x * i |> Number.byteFromFloat
        match this with
        | Displacement (x,y) ->
            Displacement(scaleSByte x, scaleSByte y)
        | ManyDisplacements ls ->
            ls
            |> List.map(fun (x,y) ->
            (scaleSByte x,scaleSByte y)
            )
            |> ManyDisplacements
        | OctantArc (r,sc) ->
            OctantArc (scaleByte r,sc)
        | FractionalArc (so,eo,r,sc) ->
            let r =
                float r * i
                |> Math.Round
                |> uint16
            FractionalArc (so,eo,r,sc)
        | BulgeArc (x,y,h) ->
            let x = scaleSByte x
            let y = scaleSByte y
            let h = scaleSByte h
            BulgeArc(x,y,h)
        | ManyBulgeArc ls ->
            ls
            |> List.map(fun (x,y,h)->
            let x = scaleSByte x 
            let y = scaleSByte y 
            let h = scaleSByte h 
            ( x, y, h)
            )
            |> ManyBulgeArc
        | VerticalText spec ->
            VerticalText(spec.scale i)
        | Vector bt ->
            //let ua = 22.5 / 180. * PI
            //let d = float(bt / 16uy)
            //let a = float(bt % 16uy)
            //let x = d * i * cos(ua * a) |> Math.Round
            //let y = d * i * sin(ua * a) |> Math.Round
            //Displacement(sbyte x, sbyte y)
            raise <| System.NotImplementedException($"{stringify this}")
        | EndOfShape
        | PenDown
        | PenUp
        | Push
        | Pop
        | Divide _ 
        | Multiply _ 
            -> this
        | Subshape _ -> failwith $"unimpl:{stringify this}"

    /// 极坐标转为xy坐标的对像
    member this.eliminate127() = 
        match this with
        | Vector bt ->
            let len = sbyte(bt / 16uy)
            let x,y =
                match bt % 16uy with
                |  0uy -> len,0y
                |  1uy -> len, len / 2y
                |  2uy -> len,len
                |  3uy -> len / 2y, len
                |  4uy -> 0y,len
                |  5uy -> -len / 2y, len
                |  6uy -> -len, len
                |  7uy -> -len, len / 2y
                |  8uy -> -len,0y
                |  9uy -> -len, -len / 2y
                | 10uy -> -len,-len
                | 11uy -> -len / 2y, -len
                | 12uy -> 0y,-len
                | 13uy -> len / 2y, -len
                | 14uy -> len,-len
                | 15uy -> len, -len / 2y
                | _ -> failwith "never"

            Displacement(x, y)
        | VerticalText spec -> VerticalText(spec.eliminate127())

        | OctantArc (r,sc) -> BulgeArc(0y,0y,0y)
        | FractionalArc (so,eo,r,sc) -> BulgeArc(0y,0y,0y)

        | EndOfShape                           
        | PenDown                              
        | PenUp                                
        | Divide _                             
        | Multiply _
        | Push                                 
        | Pop                                  
        | Subshape _                  
        | Displacement _                  
        | ManyDisplacements _  
        | BulgeArc _         
        | ManyBulgeArc _
            -> this

    member this.dissolveManyDisp() = 
        match this with
        | ManyDisplacements ls  ->
            ls
            |> List.map(fun (x,y) ->Displacement(x, y))
        | Subshape _
        | VerticalText _ // -> raise <| NotImplementedException("需要先消除的元素")
        | _ -> [this] 

    member this.complex() =
        match this with
        | EndOfShape -> Complex(0.,0.)
        | PenDown -> Complex(0.,0.)
        | PenUp -> Complex(0.,0.)
        | Divide x -> Complex(0.,0.)
        | Multiply x -> Complex(0.,0.)
        | Push -> Complex(0.,0.)
        | Pop -> Complex(0.,0.)
        | Subshape x -> Complex(0.,0.)
        | Displacement (x,y) -> Complex(float x, float y)
        | ManyDisplacements ls -> 
            [
                for (x,y) in ls do
                    Complex(float x, float y)
            ]
            |> List.reduce(+)

        | OctantArc (r,sc) -> raise <| NotImplementedException("OctantArc")
        | FractionalArc (s,c,r,sc) -> raise <| NotImplementedException("FractionalArc")
        | BulgeArc (x,y,h) -> raise <| NotImplementedException("BulgeArc")
        | ManyBulgeArc ls -> raise <| NotImplementedException("ManyBulgeArc")

        | VerticalText spec -> Complex(0.,0.)
        | Vector x -> raise <| NotImplementedException("ManyBulgeArc")

    static member displacementFromComplex (complex:Complex) =
        let x = sbyte complex.Real
        let y = sbyte complex.Imaginary
        Displacement (x,y)
