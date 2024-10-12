module shpParser.GBK
open System
open System.Text
open System.IO

//需要注册Instance
 
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance) 
let encoding = Encoding.GetEncoding("GBK")

/// 调整字节数组顺序适应于操作系统
let adapt (bytes:byte[]) =
    if bytes.Length > 1 && BitConverter.IsLittleEndian then
        bytes |> Array.rev
    else bytes
    
let hanzi (i:int) =
    if i < 0 || i > int UInt16.MaxValue then
        failwith "GBK 2 BITS OVERFLOW"
    else
    let i = uint16 i
    // 将整数编码转换为字节序列
    let bytes = BitConverter.GetBytes(i) |> adapt
    encoding.GetString(bytes)

let code (s:string) =
    let bytes = encoding.GetBytes(s) |> adapt 
    let y = BitConverter.ToUInt16(bytes,0)
    int y

//byte[] bytes = { 0x78, 0x56, 0x34, 0x12 }; // 小端字节数组
//int number = (bytes[0] << 0) | (bytes[1] << 8) | (bytes[2] << 16) | (bytes[3] << 24);
//Console.WriteLine(number); // 输出整数
