module shpParser.SByte
open System

let fromFloat (x:float) =
    let x = Math.Round(x)
    if x >= 127. then 127y
    elif x <= -127. then -127y
    else sbyte x

let multiply (x:float) (y:sbyte) =
    let yy = float y
    fromFloat (x*yy)
