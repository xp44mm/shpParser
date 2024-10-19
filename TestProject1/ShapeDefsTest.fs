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
//open System.Reactive.Observable.Aliases
open System.Reactive.Linq
open type System.Linq.ParallelEnumerable
open FSharp.Idioms
open System.Collections.Generic

type ShapeDefsTest(output:ITestOutputHelper) =
    let getFileDef (filename : string) =
        let path = Path.Combine(Dir.solutionPath, filename+".SHP")
        let lines = File.ReadAllLines(path)

        lines
        |> ShapeDefsCompiler.parse

    [<Theory>]
    [<InlineData("pen/chin2")>]
    [<InlineData("pen/design")>]
    [<InlineData("pen/SBHZ")>]
    [<InlineData("pen/tssdchn")>]
    [<InlineData("pen/XDX")>]
    member _.``print spec``(filename : string) =
        let (title,font,shapes) = getFileDef filename
        let ranges = SpecificationUtils.getRanges title
        let fontHeight = SpecificationUtils.getFontHeight font

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
                    |> SpecificationUtils.getIntListFromLines
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
        let ranges = SpecificationUtils.getRanges title
        let fontHeight = SpecificationUtils.getFontHeight font

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
                    let outp = SpecificationUtils.fileSHP ranges fontHeight dict
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
                    |> SpecificationUtils.getIntListFromLines
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
        let ranges = SpecificationUtils.getRanges title
        let fontHeight = SpecificationUtils.getFontHeight font

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

                    let outp = SpecificationUtils.fileSHP ranges fontHeight newdict
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
                    |> SpecificationUtils.getIntListFromLines
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
    member _.``convert to pen``(filename : string) =
        let title,font,shapes = getFileDef filename
        let ranges = SpecificationUtils.getRanges title
        let fontHeight = SpecificationUtils.getFontHeight font

        let path =
            let filename = Path.GetFileNameWithoutExtension(filename)
            Path.Combine(Dir.solutionPath, "pen", filename+".SHP")
        let tcs = TaskCompletionSource()
        let dict = Dictionary<uint16,_>()
        let observer = {
            new IObserver<uint16*_> with
                member this.OnNext(x) =
                    let n,bytes = x
                    dict.Add(n,bytes)
                member this.OnError err = ()
                member this.OnCompleted() =
                    let outp = SpecificationUtils.fileSHP ranges fontHeight dict
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
                    |> SpecificationUtils.getIntListFromLines
                    |> SpecificationUtils.getSpecifications
                    // |> 此处增删改查
                    |> SpecificationUtils.distinctPen

                let bytes =
                    specs
                    |> List.collect(fun spec -> spec.getBytes())

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

