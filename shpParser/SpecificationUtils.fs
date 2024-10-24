module shpParser.SpecificationUtils
open System
open System.Collections.Generic
open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase

let getSpecifications (ls:int list) =
    ls
    |> List.unfold(fun state ->
        match state with
        | [] -> None
        | _ -> Some(Specification.from state)
    )

let dissolve (dict:Dictionary<uint16,Specification list>) =
    let getlist (i:byte) =
        dict.[uint16 i]
        |> List.takeWhile(fun spec ->
            match spec with
            | EndOfShape -> false
            | _ -> true
        )
    let newdict = new Dictionary<uint16,Specification list>()
    for KeyValue(shpnum,specifications) in dict do
        let specifications =
            specifications
            |> List.collect(fun spec ->
                match spec with
                | Subshape i -> getlist i
                | _ -> spec |> List.singleton 
                )
        newdict.Add(shpnum,specifications)
    newdict

let trimChin2 (specifications:Specification list) =
    //去掉头
    let rec removeHead(specifications) =
        match specifications with
        | Push :: t -> t
        | _ -> Pop :: specifications

    //去掉尾部提笔移动到末尾的指令
    let removeTail(specifications1) =
        match List.rev specifications1 with
        | EndOfShape :: ManyDisplacements[126y,0y;18y,0y] :: PenUp :: Pop :: specifications2 ->
            specifications2
            |> List.rev
            |> Some
        | _ -> None

    //let i = 127./144. // 12.5->15 不用执行scale,只需要简单把end从144->127
    //|> Option.map(fun specifications2 ->
    //    specifications2
    //    |> List.map(fun spec -> spec.scale i)
    //)

    specifications
    |> removeHead
    |> removeTail
    |> Option.defaultValue []

let trimDesign (specifications:Specification list) =
    //去掉头
    let specifications =
        match specifications with
        | Push :: t -> t
        | _ -> failwith "never"

    // 去掉尾部提笔移动到末尾的指令
    let specifications =
        match List.rev specifications with
        | EndOfShape :: Displacement(63y,0y) :: PenUp :: Pop :: t -> List.rev t 
        | _ -> failwith "never"

    //let i = 2. // 高度127ok! 宽度应该改为100

    //specifications
    //|> List.map(fun spec -> spec.scale 2.)
    specifications

let trimSbhz (specifications:Specification list) = 
    specifications
    |> List.rev
    |> List.tail // 删除末尾的零
    |> List.rev

let trimTssd (specifications:Specification list) =
    //去掉头
    let rec removeHead(specifications) =
        match specifications with
        | Push :: t -> t
        | _ -> Pop :: specifications

    //去掉尾部提笔移动到末尾的指令
    let removeTail(specifications1) =
        match List.rev specifications1 with
        | EndOfShape :: Displacement(127y,0y) :: PenUp :: Pop :: specifications2 ->
            specifications2
            |> List.rev
            |> Some
        | _ -> None

    specifications
    |> removeHead
    |> removeTail
    |> Option.defaultValue []

/// remove divide multiply
let trimXdx (specifications:Specification list) =

    //去掉头
    let removeHead(specifications) =
        match specifications with
        | Divide 100uy :: specifications1 -> Some specifications1
        | _ -> None

    //去掉尾部提笔移动到末尾的指令
    let removeTail(specifications1) =
        match List.rev specifications1 with
        | EndOfShape :: Multiply 100uy :: specifications2 ->
            specifications2
            |> List.rev
            |> Some
        | _ -> None

    //let i = 127./115. // 13 -> 15，字小了放大
    //let x =
    specifications
    |> removeHead
    |> Option.bind(fun specifications1 -> removeTail specifications1)
    //|> Option.map(fun specifications2 ->
    //    specifications2
    //    |> List.map(fun spec -> spec.scale i)
    //)
    |> Option.defaultValue []

let distinctPen (specifications:Specification list) =
    if specifications.IsEmpty then specifications else
    // PenUp | PenDown 收集为一组
    let rec loopGroup (updown:Specification) group rest =
        match rest with
        | [] -> group |> List.rev, []
        | h::t ->
            match h with
            | PenUp | PenDown ->
                if h = updown then
                    loopGroup updown group t
                else
                    group |> List.rev, rest
            | _ ->
                loopGroup updown (h::group) t
    // 收集并分组
    let rec loop revGroups rest =
        match rest with
        | [] -> revGroups
        | h :: tail ->
            match loopGroup h [h] tail with
            | group, rest -> loop (group::revGroups) rest

    // 如果开始不是PenUp，就补一个
    let revGroups =
        match specifications with
        | [] -> []
        | (PenUp as h) :: tail -> loop [] specifications
        | _ -> loop [] (PenUp::specifications)
            
    // 删除last PenUp
    let trimEnd (revGroups:Specification list list) =
        if revGroups.Head.Head = PenUp then
            revGroups.Tail
        else revGroups

    revGroups
    |> List.filter(fun group ->
        match group with
        | [PenDown|PenUp] -> false // 删除无动作的指令
        | _ -> true
    )
    |> trimEnd
    |> List.rev
    |> List.concat
// 计算当前坐标位置

let trim (filename:string) =
    match filename with
    | IgnoreCase "chin2" -> trimChin2
    | IgnoreCase "design" -> trimDesign
    | IgnoreCase "SBHZ" -> trimSbhz
    | IgnoreCase "tssdchn" -> trimTssd
    | IgnoreCase "XDX" -> trimXdx
    | _ -> id


let scaleFactors (filename:string) =
    match filename with
    | IgnoreCase "chin2" ->
        // 127./144. 
        // 12.5->15 不用执行scale,只需要简单把end从144->127
        1.
    | IgnoreCase "design" ->
        2. // 高度127ok! 宽度应该改为100
    | IgnoreCase "SBHZ" ->
        127./16. // ok!
    | IgnoreCase "tssdchn" -> 1.0
    | IgnoreCase "XDX" ->
        127./115./13.*15. // 13 -> 15，字小了放大
    | _ -> 1.

let fromStartToEndBytes (fontWidth) =
    let h = Push.getBytes() |> List.exactlyOne
    let t =
        [
            Pop
            PenUp
            Displacement(fontWidth,0y) //确保能够移动到末尾
            EndOfShape
        ]
        |> List.collect(fun spec -> spec.getBytes())
    fun (bytes:int list) -> [h::bytes;t] |> List.concat

let splitLine (line: string) =
    if line.[0] = '*' then
        [None; Some(line.[1..])]
    else [Some line]

let renderShape (ranges) h w (mp:Map<uint16,string>) =
    [
        BigFont.renderShape ranges
        Shape0.renderShape h w
        for KeyValue(num,res) in mp do
            res
    ]
    |> String.concat "\r\n"

let trimPushPop (specifications:Specification list) =
    //去掉头
    let rec removeHead(specifications) =
        match specifications with
        | Push :: t -> t
        | _ -> Pop :: specifications

    //去掉尾部提笔移动到末尾的指令
    let removeTail(specifications1) =
        match List.rev specifications1 with
        | EndOfShape :: Displacement(_,0y) :: PenUp :: Pop :: specifications2 ->
            specifications2
            |> List.rev
            |> Some
        | _ -> None

    specifications
    |> removeHead
    |> removeTail
    |> Option.defaultValue []
