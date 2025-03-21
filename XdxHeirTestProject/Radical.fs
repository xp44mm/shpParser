﻿module XdxHeirTestProject.Radical

open shpParser
open System

let move x y =
    [
        PenUp
        Displacement(x,y)
        PenDown
    ]

/// 笔画反向写
let opposite ls =
    ls
    |> List.map(function
        | Displacement(x,y) -> Displacement(-x,-y)
        | PenUp -> PenDown
        | PenDown -> PenUp
        | _ -> raise <| NotImplementedException("")
    )
    |> List.rev

/// 先竖后撇
let 竖撇 (x, y) =
    //(0,rest)(2,5)(3,3)
    let x1 = SByte.multiply 0.6 x
    let x2 = x - x1
    let sn =  sbyte (sign y)
    let y1 = sn * abs x1
    let y2 = sn * abs x
    let y0 = y - y1 - y2
    [
        Displacement(0y,-y0)
        Displacement(-x2,-y2)
        Displacement(-x1,-y1)
    ]

let tail () =
    [
        Pop
        PenUp
        Displacement(127y,0y)
        EndOfShape
    ]

let 匚 (x, y) =
    [
        Displacement(-x,0y)
        Displacement(0y,-y)
        Displacement(x,0y)
    ]

let 反匚 (x, y) = 匚 (-x, y)

let 冂 (x, y) =
    [
        Displacement(0y,y)
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-20y,14y) //勾
    ]

let 凵 (x, y) =
    [
        Displacement(0y,-y)
        Displacement(x,0y)
        Displacement(0y,y)
    ]

let 反凵 (x, y) = 凵 (x, -y)

/// mì
let 冖 (x, y) = 反凵 (x, y)

///首笔上横左边
///末笔中横左边
/// ji急
let 彐(x, y) =
    [
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-x,0y)
        PenUp
        Displacement(x,y/2y)
        PenDown
        Displacement(-x,0y)
    ]

///巴字去掉竖弯勾
///首笔上横左边
///末笔中竖下端
let 巴头(x, y) =
    [
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-x,0y)
        PenUp
        Displacement(x/2y,y)
        PenDown
        Displacement(0y,-y)
    ]

/// 首笔左上点
let 口 (x, y) =
    [
        Displacement(0y,-y)
        Displacement(x,0y)
        Displacement(0y,y)
        Displacement(-x,0y)
    ]

let bordersTail () =
    [
        Pop
        yield! 口(127y, -127y) //x轴镜像
        Displacement(127y,0y)
        EndOfShape
    ]

/// 首笔左上
/// 末笔中横左端
let 日(x, y) =
    [
        yield! 口(x, y)
        yield! move x -(y/2y)
        Displacement(-x,0y)
    ]

/// 临的右下部分
/// 首笔左上
/// 末笔中竖下端
let 躺日(x, y) =
    [
        yield! 口(x, y)
        yield! move (x/2y) 0y
        Displacement(0y,-y)
    ]

///首笔左上
///末笔第二竖下端
let 四部(x, y) =
    let x1= x / 3y
    [
        yield! 口(x, y)
        PenUp
        Displacement(x1,0y)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(x1,y)
        PenDown
        Displacement(0y,-y)
    ]

///首笔左上
///末笔中竖下端
let 田(x, y) =
    // first at (0,0)
    [
        yield! 日(x, y)
        yield! move (x/2y) (y/2y)
        Displacement(0y,-y)
    ]

///首笔外口左上
///末笔内口左上
let 回 (x,y) (x1,y1) =
    let dx = (x-x1)/2y
    let dy = (y-y1)/2y
    [
        yield! 口(x, y)
        PenUp
        Displacement(dx,-dy)
        PenDown
        yield! 口(x1, y1)
    ]

///首笔左下角
///末笔口内第二横右端
let 青月(x,y) =
    let y1 = SByte.multiply 0.3 y
    [
        Displacement(0y,y)
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-10y,7y)
        PenUp
        Displacement(-x+10y,y-y1-7y)
        PenDown
        Displacement(x,0y)
        PenUp
        Displacement(-x,-y1)
        PenDown
        Displacement(x,0y)
    ]

///首笔左上
///末笔口内第二横左端
let 目 (x, y) =
    [
        Displacement(0y,-y)
        Displacement(x,0y)
        Displacement(0y,y)
        Displacement(-x,0y)
        PenUp
        Displacement(x,-y/3y)
        PenDown
        Displacement(-x,0y)
        PenUp
        Displacement(x,-y/3y)
        PenDown
        Displacement(-x,0y)
    ]

///例如:追去掉走之，去掉撇，剩余的部分
///首笔上口左下端
///末笔下口左上端
/// yi 以，繁体字
let 㠯 (x, y) =
    let y1 = SByte.multiply (3./8.) y
    //let y2 = SByte.multiply 0.25 y

    [
        Displacement(x,0y)
        Displacement(0y,y1)
        Displacement(-x,0y)
        Displacement(0y,-y)
        Displacement(x,0y)
        Displacement(0y,y1)
        Displacement(-x,0y)
    ]

