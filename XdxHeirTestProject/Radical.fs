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
        Displacement(-15y,10y) //勾
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

let 十(x, y) =
    let x1 = x/2y
    let y1 = y/2y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x1,y1)
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

/// 首笔左上
/// 末笔中竖下端
let 倒日(x, y) =
    [
        yield! 口(x, y)
        yield! move (x/2y) 0y
        Displacement(0y,-y)
    ]

///首笔左上
///末笔第二竖下端
let 四(x, y) =
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

let 皿(x, y) =
    let x1 = x/5y
    [
        Displacement(0y,y)
        Displacement(3y*x1,0y)
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
        Displacement(-2y*x1,0y)
        PenDown
        Displacement(x,0y)
    ]


///首笔左竖高点
///末笔中竖下点
let 山( x, y) =
    [
        Displacement(0y,-y)
        Displacement(x,0y)
        Displacement(0y,y)
        PenUp
        Displacement(-x/2y,15y)
        PenDown
        Displacement(0y,-y-15y)
    ]
///首笔上横左边
///末笔中横左边
/// ji
let 彐( x, y) =
    [
        Displacement(x,0y)
        Displacement(0y,-y)
        Displacement(-x,0y)
        PenUp
        Displacement(x,y/2y)
        PenDown
        Displacement(-x,0y)
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
let 艹 x y =
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

//(x,y) 外接矩形尺寸
//(x1,y1) 左上角矩形尺寸
///首笔上横左端
///末笔右竖上端
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

/// 首笔是上横左端
/// 末笔是下横右端
let 革 (x,y) =
    let x1 = x/4y // 廿横出头的长度
    let x2 = x-x1 // 口

    //4廿34口3十4
    let y1 = SByte.multiply (4./18.) y

    let y2 = SByte.multiply 0.4 y1 //廿竖出头的长度

    let l = (y-y1) //中竖高度


    //口顶标高
    let y4 = SByte.multiply (11./18.) y

    [
        yield! 廿 (x,y1) (x1,y2)
        yield! move -x1 -y1
        Displacement(0y,-l) //中竖
        yield! move -(x2/2y) y4
        yield! 口 (x2, y1)
        yield! move -(x/8y) (SByte.multiply (7./18.) -y)
        Displacement(x,0y)

    ]

//首笔左上点
//末笔中竖下端
let 雨 (x,y) =
    let y1= y/3y // 间距
    let x1 = x/6y //点长
    let y2 = y-y1 //竖长
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x,-y)
        PenDown
        Displacement(0y,y2)
        Displacement(x,0y)
        Displacement(0y,-y2)
        PenUp
        Displacement(-x1,y1)
        PenDown
        Displacement(-x1,0y)
        PenUp
        Displacement(x1,-y1)
        PenDown
        Displacement(-x1,0y)
        PenUp
        Displacement(-x/3y,y1)
        PenDown
        Displacement(-x1,0y)
        PenUp
        Displacement(x1,-y1)
        PenDown
        Displacement(-x1,0y)
        PenUp
        Displacement(x/3y,y)
        PenDown
        Displacement(0y,-y)

    ]
///首笔顶横线左端
///末笔中竖下端
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

///首笔第一个横线
///末笔中竖下端
let 青头(x,y) =
    let x1 = x/2y
    let y1 = SByte.multiply (3./8.) y
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

