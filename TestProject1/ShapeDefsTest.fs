namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type ShapeDefsTest(output:ITestOutputHelper) =

    let getFileDef (filename : string) =
        let path = Path.Combine(Dir.solutionPath, "SHP", filename+".SHP")
        let lines = File.ReadAllLines(path, Encoding.UTF8)

        lines
        |> ShapeDefsCompiler.parse
        |> FileDef.from

    [<Fact>]    
    member _.``File Def get Title``() =
        let file =
            {
                title = "BIGFONT 7447,4,161,163,166,167,169,169,176,247"
                shapes = []
            }

        let y = file.getTitle(100)
        let e = "BIGFONT 100,4,161,163,166,167,169,169,176,247"
        Should.equal e y


    [<Theory>]
    [<InlineData("hei")>]
    [<InlineData("kai")>]

    member _.``format shp``(filename : string) =
        let y = getFileDef filename

        let ls =
            y.shapes
            |> List.map(fun shp -> // 删除附注
                {
                    shp with
                        rows = shp.removeComment() :: shp.rows.Tail
                }
            )
            |> List.filter(fun shp -> // 删除字符
                GBK.gaps
                |> Seq.forall(fun gap -> gap shp.shapenumber |> not)
            )
            |> List.sortBy(fun s -> s.shapenumber) //按照GBK排序

        let newfile =
            {
                title = y.getTitle(ls.Length-1) //更新总字数
                shapes = ls
            }

        let outp = newfile.render()

        let path = Path.Combine(Dir.solutionPath, "SHP", filename+"1.SHP")
        File.WriteAllText(path, outp, Encoding.ASCII)
        output.WriteLine("生成新文件:")
        output.WriteLine(path)


    [<Theory>]
    [<InlineData("Hei")>]
    member _.``获取汉字全集``(filename : string) =
        let filename = filename
        let y = getFileDef filename

        let ls =
            y.shapes
            |> List.map(fun s -> s.shapenumber)
            |> List.filter(fun n -> n > 127us)
            |> List.sort
            |> List.map(GBK.hanzi)

        let a =
            ls
            |> List.findIndex(fun s -> s = '啊')

        let ls0 = ls.[0..a-1]
        let ls1 = ls.[a..]

        output.WriteLine($"标点符号数:{ls0.Length}")
        output.WriteLine($"汉字数:{ls1.Length}")

        let sprintls ls size =
            ls
            |> List.chunkBySize size
            |> List.map (List.toArray>>String)
            |> String.concat "\r\n"

        let p = sprintls ls0 60
        let w = sprintls ls1 80
        
        let outp = [p;w] |> String.concat "\r\n"

        //let outp =  ls |> Array.ofList |> String
        let path = Path.Combine(Dir.solutionPath, filename+".txt")
        File.WriteAllText(path, outp, Encoding.UTF8)
        output.WriteLine("生成新文件:")
        output.WriteLine(path)

    [<Fact>]
    member _.``union GBK``() =
        let filenames =
            [
                "tssdchn1"
                "hgcadhz1"
                "intecad1"
            ]

        let codes = 
            filenames
            |> List.map getFileDef
            |> List.map(fun def ->
                def.shapes
                |> List.map(fun s -> s.shapenumber)
            )
            |> List.concat
            |> Set.ofList
            |> Set.filter(fun n -> n > 127us)
            |> Set.toList
            |> List.map(GBK.hanzi)

        let a =
            codes
            |> List.findIndex(fun s -> s = '啊')

        let ls0 = codes.[0..a-1]
        let ls1 = codes.[a..]

        output.WriteLine($"标点符号数:{ls0.Length}")
        output.WriteLine($"汉字数:{ls1.Length}")

        let sprintls ls size =
            ls
            |> List.chunkBySize size
            |> List.map (Array.ofList>>String)
            |> String.concat "\r\n"

        let p = sprintls ls0 40
        let w = sprintls ls1 80

        let outp = [p;w] |> String.concat "\r\n"

        let path = Path.Combine(Dir.solutionPath, "gbk.txt")
        File.WriteAllText(path, outp, Encoding.UTF8)
        output.WriteLine("生成新文件:")
        output.WriteLine(path)

    [<Fact>]
    member _.``生成楷体``() =
        let tssd =
            let filename = "tssdchn1"
            getFileDef filename

        /// 从tssd中复制ascii
        let ascii =
            tssd.shapes
            |> List.filter(fun s -> 0us < s.shapenumber && s.shapenumber < 128us)

        let y =
            let filename = "intecad1"
            getFileDef filename

        let shapes =
            [
                yield! y.shapes
                yield! ascii
            ]
            |> List.distinctBy (fun s -> s.shapenumber)
            |> List.sortBy (fun s -> s.shapenumber)

        let newfile =
            {
                title = y.getTitle(shapes.Length-1) //更新总字数
                shapes = shapes
            }

        let outp = newfile.render()

        let path = Path.Combine(Dir.solutionPath, "SHP", "Kai.SHP")
        File.WriteAllText(path, outp, Encoding.ASCII)
        output.WriteLine("生成新文件:")
        output.WriteLine(path)


    [<Fact>]
    member _.``生成黑体``() =
        let sb =
            let filename = "SBHZ1"
            getFileDef filename

        /// 从tssd中复制ascii
        let pp =
            sb.shapes
            |> List.filter(fun s -> 
                let a = GBK.code '　' //全角空格\
                let b = GBK.code '啊'
                a <= s.shapenumber && s.shapenumber < b
            )
            |> List.filter(fun s ->
                s.shapenumber = GBK.code '　'
                || s.rows <> [
                    "5"
                    "2,8,(16,0),0"
                ]
            )
            |> List.map(fun s ->
                let r0 = (int s.rows.Head + 4).ToString()
                let r1 = "3,14,"
                let r = s.rows.Tail
                let r2 = r.[0..r.Length-2]
                let r3 = (List.last r).TrimEnd('0') + "4,14,0"
                 
                {
                    shapenumber = s.shapenumber
                    rows = [
                        yield r0
                        yield r1
                        yield! r2
                        yield r3
                    ]
                }
            )

        output.WriteLine($"sb:{pp.Length}")
        let xdx =
            let filename = "xdx1"
            getFileDef filename

        let shapes =
            [
                yield! pp
                yield! xdx.shapes
            ]
            |> List.distinctBy (fun s -> s.shapenumber)
            |> List.sortBy(fun s -> s.shapenumber) //按照GBK排序

        let newfile =
            {
                title = xdx.getTitle(shapes.Length-1) //更新总字数
                shapes = shapes
            }

        let outp = newfile.render()

        let path = Path.Combine(Dir.solutionPath, "SHP", "Hei.SHP")
        File.WriteAllText(path, outp, Encoding.ASCII)
        output.WriteLine("生成新文件:")
        output.WriteLine(path)
