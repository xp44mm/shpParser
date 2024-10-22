namespace shpParser

open System
open System.Text.RegularExpressions

open System.Threading.Tasks
open System.Reactive
//open System.Reactive.Observable.Aliases
open System.Reactive.Linq
open type System.Linq.ParallelEnumerable

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

        let pairs =
            groups
            |> List.map(fun rows ->
                let number = 
                    rows.Head.Split([|','|],2).[0]
                    |> Number.parseUint16
                number,rows.Tail
            )

        let ns, pairs =
            match pairs with
            | (n,ns) :: t when n = 0us ->
                    ns,t
            | _ -> failwith "没有*0,特殊形"

        {
            title = title
            font =                  
                Number.getIntListFromLines ns
            shapes = 
                pairs
                //    .AsParallel()
                //    .Select(ShapeDefinition.from)
                //|> Seq.toList

                //|> List.map ShapeDefinition.from
                    .ToObservable()
                    .SelectMany(fun x -> task { return ShapeDefinition.from x })
                    
                    .ToEnumerable()
                |> Seq.toList
        }

    //member this.render() =
    //    [
    //        "*"+this.title
    //        for shp in this.shapes do
    //            shp.render()
    //        ""
    //    ]
    //    |> String.concat "\r\n" 
