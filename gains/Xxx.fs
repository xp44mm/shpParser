module Xxx

//let xxx =
//    let dict = Dictionary<uint16,Specification list>()
//    // 、
//    dict.[41378us] <- [
//        PenUp
//        Displacement(49y,17y)
//        PenDown
//        BulgeArc(-34y,30y,8y)
//    ]
//    // 。
//    dict.[41379us] <- [
//        PenUp
//        Displacement(32y,32y)
//        PenDown
//        OctantArc(15uy,0x20y)
//    ]
//    // —
//    dict.[41386us] <- [
//        PenUp
//        Displacement(0y,63y)
//        PenDown
//        Displacement(127y,0y)
//    ]
//    // …
//    dict.[41389us] <- [
//        PenUp
//        Displacement(10y,63y)
//        PenDown
//        OctantArc(6uy,0x40y)
//        PenUp
//        Displacement(48y,0y)
//        PenDown
//        OctantArc(6uy,0x40y)
//        PenUp
//        Displacement(48y,0y)
//        PenDown
//        OctantArc(6uy,0x40y)
//    ]
//    // ‘
//    dict.[41390us] <- [
//        PenUp
//        Displacement(98y,87y)
//        PenDown
//        OctantArc(6uy,0x40y)
//        Displacement(0y,10y)
//        BulgeArc(15y,26y,-32y)
//    ]
//    // ’
//    dict.[41391us] <- [
//        PenUp
//        Displacement(22y,84y)
//        PenDown
//        BulgeArc(15y,26y,32y)
//        Displacement(0y,10y)
//        OctantArc(6uy,0x0y)
//    ]
//    // “
//    dict.[41392us] <- [
//        PenUp
//        Displacement(88y,85y)
//        Push
//        PenDown
//        OctantArc(6uy,0x40y)
//        Displacement(0y,10y)
//        BulgeArc(15y,26y,-32y)
//        Pop
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        OctantArc(6uy,0x40y)
//        Displacement(0y,10y)
//        BulgeArc(15y,26y,-32y)
//    ]
//    // ”
//    dict.[41393us] <- [
//        PenUp
//        Displacement(8y,85y)
//        Push
//        PenDown
//        BulgeArc(15y,26y,32y)
//        Displacement(0y,10y)
//        OctantArc(6uy,0x0y)
//        Pop
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        BulgeArc(15y,26y,32y)
//        Displacement(0y,10y)
//        OctantArc(6uy,0x0y)
//    ]
//    // ！
//    dict.[41889us] <- [
//        PenUp
//        Displacement(30y,32y)
//        PenDown
//        OctantArc(5uy,0x20y)
//        PenUp
//        Displacement(0y,12y)
//        PenDown
//        Displacement(0y,76y)
//    ]
//    // （
//    dict.[41896us] <- [
//        PenUp
//        Displacement(95y,127y)
//        PenDown
//        BulgeArc(0y,-127y,64y)
//    ]
//    // ）
//    dict.[41897us] <- [
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        BulgeArc(0y,127y,64y)
//    ]
//    // ，
//    dict.[41900us] <- [
//        PenUp
//        Displacement(21y,0y)
//        PenDown
//        BulgeArc(15y,18y,42y)
//        Displacement(0y,10y)
//        OctantArc(6uy,0x0y)
//    ]
//    // ：
//    dict.[41914us] <- [
//        PenUp
//        Displacement(30y,32y)
//        PenDown
//        OctantArc(6uy,0x20y)
//        PenUp
//        Displacement(0y,59y)
//        PenDown
//        OctantArc(6uy,0x20y)
//    ]
//    // ；
//    dict.[41915us] <- [
//        PenUp
//        Displacement(21y,0y)
//        PenDown
//        BulgeArc(15y,18y,42y)
//        Displacement(0y,10y)
//        OctantArc(6uy,0x0y)
//        PenUp
//        Displacement(0y,57y)
//        PenDown
//        OctantArc(6uy,0x0y)
//    ]
//    // ？
//    dict.[41919us] <- [
//        PenUp
//        Displacement(29y,30y)
//        PenDown
//        OctantArc(5uy,0x20y)
//        PenUp
//        Displacement(0y,14y)
//        PenDown
//        Displacement(0y,5y)
//        BulgeArc(5y,14y,-23y)
//        Displacement(15y,17y)
//        BulgeArc(5y,25y,44y)
//        BulgeArc(-46y,3y,58y)
//        BulgeArc(-5y,-11y,23y)
//    ]
//    Map.fromInterface dict