let 丌 (x, y) =
    let x1 = x/3y
    let x2 = x/6y
    let y1 = y/2y
    [
        Displacement(x,0y)
        PenUp
        Displacement(x1-x-x2,-y)
        PenDown
        Displacement(x2,y1)
        Displacement(0y,y-y1)
        PenUp
        Displacement(x1,0y)
        PenDown
        Displacement(0y,-y)
    ]

///首笔上横右端
///末笔右竖下端
let 开 (x,y) =
    let y1 = y/4y
    let x1 = SByte.multiply 0.6 y1
    let y2 = y/2y
    let x2 = SByte.multiply 0.3 x
    let x3 = SByte.multiply 0.4 x
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x,-y2)
        PenDown
        Displacement(x,0y)
        PenUp
        Displacement(-x+x2,y2)
        PenDown
        Displacement(0y,-y+y1)
        Displacement(-x1,-y1)
        PenUp
        Displacement(x1+x3,y)
        PenDown
        Displacement(0y,-y)
    ]

/// (x1,y1) 撇
/// 末笔第二横的右端
let 月 (x,y) (x1,y1) =
    let x2 = x-x1
    let ll = y-y1 //竖撇的竖长度
    let c = SByte.multiply 0.42 ll
    [
        Displacement(x1,y1)
        Displacement(0y,ll)
        Displacement(x2,0y)
        Displacement(0y,-y)
        Displacement(-10y,7y)
        PenUp
        Displacement(-x+x1+10y,y-c-7y)
        PenDown
        Displacement(x2,0y)
        PenUp
        Displacement(-x2,-c)
        PenDown
        Displacement(x2,0y)
    ]

///首笔中竖的下端
///末笔第二横右端
let 用 (x,y) =
    let y1 = y/4y
    let x1 = SByte.multiply 0.6 y1
    [
        Displacement(0y,-y)
        yield! move (-(x+x1)/2y) 0y
        yield! 月 (x,y) (x1,y1)
    ]

/// 两个月紧贴着
let 朋 (x,y) (x1,y1) =
    let ll = y-y1 //竖撇的竖长度
    let c = SByte.multiply 0.42 ll
    [
        yield! 月 (x/2y,y) (x1,y1)
        yield! move 0y (-y+c+c)
        yield! 月 (x/2y,y) (x1,y1)
    ]

let 玉(x,y) =
    let x1 = SByte.multiply 0.8 x
    let x2 = SByte.multiply 0.9 x
    let y1 = SByte.multiply (3./7.) y
    let y2 = SByte.multiply (4./7.) y
    [
        Displacement(x1,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(x1,0y)
        PenUp
        Displacement(-25y,-12y)
        PenDown
        Displacement(20y,-15y)
        PenUp
        Displacement(-x2-(-25y+15y),-y2-(-12y-15y))
        PenDown
        Displacement(x,0y)
        PenUp
        Displacement(-x/2y,y)
        PenDown
        Displacement(0y,-y)
    ]

/// 乚
let 竖弯勾(x, y) =
    let d = 7y
    let g = 14y
    [
    Displacement(0y,-y+d)
    Displacement(d,-d)
    Displacement(x-d,0y)
    Displacement(0y,g)
    ]

let 弓(x, y) =
    let y1 = SByte.multiply 0.3 y
    let y2 = SByte.multiply 0.4 y
    [
    Displacement(x,0y)
    Displacement(0y,-y1)
    Displacement(-x,0y)
    Displacement(0y,-y1)
    Displacement(x,0y)
    Displacement(0y,-y2)
    Displacement(-20y,14y)
    ]

/// 首笔左短横的左点
/// 末笔右短横的右点
let 臼 (x,y) =
    let x1 = SByte.multiply 0.4 x
    let y1 = y/2y
    let y2 = SByte.multiply (7./8.) y
    [
        Displacement(x1,0y)
        PenUp
        Displacement(0y,y1+y/8y)
        PenDown
        Displacement(-x1,-y/4y)
        Displacement(0y,-y2)
        Displacement(x,0y)
        Displacement(0y,y)
        Displacement(-x1,0y)
        PenUp
        Displacement(0y,-y1)
        PenDown
        Displacement(x1,0y)
    ]

/// 首笔左下角
/// 末笔右竖下端
/// x0 短横长度
/// x 长横长度
let 且 xs y =
    match xs with
    | [x0;x] ->
        let x1 = (x-x0)/2y // 底伸出长度
        let y1 = y/3y
        [
            Displacement(x,0y)
            PenUp
            Displacement(-x+x1,y1)
            PenDown
            Displacement(x0,0y)
            PenUp
            Displacement(-x0,y1)
            PenDown
            Displacement(x0,0y)
            PenUp
            Displacement(-x0,-2y*y1)
            PenDown
            Displacement(0y,y)
            Displacement(x0,0y)
            Displacement(0y,-y)
        ]
    | _ -> failwith ""

/// 首笔左下角
/// 末笔勾顶
let 门(x, y) =
    [
        Displacement(0y,y-10y)
        PenUp
        Displacement(5y,23y)
        PenDown
        Displacement(17y,-23y)
        PenUp
        Displacement(15y,10y)
        PenDown
        Displacement(x-37y,0y)
        Displacement(0y,-y)
        Displacement(-20y,14y)//勾
        ]

/// 扁无户，册的另一种写法
/// 首笔左下角
/// 末笔中横右端
let 册(x, y) =
    let x1 = x/3y
    let y1 = y-10y
    [
        Displacement(0y,y)
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-10y,7y) //勾
        PenUp
        Displacement(-x1+10y,y-7y)
        PenDown
        Displacement(0y,-y1)
        PenUp
        Displacement(-x1,y1)
        PenDown
        Displacement(0y,-y1)
        PenUp
        Displacement(2y*x1-x, y1/2y)
        PenDown
        Displacement(x,0y)
    ]

