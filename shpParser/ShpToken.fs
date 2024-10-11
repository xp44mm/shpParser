namespace shpParser

type ShpToken =
    | LPAREN
    | RPAREN
    | COMMA
    | MINUS
    | TITLE of string
    | NUM of int

    member this.getTag() =
        match this with
        | LPAREN -> "("
        | RPAREN -> ")"
        | COMMA -> ","
        | MINUS -> "-"
        | TITLE _ -> "TITLE"
        | NUM _ -> "NUM"

    member this.getLexeme () = 
        match this with
        | LPAREN 
        | RPAREN 
        | COMMA 
        | MINUS -> null
        | TITLE s -> box s
        | NUM i -> box i
