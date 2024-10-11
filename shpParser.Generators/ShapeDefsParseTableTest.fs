namespace shpParser

open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.xUnit
open FslexFsyacc
open FslexFsyacc.Fsyacc
open FslexFsyacc.Precedences
open FslexFsyacc.YACCs
open System.IO
open System.Text
open Xunit
open Xunit.Abstractions

type ShapeDefsParseTableTest(output:ITestOutputHelper) =
    let solutionPath = DirectoryInfo(__SOURCE_DIRECTORY__).Parent.FullName

    let parseTblName = "ShapeDefsParseTable"
    let parseTblModule = $"shpParser.{parseTblName}"
    let filePath = Path.Combine(__SOURCE_DIRECTORY__, "shapeDefs.fsyacc")

    let locatePath = Path.Combine(solutionPath,@"shpParser")
    let parseTblPath = Path.Combine(locatePath, $"{parseTblName}.fs")
            
    let text = File.ReadAllText(filePath, Encoding.UTF8)

    let rawFsyacc =
        text
        |> FsyaccCompiler2.compile

    let fsyacc =
        rawFsyacc
        |> FlatFsyaccFile.from

    let bnf = fsyacc.getBNF()

    // todo: %type 与 bnf 剥离
    let tbl =
        fsyacc.getYacc()

    let coder = FsyaccParseTableCoder.from fsyacc


    [<Fact>]
    member _.``01 - tbl``() =
        output.WriteLine(stringify tbl)

    [<Fact>]
    member _.``02 - list all symbols``() =
        output.WriteLine("tokens:")
        for i in bnf.grammar.terminals do
            output.WriteLine(stringify i)
        output.WriteLine("all:")
        for i in bnf.grammar.symbols do
            output.WriteLine(stringify i)
                    
    [<Fact>]
    member _.``03 - print conflict productions``() =
        let st = ConflictedProduction.from fsyacc.rules
        if st.IsEmpty then
            output.WriteLine("no conflict")
        for cp in st do
        output.WriteLine($"{stringify cp}")

    [<Fact>]
    member _.``04 - coder``() =
        output.WriteLine($"{stringify coder}")

    [<Fact>]
    member _.``05 - norm fsyacc file``() =
        let s0 = rawFsyacc.ruleGroups.Head.lhs
        let rules =
            fsyacc.rules
            //|> RuleSet.removeSymbols robust
            //|> RuleSet.removeHeads heads
            |> RuleSet.crawl s0
            //|> List.map(fun rule -> { rule with reducer = "" })

        let raw = fsyacc.toRaw(rules)
        let src = raw.toCode()

        output.WriteLine(src)

    [<Fact(
    Skip="按需更新源代码"
    )>]
    member _.``06 - generate ParseTable``() =
        let outp = coder.generateModule(parseTblModule)
        File.WriteAllText(parseTblPath, outp, Encoding.UTF8)
        output.WriteLine("output yacc:")
        output.WriteLine($"{parseTblPath}")

    //[<Fact>]
    //member _.``07 - valid ParseTable``() =
    //    Should.equal coder.tokens ShpParseTable.tokens
    //    Should.equal coder.kernels ShpParseTable.kernels
    //    Should.equal coder.actions ShpParseTable.actions

    //    //产生式比较
    //    let prodsFsyacc =
    //        fsyacc.rules
    //        |> Seq.map (fun rule -> rule.production)
    //        |> Seq.toList

    //    let prodsParseTable =
    //        ShpParseTable.rules
    //        |> List.map fst

    //    Should.equal prodsFsyacc prodsParseTable

    //    //header,semantic 代码比较
    //    let headerFromFsyacc =
    //        FSharp.Compiler.SyntaxTreeX.Parser.getDecls("header.fsx",fsyacc.header)

    //    let semansFsyacc =
    //        let mappers = coder.generateMappers()
    //        FSharp.Compiler.SyntaxTreeX.SourceCodeParser.semansFromMappers mappers

    //    let header,semans =
    //        let text = File.ReadAllText(parseTblPath, Encoding.UTF8)
    //        FSharp.Compiler.SyntaxTreeX.SourceCodeParser.getHeaderSemansFromFSharp 4 text

    //    Should.equal headerFromFsyacc header
    //    Should.equal semansFsyacc semans