/// 首笔左上角
/// 末笔右下点
/// [x0 上横长度，x1 两竖间距; x 下横长度]
let 亚无八 xs y =
    match xs with
    | [x0;x1;x] ->
        //let x1 = x0/4y
        let x2 = (x0-x1)/2y
        [
            Displacement(x0,0y)
            PenUp
            Displacement(-x1-x2,0y)
            PenDown
            Displacement(0y,-y)
            PenUp
            Displacement(x1,0y)
            PenDown
            Displacement(0y,y)
            PenUp
            Displacement(-x/2y-x0/8y,-y)
            PenDown
            Displacement(x,0y)
        ]
    | _ -> failwith ""

///首笔左竖上端
///末笔右竖下端
let 等长双竖 (x, y) =
    [
        Displacement(0y,-y)
        PenUp
        Displacement(x,y)
        PenDown
        Displacement(0y,-y)
    ]

/// 首笔日左上角
/// 末笔中竖下点
/// y0 中竖长度
let 甲 (x, y) y0 =
    [
        yield! 日(x, y)
        yield! move (x/2y) (y/2y)
        Displacement(0y,-y0)
    ]

/// 首笔日左上角
/// 末笔中竖下点
/// y0 中竖长度
let 由 (x, y) y0 =
    [
        yield! 日(x, y)
        yield! move (x/2y) (y0-y/2y)
        Displacement(0y,-y0)
    ]

///首笔左竖下端
///末笔中竖下端
/// y0左竖长; y1出头长度; y2中竖总长
let 巾 x ys =
    match ys with
    | [y0;y1;y2] ->
        [
            Displacement(0y,y0)
            Displacement(x,0y)
            Displacement(0y,-y0)
            Displacement(-20y,14y) //勾
            PenUp
            Displacement(-x/2y+20y,y0+y1-14y)
            PenDown
            Displacement(0y,-y2)
        ]
    | _ -> failwith ""

///首笔口左上端
///末笔中竖下端
/// [y0口; y1上头长度; y竖总长度]
[<Obsolete("中2")>]
let 中 x ys =
    match ys with
    | [y0;y1;y] ->
        [
            yield! 口(x,y0)
            PenUp
            Displacement(x/2y,y1)
            PenDown
            Displacement(0y,-y)
        ]
    | _ -> failwith $"ys[y0;y1;y]列表元素数量不对"

///首笔日左上端
///末笔中竖下端
/// y0口高度; y1出头长度; y2中竖总长度
let 申 x ys =
    match ys with
    | [y0;y1;y2] ->
        [
            yield! 日(x,y0)
            PenUp
            Displacement(x/2y,y1+y0/2y)
            PenDown
            Displacement(0y,-y2)
        ]
    | _ -> failwith $"ys[y0;y1;y2]列表元素数量不对"

///首笔横左端
///末笔竖下端
/// y0横上高度; y总高度
let 十 x ys =
    match ys with
    | [y0;y] ->
        [
            Displacement(x,0y)
            PenUp
            Displacement(-x/2y,y0)
            PenDown
            Displacement(0y,-y)
        ]
    | _ -> failwith $"ys[y0;y]列表元素数量不对"

/// 读作shàng
///首笔竖顶点
///末笔横右端
/// [x1 竖坐标;x 横长]
let 丄 xs y =
    match xs with
    | [x1;x] ->
        [
            Displacement(0y,-y)
            PenUp
            Displacement(-x1,0y)
            PenDown
            Displacement(x,0y)
        ]
    | _ -> failwith $"ys[y0;y]列表元素数量不对"

///首笔竖上端
///末笔横右端
let 卜 x ys =
    match ys with
    | [y0;y] ->
        [
            Displacement(0y,-y)
            PenUp
            Displacement(0y,y-y0)
            PenDown
            Displacement(x,0y)
        ]
    | _ -> failwith ""

///首笔左竖高点
///末笔中竖下点
/// ys (凵高度,中竖高度)
let 山 x ys =
    match ys with
    | [y;y0] ->
        [
            Displacement(0y,-y)
            Displacement(x,0y)
            Displacement(0y,y)
            PenUp
            Displacement(-x/2y,y0-y)
            PenDown
            Displacement(0y,-y0)
        ]
    | _ -> failwith ""

