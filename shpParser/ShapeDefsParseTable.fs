module shpParser.ShapeDefsParseTable
let tokens = set ["DATAROW";"STARROW";"TITLEROW";"ZEROROW"]
let kernels = [[0,0];[0,1];[-2,1];[-2,2];[-3,1;-4,1];[-3,2];[-3,3];[-4,2];[-5,1];[-5,2];[-6,1];[-6,2];[-7,1];[-7,2];[-8,1;-9,1];[-9,2]]
let kernelSymbols = ["";"file";"DATAROW";"datarows";"TITLEROW";"fontDef";"shapeDefs";"shapeDefs";"fontDef";"shapeDefs";"ZEROROW";"datarows";"STARROW";"datarows";"shapeDef";"shapeDefs"]
let actions = [["TITLEROW",4;"ZEROROW",10;"file",1;"fontDef",8];["",0];["",-1;"DATAROW",2;"STARROW",-1;"datarows",3];["",-2;"STARROW",-2];["STARROW",12;"ZEROROW",10;"fontDef",5;"shapeDef",14;"shapeDefs",7];["STARROW",12;"shapeDef",14;"shapeDefs",6];["",-3];["",-4];["STARROW",12;"shapeDef",14;"shapeDefs",9];["",-5];["DATAROW",2;"STARROW",-1;"datarows",11];["STARROW",-6];["",-1;"DATAROW",2;"STARROW",-1;"datarows",13];["",-7;"STARROW",-7];["",-8;"STARROW",12;"shapeDef",14;"shapeDefs",15];["",-9]]

let rules : list<string list*(obj list->obj)> = [
    ["";"file"], fun(ss:obj list)-> ss.[0]
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
    ["file";"TITLEROW";"fontDef";"shapeDefs"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<list<string>> ss.[1]
        let s2 = unbox<list<uint16*list<string>>> ss.[2]
        let result:string*list<string>*list<uint16*list<string>> =
            s0,s1,s2
        box result
    ["file";"TITLEROW";"shapeDefs"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<list<uint16*list<string>>> ss.[1]
        let result:string*list<string>*list<uint16*list<string>> =
            s0,[],s1
        box result
    ["file";"fontDef";"shapeDefs"], fun(ss:obj list)->
        let s0 = unbox<list<string>> ss.[0]
        let s1 = unbox<list<uint16*list<string>>> ss.[1]
        let result:string*list<string>*list<uint16*list<string>> =
            "",s0,s1
        box result
    ["fontDef";"ZEROROW";"datarows"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<list<string>> ss.[1]
        let result:list<string> =
            s0::s1
        box result
    ["shapeDef";"STARROW";"datarows"], fun(ss:obj list)->
        let s0 = unbox<uint16*string> ss.[0]
        let s1 = unbox<list<string>> ss.[1]
        let result:uint16*list<string> =
            let n,rest = s0
            n,rest::s1
        box result
    ["shapeDefs";"shapeDef"], fun(ss:obj list)->
        let s0 = unbox<uint16*list<string>> ss.[0]
        let result:list<uint16*list<string>> =
            [s0]
        box result
    ["shapeDefs";"shapeDef";"shapeDefs"], fun(ss:obj list)->
        let s0 = unbox<uint16*list<string>> ss.[0]
        let s1 = unbox<list<uint16*list<string>>> ss.[1]
        let result:list<uint16*list<string>> =
            s0::s1
        box result
]
let unboxRoot =
    unbox<string*list<string>*list<uint16*list<string>>>
let app: FslexFsyacc.ParseTableApp = {
    tokens        = tokens
    kernels       = kernels
    kernelSymbols = kernelSymbols
    actions       = actions
    rules         = rules
}