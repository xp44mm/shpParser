namespace shpParser

open System
open System.Text.RegularExpressions

type FileDef =
    {
        title: string
        shapes: ShapeDef list
    }

    static member from (groups: string list list) =
        if Char.IsDigit groups.Head.Head.[0] then
            {
                title = ""
                shapes =
                    groups
                    |> List.map(ShapeDef.from)
            }
        else
            {
                title = groups.Head |> List.exactlyOne
                shapes =
                    groups.Tail
                    |> List.map(ShapeDef.from)
            }
                    
    member this.render() =
        [
            "*"+this.title
            for shp in this.shapes do
                shp.render()
            ""
        ]
        |> String.concat "\r\n" 