/// 首笔上凵左竖上端
/// 末笔中竖下端
[<Obsolete("type 出")>]
let 出 xs ys =
    match xs,ys with
    | [x1;x2],[y1;dy;y2;y] ->
        [
            yield! 凵(x1,y1)
            PenUp
            Displacement(SByte.average [-x1;-x2],-dy)
            PenDown
            yield! 凵(x2,y2)
            PenUp
            Displacement(-x2/2y,y-y2)
            PenDown
            Displacement(0y,-y)
        ]
    | _ -> failwith ""

/// 首笔顶横左端
/// 末笔底横右端
let 中心对齐等距横 (xs: _ list) y =
    [
        Displacement(xs.Head,0y)
        for (x1,x2) in (
            xs
            |> List.pairwise
        ) do
            let xx = SByte.average [x1;x2]
            PenUp
            Displacement(-xx,-y)
            PenDown
            Displacement(x2,0y)
    ]
    
///首笔上沿左端
///末笔下横右端
/// [x 上横;x1 内横;x2 下横]
/// [y0 两长横间巨;y]
let 其无八 xs ys =
    match xs,ys with
    | [x;x1;x2],[y0;y] ->
        let y1 = y0/3y        
        [
            yield! 中心对齐等距横 [x;x1;x1] y1
            PenUp
            Displacement(-x1,y-y1)
            PenDown
            yield! 等长双竖(x1,y)
            PenUp
            Displacement(-x2/2y-x1/2y,0y)
            PenDown
            Displacement(x2,0y)
        ]
    | _ -> failwith ""

///首笔横左端
///末笔横竖交叉点
/// xs (横长,横右端到竖的距离)
let 丁 xs y =
    match xs with
    | [x;x1] ->
        //let x1 = SByte.multiply x1 x
        [
        Displacement(x,0y)
        PenUp
        Displacement(-x1-20y,-y+14y)
        PenDown
        Displacement(20y,-14y) // 勾
        Displacement(0y,y) // 竖从下往上写
        ]
    | _ -> failwith ""

///首笔冖左竖下端
///末笔底横右端
/// xs (x0 短横长度, x 长横长度)
let 皿 xs y =
    match xs with
    | [x0;x] ->
        let x1 = x0/3y
        let x2 = (x-x0)/2y // 底单侧横出头的长度
        [
            Displacement(0y,y)
            Displacement(x0,0y)
            Displacement(0y,-y)
            PenUp
            Displacement(-x1,y)
            PenDown
            Displacement(0y,-y)
            PenUp
            Displacement(-x1,y)
            PenDown
            Displacement(0y,-y)
            PenUp
            Displacement(-x1-x2,0y)
            PenDown
            Displacement(x,0y)
        ]
    | _ -> failwith ""

///首笔上横左端
///末笔竖下点
/// y0 横间距
let 多横中竖工 (xs: _ list) y0 =
    let xn = xs |> List.last
    let len = sbyte (xs.Length-1)
    let y = y0 * len
    [
        yield! 中心对齐等距横 xs y0
        PenUp
        Displacement(-xn/2y,y)
        PenDown
        Displacement(0y,-y)
    ]

///首笔上沿左端
///末笔竖下点
/// [y0 横间距; y 总竖长]
let 多横中竖士 (xs: _ list) ys =
    match ys with
    | [y0;y] ->
        let xn = xs |> List.last
        [
            yield! 中心对齐等距横 xs y0
            PenUp
            Displacement(-xn/2y,y)
            PenDown
            Displacement(0y,-y)
        ]
    | _ -> failwith ""

///首笔上沿左端
///末笔竖下点
let 多横中竖干 (xs: _ list) ys =
    match ys with
    | [y0;y] ->
        let xn = xs |> List.last
        let y1 = y0 * sbyte(xs.Length-1)
        [
            yield! 中心对齐等距横 xs y0
            PenUp
            Displacement(-xn/2y,y1)
            PenDown
            Displacement(0y,-y)
        ]
    | _ -> failwith ""

///首笔上沿左端
///末笔竖下点
/// xs 每个横长度
/// ys (y0 横间距, y1 底横到竖顶高度, y竖总高度)
let 多横中竖丰 (xs: _ list) ys =
    match ys with
    | [y0;y1;y] -> 
        let xn = xs |> List.last
        [
            yield! 中心对齐等距横 xs y0
            PenUp
            Displacement(-xn/2y,y1)
            PenDown
            Displacement(0y,-y)
        ]
    | _ -> failwith ""

/// 首笔日左上点
/// 末笔底横右点
/// [x1 日; x2 土上横; x 底横]
/// [y1 日; y 里总高]
let 里 xs ys =
    match xs,ys with
    | [x1;x2;x],[y1;y] ->
        let y2 = (y-y1)/2y // 间距等分
        [
            yield! 日(x1,y1)
            PenUp
            Displacement(x1/2y,y1/2y)
            PenDown
            Displacement(0y,-y)
            PenUp
            Displacement(-x2/2y,y2)
            PenDown
            yield! 中心对齐等距横 [x2;x] y2
        ]
    | _ -> failwith ""

