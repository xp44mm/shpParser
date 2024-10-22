module shpParser.ShapesParseTable
let tokens = set ["*";"LINE"]
let kernels = [[0,0];[0,1];[-1,1;-2,1];[-2,2];[-3,1];[-3,2];[-4,1;-5,1];[-5,2]]
let kernelSymbols = ["";"shapes";"LINE";"lines";"*";"lines";"shape";"shapes"]
let actions = [["*",4;"shape",6;"shapes",1];["",0];["",-1;"*",-1;"LINE",2;"lines",3];["",-2;"*",-2];["LINE",2;"lines",5];["",-3;"*",-3];["",-4;"*",4;"shape",6;"shapes",7];["",-5]]

let rules : list<string list*(obj list->obj)> = [
    ["";"shapes"], fun(ss:obj list)-> ss.[0]
    ["lines";"LINE"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:list<string> =
            [s0]
        box result
    ["lines";"LINE";"lines"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<list<string>> ss.[1]
        let result:list<string> =
            s0::s1
        box result
    ["shape";"*";"lines"], fun(ss:obj list)->
        let s1 = unbox<list<string>> ss.[1]
        let result:list<string> =
            s1
        box result
    ["shapes";"shape"], fun(ss:obj list)->
        let s0 = unbox<list<string>> ss.[0]
        let result:list<list<string>> =
            [s0]
        box result
    ["shapes";"shape";"shapes"], fun(ss:obj list)->
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