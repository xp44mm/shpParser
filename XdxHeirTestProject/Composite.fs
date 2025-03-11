namespace XdxHeirTestProject.Composite
open shpParser
open System
open XdxHeirTestProject

/// 首笔是上横左端
/// 末笔是下横右端
type 革 = // (x,y) =
    {
        横: sbyte*sbyte // 横上高度
        凵: sbyte*sbyte
        口: sbyte*sbyte
        十: sbyte*sbyte
    }
    member this.toYield() =
        let (x0,y0) = this.横
        let (x1,y1) = this.凵
        let (x2,y2) = this.口
        let dy = SByte.multiply 0.7 y2 // 口的上下间距
        let x3,y3 = this.十
        [
            yield! Radical.廿 (x1,y0) (x0,y1)
            PenUp
            Displacement(SByte.average [-x1;-x2], -y1-dy)
            PenDown
            yield! Radical.口 (x2, y2)
            PenUp
            Displacement((x2-x3)/2y, -y2-dy)
            PenDown
            yield! Radical.十 x3 [y2+dy+dy;y3]
        ]

/// 贵去掉贝字
type 虫无点 =
    {
        口:sbyte*sbyte
        丄:sbyte*sbyte
    }
    ///首笔口左上端
    ///末笔下横右端
    member this.toYield() =
        let x0,y0 = this.口
        let x1,y1 = this.丄
        let y2 = (y1-y0)/2y
        [
            yield! Radical.口(x0,y0)
            PenUp
            Displacement(x0/2y,y2)
            PenDown
            Displacement(0y,-y1)
            PenUp
            Displacement(-x1/2y,0y)
            PenDown
            Displacement(x1,0y)
        ]

type 止 =
    {
        丄: sbyte*sbyte
        /// 两横间距
        短横: sbyte*sbyte
        /// 两竖间距
        短竖: sbyte*sbyte
    }

    ///首笔中竖顶端
    ///末笔长横左端
    member this.toYield() =
        let x,y = this.丄
        let x1,y1 = this.短竖
        let x2,y2 = this.短横
        [
            Displacement(0y,-y) // 中竖
            PenUp
            Displacement(-x1,y1) // y1 短竖长度
            PenDown
            Displacement(0y,-y1) // 短竖
            PenUp
            Displacement(x1,y2) // y2 两横间距
            PenDown
            Displacement(x2,0y) // x2 短横长度
            PenUp
            Displacement(-x2-x/2y,-y2)
            PenDown
            Displacement(x,0y)
        ]

type 上 =
    {
        /// x距左端距离
        竖: sbyte*sbyte
        /// x竖距下底距离
        短横: sbyte*sbyte
        横:sbyte
    }
    ///首笔竖上端
    ///末笔长横右端
    member this.toYield() =
        let x0,y0 = this.竖
        let x1,y1 = this.短横
        [
            Displacement(0y,-y0)
            PenUp
            Displacement(0y,y1)
            PenDown
            Displacement(x1,0y) //短横
            PenUp
            Displacement(-x1-x0,-y1)
            PenDown
            Displacement(this.横,0y)
        ]

///首笔顶横左端
///末笔底横右端
/// xs(x0 顶横长度, x 底横长度,x1 两竖间距[.3],x2 短横长度[.4])
/// ys(y 中竖,y1 短竖长度[.7],y2 两横间距[.6])
type 正 =
    {
        /// 横竖横，按笔顺
        工: sbyte*sbyte*sbyte
        /// 两横间距
        短横: sbyte*sbyte
        /// 两竖间距
        短竖: sbyte*sbyte
        
    }
    member this.toYield() =
        let x0,y,x1 = this.工
        [
            Displacement(x0,0y)
            PenUp
            Displacement(-x0/2y,0y)
            PenDown
            yield! (id<止> {
                    丄 = x1,y
                    短竖 = this.短竖
                    短横 = this.短横
                }).toYield()
        ]

type 十早 = // (x,y) =
    {
        十: sbyte*sbyte
        日: sbyte*sbyte
        横: sbyte*sbyte // 横上高度
        竖: sbyte
    }
    ///首笔顶十横左端
    ///末笔底十竖下端
    member this.toYield() =
        let x1,y1 = this.十
        let x2,y2 = this.日
        let x3,y3 = this.横
        [
            yield! Radical.十 x1 [y1/2y;y1]
            PenUp
            Displacement(-x2/2y, 0y)
            PenDown
            yield! Radical.日 (x2, y2)
            PenUp
            Displacement((x2-x1)/2y, -y2/2y-y3)
            PenDown
            yield! Radical.十 x3 [y3;this.竖]
        ]

//type 西 = 
//    {
//        总尺寸:sbyte*sbyte
//        竖撇:sbyte*sbyte

//    }

