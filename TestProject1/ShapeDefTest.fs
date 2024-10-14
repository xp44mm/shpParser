namespace shpParser

open Xunit
open Xunit.Abstractions

open System.IO
open System
open System.Text

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type ShapeDefTest(output:ITestOutputHelper) =

    [<Theory>]
    [<InlineData("*0,4,HZ..YI.XUN 2/22/88")>]
    [<InlineData("14,0,0,0")>]
    [<InlineData("*1,2")>]
    [<InlineData("5,0")>]
    [<InlineData("*10,5")>]
    [<InlineData("2,8,(0,-20),0")>]
    [<InlineData("*13,2")>]
    [<InlineData("6,0")>]
    [<InlineData("*32,5")>]
    [<InlineData("2,8,(18,0),0")>]
    [<InlineData("*33,159")>]
    member _.StringSplit2(x : string) =
        let y = 
            x.Split([|','|],2)
        output.WriteLine(stringify y)

    [<Theory>]
    [<InlineData("129,砀")>]
    [<InlineData("145,磔")>]
    [<InlineData("89,罡")>]
    [<InlineData("97,钶")>]
    member _.``removeComment``(firstline : string) =
        let def = {
            shapenumber = 0us
            rows = [firstline]
        }
        let y = def.removeComment()
        let e = firstline.[0..firstline.Length-3]

        Should.equal e y

    [<Theory>]
    [<InlineData(0us,'\000')>]
    [<InlineData(10us,'\n')>]
    [<InlineData(32us,' ')>]
    [<InlineData(0xB2E2us,'测')>]
    [<InlineData(43169us,'ā')>]
    [<InlineData(43205us,'ㄅ')>]
    [<InlineData(43205us,'德')>]

    member this.Hanzi(i:uint16,c:char) =

        let hz = GBK.hanzi(i)
        output.WriteLine($"{hz}")
        let y = GBK.code c
        output.WriteLine($"{y}")

        Should.equal c hz

        Should.equal i y
