module shpParser.ShapeDefsParseTable
let tokens = set ["DATAROW";"STARROW"]
let kernels = [[0,0];[0,1];[-2,1];[-2,2];[-3,1];[-3,2];[-4,1;-5,1];[-5,2]]
let kernelSymbols = ["";"shapeDefs";"DATAROW";"datarows";"STARROW";"datarows";"shapeDef";"shapeDefs"]
let actions = [["STARROW",4;"shapeDef",6;"shapeDefs",1];["",0];["",-1;"DATAROW",2;"STARROW",-1;"datarows",3];["",-2;"STARROW",-2];["",-1;"DATAROW",2;"STARROW",-1;"datarows",5];["",-3;"STARROW",-3];["",-4;"STARROW",4;"shapeDef",6;"shapeDefs",7];["",-5]]

let rules : list<string list*(obj list->obj)> = [
    ["";"shapeDefs"], fun(ss:obj list)-> ss.[0]
    ["datarows"], fun(ss:obj list)->
        let result:list<string> =
            []
        box result
    ["datarows";"DATAROW";"datarows"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<list<string>> ss.[1]
        let result:list<string> =
            s0::s1
        box result
    ["shapeDef";"STARROW";"datarows"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<list<string>> ss.[1]
        let result:list<string> =
            s0::s1
        box result
    ["shapeDefs";"shapeDef"], fun(ss:obj list)->
        let s0 = unbox<list<string>> ss.[0]
        let result:list<list<string>> =
            [s0]
        box result
    ["shapeDefs";"shapeDef";"shapeDefs"], fun(ss:obj list)->
        let s0 = unbox<list<string>> ss.[0]
        let s1 = unbox<list<list<string>>> ss.[1]
        let result:list<list<string>> =
            s0::s1
        box result
]
let unboxRoot =
    unbox<list<list<string>>>
let app: FslexFsyacc.ParseTableApp = {
    tokens        = tokens
    kernels       = kernels
    kernelSymbols = kernelSymbols
    actions       = actions
    rules         = rules
}