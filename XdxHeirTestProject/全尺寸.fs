module XdxHeirTestProject.全尺寸
open shpParser

let 走之 =
    [
        PenUp
        Displacement(13y,113y)
        PenDown
        Displacement(19y,-18y)
        PenUp
        Displacement(-29y,-28y)
        PenDown
        Displacement(20y,0y)
        Displacement(0y,-46y)
        Displacement(-15y,-10y)
        PenUp
        Displacement(15y,10y)
        PenDown
        Displacement(31y,-15y)
        Displacement(70y,0y)
    
    ]

/// 首笔顶上点
/// 末笔广字撇尖
let 病字头 =
    [
        PenUp
        Displacement(57y,126y)
        PenDown
        Displacement(19y,-13y)
        PenUp
        Displacement(-70y,-23y)
        PenDown
        Displacement(13y,-18y)
        PenUp
        Displacement(-13y,-28y)
        PenDown
        Displacement(20y,18y)
        PenUp
        Displacement(94y,46y)
        PenDown
        Displacement(-94y,0y)
        Displacement(0y,-59y)
        Displacement(-8y,-25y)
        Displacement(-13y,-23y)
        ]

let 门 =
    [
        PenUp
        Displacement(18y,101y)
        PenDown
        Displacement(0y,-97y)
        PenUp
        Displacement(5y,120y)
        PenDown
        Displacement(17y,-23y)
        PenUp
        Displacement(15y,10y)
        PenDown
        Displacement(56y,0y)
        Displacement(0y,-97y)
        Displacement(-18y,-10y)
        ]

let 气 =
    [
        PenUp
        Displacement(33y,124y)
        PenDown
        Displacement(-27y,-38y)
        PenUp
        Displacement(23y,23y)
        PenDown
        Displacement(87y,0y)
        PenUp
        Displacement(-87y,-13y)
        PenDown
        Displacement(76y,0y)
        PenUp
        Displacement(-90y,-15y)
        PenDown
        Displacement(82y,0y)
        Displacement(0y,-28y)
        Displacement(4y,-23y)
        Displacement(13y,-23y)
        Displacement(9y,15y)
        ]

/// 长度117,高度26, 
///首笔是左点的上部,距离左端-18
let 四点底 =
    [
        Displacement(-18y,-25y)
        PenUp
        Displacement(40y,25y)
        PenDown
        Displacement(5y,-28y)
        PenUp
        Displacement(23y,28y)
        PenDown
        Displacement(9y,-25y)
        PenUp
        Displacement(18y,28y)
        PenDown
        Displacement(22y,-28y)
    
    ]
