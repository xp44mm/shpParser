module Program 
open System
open FSharp.Idioms.Literal
let text = "3,100,2,8,4,89,1,8,36,0,2,8,-17,0,1,8,-4,-18,1,8,-7,-8,1,8,-8,-12,2,8,11,-34,1,8,0,46,1,8,20,0,1,8,0,-30,1,8,-20,0,2,8,31,58,1,8,36,0,1,8,-18,-20,1,8,-17,-12,1,8,41,0,1,8,0,-42,1,8,-5,-8,1,8,-9,-2,1,8,-6,-2,2,8,-2,52,1,8,-8,-14,1,8,-10,-12,1,8,-15,-12,2,8,46,38,1,8,-4,-14,1,8,-8,-14,1,8,-10,-10,1,8,-12,-12,2,8,55,-6,2,8,15,-1,4,100,0"

let [<EntryPoint>] main _ =
    let COLUMN = 80
    let tryline (text:string) =
        if text = "" then
            None
        elif text.Length <= COLUMN then
            Some(text,"")
        else
            let i = text.[0..COLUMN-1].LastIndexOf ','
            Some(text.[0..i],text.[i+1..])

    //let lines =
        //bytes 
        //|> Seq.map(fun i -> i.ToString()) 
        //|> String.concat ","
    text
    |> Seq.unfold(fun rest -> tryline rest)
    |> Seq.iter(fun l ->
        Console.WriteLine l
    
    )

    0
