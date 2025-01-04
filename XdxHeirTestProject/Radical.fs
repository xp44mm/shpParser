module XdxHeirTestProject.Radical
open shpParser

let disp (x:int) (y:int) = Displacement(sbyte x,sbyte y)

let move x y =
    [
        PenUp
        Displacement(x,y)
        PenDown
    ]

let tail () =
    [
        Pop
        PenUp
        Displacement(127y,0y)
        EndOfShape
    ]

let 口 x y =
    [
        Displacement(0y,y)
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-x,0y)
    ]

let bordersTail () =
    [
        Pop
        yield! 口 127y 127y
        Displacement(127y,0y)
        EndOfShape
    ]

let 日 x y =
    [
        yield! 口 x y
        yield! move x (y/2y)
        Displacement(-x,0y)
    ]

let 皿 x y =
    let c = x/5y

    [
        Displacement(0y,y)
        Displacement(3y*c,0y)
        Displacement(0y,-y)
        PenUp
        Displacement(-c,y)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(-c,y)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(-2y*c,0y)
        PenDown
        Displacement(x,0y)
    ]

let 巴 x y =
    let chamfer = 7y
    let y1 = y |> SByte.multiply 0.44
    [
        Displacement(0y,-y1)
        PenUp
        Displacement(-x/2y,0y)
        PenDown
        Displacement(x,0y)
        Displacement(0y,y1)
        Displacement(-x,0y)
        Displacement(0y,-(y-chamfer))
        Displacement(chamfer,-chamfer)
        Displacement(x-chamfer,0y)

        Displacement(chamfer,2y*chamfer)
    ]


let 四 x y =
    // first at (0,0)
    let x1= x / 3y
    [
        yield! 口 x y
        PenUp
        Displacement(x1,y)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(x1,y)
        PenDown
        Displacement(0y,-y) // last at (2x/3,0)
    ]

let 田 x y =
    // first at (0,0)
    [
        yield! 日 x y
        yield! move (x/2y) (y/2y)
        Displacement(0y,-y) // last at (x/2,0)
    ]

///首笔左竖高点
///末笔中竖下点
let 山 x y =
    let yy = SByte.multiply 1.4 y //中竖高度
    [
        Displacement(0y,-y)
        Displacement(x,0y)
        Displacement(0y,y)
        PenUp
        Displacement(-x/2y,yy-y)
        PenDown
        Displacement(0y,-yy)
    ]

//x1 上横长度
//x2 下横长度
//y1 上下横之间距离
//y  竖长度
let 干 x1 x2 y1 y =
    // first at (0,0)
    let dx = (x2-x1)/2y

    [
        Displacement(x1,0y)
        yield! move -(x1+dx) -y1
        Displacement(x2,0y)
        yield! move -(x2/2y) y1

        Displacement(0y,-y)
    ]

/// 首笔横左端
/// 末笔右竖下端
let 草字头 x y =
    let x0 = x/3y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-2y*x0,y/2y)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(x0,y)
        PenDown
        Displacement(0y,-y)
    ]

let 白 (x1,y1) (x2, y2) =
    [
        Displacement(x1,y1)
        Displacement(0y,-y2)
        Displacement(x2,0y)
        Displacement(0y,y2)
        Displacement(-x2,0y)
        PenUp
        Displacement(x2,-y2/2y)
        PenDown
        Displacement(-x2,0y)
    ]
//(x,y) 外接矩形尺寸
//(x1,y1) 左上角矩形尺寸
let 廿 (x,y) (x1,y1) =
    [
        Displacement(x,0y) //最长的横
        PenUp
        Displacement(-x+x1,y1)
        PenDown
        Displacement(0y,-y)
        Displacement(x-2y*x1,0y)
        Displacement(0y,y) //右竖
    ]
