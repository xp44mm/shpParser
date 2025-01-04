module XdxHeirTestProject.XdxSpecifications

open System
open System.Collections.Generic
open FSharp.Idioms.Literal
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open shpParser

open System.IO
open System.Text
open System
open System.Threading.Tasks
open System.Reactive.Linq

open FSharp.Idioms

let altogether (specs: Specification list) =
    [
        Push
        yield! specs
        yield! Radical.tail()
    ]

let bordersBytes (specs: Specification list) =
    [
        Push
        yield!
            specs
            |> List.filter(fun spec ->
                match spec with
                | PenDown | PenUp -> false
                | _ -> true
            )
        yield! Radical.bordersTail()
    
    ]
    |> List.collect(fun spec -> spec.getBytes())