/// 首笔左上点
/// 末笔口右下点
/// (x, y) 总体尺寸
/// (x0, y0) 口的尺寸
let 西部 (x, y) (x0, y0) =
    let x1 = x0/3y // 两竖间距
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x1/2y-x/2y,-y)
        PenDown
        Displacement(0y,y)
        PenUp
        Displacement(x1,-y)
        PenDown
        Displacement(0y,y)
        PenUp
        Displacement(x1,-y)
        PenDown
        yield! 口(-x0,-y0)
    ]

/// 首笔左上点
/// 末笔下长横右端
/// [x1 日; x2 土上横; x 底横]
/// [y1 左竖; y2 右竖]
let 耳 xs ys =
    match xs,ys with
    | [x1;x2;x3],[y1;y2] ->
        [
            yield! 中心对齐等距横 [x1;x2;x2] (y1/3y)            
            PenUp
            Displacement(-x2, y1/3y+y1/3y)
            PenDown
            Displacement(0y,-y1)
            PenUp
            Displacement(x2,y1)
            PenDown
            Displacement(0y,-y2)
            PenUp
            Displacement(-SByte.average [x2;x3],y2-y1)
            PenDown
            Displacement(x3,0y)
        ]
    | _ -> failwith ""

/// 首笔左上点
/// 末笔下长横右端
/// 录字上半部分碌
let 彐2 xs y =
    match xs with
    | [x1;x2] ->
    let x11 = SByte.multiply 0.9 x1
    let x21 = x2/3y+x1/3y*2y
    [
        Displacement(x1,0y)
        Displacement(0y,-y)
        PenUp
        Displacement(-x11,y/2y)
        PenDown
        Displacement(x11,0y)
        PenUp
        Displacement(-x21,-y/2y)
        PenDown
        Displacement(x2,0y)
    ]
    | _ -> failwith ""

/// 首笔上横左点
/// 末笔凵右上端
/// [       x1 上横; x2 中横; x3 凵]
/// [y 总长; y1 上段; y2 中段; y3 凵;]
let 击 xs ys =
    match xs,ys with
    | [x1;x2;x3],[y;y1;y2;y3] ->
        [
        Displacement(x1,0y)
        PenUp
        Displacement(-x1/2y-x2/2y,-y2)
        PenDown
        Displacement(x2,0y)
        PenUp
        Displacement(-x2/2y,y1+y2)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(-x3/2y,y3)
        PenDown
        yield! 凵(x3,y3)
        ]
    | _ -> failwith ""

/// 首笔左竖顶端
/// 末笔横右点
/// [x; x1 两竖间距]
let 业无八 xs y =
    match xs with
    | [x;x1] ->
        [
            Displacement(0y,-y)
            PenUp
            Displacement(x1,y)
            PenDown
            Displacement(0y,-y)
            PenUp
            Displacement(-x1/2y-x/2y,0y)
            PenDown
            Displacement(x,0y)
        ]
    | _ -> failwith ""

/// 首笔横左点
/// 末笔右竖下端
/// [x0 两点上端间距; x1 两点下端间距]
let 点八 xs y =
    match xs with
    | [x0;x1] ->
        let dx = (x0-x1)/2y
        [
            Displacement(dx,-y)
            PenUp
            Displacement(x0/2y+x1/2y,y)
            PenDown
            Displacement(-dx,-y)
        ]
    | _ -> failwith ""

/// 首笔顶横左端
/// 末笔大口左上
/// (x,y) 总尺寸
/// (x0,y0) 口尺寸
let 酉  (x, y) (x0,y0) =
    let x1 = x0/3y
    let y1 = SByte.multiply 0.267 y0
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x/2y-x0/6y,0y)
        PenDown
        Displacement(0y,-y+y1)
        PenUp
        Displacement(-x1,0y)
        PenDown
        Displacement(x0,0y)
        PenUp
        Displacement(-x1,0y)
        PenDown
        Displacement(0y,y-y1)
        PenUp
        Displacement(x0/3y,-y)
        PenDown
        yield! 口(-x0,-y0)
    ]

///首笔左上第一个横线左端
///末笔右竖下端
/// [x0 两竖间距;x1 上横;x2 中横;x3 底横]
/// [y0 横间距;y1 横上部分;y 总长]
let 非 xs ys =
    match xs, ys with
    | [x0;x1;x2;x3],[y0;y1;y] ->
        let lefthalf =
            [
                Displacement(x1,0y)
                PenUp
                Displacement(-x2,-y0)
                PenDown
                Displacement(x2,0y)
                PenUp
                Displacement(-x3,-y0)
                PenDown
                Displacement(x3,0y)
                PenUp
                Displacement(0y,y0*2y+y1)
                PenDown
                Displacement(0y,-y)
            ]
        let righthalf =
            lefthalf
            |> List.map(function
                | Displacement (x,y) -> Displacement (-x,y)
                | o -> o
            )

        [
            yield! lefthalf
            PenUp
            Displacement(x0+x1,y-y1)
            PenDown
            yield! righthalf

        ]
    | _ -> failwith "参数错误"

