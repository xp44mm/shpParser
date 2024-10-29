namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type GBKTest(output:ITestOutputHelper) =
    [<Theory>]
    [<InlineData('　')>]
    [<InlineData('〓')>]
    [<InlineData('⒈')>]
    [<InlineData('ㄩ')>]
    [<InlineData('啊')>]
    member this.Code(c:char) =
        let y = GBK.code c
        output.WriteLine($"the {c}'s gbk is {y}")


    [<Theory>]
    [<InlineData(0us,'\000')>]
    [<InlineData(10us,'\n')>]
    [<InlineData(32us,' ')>]
    [<InlineData(0xB2E2us,'测')>]
    [<InlineData(43169us,'ā')>]
    [<InlineData(43205us,'ㄅ')>]
    [<InlineData(43205us,'德')>]
    [<InlineData(41433us,'≠')>]

    member this.Hanzi(i:uint16,c:char) =

        let hz = GBK.hanzi(i)
        output.WriteLine($"{hz}")
        let y = GBK.code c
        output.WriteLine($"{y}")

        Should.equal c hz

        Should.equal i y
