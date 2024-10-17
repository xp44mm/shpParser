namespace shpParser

open System
open System.Text.RegularExpressions

type ShpFileDef =
    {
        title: Title
        font: int list
        shapes: ShapeDefinition list
    }

    static member from (groups: string list list) =
        let title = Title.from groups.Head.Head
        let groups =
            match title with
            | BigFont _ -> groups.Tail
            | NoTitle -> groups

        let pairs0, pairs =
            groups
            |> List.map(fun rows ->
                let number = 
                    rows.Head.Split([|','|],2).[0]
                    |> Number.parseUint16
                number,rows.Tail
            )
            |> List.partition(fun (a,b) -> a = 0us)


        {
            title = title
            font = 
                pairs0 
                |> List.exactlyOne
                |> snd
                |> SpecificationUtils.getIntListFromLines
            shapes = 
                pairs 
                |> List.map ShapeDefinition.from
        }

    //member this.render() =
    //    [
    //        "*"+this.title
    //        for shp in this.shapes do
    //            shp.render()
    //        ""
    //    ]
    //    |> String.concat "\r\n" 