/// 首笔顶横左端
/// 末笔口右下
/// (x0,y0) 口尺寸
/// (x,y) 横撇尺寸
let 面 (x, y) (x0,y0) =
    let x1 = x0/3y
    let y1 = y0/3y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x/2y,0y)
        PenDown
        Displacement(-x1/2y,-y)
        Displacement(0y,-y0)
        PenUp
        Displacement(x1,y0)
        PenDown
        Displacement(0y,-y0)
        PenUp
        Displacement(-x1,y1+y1)
        PenDown
        Displacement(x1,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(x1,0y)
        PenUp
        Displacement(x1,-y1)
        PenDown
        yield! 口(-x0,-y0)
    ]

/// 首笔顶横左端
/// 末笔口右下
/// (x,y) 横撇
/// (x0,y0) 口尺寸
let 百 (x, y) (x0,y0) =
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x/2y,0y)
        PenDown
        Displacement(-y/2y,-y)
        PenUp
        Displacement(-x0/2y+y/2y,-y0/2y)
        PenDown
        Displacement(x0,0y)
        PenUp
        Displacement(0y,-y0+y0/2y)
        PenDown
        yield! 口(-x0,-y0)
    ]

/// 首笔顶横左端
/// 末笔冂左下端
/// (x0,y0) 横撇;
/// (x1,y1) 冂
let 而 (x0, y0) (x1, y1) =
    let y2 = SByte.multiply 0.88 y1
    
    [
        Displacement(x0,0y)
        PenUp
        Displacement(-x0/2y,0y)
        PenDown
        Displacement(-x1/6y,-y0)

        Displacement(0y,-y2)
        PenUp
        Displacement(x1/3y,y2)
        PenDown
        Displacement(0y,-y2)

        PenUp
        Displacement(x1/3y-10y,y2-y1+7y)
        PenDown
        Displacement(10y,-7y)
        Displacement(0y,y1)
        Displacement(-x1,0y)
        Displacement(0y,-y1)
    ]

/// 首笔左上点
/// 末笔口右下点
/// (x, y) 总体尺寸
/// (x0, y0) 口的尺寸
let 西字 (x, y) (x0, y0) =
    let x1 = SByte.multiply 0.3 x0 // 两竖间距
    let x2 = SByte.multiply 0.4 x0 // 两竖外侧，口内侧

    [
        Displacement(x,0y)
        PenUp
        Displacement(-x1/2y-x/2y,0y)
        PenDown
        yield! 竖撇(x2/2y, y-y0/2y)
        PenUp
        Displacement(x1+x2/2y,y-y0/2y)
        PenDown
        Displacement(0y,-y+y0/2y)
        Displacement(x2/2y,0y)
        PenUp
        Displacement(x2/2y,-y0/2y)
        PenDown
        yield! 口(-x0,-y0)
    ]

///首笔冂左下点
///末笔口右下端
/// (x, y) 冂 (x0, y0) 口
let 冋 (x, y) (x0, y0) =
    let x1 = (x-x0)/2y
    let y1 = SByte.multiply 0.6 (y-y0)
    [
        Displacement(0y,y)
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-15y,9y) // 勾
        PenUp
        Displacement(-x1+15y,y1-9y)
        PenDown
        yield! 口(-x0,-y0)
    ]

/// 首笔日左上角
/// 末笔右长竖下点
let 曲 x ys =
    match ys with
    | [y0;y] ->
        let x1 = x/3y
        [
            yield! 日(x, y0)
            PenUp
            Displacement(x1,y-y0/2y)
            PenDown
            Displacement(0y,-y)
            PenUp
            Displacement(x1,y)
            PenDown
            Displacement(0y,-y)
        ]
    | _ -> failwith $""

///首笔冂左下点
///末笔口右下端
/// (x, y) 冂 yy 八 (x0, y0) 口
let 冏 (x, y) yy (x0, y0) =
    let x81 = x0/2y
    let x82 = x0/2y+x/2y
    let y8 = SByte.multiply 0.8 yy
    let y81 = SByte.multiply 0.1 yy

    [
        Displacement(0y,y)
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-15y,9y) // 勾

        PenUp
        Displacement(-x81/2y-x/2y+15y,y-y81-9y)
        PenDown

        yield! 点八 [x81;x82] y8

        PenUp
        Displacement((x0-x82)/2y,-y81-y0)
        PenDown
        yield! 口(-x0,-y0)
    ]
///首笔顶横左点
///末笔中横右点
/// x1 顶横; x2 中横
let 躺巾 xs y =
    match xs with
    | [x1;x2] ->
        [
            yield! 匚 (-x1,y)
            PenUp
            Displacement(x1/2y-x2/2y,y/2y)
            PenDown
            Displacement(x2,0y)
        ]
    | _ -> failwith $""
    
///首笔左下角
///末笔顶横中点
let 用部(x,y) =
    let y1 = SByte.multiply 0.6 y
    [
        yield! 青月(x,y)
        PenUp
        Displacement(-x/2y,y1-y+7y)
        PenDown
        Displacement(0y,y-7y)
    ]

///guǎ
///首笔左下角
///末笔顶横中点
/// (x0,y0)上部 (x1,y1)下部
let 冎 (x0,y0) (x1,y1) =
    [
        Displacement(0y,y0)
        Displacement(x0,0y)
        Displacement(0y,-y0)
        PenUp
        Displacement(-x0,y0/2y)
        PenDown
        Displacement(x0/2y,0y)
        Displacement(0y,-y0/2y)

        PenUp
        Displacement(-x1/2y,-y1)
        PenDown
        Displacement(0y,y1)
        Displacement(x1,0y)
        Displacement(0y,-y1)
    ]