///首笔第一个横线
///末笔左竖下端
let 非 (x,y) =
    let x1 = x/3y
    let y1 = y/4y
    let 三横 =
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
        ]

    [
        yield! 三横
        PenUp
        Displacement(x1,y/2y)
        PenDown
        yield! 三横
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

///首笔左上
///末笔下隔横左端
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
///例如:追去掉走之，去掉撇，剩余的部分
///入口第二横左端
///末笔第三横左端
/// yi 以，繁体字
let 㠯 (x, y) =
    let y1 = y/3y
    [
        Displacement(x,0y)
        Displacement(0y,y1)
        Displacement(-x,0y)
        Displacement(0y,-y)
        Displacement(x,0y)
        Displacement(0y,y1)
        Displacement(-x,0y)    
    
    ]

///首笔上横左端
///末笔日字中横左端
let 曹头 (x, y) =
    let x2 = SByte.multiply 0.8 x
    let x3 = SByte.multiply (0.8/3.0) x
    let x4 = SByte.multiply (0.8/3.0+0.1) x
    let y2 = y/2y
    let y3 = SByte.multiply 0.75 y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x4,-y3)
        PenDown
        Displacement(0y,y)
        PenUp
        Displacement(-x3,-y)
        PenDown
        Displacement(0y,y)
        PenUp
        Displacement(-x3,-y2)
        PenDown
        yield! 日(x2,y2)
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

let 廾 (x, y) =
    [
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

///首笔长横左端
///末笔中竖下端
let 上(x, y) =
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x/2y,y/2y)
        PenDown
        Displacement(x/3y,0y) //短横
        PenUp
        Displacement(-x/3y,y/2y)
        PenDown
        Displacement(0y,-y)
    ]


///首笔长横左端
///末笔中竖下端
let 止(x, y) =
    let x1 = SByte.multiply 0.75 x
    let y1 = SByte.multiply (2./3.) y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x1,y1)
        PenDown
        Displacement(0y,-y1) //短竖
        PenUp
        Displacement(x/4y,y/2y)
        PenDown
        Displacement(x/3y,0y) //短横
        PenUp
        Displacement(-x/3y,y/2y)
        PenDown
        Displacement(0y,-y)
    ]

/// 首笔右下
/// 末笔中下
let 臣(x, y) =
    //todo:中间的小口短一点
    //x两等分
    //y三等分
    [
        Displacement(-x,0y)
        Displacement(0y,y)
        Displacement(x,0y)
        PenUp
        Displacement(-x/2y,0y)
        PenDown
        Displacement(0y,-y/3y)
        PenUp
        Displacement(-x/2y,0y)
        PenDown
        Displacement(x,0y)
        Displacement(0y,-y/3y)
        Displacement(-x,0y)
        PenUp
        Displacement(x/2y,0y)
        PenDown
        Displacement(0y,-y/3y)
    ]

///首笔下面长横左端
///末笔中竖下端
let 土(x, y) =
    let x1 = SByte.multiply (2./3.) x //短横长度
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x/6y,y/2y)
        PenDown
        Displacement(-x1,0y) //短横
        PenUp
        Displacement(x/3y,y/2y)
        PenDown
        Displacement(0y,-y)
    ]

///首笔顶横左端
///末笔中竖下端
let 正(x, y) =
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x,-y)
        PenDown
        yield! 止(x,y)
    ]

/// 首笔口左上
/// 末笔底横中点
let 由(x, y) =
    let y1 = y/3y
    [
        yield! 日(x, y-y1)
        yield! move (x/2y) (y-y1)
        Displacement(0y,-y)
    ]

let 竖弯钩(x, y) =
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

    let g = 14y
    [
    Displacement(x,0y)
    Displacement(0y,-y1)
    Displacement(-x,0y)
    Displacement(0y,-y1)
    Displacement(x,0y)
    Displacement(0y,-y2)
    Displacement(-20y,14y)
    ]

/// 首笔顶横左端
/// 末笔大口左上
let 酉(x, y) =
    let x1 = x/3y    
    let y1 = y/2y
    let y2 = SByte.multiply 0.75 y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(0y,y1)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        Displacement(0y,y1)
        PenUp
        Displacement(-x1,-y2)
        PenDown
        Displacement(x,0y)
        PenUp
        Displacement(-x,y1)
        PenDown
        yield! 口(x,y2)
    ]

