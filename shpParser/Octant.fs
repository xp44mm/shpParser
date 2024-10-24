module shpParser.Octant

open System
open FSharp.Idioms.Literal
open type System.Math
open System.Numerics


/// counterclockwise if positive, and clockwise if negative
/// 
let parseSC (sc:int) =
    let sign = Math.Sign sc
    let sc = Math.Abs sc
    let s = sc / 16
    let c = sc % 16
    sign,s,c

let parseOffsetSC start_offset end_offset sc =
    let wise,sa,ca = parseSC sc

    let s0 = 0.
    let c0 = 0.

    let s =
        float start_offset * 45. / 256. + s0
    let c =
        float end_offset  * 45. / 256. + c0
    wise,s,c


//圆与向量的关系主要体现在以下几个方面：
//1. 向量可以表示圆上任意一点的切线方向。在圆上某一点P，存在一个向量，它的方向与该点的切线相同，这个向量称为切向量。
//2. 向量可以用来表示圆心到圆上任意一点的连线，即半径向量。这种向量具有固定的大小，即圆的半径，但其方向可以变化，指向圆上的不同点。
//3. 向量的数量积（点积）可以用来计算圆上的角。例如，通过计算两个半径向量的点积，可以得到它们之间的夹角，从而了解圆上两点的相对位置。

let getRadiusVector radius angle =
    Complex.FromPolarCoordinates(radius,angle)
    
