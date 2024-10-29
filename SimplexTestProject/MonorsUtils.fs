module SimplexTestProject.MonorsUtils
open shpParser

let WIDTH = 92

//去掉头,得到新位移
let removeHead(specifications:Specification list) =
    match specifications with
    | PenUp :: Displacement(x,y) :: tail -> 
        let x = int x * WIDTH / 100
        (sbyte x, y),tail
    | _ -> failwith "removeHead"

//去掉尾部提笔移动到末尾的指令
let removeTail(specifications:Specification list) =
    match List.rev specifications with
    | EndOfShape :: Displacement _ :: PenUp :: tail ->
        List.rev tail
    | _ -> failwith "removeTail"

let trim (specifications:Specification list) =
    let (x,y),tail =
        removeHead specifications

    let middle =
        tail
        |> removeTail

    [
        Push
        PenUp
        Displacement(x,y)
        yield! middle
        PenUp
        Pop
        Displacement(sbyte WIDTH,0y)
        EndOfShape
    ]

let getRs92() =
    let a, b = 
        Monors.shapes
        |> List.partition(fun(num,_)-> num > 32us)

    //let shapes =
    [
        yield! b
        yield! 
            a 
            |> List.map(fun(num,specs) -> 
                num, trim specs
            )
    ]
    |> List.sortBy fst

// 一个形的shp
let renderShape num (specs:Specification list) =
    let bytes =
        specs
        |> List.collect(fun spec -> spec.getBytes())
    SHP.renderSHP num bytes

let fileSHP (shapes:(uint16*Specification list)list) =
    seq {
        //titleLine
        "*0,4"
        "100,27,0,0"
        yield! 
            shapes
            |> List.sortBy fst
            |> List.map (fun (num,specs) -> renderShape num specs)
        ""
    }
    |> String.concat "\r\n"
