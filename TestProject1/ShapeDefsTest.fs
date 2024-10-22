namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms
open System.Threading.Tasks
open System.Reactive
open System.Reactive.Linq
open type System.Linq.ParallelEnumerable
open FSharp.Idioms
open System.Collections.Generic
open FSharp.Idioms.OrdinalIgnoreCase

type ShapeDefsTest(output:ITestOutputHelper) =
    let getFileDef (filename : string) =
        let path = Path.Combine(Dir.solutionPath, filename+".SHP")
        let lines = File.ReadAllLines(path)

        lines
        |> ShapeDefsCompiler.parse

    [<Theory>]
    [<InlineData("scale/chin2")>]
    [<InlineData("scale/design")>]
    [<InlineData("scale/SBHZ")>]
    [<InlineData("scale/tssdchn")>]
    [<InlineData("scale/XDX")>]
    member _.``print spec``(filename : string) =
        let (title,font,shapes) = getFileDef filename
        let ranges = BigFont.getRanges title
        let fontHeight = Shape0.getFontHeight font

        let path =
            //let filename = Path.GetFileNameWithoutExtension(filename)
            Path.Combine(Dir.solutionPath, filename+".shape")
        let tcs = TaskCompletionSource()
        let dict = Dictionary<_,_>()
        let observer = {
            new IObserver<uint16*_> with
                member this.OnNext(x) =
                    let n,specs = x
                    dict.Add(n,specs)
                member this.OnError err = ()
                member this.OnCompleted() =
                    let outp = SpecificationUtils.fileShape ranges fontHeight dict
                    File.WriteAllText(path, outp, Encoding.UTF8)
                    output.WriteLine("生成新文件:")
                    output.WriteLine(path)
                    tcs.SetResult()
        }

        shapes
            .ToObservable()
            .SelectMany(fun (n,lines) -> task {
                let specs =
                    lines.Tail
                    |> Number.getIntListFromLines
                    |> SpecificationUtils.getSpecifications
                    // |> 此处增删改查

                return n,specs
                })
            .Synchronize()
            .Subscribe(observer)
        |> ignore

        tcs.Task

    [<Theory>]
    [<InlineData("SHX/chin2")>]
    [<InlineData("SHX/design")>]
    [<InlineData("SHX/SBHZ")>]
    [<InlineData("SHX/tssdchn")>]
    [<InlineData("SHX/XDX")>]
    member _.``print modes0 from shx``(filename : string) =
        let title,font,shapes = getFileDef filename
        let ranges = BigFont.getRanges title
        let fontHeight = Shape0.getFontHeight font

        let path =
            let filename = Path.GetFileNameWithoutExtension(filename)
            Path.Combine(Dir.solutionPath, "modes0", filename+".SHP")
        let tcs = TaskCompletionSource()
        let dict = Dictionary<_,_>()
        let observer = {
            new IObserver<uint16*_> with
                member this.OnNext(x) =
                    let n,bytes = x
                    dict.Add(n,bytes)
                member this.OnError err = ()
                member this.OnCompleted() =
                    let outp = SHP.fileSHP ranges fontHeight dict
                    File.WriteAllText(path, outp, Encoding.ASCII)
                    output.WriteLine("生成新文件:")
                    output.WriteLine(path)
                    tcs.SetResult()
        }

        shapes
            .ToObservable()
            .SelectMany(fun (n,lines) -> task {
                let specs =
                    lines.Tail
                    |> Number.getIntListFromLines
                    |> SpecificationUtils.getSpecifications
                    // |> 此处增删改查
                    |> List.filter(fun spec ->
                        match spec with
                        | VerticalText _ -> false
                        | _ -> true
                    )

                let bytes =
                    specs
                    |> List.collect(fun spec -> spec.getBytes())

                return n,bytes
                })
            .Synchronize()
            .Subscribe(observer)
        |> ignore

        tcs.Task

    [<Theory>]
    [<InlineData("modes0/chin2")>]
    [<InlineData("modes0/design")>]
    [<InlineData("modes0/SBHZ")>]
    [<InlineData("modes0/tssdchn")>]
    [<InlineData("modes0/XDX")>]
    member _.``convert to dissolve``(filename: string) =
        let title,font,shapes = getFileDef filename
        let ranges = BigFont.getRanges title
        let fontHeight = Shape0.getFontHeight font

        let path =
            let filename = Path.GetFileNameWithoutExtension(filename)
            Path.Combine(Dir.solutionPath, "dissolve", filename+".SHP")

        let tcs = TaskCompletionSource()
        let dict = Dictionary<_,_>()
        let observer = {
            new IObserver<uint16*_> with
                member this.OnNext(x) =
                    let n,bytes = x
                    dict.Add(n,bytes)
                member this.OnError err = ()
                member this.OnCompleted() =
                    let newdict = 
                        SpecificationUtils.dissolve dict // dissolve subshape
                        |> Map.fromInterface
                        |> Map.map(fun i specs -> 
                            specs 
                            |> List.collect (fun spec -> spec.getBytes()))
                        |> Map.filter(fun i _ -> i > 127us) // remove ascii
                        |> Dictionary

                    let outp = SHP.fileSHP ranges fontHeight newdict
                    File.WriteAllText(path, outp, Encoding.ASCII)
                    output.WriteLine("生成新文件:")
                    output.WriteLine(path)
                    tcs.SetResult()
        }

        shapes
            .ToObservable()
            .SelectMany(fun (n,lines) -> task {
                let specs =
                    lines.Tail
                    |> Number.getIntListFromLines
                    |> SpecificationUtils.getSpecifications

                return n,specs
                })
            .Synchronize()
            .Subscribe(observer)
        |> ignore

        tcs.Task

    [<Theory>]
    [<InlineData("dissolve/chin2")>]
    [<InlineData("dissolve/design")>]
    [<InlineData("dissolve/SBHZ")>]
    [<InlineData("dissolve/tssdchn")>]
    [<InlineData("dissolve/XDX")>]
    member _.``trim from dissolve``(filename:string) =
        let name = Path.GetFileNameWithoutExtension(filename)
        let title,font,shapes = getFileDef filename
        let ranges = BigFont.getRanges title
        let fontHeight = Shape0.getFontHeight font
            
        let path =
            Path.Combine(Dir.solutionPath, "trim", name+".SHP")
        let tcs = TaskCompletionSource()
        let dict = Dictionary<uint16,int list>()
        let observer = {
            new IObserver<uint16*int list> with
                member this.OnNext(x) =
                    let n,bytes = x
                    dict.Add(n,bytes)
                member this.OnError err = ()
                member this.OnCompleted() =
                    let outp = SHP.fileSHP ranges fontHeight dict
                    File.WriteAllText(path, outp, Encoding.ASCII)
                    output.WriteLine("生成新文件:")
                    output.WriteLine(path)
                    tcs.SetResult()
        }

        shapes
            .ToObservable()
            .SelectMany(fun (n,lines) -> task {                
                let bytes =
                //let specs =
                    lines.Tail
                    |> Number.getIntListFromLines
                    |> SpecificationUtils.getSpecifications
                
                    // |> 此处增删改查
                    |> match name with
                       | "chin2" -> SpecificationUtils.trimChin2
                       | "design" -> SpecificationUtils.trimDesign
                       | "SBHZ" -> SpecificationUtils.trimSbhz
                       | "tssdchn" -> SpecificationUtils.trimTssd
                       | "XDX" -> SpecificationUtils.trimXdx
                       | _ -> id
                    //specs
                    |> List.collect(fun spec -> spec.getBytes())
                return n,bytes
                })
            .Where(fun(n,bytes) -> bytes.IsEmpty |> not || n = 41377us)
            .Synchronize()
            .Subscribe(observer)
        |> ignore

        tcs.Task

    [<Theory>]
    [<InlineData("trim/chin2")>]
    [<InlineData("trim/design")>]
    [<InlineData("trim/SBHZ")>]
    [<InlineData("trim/tssdchn")>]
    [<InlineData("trim/XDX")>]
    member _.``pen from trim``(filename:string) =
        let name = Path.GetFileNameWithoutExtension(filename)
        let title,font,shapes = getFileDef filename
        let ranges = BigFont.getRanges title
        let fontHeight = Shape0.getFontHeight font
            
        let path =
            Path.Combine(Dir.solutionPath, "pen", name+".SHP")
        let tcs = TaskCompletionSource()
        let dict = Dictionary<uint16,int list>()
        let observer = {
            new IObserver<uint16*int list> with
                member this.OnNext(x) =
                    let n,bytes = x
                    dict.Add(n,bytes)
                member this.OnError err = ()
                member this.OnCompleted() =
                    let outp = SHP.fileSHP ranges fontHeight dict
                    File.WriteAllText(path, outp, Encoding.ASCII)
                    output.WriteLine("生成新文件:")
                    output.WriteLine(path)
                    tcs.SetResult()
        }

        shapes
            .ToObservable()
            .SelectMany(fun (n,lines) -> task {                
                let bytes =
                //let specs =
                    lines.Tail
                    |> Number.getIntListFromLines
                    |> SpecificationUtils.getSpecifications
                
                    // 此处增删改查
                    |> SpecificationUtils.distinctPen
                    //specs
                    |> List.collect(fun spec -> spec.getBytes())
                return n,bytes
                })
            .Where(fun(n,bytes) -> bytes.IsEmpty |> not || n = 41377us)
            .Synchronize()
            .Subscribe(observer)
        |> ignore

        tcs.Task

    [<Theory>]
    [<InlineData("pen/chin2")>]
    [<InlineData("pen/design")>]
    [<InlineData("pen/SBHZ")>]
    [<InlineData("pen/tssdchn")>]
    [<InlineData("pen/XDX")>]
    member _.``scale from pen``(filename:string) =
        let fnm = Path.GetFileNameWithoutExtension(filename)
        let i = SpecificationUtils.scaleFactors fnm
        let path = Path.Combine(Dir.solutionPath, "scale", fnm+".SHP")

        let fontHeight = 
            //SpecificationUtils.getFontHeight font
            127y

        let fontWidth =
            if fnm == "design" then 100y else 127y
            
        let title,font,shapes = getFileDef filename
        let ranges = BigFont.getRanges title


        let tcs = TaskCompletionSource()
        let dict = Dictionary<uint16,int list>()
        let observer = {
            new IObserver<uint16*int list> with
                member this.OnNext(x) =
                    let n,bytes = x
                    dict.Add(n,bytes)
                member this.OnError err = ()
                member this.OnCompleted() =
                    // todo: font 0,5
                    let outp = SHP.fileSHP ranges (int fontHeight) dict
                    File.WriteAllText(path, outp, Encoding.ASCII)
                    output.WriteLine("生成新文件:")
                    output.WriteLine(path)
                    tcs.SetResult()
        }

        shapes
            .ToObservable()
            .SelectMany(fun (n,lines) -> task {                
                let specs =
                    lines.Tail
                    |> Number.getIntListFromLines
                    |> SpecificationUtils.getSpecifications
                    // |> 此处增删改查
                    |> List.map(fun spec -> spec.scale i)

                let bytes =
                    specs 
                    |> List.collect(fun spec -> spec.getBytes())
                    |> SpecificationUtils.fromStartToEndBytes fontWidth
                return n,bytes
                })
            .Synchronize()
            .Subscribe(observer)
        |> ignore

        tcs.Task




    //[<Theory>]
    //[<InlineData("Hei")>]
    //member _.``获取汉字全集``(filename : string) =
    //    let filename = filename
    //    let y = getFileDef filename

    //    let ls =
    //        y.shapes
    //        |> List.map(fun s -> s.shapenumber)
    //        |> List.filter(fun n -> n > 127us)
    //        |> List.sort
    //        |> List.map(GBK.hanzi)

    //    let a =
    //        ls
    //        |> List.findIndex(fun s -> s = '啊')

    //    let ls0 = ls.[0..a-1]
    //    let ls1 = ls.[a..]

    //    output.WriteLine($"标点符号数:{ls0.Length}")
    //    output.WriteLine($"汉字数:{ls1.Length}")

    //    let sprintls ls size =
    //        ls
    //        |> List.chunkBySize size
    //        |> List.map (List.toArray>>String)
    //        |> String.concat "\r\n"

    //    let p = sprintls ls0 60
    //    let w = sprintls ls1 80

    //    let outp = [p;w] |> String.concat "\r\n"

    //    //let outp =  ls |> Array.ofList |> String
    //    let path = Path.Combine(Dir.solutionPath, filename+".txt")
    //    File.WriteAllText(path, outp, Encoding.UTF8)
    //    output.WriteLine("生成新文件:")
    //    output.WriteLine(path)



    //[<Theory>]
    //[<InlineData("dissolve/chin2")>]
    //[<InlineData("dissolve/design")>]
    //[<InlineData("dissolve/SBHZ")>]
    //[<InlineData("dissolve/tssdchn")>]
    //[<InlineData("dissolve/XDX")>]
    //member _.``convert to pen``(filename : string) =
    //    let title,font,shapes = getFileDef filename
    //    let ranges = SpecificationUtils.getRanges title
    //    let fontHeight = SpecificationUtils.getFontHeight font
    //    let path =
    //        let filename = Path.GetFileNameWithoutExtension(filename)
    //        Path.Combine(Dir.solutionPath, "pen", filename+".SHP")
    //    let tcs = TaskCompletionSource()
    //    let dict = Dictionary<uint16,_>()
    //    let observer = {
    //        new IObserver<uint16*_> with
    //            member this.OnNext(x) =
    //                let n,bytes = x
    //                dict.Add(n,bytes)
    //            member this.OnError err = ()
    //            member this.OnCompleted() =
    //                let outp = SpecificationUtils.fileSHP ranges fontHeight dict
    //                File.WriteAllText(path, outp, Encoding.ASCII)
    //                output.WriteLine("生成新文件:")
    //                output.WriteLine(path)
    //                tcs.SetResult()
    //    }
    //    shapes
    //        .ToObservable()
    //        .SelectMany(fun (n,lines) -> task {
    //            let specs =
    //                lines.Tail
    //                |> SpecificationUtils.getIntListFromLines
    //                |> SpecificationUtils.getSpecifications
    //                // |> 此处增删改查
    //                |> SpecificationUtils.distinctPen
    //            let bytes =
    //                specs
    //                |> List.collect(fun spec -> spec.getBytes())
    //            return n,bytes
    //            })
    //        .Synchronize()
    //        .Subscribe(observer)
    //    |> ignore
    //    tcs.Task

    //[<Fact>]
    //member _.``scale design to foreach``() =
    //    let filename = "dissolve/design"
    //    let title,font,shapes = getFileDef filename
    //    let ranges = SpecificationUtils.getRanges title
    //    let fontHeight = SpecificationUtils.getFontHeight font
            
    //    let path =
    //        let filename = Path.GetFileNameWithoutExtension(filename)
    //        Path.Combine(Dir.solutionPath, "foreach", filename+".SHP")
    //    let tcs = TaskCompletionSource()
    //    let dict = Dictionary<uint16,_>()
    //    let observer = {
    //        new IObserver<uint16*_> with
    //            member this.OnNext(x) =
    //                let n,bytes = x
    //                dict.Add(n,bytes)
    //            member this.OnError err = ()
    //            member this.OnCompleted() =
    //                let outp = SpecificationUtils.fileSHP ranges 127 dict
    //                File.WriteAllText(path, outp, Encoding.ASCII)
    //                output.WriteLine("生成新文件:")
    //                output.WriteLine(path)
    //                tcs.SetResult()
    //    }

    //    shapes
    //        .ToObservable()
    //        .SelectMany(fun (n,lines) -> task {
    //            let specs =
    //                lines.Tail
    //                |> SpecificationUtils.getIntListFromLines
    //                |> SpecificationUtils.getSpecifications
    //                // |> 此处增删改查
    //                |> SpecificationUtils.scaleDesign

    //            let bytes =
    //                specs
    //                |> List.collect(fun spec -> spec.getBytes())
    //                |> SpecificationUtils.fromStartToEndBytes 100y
    //            return n,bytes
    //            })
    //        .Synchronize()
    //        .Subscribe(observer)
    //    |> ignore

    //    tcs.Task


    //[<Fact>]
    //member _.``scale chin2 to foreach``() =
    //    let filename = "dissolve/chin2"
    //    let title,font,shapes = getFileDef filename
    //    let ranges = SpecificationUtils.getRanges title
    //    let fontHeight = SpecificationUtils.getFontHeight font
            
    //    let path =
    //        let filename = Path.GetFileNameWithoutExtension(filename)
    //        Path.Combine(Dir.solutionPath, "foreach", filename+".SHP")
    //    let tcs = TaskCompletionSource()
    //    let dict = Dictionary<uint16,_>()
    //    let observer = {
    //        new IObserver<uint16*_> with
    //            member this.OnNext(x) =
    //                let n,bytes = x
    //                dict.Add(n,bytes)
    //            member this.OnError err = ()
    //            member this.OnCompleted() =
    //                let outp = SpecificationUtils.fileSHP ranges 127 dict
    //                File.WriteAllText(path, outp, Encoding.ASCII)
    //                output.WriteLine("生成新文件:")
    //                output.WriteLine(path)
    //                tcs.SetResult()
    //    }

    //    shapes
    //        .ToObservable()
    //        .SelectMany(fun (n,lines) -> task {                
    //            let specs =
    //                lines.Tail
    //                |> SpecificationUtils.getIntListFromLines
    //                |> SpecificationUtils.getSpecifications
    //                // |> 此处增删改查
    //                |> SpecificationUtils.scaleChin2

    //            let bytes =
    //                specs
    //                |> List.collect(fun spec -> spec.getBytes())
    //                |> SpecificationUtils.fromStartToEndBytes 127y
    //            return n,bytes
    //            })
    //        .Synchronize()
    //        .Subscribe(observer)
    //    |> ignore

    //    tcs.Task

    //[<Fact>]
    //member _.``scale sbhz to foreach``() =
    //    let filename = "dissolve/sbhz"
    //    let title,font,shapes = getFileDef filename
    //    let ranges = SpecificationUtils.getRanges title
    //    let fontHeight = SpecificationUtils.getFontHeight font
            
    //    let path =
    //        let filename = Path.GetFileNameWithoutExtension(filename)
    //        Path.Combine(Dir.solutionPath, "foreach", filename+".SHP")
    //    let tcs = TaskCompletionSource()
    //    let dict = Dictionary<uint16,_>()
    //    let observer = {
    //        new IObserver<uint16*_> with
    //            member this.OnNext(x) =
    //                let n,bytes = x
    //                dict.Add(n,bytes)
    //            member this.OnError err = ()
    //            member this.OnCompleted() =
    //                let outp = SpecificationUtils.fileSHP ranges 127 dict
    //                File.WriteAllText(path, outp, Encoding.ASCII)
    //                output.WriteLine("生成新文件:")
    //                output.WriteLine(path)
    //                tcs.SetResult()
    //    }

    //    shapes
    //        .ToObservable()
    //        .SelectMany(fun (n,lines) -> task {                
    //            let specs =
    //                lines.Tail
    //                |> SpecificationUtils.getIntListFromLines
    //                |> SpecificationUtils.getSpecifications
    //                // |> 此处增删改查
    //                |> SpecificationUtils.scaleSbhz

    //            let bytes =
    //                specs
    //                |> List.collect(fun spec -> spec.getBytes())
    //                //|> SpecificationUtils.fromStartToEndBytes 127y
    //            return n,bytes
    //            })
    //        .Synchronize()
    //        .Subscribe(observer)
    //    |> ignore

    //    tcs.Task

    //[<Fact>]
    //member _.``scale xdx to foreach``() =
    //    let filename = "dissolve/xdx"
    //    let title,font,shapes = getFileDef filename
    //    let ranges = SpecificationUtils.getRanges title
    //    let fontHeight = SpecificationUtils.getFontHeight font
            
    //    let path =
    //        let filename = Path.GetFileNameWithoutExtension(filename)
    //        Path.Combine(Dir.solutionPath, "foreach", filename+".SHP")
    //    let tcs = TaskCompletionSource()
    //    let dict = Dictionary<uint16,_>()
    //    let observer = {
    //        new IObserver<uint16*_> with
    //            member this.OnNext(x) =
    //                let n,bytes = x
    //                dict.Add(n,bytes)
    //            member this.OnError err = ()
    //            member this.OnCompleted() =
    //                let outp = SpecificationUtils.fileSHP ranges 127 dict
    //                File.WriteAllText(path, outp, Encoding.ASCII)
    //                output.WriteLine("生成新文件:")
    //                output.WriteLine(path)
    //                tcs.SetResult()
    //    }

    //    shapes
    //        .ToObservable()
    //        .SelectMany(fun (n,lines) -> task {                
    //            let specs =
    //                lines.Tail
    //                |> SpecificationUtils.getIntListFromLines
    //                |> SpecificationUtils.getSpecifications
    //                // |> 此处增删改查
    //                |> SpecificationUtils.scaleXdx

    //            let bytes =
    //                specs @ [ EndOfShape ]
    //                |> List.collect(fun spec -> spec.getBytes())
    //                //|> SpecificationUtils.fromStartToEndBytes 127y
    //            return n,bytes
    //            })
    //        .Synchronize()
    //        .Subscribe(observer)
    //    |> ignore

    //    tcs.Task
