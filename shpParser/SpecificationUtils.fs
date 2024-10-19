module shpParser.SpecificationUtils
open System
open System.Collections.Generic
open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps

let splitIntList (l:string) =
    let separator = [|',';'(';')'|]
    l.Split(separator,StringSplitOptions.RemoveEmptyEntries)
    |> Array.map(fun s -> Number.parseSign (s.Trim()))

let getIntListFromLines (lines: string list) =
    lines
    |> List.collect(splitIntList>>Array.toList)

let getSpecifications (ls:int list) =
    ls
    |> List.unfold(fun state ->
        match state with
        | [] -> None
        | _ -> Some(Specification.from state)
    )

/// 改进算法
let renderSHP (num:uint16) (bytes:int list) =
    let COLUMN = 80
    let tryline (text:string) =
        if text = "" then
            None
        elif text.Length <= COLUMN then
            Some(text,"")
        else
            let i = text.[0..COLUMN-1].LastIndexOf ','
            Some(text.[0..i],text.[i+1..])
    let lines =
        bytes 
        |> Seq.map(fun i -> i.ToString()) 
        |> String.concat ","
        |> Seq.unfold(tryline)

    [
        $"*{num},{bytes.Length}"
        yield! lines
    ]
    |> String.concat "\r\n"

let getRanges (title:string) =
    if title.Substring(0,8) == "BIGFONT " then
        title.Substring(8).Split([|','|],StringSplitOptions.RemoveEmptyEntries)
        |> Array.map(fun s -> s.Trim() |> Number.parse)
        |> Array.toList
        |> List.tail // 丢弃字数，新程序将重新计算字数
    else
        raise <| NotImplementedException title

let renderTitle (count:int) (ranges:int list) =
    let pairs =
        ranges.Tail
        |> List.map(sprintf "0%X")
        |> String.concat ","

    $"*BIGFONT {count},{ranges.Head},{pairs}"
    
let getFontHeight(font:string list) = 
    let line = font.Tail.Head
    let ss = line.Split([|','|],2).[0].Trim()
    Number.parse ss
    
let renderFont (height:int) =
    [
        "*0,4"
        $"{height},0,0,0"
    ]
    |> String.concat "\r\n"

let fileSHP (ranges) (fontHeight) (dict:Dictionary<uint16,_>) =
    [
        renderTitle dict.Count ranges
        renderFont fontHeight
        for shpnum,bytes in 
            dict 
            |> Seq.map(fun (KeyValue(shpnum,bytes)) -> shpnum,bytes)
            |> Seq.sortBy fst
            do
            renderSHP shpnum bytes
        ""
    ]
    |> String.concat "\r\n"


let renderSpecifications (shpnum) (specifications:Specification list) =
    let hanzi = GBK.hanzi shpnum
    [
        $"*{shpnum}" + if Char.IsControl hanzi then "" else $",{hanzi}"
        for spec in specifications do
            "  " + spec.render()

    ]
    |> String.concat "\r\n"

let fileShape (ranges) (fontHeight) (dict:Dictionary<uint16,Specification list>) =
    [
        $"ranges={stringify ranges}"
        $"fontHeight={fontHeight}"
        for shpnum,specifications in 
            dict 
            |> Seq.map(fun (KeyValue(shpnum,specifications)) -> shpnum,specifications)
            |> Seq.sortBy fst        
            do
            renderSpecifications shpnum specifications
        ""
    ]
    |> String.concat "\r\n"

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

let distinctPen (specifications:Specification list) =
    let rec loop acc (updown:Specification) rest =
        match rest with
        | [] -> acc |> List.rev
        | h::t ->
            match h with
            | PenUp | PenDown ->
                if h = updown then
                    loop acc updown t
                else
                    loop (h::acc) h t
            | _ ->
                loop (h::acc) updown t

    let rec tryFindPen acc rest =
        match rest with
        | [] -> None
        | h::t ->
            match h with
            | PenUp | PenDown ->
                Some(h::acc,h,t)
            | _ ->
                tryFindPen (h::acc) t
        
    match
        tryFindPen [] specifications
    with
    | None -> specifications
    | Some(acc,updown,rest) -> loop acc updown rest

/// todo: 等价替换下三种
    //| OctantArc of byte*sbyte                 // 00A 计算弦向量和弦高
    //| FractionalArc of byte*byte*uint16*sbyte // 00B
    //| Vector of byte   转换角度为1,0/2,1/1,1/0,1其他象限等同