///首笔顶横左点
///末笔中横右点
/// x0 顶横; x 中横
let 躺中 xs y =
    match xs with
    | [x0;x] ->
        [
            yield! 口 (x0,y)
            PenUp
            Displacement(x0/2y-x/2y,-y/2y)
            PenDown
            Displacement(x,0y)
        ]
    | _ -> failwith $""

///具去掉八
/// 首笔冂左竖下端
/// 末笔长横右点
/// [x0 短横;x 长横]
let 目一 xs y =
    match xs with
    | [x0;x] -> //x0 (x, y)
        let x1 = (x-x0)/2y
        let y1 = y/4y
        [
            Displacement(0y,y)
            Displacement(x0,0y)
            Displacement(0y,-y)
            PenUp
            Displacement(-x0,3y*y1)
            PenDown
            yield! 中心对齐等距横 [x0;x0;x0;x] y1
        ]
    | _ -> failwith ""

/// 首笔横左端
/// 末笔右竖下端
/// (x0,y0)顶部中间的尺寸
/// (x,y) 总体尺寸
let 艹 (x0, y0) (x, y) =
    let x1 = (x-x0)/2y //两端长度
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x0-x1,y0)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(x0,y)
        PenDown
        Displacement(0y,-y)
    ]

///首笔上横左端
///末笔凵右竖上端
//(x0,y0) 横上中间矩形尺寸
//(x,y) 外接矩形尺寸
let 廿 (x0,y0) (x,y) =
    [
        Displacement(x,0y) //最长的横
        PenUp
        Displacement(-x/2y-x0/2y,y0)
        PenDown
        yield! 凵(x0,y)
    ]

///首笔上横左端
///末笔凵右竖顶端
//(x0,y0) 横上中间矩形尺寸
//(x,y) 外接矩形尺寸
let 甘 (x0,y0) (x,y) = 
    [
        yield! 中心对齐等距横 [x;x0] ((y-y0)/2y)
        PenUp
        Displacement(-x0,y/2y+y0/2y)
        PenDown
        yield! 凵(x0,y)
    ]

/// 首笔上横左端
/// 末笔底长横右点
/// [x0 两竖间距.4; x1 上横长度.8; x 下横长度]
/// [y0 两横间距.5; y 竖长度]
let 共头 xs ys =
    match xs,ys with
    | [x0;x1;x],[y0;y] ->
        [
            yield! 艹 (x0,y-y0) (x1,y)
            PenUp
            Displacement(-x0/2y-x/2y,0y)
            PenDown
            Displacement(x,0y)
        ]
    | _ -> failwith ""

// 冓　gòu
/// 首笔上横左端
/// 末笔底长横右点
/// [x0 两竖间距.4; x1 上横中横长度.8; x2 下横长度]
/// [y0 两横间距.5; y1 竖长度]
let 冓头 xs ys =
    match xs,ys with
    | [x0;x1;x],[y0;y] ->
        [
            Displacement(x1,0y)
            PenUp
            Displacement(-x1,-y0)
            PenDown
            yield! 共头 [x0;x1;x] [y0;y]
        ]
    | _ -> failwith ""

///首笔顶横左点
///末笔底横右点
/// x1 顶横长度;x2 底横长度;y 长竖高度
let 垂无撇 xs y =
    match xs with
    | [x1;x2] ->
        let x0 = SByte.multiply (5./9.) x1
        let y2 = y/2y
        let y4 = y/4y
        [
            Displacement(x1,0y)
            PenUp
            Displacement(-x1,-y4)
            PenDown
            yield! 艹 (x0,y4-6y) (x1,y2-12y)
            PenUp
            Displacement(-x0/2y-x1/2y,-6y)
            PenDown
            yield! 十 x1 [y-y4;y]
            PenUp
            Displacement(-x2/2y,0y)
            PenDown
            Displacement(x2,0y)
        ]
    | _ -> failwith $""

/// 首笔冂左竖下端
/// 末笔底长横右点
//(x0,y0) 冂尺寸
//(x,y) 外接矩形尺寸
let 典无八 (x0,y0) (x,y) =
    [
        yield! 冖 (x0,y0)
        PenUp
        Displacement(-x0,y0/2y)
        PenDown
        yield! 共头 [x0/3y;x0;x] [y0/2y;y]
    ]

///首笔冂左下点
///末笔口右下端
/// (x, y) 冂 (x0, y0) 口
let 同 (x, y) (x0, y0) =
    let x1 = (SByte.multiply 0.4 x) + (SByte.multiply 0.6 x0)
    let y1 = SByte.multiply 0.7 y0
    [
        Displacement(0y,y)
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-15y,9y) // 勾

        PenUp
        Displacement(-x/2y-x1/2y+15y,y-y1-9y)
        PenDown
        Displacement(x1,0y) // 横与口等长
        PenUp
        Displacement(-x1/2y-x0/2y,-y1)
        PenDown
        yield! 口(x0,y0)
    ]

