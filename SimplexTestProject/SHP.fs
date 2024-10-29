module SimplexTestProject.SHP
open shpParser

open System.IO
open System.Text
open System
open System.Threading.Tasks
open System.Reactive.Linq

open FSharp.Idioms
   

let renderModule (mdl) shapes =
    [
        $"module SimplexTestProject.{mdl}"
        "open shpParser"
        yield!
            shapes
            |> FSharpSpecification.bindShapes "shapes"
    ]
    |> String.concat "\r\n"
