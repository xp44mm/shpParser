module shpParser.ShpParseTable
let tokens = set ["(";")";",";"-";"NUM";"TITLE"]
let kernels = [[0,0];[0,1];[-1,1;-3,1];[-1,2];[-2,1];[-3,1];[-3,2];[-4,1;-5,1];[-5,2];[-6,1];[-6,2];[-7,1];[-8,1;-9,1];[-9,2];[-9,3];[-10,1];[-10,2];[-10,3];[-11,1];[-12,1;-13,1];[-13,2];[-13,3]]
let kernelSymbols = ["";"file";"TITLE";"shps";"shps";"TITLE";"specbytes";"shp";"shps";"-";"NUM";"NUM";"signnum";",";"signnums";"(";"signnums";")";"signnum";"specbyte";",";"specbytes"]
let actions = [["TITLE",2;"file",1;"shp",7;"shps",4];["",0];["(",15;"-",9;"NUM",11;"TITLE",5;"shp",7;"shps",3;"signnum",18;"specbyte",19;"specbytes",6];["",-1];["",-2];["(",15;"-",9;"NUM",11;"signnum",18;"specbyte",19;"specbytes",6];["",-3;"TITLE",-3];["",-4;"TITLE",5;"shp",7;"shps",8];["",-5];["NUM",10];["",-6;")",-6;",",-6;"TITLE",-6];["",-7;")",-7;",",-7;"TITLE",-7];[")",-8;",",13];["-",9;"NUM",11;"signnum",12;"signnums",14];[")",-9];["-",9;"NUM",11;"signnum",12;"signnums",16];[")",17];["",-10;",",-10;"TITLE",-10];["",-11;",",-11;"TITLE",-11];["",-12;",",20;"TITLE",-12];["(",15;"-",9;"NUM",11;"signnum",18;"specbyte",19;"specbytes",21];["",-13;"TITLE",-13]]

let rules : list<string list*(obj list->obj)> = [
    ["";"file"], fun(ss:obj list)-> ss.[0]
    ["file";"TITLE";"shps"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<list<Shape>> ss.[1]
        let result:ShapeFile =
            ShapeFile.from(s0,s1)
        box result
    ["file";"shps"], fun(ss:obj list)->
        let s0 = unbox<list<Shape>> ss.[0]
        let result:ShapeFile =
            ShapeFile.from("",s0)
        box result
    ["shp";"TITLE";"specbytes"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<list<list<int>>> ss.[1]
        let result:Shape =
            Shape.from(s0,s1)
        box result
    ["shps";"shp"], fun(ss:obj list)->
        let s0 = unbox<Shape> ss.[0]
        let result:list<Shape> =
            [s0]
        box result
    ["shps";"shp";"shps"], fun(ss:obj list)->
        let s0 = unbox<Shape> ss.[0]
        let s1 = unbox<list<Shape>> ss.[1]
        let result:list<Shape> =
            s0::s1
        box result
    ["signnum";"-";"NUM"], fun(ss:obj list)->
        let s1 = unbox<int> ss.[1]
        let result:int =
            -s1
        box result
    ["signnum";"NUM"], fun(ss:obj list)->
        let s0 = unbox<int> ss.[0]
        let result:int =
            s0
        box result
    ["signnums";"signnum"], fun(ss:obj list)->
        let s0 = unbox<int> ss.[0]
        let result:list<int> =
            [s0]
        box result
    ["signnums";"signnum";",";"signnums"], fun(ss:obj list)->
        let s0 = unbox<int> ss.[0]
        let s2 = unbox<list<int>> ss.[2]
        let result:list<int> =
            s0::s2
        box result
    ["specbyte";"(";"signnums";")"], fun(ss:obj list)->
        let s1 = unbox<list<int>> ss.[1]
        let result:list<int> =
            s1
        box result
    ["specbyte";"signnum"], fun(ss:obj list)->
        let s0 = unbox<int> ss.[0]
        let result:list<int> =
            [s0]
        box result
    ["specbytes";"specbyte"], fun(ss:obj list)->
        let s0 = unbox<list<int>> ss.[0]
        let result:list<list<int>> =
            [s0]
        box result
    ["specbytes";"specbyte";",";"specbytes"], fun(ss:obj list)->
        let s0 = unbox<list<int>> ss.[0]
        let s2 = unbox<list<list<int>>> ss.[2]
        let result:list<list<int>> =
            s0::s2
        box result
]
let unboxRoot =
    unbox<ShapeFile>
let app: FslexFsyacc.ParseTableApp = {
    tokens        = tokens
    kernels       = kernels
    kernelSymbols = kernelSymbols
    actions       = actions
    rules         = rules
}
