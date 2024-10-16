namespace shpParser

open System

/// 形定义字节。每个定义字节都是一个代码，或者定义矢量长度和方向，或者是特殊代码的对应值之一。
type Specification =
    | EndOfShape                                   // 000
    | PenDown                                      // 001
    | PenUp                                        // 002
    | Divide of byte                               // 003
    | Multiply of byte                             // 004
    | Push                                         // 005
    | Pop                                          // 006
    | Subshape of byte*byte                        // 007
    | Displacement of sbyte*sbyte                  // 008
    | ManyDisplacements of (sbyte*sbyte) list      // 009
    | OctantArc of byte*byte                       // 00A
    | FractionalArc of sbyte*sbyte*byte*byte*sbyte // 00B
    | BulgeArc of byte*byte*byte                   // 00C
    | ManyBulgeArc of (int*int*int) list           // 00D
    | VerticalText of Specification                // 00E
    | Simple of byte                               // >= 010

    static member from (ls:int list) =
        let h = ls.Head
        let t = ls.Tail
        //let spec, rest =
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
            let y = byte t.Tail.Head
            Subshape(x,y), t.Tail.Tail
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
            let y = byte t.Tail.Head
            OctantArc (x,y) ,t.Tail.Tail
        | 0xB ->
            let a = sbyte t.[0]
            let b = sbyte t.[1]
            let c = byte t.[2]
            let d = byte t.[3]
            let e = sbyte t.[4]
            let tt = t.[5..]
            FractionalArc (a,b,c,d,e),tt
        | 0xC ->
            let a = byte t.[0]
            let b = byte t.[1]
            let c = byte t.[2]
            let tt = t.[3..]
            BulgeArc(a,b,c),tt
        | 0xD ->
            let rec take3 (acc: _ list)(remains:int list) =
                let e0 = remains.[0]
                let e1 = remains.[1]
                if  e0 = 0 && e1 = 0 then
                    acc |> List.rev, remains.[2..]
                else
                let e3 = remains.[2]
                let acc = (e0,e1,e3) :: acc
                take3 acc remains.[3..]
            let ls,remains = take3 [] t

            ManyBulgeArc ls, remains
        | 0xE ->
            let spec,rest = Specification.from t
            VerticalText spec, rest
        | _ ->
            Simple (byte h), t

    member this.bytes =
        match this with
        | EndOfShape        
        | PenDown           
        | PenUp             
        | Push              
        | Pop               
        | Simple _          
            -> 1us
        | Divide _          
        | Multiply _        
            -> 2us

        | Subshape _        
        | Displacement _    
        | OctantArc _       
            -> 3us

        | BulgeArc _               
            -> 4us
        | FractionalArc _ 
            -> 6us

        | ManyDisplacements ls
            -> 3us + uint16 ls.Length * 2us
        | ManyBulgeArc ls 
            -> 3us + uint16 ls.Length * 3us

        | VerticalText spec
            -> 1us + spec.bytes

// 删除用全角的空格占位的字形
//    shp.shapenumber = 41377us
//    || shp.rows <> [
//            "17"
//            "3,13,2,14,8,(-64,-127),8,(127,0),14,8,(-64,-64),4,13,0"
//        ]