/// x 一的长度
/// (x1,y1) 口对角线
/// (x2,y2) 田对角线
/// y 一口田之间间距
/// 首笔一左端点，末笔田中竖下端点
let 一口田 x (x1,y1) (x2,y2) y =
    [
        Displacement(x,0y)
        yield! move (-(x+x1)/2y) -(y+y1)
        yield! 口 x1 y1
        yield! move ((x1-x2)/2y) -(y+y2)
        yield! 田 x2 y2
    ]

let 自 (x1,y1) (x2, y2) =
    [
        Displacement(x1,y1)
        Displacement(0y,-y2)
        Displacement(x2,0y)
        Displacement(0y,y2)
        Displacement(-x2,0y)
        PenUp
        Displacement(x2,-y2/3y)
        PenDown
        Displacement(-x2,0y)
        PenUp
        Displacement(x2,-y2/3y)
        PenDown
        Displacement(-x2,0y)
    ]


let 回 (x,y) (x1,y1) =
    let dx = (x-x1)/2y
    let dy = (y-y1)/2y
    [
        yield! 口 x y

        PenUp
        Displacement(dx,dy)
        PenDown

        yield! 口 x1 y1

    ]
// (x1,y1) 撇
//末笔第二横的右端
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

let 用 (x,y) =
    let y1 = y/4y
    let x1 = SByte.multiply 0.6 y1
    [
        Displacement(0y,-y)
        yield! move (-(x+x1)/2y) 0y
        yield! 月 (x,y) (x1,y1)
    ]

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

/// 两个月紧贴着
let 朋 (x,y) (x1,y1) =
    let ll = y-y1 //竖撇的竖长度
    let c = SByte.multiply 0.42 ll

    [
        yield! 月 (x/2y,y) (x1,y1)
        yield! move 0y (-y+c+c)
        yield! 月 (x/2y,y) (x1,y1)
    ]

let 革 (x,y) =
    let x1 = x/4y // 廿横出头的长度
    let x2 = x/2y //廿底宽
    let x3 = x-x1 // 口

    //4廿34口3十4
    let y1 = SByte.multiply (4./18.) y

    let y2 = SByte.multiply 0.4 y1 //廿竖出头的长度

    let l = (y-y1) //中竖高度


    let y3 = SByte.multiply (3./18.) y //口上下外边距

    [
        yield! 廿 (x,y1) (x1,y2)
        yield! move -x1 -y1
        Displacement(0y,-l)
        yield! move -(x3/2y) (l/2y)
        yield! 口 x3 y1
        yield! move -(x/8y) (-y3)
        Displacement(x,0y)

    ]

let 雨 (x,y) =
    let y1= y/3y // 间距
    let x1 = x/6y //点长

    [
        Displacement(x,0y)
        PenUp
        Displacement(-x,-y)
        PenDown
        Displacement(0y,y-y1)
        Displacement(x,0y)
        Displacement(0y,-(y-y1))
        PenUp
        Displacement(-(x/2y),y)
        PenDown
        Displacement(0y,-y-7y) //中竖
        PenUp
        Displacement(x1-x/2y,y1+7y)
        PenDown
        Displacement(x1,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(x1,0y)
        PenUp
        Displacement(x/3y,y1)
        PenDown
        Displacement(x1,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(x1,0y)
    ]

let 王 (x,y) =
    let x1 = x/2y
    let y1 = y/2y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x,-y1)
        PenDown
        Displacement(x,0y)
        PenUp
        Displacement(-x,-y1)
        PenDown
        Displacement(x,0y)
        PenUp
        Displacement(-x1,y)
        PenDown
        Displacement(0y,-y)
    ]

//二三十石目中申旦止正

///首笔第一个横线
///末笔左竖下端
let 非 (x,y) =
    let x1 = x/3y
    let y1 = y/4y
    [
        Displacement(x1,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(x1,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(x1,0y)

        PenUp
        Displacement(x1,y/2y)
        PenDown

        Displacement(x1,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(x1,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(x1,0y)

        PenUp
        Displacement(-x1,y-y1)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(-x1,y)
        PenDown
        Displacement(0y,-y)
    ]

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
