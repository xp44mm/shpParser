module shpParser.GBK
open System
open System.Text
open FSharp.Idioms.Literal

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
let encoding = Encoding.GetEncoding("GBK")

/// 调整字节数组顺序适应于操作系统内存
let adapt (bytes:byte[]) =
    if bytes.Length > 1 && BitConverter.IsLittleEndian then
        bytes |> Array.rev
    else bytes
    
let hanzi (i:uint16) =
    if i < 128us then
        char i
    else
        // 将整数编码转换为字节序列
        BitConverter.GetBytes(i)
        |> adapt
        |> encoding.GetChars
        |> Array.exactlyOne

let code (c:char) =
    if c < char 128uy then
        uint16 c
    else
        let bytes = 
            encoding.GetBytes [|c|]
            |> adapt
        BitConverter.ToUInt16(bytes,0)

/// 编码在沟里，不包含边界，输入参数a要小于b
let gap (a:char) (b:char) =
    let ac = code a
    let bc = code b
    if ac >= bc then failwith "输入参数a要小于b"
    fun i -> ac < i && i < bc

/// 编码在范围里，包含边界
let inrange (a:char) (b:char) =
    let ac = code a
    let bc = code b
    if ac > bc then failwith "输入参数a要小于b"
    fun i -> ac <= i && i <= bc

let gaps  =
    [
        gap ' ' '　' //全角空格
        gap '〓' '⒈'
        gap '⑩' '㈠'
        gap '㈩' 'Ⅰ'
        gap 'Ⅻ' '！'
        gap 'ん' 'ァ'
        gap 'ヶ' 'Α'
        gap 'Ω' 'α'
        gap 'ω' 'А'
        gap 'Я' 'а'
        gap 'я' 'ā'
        gap 'ɡ' 'ㄅ'
        gap 'ㄩ' '啊'
        gap '座' '亍'

    ]
            
