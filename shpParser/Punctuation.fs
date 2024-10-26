module shpParser.Punctuation
open System
open System.Collections.Generic
open System.Text.RegularExpressions

open FSharp.Idioms
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.RegularExpressions

let Shapes =
    let dict = Dictionary<_,_>()

    dict.['？'] <- [
        PenUp
        Displacement(29y,30y)
        PenDown
        OctantArc(5uy,0x20y)
        PenUp
        Displacement(0y,14y)
        PenDown
        Displacement(0y,5y)
        BulgeArc(5y,14y, -23y)
        Displacement(15y,17y)
        BulgeArc(5y,25y, 44y)
        BulgeArc(-46y,3y, 58y)
        BulgeArc(-5y,-11y, 23y)
    ]

    //``中文破折号``
    dict.['—'] <- [
        PenUp
        Displacement(0y,63y)
        PenDown
        Displacement(127y,0y)
    ]
        
    //``中文句号``
    dict.['。'] <- [
        PenUp
        Displacement(32y,32y)
        PenDown
        OctantArc(15uy,0x20y)
    ]


    //``中文LPAREN``
    dict.['（'] <- [
        PenUp
        Displacement(95y,127y)
        PenDown
        BulgeArc(0y,-127y, 64y)
        ]
            
    //``中文RPAREN``
    dict.['）'] <-[
        PenUp
        Displacement(32y,0y)
        PenDown
        BulgeArc(0y,127y, 64y)
        ]

    //``中文顿号``
    dict.['、'] <- [
        PenUp
        Displacement(49y,17y)
        PenDown
        BulgeArc(-34y,30y, 8y)
        ]

    //``中文感叹号``
    dict.[ '！'] <- [
        PenUp
        Displacement(30y,32y)
        PenDown
        OctantArc(5uy,0x20y)
        PenUp
        Displacement(0y,12y)
        PenDown
        Displacement(0y,76y)
        ]

    //``中文冒号``() =
    dict.['：'] <- [
        PenUp
        Displacement(30y,32y)
        PenDown
        OctantArc(6uy,0x20y)
        PenUp
        Displacement(0y,59y)
        PenDown
        OctantArc(6uy,0x20y)
        ]

    //``中文省略号``() =
    dict.[ '…'] <- [
        PenUp
        Displacement(10y,63y)
        PenDown
        OctantArc(6uy,0x40y)
        PenUp
        Displacement(48y,0y)
        PenDown
        OctantArc(6uy,0x40y)
        PenUp
        Displacement(48y,0y)
        PenDown
        OctantArc(6uy,0x40y)
        ]

    //``中文逗号``() =
    dict.[ '，'] <- [
        PenUp
        Displacement(21y,0y)
        PenDown
        BulgeArc(15y,18y, 42y)
        Displacement(0y,10y)
        OctantArc(6uy,0y)
        ]

    //``中文分号``() =
    dict.[ '；'] <- [
        PenUp
        Displacement(21y,0y)
        PenDown
        BulgeArc(15y,18y, 42y)
        Displacement(0y,10y)
        OctantArc(6uy,0y)
        PenUp
        Displacement(0y,57y)
        PenDown
        OctantArc(6uy,0y)
        ]


    // 画一个单引号
    let leftq = [
        PenDown
        OctantArc(6uy,0x40y)
        Displacement(0y,10y)
        BulgeArc(15y,26y, -32y)        
    ]

    //``中文左单引号``() =
    dict.[  '‘'] <- [
        PenUp
        Displacement(98y,87y)
        yield! leftq
        ]

    //``中文左双引号``() =
    dict.[ '“'] <- [
        PenUp
        Displacement(88y,85y)
        Push
        yield! leftq
        Pop
        PenUp
        Displacement(24y,0y)
        yield! leftq
        ]

    // 画一个单引号
    let rightq = [
        PenDown
        BulgeArc(15y,26y, 32y)
        Displacement(0y,10y)
        OctantArc(6uy,0y)
    ]

    //``中文右单引号``() =
    dict.['’'] <- [
        PenUp
        Displacement(22y,84y)
        yield! rightq
        ]

    //``中文右双引号``() =
    dict.['”'] <- [
        PenUp
        Displacement(8y,85y)
        Push
        yield! rightq
        Pop
        PenUp
        Displacement(24y,0y)
        yield! rightq
        ]

    Map.fromInterface dict

let getBytes (mp:Map<char,Specification list>) =
    mp
    |> Map.map(fun c specs ->
        specs
        |> List.collect(fun spec -> spec.getBytes())
        |> SpecificationUtils.fromStartToEndBytes 127y
    )