/// 贯去掉贝
/// 首笔口左上
/// 末笔中横右端
/// (x, y) 口; x1 中横
let 躺申 (x, y) x1 =
    [
        yield! 躺日(x, y)
        PenUp
        Displacement(-x1/2y,y/2y)
        PenDown
        Displacement(x1,0y)
    ]

//cháng镸

///首笔外框上横右端
///末笔中间框左下点
/// (x0,y0)大框尺寸; (x1,y1)中间框尺寸
let 巨 (x0,y0) (x1,y1) =
    [
        yield! 匚(x0,y0)
        PenUp
        Displacement(-x0, SByte.average [y0;y1])
        PenDown
        yield! 匚(-x1,y1)
    ]

///首笔外框上横右端
///末笔下小竖下点
/// (x,y) 大框尺寸;
/// (x1,y1) 中间框尺寸
let 臣(x, y) (x1,y1) =
    //todo:中间的小口短一点
    //x两等分
    //y三等分
    [
        yield! 巨 (x,y) (x1,y1)

        PenUp
        Displacement(x1/2y,SByte.average [y;y1])
        PenDown
        let yy = (y-y1)/2y
        Displacement(0y,-yy)
        PenUp
        Displacement(0y,-y1)
        PenDown
        Displacement(0y,-yy)
    ]

///首笔顶横左点
///末笔冖右竖下端
///(x,y)丁; (x0,y0)冖
let 雨字头 (x,y) (x0,y0) =
    let x3 = SByte.multiply 0.3 x0 //横点长度
    let yy = 4y // 中竖下伸出长度
    let yd = 2y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x/2y,0y)
        PenDown
        Displacement(0y,-y)

        //下行两点
        PenUp
        Displacement(-x0/2y+x0/10y,yy+yd)
        PenDown
        Displacement(x3,0y)
        PenUp
        Displacement(x0/5y,0y)
        PenDown
        Displacement(x3,0y)

        //上行两点
        PenUp
        Displacement(0y,y0/2y)
        PenDown
        Displacement(-x3,0y)
        PenUp
        Displacement(-x0/5y,0y)
        PenDown
        Displacement(-x3,0y)

        PenUp
        Displacement(-x0/10y,-y0/2y-yd)
        PenDown
        yield! 冖 (x0,y0)


    ]

///首笔外框上横右端
///末笔下小竖下点
/// (x,y) 大框尺寸;
/// (x1,y1) 中间框尺寸
let 颐无页 (x,y) (x0,y0) =
    let x2 = SByte.multiply 0.6 x + SByte.multiply 0.4 x0
    [
        yield! 匚(x,y)
        PenUp
        Displacement(-x2, SByte.average [y;y0])
        PenDown
        yield! 口(x0,y0)

        let yy = (y-y0)/2y
        PenUp
        Displacement(x0/2y,yy)
        PenDown
        Displacement(0y,-yy)
        PenUp
        Displacement(0y,-y0)
        PenDown
        Displacement(0y,-yy)
    ]

let 单无八(x0,y0) (x1,y1)  =
    [
        yield! 日(x0,y0)
        PenUp
        Displacement((x0-x1)/2y,-SByte.multiply 0.9 y0)
        PenDown
        yield! 十 x1 [SByte.multiply 1.4 y0;y1]
    ]
///首笔上横左端
///末笔日字中横左端
/// (x, y) 总体尺寸; (x0,y0) 日字尺寸
let 曹头 (x,y) (x0,y0) =
    let x1 = x0/3y
    let y1 = (y-y0)/2y
    let x2 = SByte.average [x1;x]
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x2,y1)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(x1,y)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(-x1-x1,y0/2y)
        PenDown
        Displacement(x0,0y)
        PenUp
        Displacement(0y,-y0/2y)
        PenDown
        yield! 口(-x0,-y0)
    ]

///首笔顶横左点
///末笔口右下
///(x1,y1)十(x0,y0)口
let 古 (x1,y1) (x0,y0) =
    [
        yield! 十 x1 [y1/2y;y1]
        PenUp
        Displacement(x0/2y,-y0)
        PenDown
        yield! 口(-x0,-y0)
    ]

///首笔日左上点
///末笔中竖
///(x0,y0)日(x1,y1)十
let 早 (x0,y0) (x1,y1) =
    [
        yield! 日(x0,y0)
        PenUp
        Displacement((x0-x1)/2y,-y0)
        PenDown
        yield! 十 x1 [y0/2y;y1]
    ]

/// 带字顶头
///首笔横左点
///末笔右竖下点
let 卅头 (x,y) =
    let x0 = x/4y
    let y0 = y/2y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x+x0,y0)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(x0,y)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(x0,y)
        PenDown
        Displacement(0y,-y)
    ]
///首笔口左上端
///末笔中竖下端
/// (x0,y0) 口; [y1上头长度; y竖总长度]
let 中2 (x0,y0) ys =
    match ys with
    | [y1;y] ->
        [
            yield! 口(x0,y0)
            PenUp
            Displacement(x0/2y,y1)
            PenDown
            Displacement(0y,-y)
        ]
    | _ -> failwith $""