/// 首笔顶横左端
/// 末笔底横右端
let 四横一竖(x, y) =
    let y1 = y/3y
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
        Displacement(-x/2y,y-y1)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(-x/2y,0y)
        PenDown
        Displacement(x,0y)    
    ]

/// 首笔上左竖上端
/// 末笔中竖下端
let 出(x, y) =
    let y1 = SByte.multiply (40./95.) y
    let y2 = SByte.multiply (55./95.) y
    [
        yield! 凵(x,y1)
        PenUp
        Displacement(-x,-y2)
        PenDown
        yield! 凵(x,y1)
        PenUp
        Displacement(-x/2y,y2)
        PenDown
        Displacement(0y,-y)
    ]

/// 首笔上横左端
/// 末笔左下角
let 而(x, y) =
    let x1 = x/3y
    let x2 = x/6y
    let y1 = SByte.multiply (2./7.) y
    let y2 = SByte.multiply (5./7.) y
    
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x1,-y)
        PenDown
        Displacement(0y,y2)
        PenUp
        Displacement(-x1,-y2)
        PenDown
        Displacement(0y,y2)
        PenUp
        Displacement(x2,y1)
        PenDown
        Displacement(-x1,-y1)
        PenUp
        Displacement(x-x2-14y,-y2+8y)
        PenDown
        Displacement(14y,-8y)
        Displacement(0y,y2)
        Displacement(-x,0y)
        Displacement(0y,-y2)
    ]

/// 首笔左下角
/// 末笔右竖下端
let 且(x, y) =
    let x1 = 15y
    let x2 = x-2y*x1
    let y1 = y/3y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x+x1,y1)
        PenDown
        Displacement(x2,0y)
        PenUp
        Displacement(-x2,y1)
        PenDown
        Displacement(x2,0y)
        PenUp
        Displacement(-x2,-2y*y1)
        PenDown
        Displacement(0y,y)
        Displacement(x2,0y)
        Displacement(0y,-y)
    ]
/// 首笔左下角
/// 末笔右竖下端
let 昔头(x,y)=
    let x1 = x/3y
    let y1 = SByte.multiply 0.4 y
    let y2 = SByte.multiply 0.6 y

    [
        Displacement(x,0y)
        PenUp
        Displacement(-x,y2)
        PenDown
        Displacement(x,0y)
        PenUp
        Displacement(-x1-x1,y1)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(x1,y)
        PenDown
        Displacement(0y,-y)
    ]

/// 首笔左上角
/// 末笔右下角
let 工(x,y)=
    let x1 = x/2y
    [
        Displacement(x,0y)
        PenUp
        Displacement(-x1,0y)
        PenDown
        Displacement(0y,-y)
        PenUp
        Displacement(-x1,0y)
        PenDown
        Displacement(x,0y)
    ]

let 丁 x1 (x,y) =
    let x1 = SByte.multiply x1 x
    [
    Displacement(x,0y)
    PenUp
    Displacement(-x1-20y,-y+14y)
    PenDown
    Displacement(20y,-14y)
    Displacement(0y,y)
    ]

let 臼 (x,y) =
    let x1 = x/3y
    let y1 = y/2y
    [
        Displacement(-x1,-6y)
        Displacement(0y,-y)
        Displacement(x,0y)
        Displacement(0y,y)
        Displacement(-x1,0y)
        PenUp
        Displacement(-x+x1,-y1)
        PenDown
        Displacement(x1,0y)
        PenUp
        Displacement(x-x1-x1,0y)
        PenDown
        Displacement(x1,0y)
    ]

/// 首笔上竖的上点
/// 末笔口的左上点
let 占 (x,y) =
    let x1= x/2y
    let y1 = y/4y
    let y2= y/2y
    [
        Displacement(0y,-y2)
        PenUp
        Displacement(x1,y1)
        PenDown
        Displacement(-x1,0y)
        PenUp
        Displacement(-x1,-y1)
        PenDown
        yield! 口(x,y2)
    ]
