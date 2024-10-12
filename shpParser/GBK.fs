module shpParser.GBK
open System
open System.Text

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
let encoding = Encoding.GetEncoding("GBK")

/// 调整字节数组顺序适应于操作系统内存
let adapt (bytes:byte[]) =
    if bytes.Length > 1 && BitConverter.IsLittleEndian then
        bytes |> Array.rev
    else bytes
    
let hanzi (i:uint16) =
    // 将整数编码转换为字节序列
    let bytes = BitConverter.GetBytes(i) |> adapt
    encoding.GetString(bytes)

let code (s:string) =
    let bytes = encoding.GetBytes(s) |> adapt 
    BitConverter.ToUInt16(bytes,0)
