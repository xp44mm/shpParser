module shpParser.ShpTokenUtils

open System
open System.Text.RegularExpressions
open FSharp.Idioms

open FSharp.Idioms.Jsons
open FSharp.Idioms.ActivePatterns
open FSharp.Idioms.RegularExpressions

open FslexFsyacc

let getTag (postok:PositionWith<ShpToken>) = postok.value.getTag()

let getLexeme (postok:PositionWith<ShpToken>) = postok.value.getLexeme()

let tokenize (pos:int) (inp:string) =
    let rec loop (i:int) =
        seq {
            match inp.[i-pos..] with
            | "" -> ()
    
            | Rgx @"^\s+" x -> 
                let pos = i + x.Length
                yield! loop pos

            | First '(' _ ->
                let postok = {
                    index = i
                    length = 1
                    value = LPAREN
                }
                yield postok
                yield! loop postok.adjacent

            | First ')' _ ->
                let postok = {
                    index = i
                    length = 1
                    value = RPAREN
                }
                yield postok
                yield! loop postok.adjacent

            | First ',' _ ->
                let postok = {
                    index = i
                    length = 1
                    value = COMMA
                }
                yield postok
                yield! loop postok.adjacent

            | First '-' _ ->
                let postok = {
                    index = i
                    length = 1
                    value = MINUS
                }
                yield postok
                yield! loop postok.adjacent

            | Rgx @"^\*.*" m ->
                let postok = {
                    index = i
                    length = m.Length
                    value = TITLE m.Value
                }
                yield postok
                yield! loop postok.adjacent

            | Rgx @"^[1-9]\d*\b" m ->
                let postok = {
                    index = i
                    length = m.Length
                    value = NUM(int m.Value)
                }
                yield postok
                yield! loop postok.adjacent

            | Rgi @"^0[0-9a-f]*\b" m ->
                let postok = {
                    index = i
                    length = m.Length
                    value = NUM(Convert.ToInt32(m.Value,16))
                }
                yield postok
                yield! loop postok.adjacent

            | rest -> failwith $"tokenize:{rest}"
        }
    
    loop pos

