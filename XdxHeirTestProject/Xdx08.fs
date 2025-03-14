﻿module XdxHeirTestProject.Xdx08
open shpParser
open XdxHeirTestProject.Composite

let chunk = [
    // 恬
    52465us, [
        PenUp
        Displacement(4y,62y)
        PenDown
        Displacement(8y,33y)
        PenUp
        Displacement(14y,28y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(11y,99y)
        PenDown
        Displacement(8y,-28y)
        PenUp
        Displacement(11y,38y)
        PenDown
        Displacement(18y,0y)
        Displacement(27y,5y)
        Displacement(17y,3y)
        PenUp
        Displacement(-66y,-33y)
        PenDown
        yield! Radical.十 74y [28y;59y]
        PenUp
        Displacement(-26y,0y)
        PenDown
        yield! Radical.口(52y,41y)
    ]
    // 舔
    52466us, [
        PenUp
        Displacement(51y,119y)
        PenDown
        Displacement(-42y,-8y)
        PenUp
        Displacement(-4y,-25y)
        PenDown
        yield! Radical.十 46y [28y;51y]
        PenUp
        Displacement(-15y,0y)
        PenDown
        yield! Radical.口(30y,38y)
        PenUp
        Displacement(41y,54y)
        PenDown

        yield! Radical.中心对齐等距横 [60y;70y] 25y

        PenUp
        Displacement(-37y,23y)
        PenDown
        Displacement(-6y,-23y)
        Displacement(-8y,-18y)
        Displacement(-22y,-18y)
        PenUp
        Displacement(40y,33y)
        PenDown
        Displacement(9y,-13y)
        Displacement(10y,-10y)
        Displacement(14y,-8y)
        PenUp
        Displacement(-43y,13y)
        PenDown
        Displacement(0y,-56y)
        Displacement(-15y,-10y)
        PenUp
        Displacement(0y,46y)
        PenDown
        Displacement(-9y,-38y)
        PenUp
        Displacement(32y,36y)
        PenDown
        Displacement(15y,-31y)
        PenUp
        Displacement(-1y,36y)
        PenDown
        Displacement(20y,-36y)
    ]
    // 腆
    52467us, [
        PenUp
        Displacement(4y,6y)
        PenDown
        Displacement(9y,18y)
        Displacement(4y,33y)
        Displacement(0y,54y)
        Displacement(24y,0y)
        Displacement(0y,-94y)
        Displacement(-3y,-8y)
        Displacement(-5y,-3y)
        Displacement(-9y,0y)
        PenUp
        Displacement(-6y,48y)
        PenDown
        Displacement(19y,0y)
        PenUp
        Displacement(3y,28y)
        PenDown
        Displacement(-20y,0y)
        PenUp
        Displacement(41y,-41y)
        PenDown
        yield! Radical.典无八 (54y,56y) (76y,82y)

        PenUp
        Displacement(-48y,-4y)

        PenDown
        Displacement(-14y,-18y)
        Displacement(-14y,-10y)
        PenUp
        Displacement(47y,25y)
        PenDown
        Displacement(28y,-25y)
    ]
    // 挑
    52468us, [
        PenUp
        Displacement(1y,93y)
        PenDown
        Displacement(42y,0y)
        PenUp
        Displacement(-19y,31y)
        PenDown
        Displacement(0y,-112y)
        Displacement(-3y,-5y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-10y,41y)
        PenDown
        Displacement(45y,23y)
        PenUp
        Displacement(3y,31y)
        PenDown
        Displacement(13y,-25y)
        PenUp
        Displacement(-22y,-33y)
        PenDown
        Displacement(29y,18y)
        PenUp
        Displacement(1y,66y)
        PenDown
        Displacement(0y,-79y)
        Displacement(-4y,-15y)
        Displacement(-8y,-10y)
        Displacement(-19y,-18y)
        PenUp
        Displacement(52y,120y)
        PenDown
        Displacement(0y,-107y)
        Displacement(3y,-8y)
        Displacement(23y,0y)
        Displacement(5y,15y)
        PenUp
        Displacement(-4y,79y)
        PenDown
        Displacement(-18y,-25y)
        PenUp
        Displacement(-8y,-18y)
        PenDown
        Displacement(27y,-18y)
    ]
    // 条
    52469us, [
        PenUp
        Displacement(57y,126y)
        PenDown
        Displacement(-17y,-18y)
        Displacement(-27y,-25y)
        PenUp
        Displacement(31y,25y)
        PenDown
        Displacement(54y,0y)
        Displacement(-31y,-23y-5y)
        Displacement(-25y,-15y)
        Displacement(-15y,-3y)
        Displacement(-18y,-5y)
        PenUp
        Displacement(36y,38y)
        PenDown
        Displacement(22y,-15y)
        Displacement(22y,-13y)
        Displacement(19y,-8y)
        Displacement(18y,-3y)
        PenUp
        Displacement(-102y,-10y)
        PenDown
        Displacement(84y,0y)
        PenUp
        Displacement(-42y,18y)
        PenDown
        Displacement(0y,-56y)
        Displacement(-8y,-5y)
        Displacement(-13y,0y)
        PenUp
        Displacement(0y,33y)
        PenDown
        Displacement(-17y,-15y)
        Displacement(-19y,-10y)
        PenUp
        Displacement(71y,23y)
        PenDown
        Displacement(17y,-13y)
        Displacement(15y,-15y)
    ]
    // 迢
    52470us, [
        PenUp
        Displacement(18y,113y)
        PenDown
        Displacement(19y,-23y)
        PenUp
        Displacement(-29y,-20y)
        PenDown
        Displacement(20y,0y)
        Displacement(0y,-46y)
        PenUp
        Displacement(-19y,-13y)
        PenDown
        Displacement(9y,8y)
        Displacement(10y,5y)
        Displacement(13y,-5y)
        Displacement(15y,-8y)
        Displacement(19y,-3y)
        Displacement(23y,0y)
        Displacement(23y,3y)
        PenUp
        Displacement(-75y,102y)
        PenDown
        Displacement(66y,0y)
        Displacement(-3y,-23y)
        Displacement(-4y,-13y)
        Displacement(-8y,-3y)
        Displacement(-9y,-3y)
        PenUp
        Displacement(-13y,41y)
        PenDown
        Displacement(-5y,-20y)
        Displacement(-11y,-13y)
        Displacement(-17y,-15y)
        PenUp
        Displacement(14y,-2y)
        PenDown
        yield! Radical.口(51y,28y)
    ]
    // 眺
    52471us, [
        PenUp
        Displacement(9y,115y)
        PenDown
        yield! Radical.目(28y,89y)
        PenUp
        Displacement(36y,46y)
        PenDown
        Displacement(15y,-25y)
        PenUp
        Displacement(-15y,-33y)
        PenDown
        Displacement(23y,15y)
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(0y,-71y)
        Displacement(0y,-15y)
        Displacement(-11y,-15y)
        Displacement(-22y,-18y)
        PenUp
        Displacement(55y,122y)
        PenDown
        Displacement(0y,-102y)
        Displacement(1y,-5y)
        Displacement(4y,-5y)
        Displacement(19y,0y)
        Displacement(4y,5y)
        Displacement(3y,10y)
        PenUp
        Displacement(-6y,79y)
        PenDown
        Displacement(-17y,-25y)
        PenUp
        Displacement(-5y,-15y)
        PenDown
        Displacement(27y,-20y)
    ]
    // 跳
    52472us, [
        PenUp
        Displacement(10y,88y)
        PenDown
        yield! Radical.口(33y,-33y)
        PenUp
        Displacement(19y,0y)
        PenDown
        Displacement(0y,-59y)
        PenUp
        Displacement(3y,33y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(-40y,8y)
        PenDown
        Displacement(0y,-46y)
        PenUp
        Displacement(-9y,-8y)
        PenDown
        Displacement(47y,20y)
        PenUp
        Displacement(-8y,-31y)
        PenDown
        Displacement(11y,8y)
        Displacement(16y,16y)
        Displacement(5y,13y)
        Displacement(2y,20y)
        Displacement(0y,64y)
        PenUp
        Displacement(18y,-3y)
        PenDown
        Displacement(0y,-104y)
        Displacement(3y,-5y)
        Displacement(13y,-3y)
        Displacement(9y,0y)
        Displacement(3y,5y)
        Displacement(3y,8y)
        PenUp
        Displacement(-70y,76y)
        PenDown
        Displacement(14y,-20y)
        PenUp
        Displacement(-22y,-33y)
        PenDown
        Displacement(28y,15y)
        PenUp
        Displacement(46y,41y)
        PenDown
        Displacement(-18y,-23y)
        PenUp
        Displacement(-5y,-15y)
        PenDown
        Displacement(24y,-20y)
    ]
    // 贴
    52473us, [
        PenUp
        Displacement(13y,40y)
        PenDown
        Displacement(0y,74y)
        Displacement(37y,0y)
        Displacement(0y,-69y)
        PenUp
        Displacement(-17y,46y)
        PenDown
        Displacement(0y,-33y)
        Displacement(-4y-5y,-15y-15y)
        Displacement(-9y,-10y)
        Displacement(-13y,-8y)
        PenUp
        Displacement(34y,25y)
        PenDown
        Displacement(20y,-18y)
        PenUp
        Displacement(31y,110y)
        PenDown
        Displacement(0y,-61y)
        PenUp
        Displacement(3y,31y)
        PenDown
        Displacement(34y,0y)
        PenUp
        Displacement(-59y,-33y)
        PenDown
        yield! Radical.口(48y,46y)

    ]
    // 铁
    52474us, [
        PenUp
        Displacement(31y,126y)
        PenDown
        Displacement(-14y,-23y)
        Displacement(-17y,-18y)
        PenUp
        Displacement(18y,18y)
        PenDown
        Displacement(33y,0y)
        PenUp
        Displacement(-45y,-23y)
        PenDown
        Displacement(40y,0y)
        PenUp
        Displacement(-45y,-25y)
        PenDown
        Displacement(46y,0y)
        PenUp
        Displacement(-22y,25y)
        PenDown
        Displacement(-6y,-69y)
        Displacement(31y,18y)
        PenUp
        Displacement(18y,84y)
        PenDown
        Displacement(-5y,-20y)
        Displacement(-11y,-20y)
        PenUp
        Displacement(11y,18y)
        PenDown
        Displacement(56y,0y)
        PenUp
        Displacement(-69y,-31y)
        PenDown
        Displacement(71y,0y)
        PenUp
        Displacement(-36y,66y)
        PenDown
        Displacement(0y,-61y)
        Displacement(-5y,-23y)
        Displacement(-10y,-18y)
        Displacement(-13y,-13y)
        Displacement(-14y,-8y)
        PenUp
        Displacement(42y,54y)
        PenDown
        Displacement(6y,-20y)
        Displacement(13y,-18y)
        Displacement(18y,-15y)
    ]
    // 帖
    52475us, [
        PenUp
        Displacement(6y,32y)
        PenDown
        yield! Radical.巾 40y [66y;28y;125y]

        PenUp
        Displacement(98y,97y)
        PenDown
        Displacement(-40y,0y)
        PenUp
        Displacement(-1y,31y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-21y,0y)
        PenDown
        yield! Radical.口(50y,46y)

    ]
    // 厅
    52476us, [
        PenUp
        Displacement(3y,14y)
        PenDown
        Displacement(9y,20y)
        Displacement(6y,25y)
        Displacement(3y,25y)
        Displacement(0y,31y)
        Displacement(102y,0y)
        PenUp
        Displacement(-89y,-33y)
        PenDown
        yield! Radical.丁 [93y;41y] 74y
    ]
    // 听
    52477us, [
        PenUp
        Displacement(5y,47y)
        PenDown
        yield! Radical.口(33y,-66y)
        PenUp
        Displacement(107y,76y)
        PenDown
        Displacement(-24y,-5y)
        Displacement(-25y-1y,-3y)
        Displacement(0y,-25y-38y)
        Displacement(-3y,-13y)
        Displacement(-9y,-15y)
        Displacement(-10y,-13y)
        Displacement(-11y,-8y)
        PenUp
        Displacement(37y,74y)
        PenDown
        Displacement(57y,0y)
        PenUp
        Displacement(-25y,0y)
        PenDown
        Displacement(0y,-76y)
    ]
    // 烃
    52478us, [
        PenUp
        Displacement(15y,96y)
        PenDown
        Displacement(-9y,-33y)
        PenUp
        Displacement(23y,64y)
        PenDown
        Displacement(0y,-56y)
        Displacement(-4y,-23y)
        Displacement(-8y,-20y)
        Displacement(-15y,-18y)
        PenUp
        Displacement(51y,89y)
        PenDown
        Displacement(-22y,-20y)
        PenUp
        Displacement(-4y,-33y)
        PenDown
        Displacement(27y,-20y)
        PenUp
        Displacement(-1y,92y)
        PenDown
        Displacement(51y,0y)
        Displacement(-14y,-18y)
        Displacement(-23y,-20y)
        Displacement(-25y,-15y)
        PenUp
        Displacement(41y,23y)
        PenDown
        Displacement(38y,-23y)
        PenUp
        Displacement(-69y,-13y)
        PenDown
        yield! Radical.多横中竖工 [64y;84y] 38y

    ]
    // 汀
    52641us, [
        PenUp
        Displacement(18y,121y)
        PenDown
        Displacement(22y,-18y)
        PenUp
        Displacement(-33y,-15y)
        PenDown
        Displacement(22y,-15y)
        PenUp
        Displacement(-17y,-61y)
        PenDown
        Displacement(22y,43y)
        PenUp
        Displacement(14y,51y)
        PenDown
        yield! Radical.丁 [74y;29y] 95y
    ]
    // 廷
    52642us, [
        PenUp
        Displacement(111y,119y)
        PenDown
        Displacement(-55y,-10y)
        PenUp
        Displacement(-3y,-31y)
        PenDown
        yield! Radical.多横中竖士 [64y;60y] [36y;69y]

        PenUp
        Displacement(-74y,69y)
        PenDown
        Displacement(41y,0y)
        Displacement(-36y,-41y)
        Displacement(34y,0y)
        Displacement(-15y,-41y)
        Displacement(-28y,-20y)
        PenUp
        Displacement(11y,48y)
        PenDown
        Displacement(15y,-28y)
        Displacement(18y,-15y)
        Displacement(75y,0y)
    ]
    // 停
    52643us, [
        PenUp
        Displacement(34y,124y)
        PenDown
        Displacement(-10y,-20y)
        Displacement(-15y,-23y)
        Displacement(-6y,-8y)
        PenUp
        Displacement(20y,31y)
        PenDown
        Displacement(0y,-99y)
        PenUp
        Displacement(45y,122y)
        PenDown
        Displacement(17y,-15y)
        PenUp
        Displacement(-46y,-3y)
        PenDown
        Displacement(83y,0y)
        PenUp
        Displacement(-68y,-15y)
        PenDown
        yield! Radical.口(47y,20y)
        PenUp
        Displacement(-14y,-51y)
        PenDown
        yield! Radical.冖(80y,18y)
        PenUp
        Displacement(-70y,0y)
        PenDown
        yield! Radical.丁 [60y;25y] 36y

    ]
    // 亭
    52644us, [
        PenUp
        Displacement(55y,124y)
        PenDown
        Displacement(17y,-10y)
        PenUp
        Displacement(-62y,-3y)
        PenDown
        Displacement(106y,0y)
        PenUp
        Displacement(-85y,-36y)
        PenDown
        yield! Radical.口(64y,-18y)
        PenUp
        Displacement(-20y,-31y)
        PenDown
        yield! Radical.冖(104y,18y)
        PenUp
        Displacement(-92y,-5y)
        PenDown
        yield! Radical.丁 [82y;38y] 36y
    ]
    // 庭
    52645us, [
        PenUp
        Displacement(60y,124y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(-69y,-104y)
        PenDown
        Displacement(6y,10y)
        Displacement(3y,10y)
        Displacement(4y,15y)
        Displacement(0y,18y+45y)
        Displacement(101y,0y)
        PenUp
        Displacement(-88y,-23y)
        PenDown
        Displacement(25y,0y)
        Displacement(-6y,-10y)
        Displacement(-15y,-18y)
        Displacement(24y,0y)
        Displacement(-6y,-15y)
        Displacement(-4y,-13y)
        Displacement(-8y,-10y)
        Displacement(-9y,-8y)
        Displacement(-9y,-5y)
        PenUp
        Displacement(9y,38y)
        PenDown
        Displacement(9y,-15y)
        Displacement(5y,-8y)
        Displacement(10y,-8y)
        Displacement(6y,-3y)
        Displacement(28y,-3y)
        Displacement(29y,0y)
        PenUp
        Displacement(-11y,82y)
        PenDown
        Displacement(-19y,-5y)
        Displacement(-20y,-3y)
        PenUp
        Displacement(-4y,-23y)
        PenDown
        yield! Radical.多横中竖士 [52y;46y] [28y;54y]

    ]
    // 挺
    52646us, [
        PenUp
        Displacement(5y,93y)
        PenDown
        Displacement(40y,0y)
        PenUp
        Displacement(-19y,33y)
        PenDown
        Displacement(0y,-107y)
        Displacement(-6y,-10y)
        Displacement(-11y,0y)
        PenUp
        Displacement(-3y,41y)
        PenDown
        Displacement(37y,23y)
        PenUp
        Displacement(-1y,31y)
        PenDown
        Displacement(24y,0y)
        Displacement(-14y,-38y)
        Displacement(17y,3y)
        Displacement(-5y,-36y)
        Displacement(-15y,-15y)
        Displacement(-13y,-10y)
        PenUp
        Displacement(10y,48y)
        PenDown
        Displacement(11y,-23y)
        Displacement(9y,-13y)
        Displacement(17y,-5y)
        Displacement(42y,0y)
        PenUp
        Displacement(-9y,104y)
        PenDown
        Displacement(-43y,-10y)
        PenUp
        Displacement(-3y,-31y)
        PenDown
        yield! Radical.多横中竖士 [52y;46y] [38y;71y]

    ]
    // 艇
    52647us, [
        PenUp
        Displacement(31y,121y)
        PenDown
        Displacement(-6y,-15y)
        PenUp
        Displacement(-19y,-102y)
        PenDown
        Displacement(6y,13y)
        Displacement(4y,8y)
        Displacement(1y,18y)
        Displacement(0y,64y)
        Displacement(28y,0y)
        Displacement(0y,-92y)
        Displacement(-5y,-5y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-3y,82y)
        PenDown
        Displacement(9y,-15y)
        PenUp
        Displacement(-31y,-10y)
        PenDown
        Displacement(47y,0y)
        PenUp
        Displacement(-24y,-8y)
        PenDown
        Displacement(9y,-15y)
        PenUp
        Displacement(82y,71y)
        PenDown
        Displacement(-20y,-3y)
        Displacement(-15y,0y)
        PenUp
        Displacement(-3y,-36y)
        PenDown
        yield! Radical.多横中竖士 [42y;36y] [38y;72y]

        PenUp
        Displacement(-46y,66y)
        PenDown
        Displacement(24y,-3y)
        Displacement(-17y,-38y)
        Displacement(17y,0y)
        Displacement(-6y,-36y)
        Displacement(-8y,-13y)
        Displacement(-10y,-10y)
        PenUp
        Displacement(5y,46y)
        PenDown
        Displacement(13y,-23y)
        Displacement(6y,-10y)
        Displacement(11y,-5y)
        Displacement(36y,0y)
    ]
    // 通
    52648us, [
        PenUp
        Displacement(6y,119y)
        PenDown
        Displacement(22y,-18y)
        PenUp
        Displacement(-27y,-25y)
        PenDown
        Displacement(22y,0y)
        Displacement(0y,-46y)
        Displacement(-8y,-3y)
        Displacement(-8y,-5y)
        Displacement(-4y,-5y)
        PenUp
        Displacement(19y,13y)
        PenDown
        Displacement(11y,-5y)
        Displacement(9y,-5y)
        Displacement(10y,-3y)
        Displacement(14y,-3y)
        Displacement(18y,0y)
        Displacement(18y,0y)
        Displacement(18y,0y)
        PenUp
        Displacement(-82y,104y)
        PenDown
        Displacement(62y,0y)
        Displacement(-27y,-20y)
        PenUp
        Displacement(-17y,10y)
        PenDown
        Displacement(24y,-15y)
        PenUp
        Displacement(-40y,-64y)
        PenDown
        yield! Radical.用部(65y,59y)

    ]
    // 桐
    52649us, [
        PenUp
        Displacement(1y,93y)
        PenDown
        yield! Radical.十 48y [33y;122y]

        PenUp
        Displacement(-3y,84y)
        PenDown
        Displacement(-22y,-43y)
        PenUp
        Displacement(24y,36y)
        PenDown
        Displacement(18y,-20y)
        PenUp
        Displacement(10y,-54y)
        PenDown
        yield! Radical.同 (62y,110y) (27y,32y)

    ]
    // 酮
    52650us, [
        PenUp
        Displacement(6y,108y)
        PenDown
        yield! Radical.酉(54y,88y)(40y,69y)
        PenUp
        Displacement(14y,-13y)
        PenDown
        yield! Radical.同 (48y,104y) (20y,25y)

    ]
    // 瞳
    52651us, [
        PenUp
        Displacement(9y,108y)
        PenDown
        yield! Radical.目(28y,82y)
        PenUp
        Displacement(61y,68y)
        PenDown

        Displacement(18y,-13y)
        PenUp
        Displacement(-42y,-5y)
        PenDown
        Displacement(69y,0y)
        PenUp
        Displacement(-54y,-3y)
        PenDown
        Displacement(9y,-15y)
        PenUp
        Displacement(27y,15y)
        PenDown
        Displacement(-9y,-15y)
        PenUp
        Displacement(-45y,-3y)
        PenDown
        Displacement(78y,0y)

        PenUp
        Displacement(-66y,-13y)
        PenDown
        yield! Radical.里 [52y;70y;86y] [34y;62y]


    ]
    // 同
    52652us, [
        PenUp
        Displacement(17y,9y)
        PenDown
        yield! Radical.同(94y,104y)(40y,30y)

    ]
    // 铜
    52653us, [
        PenUp
        Displacement(31y,124y)
        PenDown
        Displacement(-11y,-20y)
        Displacement(-17y,-20y)
        PenUp
        Displacement(18y,18y)
        PenDown
        Displacement(29y,0y)
        PenUp
        Displacement(-38y,-20y)
        PenDown
        Displacement(34y,0y)
        PenUp
        Displacement(-42y,-28y)
        PenDown
        Displacement(45y,0y)
        PenUp
        Displacement(-24y,25y)
        PenDown
        Displacement(0y,-71y)
        Displacement(24y,20y)
        PenUp
        Displacement(8y,-23y)
        PenDown
        yield! Radical.同(60y,110y)(26y,28y)

    ]
    // 彤
    52654us, [
        PenUp
        Displacement(1y,65y)
        PenDown
        Displacement(71y,0y)
        PenUp
        Displacement(-66y,-59y)
        PenDown
        Displacement(10y,13y)
        Displacement(3y,8y)
        Displacement(0y,89y)
        Displacement(42y,0y)
        Displacement(0y,-92y)
        Displacement(-5y,-5y)
        Displacement(-14y,-3y)
        PenUp
        Displacement(-9y,84y)
        PenDown
        Displacement(14y,-23y)
        PenUp
        Displacement(66y,46y)
        PenDown
        Displacement(-18y,-20y)
        Displacement(-23y,-15y)
        PenUp
        Displacement(45y,-3y)
        PenDown
        Displacement(-42y,-36y)
        PenUp
        Displacement(48y,5y)
        PenDown
        Displacement(-28y,-28y)
        Displacement(-33y,-23y)
    ]
    // 童
    52655us, [
        PenUp
        Displacement(51y,124y)
        PenDown
        Displacement(19y,-13y)
        PenUp
        Displacement(-55y,-5y)
        PenDown
        Displacement(93y,0y)
        PenUp
        Displacement(-76y,-5y)
        PenDown
        Displacement(17y,-13y)
        PenUp
        Displacement(40y,15y)
        PenDown
        Displacement(-15y,-18y)
        PenUp
        Displacement(-69y,0y)
        PenDown
        Displacement(117y,0y)
        PenUp
        Displacement(-96y,-15y)
        PenDown
        yield! Radical.里 [75y;85y;115y] [31y;61y]


    ]
    // 桶
    52656us, [
        PenUp
        Displacement(6y,90y)
        PenDown
        yield! Radical.十 45y [33y;122y]

        PenUp
        Displacement(1y,84y)
        PenDown
        Displacement(-25y,-43y)
        PenUp
        Displacement(27y,36y)
        PenDown
        Displacement(18y,-20y)
        PenUp
        Displacement(5y,59y)
        PenDown
        Displacement(57y,0y)
        Displacement(-24y,-23y)
        PenUp
        Displacement(-18y,8y)
        PenDown
        Displacement(23y,-15y)
        PenUp
        Displacement(-36y,-84y)
        PenDown
        yield! Radical.用部(61y,79y)

    ]
    // 捅
    52657us, [
        PenUp
        Displacement(1y,93y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-19y,33y)
        PenDown
        Displacement(0y,-110y)
        Displacement(-3y,-8y)
        Displacement(-9y,-5y)
        Displacement(-5y,0y)
        PenUp
        Displacement(-8y,43y)
        PenDown
        Displacement(42y,25y)
        PenUp
        Displacement(4y,46y)
        PenDown
        Displacement(59y,0y)
        Displacement(-23y,-23y)
        PenUp
        Displacement(-18y,5y)
        PenDown
        Displacement(27y,-13y)
        PenUp
        Displacement(-40y,-87y)
        PenDown
        yield! Radical.用部(60y,82y)

    ]
    // 筒
    52658us, [
        PenUp
        Displacement(34y,126y)
        PenDown
        Displacement(-14y,-20y)
        Displacement(-18y,-15y)
        PenUp
        Displacement(20y,15y)
        PenDown
        Displacement(40y,0y)
        PenUp
        Displacement(-25y,0y)
        PenDown
        Displacement(11y,-18y)
        PenUp
        Displacement(36y,38y)
        PenDown
        Displacement(-8y,-18y)
        Displacement(-15y,-18y)
        PenUp
        Displacement(15y,15y)
        PenDown
        Displacement(46y,0y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        Displacement(9y,-18y)
        PenUp
        Displacement(-83y,-87y)
        PenDown
        yield! Radical.同(90y,79y)(40y,20y)

    ]
    // 统
    52659us, [
        PenUp
        Displacement(31y,121y)
        PenDown
        Displacement(-25y,-41y)
        Displacement(28y,0y)
        PenUp
        Displacement(9y,18y)
        PenDown
        Displacement(-13y,-28y)
        Displacement(-17y,-18y)
        Displacement(-6y,-5y)
        Displacement(40y,0y)
        PenUp
        Displacement(-45y,-31y)
        PenDown
        Displacement(45y,10y)
        PenUp
        Displacement(31y,94y)
        PenDown
        Displacement(17y,-18y)
        PenUp
        Displacement(-40y,-10y)
        PenDown
        Displacement(71y,0y)
        PenUp
        Displacement(-43y,0y)
        PenDown
        Displacement(-10y,-18y)
        Displacement(-18y,-18y)
        Displacement(54y,0y)
        PenUp
        Displacement(-11y,20y)
        PenDown
        Displacement(22y,-28y)
        PenUp
        Displacement(-46y,5y)
        PenDown
        Displacement(-3y,-18y)
        Displacement(-5y,-13y)
        Displacement(-5y,-8y)
        Displacement(-8y,-8y)
        Displacement(-13y,-8y)
        PenUp
        Displacement(52y,54y)
        PenDown
        Displacement(0y,-43y-5y)
        Displacement(8y,-3y)
        Displacement(13y,3y)
        Displacement(8y,5y)
        Displacement(1y,5y)
    ]
    // 痛
    52660us, [
        PenUp
        Displacement(61y,124y)
        PenDown
        Displacement(18y,-10y)
        PenUp
        Displacement(45y,-5y)
        PenDown
        Displacement(-96y,0y)
        Displacement(0y,-41y)
        Displacement(0y,-20y)
        Displacement(-10y,-20y)
        Displacement(-11y,-15y)
        PenUp
        Displacement(0y,84y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(-15y,-28y)
        PenDown
        Displacement(22y,13y)
        PenUp
        Displacement(13y,28y)
        PenDown
        Displacement(68y,0y)
        Displacement(-29y,-15y)
        PenUp
        Displacement(-19y,8y)
        PenDown
        Displacement(28y,-13y)
        PenUp
        Displacement(-45y,-66y)
        PenDown
        yield! Radical.用部(69y,61y)

    ]
    // 偷
    52661us, [
        PenUp
        Displacement(34y,124y)
        PenDown
        Displacement(-6y,-15y)
        Displacement(-9y,-15y)
        Displacement(-9y,-10y)
        Displacement(-10y,-13y)
        PenUp
        Displacement(19y,25y)
        PenDown
        Displacement(0y,-94y)
        PenUp
        Displacement(57y,125y)
        PenDown
        Displacement(-5y,-10y)
        Displacement(-10y,-15y)
        Displacement(-13y,-13y)
        Displacement(-17y,-8y)
        PenUp
        Displacement(41y,38y)
        PenDown
        Displacement(15y,-15y)
        Displacement(33y,-24y)
        PenUp
        Displacement(-68y,3y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-57y,-79y)
        PenDown
        yield! Radical.青月(29y,61y)

        PenUp
        Displacement(19y,31y)
        PenDown
        Displacement(0y,-43y)
        PenUp
        Displacement(19y,51y)
        PenDown
        Displacement(0y,-61y)
        Displacement(-3y,-5y)
        Displacement(-13y,-3y)
    ]
    // 投
    52662us, [
        PenUp
        Displacement(8y,93y)
        PenDown
        Displacement(47y,0y)
        PenUp
        Displacement(-24y,28y)
        PenDown
        Displacement(0y,-102y-8y)
        Displacement(-5y,-5y)
        Displacement(-4y,-3y)
        Displacement(-5y,0y)
        PenUp
        Displacement(-9y,41y)
        PenDown
        Displacement(37y,18y)
        PenUp
        Displacement(6y,10y)
        PenDown
        Displacement(10y,8y)
        Displacement(6y,8y)
        Displacement(0y,28y)
        Displacement(33y,0y)
        Displacement(0y,-33y)
        Displacement(4y,-5y)
        Displacement(6y,-3y)
        Displacement(11y,0y)
        PenUp
        Displacement(-69y,-13y)
        PenDown
        Displacement(54y,0y)
        Displacement(-4y,-13y)
        Displacement(-5y,-8y)
        Displacement(-6y-6y,-8y-8y)
        Displacement(-10y,-8y)
        Displacement(-9y,-5y)
        Displacement(-8y,-3y)
        Displacement(-11y,-5y)
        PenUp
        Displacement(17y,54y)
        PenDown
        Displacement(10y,-18y)
        Displacement(8y,-10y)
        Displacement(8y,-8y)
        Displacement(9y,-5y)
        Displacement(11y,-5y)
        Displacement(15y,-5y)
    ]
    // 头
    52663us, [
        PenUp
        Displacement(33y,119y)
        PenDown
        Displacement(25y,-18y)
        PenUp
        Displacement(-36y,-13y)
        PenDown
        Displacement(27y,-15y)
        PenUp
        Displacement(-46y,-20y)
        PenDown
        Displacement(121y,0y)
        PenUp
        Displacement(-47y,71y)
        PenDown
        Displacement(0y,-31y)
        Displacement(-3y,-20y)
        Displacement(-4y,-18y)
        Displacement(-5y,-13y)
        Displacement(-9y,-10y)
        Displacement(-13y,-10y)
        Displacement(-17y,-8y)
        Displacement(-17y,-5y)
        PenUp
        Displacement(69y,28y)
        PenDown
        Displacement(11y,-8y)
        Displacement(14y,-10y)
        Displacement(14y,-13y)
    ]
    // 透
    52664us, [
        PenUp
        Displacement(15y,116y)
        PenDown
        Displacement(18y,-18y)
        PenUp
        Displacement(-27y,-23y)
        PenDown
        Displacement(22y,0y)
        Displacement(0y,-48y)
        Displacement(-22y,-10y)
        PenUp
        Displacement(22y,10y)
        PenDown
        Displacement(17y,-10y)
        Displacement(18y,-8y)
        Displacement(61y,0y)
        PenUp
        Displacement(-73y,104y)
        PenDown
        Displacement(31y,0y)
        Displacement(28y,5y)
        PenUp
        Displacement(-66y,-23y)
        PenDown
        yield! Radical.十 78y [18y;43y]

        PenUp
        Displacement(-3y,23y)
        PenDown
        Displacement(-18y,-15y)
        Displacement(-19y,-10y)
        PenUp
        Displacement(45y,25y)
        PenDown
        Displacement(14y,-10y)
        Displacement(23y,-13y)
        PenUp
        Displacement(-66y,-5y)
        PenDown
        Displacement(41y,0y)
        Displacement(-6y,-18y)
        Displacement(22y,0y)
        Displacement(-5y,-15y)
        Displacement(-5y,-5y)
        Displacement(-14y,-3y)
        PenUp
        Displacement(-15y,41y)
        PenDown
        Displacement(-8y,-20y)
        Displacement(-19y,-18y)
    ]
    // 凸
    52665us, [
        PenUp
        Displacement(13y,14y)
        PenDown
        Displacement(0y,58y)
        Displacement(28y,0y)
        Displacement(0y,43y)
        Displacement(46y,0y)
        Displacement(0y,-43y)
        Displacement(28y,0y)
        Displacement(0y,-58y)
        Displacement(-102y,0y)
    ]
    // 秃
    52666us, [
        PenUp
        Displacement(106y,119y)
        PenDown
        Displacement(-48y,-5y)
        Displacement(-32y,0y)
        PenUp
        Displacement(-19y,-20y)
        PenDown
        yield! Radical.十 115y [18y;51y]

        PenUp
        Displacement(-4y,31y)
        PenDown
        Displacement(-22y,-15y)
        Displacement(-31y,-18y)
        PenUp
        Displacement(60y,33y)
        PenDown
        Displacement(24y,-18y)
        Displacement(27y,-15y)
        PenUp
        Displacement(-111y,-54y)
        PenDown
        Displacement(15y,5y)
        Displacement(13y,10y)
        Displacement(5y,13y)
        Displacement(3y,20y)
        Displacement(41y,0y)
        Displacement(0y,-41y)
        Displacement(5y,-5y)
        Displacement(22y,0y)
        Displacement(5y,3y)
        Displacement(4y,13y)
    ]
    // 突
    52667us, [
        PenUp
        Displacement(54y,124y)
        PenDown
        Displacement(19y,-13y)
        PenUp
        Displacement(-60y,-25y)
        PenDown
        Displacement(0y,20y)
        Displacement(97y,0y)
        Displacement(3y,-23y)
        PenUp
        Displacement(-61y,15y)
        PenDown
        Displacement(-38y,-31y)
        PenUp
        Displacement(59y,28y)
        PenDown
        Displacement(38y,-28y)
        PenUp
        Displacement(-37y,8y)
        PenDown
        Displacement(18y,-15y)
        PenUp
        Displacement(-84y,-10y)
        PenDown
        Displacement(108y,0y)
        PenUp
        Displacement(-54y,33y)
        PenDown
        Displacement(-5y,-33y)
        Displacement(-6y,-18y)
        Displacement(-14y,-13y)
        Displacement(-14y,-8y)
        Displacement(-17y,-5y)
        PenUp
        Displacement(59y,43y)
        PenDown
        Displacement(6y,-10y)
        Displacement(14y,-13y)
        Displacement(11y,-10y)
        Displacement(11y,-8y)
        Displacement(11y,-3y)
    ]
    // 图
    52668us, [
        PenUp
        Displacement(13y,116y)
        PenDown
        yield! Radical.口(99y,98y)
        PenUp
        Displacement(45y,-3y)
        PenDown

        Displacement(-13y,-18y)
        Displacement(-17y,-13y)
        PenUp
        Displacement(19y,15y)
        PenDown
        Displacement(36y,0y)
        Displacement(-17y,-18y)
        Displacement(-22y,-13y)
        Displacement(-20y,-10y)
        PenUp
        Displacement(22y,31y)
        PenDown
        Displacement(55y,-31y)
        PenUp
        Displacement(-47y,3y)
        PenDown
        Displacement(24y,-10y)
        PenUp
        Displacement(-36y,-5y)
        PenDown
        Displacement(38y,-18y)
    ]
    // 徒
    52669us, [
        PenUp
        Displacement(38y,126y)
        PenDown
        Displacement(-11y,-18y)
        Displacement(-17y,-18y)
        PenUp
        Displacement(31y,3y)
        PenDown
        Displacement(-13y,-18y)
        Displacement(-23y,-23y)
        PenUp
        Displacement(22y,23y)
        PenDown
        Displacement(0y,-74y)
        PenUp
        Displacement(20y,102y)
        PenDown
        yield! Radical.中心对齐等距横 [71y;88y] 28y

        PenUp
        Displacement(-42y,-25y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-34y,76y)
        PenDown
        Displacement(0y,-112y)
        PenUp
        Displacement(-24y,48y)
        PenDown
        Displacement(-5y,-18y)
        Displacement(-8y,-25y)
        Displacement(-11y,-10y)
        PenUp
        Displacement(20y,33y)
        PenDown
        Displacement(10y,-13y)
        Displacement(11y,-13y)
        Displacement(14y,-5y)
        Displacement(37y,0y)
    ]
    // 途
    52670us, [
        PenUp
        Displacement(76y+8y,124y)
        PenDown
        Displacement(-9y,-20y)
        Displacement(-13y,-15y)
        Displacement(-22y,-13y)
        PenUp
        Displacement(41y,36y)
        PenDown
        Displacement(11y,-13y)
        Displacement(13y,-8y)
        Displacement(20y,-8y)
        PenUp
        Displacement(-69y,0y)
        PenDown
        yield! Radical.多横中竖干 [52y;70y] [25y;56y]            

        Displacement(-14y,-5y)
        PenUp
        Displacement(-3y,28y)
        PenDown
        Displacement(-20y,-20y)
        PenUp
        Displacement(51y,20y)
        PenDown
        Displacement(27y,-18y)
        PenUp
        Displacement(-111y,76y)
        PenDown
        Displacement(20y,-15y)
        PenUp
        Displacement(-27y,-23y)
        PenDown
        Displacement(24y,0y)
        Displacement(0y,-48y)
        PenUp
        Displacement(-18y,-15y)
        PenDown
        Displacement(18y,15y)
        Displacement(8y,-3y)
        Displacement(9y,-8y)
        Displacement(10y,-5y)
        Displacement(70y,0y)
    ]
    // 涂
    52671us, [
        PenUp
        Displacement(15y,119y)
        PenDown
        Displacement(24y,-18y)
        PenUp
        Displacement(-36y,-15y)
        PenDown
        Displacement(27y,-18y)
        PenUp
        Displacement(1y,-15y)
        PenDown
        Displacement(-25y,-41y)
        PenUp
        Displacement(70y,112y)
        PenDown
        Displacement(-13y,-20y)
        Displacement(-14y,-15y)
        Displacement(-17y,-10y)
        PenUp
        Displacement(42y,38y)
        PenDown
        Displacement(9y,-10y)
        Displacement(15y,-13y)
        Displacement(24y,-13y)
        PenUp
        Displacement(-74y,-3y)
        PenDown
        yield! Radical.多横中竖干 [56y;78y] [23y;66y]            

        Displacement(-4y,-5y)
        Displacement(-14y,0y)
        PenUp
        Displacement(-1y,38y)
        PenDown
        Displacement(-24y,-31y)
        PenUp
        Displacement(62y,28y)
        PenDown
        Displacement(24y,-23y)
    ]
    // 屠
    52672us, [
        PenUp
        Displacement(0y,11y)
        PenDown
        Displacement(9y,18y)
        Displacement(8y,25y)
        Displacement(0y,67y)
        yield! Radical.匚(-90y,23y)
        PenUp
        Displacement(48y,-5y)
        PenDown
        Displacement(0y,-28y)
        PenUp
        Displacement(-34y,15y)
        PenDown
        yield! Radical.中心对齐等距横 [64y;86y] 15y

        PenUp
        Displacement(-2y,25y)
        PenDown
        Displacement(-17y,-18y)
        Displacement(-18y,-13y)
        Displacement(-55y,-23y)

        PenUp
        Displacement(23y,8y)
        PenDown
        yield! Radical.日(62y,36y)

    ]
    // 土
    52673us, [
        PenUp
        Displacement(18y,75y)
        PenDown
        yield! Radical.多横中竖士 [93y;117y] [58y;102y]

    ]
    // 吐
    52674us, [
        PenUp
        Displacement(6y,35y)
        PenDown
        yield! Radical.口(31y,-64y)
        PenUp
        Displacement(45y,41y)
        PenDown
        yield! Radical.多横中竖士 [65y;82y] [66y;112y]

    ]
    // 兔
    52675us, [
        PenUp
        Displacement(50y,124y)
        PenDown
        Displacement(-13y,-13y)
        Displacement(-14y,-13y)
        Displacement(-11y,-8y)
        PenUp
        Displacement(27y,18y)
        PenDown
        Displacement(51y,0y)
        Displacement(-22y,-23y)
        PenUp
        Displacement(-42y,-31y)
        PenDown
        yield! Radical.口(83y,-31y)

        PenUp
        Displacement(42y,31y)
        PenDown
        Displacement(-6y,-23y)
        Displacement(-6y,-15y)
        Displacement(-9y,-10y)
        Displacement(-13y,-10y)
        Displacement(-13y,-8y)
        Displacement(-13y,-5y)
        PenUp
        Displacement(60y,36y)
        PenDown
        Displacement(0y,-33y)
        Displacement(4y,-8y)
        Displacement(43y,0y)
        Displacement(4y,8y)
        Displacement(4y,10y)
        PenUp
        Displacement(-33y,20y)
        PenDown
        Displacement(13y,-18y)
    ]
    // 湍
    52676us, [
        PenUp
        Displacement(18y,116y)
        PenDown
        Displacement(22y,-15y)
        PenUp
        Displacement(-34y,-18y)
        PenDown
        Displacement(20y,-15y)
        PenUp
        Displacement(-15y,-61y)
        PenDown
        Displacement(15y,43y)
        PenUp
        Displacement(23y,64y)
        PenDown
        yield! Radical.山 64y [23y;38y]
        PenUp
        Displacement(-41y,-23y)
        PenDown
        yield! Radical.而(85y,23y) (68y,43y)

    ]
    // 团
    52677us, [

        PenUp
        Displacement(18y,116y)
        PenDown
        yield! Radical.口(96y,97y)
        PenUp
        Displacement(12y,-28y)
        PenDown

        Displacement(75y,0y)
        PenUp
        Displacement(-31y,23y)
        PenDown
        Displacement(0y,-69y)
        Displacement(-3y,-8y)
        Displacement(-20y,-3y)
        PenUp
        Displacement(19y,54y)
        PenDown
        Displacement(-13y,-20y)
        Displacement(-14y,-10y)
        Displacement(-17y,-13y)
    ]
    // 推
    52678us, [
        PenUp
        Displacement(1y,96y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(0y,-31y)
        PenDown
        Displacement(-48y,-15y)
        PenUp
        Displacement(25y,76y)
        PenDown
        Displacement(0y,-110y)
        Displacement(-5y,-10y)
        Displacement(-13y,-3y)
        PenUp
        Displacement(62y,122y)
        PenDown
        Displacement(-9y,-23y)
        Displacement(-19y,-28y)
        PenUp
        Displacement(15y,20y)
        PenDown
        Displacement(0y,-94y)
        PenUp
        Displacement(24y,122y)
        PenDown
        Displacement(19y,-20y)
        PenUp
        Displacement(-41y,-8y)
        PenDown
        yield! Radical.多横中竖工 [61y;57y;59y;62y] 27y

    ]
    // 颓
    52679us, [
        PenUp
        Displacement(52y,121y)
        PenDown
        Displacement(-18y,-5y)
        Displacement(-22y,-3y)
        PenUp
        Displacement(-6y,-18y)
        PenDown
        yield! Radical.十 56y [20y;51y]

        PenUp
        Displacement(-3y,28y)
        PenDown
        Displacement(-9y,-15y)
        Displacement(-11y,-8y)
        Displacement(-6y,-5y)
        PenUp
        Displacement(32y,23y)
        PenDown
        Displacement(23y,-15y)
        PenUp
        Displacement(-55y,-61y)
        PenDown
        Displacement(6y,5y)
        Displacement(5y,8y)
        Displacement(5y,10y)
        Displacement(0y,25y)
        Displacement(22y,0y)
        Displacement(0y,-41y)
        Displacement(17y,18y)
        PenUp
        Displacement(3y,84y)
        PenDown
        Displacement(61y,0y)
        PenUp
        Displacement(-32y,-5y)
        PenDown
        Displacement(-6y,-23y)
        PenUp
        Displacement(-15y,-59y)
        PenDown
        Displacement(0y,56y)
        Displacement(41y,0y)
        Displacement(0y,-56y)
        PenUp
        Displacement(-20y,41y)
        PenDown
        Displacement(0y,-23y)
        Displacement(-3y,-15y)
        Displacement(-8y,-10y)
        Displacement(-11y,-10y)
        Displacement(-13y,-5y)
        PenUp
        Displacement(42y,20y)
        PenDown
        Displacement(24y,-20y)
    ]
    // 腿
    52680us, [
        PenUp
        Displacement(6y,6y)
        PenDown
        Displacement(8y,15y)
        Displacement(3y,15y)
        Displacement(0y,79y)
        Displacement(23y,0y)
        Displacement(0y,-97y)
        Displacement(-5y,-5y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-3y,74y)
        PenDown
        Displacement(15y,0y)
        PenUp
        Displacement(-18y,-31y)
        PenDown
        Displacement(19y,0y)
        PenUp
        Displacement(11y,61y)
        PenDown
        Displacement(14y,-20y)
        PenUp
        Displacement(-20y,-23y)
        PenDown
        Displacement(18y,0y)
        Displacement(0y,-51y)
        Displacement(-17y,-8y)
        PenUp
        Displacement(17y,8y)
        PenDown
        Displacement(20y,-10y)
        Displacement(45y,0y)
        PenUp
        Displacement(-27y,31y)
        PenDown
        Displacement(-20y,-13y)
        Displacement(0y,87y)
        yield! Radical.彐(32y,44y)
        PenUp
        Displacement(41y,-29y)
        PenDown
        Displacement(-15y,-15y)
        PenUp
        Displacement(-14y,10y)
        PenDown
        Displacement(31y,-33y)
    ]
    // 蜕
    52681us, [
        PenUp
        Displacement(8y,58y+38y)
        PenDown
        yield! Radical.中 36y [38y;28y;97y]

        PenUp
        Displacement(-23y,-10y)
        PenDown
        Displacement(45y,13y)
        PenUp
        Displacement(-9y,15y)
        PenDown
        Displacement(15y,-23y)
        PenUp
        Displacement(4y,102y)
        PenDown
        Displacement(18y,-23y)
        PenUp
        Displacement(32y,25y)
        PenDown
        Displacement(-17y,-33y)
        PenUp
        Displacement(-31y,-36y)
        PenDown
        yield! Radical.口(47y,-36y)
        PenUp
        Displacement(15y,0y)
        PenDown
        Displacement(-3y,-20y)
        Displacement(-3y,-10y)
        Displacement(-8y,-8y)
        Displacement(-9y,-8y)
        Displacement(-11y,-8y)
        PenUp
        Displacement(50y,51y)
        PenDown
        Displacement(0y,-33y)
        Displacement(1y,-8y)
        Displacement(8y,-5y)
        Displacement(11y,0y)
        Displacement(6y,3y)
        Displacement(4y,10y)
    ]
    // 褪
    52682us, [
        PenUp
        Displacement(19y,124y)
        PenDown
        Displacement(15y,-20y)
        PenUp
        Displacement(-28y,-8y)
        PenDown
        Displacement(34y,0y)
        Displacement(-38y,-51y)
        PenUp
        Displacement(23y,25y)
        PenDown
        Displacement(0y,-66y)
        PenUp
        Displacement(20y,69y)
        PenDown
        Displacement(-13y,-15y)
        PenUp
        Displacement(-5y,3y)
        PenDown
        Displacement(18y,-18y)
        PenUp
        Displacement(3y,76y)
        PenDown
        Displacement(14y,-25y)
        PenUp
        Displacement(-22y,-13y)
        PenDown
        Displacement(22y,0y)
        Displacement(0y,-59y)
        Displacement(-19y,-8y)
        PenUp
        Displacement(19y,8y)
        PenDown
        Displacement(8y,-8y)
        Displacement(11y,-5y)
        Displacement(41y,0y)

        PenUp
        Displacement(-27y,33y)
        PenDown

        Displacement(-19y,-13y)
        Displacement(0y,87y)
        yield! Radical.彐(34y,43y)
        PenUp
        Displacement(42y,-29y)
        PenDown
        Displacement(-15y,-15y)
        PenUp
        Displacement(-17y,13y)
        PenDown
        Displacement(33y,-33y)
    ]
    // 退
    52683us, [
        PenUp
        Displacement(13y,116y)
        PenDown
        Displacement(19y,-23y)
        PenUp
        Displacement(-28y,-20y)
        PenDown
        Displacement(24y,0y)
        Displacement(0y,-46y)
        PenUp
        Displacement(-19y,-18y)
        PenDown
        Displacement(19y,18y)
        Displacement(11y,-8y)
        Displacement(13y,-5y)
        Displacement(11y,-3y)
        Displacement(24y,0y)
        Displacement(32y,0y)
        PenUp
        Displacement(-41y,25y)
        PenDown
        Displacement(-28y,-10y)
        Displacement(0y,89y)
        yield! Radical.彐(52y,43y)

        PenUp
        Displacement(18y,-29y)
        PenDown
        Displacement(45y,-33y)
        PenUp
        Displacement(1y,36y)
        PenDown
        Displacement(-23y,-15y)
    ]
    // 吞
    52684us, [
        PenUp
        Displacement(19y,116y)
        PenDown
        yield! Radical.中心对齐等距横 [88y;110y] 25y

        PenUp
        Displacement(-57y,23y)
        PenDown
        Displacement(-3y,-18y)
        Displacement(-10y,-18y)
        Displacement(-10y,-10y)
        Displacement(-13y,-10y)
        Displacement(-11y,-5y)
        Displacement(-8y,-3y)
        PenUp
        Displacement(68y,36y)
        PenDown
        Displacement(6y,-10y)
        Displacement(9y,-8y)
        Displacement(8y,-5y)
        Displacement(13y,-8y)
        Displacement(10y,-5y)
        PenUp
        Displacement(-89y,5y)
        PenDown
        yield! Radical.口(62y,33y)

    ]
    // 屯
    52685us, [
        PenUp
        Displacement(1y,98y)
        PenDown
        Displacement(108y,0y)
        PenUp
        Displacement(-91y,-15y)
        PenDown
        yield! Radical.凵(74y,36y)
        PenUp
        Displacement(-37y,41y)
        PenDown
        yield! Radical.竖弯勾(60y,114y)

    ]
    // 臀
    52686us, [
        PenUp
        Displacement(4y,57y)
        PenDown
        Displacement(6y,10y)
        Displacement(4y,10y)
        Displacement(3y,15y)
        Displacement(0y,28y)
        yield! Radical.匚(-45y,18y)
        PenUp
        Displacement(7y,-15y)
        PenDown
        yield! Radical.共头 [18y;42y;51y] [15y;25y]

        PenUp
        Displacement(-35y,-6y)
        PenDown
        Displacement(-18y,-13y)
        PenUp
        Displacement(32y,13y)
        PenDown
        Displacement(11y,-10y)
        PenUp
        Displacement(13y,36y)
        PenDown
        Displacement(4y,5y)
        Displacement(3y,8y)
        Displacement(0y,8y+5y)
        Displacement(25y-1y,0y)
        Displacement(0y,-15y-5y)
        Displacement(18y,0y)
        PenUp
        Displacement(-51y,-10y)
        PenDown
        Displacement(38y,0y)
        Displacement(-10y,-13y)
        Displacement(-18y,-13y)
        Displacement(-11y,-5y)
        PenUp
        Displacement(9y,28y)
        PenDown
        Displacement(10y,-10y)
        Displacement(14y,-10y)
        Displacement(18y,-8y)
        PenUp
        Displacement(-89y,-54y)
        PenDown
        yield! Radical.青月(68y,48y)

    ]
    // 拖
    52687us, [
        PenUp
        Displacement(5y,96y)
        PenDown
        Displacement(41y,0y)
        PenUp
        Displacement(-19y,33y)
        PenDown
        Displacement(0y,-112y)
        Displacement(-5y,-5y)
        Displacement(-11y,0y)
        PenUp
        Displacement(-4y,41y)
        PenDown
        Displacement(37y,23y)
        PenUp
        Displacement(28y,54y)
        PenDown
        Displacement(-11y,-25y)
        Displacement(-15y,-23y)
        PenUp
        Displacement(19y,25y)
        PenDown
        Displacement(56y,0y)
        PenUp
        Displacement(-28y,-69y)
        PenDown
        Displacement(10y,3y)
        Displacement(6y,5y)
        Displacement(0y,36y)
        Displacement(-65y,-23y)
        PenUp
        Displacement(40y,38y)
        PenDown
        Displacement(0y,-69y)
        PenUp
        Displacement(-24y,61y)
        PenDown
        Displacement(0y,-66y)
        Displacement(4y,-8y)
        Displacement(47y,0y)
        Displacement(8y,3y)
        Displacement(4y,13y)
    ]
    // 托
    52688us, [
        PenUp
        Displacement(4y,93y)
        PenDown
        Displacement(52y,0y)
        PenUp
        Displacement(-23y,33y)
        PenDown
        Displacement(0y,-115y)
        Displacement(-5y,-5y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-14y,43y)
        PenDown
        Displacement(51y,20y)
        PenUp
        Displacement(62y,48y)
        PenDown
        Displacement(-31y,-13y)
        Displacement(-28y,0y)
        PenUp
        Displacement(-4y,-41y)
        PenDown
        Displacement(73y,0y)
        PenUp
        Displacement(-42y,41y)
        PenDown
        Displacement(0y,-92y)
        Displacement(4y,-5y)
        Displacement(29y,0y)
        Displacement(4y,8y)
        Displacement(3y,10y)
    ]
    // 脱
    52689us, [
        PenUp
        Displacement(3y,4y)
        PenDown
        Displacement(6y,15y)
        Displacement(6y,20y)
        Displacement(0y,69y)
        Displacement(27y,0y)
        Displacement(0y,-100y)
        Displacement(-14y,-5y)
        PenUp
        Displacement(-10y,74y)
        PenDown
        Displacement(22y,0y)
        PenUp
        Displacement(-20y,-28y)
        PenDown
        Displacement(23y,0y)
        PenUp
        Displacement(15y,69y)
        PenDown
        Displacement(22y,-23y)
        PenUp
        Displacement(29y,23y)
        PenDown
        Displacement(-22y,-31y)

        PenUp
        Displacement(-27y,0y)
        PenDown
        yield! Radical.口(47y,36y)

        PenUp
        Displacement(17y,-38y)
        PenDown
        Displacement(0y,-15y)
        Displacement(-6y,-13y)
        Displacement(-6y,-8y)
        Displacement(-15y,-13y)
        PenUp
        Displacement(46y,51y)
        PenDown
        Displacement(0y,-43y)
        Displacement(4y,-5y)
        Displacement(18y,0y)
        Displacement(4y,5y)
        Displacement(1y,13y)
    ]
    // 鸵
    52690us, [
        PenUp
        Displacement(29y,121y)
        PenDown
        Displacement(-13y,-15y)
        PenUp
        Displacement(15y,-36y)
        PenDown
        Displacement(11y,0y)
        Displacement(4y,5y)
        Displacement(0y,31y)
        Displacement(-37y,0y)
        Displacement(0y,-54y)
        Displacement(43y,0y)
        Displacement(-4y,-43y)
        Displacement(-6y,-5y)
        Displacement(-15y,-3y)
        PenUp
        Displacement(-27y,25y)
        PenDown
        Displacement(43y,8y)
        PenUp
        Displacement(-23y,61y)
        PenDown
        Displacement(13y,-15y)
        PenUp
        Displacement(42y,38y)
        PenDown
        Displacement(15y,-15y)
        PenUp
        Displacement(-29y,-28y)
        PenDown
        Displacement(0y,23y)
        Displacement(51y,0y)
        Displacement(0y,-20y)
        PenUp
        Displacement(0y,-15y)
        PenDown
        Displacement(-36y,-15y)
        PenUp
        Displacement(-1y,28y)
        PenDown
        Displacement(0y,-61y)
        Displacement(6y,-10y)
        Displacement(29y,0y)
        Displacement(6y,5y)
        Displacement(4y,15y)
    ]
    // 陀
    52691us, [
        PenUp
        Displacement(9y,1y)
        PenDown
        Displacement(0y,112y)
        Displacement(33y,0y)
        Displacement(-17y,-36y)
        Displacement(11y,-13y)
        Displacement(5y,-10y)
        Displacement(1y,-8y)
        Displacement(-4y,-10y)
        Displacement(-10y,-8y)
        Displacement(-10y,0y)
        PenUp
        Displacement(48y,97y)
        PenDown
        Displacement(17y,-15y)
        PenUp
        Displacement(-34y,-28y)
        PenDown
        Displacement(0y,20y)
        Displacement(64y,0y)
        Displacement(0y,-18y)
        PenUp
        Displacement(-45y,0y)
        PenDown
        Displacement(0y,-59y-8y)
        Displacement(4y,-8y)
        Displacement(8y,-3y)
        Displacement(25y,0y)
        Displacement(8y,3y)
        Displacement(4y,8y)
        Displacement(0y,5y)
        PenUp
        Displacement(-47y,31y)
        PenDown
        Displacement(38y,10y)
    ]
    // 驮
    52692us, [
        PenUp
        Displacement(10y,111y)
        PenDown
        Displacement(36y,0y)
        Displacement(-5y,-51y)
        PenUp
        Displacement(14y,-3y)
        PenDown
        Displacement(-5y,-43y)
        PenUp
        Displacement(-45y,15y)
        PenDown
        Displacement(36y,10y)
        PenUp
        Displacement(14y,38y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-32y,46y)
        PenDown
        Displacement(0y,-43y)
        Displacement(-3y,-25y)
        Displacement(-8y,-23y)
        Displacement(-9y,-13y)
        Displacement(-19y,-18y)
        PenUp
        Displacement(42y,54y)
        PenDown
        Displacement(13y,-28y)
        Displacement(10y,-18y)
        Displacement(8y,-5y)
        PenUp
        Displacement(-31y,48y)
        PenDown
        Displacement(-5y,18y)
        PenUp
        Displacement(-29y,-10y)
        PenDown
        Displacement(-38y,0y)
        PenUp
        Displacement(5y,51y)
        PenDown
        Displacement(-5y,-51y)
        PenUp
        Displacement(32y,-46y)
        PenDown
        Displacement(-5y,-8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-27y,97y)
        PenDown
        Displacement(36y,0y)
    ]
    // 驼
    52693us, [
        PenUp
        Displacement(3y,113y)
        PenDown
        Displacement(38y,0y)
        Displacement(0y,-54y)
        PenUp
        Displacement(-25y,43y)
        PenDown
        Displacement(0y,-46y)
        Displacement(37y,0y)
        Displacement(0y,-48y)
        Displacement(-5y,-3y)
        Displacement(-18y,-5y)
        PenUp
        Displacement(-25y,25y)
        PenDown
        Displacement(37y,10y)
        PenUp
        Displacement(41y,87y)
        PenDown
        Displacement(8y,-15y)
        PenUp
        Displacement(-29y,-28y)
        PenDown
        Displacement(0y,25y)
        Displacement(56y,0y)
        Displacement(-3y,-28y)
        PenUp
        Displacement(-1y,-10y)
        PenDown
        Displacement(-18y,-13y)
        Displacement(-19y,-8y)
        PenUp
        Displacement(0y,33y)
        PenDown
        Displacement(0y,-71y)
        Displacement(37y,-3y)
        Displacement(4y,5y)
        Displacement(4y,13y)
    ]
    // 椭
    52694us, [
        PenUp
        Displacement(5y,90y)
        PenDown
        Displacement(31y,0y)
        PenUp
        Displacement(-14y,31y)
        PenDown
        Displacement(0y,-120y)
        PenUp
        Displacement(-1y,84y)
        PenDown
        Displacement(-9y,-18y)
        Displacement(-9y,-23y)
        PenUp
        Displacement(18y,33y)
        PenDown
        Displacement(15y,-20y)
        PenUp
        Displacement(8y,-56y)
        PenDown
        Displacement(0y,112y)
        Displacement(22y,0y)
        Displacement(-11y,-33y)
        Displacement(6y,-13y)
        Displacement(5y,-20y)
        Displacement(-5y,-10y)
        Displacement(-9y,-8y)
        PenUp
        Displacement(17y,73y)
        PenDown
        Displacement(57y,0y)
        PenUp
        Displacement(-32y,18y)
        PenDown
        Displacement(-6y,-15y)
        Displacement(-9y,-15y)
        Displacement(-10y,-20y)
        PenUp
        Displacement(11y,-66y)
        PenDown
        yield! Radical.青月(34y,74y)

    ]
    // 妥
    52695us, [
        PenUp
        Displacement(18y,111y)
        PenDown
        Displacement(34y,0y)
        Displacement(31y,3y)
        Displacement(19y,10y)
        PenUp
        Displacement(-82y,-23y)
        PenDown
        Displacement(19y,-20y)
        PenUp
        Displacement(19y,25y)
        PenDown
        Displacement(14y,-20y)
        PenUp
        Displacement(34y,23y)
        PenDown
        Displacement(-23y,-31y)
        PenUp
        Displacement(-79y,-18y)
        PenDown
        Displacement(121y,0y)
        PenUp
        Displacement(-65y,23y)
        PenDown
        Displacement(-23y,-43y)
        Displacement(79y,-38y)
        PenUp
        Displacement(-28y,56y)
        PenDown
        Displacement(-8y,-23y)
        Displacement(-14y,-10y)
        Displacement(-11y,-3y)
        Displacement(-19y,-8y)
        Displacement(-27y,-5y)
    ]
    // 拓
    52696us, [
        PenUp
        Displacement(5y,90y)
        PenDown
        Displacement(46y,0y)
        PenUp
        Displacement(-22y,36y)
        PenDown
        Displacement(0y,-110y)
        Displacement(-4y,-5y)
        Displacement(-14y,-3y)
        PenUp
        Displacement(-6y,41y)
        PenDown
        Displacement(43y,23y)
        PenUp
        Displacement(0y,36y)
        PenDown
        Displacement(76y,0y)
        PenUp
        Displacement(-47y,-3y)
        PenDown
        Displacement(-10y,-31y)
        Displacement(-9y,-15y)
        Displacement(-15y,-18y)
        PenUp
        Displacement(22y,28y)
        PenDown
        yield! Radical.口(46y,54y)

    ]
    // 唾
    52697us, [
        PenUp
        Displacement(9y,37y)
        PenDown
        yield! Radical.口(20y,-69y)
        PenUp
        Displacement(33y,74y)
        PenDown
        Displacement(69y,9y)
        PenUp
        Displacement(-75y,-30y)
        PenDown
        yield! Radical.垂无撇 [82y;70y] 104y
    ]
    // 挖
    52698us, [
        PenUp
        Displacement(4y,96y)
        PenDown
        Displacement(42y,0y)
        PenUp
        Displacement(-17y,25y)
        PenDown
        Displacement(0y,-10y-102y)
        Displacement(-5y,-3y)
        Displacement(-13y,-5y)
        PenUp
        Displacement(-5y,46y)
        PenDown
        Displacement(41y,20y)
        PenUp
        Displacement(27y,56y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(-36y,-25y)
        PenDown
        Displacement(0y,20y)
        Displacement(62y,0y)
        Displacement(0y,-18y)
        PenUp
        Displacement(-40y,5y)
        PenDown
        Displacement(-24y,-25y)
        PenUp
        Displacement(40y,25y)
        PenDown
        Displacement(28y,-25y)
        PenUp
        Displacement(-68y,-8y)
        PenDown
        Displacement(50y,0y)
        Displacement(-28y,-23y)
        Displacement(-10y,-8y)
        Displacement(-4y,-10y)
        Displacement(0y,-5y)
        Displacement(5y,-5y)
        Displacement(40y,0y)
        Displacement(6y,3y)
        Displacement(6y,8y)
        Displacement(4y,10y)
    ]
    // 哇
    52699us, [
        PenUp
        Displacement(8y,39y)
        PenDown
        yield! Radical.口(28y,-59y)
        PenUp
        Displacement(38y,58y)
        PenDown
        yield! Radical.多横中竖士 [66y;78y;68y;89y] [29y;113y]

    ]
    // 蛙
    52700us, [
        PenUp
        Displacement(10y,54y+41y)
        PenDown
        yield! Radical.中 40y [41y;25y;97y]

        PenUp
        Displacement(-24y,-5y)
        PenDown
        Displacement(45y,10y)
        PenUp
        Displacement(-7y,14y)
        PenDown
        Displacement(10y,-20y)
        PenUp
        Displacement(6y,80y)
        PenDown
        yield! Radical.多横中竖士 [56y;64y;56y;79y] [30y;112y]

    ]
    // 洼
    52701us, [
        PenUp
        Displacement(11y,119y)
        PenDown
        Displacement(23y,-18y)
        PenUp
        Displacement(-31y,-15y)
        PenDown
        Displacement(22y,-15y)
        PenUp
        Displacement(3y,-15y)
        PenDown
        Displacement(-10y-11y,-25y-23y)
        PenUp
        Displacement(41y,94y)
        PenDown
        yield! Radical.多横中竖士 [68y;83y;70y;92y] [30y;114y]

    ]
    // 娃
    52702us, [
        PenUp
        Displacement(3y,90y)
        PenDown
        Displacement(42y,0y)
        Displacement(-3y,-23y)
        Displacement(-4y,-15y)
        Displacement(-5y,-13y)
        Displacement(-4y,-8y)
        Displacement(-6y-6y,-8y-8y)
        Displacement(-13y,-8y)
        PenUp
        Displacement(23y,115y)
        PenDown
        Displacement(-15y,-69y)
        Displacement(36y,-28y)
        PenUp
        Displacement(9y,77y)
        PenDown
        yield! Radical.多横中竖士 [61y;71y;62y;83y] [30y;112y]

    ]
    // 瓦
    52703us, [
        PenUp
        Displacement(5y,106y)
        PenDown
        Displacement(111y,0y)
        PenUp
        Displacement(-75y,-3y)
        PenDown
        Displacement(-20y,-94y)
        Displacement(43y,15y)
        PenUp
        Displacement(-29y,56y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,-66y)
        Displacement(33y,-8y)
        Displacement(6y,20y)
        PenUp
        Displacement(-79y,33y)
        PenDown
        Displacement(25y,-23y)
    ]
    // 袜
    52704us, [
        PenUp
        Displacement(20y,124y)
        PenDown
        Displacement(13y,-20y)
        PenUp
        Displacement(-28y,-5y)
        PenDown
        Displacement(40y,0y)
        Displacement(-9y,-15y)
        Displacement(-13y,-18y)
        Displacement(-17y,-10y)
        PenUp
        Displacement(20y,18y)
        PenDown
        Displacement(0y,-71y)
        PenUp
        Displacement(24y,74y)
        PenDown
        Displacement(-10y,-18y)
        PenUp
        Displacement(-11y,5y)
        PenDown
        Displacement(22y,-18y)
        PenUp
        Displacement(4y,51y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-62y,-31y)
        PenDown
        Displacement(60y,0y)
        PenUp
        Displacement(-32y,61y)
        PenDown
        Displacement(0y,-125y)
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(-11y,-15y)
        Displacement(-15y,-20y)
        Displacement(-17y,-13y)
        PenUp
        Displacement(45y,51y)
        PenDown
        Displacement(11y,-18y)
        Displacement(10y,-18y)
        Displacement(17y,-18y)
    ]
    // 歪
    52705us, [
        PenUp
        Displacement(9y,113y)
        PenDown
        Displacement(107y,0y)
        PenUp
        Displacement(-46y,-3y)
        PenDown
        Displacement(-8y,-10y)
        Displacement(-20y,-13y)
        Displacement(-22y,-10y)
        Displacement(-18y,-5y)
        PenUp
        Displacement(59y,28y)
        PenDown
        Displacement(0y,-33y)
        PenUp
        Displacement(13y,25y)
        PenDown
        Displacement(45y,-20y)
        PenUp
        Displacement(-104y,-13y)
        PenDown
        yield! (id<正> {
                工 = 94y,43y,119y
                短竖 = 32y,28y
                短横 = 37y,20y
            }).toYield()

    ]
    // 外
    52706us, [
        PenUp
        Displacement(37y,124y)
        PenDown
        Displacement(-8y,-23y)
        Displacement(-10y,-15y)
        Displacement(-14y,-20y)
        PenUp
        Displacement(22y,31y)
        PenDown
        Displacement(36y,0y)
        Displacement(-6y,-28y)
        Displacement(-9y,-18y)
        Displacement(-13y,-15y)
        Displacement(-13y,-8y)
        Displacement(-14y,-10y)
        PenUp
        Displacement(18y,54y)
        PenDown
        Displacement(22y,-23y)
        PenUp
        Displacement(33y,79y)
        PenDown
        Displacement(0y,-125y)
        PenUp
        Displacement(10y,84y)
        PenDown
        Displacement(18y,-15y)
        Displacement(15y,-20y)
    ]
    // 豌
    52707us, [
        PenUp
        Displacement(6y,111y)
        PenDown
        Displacement(45y,0y)
        PenUp
        Displacement(-38y,-25y)
        PenDown
        yield! Radical.口(31y,23y)
        PenUp
        Displacement(-1y,-33y)
        PenDown
        Displacement(14y,-20y)
        PenUp
        Displacement(20y,20y)
        PenDown
        Displacement(-11y,-23y)
        PenUp
        Displacement(-31y,-10y)
        PenDown
        Displacement(52y,13y)
        PenUp
        Displacement(17y,92y)
        PenDown
        Displacement(19y,-15y)
        PenUp
        Displacement(-37y,-25y)
        PenDown
        yield! Radical.冖(60y,20y)
        PenUp
        Displacement(-41y,10y)
        PenDown
        Displacement(-23y,-41y)
        PenUp
        Displacement(17y,23y)
        PenDown
        Displacement(14y,0y)
        Displacement(-3y,-23y)
        Displacement(-5y,-15y)
        Displacement(-9y,-15y)
        Displacement(-18y,-15y)
        PenUp
        Displacement(13y,46y)
        PenDown
        Displacement(10y,-8y)
        PenUp
        Displacement(52y,-20y)
        PenDown
        Displacement(-3y,-10y)
        Displacement(-8y,-5y)
        Displacement(-18y,0y)
        Displacement(-5y,8y)
        Displacement(0y,59y)
        Displacement(22y,0y)
        Displacement(0y,-33y)
        Displacement(-4y,-3y)
        Displacement(-10y,-3y)
    ]
    // 弯
    52708us, [
        PenUp
        Displacement(51y,121y)
        PenDown
        Displacement(22y,-10y)
        PenUp
        Displacement(-44y,-15y)
        PenDown
        Displacement(-24y,-31y)
        PenUp
        Displacement(88y,31y)
        PenDown
        Displacement(29y,-23y)
        PenUp
        Displacement(-75y,-5y)
        PenDown
        yield! Radical.业无八 [113y;29y] -33y

        PenUp
        Displacement(-96y,-38y)
        PenDown
        Displacement(76y,0y)
        Displacement(0y,-20y)
        Displacement(-71y,0y)
        Displacement(-4y,-15y)
        Displacement(84y,0y)
        Displacement(-11y,-28y)
        Displacement(-27y,0y)
    ]
    // 湾
    52709us, [
        PenUp
        Displacement(11y,113y)
        PenDown
        Displacement(19y,-18y)
        PenUp
        Displacement(-27y,-10y)
        PenDown
        Displacement(17y,-15y)
        PenUp
        Displacement(9y,-18y)
        PenDown
        Displacement(-20y,-48y)
        PenUp
        Displacement(54y,120y)
        PenDown
        Displacement(18y,-13y)
        PenUp
        Displacement(-28y,-16y)
        PenDown
        Displacement(-20y,-23y)
        PenUp
        Displacement(65y,20y)
        PenDown
        Displacement(20y,-18y)
        PenUp
        Displacement(-52y,-8y)
        PenDown
        yield! Radical.业无八 [82y;20y] -36y

        PenUp
        Displacement(-74y,-37y)
        PenDown
        Displacement(64y,0y)
        Displacement(0y,-18y)
        Displacement(-61y,0y)
        Displacement(-3y,-23y)
        Displacement(65y,0y)
        Displacement(-6y,-18y)
        Displacement(-17y,-3y)
        Displacement(-13y,-3y)
    ]
    // 玩
    52710us, [
        PenUp
        Displacement(6y,113y)
        PenDown
        yield! Radical.中心对齐等距横 [46y;40y] 33y

        PenUp
        Displacement(-42y,-51y)
        PenDown
        Displacement(50y,18y)
        PenUp
        Displacement(-25y,69y)
        PenDown
        Displacement(0y,-76y)
        PenUp
        Displacement(28y,76y)
        PenDown
        yield! Radical.中心对齐等距横 [60y;69y] 38y

        PenUp
        Displacement(-46y,3y)
        PenDown
        Displacement(0y,-36y)
        Displacement(-9y,-18y)
        Displacement(-8y,-5y)
        Displacement(-24y,-10y)
        PenUp
        Displacement(61y,66y)
        PenDown
        Displacement(0y,-54y)
        Displacement(4y,-13y)
        Displacement(19y,3y)
        Displacement(8y,13y)
    ]
    // 顽
    52711us, [
        PenUp
        Displacement(9y,116y)
        PenDown
        yield! Radical.中心对齐等距横 [40y;54y] 31y

        PenUp
        Displacement(-36y,-3y)
        PenDown
        Displacement(0y,-23y)
        Displacement(-4y,-18y)
        Displacement(-4y,-13y)
        Displacement(-9y,-10y)
        PenUp
        Displacement(34y,66y)
        PenDown
        Displacement(0y,-59y)
        Displacement(18y,15y)
        PenUp
        Displacement(-3y,76y)
        PenDown
        Displacement(69y,0y)
        PenUp
        Displacement(-34y,0y)
        PenDown
        Displacement(-9y,-25y)
        PenUp
        Displacement(-15y,-59y)
        PenDown
        Displacement(0y,59y)
        Displacement(47y,0y)
        Displacement(0y,-59y)
        PenUp
        Displacement(-24y,41y)
        PenDown
        Displacement(0y,-23y)
        Displacement(-5y,-20y)
        Displacement(-11y,-13y)
        Displacement(-23y,-13y)
        PenUp
        Displacement(43y,25y)
        PenDown
        Displacement(32y,-23y)
    ]
    // 丸
    52712us, [
        PenUp
        Displacement(13y,88y)
        PenDown
        Displacement(82y,0y)
        Displacement(-8y,-74y)
        Displacement(3y,-10y)
        Displacement(25y,3y)
        Displacement(3y,3y)
        Displacement(4y,15y)
        PenUp
        Displacement(-64y,99y)
        PenDown
        Displacement(0y,-64y)
        Displacement(-9y,-23y)
        Displacement(-19y,-18y)
        Displacement(-22y,-13y)
        PenUp
        Displacement(17y,64y)
        PenDown
        Displacement(52y,-33y)
    ]
    // 烷
    52713us, [
        PenUp
        Displacement(14y,96y)
        PenDown
        Displacement(-6y,-31y)
        PenUp
        Displacement(20y,56y)
        PenDown
        Displacement(0y,-56y-18y)
        Displacement(-6y,-15y)
        Displacement(-8y,-10y)
        Displacement(-9y,-13y)
        PenUp
        Displacement(41y,87y)
        PenDown
        Displacement(-17y,-23y)
        PenUp
        Displacement(0y,-28y)
        PenDown
        Displacement(19y,-20y)
        PenUp
        Displacement(24y,102y)
        PenDown
        Displacement(11y,-13y)
        PenUp
        Displacement(-33y,-28y)
        PenDown
        Displacement(3y,20y)
        Displacement(59y,0y)
        Displacement(0y,-20y)
        PenUp
        Displacement(-50y,0y)
        PenDown
        yield! Radical.中心对齐等距横 [43y;70y] 25y

        PenUp
        Displacement(-46y,0y)
        PenDown
        Displacement(-3y,-23y)
        Displacement(-9y,-18y)
        Displacement(-9y,-8y)
        Displacement(-10y,-5y)
        PenUp
        Displacement(50y,56y)
        PenDown
        Displacement(0y,-38y)
        Displacement(1y,-13y)
        Displacement(22y,0y)
        Displacement(8y,13y)
    ]
    // 完
    52714us, [
        PenUp
        Displacement(11y,85y)
        PenDown
        Displacement(0y,23y)
        Displacement(101y,0y)
        Displacement(0y,-20y)
        PenUp
        Displacement(-59y,38y)
        PenDown
        Displacement(17y,-13y)
        PenUp
        Displacement(-42y,-31y)
        PenDown
        yield! Radical.中心对齐等距横 [70y;104y] 25y

        PenUp
        Displacement(-68y,-3y)
        PenDown
        Displacement(0y,-18y)
        Displacement(-6y,-10y)
        Displacement(-8y,-8y)
        Displacement(-8y,-5y)
        Displacement(-19y,-10y)
        PenUp
        Displacement(68y,54y)
        PenDown
        Displacement(0y,-33y)
        Displacement(3y,-10y)
        Displacement(6y,-5y)
        Displacement(22y,0y)
        Displacement(9y,5y)
        Displacement(5y,15y)
    ]
    // 碗
    52715us, [
        PenUp
        Displacement(8y,103y)
        PenDown
        Displacement(37y,0y)
        PenUp
        Displacement(-19y,0y)
        PenDown
        Displacement(-5y,-20y)
        Displacement(-5y,-8y)
        Displacement(-8y,-10y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(17y,-26y)
        PenDown
        yield! Radical.口(23y,-41y)
        PenUp
        Displacement(56y,92y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(-36y,-25y)
        PenDown
        yield! Radical.冖(63y,20y)
        PenUp
        Displacement(-46y,5y)
        PenDown
        Displacement(-9y,-18y)
        Displacement(-5y,-15y)
        Displacement(-10y,-13y)
        PenUp
        Displacement(19y,31y)
        PenDown
        Displacement(14y,-3y)
        Displacement(0y,-18y)
        Displacement(-5y,-15y)
        Displacement(-8y,-13y)
        Displacement(-8y,-10y)
        Displacement(-8y,-8y)
        Displacement(-9y,-8y)
        PenUp
        Displacement(17y,46y)
        PenDown
        Displacement(15y,-8y)
        PenUp
        Displacement(27y,-3y)
        PenDown
        Displacement(9y,0y)
        Displacement(1y,3y)
        Displacement(0y,33y)
        Displacement(-19y,0y)
        Displacement(0y,-59y)
        Displacement(3y,-8y)
        Displacement(5y+18y,0y)
        Displacement(4y,3y)
        Displacement(3y,8y)
    ]
    // 挽
    52716us, [
        PenUp
        Displacement(4y,93y)
        PenDown
        Displacement(45y,0y)
        PenUp
        Displacement(-22y,33y)
        PenDown
        Displacement(0y,-102y)
        Displacement(-1y,-10y)
        Displacement(-6y,-3y)
        Displacement(-9y,-3y)
        PenUp
        Displacement(-6y,43y)
        PenDown
        Displacement(42y,18y)
        PenUp
        Displacement(32y,54y)
        PenDown
        Displacement(-27y,-31y)
        PenUp
        Displacement(19y,15y)
        PenDown
        Displacement(34y,0y)
        Displacement(-18y,-18y)
        PenUp
        Displacement(-34y,-33y)
        PenDown
        yield! Radical.口(59y,-31y)
        PenUp
        Displacement(29y,28y)
        PenDown
        Displacement(0y,-20y)
        Displacement(-4y,-15y)
        Displacement(-4y,-10y)
        Displacement(-8y,-10y)
        Displacement(-9y,-10y)
        Displacement(-10y,-8y)
        Displacement(-11y,-8y)
        PenUp
        Displacement(50y,46y)
        PenDown
        Displacement(0y,-31y)
        Displacement(0y,-8y)
        Displacement(3y,-3y)
        Displacement(6y,0y)
        Displacement(11y,-3y)
        Displacement(5y,3y)
        Displacement(5y,5y)
        Displacement(3y,5y)
    ]
    // 晚
    52717us, [
        PenUp
        Displacement(8y,106y)
        PenDown
        yield! Radical.日(31y,69y)
        PenUp
        Displacement(66y,52y)
        PenDown

        Displacement(-10y,-15y)
        Displacement(-17y,-18y)
        PenUp
        Displacement(17y,15y)
        PenDown
        Displacement(34y,0y)
        Displacement(-15y,-18y)
        PenUp
        Displacement(-31y,-34y)
        PenDown
        yield! Radical.口(56y,-31y)
        PenUp
        Displacement(27y,28y)
        PenDown
        Displacement(0y,-20y)
        Displacement(-4y,-13y)
        Displacement(-6y,-15y)
        Displacement(-13y,-15y)
        Displacement(-13y,-10y)
        Displacement(-11y,-8y)
        PenUp
        Displacement(52y,48y)
        PenDown
        Displacement(0y,-31y-5y)
        Displacement(1y,-5y)
        Displacement(5y,-3y)
        Displacement(15y,0y)
        Displacement(5y,3y)
        Displacement(4y,5y)
        Displacement(3y,10y)
    ]
    // 皖
    52718us, [
        PenUp
        Displacement(29y,121y)
        PenDown
        Displacement(-13y,-23y)
        PenUp
        Displacement(-5y,0y)
        PenDown
        yield! Radical.日(29y,69y)
        PenUp
        Displacement(61y,64y)
        PenDown
        Displacement(11y,-13y)
        PenUp
        Displacement(-33y,-28y)
        PenDown
        yield! Radical.冖(65y,20y)
        PenUp
        Displacement(-52y,3y)
        PenDown
        yield! Radical.中心对齐等距横 [43y;70y] 25y

        PenUp
        Displacement(-46y,0y)
        PenDown
        Displacement(-3y,-23y)
        Displacement(-9y,-18y)
        Displacement(-9y,-8y)
        Displacement(-10y,-5y)
        PenUp
        Displacement(50y,56y)
        PenDown
        Displacement(0y,-38y)
        Displacement(1y,-13y)
        Displacement(22y,0y)
        Displacement(8y,13y)
    ]
    // 惋
    52719us, [
        PenUp
        Displacement(11y,96y)
        PenDown
        Displacement(-6y,-33y)
        PenUp
        Displacement(19y,61y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(10y,97y)
        PenDown
        Displacement(8y,-23y)
        PenUp
        Displacement(31y,48y)
        PenDown
        Displacement(13y,-13y)
        PenUp
        Displacement(-36y,-25y)
        PenDown
        yield! Radical.冖(65y,20y)

        PenUp
        Displacement(-51y,8y)
        PenDown
        Displacement(-28y,-51y)
        PenUp
        Displacement(23y,33y)
        PenDown
        Displacement(17y,0y)
        Displacement(-3y,-23y)
        Displacement(-10y,-20y)
        Displacement(-24y,-28y)
        PenUp
        Displacement(17y,48y)
        PenDown
        Displacement(9y,-10y)
        PenUp
        Displacement(33y,-8y)
        PenDown
        Displacement(6y,0y)
        Displacement(6y,8y)
        Displacement(0y,33y)
        Displacement(-24y,0y)
        Displacement(0y,-56y)
        Displacement(1y,-8y)
        Displacement(4y,-5y)
        Displacement(22y,0y)
        Displacement(6y,5y)
        Displacement(3y,8y)
    ]
    // 宛
    52720us, [
        PenUp
        Displacement(51y,121y)
        PenDown
        Displacement(18y,-10y)
        PenUp
        Displacement(-60y,-31y)
        PenDown
        yield! Radical.冖(103y,20y)

        PenUp
        Displacement(-74y,13y)
        PenDown
        Displacement(-6y,-18y)
        Displacement(-9y-9y,-15y-15y)
        Displacement(-8y,-5y)
        PenUp
        Displacement(25y,36y)
        PenDown
        Displacement(25y,0y)
        Displacement(-5y,-23y)
        Displacement(-6y,-15y)
        Displacement(-14y,-15y)
        Displacement(-10y,-13y)
        Displacement(-10y,-5y)
        PenUp
        Displacement(17y,46y)
        PenDown
        Displacement(14y,-13y)
        PenUp
        Displacement(43y,-3y)
        PenDown
        Displacement(6y,0y)
        Displacement(8y,3y)
        Displacement(3y,5y)
        Displacement(0y,31y)
        Displacement(-33y,0y)
        Displacement(0y,-56y)
        Displacement(4y,-8y)
        Displacement(6y,-3y)
        Displacement(23y,0y)
        Displacement(6y,3y)
        Displacement(5y,5y)
        Displacement(3y,10y)
    ]
    // 婉
    52721us, [
        PenUp
        Displacement(28y,121y)
        PenDown
        Displacement(-17y,-76y)
        Displacement(33y,-25y)
        PenUp
        Displacement(-43y,66y)
        PenDown
        Displacement(40y,0y)
        Displacement(0y,-18y)
        Displacement(-5y,-20y)
        Displacement(-9y,-18y)
        Displacement(-11y,-15y)
        Displacement(-11y,-10y)
        PenUp
        Displacement(69y,117y)
        PenDown
        Displacement(17y,-13y)
        PenUp
        Displacement(-40y,-28y)
        PenDown
        yield! Radical.冖(65y,20y)
        PenUp
        Displacement(-45y,5y)
        PenDown
        Displacement(-10y,-18y)
        Displacement(-9y,-18y)
        Displacement(-8y,-13y)
        PenUp
        Displacement(20y,31y)
        PenDown
        Displacement(15y,0y)
        Displacement(-4y,-20y)
        Displacement(-5y,-15y)
        Displacement(-11y,-18y)
        Displacement(-9y,-10y)
        Displacement(-8y,-5y)
        PenUp
        Displacement(15y,46y)
        PenDown
        Displacement(13y,-8y)
        PenUp
        Displacement(25y,-5y)
        PenDown
        Displacement(5y,3y)
        Displacement(4y,0y)
        Displacement(4y,5y)
        Displacement(0y,31y)
        Displacement(-19y,0y)
        Displacement(0y,-59y)
        Displacement(1y,-5y)
        Displacement(8y,-3y)
        Displacement(14y,0y)
        Displacement(6y,0y)
        Displacement(4y,8y)
        Displacement(0y,8y)
    ]
    // 万
    52722us, [
        PenUp
        Displacement(6y,108y)
        PenDown
        Displacement(116y,0y)
        PenUp
        Displacement(-66y,0y)
        PenDown
        Displacement(-3y,-23y)
        Displacement(-5y,-23y)
        Displacement(-8y,-18y)
        Displacement(-10y,-15y)
        Displacement(-18y,-20y)
        PenUp
        Displacement(42y,69y)
        PenDown
        Displacement(54y,0y)
        Displacement(-10y,-54y)
        Displacement(-6y,-13y)
        Displacement(-22y,-5y)
    ]
    // 腕
    52723us, [
        PenUp
        Displacement(4y,9y)
        PenDown
        Displacement(6y,15y)
        Displacement(5y,15y)
        Displacement(0y,74y)
        Displacement(24y,0y)
        Displacement(0y,-97y)
        Displacement(-5y,-5y)
        Displacement(-13y,0y)
        PenUp
        Displacement(-1y,71y)
        PenDown
        Displacement(17y,0y)
        PenUp
        Displacement(-19y,-25y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(38y,66y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(-37y,-25y)
        PenDown
        yield! Radical.冖(67y,18y)

        PenUp
        Displacement(-50y,8y)
        PenDown
        Displacement(-19y,-43y)
        PenUp
        Displacement(17y,28y)
        PenDown
        Displacement(15y,0y)
        Displacement(-4y,-25y)
        Displacement(-15y,-28y)
        Displacement(-14y,-10y)
        PenUp
        Displacement(13y,43y)
        PenDown
        Displacement(9y,-10y)
        PenUp
        Displacement(28y,-8y)
        PenDown
        Displacement(10y,3y)
        Displacement(5y,5y)
        Displacement(0y,33y)
        Displacement(-22y,0y)
        Displacement(0y,-64y)
        Displacement(4y,-5y)
        Displacement(18y,0y)
        Displacement(8y,13y)
    ]
    // 汪
    52724us, [
        PenUp
        Displacement(14y,116y)
        PenDown
        Displacement(25y,-15y)
        PenUp
        Displacement(-36y,-18y)
        PenDown
        Displacement(23y,-15y)
        PenUp
        Displacement(-19y,-54y)
        PenDown
        Displacement(17y+14y,18y+25y)
        PenUp
        Displacement(4y,51y)
        PenDown
        yield! Radical.多横中竖工 [76y;68y;92y] 41y

    ]
    // 王
    52725us, [
        PenUp
        Displacement(11y,113y)
        PenDown
        yield! Radical.多横中竖工 [103y;85y;117y] 47y

    ]
    // 亡
    52726us, [
        PenUp
        Displacement(51y,116y)
        PenDown
        Displacement(23y,-23y)
        PenUp
        Displacement(-70y,-8y)
        PenDown
        Displacement(116y,0y)
        PenUp
        Displacement(-90y,0y)
        PenDown
        Displacement(0y,-74y)
        Displacement(80y,0y)
    ]
    // 枉
    52727us, [
        PenUp
        Displacement(1y,93y)
        PenDown
        yield! Radical.十 50y [31y; 120y]

        PenUp
        Displacement(-1y,87y)
        PenDown
        Displacement(-24y,-48y)
        PenUp
        Displacement(25y,33y)
        PenDown
        Displacement(23y,-18y)
        PenUp
        Displacement(-5y,56y)
        PenDown
        yield! Radical.多横中竖工 [74y;64y;83y] 47y

    ]
    // 网
    52728us, [
        PenUp
        Displacement(14y,1y)
        PenDown
        Displacement(0y,112y)
        Displacement(97y,0y)
        Displacement(0y,-97y)
        Displacement(-3y,-5y)
        Displacement(-8y,-3y)
        Displacement(-10y,-3y)
        PenUp
        Displacement(-68y,87y)
        PenDown
        Displacement(13y,-18y)
        Displacement(11y,-18y)
        Displacement(10y,-23y)
        PenUp
        Displacement(-3y,64y)
        PenDown
        Displacement(-5y,-20y)
        Displacement(-13y,-25y)
        Displacement(-15y,-23y)
        PenUp
        Displacement(43y,64y)
        PenDown
        Displacement(11y,-18y)
        Displacement(13y,-23y)
        Displacement(8y,-18y)
        PenUp
        Displacement(-1y,64y)
        PenDown
        Displacement(-6y,-20y)
        Displacement(-11y,-20y)
        Displacement(-14y,-23y)
    ]
    // 往
    52729us, [
        PenUp
        Displacement(37y,121y)
        PenDown
        Displacement(-8y,-10y)
        Displacement(-8y-8y,-8y-8y)
        Displacement(-9y,-5y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(-25y,-30y)
        Displacement(-10y,-10y)
        PenUp
        Displacement(19y,20y)
        PenDown
        Displacement(0y,-69y)
        PenUp
        Displacement(48y,120y)
        PenDown
        Displacement(18y,-20y)
        PenUp
        Displacement(-45y,-8y)
        PenDown
        yield! Radical.多横中竖工 [78y;66y;85y] 40y

    ]
    // 旺
    52730us, [
        PenUp
        Displacement(8y,108y)
        PenDown
        yield! Radical.日(29y,79y)
        PenUp
        Displacement(39y,41y)
        PenDown
        yield! Radical.多横中竖工 [66y;60y;82y] 48y

    ]
    // 望
    52731us, [
        PenUp
        Displacement(25y,121y)
        PenDown
        Displacement(17y,-15y)
        PenUp
        Displacement(-36y,-8y)
        PenDown
        Displacement(57y,0y)
        PenUp
        Displacement(-41y,-3y)
        PenDown
        Displacement(-5y,-31y)
        Displacement(38y,8y)
        PenUp
        Displacement(5y,-18y)
        PenDown
        Displacement(8y,10y)
        Displacement(3y,8y)
        Displacement(1y,10y)
        Displacement(0y,15y+13y)
        Displacement(36y,0y)
        Displacement(0y,-15y-10y-18y)
        Displacement(-4y,-5y)
        Displacement(-6y,-3y)
        Displacement(-5y,0y)
        PenUp
        Displacement(-18y,36y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-33y,-15y)
        PenDown
        Displacement(33y,0y)
        PenUp
        Displacement(-92y,-31y)
        PenDown
        yield! Radical.多横中竖工 [93y;83y;119y] 21y

    ]
    // 忘
    52732us, [
        PenUp
        Displacement(51y,121y)
        PenDown
        Displacement(20y,-18y)
        PenUp
        Displacement(-66y,-5y)
        PenDown
        Displacement(113y,0y)
        PenUp
        Displacement(-88y,-3y)
        PenDown
        Displacement(0y,-33y)
        Displacement(71y,0y)
        PenUp
        Displacement(-79y,-20y)
        PenDown
        Displacement(-14y,-31y)
        PenUp
        Displacement(31y,33y)
        PenDown
        Displacement(0y,-28y)
        Displacement(3y,-8y)
        Displacement(15y,-3y)
        Displacement(32y,0y)
        Displacement(4y,3y)
        Displacement(4y,10y)
        PenUp
        Displacement(-38y,31y)
        PenDown
        Displacement(17y,-18y)
        PenUp
        Displacement(24y,8y)
        PenDown
        Displacement(24y,-20y)
    ]
    // 妄
    52733us, [
        PenUp
        Displacement(52y,124y)
        PenDown
        Displacement(22y,-15y)
        PenUp
        Displacement(-70y,-5y)
        PenDown
        Displacement(117y,0y)
        PenUp
        Displacement(-93y,-3y)
        PenDown
        Displacement(0y,-25y)
        Displacement(79y,0y)
        PenUp
        Displacement(-47y,-3y)
        PenDown
        Displacement(-24y,-36y)
        Displacement(83y,-33y)
        PenUp
        Displacement(-31y,48y)
        PenDown
        Displacement(-17y,-28y)
        Displacement(-19y,-10y)
        Displacement(-24y,-10y)
        Displacement(-19y,-3y)
        PenUp
        Displacement(-8y,51y)
        PenDown
        Displacement(121y,0y)
    ]
    // 威
    52734us, [
        PenUp
        Displacement(119y,101y)
        PenDown
        Displacement(-102y,0y)
        Displacement(0y,-56y)
        Displacement(-1y,-15y)
        Displacement(-11y,-25y)
        PenUp
        Displacement(93y,117y)
        PenDown
        Displacement(17y,-13y)
        PenUp
        Displacement(-27y,18y)
        PenDown
        Displacement(0y,-54y)
        Displacement(4y,-31y)
        Displacement(10y,-25y)
        Displacement(14y,-13y)
        Displacement(9y,18y)
        PenUp
        Displacement(-9y,59y)
        PenDown
        Displacement(-22y,-46y)
        Displacement(-24y,-25y)
        PenUp
        Displacement(-45y,71y)
        PenDown
        Displacement(54y,0y)
        PenUp
        Displacement(-59y,-20y)
        PenDown
        Displacement(62y,0y)
        PenUp
        Displacement(-17y,-3y)
        PenDown
        Displacement(-4y,-10y)
        Displacement(-11y,-18y)
        Displacement(-27y,-18y)
        PenUp
        Displacement(27y,66y)
        PenDown
        Displacement(-17y,-33y)
        Displacement(41y,-20y)
    ]
    // 巍
    52897us, [
        PenUp
        Displacement(18y,119y)
        PenDown
        yield! Radical.山 92y [18y;33y]
        PenUp
        Displacement(-56y,-13y)
        PenDown
        Displacement(25y,0y)
        Displacement(20y,3y)
        PenUp
        Displacement(-48y,-15y)
        PenDown
        yield! Radical.十 50y [13y;33y]
        PenUp
        Displacement(-3y,18y)
        PenDown
        Displacement(-13y,-10y)
        Displacement(-17y,-8y)
        PenUp
        Displacement(33y,15y)
        PenDown
        Displacement(18y,-13y)
        PenUp
        Displacement(-52y,-15y)
        PenDown
        Displacement(54y,0y)
        PenUp
        Displacement(-23y,13y)
        PenDown
        Displacement(-19y,-23y)
        Displacement(20y,-8y)
        Displacement(17y,-10y)
        PenUp
        Displacement(-5y,25y)
        PenDown
        Displacement(-13y,-18y)
        Displacement(-24y,-15y)
        PenUp
        Displacement(74y,89y)
        PenDown
        Displacement(-6y,-13y)
        PenUp
        Displacement(-13y,0y)
        PenDown
        yield! Radical.日(48y,33y)
        PenUp
        Displacement(24y,15y)
        PenDown
        Displacement(-6y,-38y)
        Displacement(-14y,-20y)
        Displacement(-20y,-20y)
        PenUp
        Displacement(40y,41y)
        PenDown
        Displacement(0y,-31y)
        Displacement(1y,-5y)
        Displacement(14y,-3y)
        Displacement(10y,0y)
        Displacement(6y,8y)
        PenUp
        Displacement(-13y,31y)
        PenDown
        Displacement(-11y,-18y)
        Displacement(19y,0y)
        PenUp
        Displacement(-3y,10y)
        PenDown
        Displacement(6y,-15y)
    ]
    // 微
    52898us, [
        PenUp
        Displacement(29y,121y)
        PenDown
        Displacement(-10y,-13y)
        Displacement(-6y,-8y)
        Displacement(-10y,-10y)
        PenUp
        Displacement(27y,-3y)
        PenDown
        Displacement(-11y,-15y)
        Displacement(-6y-6y,-8y-8y)
        Displacement(-5y,-5y)
        PenUp
        Displacement(17y,13y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(22y,115y)
        PenDown
        yield! Radical.山 36y [28y;33y]
        PenUp
        Displacement(-25y,-20y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-48y,-59y)
        PenDown
        Displacement(9y,10y)
        Displacement(4y,5y)
        Displacement(4y,8y)
        Displacement(1y,5y)
        Displacement(0y,15y)
        Displacement(19y,0y)
        Displacement(0y,-33y)
        Displacement(18y,13y)
        PenUp
        Displacement(15y,87y)
        PenDown
        Displacement(-5y,-20y)
        Displacement(-4y-4y,-10y-10y)
        Displacement(-5y-5y,-8y-8y)
        PenUp
        Displacement(15y,23y)
        PenDown
        Displacement(37y,0y)
        PenUp
        Displacement(-15y,0y)
        PenDown
        Displacement(-3y,-20y)
        Displacement(-4y,-10y)
        Displacement(-4y,-13y)
        Displacement(-3y,-10y)
        Displacement(-5y,-8y)
        Displacement(-6y,-8y)
        Displacement(-8y,-8y)
        Displacement(-10y,-8y)
        Displacement(-9y,-5y)
        PenUp
        Displacement(25y,69y)
        PenDown
        Displacement(4y,-15y)
        Displacement(3y,-8y)
        Displacement(3y,-10y)
        Displacement(5y,-8y)
        Displacement(4y,-5y)
        Displacement(10y,-10y)
        Displacement(9y,-5y)
    ]
    // 危
    52899us, [
        PenUp
        Displacement(50y,126y)
        PenDown
        Displacement(-14y,-20y)
        Displacement(-13y,-10y)
        Displacement(-14y,-8y)
        PenUp
        Displacement(32y,20y)
        PenDown
        Displacement(45y,0y)
        Displacement(-5y,-10y)
        Displacement(-9y,-10y)
        PenUp
        Displacement(43y,-3y)
        PenDown
        Displacement(-88y,0y)
        Displacement(-3y,-28y)
        Displacement(-3y,-13y)
        Displacement(-4y,-13y)
        Displacement(-6y,-13y)
        Displacement(-8y,-15y)
        PenUp
        Displacement(70y,33y)
        PenDown
        Displacement(15y,0y)
        Displacement(4y,5y)
        Displacement(4y,10y)
        Displacement(4y,13y)
        Displacement(-6y-41y,0y)
        Displacement(-5y,-3y)
        Displacement(0y,-54y)
        Displacement(54y,0y)
        Displacement(8y,5y)
        Displacement(3y,8y)
    ]
    // 韦
    52900us, [
        PenUp
        Displacement(14y,98y)
        PenDown
        yield! Radical.中心对齐等距横 [98y;84y] 23y

        PenUp
        Displacement(-97y,-23y)
        PenDown
        Displacement(106y,0y)
        Displacement(-5y,-28y)
        Displacement(-9y,-5y)
        Displacement(-14y,-3y)
        PenUp
        Displacement(-24y,107y)
        PenDown
        Displacement(0y,-122y)
    ]
    // 违
    52901us, [
        PenUp
        Displacement(13y,111y)
        PenDown
        Displacement(19y,-20y)
        PenUp
        Displacement(-31y,-18y)
        PenDown
        Displacement(25y,0y)
        Displacement(-5y,-51y)
        PenUp
        Displacement(-17y,-13y)
        PenDown
        Displacement(9y,5y)
        Displacement(5y,5y)
        Displacement(8y,3y)
        Displacement(5y,-3y)
        Displacement(9y,-8y)
        Displacement(13y,-3y)
        Displacement(66y,0y)
        PenUp
        Displacement(-83y,89y)
        PenDown
        yield! Radical.中心对齐等距横 [76y;69y] 20y

        PenUp
        Displacement(-75y,-20y)
        PenDown
        Displacement(75y,0y)
        Displacement(-3y,-13y)
        Displacement(-4y,-10y)
        Displacement(-3y,-5y)
        Displacement(-18y,0y)
        PenUp
        Displacement(-15y,97y)
        PenDown
        Displacement(0y,-110y)
    ]
    // 桅
    52902us, [
        PenUp
        Displacement(6y,88y)
        PenDown
        yield! Radical.十 46y [36y; 122y]

        PenUp
        Displacement(-1y,87y)
        PenDown
        Displacement(-9y,-23y)
        Displacement(-18y,-28y)
        PenUp
        Displacement(28y,38y)
        PenDown
        Displacement(18y,-18y)
        PenUp
        Displacement(33y,66y)
        PenDown
        Displacement(-9y,-15y)
        Displacement(-17y,-18y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(36y,0y)
        Displacement(-17y,-23y)
        PenUp
        Displacement(33y,0y)
        PenDown
        Displacement(-65y,0y)
        Displacement(0y,-33y)
        Displacement(-3y,-20y)
        Displacement(-5y,-13y)
        Displacement(-10y,-13y)
        PenUp
        Displacement(54y,28y)
        PenDown
        Displacement(14y,3y)
        Displacement(0y,28y)
        Displacement(-29y,0y)
        Displacement(0y,-51y)
        Displacement(5y,-5y)
        Displacement(31y,0y)
        Displacement(9y,18y)
    ]
    // 围
    52903us, [
        PenUp
        Displacement(15y,116y)
        PenDown
        yield! Radical.口(97y,97y)
        PenUp
        Displacement(13y,-21y)
        PenDown

        yield! Radical.中心对齐等距横 [69y;64y] 18y

        PenUp
        Displacement(-68y,-15y)
        PenDown
        Displacement(68y,0y)
        Displacement(0y,-10y)
        Displacement(-4y,-8y)
        Displacement(-4y,-3y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-15y,71y)
        PenDown
        Displacement(0y,-82y)
    ]
    // 唯
    52904us, [
        PenUp
        Displacement(9y,42y)
        PenDown
        yield! Radical.口(29y,-61y)
        PenUp
        Displacement(62y,79y)
        PenDown
        Displacement(-8y-8y,-18y-18y)
        Displacement(-13y,-18y)
        PenUp
        Displacement(15y,25y)
        PenDown
        Displacement(0y,-92y)
        PenUp
        Displacement(25y,120y)
        PenDown
        Displacement(17y,-20y)
        PenUp
        Displacement(-40y,-10y)
        PenDown
        yield! Radical.多横中竖工 [57y;55y;56y;61y] 25y

    ]
    // 惟
    52905us, [
        PenUp
        Displacement(15y,93y)
        PenDown
        Displacement(-9y,-31y)
        PenUp
        Displacement(22y,61y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(10y,97y)
        PenDown
        Displacement(8y,-15y)
        PenUp
        Displacement(27y,41y)
        PenDown
        Displacement(-8y,-20y)
        Displacement(-9y,-18y)
        Displacement(-15y,-20y)
        PenUp
        Displacement(18y,25y)
        PenDown
        Displacement(0y,-89y)
        PenUp
        Displacement(24y,120y)
        PenDown
        Displacement(18y,-18y)
        PenUp
        Displacement(-42y,-13y)
        PenDown
        yield! Radical.多横中竖工 [62y;56y;56y;66y] 25y

    ]
    // 为
    52906us, [
        PenUp
        Displacement(36y,116y)
        PenDown
        Displacement(11y,-20y)
        PenUp
        Displacement(-32y,-13y)
        PenDown
        Displacement(96y,0y)
        Displacement(0y,-64y)
        Displacement(-4y,-8y)
        Displacement(-10y,-3y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-17y,115y)
        PenDown
        Displacement(0y,-25y)
        Displacement(-4y,-25y)
        Displacement(-5y,-15y)
        Displacement(-10y,-15y)
        Displacement(-10y-13y,-10y-13y)
        Displacement(-13y,-8y)
        PenUp
        Displacement(56y,46y)
        PenDown
        Displacement(17y,-18y)
    ]
    // 潍
    52907us, [
        PenUp
        Displacement(9y,119y)
        PenDown
        Displacement(19y,-15y)
        PenUp
        Displacement(-27y,-15y)
        PenDown
        Displacement(20y,-15y)
        PenUp
        Displacement(-15y,-61y)
        PenDown
        Displacement(14y,41y)
        PenUp
        Displacement(25y,66y)
        PenDown
        Displacement(-19y,-38y)
        Displacement(22y,0y)
        PenUp
        Displacement(9y,18y)
        PenDown
        Displacement(-27y,-48y)
        Displacement(27y,3y)
        PenUp
        Displacement(-31y,-31y)
        PenDown
        Displacement(33y,8y)
        PenUp
        Displacement(19y,92y)
        PenDown
        Displacement(-9y,-28y)
        Displacement(-15y,-23y)
        PenUp
        Displacement(15y,23y)
        PenDown
        Displacement(0y,-89y)
        PenUp
        Displacement(4y,94y)
        PenDown
        yield! Radical.多横中竖工 [45y;45y;43y;52y] 27y

        PenUp
        Displacement(-3y,99y)
        PenDown
        Displacement(11y,-15y)
    ]
    // 维
    52908us, [
        PenUp
        Displacement(31y,124y)
        PenDown
        Displacement(-11y,-23y)
        Displacement(-13y,-20y)
        Displacement(28y,0y)
        PenUp
        Displacement(11y,23y)
        PenDown
        Displacement(-14y,-28y)
        Displacement(-14y,-18y)
        Displacement(-9y,-10y)
        Displacement(38y,5y)
        PenUp
        Displacement(-42y,-36y)
        PenDown
        Displacement(45y,15y)
        PenUp
        Displacement(23y,92y)
        PenDown
        Displacement(-11y,-25y)
        Displacement(-9y,-18y)
        Displacement(-10y,-10y)
        PenUp
        Displacement(19y,31y)
        PenDown
        Displacement(0y,-99y)
        PenUp
        Displacement(25y,120y)
        PenDown
        Displacement(17y,-20y)
        PenUp
        Displacement(-40y,-5y)
        PenDown
        yield! Radical.多横中竖工 [59y;55y;55y;65y] 26y
    ]
    // 苇
    52909us, [
        PenUp
        Displacement(4y,108y)
        PenDown
        yield! Radical.艹 (38y,15y) (117y,36y)

        PenUp
        Displacement(-71y,-7y)
        PenDown
        yield! Radical.多横中竖丰 [106y;85y] [20y;35y;94y]

        PenUp
        Displacement(-53y,44y)
        PenDown
        Displacement(98y,0y)
        Displacement(0y,-15y)
        Displacement(-3y,-8y)
        Displacement(-5y,-5y)
        Displacement(-14y,-3y)
    ]
    // 萎
    52910us, [
        PenUp
        Displacement(4y,111y)
        PenDown
        yield! Radical.艹 (34y,15y) (113y,33y)

        PenUp
        Displacement(-56y,3y)
        PenDown
        yield! Radical.多横中竖干 [76y;106y] [15y;36y]            

        PenUp
        Displacement(-6y,20y)
        PenDown
        Displacement(-46y,-25y)
        PenUp
        Displacement(55y,25y)
        PenDown
        Displacement(23y,-15y)
        Displacement(24y,-5y)
        PenUp
        Displacement(-111y,-13y)
        PenDown
        Displacement(119y,0y)
        PenUp
        Displacement(-59y,13y)
        PenDown
        Displacement(-31y,-28y)
        Displacement(48y,-10y)
        Displacement(31y,-13y)
        PenUp
        Displacement(-23y,36y)
        PenDown
        Displacement(-10y,-13y)
        Displacement(-23y,-15y)
        Displacement(-40y,-8y)
    ]
    // 委
    52911us, [
        PenUp
        Displacement(106y,121y)
        PenDown
        Displacement(-37y,-3y)
        Displacement(-46y,0y)
        PenUp
        Displacement(-9y,-23y)
        PenDown
        yield! Radical.十 107y [20y;46y]

        PenUp
        Displacement(-3y,25y)
        PenDown
        Displacement(-18y,-13y)
        Displacement(-36y,-15y)
        PenUp
        Displacement(62y,28y)
        PenDown
        Displacement(46y,-33y)
        PenUp
        Displacement(-57y,5y)
        PenDown
        Displacement(-25y,-31y)
        Displacement(38y,-15y)
        Displacement(40y,-15y)
        PenUp
        Displacement(-23y,41y)
        PenDown
        Displacement(-20y,-23y)
        Displacement(-24y,-8y)
        Displacement(-31y,-5y)
        PenUp
        Displacement(-11y,38y)
        PenDown
        Displacement(119y,0y)
    ]
    // 伟
    52912us, [
        PenUp
        Displacement(40y,124y)
        PenDown
        Displacement(-37y,-59y)
        PenUp
        Displacement(24y,31y)
        PenDown
        Displacement(0y,-92y)
        PenUp
        Displacement(14y,97y)
        PenDown
        yield! Radical.中心对齐等距横 [82y;68y] 23y

        PenUp
        Displacement(-76y,-23y)
        PenDown
        Displacement(78y,0y)
        Displacement(0y,-28y)
        Displacement(-10y,-5y)
        Displacement(-13y,0y)
        PenUp
        Displacement(-15y,104y)
        PenDown
        Displacement(0y,-122y)
    ]
    // 伪
    52913us, [
        PenUp
        Displacement(42y,119y)
        PenDown
        Displacement(-13y,-23y)
        Displacement(-22y,-28y)
        PenUp
        Displacement(19y,25y)
        PenDown
        Displacement(0y,-89y)
        PenUp
        Displacement(29y,115y)
        PenDown
        Displacement(11y,-20y)
        PenUp
        Displacement(18y,23y)
        PenDown
        Displacement(-4y,-36y)
        Displacement(-8y,-25y)
        Displacement(-20y,-40y)
        Displacement(-10y,-10y)
        PenUp
        Displacement(0y,76y)
        PenDown
        Displacement(71y,0y)
        Displacement(0y,-71y)
        Displacement(-8y,-5y)
        Displacement(-18y,-3y)
        PenUp
        Displacement(-8y,51y)
        PenDown
        Displacement(15y,-23y)
    ]
    // 尾
    52914us, [
        PenUp
        Displacement(6y,6y)
        PenDown
        Displacement(8y,13y)
        Displacement(4y,15y)
        Displacement(3y,18y)
        Displacement(0y,66y)
        Displacement(90y,0y)
        Displacement(0y,-23y)
        Displacement(-90y,0y)
        PenUp
        Displacement(82y,-10y)
        PenDown
        Displacement(-51y,-8y)
        Displacement(-11y,0y)
        PenUp
        Displacement(-7y,-17y)
        PenDown
        yield! Radical.中心对齐等距横 [76y;89y] 23y

        PenUp
        Displacement(-48y,41y)
        PenDown
        Displacement(0y,-59y)
        Displacement(3y,-8y)
        Displacement(4y,-3y)
        Displacement(36y,0y)
        Displacement(8y,5y)
        Displacement(4y,10y)
    ]
    // 纬
    52915us, [
        PenUp
        Displacement(37y,124y)
        PenDown
        Displacement(-27y,-43y)
        Displacement(32y,0y)
        PenUp
        Displacement(9y,18y)
        PenDown
        Displacement(-37y,-51y)
        Displacement(36y,5y)
        PenUp
        Displacement(-41y,-33y)
        PenDown
        Displacement(46y,8y)
        PenUp
        Displacement(1y,74y)
        PenDown
        yield! Radical.中心对齐等距横 [69y;61y] 25y

        PenUp
        Displacement(-66y,-23y)
        PenDown
        Displacement(68y,0y)
        Displacement(-3y,-23y)
        Displacement(-3y,-8y)
        Displacement(-11y,-3y)
        Displacement(-5y,0y)
        PenUp
        Displacement(-17y,104y)
        PenDown
        Displacement(0y,-122y)
    ]
    // 未
    52916us, [
        PenUp
        Displacement(17y,96y)
        PenDown
        yield! Radical.多横中竖丰 [85y;110y] [28y;56y;122y]

        PenUp
        Displacement(-4y,64y)
        PenDown
        Displacement(-6y,-13y)
        Displacement(-10y,-13y)
        Displacement(-20y,-20y)
        Displacement(-13y,-8y)
        PenUp
        Displacement(60y,54y)
        PenDown
        Displacement(8y,-10y)
        Displacement(9y,-10y)
        Displacement(22y,-20y)
        Displacement(13y,-8y)
    ]
    // 蔚
    52917us, [
        PenUp
        Displacement(6y,108y)
        PenDown
        yield! Radical.艹 (38y,15y) (115y,28y)

        PenUp
        Displacement(-64y,-25y)
        PenDown
        Displacement(47y,0y)
        Displacement(0y,20y)
        Displacement(-47y,0y)
        Displacement(0y,-33y)
        Displacement(-3y,-18y)
        Displacement(-3y,-13y)
        Displacement(-8y,-13y)
        PenUp
        Displacement(23y,43y)
        PenDown
        yield! Radical.中心对齐等距横 [38y;50y] 15y

        PenUp
        Displacement(-37y,-8y)
        PenDown
        Displacement(-11y,-20y)
        PenUp
        Displacement(24y,25y)
        PenDown
        Displacement(0y,-25y)
        Displacement(-4y,-8y)
        Displacement(-13y,0y)
        PenUp
        Displacement(29y,28y)
        PenDown
        Displacement(13y,-20y)
        PenUp
        Displacement(1y,36y)
        PenDown
        Displacement(14y,-18y)
        PenUp
        Displacement(-18y,33y)
        PenDown
        Displacement(47y,0y)
        PenUp
        Displacement(-17y,28y)
        PenDown
        Displacement(0y,-76y)
        Displacement(-4y,-8y)
        Displacement(-15y,-3y)
    ]
    // 味
    52918us, [
        PenUp
        Displacement(6y,41y)
        PenDown
        yield! Radical.口(29y,-64y)
        PenUp
        Displacement(42y,56y)
        PenDown
        yield! Radical.多横中竖丰 [61y;73y] [33y;59y;122y]

        PenUp
        Displacement(-3y,61y)
        PenDown
        Displacement(-10y,-18y)
        Displacement(-13y,-13y)
        Displacement(-11y,-13y)
        Displacement(-9y,-8y)
        PenUp
        Displacement(50y,51y)
        PenDown
        Displacement(8y,-15y)
        Displacement(9y,-13y)
        Displacement(9y,-8y)
        Displacement(8y,-8y)
        Displacement(5y,-5y)
    ]
    // 畏
    52919us, [
        PenUp
        Displacement(29y,119y)
        PenDown
        yield! Radical.田(76y,44y)
        PenUp
        Displacement(59y,-18y)
        PenDown
        Displacement(-116y,0y)
        PenUp
        Displacement(23y,-3y)
        PenDown
        Displacement(0y,-48y)
        Displacement(36y,23y)
        PenUp
        Displacement(40y,20y)
        PenDown
        Displacement(-24y,-18y)
        PenUp
        Displacement(-20y,23y)
        PenDown
        Displacement(14y,-18y)
        Displacement(15y,-13y)
        Displacement(28y,-15y)
    ]
    // 胃
    52920us, [        
        PenUp
        Displacement(15y,121y)
        PenDown
        yield! Radical.田(93y,38y)

        PenUp
        Displacement(-37y,-82y)
        PenDown
        yield! Radical.青月(80y,66y)

    ]
    // 喂
    52921us, [
        PenUp
        Displacement(9y,110y)
        PenDown
        yield! Radical.口(25y,61y)
        PenUp
        Displacement(48y,7y)
        PenDown
        yield! Radical.田(50y,43y)

        PenUp
        Displacement(-38y,-18y)
        PenDown
        Displacement(78y,0y)
        PenUp
        Displacement(-62y,0y)
        PenDown
        Displacement(0y,-51y)
        Displacement(25y,18y)
        PenUp
        Displacement(-4y,31y)
        PenDown
        Displacement(8y,-15y)
        Displacement(8y,-10y)
        Displacement(9y,-10y)
        Displacement(14y,-10y)
        PenUp
        Displacement(-9y,38y)
        PenDown
        Displacement(-15y,-13y)
    ]
    // 魏
    52922us, [
        PenUp
        Displacement(51y,113y)
        PenDown
        Displacement(-43y,0y)
        PenUp
        Displacement(-4y,-18y)
        PenDown
        yield! Radical.十 50y [15y;46y]

        PenUp
        Displacement(-1y,25y)
        PenDown
        Displacement(-24y,-28y)
        PenUp
        Displacement(23y,25y)
        PenDown
        Displacement(25y,-20y)
        PenUp
        Displacement(-51y,-18y)
        PenDown
        Displacement(51y,0y)
        PenUp
        Displacement(-24y,13y)
        PenDown
        Displacement(-14y,-25y)
        Displacement(32y,-20y)
        PenUp
        Displacement(-1y,31y)
        PenDown
        Displacement(-11y,-18y)
        Displacement(-13y,-13y)
        Displacement(-17y,-10y)
        PenUp
        Displacement(80y,115y)
        PenDown
        Displacement(-13y,-13y)
        PenUp
        Displacement(-10y,-3y)
        PenDown
        yield! Radical.日(48y,46y)
        PenUp
        Displacement(24y,23y)
        PenDown

        Displacement(0y,-41y)
        Displacement(-5y,-18y)
        Displacement(-9y,-20y)
        Displacement(-11y,-8y)
        Displacement(-14y,-10y)
        Displacement(-3y,-3y)
        PenUp
        Displacement(43y,46y)
        PenDown
        Displacement(0y,-38y)
        Displacement(1y,-5y)
        Displacement(25y,0y)
        Displacement(5y,10y)
        PenUp
        Displacement(-11y,31y)
        PenDown
        Displacement(-11y,-20y)
        Displacement(19y,0y)
        PenUp
        Displacement(-4y,13y)
        PenDown
        Displacement(5y,-18y)
    ]
    // 位
    52923us, [
        PenUp
        Displacement(32y,124y)
        PenDown
        Displacement(-13y,-31y)
        Displacement(-18y,-28y)
        PenUp
        Displacement(19y,28y)
        PenDown
        Displacement(0y,-92y)
        PenUp
        Displacement(41y,122y)
        PenDown
        Displacement(22y,-23y)
        PenUp
        Displacement(-46y,-8y)
        PenDown
        Displacement(84y,0y)
        PenUp
        Displacement(-70y,-18y)
        PenDown
        Displacement(15y,-46y)
        PenUp
        Displacement(37y,48y)
        PenDown
        Displacement(-10y,-36y)
        Displacement(-14y,-28y)
        PenUp
        Displacement(-47y,-3y)
        PenDown
        Displacement(94y,0y)
    ]
    // 渭
    52924us, [
        PenUp
        Displacement(14y,119y)
        PenDown
        Displacement(20y,-13y)
        PenUp
        Displacement(-28y,-13y)
        PenDown
        Displacement(22y,-18y)
        PenUp
        Displacement(5y,-18y)
        PenDown
        Displacement(-10y,-20y)
        Displacement(-15y,-20y)
        PenUp
        Displacement(43y,104y)
        PenDown
        yield! Radical.田(62y,38y)
        PenUp
        Displacement(-28y,-76y)
        PenDown
        yield! Radical.青月(57y,61y)

    ]
    // 谓
    52925us, [
        PenUp
        Displacement(14y,119y)
        PenDown
        Displacement(24y,-15y)
        PenUp
        Displacement(-36y,-23y)
        PenDown
        Displacement(23y,0y)
        Displacement(0y,-74y)
        Displacement(23y,31y)

        PenUp
        Displacement(3y,79y)
        PenDown
        yield! Radical.田(66y,38y)

        PenUp
        Displacement(-29y,-76y)
        PenDown
        yield! Radical.青月(59y,59y)

    ]
    // 尉
    52926us, [
        PenUp
        Displacement(1y,11y)
        PenDown
        Displacement(6y,18y)
        Displacement(5y,23y)
        Displacement(3y,20y)
        Displacement(0y,46y)
        Displacement(51y,0y)
        Displacement(0y,-23y)
        Displacement(-51y,0y)
        PenUp
        Displacement(14y,-20y)
        PenDown
        yield! Radical.中心对齐等距横 [41y;55y] 20y

        PenUp
        Displacement(-42y,-13y)
        PenDown
        Displacement(-15y,-23y)
        PenUp
        Displacement(29y,36y)
        PenDown
        Displacement(0y,-43y)
        Displacement(-1y,-3y)
        Displacement(-5y,-3y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(31y,38y)
        PenDown
        Displacement(15y,-18y)
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(50y,0y)
        PenUp
        Displacement(-18y,38y)
        PenDown
        Displacement(0y,-112y-5y)
        Displacement(-16y,-6y)
        Displacement(-8y,3y)
        PenUp
        Displacement(-8y,64y)
        PenDown
        Displacement(18y,-20y)
    ]
    // 慰
    52927us, [
        PenUp
        Displacement(4y,50y)
        PenDown
        Displacement(5y,10y)
        Displacement(5y,13y)
        Displacement(3y,20y)
        Displacement(3y,28y)
        Displacement(47y,0y)
        Displacement(0y,-15y)
        Displacement(-47y,0y)
        PenUp
        Displacement(10y,-18y)
        PenDown
        yield! Radical.中心对齐等距横 [37y;48y] 15y

        PenUp
        Displacement(-38y,-8y)
        PenDown
        Displacement(-15y,-18y)
        PenUp
        Displacement(28y,25y)
        PenDown
        Displacement(0y,-25y)
        Displacement(-3y,-3y)
        Displacement(-10y,-3y)
        PenUp
        Displacement(24y,23y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(5y,33y)
        PenDown
        Displacement(14y,-18y)
        PenUp
        Displacement(-18y,31y)
        PenDown
        Displacement(52y,0y)
        PenUp
        Displacement(-20y,31y)
        PenDown
        Displacement(0y,-74y)
        Displacement(-1y,-5y)
        Displacement(-6y,-3y)
        Displacement(-10y,0y)
        PenUp
        Displacement(-69y,-13y)
        PenDown
        Displacement(-6y,-13y)
        Displacement(-10y,-15y)
        PenUp
        Displacement(36y,28y)
        PenDown
        Displacement(0y,-18y)
        Displacement(3y,-5y)
        Displacement(6y,-3y)
        Displacement(32y,0y)
        Displacement(5y,3y)
        Displacement(5y,13y)
        PenUp
        Displacement(-33y,15y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(31y,10y)
        PenDown
        Displacement(19y,-23y)
    ]
    // 卫
    52928us, [
        PenUp
        Displacement(15y,108y)
        PenDown
        Displacement(84y,0y)
        Displacement(0y,-51y)
        Displacement(-5y,-8y)
        Displacement(-13y,-3y)
        Displacement(-13y,0y)
        PenUp
        Displacement(-19y,56y)
        PenDown
        yield! Radical.丄 [48y;119y] 87y

    ]
    // 瘟
    52929us, [
        PenUp
        Displacement(61y,124y)
        PenDown
        Displacement(17y,-15y)
        PenUp
        Displacement(-69y,-13y)
        PenDown
        Displacement(13y,-20y)
        PenUp
        Displacement(-20y,-25y)
        PenDown
        Displacement(25y,13y)
        PenUp
        Displacement(94y,43y)
        PenDown
        Displacement(-93y,0y)
        Displacement(0y,-48y)
        Displacement(-4y,-25y)
        Displacement(-9y,-18y)
        Displacement(-10y,-8y)
        PenUp
        Displacement(35y,84y)
        PenDown
        yield! Radical.日(57y,33y)
        PenUp
        Displacement(-4y,-66y)
        PenDown
        yield! Radical.皿 [69y;99y] 33y

    ]
    // 温
    52930us, [
        PenUp
        Displacement(14y,119y)
        PenDown
        Displacement(22y,-15y)
        PenUp
        Displacement(-29y,-15y)
        PenDown
        Displacement(22y,-15y)
        PenUp
        Displacement(3y,-15y)
        PenDown
        Displacement(-24y,-48y)
        PenUp
        Displacement(38y,104y)
        PenDown
        yield! Radical.日(54y,41y)
        PenUp
        Displacement(-6y,-82y)
        PenDown
        yield! Radical.皿 [66y;99y] 41y

    ]
    // 蚊
    52931us, [
        PenUp
        Displacement(8y,58y+38y)
        PenDown
        yield! Radical.中 38y [38y;28y;94y]

        PenUp
        Displacement(-25y,-10y)
        PenDown
        Displacement(45y,15y)
        PenUp
        Displacement(-5y,13y)
        PenDown
        Displacement(14y,-28y)
        PenUp
        Displacement(18y,104y)
        PenDown
        Displacement(18y,-23y)
        PenUp
        Displacement(-38y,-8y)
        PenDown
        Displacement(68y,0y)
        PenUp
        Displacement(-19y,-3y)
        PenDown
        Displacement(-3y,-23y)
        Displacement(-9y,-25y)
        Displacement(-15y,-18y)
        Displacement(-13y,-10y)
        Displacement(-19y,-10y)
        PenUp
        Displacement(23y,79y)
        PenDown
        Displacement(6y,-23y)
        Displacement(14y,-23y)
        Displacement(15y,-15y)
        Displacement(19y,-15y)
    ]
    // 文
    52932us, [
        PenUp
        Displacement(50y,124y)
        PenDown
        Displacement(22y,-18y)
        PenUp
        Displacement(-69y,-8y)
        PenDown
        Displacement(117y,0y)
        PenUp
        Displacement(-33y,0y)
        PenDown
        Displacement(-11y,-41y)
        Displacement(-13y,-18y)
        Displacement(-31y,-20y)
        Displacement(-28y,-15y)
        PenUp
        Displacement(27y,84y)
        PenDown
        Displacement(29y,-46y)
        Displacement(31y,-23y)
        Displacement(28y,-13y)
    ]
    // 闻
    52933us, [
        PenUp
        Displacement(15y,2y)
        PenDown
        yield! Radical.门(94y,110y)
        PenUp
        Displacement(-62y,74y)
        PenDown
        yield! Radical.耳 [73y;41y;79y] [51y;79y]

    ]
    // 纹
    52934us, [
        PenUp
        Displacement(31y,121y)
        PenDown
        Displacement(-13y,-20y)
        Displacement(-11y,-20y)
        Displacement(31y,0y)
        PenUp
        Displacement(14y,23y)
        PenDown
        Displacement(-42y,-54y)
        Displacement(43y,0y)
        PenUp
        Displacement(-47y,-31y)
        PenDown
        Displacement(48y,10y)
        PenUp
        Displacement(18y,94y)
        PenDown
        Displacement(20y,-23y)
        PenUp
        Displacement(-33y,-10y)
        PenDown
        Displacement(66y,0y)
        PenUp
        Displacement(-20y,-3y)
        PenDown
        Displacement(-6y,-28y)
        Displacement(-11y,-25y)
        Displacement(-13y,-13y)
        Displacement(-15y,-10y)
        Displacement(-17y,-8y)
        PenUp
        Displacement(24y,74y)
        PenDown
        Displacement(11y,-28y)
        Displacement(6y,-18y)
        Displacement(17y,-15y)
        Displacement(20y,-13y)
    ]
    // 吻
    52935us, [
        PenUp
        Displacement(10y,41y)
        PenDown
        yield! Radical.口(25y,-59y)
        PenUp
        Displacement(57y,82y)
        PenDown
        Displacement(-28y,-48y)
        PenUp
        Displacement(19y,23y)
        PenDown
        Displacement(51y,0y)
        Displacement(0y,-76y)
        Displacement(-6y,-8y)
        Displacement(-19y,-5y)
        PenUp
        Displacement(-10y,89y)
        PenDown
        Displacement(-9y,-28y)
        Displacement(-22y,-28y)
        PenUp
        Displacement(51y,56y)
        PenDown
        Displacement(-4y,-28y)
        Displacement(-10y,-25y)
        Displacement(-29y,-28y)
    ]
    // 稳
    52936us, [
        PenUp
        Displacement(46y,119y)
        PenDown
        Displacement(-41y,-5y)
        PenUp
        Displacement(-4y,-33y)
        PenDown
        yield! Radical.十 43y [31y;110y]

        PenUp
        Displacement(-1y,71y)
        PenDown
        Displacement(-23y,-38y)
        PenUp
        Displacement(25y,33y)
        PenDown
        Displacement(18y,-20y)
        PenUp
        Displacement(28y,76y)
        PenDown
        Displacement(-25y,-36y)
        PenUp
        Displacement(18y,20y)
        PenDown
        Displacement(32y,0y)
        Displacement(-13y,-18y)
        PenUp
        Displacement(-32y,-3y)
        PenDown
        yield! Radical.彐(54y,33y)
        PenUp
        Displacement(-1y,-31y)
        PenDown
        Displacement(-14y,-25y)
        PenUp
        Displacement(40y,33y)
        PenDown
        Displacement(13y,-18y)
        PenUp
        Displacement(15y,13y)
        PenDown
        Displacement(17y,-25y)
        PenUp
        Displacement(-57y,25y)
        PenDown
        Displacement(0y,-28y)
        Displacement(1y,-5y)
        Displacement(28y,3y)
        Displacement(5y,8y)
    ]
    // 紊
    52937us, [
        PenUp
        Displacement(55y,121y)
        PenDown
        Displacement(15y,-15y)
        PenUp
        Displacement(-61y,-5y)
        PenDown
        Displacement(110y,0y)
        PenUp
        Displacement(-25y,0y)
        PenDown
        Displacement(-22y,-18y)
        Displacement(-25y,-10y)
        Displacement(-42y,-8y)
        PenUp
        Displacement(37y,31y)
        PenDown
        Displacement(24y,-15y)
        Displacement(29y,-10y)
        Displacement(29y,-8y)
        PenUp
        Displacement(-62y,8y)
        PenDown
        Displacement(-27y,-18y)
        Displacement(36y,0y)
        PenUp
        Displacement(19y,10y)
        PenDown
        Displacement(-60y,-28y)
        Displacement(68y,0y)
        PenUp
        Displacement(-11y,13y)
        PenDown
        Displacement(25y,-18y)
        PenUp
        Displacement(-46y,0y)
        PenDown
        Displacement(0y,-18y)
        Displacement(-4y,-5y)
        Displacement(-14y,-3y)
        PenUp
        Displacement(0y,20y)
        PenDown
        Displacement(-15y,-8y)
        Displacement(-22y,-10y)
        PenUp
        Displacement(71y,18y)
        PenDown
        Displacement(38y,-18y)
    ]
    // 问
    52938us, [
        PenUp
        Displacement(15y,4y)
        PenDown
        yield! Radical.门(98y,109y)
        PenUp
        Displacement(-50y,65y)
        PenDown
        yield! Radical.口(43y,46y)
    ]
    // 嗡
    52939us, [
        PenUp
        Displacement(6y,42y)
        PenDown
        yield! Radical.口(23y,-69y)

        PenUp
        Displacement(60y,84y)
        PenDown
        Displacement(-32y,-36y)
        PenUp
        Displacement(51y,36y)
        PenDown
        Displacement(34y,-33y)
        PenUp
        Displacement(-42y,18y)
        PenDown
        Displacement(-25y,-33y)
        Displacement(45y,8y)
        PenUp
        Displacement(-10y,13y)
        PenDown
        Displacement(19y,-23y)
        PenUp
        Displacement(-68y,-10y)
        PenDown
        Displacement(29y,0y)
        Displacement(0y,-54y)
        Displacement(-3y,-5y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-10y,48y)
        PenDown
        Displacement(14y,-13y)
        PenUp
        Displacement(-23y,-20y)
        PenDown
        Displacement(32y,15y)
        PenUp
        Displacement(13y,31y)
        PenDown
        Displacement(29y,0y)
        Displacement(0y,-51y)
        Displacement(-4y,-5y)
        Displacement(-11y,-5y)
        PenUp
        Displacement(-14y,51y)
        PenDown
        Displacement(15y,-13y)
        PenUp
        Displacement(-15y,-18y)
        PenDown
        Displacement(28y,15y)
    ]
    // 翁
    52940us, [
        PenUp
        Displacement(45y,116y)
        PenDown
        Displacement(-13y,-13y)
        Displacement(-10y,-8y)
        Displacement(-17y,-13y)
        PenUp
        Displacement(74y,36y)
        PenDown
        Displacement(10y,-13y)
        Displacement(9y,-5y)
        Displacement(11y,-8y)
        Displacement(14y,-8y)
        PenUp
        Displacement(-64y,20y)
        PenDown
        Displacement(-10y,-15y)
        Displacement(-10y,-10y)
        Displacement(-9y,-5y)
        Displacement(52y,0y)
        PenUp
        Displacement(-9y,18y)
        PenDown
        Displacement(20y,-23y)
        PenUp
        Displacement(-85y,-13y)
        PenDown
        Displacement(45y,0y)
        Displacement(0y,-46y)
        Displacement(-1y,-3y)
        Displacement(-4y,-5y)
        Displacement(-5y,-3y)
        Displacement(-8y,0y)
        PenUp
        Displacement(27y,56y)
        PenDown
        Displacement(43y,0y)
        Displacement(0y,-46y)
        Displacement(-1y,-5y)
        Displacement(-5y,-3y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-69y,48y)
        PenDown
        Displacement(14y,-18y)
        PenUp
        Displacement(-27y,-15y)
        PenDown
        Displacement(40y,13y)
        PenUp
        Displacement(22y,18y)
        PenDown
        Displacement(17y,-13y)
        PenUp
        Displacement(-23y,-18y)
        PenDown
        Displacement(37y,15y)
    ]
    // 瓮
    52941us, [
        PenUp
        Displacement(43y,124y)
        PenDown
        Displacement(-8y,-10y)
        Displacement(-9y,-10y)
        Displacement(-10y,-8y)
        Displacement(-14y,-8y)
        PenUp
        Displacement(71y,38y)
        PenDown
        Displacement(8y,-8y)
        Displacement(5y,-8y)
        Displacement(9y,-8y)
        Displacement(9y,-5y)
        Displacement(6y,-3y)
        Displacement(9y,-5y)
        PenUp
        Displacement(-61y,18y)
        PenDown
        Displacement(-9y-9y,-10y-10y)
        Displacement(-11y,-10y)
        Displacement(15y+11y,0y)
        Displacement(13y,3y)
        Displacement(15y,3y)
        PenUp
        Displacement(-14y,18y)
        PenDown
        Displacement(11y,-13y)
        Displacement(14y,-15y)
        PenUp
        Displacement(-93y,-8y)
        PenDown
        Displacement(116y,0y)
        PenUp
        Displacement(-84y,-3y)
        PenDown
        Displacement(-5y,-23y)
        Displacement(-5y,-18y)
        Displacement(-6y,-18y)
        Displacement(40y,10y)
        PenUp
        Displacement(-15y,20y)
        PenDown
        Displacement(31y,-15y)
        PenUp
        Displacement(-41y,28y)
        PenDown
        Displacement(54y,0y)
        Displacement(0y,-33y)
        Displacement(1y,-5y)
        Displacement(4y,-5y)
        Displacement(17y+5y,0y)
        Displacement(3y,5y)
        Displacement(4y,13y)
    ]
    // 挝
    52942us, [
        PenUp
        Displacement(0y,96y)
        PenDown
        yield! Radical.十 42y [31y;107y]
        Displacement(-5y,-8y)
        Displacement(-4y,0y)
        Displacement(-8y,-3y)
        PenUp
        Displacement(-5y,43y)
        PenDown
        Displacement(36y,20y)
        PenUp
        Displacement(29y,20y)
        PenDown
        Displacement(52y,0y)
        PenUp
        Displacement(-19y,33y)
        PenDown
        Displacement(0y,-92y)
        Displacement(-4y,-5y)
        Displacement(-6y,-5y)
        Displacement(-8y,3y)
        PenUp
        Displacement(-10y,54y)
        PenDown
        Displacement(13y,-25y)
        PenUp
        Displacement(-41y,64y)
        PenDown
        Displacement(14y,-25y)
        PenUp
        Displacement(-17y,-20y)
        PenDown
        Displacement(14y,0y)
        Displacement(0y,-43y)
        PenUp
        Displacement(-18y,-13y)
        PenDown
        Displacement(8y,8y)
        Displacement(8y,3y)
        Displacement(5y,-3y)
        Displacement(9y+9y,-5y-5y)
        Displacement(11y,-3y)
        Displacement(36y,0y)
    ]
    // 蜗
    52943us, [
        PenUp
        Displacement(10y,61y+38y)
        PenDown
        yield! Radical.中 36y [38y;28y;97y]
        PenUp
        Displacement(-24y,-8y)
        PenDown
        Displacement(45y,10y)
        PenUp
        Displacement(-6y,15y)
        PenDown
        Displacement(13y,-28y)
        PenUp
        Displacement(11y,69y)
        PenDown
        yield! Radical.口(45y,-31y)

        PenUp
        Displacement(-4y,-82y)
        PenDown
        Displacement(0y,59y)
        Displacement(54y,0y)
        Displacement(0y,-51y)
        Displacement(-3y,-5y)
        Displacement(-10y,-3y)
        PenUp
        Displacement(-15y,79y)
        PenDown
        Displacement(0y,-25y)
        Displacement(-6y,-13y)
        Displacement(-10y,-13y)
        PenUp
        Displacement(18y,20y)
        PenDown
        Displacement(19y,-20y)
    ]
    // 涡
    52944us, [
        PenUp
        Displacement(14y,121y)
        PenDown
        Displacement(25y,-20y)
        PenUp
        Displacement(-34y,-13y)
        PenDown
        Displacement(24y,-18y)
        PenUp
        Displacement(-20y,-61y)
        PenDown
        Displacement(8y,13y)
        Displacement(10y,13y)
        Displacement(8y,15y)
        PenUp
        Displacement(20y,36y)
        PenDown
        yield! Radical.口(54y,-31y)

        PenUp
        Displacement(-8y,-84y)
        PenDown
        Displacement(0y,64y)
        Displacement(69y,0y)
        Displacement(0y,-48y)
        Displacement(-3y,-5y)
        Displacement(-8y,-3y)
        Displacement(-6y,-3y)
        PenUp
        Displacement(-17y,79y)
        PenDown
        Displacement(1y,-13y)
        Displacement(-3y,-13y)
        Displacement(-6y,-13y)
        Displacement(-8y,-10y)
        Displacement(-11y,-10y)
        PenUp
        Displacement(24y,25y)
        PenDown
        Displacement(28y,-20y)
    ]
    // 窝
    52945us, [
        PenUp
        Displacement(51y,126y)
        PenDown
        Displacement(22y,-15y)
        PenUp
        Displacement(-62y,-20y)
        PenDown
        yield! Radical.冖(104y,15y)

        PenUp
        Displacement(-65y,8y)
        PenDown
        Displacement(-11y,-8y)
        Displacement(-15y,-8y)
        Displacement(-9y,-5y)
        PenUp
        Displacement(64y,20y)
        PenDown
        Displacement(20y,-8y)
        Displacement(15y,-5y)
        PenUp
        Displacement(-80y,-5y)
        PenDown
        yield! Radical.口(61y,18y)

        PenUp
        Displacement(-14y,-74y)
        PenDown
        Displacement(0y,36y)
        Displacement(92y,0y)
        Displacement(0y,-31y)
        Displacement(-6y,-5y)
        Displacement(-13y,0y)
        PenUp
        Displacement(-25y,54y)
        PenDown
        Displacement(-5y,-18y)
        Displacement(-6y,-13y)
        Displacement(-19y,-10y)
        PenUp
        Displacement(27y,18y)
        PenDown
        Displacement(28y,-13y)
    ]
    // 我
    52946us, [
        PenUp
        Displacement(62y,113y)
        PenDown
        Displacement(-23y,-5y)
        Displacement(-25y,0y)
        PenUp
        Displacement(-11y,-25y)
        PenDown
        Displacement(119y,0y)
        PenUp
        Displacement(-82y,28y)
        PenDown
        Displacement(0y,-97y)
        Displacement(-4y,-8y)
        Displacement(-14y,-3y)
        PenUp
        Displacement(-17y,33y)
        PenDown
        Displacement(60y,23y)
        PenUp
        Displacement(13y,64y)
        PenDown
        Displacement(0y,-46y)
        Displacement(6y,-31y)
        Displacement(8y,-20y)
        Displacement(10y,-18y)
        Displacement(9y,-5y)
        Displacement(9y,15y)
        PenUp
        Displacement(-13y,51y)
        PenDown
        Displacement(-18y,-33y)
        Displacement(-13y,-15y)
        Displacement(-25y,-15y)
        PenUp
        Displacement(38y,107y)
        PenDown
        Displacement(23y,-20y)
    ]
    // 斡
    52947us, [
        PenUp
        Displacement(4y,103y)
        PenDown
        yield! (id<十早> {
                十 = 56y,36y
                日 = 38y,33y
                横 = 55y,18y
                竖 = 46y
            }).toYield()
        PenUp
        Displacement(60y,120y)
        PenDown
        Displacement(-13y,-20y)
        Displacement(-18y,-20y)
        PenUp
        Displacement(31y,38y)
        PenDown
        Displacement(13y,-18y)
        Displacement(20y,-23y)
        PenUp
        Displacement(-47y,3y)
        PenDown
        Displacement(11y,-15y)
        PenUp
        Displacement(-20y,-8y)
        PenDown
        Displacement(14y,-18y)
        PenUp
        Displacement(-20y,-15y)
        PenDown
        Displacement(61y,13y)
        PenUp
        Displacement(-23y,51y)
        PenDown
        Displacement(0y,-87y)
    ]
    // 卧
    52948us, [
        PenUp
        Displacement(34y+31y,116y)
        PenDown
        yield! Radical.臣(62y,107y) (51y,33y)

        PenUp
        Displacement(48y,117y)
        PenDown
        Displacement(0y,-125y)
        PenUp
        Displacement(9y,79y)
        PenDown
        Displacement(31y,-31y)
    ]
    // 握
    52949us, [
        PenUp
        Displacement(5y,90y)
        PenDown
        Displacement(38y,0y)
        PenUp
        Displacement(-18y,31y)
        PenDown
        Displacement(0y,-99y-10y)
        Displacement(-5y,-5y)
        Displacement(-5y-6y,0y)
        PenUp
        Displacement(-4y,41y)
        PenDown
        Displacement(36y,20y)
        PenUp
        Displacement(13y,23y)
        PenDown
        Displacement(56y,0y)
        Displacement(0y,25y)
        Displacement(-59y,0y)
        Displacement(0y,-61y)
        Displacement(-1y,-13y)
        Displacement(-3y,-13y)
        Displacement(-5y,-13y)
        Displacement(-5y,-8y)
        PenUp
        Displacement(22y,66y)
        PenDown
        Displacement(59y,0y)
        PenUp
        Displacement(-34y,-3y)
        PenDown
        Displacement(-19y,-23y)
        Displacement(43y,5y)
        PenUp
        Displacement(-9y,15y)
        PenDown
        Displacement(19y,-23y)
        PenUp
        Displacement(-59y,-15y)
        PenDown
        yield! Radical.多横中竖士 [56y;74y] [23y;38y]

    ]
    // 沃
    52950us, [
        PenUp
        Displacement(11y,113y)
        PenDown
        Displacement(31y,-13y)
        PenUp
        Displacement(-37y,-15y)
        PenDown
        Displacement(24y,-13y)
        PenUp
        Displacement(-22y,-66y)
        PenDown
        Displacement(23y,48y)
        PenUp
        Displacement(84y,59y)
        PenDown
        Displacement(-22y,-5y)
        Displacement(-24y,-3y)
        Displacement(-23y,0y)
        PenUp
        Displacement(-5y,-41y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-42y,38y)
        PenDown
        Displacement(-6y,-35y)
        Displacement(-8y,-31y)
        Displacement(-9y,-15y)
        Displacement(-25y,-19y)
        PenUp
        Displacement(52y,54y)
        PenDown
        Displacement(11y,-20y)
        Displacement(10y,-14y)
        Displacement(16y,-18y)
    ]
    // 巫
    52951us, [
        PenUp
        Displacement(9y,119y)
        PenDown
        yield! Radical.多横中竖工 [104y;116y] 98y
        PenUp
        Displacement(-80y,81y)
        PenDown

        Displacement(-5y,-20y)
        Displacement(-6y,-13y)
        Displacement(-8y,-10y)
        Displacement(-9y,-13y)
        PenUp
        Displacement(20y,33y)
        PenDown
        Displacement(23y,-23y)
        PenUp
        Displacement(43y,46y)
        PenDown
        Displacement(-3y,-18y)
        Displacement(-5y,-15y)
        Displacement(-8y,-10y)
        Displacement(-9y,-15y)
        PenUp
        Displacement(19y,36y)
        PenDown
        Displacement(11y,-13y)
        Displacement(8y,-10y)
        Displacement(6y,-5y)
    ]
    // 呜
    52952us, [
        PenUp
        Displacement(14y,42y)
        PenDown
        yield! Radical.口(28y,-61y)
        PenUp
        Displacement(68y,79y)
        PenDown
        Displacement(-6y,-13y)
        PenUp
        Displacement(13y,-38y)
        PenDown
        Displacement(6y,0y)
        Displacement(6y,3y)
        Displacement(5y,5y)
        Displacement(1y,5y)
        Displacement(0y,20y)
        Displacement(-45y,0y)
        Displacement(0y,-51y)
        Displacement(55y,0y)
        Displacement(0y,-31y)
        Displacement(-1y,-8y)
        Displacement(-5y,-5y)
        Displacement(-8y,-5y)
        Displacement(-5y,0y)
        Displacement(-6y,-3y)
        PenUp
        Displacement(-50y,25y)
        PenDown
        Displacement(60y,0y)
    ]
    // 钨
    52953us, [
        PenUp
        Displacement(31y,126y)
        PenDown
        Displacement(-27y,-41y)
        PenUp
        Displacement(15y,18y)
        PenDown
        Displacement(37y,0y)
        PenUp
        Displacement(-45y,-23y)
        PenDown
        Displacement(38y,0y)
        PenUp
        Displacement(-46y,-31y)
        PenDown
        Displacement(51y,0y)
        PenUp
        Displacement(-27y,31y)
        PenDown
        Displacement(0y,-69y)
        Displacement(25y,18y)
        PenUp
        Displacement(33y,97y)
        PenDown
        Displacement(-9y,-15y)
        PenUp
        Displacement(10y,-38y)
        PenDown
        Displacement(4y,3y)
        Displacement(9y,3y)
        Displacement(6y,5y)
        Displacement(0y,23y)
        Displacement(-42y,0y)
        Displacement(0y,-51y)
        Displacement(52y,0y)
        Displacement(-4y,-41y)
        Displacement(-6y,-5y)
        Displacement(-15y,-3y)
        PenUp
        Displacement(-34y,25y)
        PenDown
        Displacement(46y,0y)
    ]
    // 乌
    52954us, [
        PenUp
        Displacement(57y,124y)
        PenDown
        Displacement(-13y,-18y)
        PenUp
        Displacement(22y,-36y)
        PenDown
        Displacement(24y,13y)
        Displacement(0y,20y)
        Displacement(-65y,0y)
        Displacement(0y,-46y)
        Displacement(84y,0y)
        Displacement(0y,-43y)
        Displacement(-11y,-8y)
        Displacement(-17y,-5y)
        PenUp
        Displacement(-78y,28y)
        PenDown
        Displacement(90y,0y)
    ]
    // 污
    52955us, [
        PenUp
        Displacement(38y,75y)
        PenDown
        yield! Radical.中心对齐等距横 [84y;47y] 33y

        PenUp
        Displacement(-37y,-33y)
        PenDown
        Displacement(0y,-23y)
        Displacement(42y,0y)
        Displacement(0y,-36y)
        Displacement(-9y,-5y)
        Displacement(-25y,0y)
        PenUp
        Displacement(-65y,71y)
        PenDown
        Displacement(19y,-15y)
        PenUp
        Displacement(-11y,43y)
        PenDown
        Displacement(20y,-13y)
        PenUp
        Displacement(-23y,-87y)
        PenDown
        Displacement(20y,41y)
    ]
    // 诬
    52956us, [
        PenUp
        Displacement(14y,119y)
        PenDown
        Displacement(22y,-20y)
        PenUp
        Displacement(-33y,-20y)
        PenDown
        Displacement(22y,0y)
        Displacement(0y,-76y)
        Displacement(23y,31y)
        PenUp
        Displacement(-4y,79y)
        PenDown
        yield! Radical.多横中竖工 [75y;85y] 100y

        PenUp
        Displacement(-65y,82y)
        PenDown
        Displacement(-19y,-51y)
        PenUp
        Displacement(15y,23y)
        PenDown
        Displacement(14y,-20y)
        PenUp
        Displacement(36y,46y)
        PenDown
        Displacement(-19y,-48y)
        PenUp
        Displacement(14y,25y)
        PenDown
        Displacement(19y,-25y)
    ]
    // 屋
    52957us, [
        PenUp
        Displacement(8y,17y)
        PenDown
        Displacement(11y,18y)
        Displacement(5y,20y)
        Displacement(0y,61y)
        Displacement(85y,0y)
        Displacement(0y,-20y)
        Displacement(-83y,0y)
        PenUp
        Displacement(5y,-18y)
        PenDown
        Displacement(87y,0y)
        PenUp
        Displacement(-52y,-3y)
        PenDown
        Displacement(-24y,-20y)
        Displacement(62y,0y)
        PenUp
        Displacement(-13y,15y)
        PenDown
        Displacement(22y,-23y)
        PenUp
        Displacement(-76y,-13y)
        PenDown
        yield! Radical.多横中竖士 [75y;102y] [23y;41y]

    ]
    // 无
    52958us, [
        PenUp
        Displacement(15y,111y)
        PenDown
        yield! Radical.中心对齐等距横 [92y;113y] 36y

        PenUp
        Displacement(-57y,36y)
        PenDown
        Displacement(-8y,-46y)
        Displacement(-20y,-33y)
        Displacement(-28y,-18y)
        PenUp
        Displacement(65y,61y)
        PenDown
        Displacement(0y,-59y)
        Displacement(40y,0y)
        Displacement(8y,18y)
    ]
    // 芜
    52959us, [
        PenUp
        Displacement(8y,103y)
        PenDown
        yield! Radical.艹 (37y,18y) (113y,33y)

        PenUp
        Displacement(-60y,-8y)
        PenDown
        yield! Radical.中心对齐等距横 [87y;106y] 28y

        PenUp
        Displacement(-56y,25y)
        PenDown
        Displacement(-4y,-25y)
        Displacement(-10y,-20y)
        Displacement(-13y,-13y)
        Displacement(-28y,-10y)
        PenUp
        Displacement(66y,40y)
        PenDown
        Displacement(0y,-36y)
        Displacement(4y,-8y)
        Displacement(37y,0y)
        Displacement(4y,5y)
        Displacement(5y,13y)
    ]
    // 梧
    52960us, [
        PenUp
        Displacement(1y,90y)
        PenDown
        yield! Radical.十 43y [33y;122y]

        PenUp
        Displacement(0y,84y)
        PenDown
        Displacement(-24y,-43y)
        PenUp
        Displacement(24y,33y)
        PenDown
        Displacement(18y,-18y)
        PenUp
        Displacement(4y,56y)
        PenDown
        Displacement(69y,0y)
        PenUp
        Displacement(-62y,-23y)
        PenDown
        Displacement(51y,0y)
        Displacement(-3y,-25y)
        PenUp
        Displacement(-25y,48y)
        PenDown
        Displacement(-10y,-51y)
        PenUp
        Displacement(-18y,0y)
        PenDown
        Displacement(76y,0y)
        PenUp
        Displacement(-68y,-18y)
        PenDown
        yield! Radical.口(52y,33y)

    ]
    // 吾
    52961us, [
        PenUp
        Displacement(9y,116y)
        PenDown
        Displacement(101y,0y)
        PenUp
        Displacement(-89y,-23y)
        PenDown
        Displacement(69y,0y)
        Displacement(-3y,-23y)
        PenUp
        Displacement(-83y,-5y)
        PenDown
        Displacement(113y,0y)
        PenUp
        Displacement(-65y,48y)
        PenDown
        Displacement(-13y,-46y)
        PenUp
        Displacement(-13y,-22y)
        PenDown
        yield! Radical.口(69y,28y)
    ]
    // 吴
    52962us, [
        PenUp
        Displacement(23y,93y)
        PenDown
        yield! Radical.口(71y,-25y)
        PenUp
        Displacement(-6y,-18y)
        PenDown
        yield! Radical.中心对齐等距横 [90y;112y] 23y

        PenUp
        Displacement(-57y,23y)
        PenDown
        Displacement(-3y,-23y)
        Displacement(-10y,-20y)
        Displacement(-22y,-13y)
        Displacement(-20y,-10y)
        PenUp
        Displacement(59y,41y)
        PenDown
        Displacement(15y,-15y)
        Displacement(15y,-13y)
        Displacement(23y,-8y)
    ]
    // 毋
    52963us, [
        PenUp
        Displacement(76y,9y)
        PenDown
        Displacement(10y,3y)
        Displacement(9y,3y)
        Displacement(4y,8y)
        Displacement(1y,8y)
        Displacement(0y,87y)
        Displacement(-70y,0y)
        Displacement(-10y,-82y)
        Displacement(97y,0y)
        PenUp
        Displacement(-116y,38y)
        PenDown
        Displacement(125y,0y)
        PenUp
        Displacement(-59y,41y)
        PenDown
        Displacement(-5y,-48y)
        Displacement(-5y,-25y)
        Displacement(-10y,-18y)
        Displacement(-22y,-15y)
    ]
    // 武
    52964us, [
        PenUp
        Displacement(13y,106y)
        PenDown
        Displacement(50y,0y)
        PenUp
        Displacement(-61y,-25y)
        PenDown
        Displacement(119y,0y)
        PenUp
        Displacement(-98y,-20y)
        PenDown
        Displacement(0y,-48y)
        PenUp
        Displacement(-15y,-5y)
        PenDown
        Displacement(69y,20y)
        PenUp
        Displacement(-31y,51y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(0y,33y)
        PenDown
        Displacement(24y,0y)
        PenUp
        Displacement(8y,69y)
        PenDown
        Displacement(0y,-64y)
        Displacement(8y,-23y)
        Displacement(11y,-18y)
        Displacement(11y,-13y)
        Displacement(9y,3y)
        Displacement(3y,15y)
        PenUp
        Displacement(-28y,92y)
        PenDown
        Displacement(17y,-20y)
    ]
    // 五
    52965us, [
        PenUp
        Displacement(11y,111y)
        PenDown
        Displacement(102y,0y)
        PenUp
        Displacement(-55y,0y)
        PenDown
        Displacement(-15y,-89y)
        PenUp
        Displacement(-23y,54y)
        PenDown
        Displacement(71y,0y)
        Displacement(0y,-51y)
        PenUp
        Displacement(-85y,-5y)
        PenDown
        Displacement(113y,0y)
    ]
    // 捂
    52966us, [
        PenUp
        Displacement(1y,101y)
        PenDown
        Displacement(38y,0y)
        PenUp
        Displacement(-19y,25y)
        PenDown
        Displacement(0y,-110y)
        Displacement(-4y,-10y)
        Displacement(-5y,-3y)
        Displacement(-9y,-3y)
        PenUp
        Displacement(-1y,41y)
        PenDown
        Displacement(34y,31y)
        PenUp
        Displacement(9y,43y)
        PenDown
        Displacement(75y,0y)
        PenUp
        Displacement(-46y,0y)
        PenDown
        Displacement(-8y,-51y)
        PenUp
        Displacement(-15y,31y)
        PenDown
        Displacement(56y,0y)
        Displacement(-4y,-31y)
        PenUp
        Displacement(-61y,0y)
        PenDown
        Displacement(82y,0y)
        PenUp
        Displacement(-65y,-18y)
        PenDown
        yield! Radical.口(54y,35y)

    ]
    // 午
    52967us, [
        PenUp
        Displacement(43y,121y)
        PenDown
        Displacement(-36y,-46y)
        PenUp
        Displacement(25y,25y)
        PenDown
        Displacement(78y,0y)
        PenUp
        Displacement(-102y,-48y)
        PenDown
        yield! Radical.十 112y [48y;99y]

    ]
    // 舞
    52968us, [
        PenUp
        Displacement(37y,126y)
        PenDown
        Displacement(-8y,-13y)
        Displacement(-6y,-10y)
        Displacement(-10y,-10y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(87y,0y)
        PenUp
        Displacement(-96y,-23y)
        PenDown
        yield! Radical.中心对齐等距横 [96y;121y] 20y

        PenUp
        Displacement(-93y,43y)
        PenDown
        Displacement(0y,-43y)
        for _ in [1;2;3] do
            PenUp
            Displacement(22y,43y)
            PenDown
            Displacement(0y,-43y)
        PenUp
        Displacement(-59y,-5y)
        PenDown
        Displacement(-6y,-10y)
        Displacement(-9y,-10y)
        Displacement(-10y,-10y)
        PenUp
        Displacement(17y,15y)
        PenDown
        Displacement(29y,0y)
        Displacement(-6y,-13y)
        Displacement(-9y,-13y)
        Displacement(-10y,-10y)
        Displacement(-10y,-8y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(19y,33y)
        PenDown
        Displacement(17y,-10y)
        PenUp
        Displacement(74y,23y)
        PenDown
        yield! Radical.匚(47y,23y)
        PenUp
        Displacement(-24y,38y)
        PenDown
        Displacement(0y,-61y)
    ]
    // 伍
    52969us, [
        PenUp
        Displacement(36y,121y)
        PenDown
        Displacement(-8y,-23y)
        Displacement(-11y,-15y)
        Displacement(-11y,-15y)
        PenUp
        Displacement(18y,25y)
        PenDown
        Displacement(0y,-92y)
        PenUp
        Displacement(18y,107y)
        PenDown
        Displacement(78y,0y)
        PenUp
        Displacement(-78y,-38y)
        PenDown
        Displacement(61y,0y)
        Displacement(0y,-56y)
        PenUp
        Displacement(-29y,94y)
        PenDown
        Displacement(-17y,-94y)
        PenUp
        Displacement(-24y,-3y)
        PenDown
        Displacement(89y,0y)
    ]
    // 侮
    52970us, [
        PenUp
        Displacement(36y,124y)
        PenDown
        Displacement(-13y,-23y)
        Displacement(-10y,-25y)
        Displacement(-10y,-13y)
        PenUp
        Displacement(20y,33y)
        PenDown
        Displacement(0y,-94y)
        PenUp
        Displacement(42y,125y)
        PenDown
        Displacement(-6y,-15y)
        Displacement(-11y,-18y)
        Displacement(-11y,-13y)
        PenUp
        Displacement(20y,25y)
        PenDown
        Displacement(62y,0y)
        PenUp
        Displacement(-83y,-54y)
        PenDown
        Displacement(92y,0y)
        PenUp
        Displacement(-54y,23y)
        PenDown
        Displacement(17y,-13y)
        PenUp
        Displacement(-17y,-18y)
        PenDown
        Displacement(14y,-13y)
        PenUp
        Displacement(-1y,-25y)
        PenDown
        Displacement(17y,3y)
        Displacement(4y,5y)
        Displacement(0y,71y)
        Displacement(-48y,0y)
        Displacement(-6y,-64y)
        Displacement(69y,0y)
    ]
    // 坞
    52971us, [
        PenUp
        Displacement(6y,85y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-41y,-56y)
        PenDown
        Displacement(43y,18y)
        PenUp
        Displacement(-24y,76y)
        PenDown
        Displacement(0y,-84y)
        PenUp
        Displacement(56y,87y)
        PenDown
        Displacement(-10y,-18y)
        PenUp
        Displacement(17y,-38y)
        PenDown
        Displacement(15y,5y)
        Displacement(0y,31y)
        Displacement(-43y,0y)
        Displacement(0y,-51y)
        Displacement(56y,0y)
        Displacement(0y,-38y)
        Displacement(-8y,-10y)
        Displacement(-19y,-3y)
        PenUp
        Displacement(-51y,20y)
        PenDown
        Displacement(60y,8y)
    ]
    // 戊
    52972us, [
        PenUp
        Displacement(4y,1y)
        PenDown
        Displacement(8y,13y)
        Displacement(6y,13y)
        Displacement(3y,15y)
        Displacement(0y,51y)
        Displacement(98y,0y)
        PenUp
        Displacement(-54y,31y)
        PenDown
        Displacement(0y,-28y)
        Displacement(4y,-25y)
        Displacement(5y,-20y)
        Displacement(10y,-20y)
        Displacement(14y,-15y)
        Displacement(11y,-8y)
        Displacement(5y,-3y)
        Displacement(4y,8y)
        Displacement(3y,10y)
        PenUp
        Displacement(-19y,56y)
        PenDown
        Displacement(-13y,-25y)
        Displacement(-15y,-18y)
        Displacement(-18y,-15y)
        Displacement(-13y,-10y)
        PenUp
        Displacement(42y,107y)
        PenDown
        Displacement(20y,-18y)
    ]
    // 雾
    52973us, [
        PenUp
        Displacement(14y,119y)
        PenDown

        yield! Radical.雨字头(93y,43y)(98y,23y)
        PenUp
        Displacement(-60y,-4y)
        PenDown
        Displacement(-17y,-8y)
        Displacement(-20y,-10y)
        PenUp
        Displacement(22y,10y)
        PenDown
        Displacement(65y,0y)
        Displacement(-24y,-13y)
        Displacement(-17y,-3y)
        Displacement(-29y,-8y)
        Displacement(-25y,-5y)
        PenUp
        Displacement(34y,20y)
        PenDown
        Displacement(22y,-8y)
        Displacement(34y,-8y)
        Displacement(28y,-3y)
        PenUp
        Displacement(-96y,-13y)
        PenDown
        Displacement(69y,0y)
        Displacement(-4y,-18y)
        Displacement(-22y,-5y)
        PenUp
        Displacement(-14y,38y)
        PenDown
        Displacement(-4y,-15y)
        Displacement(-8y,-13y)
        Displacement(-14y,-10y)
        Displacement(-18y,-5y)
    ]
    // 晤
    52974us, [
        PenUp
        Displacement(8y,114y)
        PenDown
        yield! Radical.日(28y,79y)
        PenUp
        Displacement(37y,44y)
        PenDown

        Displacement(73y,0y)
        PenUp
        Displacement(-43y,0y)
        PenDown
        Displacement(-8y,-51y)
        PenUp
        Displacement(-17y,28y)
        PenDown
        Displacement(54y,0y)
        Displacement(-4y,-31y)
        PenUp
        Displacement(-56y,3y)
        PenDown
        Displacement(82y,0y)
        PenUp
        Displacement(-70y,-20y)
        PenDown
        yield! Radical.口(54y,33y)
    ]
    // 物
    52975us, [
        PenUp
        Displacement(18y,108y)
        PenDown
        Displacement(-14y,-41y)
        PenUp
        Displacement(13y,23y)
        PenDown
        Displacement(34y,0y)
        PenUp
        Displacement(-15y,31y)
        PenDown
        Displacement(0y,-120y)
        PenUp
        Displacement(-28y,43y)
        PenDown
        Displacement(45y,18y)
        PenUp
        Displacement(23y,61y)
        PenDown
        Displacement(-11y,-28y)
        Displacement(-11y,-13y)
        Displacement(-6y,-8y)
        PenUp
        Displacement(18y,18y)
        PenDown
        Displacement(51y,0y)
        Displacement(0y,-71y)
        Displacement(-9y,-10y)
        Displacement(-14y,-3y)
        PenUp
        Displacement(-10y,84y)
        PenDown
        Displacement(-8y,-23y)
        Displacement(-9y,-10y)
        Displacement(-11y,-13y)
        Displacement(-6y,-8y)
        PenUp
        Displacement(55y,54y)
        PenDown
        Displacement(-5y,-25y)
        Displacement(-10y,-15y)
        Displacement(-8y,-15y)
        Displacement(-10y,-13y)
        Displacement(-18y,-10y)
    ]
    // 勿
    52976us, [
        PenUp
        Displacement(42y,121y)
        PenDown
        Displacement(-14y,-31y)
        Displacement(-15y,-23y)
        PenUp
        Displacement(19y,33y)
        PenDown
        Displacement(78y,0y)
        Displacement(0y,-71y)
        Displacement(-3y,-8y)
        Displacement(-9y,-8y)
        Displacement(-10y,-5y)
        Displacement(-10y,-3y)
        PenUp
        Displacement(-20y,94y)
        PenDown
        Displacement(-5y,-25y)
        Displacement(-10y,-15y)
        Displacement(-6y,-13y)
        Displacement(-8y,-10y)
        Displacement(-11y,-10y)
        PenUp
        Displacement(69y,71y)
        PenDown
        Displacement(-6y,-31y)
        Displacement(-9y,-20y)
        Displacement(-4y,-10y)
        Displacement(-15y,-18y)
        Displacement(-11y,-13y)
    ]
    // 务
    52977us, [
        PenUp
        Displacement(51y,126y)
        PenDown
        Displacement(-25y,-33y)
        Displacement(-9y,-8y)
        PenUp
        Displacement(25y,23y)
        PenDown
        Displacement(50y,0y)
        Displacement(-27y,-25y)
        Displacement(-31y,-15y)
        Displacement(-32y,-10y)
        PenUp
        Displacement(37y,38y)
        PenDown
        Displacement(19y,-15y)
        Displacement(23y,-10y)
        Displacement(36y,-10y)
        PenUp
        Displacement(-99y,-15y)
        PenDown
        Displacement(76y,0y)
        Displacement(-3y,-25y)
        Displacement(-4y,-10y)
        Displacement(-13y,-5y)
        Displacement(-8y,0y)
        PenUp
        Displacement(-10y,61y)
        PenDown
        Displacement(-3y,-20y)
        Displacement(-6y,-13y)
        Displacement(-9y,-10y)
        Displacement(-9y,-8y)
        Displacement(-15y,-8y)
        Displacement(-8y,-3y)
    ]
    // 悟
    52978us, [
        PenUp
        Displacement(20y,96y)
        PenDown
        Displacement(-10y,-36y)
        PenUp
        Displacement(19y,64y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(11y,97y)
        PenDown
        Displacement(13y,-25y)
        PenUp
        Displacement(0y,38y)
        PenDown
        Displacement(70y,0y)
        PenUp
        Displacement(-66y,-23y)
        PenDown
        Displacement(52y,0y)
        Displacement(-3y,-25y)
        PenUp
        Displacement(-24y,48y)
        PenDown
        Displacement(-10y,-51y)
        PenUp
        Displacement(-27y,0y)
        PenDown
        Displacement(80y,0y)
        PenUp
        Displacement(-66y,-21y)
        PenDown
        yield! Radical.口(54y,30y)
    ]
    // 误
    52979us, [
        PenUp
        Displacement(17y,121y)
        PenDown
        Displacement(20y,-20y)
        PenUp
        Displacement(-36y,-20y)
        PenDown
        Displacement(24y,0y)
        Displacement(0y,-71y)
        Displacement(24y,23y)
        PenUp
        Displacement(4y,59y)
        PenDown
        yield! Radical.口(59y,-25y)

        PenUp
        Displacement(-3y,-18y)
        PenDown
        yield! Radical.中心对齐等距横 [64y;76y] 23y

        PenUp
        Displacement(-38y,20y)
        PenDown
        Displacement(-3y,-15y)
        Displacement(-4y,-15y)
        Displacement(-8y,-10y)
        Displacement(-11y,-10y)
        Displacement(-13y,-10y)
        PenUp
        Displacement(37y,38y)
        PenDown
        Displacement(9y,-13y)
        Displacement(9y,-10y)
        Displacement(10y,-8y)
        Displacement(11y,-5y)
    ]
    // 昔
    52980us, [
        PenUp
        Displacement(15y,101y)
        PenDown
        yield! Radical.共头 [42y;97y;122y] [18y;46y]

        PenUp
        Displacement(-98y,-17y)
        PenDown
        yield! Radical.日(74y,47y)

    ]
    // 熙
    52981us, [
        PenUp
        Displacement(65y,116y)
        PenDown

        yield! Radical.颐无页(56y,66y)(31y,20y)
        PenUp
        Displacement(34y,36y)
        PenDown
        yield! Radical.匚(-33y,-31y)
        Displacement(0y,-56y)
        Displacement(3y,-5y)
        Displacement(4y,-3y)
        Displacement(27y,0y)
        Displacement(4y,5y)
        Displacement(4y,8y)
        PenUp
        Displacement(-96y,-31y)
        PenDown
        Displacement(-17y,-31y)
        PenUp
        Displacement(38y,28y)
        PenDown
        Displacement(10y,-28y)
        PenUp
        Displacement(18y,31y)
        PenDown
        Displacement(15y,-25y)
        PenUp
        Displacement(17y,28y)
        PenDown
        Displacement(20y,-31y)
    ]
    // 析
    52982us, [
        PenUp
        Displacement(5y,90y)
        PenDown
        yield! Radical.十 51y [33y;122y]

        PenUp
        Displacement(1y,84y)
        PenDown
        Displacement(-10y,-20y)
        Displacement(-15y,-20y)
        PenUp
        Displacement(25y,31y)
        PenDown
        Displacement(20y,-20y)
        PenUp
        Displacement(66y,59y)
        PenDown
        Displacement(-54y,-8y)
        Displacement(0y,-61y)
        Displacement(-5y,-15y)
        Displacement(-5y,-10y)
        Displacement(-13y,-15y)
        PenUp
        Displacement(25y,69y)
        PenDown
        Displacement(61y,0y)
        PenUp
        Displacement(-27y,-3y)
        PenDown
        Displacement(0y,-69y)
    ]
    // 西
    52983us, [
        PenUp
        Displacement(4y,119y)
        PenDown
        yield! Radical.西字(117y,97y)(93y,61y)


    ]
    // 硒
    52984us, [
        PenUp
        Displacement(6y,103y)
        PenDown
        Displacement(47y,0y)
        PenUp
        Displacement(-22y,0y)
        PenDown
        Displacement(-10y,-25y)
        Displacement(-19y,-23y)
        PenUp
        Displacement(15y,-32y)
        PenDown
        yield! Radical.口(27y,-48y)
        PenUp
        Displacement(42y,94y)
        PenDown
        yield! Radical.西字(60y,102y)(56y,69y)


    ]
    // 矽
    52985us, [
        PenUp
        Displacement(4y,103y)
        PenDown
        Displacement(47y,0y)
        PenUp
        Displacement(-23y,-3y)
        PenDown
        Displacement(-9y,-28y)
        Displacement(-17y,-25y)
        PenUp
        Displacement(17y,-28y)
        PenDown
        yield! Radical.口(25y,-51y)
        PenUp
        Displacement(71y,104y)
        PenDown
        Displacement(-6y,-20y)
        Displacement(-11y,-20y)
        Displacement(-14y,-18y)
        PenUp
        Displacement(24y,36y)
        PenDown
        Displacement(40y,0y)
        Displacement(-5y,-15y)
        Displacement(-8y,-25y)
        Displacement(-10y,-18y)
        Displacement(-15y,-23y)
        Displacement(-14y,-10y)
        Displacement(-15y,-8y)
        PenUp
        Displacement(10y,66y)
        PenDown
        Displacement(34y,-25y)
    ]
    // 晰
    52986us, [
        PenUp
        Displacement(8y,111y)
        PenDown
        yield! Radical.日(22y,76y)
        PenUp
        Displacement(27y,19y)
        PenDown

        yield! Radical.十 38y [26y;115y]

        PenUp
        Displacement(-4y,79y)
        PenDown
        Displacement(-17y,-41y)
        PenUp
        Displacement(24y,36y)
        PenDown
        Displacement(14y,-18y)
        Displacement(4y,0y)
        PenUp
        Displacement(38y,64y)
        PenDown
        Displacement(-34y,-10y)
        Displacement(0y,-51y-18y)
        Displacement(-5y,-18y)
        Displacement(-10y,-18y)
        PenUp
        Displacement(18y,69y)
        PenDown
        Displacement(40y,0y)
        PenUp
        Displacement(-19y,-3y)
        PenDown
        Displacement(0y,-69y)
    ]
    // 嘻
    52987us, [
        PenUp
        Displacement(8y,44y)
        PenDown
        yield! Radical.口(25y,-64y)
        PenUp
        Displacement(32y,64y)
        PenDown
        yield! Radical.多横中竖士 [78y;62y] [15y;33y]

        PenUp
        Displacement(-26y,-31y)
        PenDown
        yield! Radical.口(52y,-18y)

        PenUp
        Displacement(-16y,-18y)
        PenDown
        Displacement(84y,0y)
        PenUp
        Displacement(-59y,15y)
        PenDown
        Displacement(8y,-13y)
        PenUp
        Displacement(23y,10y)
        PenDown
        Displacement(-8y,-10y)
        PenUp
        Displacement(-35y,-15y)
        PenDown
        yield! Radical.口(56y,21y)
    ]
    // 吸
    52988us, [
        PenUp
        Displacement(9y,55y)
        PenDown
        yield! Radical.口(29y,-61y)
        PenUp
        Displacement(40y,64y)
        PenDown
        Displacement(56y,0y)
        Displacement(-18y,-38y)
        Displacement(24y,0y)
        Displacement(-9y-4y,-23y-10y)
        Displacement(-8y-6y,-10y-10y)
        Displacement(-8y-10y-8y,-5y-5y-5y)
        Displacement(-8y,-3y)
        PenUp
        Displacement(22y,61y)
        PenDown
        Displacement(10y,-20y)
        Displacement(8y,-13y)
        Displacement(19y,-18y)
        Displacement(11y,-8y)
        PenUp
        Displacement(-57y,107y)
        PenDown
        Displacement(0y,-15y)
        Displacement(-1y,-28y)
        Displacement(-4y,-18y)
        Displacement(-5y,-13y)
        Displacement(-10y,-13y)
        Displacement(-3y,-3y)
        Displacement(-9y,-8y)
        Displacement(-8y,-5y)
    ]
    // 锡
    52989us, [
        PenUp
        Displacement(32y,124y)
        PenDown
        Displacement(-11y,-20y)
        Displacement(-15y,-20y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(34y,0y)
        PenUp
        Displacement(-42y,-23y)
        PenDown
        Displacement(36y,0y)
        PenUp
        Displacement(-45y,-25y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(-25y,25y)
        PenDown
        Displacement(0y,-69y)
        Displacement(27y,23y)
        PenUp
        Displacement(10y,87y)
        PenDown

        yield! Radical.日(47y,38y)
        PenUp
        Displacement(17y,-23y)
        PenDown
        Displacement(-11y,-15y)
        Displacement(-13y,-13y)
        PenUp
        Displacement(14y,13y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,-41y)
        Displacement(-6y,-8y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-14y,51y)
        PenDown
        Displacement(-9y,-18y)
        Displacement(-19y,-15y)
        PenUp
        Displacement(47y,31y)
        PenDown
        Displacement(-6y,-13y)
        Displacement(-13y,-18y)
        Displacement(-13y,-15y)
        Displacement(-13y,-8y)
    ]
    // 牺
    52990us, [
        PenUp
        Displacement(19y,108y)
        PenDown
        Displacement(-4y,-23y)
        Displacement(-11y,-20y)
        PenUp
        Displacement(14y,28y)
        PenDown
        Displacement(33y,0y)
        PenUp
        Displacement(-23y,33y)
        PenDown
        Displacement(0y,-125y)
        PenUp
        Displacement(-23y,46y)
        PenDown
        Displacement(43y,18y)
        PenUp
        Displacement(-3y,46y)
        PenDown
        yield! Radical.西字(79y,98y)(57y,67y)


    ]
    // 稀
    53153us, [
        PenUp
        Displacement(51y,119y)
        PenDown
        Displacement(-41y,-8y)
        PenUp
        Displacement(-4y,-31y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-19y,31y)
        PenDown
        Displacement(0y,-110y)
        PenUp
        Displacement(-1y,74y)
        PenDown
        Displacement(-25y,-43y)
        PenUp
        Displacement(29y,41y)
        PenDown
        Displacement(15y,-15y)
        PenUp
        Displacement(62y,64y)
        PenDown
        Displacement(-22y,-18y)
        Displacement(-29y,-15y)
        PenUp
        Displacement(1y,31y)
        PenDown
        Displacement(29y,-15y)
        Displacement(24y,-15y)
        PenUp
        Displacement(-62y,-13y)
        PenDown
        Displacement(74y,0y)
        PenUp
        Displacement(-37y,15y)
        PenDown
        Displacement(-15y,-25y)
        Displacement(-11y,-13y)
        Displacement(-18y,-13y)
        PenUp
        Displacement(20y,-28y)
        PenDown
        yield! Radical.巾 54y [43y;14y;66y]

    ]
    // 息
    53154us, [
        PenUp
        Displacement(57y,124y)
        PenDown
        Displacement(-9y,-18y)

        PenUp
        Displacement(-19y,-2y)
        PenDown
        yield! Radical.目(71y,54y)
        PenUp
        Displacement(-2y,-33y)
        PenDown

        Displacement(-8y,-15y)
        Displacement(-13y,-10y)
        PenUp
        Displacement(52y,33y)
        PenDown
        Displacement(17y,-18y)
        PenUp
        Displacement(24y,13y)
        PenDown
        Displacement(20y,-28y)
        PenUp
        Displacement(-78y,25y)
        PenDown
        Displacement(0y,-23y)
        Displacement(1y,-5y)
        Displacement(42y,-5y)
        Displacement(4y,5y)
        Displacement(5y,13y)
    ]
    // 希
    53155us, [
        PenUp
        Displacement(20y,119y)
        PenDown
        Displacement(85y,-31y)
        PenUp
        Displacement(-13y,33y)
        PenDown
        Displacement(-82y,-31y)
        PenUp
        Displacement(-10y,-15y)
        PenDown
        Displacement(122y,0y)
        PenUp
        Displacement(-69y,18y)
        PenDown
        Displacement(-15y,-23y)
        Displacement(-14y,-15y)
        Displacement(-22y,-18y)
        PenUp
        Displacement(27y,-28y)
        PenDown
        yield! Radical.巾 71y [46y;18y;70y]

    ]
    // 悉
    53156us, [
        PenUp
        Displacement(17y,113y)
        PenDown
        Displacement(46y,0y)
        Displacement(14y,3y)
        Displacement(20y,8y)
        PenUp
        Displacement(-36y,-10y)
        PenDown
        Displacement(0y,-59y)
        PenUp
        Displacement(-56y,31y)
        PenDown
        Displacement(115y,0y)
        PenUp
        Displacement(-90y,20y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(52y,18y)
        PenDown
        Displacement(-13y,-20y)
        PenUp
        Displacement(-25y,-5y)
        PenDown
        Displacement(-15y,-13y)
        Displacement(-11y,-10y)
        Displacement(-15y,-5y)
        Displacement(-8y,-3y)
        PenUp
        Displacement(60y,31y)
        PenDown
        Displacement(14y,-13y)
        Displacement(14y,-8y)
        Displacement(10y,-5y)
        Displacement(13y,-3y)
        PenUp
        Displacement(-96y,-18y)
        PenDown
        Displacement(-17y,-28y)
        PenUp
        Displacement(36y,31y)
        PenDown
        Displacement(0y,-20y)
        Displacement(1y,-10y)
        Displacement(9y,-3y)
        Displacement(32y,0y)
        Displacement(5y,3y)
        Displacement(1y,5y)
        Displacement(3y,8y)
        PenUp
        Displacement(-36y,25y)
        PenDown
        Displacement(20y,-18y)
        PenUp
        Displacement(23y,8y)
        PenDown
        Displacement(23y,-25y)
    ]
    // 膝
    53157us, [
        PenUp
        Displacement(3y,9y)
        PenDown
        Displacement(8y,15y)
        Displacement(5y,18y)
        Displacement(0y,74y)
        Displacement(24y,0y)
        Displacement(0y,-97y)
        Displacement(-4y,-5y)
        Displacement(-11y,-5y)
        PenUp
        Displacement(-6y,79y)
        PenDown
        Displacement(20y,0y)
        PenUp
        Displacement(-22y,-31y)
        PenDown
        Displacement(22y,0y)
        PenUp
        Displacement(9y,51y)
        PenDown
        Displacement(73y,0y)
        PenUp
        Displacement(-40y,18y)
        PenDown
        Displacement(0y,-38y)
        PenUp
        Displacement(-3y,20y)
        PenDown
        Displacement(-11y,-15y)
        Displacement(-19y,-13y)
        PenUp
        Displacement(36y,28y)
        PenDown
        Displacement(19y,-13y)
        Displacement(15y,-13y)
        PenUp
        Displacement(-36y,3y)
        PenDown
        Displacement(-14y,-15y)
        Displacement(-23y,-13y)
        PenUp
        Displacement(37y,25y)
        PenDown
        Displacement(17y,-13y)
        Displacement(23y,-10y)
        PenUp
        Displacement(-68y,-10y)
        PenDown
        Displacement(17y,-8y)
        PenUp
        Displacement(37y,13y)
        PenDown
        Displacement(-28y,-18y)
        Displacement(-31y,-15y)
        PenUp
        Displacement(37y,20y)
        PenDown
        Displacement(33y,-28y)
        PenUp
        Displacement(-37y,54y)
        PenDown
        Displacement(0y,-54y)
        Displacement(-3y,-3y)
        Displacement(-15y,-3y)
    ]
    // 夕
    53158us, [
        PenUp
        Displacement(60y,119y)
        PenDown
        Displacement(-15y,-28y)
        Displacement(-14y,-15y)
        Displacement(-18y,-15y)
        PenUp
        Displacement(33y,28y)
        PenDown
        Displacement(62y,0y)
        Displacement(-4y,-15y)
        Displacement(-14y,-20y)
        Displacement(-10y,-15y)
        Displacement(-15y,-13y)
        Displacement(-14y,-8y)
        Displacement(-15y,-5y)
        Displacement(-27y,-5y)
        PenUp
        Displacement(37y,59y)
        PenDown
        Displacement(36y,-25y)
    ]
    // 惜
    53159us, [
        PenUp
        Displacement(11y,98y)
        PenDown
        Displacement(-9y,-33y)
        PenUp
        Displacement(22y,61y)
        PenDown
        Displacement(0y,-125y)
        PenUp
        Displacement(14y,102y)
        PenDown
        Displacement(6y,-20y)
        PenUp
        Displacement(5y,20y)
        PenDown
        yield! Radical.共头 [29y;66y;78y] [25y;48y]

        PenUp
        Displacement(-65y,-18y)
        PenDown
        yield! Radical.日(52y,49y)

    ]
    // 熄
    53160us, [
        PenUp
        Displacement(15y,93y)
        PenDown
        Displacement(-10y,-31y)
        PenUp
        Displacement(24y,59y)
        PenDown
        Displacement(0y,-51y-18y)
        Displacement(-8y,-18y)
        Displacement(-19y,-25y)
        PenUp
        Displacement(46y,87y)
        PenDown
        Displacement(-14y,-18y)
        PenUp
        Displacement(-4y,-31y)
        PenDown
        Displacement(15y,-15y)
        PenUp
        Displacement(38y,87y)
        PenDown
        Displacement(-6y,-13y)
        PenUp
        Displacement(-19y,-2y)
        PenDown
        yield! Radical.目(48y,54y)
        PenUp
        Displacement(-3y,-33y)
        PenDown

        Displacement(-18y,-28y)
        PenUp
        Displacement(28y,28y)
        PenDown
        Displacement(0y,-23y)
        Displacement(3y,-8y)
        Displacement(27y,0y)
        Displacement(6y,5y)
        Displacement(1y,8y)
        PenUp
        Displacement(-23y,25y)
        PenDown
        Displacement(13y,-18y)
        PenUp
        Displacement(15y,8y)
        PenDown
        Displacement(17y,-20y)
    ]
    // 烯
    53161us, [
        PenUp
        Displacement(14y,96y)
        PenDown
        Displacement(-6y,-31y)
        PenUp
        Displacement(20y,56y)
        PenDown
        Displacement(0y,-56y-18y)
        Displacement(-6y,-15y)
        Displacement(-8y,-10y)
        Displacement(-9y,-13y)
        PenUp
        Displacement(41y,87y)
        PenDown
        Displacement(-17y,-23y)
        PenUp
        Displacement(0y,-28y)
        PenDown
        Displacement(19y,-20y)
        PenUp
        Displacement(62y,97y)
        PenDown
        Displacement(-22y,-18y)
        Displacement(-29y,-15y)
        PenUp
        Displacement(1y,31y)
        PenDown
        Displacement(29y,-15y)
        Displacement(24y,-15y)
        PenUp
        Displacement(-62y,-13y)
        PenDown
        Displacement(74y,0y)
        PenUp
        Displacement(-37y,15y)
        PenDown
        Displacement(-15y,-25y)
        Displacement(-11y,-13y)
        Displacement(-18y,-13y)
        PenUp
        Displacement(20y,-28y)
        PenDown
        yield! Radical.巾 54y [43y;18y;66y]

    ]
    // 溪
    53162us, [
        PenUp
        Displacement(13y,121y)
        PenDown
        Displacement(23y,-18y)
        PenUp
        Displacement(-32y,-15y)
        PenDown
        Displacement(24y,-15y)
        PenUp
        Displacement(-1y,-15y)
        PenDown
        Displacement(-22y,-51y)
        PenUp
        Displacement(112y,112y)
        PenDown
        Displacement(-75y,0y)
        PenUp
        Displacement(5y,-10y)
        PenDown
        Displacement(8y,-18y)
        PenUp
        Displacement(19y,15y)
        PenDown
        Displacement(10y,-15y)
        PenUp
        Displacement(29y,18y)
        PenDown
        Displacement(-15y,-18y)
        PenUp
        Displacement(-25y,0y)
        PenDown
        Displacement(-20y,-18y)
        Displacement(36y,0y)
        PenUp
        Displacement(14y,15y)
        PenDown
        Displacement(-51y,-33y)
        Displacement(55y,0y)
        PenUp
        Displacement(-10y,13y)
        PenDown
        Displacement(20y,-20y)
        PenUp
        Displacement(-84y,-13y)
        PenDown
        Displacement(92y,0y)
        PenUp
        Displacement(-48y,18y)
        PenDown
        Displacement(-3y,-20y)
        Displacement(-11y,-13y)
        Displacement(-14y,-10y)
        Displacement(-19y,-5y)
        PenUp
        Displacement(51y,31y)
        PenDown
        Displacement(9y,-13y)
        Displacement(13y,-8y)
        Displacement(20y,-8y)
    ]
    // 汐
    53163us, [
        PenUp
        Displacement(18y,119y)
        PenDown
        Displacement(28y,-15y)
        PenUp
        Displacement(-42y,-15y)
        PenDown
        Displacement(27y,-18y)
        PenUp
        Displacement(-22y,-56y)
        PenDown
        Displacement(28y,38y)
        PenUp
        Displacement(40y,71y)
        PenDown
        Displacement(-6y,-20y)
        Displacement(-10y,-18y)
        Displacement(-17y,-20y)
        PenUp
        Displacement(27y,33y)
        PenDown
        Displacement(47y,0y)
        Displacement(-5y,-20y)
        Displacement(-8y,-15y)
        Displacement(-9y,-20y)
        Displacement(-8y,-13y)
        Displacement(-13y,-13y)
        Displacement(-13y,-8y)
        Displacement(-11y,-3y)
        Displacement(-11y,-5y)
        PenUp
        Displacement(25y,66y)
        PenDown
        Displacement(31y,-23y)
    ]
    // 犀
    53164us, [
        PenUp
        Displacement(3y,14y)
        PenDown
        Displacement(9y,18y)
        Displacement(6y,20y)
        Displacement(0y,64y)
        Displacement(92y,0y)
        Displacement(0y,-18y)
        Displacement(-90y,0y)
        PenUp
        Displacement(13y,-10y)
        PenDown
        Displacement(28y,-8y)
        PenUp
        Displacement(-31y,-15y)
        PenDown
        Displacement(34y,5y)
        PenUp
        Displacement(6y,25y)
        PenDown
        Displacement(0y,-31y)
        PenUp
        Displacement(13y,13y)
        PenDown
        Displacement(29y,10y)
        PenUp
        Displacement(-32y,-15y)
        PenDown
        Displacement(34y,-10y)
        PenUp
        Displacement(-66y,-3y)
        PenDown
        Displacement(-17y,-25y)
        PenUp
        Displacement(11y,10y)
        PenDown
        Displacement(70y,0y)
        PenUp
        Displacement(-88y,-20y)
        PenDown
        yield! Radical.十 98y [36y;56y]

    ]
    // 檄
    53165us, [
        PenUp
        Displacement(1y,93y)
        PenDown
        yield! Radical.十 37y [33y;122y]

        PenUp
        Displacement(-3y,84y)
        PenDown
        Displacement(-9y,-28y)
        Displacement(-9y,-15y)
        PenUp
        Displacement(22y,33y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(25y,61y)
        PenDown
        Displacement(-6y,-13y)
        PenUp
        Displacement(-10y,-2y)
        PenDown
        yield! Radical.日(25y,31y)
        PenUp
        Displacement(7y,-20y)
        PenDown

        Displacement(11y,-10y)
        PenUp
        Displacement(-28y,-3y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-28y,0y)
        PenDown
        Displacement(0y,-15y)
        Displacement(-5y-6y,-13y-13y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(20y,33y)
        PenDown
        Displacement(20y,0y)
        Displacement(-4y,-20y)
        Displacement(-5y,-3y)
        Displacement(-10y,-3y)
        PenUp
        Displacement(41y,107y)
        PenDown
        Displacement(-4y,-20y)
        Displacement(-6y,-20y)
        Displacement(-9y,-15y)
        PenUp
        Displacement(15y,25y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-17y,0y)
        PenDown
        Displacement(0y,-28y)
        Displacement(-3y,-15y)
        Displacement(-5y,-15y)
        Displacement(-10y,-13y)
        Displacement(-22y,-18y)
        PenUp
        Displacement(18y,66y)
        PenDown
        Displacement(8y,-25y)
        Displacement(13y,-20y)
        Displacement(18y,-15y)
    ]
    // 袭
    53166us, [
        PenUp
        Displacement(8y,103y)
        PenDown
        Displacement(107y,0y)
        PenUp
        Displacement(-59y,23y)
        PenDown
        Displacement(-5y,-25y)
        Displacement(-9y,-15y)
        Displacement(-11y,-10y)
        Displacement(-11y,-8y)
        Displacement(-13y,-8y)
        PenUp
        Displacement(61y,36y)
        PenDown
        Displacement(0y,-20y)
        Displacement(3y,-8y)
        Displacement(8y,-3y)
        Displacement(23y,0y)
        Displacement(5y,5y)
        Displacement(5y,10y)
        PenUp
        Displacement(-17y,18y)
        PenDown
        Displacement(-27y,-15y)
        Displacement(-19y,-8y)
        PenUp
        Displacement(31y,51y)
        PenDown
        Displacement(14y,-13y)
        PenUp
        Displacement(-38y,-46y)
        PenDown
        Displacement(14y,-13y)
        PenUp
        Displacement(-69y,-8y)
        PenDown
        Displacement(122y,0y)
        PenUp
        Displacement(-74y,-3y)
        PenDown
        Displacement(-20y,-16y)
        Displacement(-21y,-10y)
        PenUp
        Displacement(37y,18y)
        PenDown
        Displacement(0y,-33y)
        Displacement(24y,13y)
        PenUp
        Displacement(0y,25y)
        PenDown
        Displacement(17y,-13y)
        Displacement(32y,-20y)
        PenUp
        Displacement(-15y,33y)
        PenDown
        Displacement(-17y,-13y)
    ]
    // 席
    53167us, [
        PenUp
        Displacement(59y,126y)
        PenDown
        Displacement(19y,-10y)
        PenUp
        Displacement(43y,-8y)
        PenDown
        Displacement(-101y,0y)
        Displacement(0y,-56y)
        Displacement(-6y,-31y)
        Displacement(-14y,-10y)
        PenUp
        Displacement(29y,74y)
        PenDown
        yield! Radical.廿 (40y,15y) (93y,36y)

        PenUp
        Displacement(-55y,-92y)
        PenDown
        yield! Radical.巾 64y [38y;18y;66y]

    ]
    // 习
    53168us, [
        PenUp
        Displacement(14y,108y)
        PenDown
        Displacement(93y,0y)
        Displacement(0y,-87y)
        Displacement(-8y,-8y)
        Displacement(-22y,-3y)
        PenUp
        Displacement(-47y,82y)
        PenDown
        Displacement(32y,-23y)
        PenUp
        Displacement(-50y,-41y)
        PenDown
        Displacement(76y,31y)
    ]
    // 媳
    53169us, [
        PenUp
        Displacement(32y,121y)
        PenDown
        Displacement(-19y,-74y)
        Displacement(37y,-23y)
        PenUp
        Displacement(-47y,61y)
        PenDown
        Displacement(46y,0y)
        Displacement(-3y,-20y)
        Displacement(-6y,-20y)
        Displacement(-9y,-15y)
        Displacement(-10y,-10y)
        Displacement(-14y,-13y)
        PenUp
        Displacement(75y,117y)
        PenDown
        Displacement(-5y,-18y)
        PenUp
        Displacement(-15y,-5y)
        PenDown
        yield! Radical.目(48y,51y)
        PenUp
        Displacement(-1y,-33y)
        PenDown

        Displacement(-14y,-25y)
        PenUp
        Displacement(25y,25y)
        PenDown
        Displacement(0y,-28y)
        Displacement(31y,0y)
        Displacement(4y,15y)
        PenUp
        Displacement(-24y,20y)
        PenDown
        Displacement(14y,-18y)
        PenUp
        Displacement(14y,13y)
        PenDown
        Displacement(17y,-25y)
    ]
    // 喜
    53170us, [
        PenUp
        Displacement(9y,108y)
        PenDown
        yield! Radical.多横中竖士 [110y;89y] [18y;33y]

        PenUp
        Displacement(-38y,-31y+18y)
        PenDown
        yield! Radical.口(76y,18y)
        PenUp
        Displacement(11y,-21y)
        PenDown
        Displacement(14y,-13y)
        PenUp
        Displacement(40y,13y)
        PenDown
        Displacement(-14y,-13y)
        PenUp
        Displacement(-71y,0y)
        PenDown
        Displacement(117y,0y)
        PenUp
        Displacement(-97y,-16y)
        PenDown
        yield! Radical.口(76y,22y)
    ]
    // 铣
    53171us, [
        PenUp
        Displacement(27y,121y)
        PenDown
        Displacement(-23y,-36y)
        PenUp
        Displacement(11y,13y)
        PenDown
        Displacement(34y,0y)
        PenUp
        Displacement(-43y,-23y)
        PenDown
        Displacement(41y,0y)
        PenUp
        Displacement(-42y,-25y)
        PenDown
        Displacement(46y,0y)
        PenUp
        Displacement(-27y,25y)
        PenDown
        Displacement(0y,-69y)
        Displacement(27y,23y)
        PenUp
        Displacement(5y,48y)
        PenDown
        Displacement(13y,33y)
        PenUp
        Displacement(18y,10y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(-24y,28y)
        PenDown
        Displacement(52y,0y)
        PenUp
        Displacement(6y,-31y)
        PenDown
        Displacement(-69y,0y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(-3y,-18y)
        Displacement(-6y,-18y)
        Displacement(-8y,-13y)
        Displacement(-13y,-13y)
        PenUp
        Displacement(46y,59y)
        PenDown
        Displacement(0y,-48y)
        Displacement(3y,-5y)
        Displacement(19y,0y)
        Displacement(4y,5y)
        Displacement(4y,10y)
    ]
    // 洗
    53172us, [
        PenUp
        Displacement(10y,113y)
        PenDown
        Displacement(23y,-15y)
        PenUp
        Displacement(-32y,-15y)
        PenDown
        Displacement(23y,-20y)
        PenUp
        Displacement(3y,-13y)
        PenDown
        Displacement(-24y,-41y)
        PenUp
        Displacement(55y,102y)
        PenDown
        Displacement(-20y,-33y)
        PenUp
        Displacement(13y,18y)
        PenDown
        Displacement(59y,0y)
        PenUp
        Displacement(-74y,-33y)
        PenDown
        Displacement(82y,0y)
        PenUp
        Displacement(-41y,61y)
        PenDown
        Displacement(0y,-59y)
        PenUp
        Displacement(-11y,-3y)
        PenDown
        Displacement(-1y,-15y)
        Displacement(-5y,-15y)
        Displacement(-11y,-18y)
        Displacement(-20y,-10y)
        PenUp
        Displacement(57y,59y)
        PenDown
        Displacement(0y,-48y)
        Displacement(5y,-10y)
        Displacement(24y,3y)
        Displacement(4y,5y)
        Displacement(3y,10y)
    ]
    // 系
    53173us, [
        PenUp
        Displacement(112y,113y)
        PenDown
        Displacement(-27y,-3y)
        Displacement(-41y-32y,0y)
        PenUp
        Displacement(48y,-3y)
        PenDown
        Displacement(-33y,-28y)
        Displacement(47y,0y)
        PenUp
        Displacement(22y,20y)
        PenDown
        Displacement(-25y,-20y)
        Displacement(-37y,-18y)
        Displacement(-13y,-8y)
        Displacement(79y,0y)
        PenUp
        Displacement(-13y,18y)
        PenDown
        Displacement(22y,-28y)
        PenUp
        Displacement(-46y,10y)
        PenDown
        Displacement(0y,-43y)
        Displacement(-18y,-5y)
        PenUp
        Displacement(-6y,38y)
        PenDown
        Displacement(-13y,-18y)
        Displacement(-18y,-13y)
        PenUp
        Displacement(73y,28y)
        PenDown
        Displacement(34y,-33y)
    ]
    // 隙
    53174us, [
        PenUp
        Displacement(11y,1y)
        PenDown
        Displacement(0y,115y)
        Displacement(28y,0y)
        Displacement(-17y,-36y)
        Displacement(13y,-15y)
        Displacement(1y,-13y)
        Displacement(-4y,-13y)
        Displacement(-13y,-5y)
        PenUp
        Displacement(60y,89y)
        PenDown
        Displacement(0y,-25y)
        PenUp
        Displacement(-19y,18y)
        PenDown
        Displacement(-15y,-23y)
        PenUp
        Displacement(52y,23y)
        PenDown
        Displacement(22y,-18y)
        PenUp
        Displacement(-64y,-21y)
        PenDown
        yield! Radical.日(51y,33y)
        PenUp
        Displacement(25y,-18y)
        PenDown

        Displacement(0y,-28y)
        Displacement(-1y,-5y)
        Displacement(-8y,-3y)
        Displacement(-8y,0y)
        PenUp
        Displacement(-5y,28y)
        PenDown
        Displacement(-20y,-25y)
        PenUp
        Displacement(57y,23y)
        PenDown
        Displacement(20y,-20y)
    ]
    // 戏
    53175us, [
        PenUp
        Displacement(5y,93y)
        PenDown
        Displacement(46y,0y)
        Displacement(-8y,-33y)
        Displacement(-5y,-10y)
        Displacement(-8y,-15y)
        Displacement(-11y,-10y)
        Displacement(-13y,-13y)
        PenUp
        Displacement(10y,61y)
        PenDown
        Displacement(37y,-48y)
        PenUp
        Displacement(1y,54y)
        PenDown
        Displacement(66y,10y)
        PenUp
        Displacement(-45y,38y)
        PenDown
        Displacement(0y,-43y)
        Displacement(3y,-23y)
        Displacement(5y,-18y)
        Displacement(3y,-8y)
        Displacement(13y,-18y)
        Displacement(9y,-10y)
        Displacement(5y,0y)
        Displacement(9y,15y)
        PenUp
        Displacement(-10y,46y)
        PenDown
        Displacement(-25y,-33y)
        Displacement(-17y,-15y)
        Displacement(-22y,-15y)
        PenUp
        Displacement(42y,110y)
        PenDown
        Displacement(19y,-18y)
    ]
    // 细
    53176us, [
        PenUp
        Displacement(34y,124y)
        PenDown
        Displacement(-28y,-46y)
        Displacement(28y,0y)
        PenUp
        Displacement(15y,20y)
        PenDown
        Displacement(-37y,-54y)
        Displacement(40y,0y)
        PenUp
        Displacement(-46y,-28y)
        PenDown
        Displacement(47y,13y)
        PenUp
        Displacement(8y,79y)
        PenDown
        yield! Radical.田(56y,92y)
    ]
    // 瞎
    53177us, [
        PenUp
        Displacement(10y,108y)
        PenDown
        yield! Radical.目(27y,82y)
        PenUp
        Displacement(64y,71y)
        PenDown
        Displacement(14y,-15y)
        PenUp
        Displacement(-36y,-25y)
        PenDown
        Displacement(0y,23y)
        Displacement(61y,0y)
        Displacement(0y,-23y)
        PenUp
        Displacement(-50y,3y)
        PenDown
        yield! Radical.多横中竖丰 [42y;56y;75y] [17y;47y;64y]

        PenUp
        Displacement(-25y,0y)
        PenDown
        yield! Radical.口(50y,28y)
    ]
    // 虾
    53178us, [
        PenUp
        Displacement(13y,96y)
        PenDown
        yield! Radical.中 42y [38y;31y;99y]

        PenUp
        Displacement(-31y,-8y)
        PenDown
        Displacement(55y,13y)
        PenUp
        Displacement(-8y,15y)
        PenDown
        Displacement(15y,-28y)
        PenUp
        Displacement(-13y,92y)
        PenDown
        Displacement(70y,0y)
        PenUp
        Displacement(-38y,-3y)
        PenDown
        Displacement(0y,-107y)
        PenUp
        Displacement(9y,79y)
        PenDown
        Displacement(25y,-36y)
    ]
    // 匣
    53179us, [
        PenUp
        Displacement(110y,116y)
        PenDown
        Displacement(-98y,0y)
        Displacement(0y,-104y)
        Displacement(108y,0y)
        PenUp
        Displacement(-87y,87y)
        PenDown
        yield! Radical.甲 (66y,46y) 79y
    ]
    // 霞
    53180us, [
        PenUp
        Displacement(18y,116y)
        PenDown
        yield! Radical.雨字头 (92y,43y)(104y,43y-12y-2y)

        PenUp
        Displacement(-93y,-74y)
        PenDown
        Displacement(0y,61y)
        Displacement(42y,0y)
        Displacement(0y,-15y)
        Displacement(-41y,0y)
        PenUp
        Displacement(0y,-13y)
        PenDown
        Displacement(41y,0y)
        PenUp
        Displacement(-41y,-15y)
        PenDown
        Displacement(41y,0y)
        PenUp
        Displacement(13y,43y)
        PenDown
        Displacement(38y,0y)
        Displacement(0y,-15y)
        Displacement(-38y,0y)
        PenUp
        Displacement(-6y,-13y)
        PenDown
        Displacement(47y,0y)
        Displacement(-9y,-13y)
        Displacement(-15y,-10y)
        Displacement(-15y,-8y)
        Displacement(-17y,-3y)
        PenUp
        Displacement(15y,33y)
        PenDown
        Displacement(11y,-13y)
        Displacement(10y,-8y)
        Displacement(14y,-8y)
        Displacement(15y,-5y)
    ]
    // 辖
    53181us, [
        PenUp
        Displacement(4y,101y)
        PenDown
        Displacement(45y,0y)
        PenUp
        Displacement(-15y,23y)
        PenDown
        Displacement(-25y,-61y)
        Displacement(43y,0y)
        PenUp
        Displacement(-50y,-31y)
        PenDown
        Displacement(54y,8y)
        PenUp
        Displacement(-22y,43y)
        PenDown
        Displacement(0y,-82y)
        PenUp
        Displacement(40y,122y)
        PenDown
        Displacement(18y,-13y)
        PenUp
        Displacement(-36y,-25y)
        PenDown
        Displacement(0y,20y)
        Displacement(60y,0y)
        Displacement(0y,-20y)
        PenUp
        Displacement(-50y,3y)
        PenDown
        yield! Radical.多横中竖丰 [42y;52y;68y] [18y;46y;59y]

        PenUp
        Displacement(-24y,0y)
        PenDown
        yield! Radical.口(48y,28y)
    ]
    // 暇
    53182us, [
        PenUp
        Displacement(10y,113y)
        PenDown
        yield! Radical.日(24y,76y)
        PenUp
        Displacement(39y,-76y)
        PenDown
        Displacement(0y,117y)
        Displacement(25y,0y)
        Displacement(0y,-31y)
        Displacement(-25y,0y)
        PenUp
        Displacement(3y,-23y)
        PenDown
        Displacement(23y,0y)
        PenUp
        Displacement(-23y,-28y)
        PenDown
        Displacement(24y,0y)
        PenUp
        Displacement(8y,79y)
        PenDown
        yield! Radical.匚(-25y,30y)
        PenUp
        Displacement(-23y,-79y)
        PenDown
        Displacement(11y,8y)
        Displacement(11y,5y)
        Displacement(11y,10y)
        Displacement(6y,13y)
        Displacement(5y,13y)
        Displacement(3y,13y)
        Displacement(-31y,0y)
        Displacement(5y,-18y)
        Displacement(6y,-15y)
        Displacement(10y,-15y)
        Displacement(20y,-13y)
    ]
    // 峡
    53183us, [
        PenUp
        Displacement(8y,93y)
        PenDown
        yield! Radical.山 37y [69y;84y]
        PenUp
        Displacement(28y,76y)
        PenDown
        Displacement(62y,0y)
        PenUp
        Displacement(-60y,-13y)
        PenDown
        Displacement(13y,-20y)
        PenUp
        Displacement(40y,18y)
        PenDown
        Displacement(-14y,-20y)
        PenUp
        Displacement(-43y,-10y)
        PenDown
        Displacement(71y,0y)
        PenUp
        Displacement(-41y,69y)
        PenDown
        Displacement(0y,-38y-20y)
        Displacement(-4y,-18y)
        Displacement(-6y,-13y)
        Displacement(-10y,-15y)
        Displacement(-11y,-10y)
        Displacement(-13y,-10y)
        PenUp
        Displacement(47y,56y)
        PenDown
        Displacement(4y,-13y)
        Displacement(8y,-15y)
        Displacement(11y,-13y)
        Displacement(14y,-10y)
    ]
    // 侠
    53184us, [
        PenUp
        Displacement(34y,121y)
        PenDown
        Displacement(-32y,-54y)
        PenUp
        Displacement(19y,23y)
        PenDown
        Displacement(0y,-89y)
        PenUp
        Displacement(22y,99y)
        PenDown
        yield! Radical.中心对齐等距横 [75y;87y] 46y

        PenUp
        Displacement(-46y,66y)
        PenDown
        Displacement(0y,-69y)
        Displacement(-6y,-18y)
        Displacement(-10y,-15y)
        Displacement(-13y,-13y)
        Displacement(-13y,-5y)
        PenUp
        Displacement(46y,51y)
        PenDown
        Displacement(9y,-20y)
        Displacement(11y,-13y)
        Displacement(20y,-15y)
        PenUp
        Displacement(-75y,82y)
        PenDown
        Displacement(14y,-18y)
        PenUp
        Displacement(50y,18y)
        PenDown
        Displacement(-15y,-20y)
    ]
    // 狭
    53185us, [
        PenUp
        Displacement(41y,119y)
        PenDown
        Displacement(-37y,-38y)
        PenUp
        Displacement(3y,41y)
        PenDown
        Displacement(18y,-18y)
        Displacement(10y,-20y)
        Displacement(5y,-25y)
        Displacement(0y,-23y)
        Displacement(-9y,-20y)
        Displacement(-18y,-5y)
        PenUp
        Displacement(23y,66y)
        PenDown
        Displacement(-33y,-33y)
        PenUp
        Displacement(46y,56y)
        PenDown
        Displacement(69y,0y)
        PenUp
        Displacement(-65y,-13y)
        PenDown
        Displacement(13y,-20y)
        PenUp
        Displacement(43y,20y)
        PenDown
        Displacement(-14y,-20y)
        PenUp
        Displacement(-50y,-10y)
        PenDown
        Displacement(76y,0y)
        PenUp
        Displacement(-41y,69y)
        PenDown
        Displacement(0y,-69y)
        Displacement(-5y,-15y)
        Displacement(-11y,-20y)
        Displacement(-14y,-10y)
        Displacement(-11y,-5y)
        PenUp
        Displacement(40y,51y)
        PenDown
        Displacement(10y,-18y)
        Displacement(8y,-13y)
        Displacement(9y,-10y)
        Displacement(15y,-13y)
    ]
    // 下
    53186us, [
        PenUp
        Displacement(4y,113y)
        PenDown
        Displacement(111y,0y)
        PenUp
        Displacement(-59y,-3y)
        PenDown
        Displacement(0y,-102y)
        PenUp
        Displacement(14y,74y)
        PenDown
        Displacement(38y,-31y)
    ]
    // 厦
    53187us, [
        PenUp
        Displacement(125y,124y)
        PenDown
        Displacement(-111y,0y)
        Displacement(0y,-48y-15y)
        Displacement(-4y,-15y)
        Displacement(-5y,-13y)
        Displacement(-5y,-20y)
        PenUp
        Displacement(25y,97y)
        PenDown
        Displacement(90y,0y)
        PenUp
        Displacement(-43y,0y)
        PenDown
        Displacement(-5y,-10y)

        PenUp
        Displacement(-31y,-2y)
        PenDown
        yield! Radical.目(66y,41y)
        PenUp
        Displacement(26y,-15y)
        PenDown

        Displacement(-11y,-10y)
        Displacement(-13y,-8y)
        Displacement(-14y,-8y)
        PenUp
        Displacement(27y,13y)
        PenDown
        Displacement(47y,0y)
        Displacement(-15y,-13y)
        Displacement(-11y,-8y)
        Displacement(-19y,-8y)
        Displacement(-19y,-5y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(29y,28y)
        PenDown
        Displacement(14y,-10y)
        Displacement(14y,-8y)
        Displacement(15y,-3y)
        Displacement(27y,-3y)
    ]
    // 夏
    53188us, [
        PenUp
        Displacement(64y-45y,116y)
        PenDown
        Displacement(99y,0y)
        PenUp
        Displacement(45y-99y,0y)
        PenDown
        Displacement(-10y,-15y)
        PenUp
        Displacement(-25y,0y)
        PenDown
        yield! Radical.目(71y,42y)
        PenUp
        Displacement(23y,-17y)
        PenDown
        Displacement(-10y,-10y)
        Displacement(-11y,-10y)
        Displacement(-13y,-8y)
        PenUp
        Displacement(27y,15y)
        PenDown
        Displacement(51y,0y)
        Displacement(-13y,-13y)
        Displacement(-20y,-15y)
        Displacement(-20y,-8y)
        Displacement(-28y,-8y)
        PenUp
        Displacement(31y,36y)
        PenDown
        Displacement(22y,-13y)
        Displacement(19y,-8y)
        Displacement(36y,-10y)
    ]
    // 吓
    53189us, [
        PenUp
        Displacement(9y,52y)
        PenDown
        yield! Radical.口(31y,-61y)
        PenUp
        Displacement(34y,64y)
        PenDown
        Displacement(75y,0y)
        PenUp
        Displacement(-42y,-3y)
        PenDown
        Displacement(0y,-107y)
        PenUp
        Displacement(13y,79y)
        PenDown
        Displacement(28y,-38y)
    ]
    // 掀
    53190us, [
        PenUp
        Displacement(5y,93y)
        PenDown
        Displacement(34y,5y)
        PenUp
        Displacement(-14y,25y)
        PenDown
        Displacement(0y,-99y)
        Displacement(-3y,-10y)
        Displacement(-4y,-3y)
        Displacement(-10y,-3y)
        PenUp
        Displacement(-3y,41y)
        PenDown
        Displacement(34y,20y)
        PenUp
        Displacement(33y,48y)
        PenDown
        Displacement(-28y,-10y)
        Displacement(-1y,-43y)
        Displacement(0y,-23y)
        Displacement(-5y,-18y)
        Displacement(-6y,-8y)
        PenUp
        Displacement(15y,59y)
        PenDown
        Displacement(28y,0y)
        PenUp
        Displacement(-9y,0y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(25y,104y)
        PenDown
        Displacement(-8y,-25y)
        Displacement(-9y,-18y)
        PenUp
        Displacement(11y,15y)
        PenDown
        Displacement(29y,0y)
        Displacement(-4y,-18y)
        PenUp
        Displacement(-22y,5y)
        PenDown
        Displacement(0y,-33y)
        Displacement(-8y,-20y)
        Displacement(-8y,-13y)
        Displacement(-11y,-10y)
        PenUp
        Displacement(29y,48y)
        PenDown
        Displacement(11y,-25y)
        Displacement(14y,-20y)
    ]
    // 锨
    53191us, [
        PenUp
        Displacement(29y,121y)
        PenDown
        Displacement(-27y,-41y)
        PenUp
        Displacement(14y,18y)
        PenDown
        Displacement(27y,0y)
        PenUp
        Displacement(-33y,-20y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-38y,-23y)
        PenDown
        Displacement(41y,0y)
        PenUp
        Displacement(-24y,20y)
        PenDown
        Displacement(0y,-61y)
        Displacement(22y,20y)
        PenUp
        Displacement(37y,79y)
        PenDown
        Displacement(-28y,-5y)
        Displacement(0y,-54y-15y)
        Displacement(-5y,-15y)
        Displacement(-14y,-18y)
        PenUp
        Displacement(23y,76y)
        PenDown
        Displacement(27y,3y)
        PenUp
        Displacement(-13y,-5y)
        PenDown
        Displacement(0y,-61y)
        PenUp
        Displacement(27y,102y)
        PenDown
        Displacement(-17y,-51y)
        PenUp
        Displacement(11y,23y)
        PenDown
        Displacement(28y,0y)
        Displacement(-6y,-20y)
        PenUp
        Displacement(-14y,5y)
        PenDown
        Displacement(0y,-15y)
        Displacement(-5y-6y,-18y-18y)
        Displacement(-10y,-15y)
        Displacement(-10y,-8y)
        PenUp
        Displacement(32y,51y)
        PenDown
        Displacement(3y+4y,-13y-13y)
        Displacement(8y+9y,-13y-13y)
    ]
    // 先
    53192us, [
        PenUp
        Displacement(42y,116y)
        PenDown
        Displacement(-10y,-23y)
        Displacement(-13y,-15y)
        PenUp
        Displacement(13y,18y)
        PenDown
        Displacement(76y,0y)
        PenUp
        Displacement(-43y,31y)
        PenDown
        Displacement(0y,-61y)
        PenUp
        Displacement(-55y,0y)
        PenDown
        Displacement(110y,0y)
        PenUp
        Displacement(-69y,0y)
        PenDown
        Displacement(-3y,-25y)
        Displacement(-6y,-15y)
        Displacement(-13y,-13y)
        Displacement(-20y,-8y)
        PenUp
        Displacement(68y,61y)
        PenDown
        Displacement(0y,-51y)
        Displacement(3y,-8y)
        Displacement(33y,0y)
        Displacement(6y,3y)
        Displacement(0y,15y)
    ]
    // 仙
    53193us, [
        PenUp
        Displacement(40y,124y)
        PenDown
        Displacement(-13y,-36y)
        Displacement(-20y,-23y)
        PenUp
        Displacement(19y,23y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(24y,89y)
        PenDown
        yield! Radical.山 68y [79y;94y]
    ]
    // 鲜
    53194us, [
        PenUp
        Displacement(28y,124y)
        PenDown
        Displacement(-23y,-36y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(29y,0y)
        Displacement(-14y,-18y)
        PenUp
        Displacement(-24y,-3y)
        PenDown
        yield! Radical.田(43y,48y)
        PenUp
        Displacement(-29y,-25y)
        PenDown
        Displacement(57y,8y)
        PenUp
        Displacement(5y,99y)
        PenDown
        Displacement(17y,-18y)
        PenUp
        Displacement(28y,18y)
        PenDown
        Displacement(-18y,-25y)
        PenUp
        Displacement(-33y,-3y)
        PenDown
        yield! Radical.多横中竖干 [61y;51y;65y] [28y;89y]            

    ]
    // 纤
    53195us, [
        PenUp
        Displacement(37y,126y)
        PenDown
        Displacement(-11y,-20y)
        Displacement(-10y,-13y)
        Displacement(-6y,-10y)
        Displacement(31y,0y)
        PenUp
        Displacement(13y,20y)
        PenDown
        Displacement(-15y,-23y)
        Displacement(-14y,-18y)
        Displacement(-11y,-13y)
        Displacement(43y,0y)
        PenUp
        Displacement(-50y,-33y)
        PenDown
        Displacement(47y,10y)
        PenUp
        Displacement(66y,89y)
        PenDown
        Displacement(-27y,-3y)
        Displacement(-18y,-3y)
        Displacement(-15y,0y)
        PenUp
        Displacement(-8y,-43y)
        PenDown
        yield! Radical.十 75y [46y; 110y]

    ]
    // 咸
    53196us, [
        PenUp
        Displacement(97y,119y)
        PenDown
        Displacement(15y,-13y)
        PenUp
        Displacement(8y,-10y)
        PenDown
        Displacement(-96y,0y)
        Displacement(0y,-51y)
        Displacement(-4y,-18y)
        Displacement(-13y,-23y)
        PenUp
        Displacement(24y,71y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-36y,-18y)
        PenDown
        yield! Radical.口(28y,31y)
        PenUp
        Displacement(42y,66y)
        PenDown
        Displacement(0y,-54y)
        Displacement(8y,-36y)
        Displacement(10y,-20y)
        Displacement(13y,-10y)
        Displacement(8y,18y)
        PenUp
        Displacement(-6y,59y)
        PenDown
        Displacement(-18y,-41y)
        Displacement(-13y,-18y)
        Displacement(-18y,-15y)
    ]
    // 贤
    53197us, [
        PenUp
        Displacement(17y,119y)
        PenDown
        Displacement(0y,-48y)
        PenUp
        Displacement(25y,54y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(14y,48y)
        PenDown
        Displacement(54y,0y)
        Displacement(-17y,-23y)
        Displacement(-11y,-10y)
        Displacement(-24y,-10y)
        PenUp
        Displacement(10y,46y)
        PenDown
        Displacement(18y,-25y)
        Displacement(17y,-10y)
        Displacement(20y,-5y)
        PenUp
        Displacement(-89y,-54y)
        PenDown
        Displacement(0y,43y)
        Displacement(66y,0y)
        Displacement(0y,-36y)
        PenUp
        Displacement(-33y,23y)
        PenDown
        Displacement(-4y,-23y)
        Displacement(-9y,-13y)
        Displacement(-14y,-10y)
        Displacement(-28y,-8y)
        PenUp
        Displacement(64y,25y)
        PenDown
        Displacement(45y,-20y)
    ]
    // 衔
    53198us, [
        PenUp
        Displacement(29y,124y)
        PenDown
        Displacement(-8y,-13y)
        Displacement(-10y,-13y)
        Displacement(-9y,-10y)
        PenUp
        Displacement(25y,0y)
        PenDown
        Displacement(-8y,-15y)
        Displacement(-9y,-10y)
        Displacement(-10y,-13y)
        PenUp
        Displacement(19y,23y)
        PenDown
        Displacement(0y,-71y)
        PenUp
        Displacement(37y,120y)
        PenDown
        Displacement(-23y,-38y)
        PenUp
        Displacement(13y,18y)
        PenDown
        Displacement(31y,0y)
        PenUp
        Displacement(-37y,-23y)
        PenDown
        Displacement(34y,0y)
        PenUp
        Displacement(-41y,-23y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-23y,23y)
        PenDown
        Displacement(0y,-61y)
        Displacement(25y,15y)
        PenUp
        Displacement(3y,79y)
        PenDown
        yield! Radical.中心对齐等距横 [37y;46y] 33y

        PenUp
        Displacement(-20y,-3y)
        PenDown
        Displacement(0y,-61y)
        Displacement(-3y,-5y)
        Displacement(-8y,-5y)
        Displacement(-9y,0y)
    ]
    // 舷
    53199us, [
        PenUp
        Displacement(41y,121y)
        PenDown
        Displacement(-9y,-15y)
        PenUp
        Displacement(-24y,-102y)
        PenDown
        Displacement(5y,8y)
        Displacement(4y,10y)
        Displacement(4y,13y)
        Displacement(0y,69y)
        Displacement(32y,0y)
        Displacement(0y,-89y)
        Displacement(-3y,-5y)
        Displacement(-5y,-3y)
        Displacement(-9y,-3y)
        PenUp
        Displacement(-33y,59y)
        PenDown
        Displacement(62y,0y)
        PenUp
        Displacement(-33y,28y)
        PenDown
        Displacement(10y,-18y)
        PenUp
        Displacement(-10y,-20y)
        PenDown
        Displacement(10y,-18y)
        PenUp
        Displacement(40y,84y)
        PenDown
        Displacement(17y,-20y)
        PenUp
        Displacement(-37y,-5y)
        PenDown
        Displacement(66y,0y)
        PenUp
        Displacement(-37y,-3y)
        PenDown
        Displacement(-24y,-36y)
        Displacement(31y,0y)
        PenUp
        Displacement(14y,23y)
        PenDown
        Displacement(-22y,-36y)
        Displacement(-27y,-33y)
        Displacement(47y,10y)
        PenUp
        Displacement(-8y,20y)
        PenDown
        Displacement(17y,-36y)
    ]
    // 闲
    53200us, [
        PenUp
        Displacement(17y,3y)
        PenDown
        yield! Radical.门(93y,107y)
        PenUp
        Displacement(-63y,57y)
        PenDown
        yield! Radical.十 71y [28y;87y]

        PenUp
        Displacement(-2y,59y)
        PenDown
        Displacement(-13y,-18y)
        Displacement(-17y,-20y)
        PenUp
        Displacement(34y,33y)
        PenDown
        Displacement(29y,-31y)
    ]
    // 涎
    53201us, [
        PenUp
        Displacement(17y,116y)
        PenDown
        Displacement(22y,-18y)
        PenUp
        Displacement(-31y,-15y)
        PenDown
        Displacement(19y,-18y)
        PenUp
        Displacement(3y,-13y)
        PenDown
        Displacement(-20y,-48y)
        PenUp
        Displacement(32y,104y)
        PenDown
        Displacement(23y,0y)
        Displacement(-23y,-38y)
        Displacement(24y,0y)
        Displacement(-4y,-20y)
        Displacement(-4y,-10y)
        Displacement(-6y,-10y)
        Displacement(-8y-11y,-10y-10y)
        Displacement(-8y,-5y)
        PenUp
        Displacement(17y,54y)
        PenDown
        Displacement(4y,-13y)
        Displacement(5y,-10y)
        Displacement(6y,-10y)
        Displacement(6y,-8y)
        Displacement(10y,-5y)
        Displacement(14y,-3y)
        Displacement(34y,0y)
        PenUp
        Displacement(-48y,94y)
        PenDown
        Displacement(43y,8y)
        PenUp
        Displacement(-22y,-5y)
        PenDown
        Displacement(0y,-74y)
        PenUp
        Displacement(4y,38y)
        PenDown
        Displacement(19y,0y)
        PenUp
        Displacement(-43y,15y)
        PenDown
        Displacement(0y,-56y)
        Displacement(42y,0y)
    ]
    // 弦
    53202us, [
        PenUp
        Displacement(3y,111y)
        PenDown
        Displacement(33y,0y)
        Displacement(0y,-25y)
        Displacement(-25y,0y)
        Displacement(0y,-25y-5y)
        Displacement(29y,0y)
        Displacement(-4y,-36y)
        Displacement(-5y,-10y)
        Displacement(-20y,-3y)
        PenUp
        Displacement(60y,117y)
        PenDown
        Displacement(18y,-20y)
        PenUp
        Displacement(-43y,-8y)
        PenDown
        Displacement(74y,0y)
        PenUp
        Displacement(-43y,-3y)
        PenDown
        Displacement(-20y,-36y)
        Displacement(29y,0y)
        PenUp
        Displacement(18y,28y)
        PenDown
        Displacement(-47y,-71y)
        Displacement(54y,8y)
        PenUp
        Displacement(-11y,23y)
        PenDown
        Displacement(23y,-36y)
    ]
    // 嫌
    53203us, [
        PenUp
        Displacement(28y,124y)
        PenDown
        Displacement(-17y,-71y)
        Displacement(31y,-23y)
        PenUp
        Displacement(-38y,61y)
        PenDown
        Displacement(38y,0y)
        Displacement(-3y,-23y)
        Displacement(-8y,-23y)
        Displacement(-9y,-15y)
        Displacement(-9y,-10y)
        Displacement(-11y,-5y)
        PenUp
        Displacement(54y,110y)
        PenDown
        Displacement(18y,-18y)
        PenUp
        Displacement(31y,15y)
        PenDown
        Displacement(-18y,-18y)
        PenUp
        Displacement(-38y+36y-11y,0y-98y)
        PenDown
        yield! Radical.业无八 [72y;22y] -98y
        PenUp
        Displacement(-65y,-18y)
        PenDown
        yield! Radical.躺巾 [58y;80y] 36y
        PenUp
        Displacement(-52y-8y,-20y)
        PenDown
        Displacement(-5y,-8y)
        Displacement(-9y,-10y)
        Displacement(-15y,-8y)
        PenUp
        Displacement(60y,28y)
        PenDown
        Displacement(11y,-15y)
        Displacement(9y,-10y)
        Displacement(9y,-5y)
    ]
    // 显
    53204us, [
        PenUp
        Displacement(23y,116y)
        PenDown
        yield! Radical.日(78y,46y)

        PenUp
        Displacement(31y,-26y)
        PenDown
        yield! Radical.业无八 [120y;24y] 51y

        PenUp
        Displacement(-103y,43y)
        PenDown
        Displacement(19y,-31y)
        PenUp
        Displacement(69y,33y)
        PenDown
        Displacement(-23y,-31y)
    ]
    // 险
    53205us, [
        PenUp
        Displacement(6y,1y)
        PenDown
        Displacement(0y,115y)
        Displacement(29y,0y)
        Displacement(-17y,-36y)
        Displacement(11y,-13y)
        Displacement(5y,-13y)
        Displacement(0y,-10y)
        Displacement(-4y,-8y)
        Displacement(-8y,-5y)
        Displacement(-8y,0y)
        PenUp
        Displacement(19y,41y)
        PenDown
        Displacement(10y,8y)
        Displacement(10y,10y)
        Displacement(9y,13y)
        Displacement(6y,13y)
        Displacement(4y,10y)
        PenUp
        Displacement(0y,-8y)
        PenDown
        Displacement(6y,-10y)
        Displacement(8y,-10y)
        Displacement(9y,-8y)
        Displacement(10y,-8y)
        Displacement(11y,-5y)
        PenUp
        Displacement(-66y,-5y)
        PenDown
        Displacement(50y,0y)
        PenUp
        Displacement(-55y,-23y)
        PenDown
        Displacement(15y,-25y)
        PenUp
        Displacement(6y,33y)
        PenDown
        Displacement(14y,-23y)
        PenUp
        Displacement(22y,18y)
        PenDown
        Displacement(-20y,-43y)
        PenUp
        Displacement(-45y,0y)
        PenDown
        Displacement(78y,0y)
    ]
    // 现
    53206us, [
        PenUp
        Displacement(6y,111y)
        PenDown
        yield! Radical.中心对齐等距横 [47y;41y] 36y

        PenUp
        Displacement(-46y,-48y)
        PenDown
        Displacement(50y,15y)
        PenUp
        Displacement(-27y,69y)
        PenDown
        Displacement(0y,-74y)
        PenUp
        Displacement(33y,18y)
        PenDown
        Displacement(0y,59y)
        Displacement(50y,0y)
        Displacement(0y,-59y)
        PenUp
        Displacement(-23y,38y)
        PenDown
        Displacement(-5y,-38y)
        Displacement(-8y,-18y)
        Displacement(-11y,-13y)
        Displacement(-13y,-10y)
        Displacement(-13y,-5y)
        PenUp
        Displacement(52y,46y)
        PenDown
        Displacement(0y,-33y)
        Displacement(1y,-5y)
        Displacement(3y,-8y)
        Displacement(19y,0y)
        Displacement(5y,8y)
        Displacement(4y,8y)
    ]
    // 献
    53207us, [
        PenUp
        Displacement(5y,103y)
        PenDown
        yield! Radical.十 65y [20y; 38y]

        PenUp
        Displacement(-25y,-82y)
        PenDown
        Displacement(0y,76y)
        Displacement(52y,0y)
        Displacement(0y,-64y)
        Displacement(-6y,-8y)
        Displacement(-13y,-3y)
        PenUp
        Displacement(-18y,66y)
        PenDown
        Displacement(8y,-13y)
        PenUp
        Displacement(15y,15y)
        PenDown
        Displacement(-9y,-18y)
        PenUp
        Displacement(-23y,-5y)
        PenDown
        yield! Radical.多横中竖干 [37y;34y] [18y;41y]            

        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(54y,0y)
        PenUp
        Displacement(-28y,38y)
        PenDown
        Displacement(0y,-31y)
        Displacement(-4y,-25y)
        Displacement(-5y,-25y)
        Displacement(-10y,-20y)
        Displacement(-11y,-15y)
        PenUp
        Displacement(32y,61y)
        PenDown
        Displacement(4y,-18y)
        Displacement(9y,-13y)
        Displacement(13y,-23y)
        Displacement(4y,-5y)
        PenUp
        Displacement(-20y,104y)
        PenDown
        Displacement(13y,-18y)
    ]
    // 县
    53208us, [
        PenUp
        Displacement(3y,55y)
        PenDown
        yield! Radical.且 [66y;120y] 64y

        PenUp
        Displacement(-33y-12y,-3y)
        PenDown
        Displacement(-38y,-33y)
        Displacement(82y,0y)
        PenUp
        Displacement(-20y,25y)
        PenDown
        Displacement(36y,-33y)
    ]
    // 腺
    53209us, [
        PenUp
        Displacement(5y,4y)
        PenDown
        Displacement(5y,13y)
        Displacement(4y,10y)
        Displacement(1y,10y)
        Displacement(0y,79y)
        Displacement(23y,-3y)
        Displacement(0y,-97y)
        Displacement(-3y,-5y)
        Displacement(-13y,-3y)
        PenUp
        Displacement(-4y,71y)
        PenDown
        Displacement(17y,0y)
        PenUp
        Displacement(-17y,-28y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(45y,74y)
        PenDown
        Displacement(-8y,-13y)
        PenUp
        Displacement(-14y,-6y)
        PenDown
        yield! Radical.日(48y,34y)
        PenUp
        Displacement(26y,-18y)
        PenDown
        Displacement(0y,-64y)
        Displacement(-6y,-5y)
        Displacement(-14y,0y)
        PenUp
        Displacement(-13y,51y)
        PenDown
        Displacement(20y,-5y)
        Displacement(-4y,-18y)
        Displacement(-11y,-15y)
        Displacement(-9y,-8y)
        PenUp
        Displacement(70y,54y)
        PenDown
        Displacement(-18y,-18y)
        PenUp
        Displacement(-11y,13y)
        PenDown
        Displacement(15y,-23y)
        Displacement(23y,-20y)
    ]
    // 馅
    53210us, [
        PenUp
        Displacement(33y,126y)
        PenDown
        Displacement(-10y,-23y)
        Displacement(-19y,-23y)
        PenUp
        Displacement(19y,23y)
        PenDown
        Displacement(28y,0y)
        Displacement(-8y,-20y)
        PenUp
        Displacement(-19y,-3y)
        PenDown
        Displacement(0y,-66y)
        Displacement(23y,13y)
        PenUp
        Displacement(37y,102y)
        PenDown
        Displacement(-6y,-23y)
        Displacement(-8y,-15y)
        Displacement(-13y,-13y)
        PenUp
        Displacement(22y,30y)
        PenDown
        Displacement(40y,0y)
        Displacement(-15y,-31y)
        PenUp
        Displacement(-44y,-41y)
        PenDown
        yield! Radical.臼(60y,48y)

    ]
    // 羡
    53211us, [
        PenUp
        Displacement(38y,126y)
        PenDown
        Displacement(15y,-13y)
        PenUp
        Displacement(38y,10y)
        PenDown
        Displacement(-10y,-13y)
        PenUp
        Displacement(-66y,-3y)
        PenDown
        yield! Radical.多横中竖工 [101y;85y;110y] 18y

        PenUp
        Displacement(-49y,-7y)
        PenDown
        Displacement(22y,-15y)
        PenUp
        Displacement(-29y,-31y)
        PenDown
        Displacement(33y,13y)
        PenUp
        Displacement(23y,38y)
        PenDown

        Displacement(-20y,-31y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(47y,0y)
        Displacement(-8y,-18y)
        PenUp
        Displacement(-25y,10y)
        PenDown
        Displacement(-5y,-15y)
        Displacement(-6y,-10y)
        Displacement(-18y,-13y)
        Displacement(-15y,-8y)
        PenUp
        Displacement(45y,36y)
        PenDown
        Displacement(13y,-15y)
        Displacement(18y,-10y)
        Displacement(14y,-8y)
    ]
    // 宪
    53212us, [
        PenUp
        Displacement(59y,119y)
        PenDown
        Displacement(14y,-8y)
        PenUp
        Displacement(-57y,-28y)
        PenDown
        Displacement(0y,20y)
        Displacement(101y,0y)
        Displacement(0y,-20y)
        PenUp
        Displacement(-74y,7y)
        PenDown
        Displacement(-9y,-13y)
        Displacement(-13y,-13y)
        PenUp
        Displacement(15y,10y)
        PenDown
        Displacement(68y,0y)
        PenUp
        Displacement(-93y,-25y)
        PenDown
        Displacement(111y,0y)
        PenUp
        Displacement(-56y,46y)
        PenDown
        Displacement(0y,-41y)
        PenUp
        Displacement(-10y,-5y)
        PenDown
        Displacement(0y,-10y)
        Displacement(-9y,-18y)
        Displacement(-15y,-10y)
        Displacement(-23y,-10y)
        PenUp
        Displacement(70y,48y)
        PenDown
        Displacement(0y,-38y)
        Displacement(3y,-8y)
        Displacement(32y,0y)
        Displacement(4y,5y)
        Displacement(4y,18y)
    ]
    // 陷
    53213us, [
        PenUp
        Displacement(13y,1y)
        PenDown
        Displacement(0y,117y)
        Displacement(33y,0y)
        Displacement(-17y,-36y)
        Displacement(9y,-10y)
        Displacement(4y,-8y)
        Displacement(1y,-13y)
        Displacement(-1y,-10y)
        Displacement(-5y-5y,-5y-5y)
        Displacement(-8y,0y)
        PenUp
        Displacement(52y,94y)
        PenDown
        Displacement(-4y,-13y)
        Displacement(-6y,-13y)
        Displacement(-6y,-10y)
        Displacement(-10y,-10y)
        PenUp
        Displacement(22y,28y)
        PenDown
        Displacement(42y,0y)
        Displacement(-20y,-31y)
        PenUp
        Displacement(-38y,-39y)
        PenDown
        yield! Radical.臼(60y,48y)

    ]
    // 限
    53214us, [
        PenUp
        Displacement(6y,6y)
        PenDown
        Displacement(0y,115y)
        Displacement(37y,0y)
        Displacement(-22y,-33y)
        Displacement(10y,-10y)
        Displacement(6y,-10y)
        Displacement(3y,-8y)
        Displacement(-3y,-10y)
        Displacement(-6y,-8y)
        Displacement(-8y,-3y)
        Displacement(-8y,0y)
        PenUp
        Displacement(61y,-12y)
        PenDown
        Displacement(-25y,-18y)
        Displacement(0y,112y)
        yield! Radical.彐(52y,50y)
        PenUp
        Displacement(22y,-25y)
        PenDown
        Displacement(3y,-13y)
        Displacement(4y,-10y)
        Displacement(12y,-20y)
        Displacement(8y,-8y)
        Displacement(11y,-8y)
        PenUp
        Displacement(-3y,48y)
        PenDown
        Displacement(-24y,-18y)
    ]
    // 线
    53215us, [
        PenUp
        Displacement(34y,124y)
        PenDown
        Displacement(-25y,-41y)
        Displacement(31y,0y)
        PenUp
        Displacement(10y,23y)
        PenDown
        Displacement(-37y,-56y)
        Displacement(34y,5y)
        PenUp
        Displacement(-42y,-41y)
        PenDown
        Displacement(46y,18y)
        PenUp
        Displacement(1y,54y)
        PenDown
        Displacement(64y,8y)
        PenUp
        Displacement(-62y,-41y)
        PenDown
        Displacement(69y,15y)
        PenUp
        Displacement(-45y,56y)
        PenDown
        Displacement(0y,-54y)
        Displacement(5y,-23y)
        Displacement(5y,-20y)
        Displacement(14y,-18y)
        Displacement(9y,-5y)
        Displacement(6y,3y)
        Displacement(5y,16y)
        PenUp
        Displacement(-9y,33y)
        PenDown
        Displacement(-23y,-25y)
        Displacement(-20y,-15y)
        Displacement(-20y,-5y)
        PenUp
        Displacement(45y,107y)
        PenDown
        Displacement(17y,-13y)
    ]
    // 相
    53216us, [
        PenUp
        Displacement(6y,93y)
        PenDown
        yield! Radical.十 48y [33y;120y]

        PenUp
        Displacement(-1y,79y)
        PenDown
        Displacement(-11y,-18y)
        Displacement(-11y,-20y)
        PenUp
        Displacement(28y,36y)
        PenDown
        Displacement(17y,-18y)
        PenUp
        Displacement(11y,48y)
        PenDown
        yield! Radical.目(50y,107y)
    ]
    // 厢
    53217us, [
        PenUp
        Displacement(124y,116y)
        PenDown
        Displacement(-104y,0y)
        Displacement(-1y,-54y)
        Displacement(0y,-20y)
        Displacement(-5y,-15y)
        Displacement(-8y,-15y)
        PenUp
        Displacement(24y,71y)
        PenDown
        yield! Radical.十 40y [25y;102y]

        PenUp
        Displacement(-3y,64y)
        PenDown
        Displacement(-6y,-13y)
        Displacement(-15y,-18y)
        PenUp
        Displacement(25y,28y)
        PenDown
        Displacement(17y,-15y)
        PenUp
        Displacement(10y,41y)
        PenDown
        yield! Radical.目(38y,87y)
    ]
    // 镶
    53218us, [
        PenUp
        Displacement(25y,124y)
        PenDown
        Displacement(-23y,-38y)
        PenUp
        Displacement(13y,18y)
        PenDown
        Displacement(28y,0y)
        PenUp
        Displacement(-34y,-20y)
        PenDown
        Displacement(31y,0y)
        PenUp
        Displacement(-34y,-25y)
        PenDown
        Displacement(37y,0y)
        PenUp
        Displacement(-19y,23y)
        PenDown
        Displacement(0y,-66y)
        Displacement(20y,23y)
        PenUp
        Displacement(28y,89y)
        PenDown
        Displacement(15y,-10y)
        PenUp
        Displacement(-38y,-5y)
        PenDown
        Displacement(73y,0y)
        PenUp
        Displacement(-71y,-25y)
        PenDown
        yield! Radical.口(27y,-13y)
        PenUp
        Displacement(38y,0y)
        PenDown
        yield! Radical.口(27y,-13y)
        PenUp
        Displacement(-42y,-15y)
        PenDown
        yield! Radical.冓头 [28y;65y;78y] [13y;38y]

        PenUp
        Displacement(-39y,-5y)
        PenDown
        Displacement(-36y,-28y)
        PenUp
        Displacement(24y,15y)
        PenDown
        Displacement(0y,-25y)
        Displacement(20y,15y)
        PenUp
        Displacement(-1y,18y)
        PenDown
        Displacement(42y,-33y)
        PenUp
        Displacement(-14y,31y)
        PenDown
        Displacement(-14y,-10y)
    ]
    // 香
    53219us, [
        PenUp
        Displacement(104y,120y)
        PenDown
        Displacement(-37y,-3y)
        Displacement(-24y,-1y)
        Displacement(-24y,0y)
        PenUp
        Displacement(-11y,-23y)
        PenDown
        yield! Radical.十 115y [23y;59y]

        PenUp
        Displacement(-1y,36y)
        PenDown
        Displacement(-15y,-13y)
        Displacement(-19y,-15y)
        Displacement(-22y,-10y)
        PenUp
        Displacement(64y,38y)
        PenDown
        Displacement(13y,-13y)
        Displacement(13y,-10y)
        Displacement(27y,-15y)
        PenUp
        Displacement(-93y,-3y)
        PenDown
        yield! Radical.日(66y,51y)
    ]
    // 箱
    53220us, [
        PenUp
        Displacement(29y,126y)
        PenDown
        Displacement(-27y,-38y)
        PenUp
        Displacement(20y,25y)
        PenDown
        Displacement(41y,0y)
        PenUp
        Displacement(-28y,-3y)
        PenDown
        Displacement(10y,-18y)
        PenUp
        Displacement(33y,33y)
        PenDown
        Displacement(-22y,-38y)
        PenUp
        Displacement(18y,20y)
        PenDown
        Displacement(46y,0y)
        PenUp
        Displacement(-33y,0y)
        PenDown
        Displacement(13y,-15y)
        PenUp
        Displacement(-97y,-25y)
        PenDown
        yield! Radical.十 48y [23y;89y]

        PenUp
        Displacement(0y,56y)
        PenDown
        Displacement(-25y,-33y)
        PenUp
        Displacement(27y,36y)
        PenDown
        Displacement(20y,-20y)
        PenUp
        Displacement(10y,41y)
        PenDown
        yield! Radical.目(47y,79y)
    ]
    // 襄
    53221us, [
        PenUp
        Displacement(54y,124y)
        PenDown
        Displacement(14y,-10y)
        PenUp
        Displacement(-64y,-3y)
        PenDown
        Displacement(117y,0y)
        PenUp
        Displacement(-98y,-15y)
        PenDown
        yield! Radical.口(31y,15y)
        PenUp
        Displacement(50y,0y)
        PenDown
        yield! Radical.口(31y,15y)

        PenUp
        Displacement(-57y,-28y)
        PenDown
        yield! Radical.冓头 [38y;88y;119y] [14y;38y]

        PenUp
        Displacement(-75y,-3y)
        PenDown
        Displacement(-11y,-13y)
        Displacement(-30y,-10y)
        PenUp
        Displacement(33y,13y)
        PenDown
        Displacement(0y,-25y)
        Displacement(28y,15y)
        PenUp
        Displacement(37y,15y)
        PenDown
        Displacement(-15y,-13y)
        PenUp
        Displacement(-23y,13y)
        PenDown
        Displacement(13y,-10y)
        Displacement(19y,-8y)
        Displacement(24y,-8y)
    ]
    // 湘
    53222us, [
        PenUp
        Displacement(14y,119y)
        PenDown
        Displacement(23y,-13y)
        PenUp
        Displacement(-29y,-18y)
        PenDown
        Displacement(23y,-15y)
        PenUp
        Displacement(0y,-13y)
        PenDown
        Displacement(-18y,-51y)
        PenUp
        Displacement(20y,82y)
        PenDown
        yield! Radical.十 43y [36y;125y]

        PenUp
        Displacement(0y,84y)
        PenDown
        Displacement(-20y,-43y)
        PenUp
        Displacement(23y,41y)
        PenDown
        Displacement(17y,-23y)
        PenUp
        Displacement(9y,51y)
        PenDown
        yield! Radical.目(33y,107y)

    ]
    // 乡
    53223us, [
        PenUp
        Displacement(65y,119y)
        PenDown
        Displacement(-41y,-41y)
        Displacement(46y,0y)
        PenUp
        Displacement(25y,25y)
        PenDown
        Displacement(-69y,-56y)
        Displacement(69y,0y)
        PenUp
        Displacement(11y,23y)
        PenDown
        Displacement(-11y,-25y)
        Displacement(-14y,-15y)
        Displacement(-17y,-13y)
        Displacement(-19y,-5y)
        Displacement(-17y,-5y)
        Displacement(-15y,0y)
    ]
    // 翔
    53224us, [
        PenUp
        Displacement(11y,124y)
        PenDown
        Displacement(17y,-18y)
        PenUp
        Displacement(24y,18y)
        PenDown
        Displacement(-17y,-23y)
        PenUp
        Displacement(-28y,-3y)
        PenDown
        yield! Radical.中心对齐等距横 [48y;41y;48y] 27y

        PenUp
        Displacement(-20y,54y)
        PenDown
        yield! Radical.竖撇(20y,92y)
        PenUp
        Displacement(43y,104y)
        PenDown
        Displacement(22y,0y)
        Displacement(0y,-89y)
        Displacement(-1y,-8y)
        Displacement(-8y,-3y)
        Displacement(-8y,-3y)
        PenUp
        Displacement(-8y,82y)
        PenDown
        Displacement(14y,-18y)
        PenUp
        Displacement(-17y,-33y)
        PenDown
        Displacement(25y,23y)
        PenUp
        Displacement(9y,51y)
        PenDown
        Displacement(27y,0y)
        Displacement(0y,-92y)
        Displacement(-1y,-5y)
        Displacement(-8y,-3y)
        Displacement(-8y,-3y)
        PenUp
        Displacement(-8y,82y)
        PenDown
        Displacement(14y,-20y)
        PenUp
        Displacement(-15y,-25y)
        PenDown
        Displacement(23y,18y)
    ]
    // 祥
    53225us, [
        PenUp
        Displacement(19y,124y)
        PenDown
        Displacement(15y,-20y)
        PenUp
        Displacement(-31y,-13y)
        PenDown
        Displacement(40y,0y)
        Displacement(-13y-13y,-18y-18y)
        Displacement(-15y,-13y)
        PenUp
        Displacement(24y,28y)
        PenDown
        Displacement(0y,-69y)
        PenUp
        Displacement(-1y,66y)
        PenDown
        Displacement(23y,-18y)
        PenUp
        Displacement(14y,74y)
        PenDown
        Displacement(17y,-20y)
        PenUp
        Displacement(32y,20y)
        PenDown
        Displacement(-20y,-28y)
        PenUp
        Displacement(-38y,-3y)
        PenDown
        yield! Radical.多横中竖干 [71y;57y;78y] [31y;94y]            

    ]
    // 详
    53226us, [
        PenUp
        Displacement(15y,119y)
        PenDown
        Displacement(18y,-20y)
        PenUp
        Displacement(-29y,-15y)
        PenDown
        Displacement(18y,0y)
        Displacement(0y,-69y)
        Displacement(19y,23y)
        PenUp
        Displacement(13y,87y)
        PenDown
        Displacement(18y,-18y)
        PenUp
        Displacement(30y,19y)
        PenDown
        Displacement(-19y,-26y)
        PenUp
        Displacement(-38y,0y)
        PenDown
        yield! Radical.多横中竖干 [75y;69y;79y] [28y;94y]            

    ]
    // 想
    53227us, [
        PenUp
        Displacement(3y,98y)
        PenDown
        yield! Radical.十 50y [28y;82y]

        PenUp
        Displacement(-1y,46y)
        PenDown
        Displacement(-27y,-31y)
        PenUp
        Displacement(31y,28y)
        PenDown
        Displacement(17y,-15y)
        PenUp
        Displacement(9y,46y)
        PenDown
        yield! Radical.目(45y,61y)

        PenUp
        Displacement(-34y,-41y)
        PenDown
        Displacement(-14y,-28y)
        PenUp
        Displacement(32y,33y)
        PenDown
        Displacement(0y,-23y)
        Displacement(1y,-5y)
        Displacement(4y,-3y)
        Displacement(40y,0y)
        Displacement(5y,5y)
        Displacement(5y,10y)
        PenUp
        Displacement(-36y,20y)
        PenDown
        Displacement(17y,-18y)
        PenUp
        Displacement(23y,15y)
        PenDown
        Displacement(19y,-25y)
    ]
    // 响
    53228us, [
        PenUp
        Displacement(13y,39y)
        PenDown
        yield! Radical.口(27y,-59y)

        PenUp
        Displacement(76y,84y)
        PenDown
        Displacement(-18y,-23y)
        PenUp
        Displacement(-17y,-94y)
        PenDown
        yield! Radical.冋(60y,92y)(24y,41y)

    ]
    // 享
    53229us, [
        PenUp
        Displacement(52y,124y)
        PenDown
        Displacement(23y,-13y)
        PenUp
        Displacement(-64y,-3y)
        PenDown
        Displacement(104y,0y)
        PenUp
        Displacement(-89y,-38y)
        PenDown
        yield! Radical.口(74y,-23y)

        PenUp
        Displacement(-4y,-15y)
        PenDown
        Displacement(78y,0y)
        Displacement(-34y,-18y)
        Displacement(0y,-25y)
        Displacement(-3y,-5y)
        Displacement(-22y,-3y)
        PenUp
        Displacement(-36y,25y)
        PenDown
        Displacement(115y,0y)
    ]
    // 项
    53230us, [
        PenUp
        Displacement(1y,108y)
        PenDown
        Displacement(42y,0y)
        PenUp
        Displacement(-20y,-3y)
        PenDown
        Displacement(0y,-59y)
        PenUp
        Displacement(-20y,-10y)
        PenDown
        Displacement(45y,15y)
        PenUp
        Displacement(1y,66y)
        PenDown
        Displacement(71y,0y)
        PenUp
        Displacement(-62y,-87y)
        PenDown
        Displacement(0y,59y)
        Displacement(52y,0y)
        Displacement(0y,-59y)
        PenUp
        Displacement(-25y,87y)
        PenDown
        Displacement(-6y,-28y)
        PenUp
        Displacement(5y,-15y)
        PenDown
        Displacement(0y,-33y)
        Displacement(-4y,-15y)
        Displacement(-8y,-8y)
        Displacement(-13y,-8y)
        Displacement(-24y,-10y)
        PenUp
        Displacement(56y,31y)
        PenDown
        Displacement(32y,-28y)
    ]
    // 巷
    53231us, [
        PenUp
        Displacement(14y,101y)
        PenDown
        yield! Radical.共头 [41y;98y;113y] [24y;41y]

        PenUp
        Displacement(-75y,-3y)
        PenDown
        Displacement(-10y,-13y)
        Displacement(-13y,-8y)
        Displacement(-18y,-13y)
        PenUp
        Displacement(80y,33y)
        PenDown
        Displacement(10y,-13y)
        Displacement(10y,-8y)
        Displacement(17y,-8y)
        PenUp
        Displacement(-19y,-23y)
        PenDown
        Displacement(-4y,-10y)
        Displacement(-5y,-3y)
        Displacement(-48y,0y)
        Displacement(-6y,0y)
        Displacement(-1y,5y)
        Displacement(5y,41y)
        Displacement(47y,0y)
        Displacement(0y,-23y)
        Displacement(-50y,0y)
    ]
    // 橡
    53232us, [
        PenUp
        Displacement(5y,90y)
        PenDown
        yield! Radical.十 42y [33y;122y]

        PenUp
        Displacement(0y,87y)
        PenDown
        Displacement(-8y,-20y)
        Displacement(-14y,-25y)
        PenUp
        Displacement(23y,36y)
        PenDown
        Displacement(17y,-18y)
        PenUp
        Displacement(32y,64y)
        PenDown
        Displacement(-25y,-28y)
        PenUp
        Displacement(17y,15y)
        PenDown
        Displacement(32y,0y)
        Displacement(-13y,-18y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        yield! Radical.口(57y,23y)

        PenUp
        Displacement(29y,0y)
        PenDown
        Displacement(-3y,-18y)
        Displacement(-10y,-13y)
        Displacement(-10y,-8y)
        Displacement(-18y,-8y)
        PenUp
        Displacement(27y,13y)
        PenDown
        Displacement(10y,-8y)
        Displacement(6y,-13y)
        Displacement(0y,-18y)
        Displacement(-5y,-13y)
        Displacement(-13y,-3y)
        PenUp
        Displacement(8y,48y)
        PenDown
        Displacement(-34y,-23y)
        PenUp
        Displacement(70y,31y)
        PenDown
        Displacement(-27y,-20y)
        Displacement(-40y,-28y)
        PenUp
        Displacement(52y,38y)
        PenDown
        Displacement(4y,-15y)
        Displacement(9y,-13y)
        Displacement(10y,-10y)
    ]
    // 像
    53233us, [
        PenUp
        Displacement(36y,124y)
        PenDown
        Displacement(-34y,-56y)
        PenUp
        Displacement(23y,31y)
        PenDown
        Displacement(0y,-97y)
        PenUp
        Displacement(48y,122y)
        PenDown
        Displacement(-38y,-38y)
        PenUp
        Displacement(27y,23y)
        PenDown
        Displacement(37y,0y)
        Displacement(-14y,-15y)
        PenUp
        Displacement(-38y,-25y)
        PenDown
        yield! Radical.口(66y,-23y)

        PenUp
        Displacement(34y,20y)
        PenDown
        Displacement(-4y,-10y)
        Displacement(-6y,-15y)
        Displacement(-13y,-8y)
        Displacement(-20y,-10y)
        PenUp
        Displacement(31y,15y)
        PenDown
        Displacement(8y,-8y)
        Displacement(6y,-13y)
        Displacement(3y,-15y)
        Displacement(-1y,-13y)
        Displacement(-4y,-5y)
        Displacement(-5y,-3y)
        Displacement(-8y,0y)
        PenUp
        Displacement(6y,46y)
        PenDown
        Displacement(-11y,-10y)
        Displacement(-10y,-5y)
        Displacement(-15y,-8y)
        PenUp
        Displacement(45y,13y)
        PenDown
        Displacement(-13y,-13y)
        Displacement(-9y-9y,-8y-8y)
        Displacement(-11y,-5y)
        PenUp
        Displacement(74y,54y)
        PenDown
        Displacement(-29y,-18y)
        PenUp
        Displacement(13y,3y)
        PenDown
        Displacement(4y,-8y)
        Displacement(8y,-10y)
        Displacement(16y,-16y)
    ]
    // 向
    53234us, [
        PenUp
        Displacement(52y,124y)
        PenDown
        Displacement(-23y,-25y)
        PenUp
        Displacement(-13y,-92y)
        PenDown
        yield! Radical.冋(94y,92y)(40y,36y)

    ]
    // 象
    53235us, [
        PenUp
        Displacement(50y,126y)
        PenDown
        Displacement(-24y,-25y)
        Displacement(-18y,-13y)
        PenUp
        Displacement(32y,25y)
        PenDown
        Displacement(46y,0y)
        Displacement(-11y,-15y)
        PenUp
        Displacement(-51y,-22y)
        PenDown
        yield! Radical.口(83y,-20y)

        PenUp
        Displacement(42y,18y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-4y,-8y)
        Displacement(-4y-3y,-5y-5y)
        Displacement(-11y,-8y)
        Displacement(-29y,-10y)
        PenUp
        Displacement(36y,13y)
        PenDown
        Displacement(18y,-10y)
        Displacement(5y,-13y)
        Displacement(0y,-10y)
        Displacement(-3y,-13y)
        Displacement(-3y,-8y)
        Displacement(-4y,-3y)
        Displacement(-9y,-3y)
        PenUp
        Displacement(46y,64y)
        PenDown
        Displacement(-28y,-23y)
        PenUp
        Displacement(14y,5y)
        PenDown
        Displacement(6y,-13y)
        Displacement(6y,-8y)
        Displacement(11y,-8y)
        Displacement(13y,-5y)
        PenUp
        Displacement(-66y,38y)
        PenDown
        Displacement(-14y,-13y)
        Displacement(-17y,-10y)
        Displacement(-14y,-5y)
        PenUp
        Displacement(54y,15y)
        PenDown
        Displacement(-15y,-15y)
        Displacement(-13y,-10y)
        Displacement(-17y-10y,-5y-8y)
    ]
    // 萧
    53236us, [
        PenUp
        Displacement(6y,111y)
        PenDown
        yield! Radical.艹 (41y,13y) (115y,25y)
        PenUp
        Displacement(-23y-41y,-8y)
        PenDown
        yield! Radical.躺巾 [80y;115y] 34y

        PenUp
        Displacement(-57y,28y)
        PenDown
        Displacement(0y,-99y)
        PenUp
        Displacement(-37y,48y)
        PenDown
        Displacement(-3y,-23y)
        Displacement(-6y,-13y)
        Displacement(-10y,-13y)
        PenUp
        Displacement(42y,43y)
        PenDown
        Displacement(-11y,-25y)
        PenUp
        Displacement(40y,25y)
        PenDown
        Displacement(11y,-23y)
        PenUp
        Displacement(14y,28y)
        PenDown
        Displacement(0y,-48y)
    ]
    // 硝
    53237us, [
        PenUp
        Displacement(3y,106y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(-22y,0y)
        PenDown
        Displacement(-11y,-31y)
        Displacement(-15y,-18y)
        PenUp
        Displacement(16y,-25y)
        PenDown
        yield! Radical.口(28y,-43y)
        PenUp
        Displacement(41y,84y)
        PenDown
        Displacement(15y,-23y)
        PenUp
        Displacement(14y,36y)
        PenDown
        Displacement(0y,-46y)
        PenUp
        Displacement(31y,36y)
        PenDown
        Displacement(-17y,-23y)
        PenUp
        Displacement(-41y,-94y)
        PenDown
        yield! Radical.青月(54y,79y)

    ]
    // 霄
    53238us, [
        PenUp
        Displacement(17y,119y)
        PenDown
        yield! Radical.雨字头 (96y,41y) (106y,23y)

        PenUp
        Displacement(-53y,-8y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-40y,15y)
        PenDown
        Displacement(24y,-10y)
        PenUp
        Displacement(59y,13y)
        PenDown
        Displacement(-28y,-15y)
        PenUp
        Displacement(-55y,-59y)
        PenDown
        yield! Radical.青月 (79y,54y)

    ]
    // 削
    53239us, [
        PenUp
        Displacement(9y,113y)
        PenDown
        Displacement(17y,-20y)
        PenUp
        Displacement(14y,31y)
        PenDown
        Displacement(0y,-38y)
        PenUp
        Displacement(31y,31y)
        PenDown
        Displacement(-19y,-25y)
        PenUp
        Displacement(-37y,-84y)
        PenDown
        yield! Radical.青月 (48y,76y)

        PenUp
        Displacement(24y,64y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(25y,84y)
        PenDown
        Displacement(0y,-99y-5y)
        Displacement(-3y-4y,-5y-3y)
        Displacement(-11y,0y)
    ]
    // 哮
    53240us, [
        PenUp
        Displacement(9y,42y)
        PenDown
        yield! Radical.口(28y,-61y)
        PenUp
        Displacement(41y,64y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-50y,-25y)
        PenDown
        Displacement(74y,0y)
        PenUp
        Displacement(-45y,43y)
        PenDown
        Displacement(0y,-41y)
        PenUp
        Displacement(34y,31y)
        PenDown
        Displacement(-74y,-84y)
        PenUp
        Displacement(27y,33y)
        PenDown
        Displacement(45y,0y)
        Displacement(-19y,-13y)
        Displacement(0y,-36y)
        Displacement(-4y,-8y)
        Displacement(-10y,-3y)
        Displacement(-8y,0y)
        PenUp
        Displacement(-9y,36y)
        PenDown
        Displacement(66y,0y)
    ]
    // 嚣
    53241us, [
        PenUp
        Displacement(17y,101y)
        PenDown
        yield! Radical.口(38y,-18y)

        PenUp
        Displacement(56y,0y)
        PenDown
        yield! Radical.口(38y,-18y)

        PenUp
        Displacement(-66y,-13y)
        PenDown
        Displacement(115y,0y)
        PenUp
        Displacement(-57y,0y)
        PenDown
        Displacement(-13y,-15y)
        PenUp
        Displacement(-28y,-20y)
        PenDown
        Displacement(0y,20y)
        Displacement(82y,0y)
        Displacement(0y,-20y)
        PenUp
        Displacement(-41y,15y)
        PenDown
        Displacement(-14y,-13y)
        Displacement(-22y,-10y)
        Displacement(-24y,-8y)
        PenUp
        Displacement(65y,18y)
        PenDown
        Displacement(52y,-18y)
        PenUp
        Displacement(-104y,-24y)
        PenDown

        yield! Radical.口(38y,-18y)
        PenUp
        Displacement(56y,0y)
        PenDown
        yield! Radical.口(38y,-18y)

    ]
    // 销
    53242us, [
        PenUp
        Displacement(32y,124y)
        PenDown
        Displacement(-27y,-46y)
        PenUp
        Displacement(18y,23y)
        PenDown
        Displacement(34y,0y)
        PenUp
        Displacement(-43y,-23y)
        PenDown
        Displacement(40y,0y)
        PenUp
        Displacement(-43y,-25y)
        PenDown
        Displacement(50y,0y)
        PenUp
        Displacement(-28y,25y)
        PenDown
        Displacement(0y,-74y)
        Displacement(24y,25y)
        PenUp
        Displacement(3y,84y)
        PenDown
        Displacement(18y,-20y)
        PenUp
        Displacement(46y,25y)
        PenDown
        Displacement(-18y,-25y)
        PenUp
        Displacement(-14y,33y)
        PenDown
        Displacement(0y,-46y)
        PenUp
        Displacement(-24y,-79y)
        PenDown
        yield! Radical.青月 (52y,79y)

    ]
    // 消
    53243us, [
        PenUp
        Displacement(19y,119y)
        PenDown
        Displacement(23y,-18y)
        PenUp
        Displacement(-34y,-15y)
        PenDown
        Displacement(25y,-18y)
        PenUp
        Displacement(3y,-10y)
        PenDown
        Displacement(-25y,-48y)
        PenUp
        Displacement(75y,120y)
        PenDown
        Displacement(0y,-46y)
        PenUp
        Displacement(-34y,33y)
        PenDown
        Displacement(22y,-23y)
        PenUp
        Displacement(45y,25y)
        PenDown
        Displacement(-17y,-25y)
        PenUp
        Displacement(-43y,-92y)
        PenDown
        yield! Radical.青月 (57y,79y)

    ]
    // 宵
    53244us, [
        PenUp
        Displacement(52y,124y)
        PenDown
        Displacement(18y,-13y)
        PenUp
        Displacement(-60y,-28y)
        PenDown
        Displacement(0y,20y)
        Displacement(104y,0y)
        Displacement(0y,-23y)
        PenUp
        Displacement(-87y,10y)
        PenDown
        Displacement(18y,-13y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(0y,-28y)
        PenUp
        Displacement(37y,23y)
        PenDown
        Displacement(-19y,-15y)
        PenUp
        Displacement(-55y,-74y)
        PenDown
        yield! Radical.青月 (75y,64y)

    ]
    // 淆
    53245us, [
        PenUp
        Displacement(17y,119y)
        PenDown
        Displacement(24y,-18y)
        PenUp
        Displacement(-33y,-15y)
        PenDown
        Displacement(23y,-18y)
        PenUp
        Displacement(-18y,-61y)
        PenDown
        Displacement(15y,46y)
        PenUp
        Displacement(74y,71y)
        PenDown
        Displacement(-25y,-23y)
        Displacement(-30y,-18y)
        PenUp
        Displacement(4y,36y)
        PenDown
        Displacement(61y,-31y)
        PenUp
        Displacement(-76y,-10y)
        PenDown
        Displacement(90y,0y)
        PenUp
        Displacement(-45y,15y)
        PenDown
        Displacement(-13y,-20y)
        Displacement(-15y,-18y)
        Displacement(-15y,-15y)
        PenUp
        Displacement(23y,-38y)
        PenDown
        yield! Radical.青月 (47y,61y)

    ]
    // 晓
    53246us, [
        PenUp
        Displacement(11y,108y)
        PenDown
        yield! Radical.日(27y,79y)

        PenUp
        Displacement(36y,25y)
        PenDown
        Displacement(73y,15y)
        PenUp
        Displacement(-51y,13y)
        PenDown
        Displacement(10y,-33y)
        Displacement(14y,-18y)
        Displacement(17y,-10y)
        Displacement(6y,0y)
        Displacement(4y,13y)
        PenUp
        Displacement(-10y,20y)
        PenDown
        Displacement(-27y,-20y)
        Displacement(-27y,-13y)
        PenUp
        Displacement(-8y,-13y)
        PenDown
        Displacement(73y,0y)
        PenUp
        Displacement(-48y,-5y)
        PenDown
        Displacement(-3y,-15y)
        Displacement(-18y,-20y)
        Displacement(-17y,-8y)
        PenUp
        Displacement(56y,43y)
        PenDown
        Displacement(0y,-36y)
        Displacement(3y,-3y)
        Displacement(22y,0y)
        Displacement(4y,3y)
        Displacement(3y,13y)
    ]
    // 小
    53409us, [
        PenUp
        Displacement(31y,90y)
        PenDown
        Displacement(-9y,-33y)
        Displacement(-14y,-28y)
        PenUp
        Displacement(87y,59y)
        PenDown
        Displacement(27y,-59y)
        PenUp
        Displacement(-55y,92y)
        PenDown
        Displacement(0y,-110y)
        Displacement(-4y,-5y)
        Displacement(-15y,0y)
    ]
    // 孝
    53410us, [
        PenUp
        Displacement(23y,108y)
        PenDown
        Displacement(68y,0y)
        PenUp
        Displacement(-33y,18y)
        PenDown
        Displacement(0y,-38y)
        PenUp
        Displacement(-52y,-3y)
        PenDown
        Displacement(121y,0y)
        PenUp
        Displacement(-19y,31y)
        PenDown
        Displacement(-19y,-18y)
        Displacement(-15y,-13y)
        Displacement(-18y,-13y)
        Displacement(-18y,-8y)
        Displacement(-25y,-13y)
        Displacement(-6y,-3y)
        PenUp
        Displacement(37y,15y)
        PenDown
        Displacement(52y,0y)
        Displacement(-24y,-18y)
        Displacement(0y,-38y)
        Displacement(-5y,-5y)
        Displacement(-13y,0y)
        PenUp
        Displacement(-34y,33y)
        PenDown
        Displacement(103y,0y)
    ]
    // 校
    53411us, [
        PenUp
        Displacement(5y,93y)
        PenDown
        yield! Radical.十 45y [31y; 122y]

        PenUp
        Displacement(-1y,87y)
        PenDown
        Displacement(-22y,-43y)
        PenUp
        Displacement(24y,28y)
        PenDown
        Displacement(17y,-13y)
        PenUp
        Displacement(31y,64y)
        PenDown
        Displacement(17y,-15y)
        PenUp
        Displacement(-41y,-10y)
        PenDown
        Displacement(73y,0y)
        PenUp
        Displacement(-52y,-8y)
        PenDown
        Displacement(-19y,-28y)
        PenUp
        Displacement(43y,25y)
        PenDown
        Displacement(23y,-25y)
        PenUp
        Displacement(-14y,0y)
        PenDown
        Displacement(-10y,-20y)
        Displacement(-9y,-15y)
        Displacement(-10y,-8y)
        Displacement(-30y,-16y)
        PenUp
        Displacement(22y,56y)
        PenDown
        Displacement(8y,-13y)
        Displacement(4y,-10y)
        Displacement(8y,-10y)
        Displacement(6y,-5y)
        Displacement(11y,-8y)
        Displacement(8y,-5y)
        Displacement(13y,-3y)
    ]
    // 肖
    53412us, [
        PenUp
        Displacement(19y,113y)
        PenDown
        Displacement(28y,-25y)
        PenUp
        Displacement(60y,28y)
        PenDown
        Displacement(-25y,-28y)
        PenUp
        Displacement(-17y,33y)
        PenDown
        Displacement(0y,-41y)
        PenUp
        Displacement(-36y,-79y)
        PenDown
        yield! Radical.青月 (71y,76y)

    ]
    // 啸
    53413us, [
        PenUp
        Displacement(8y,49y)
        PenDown
        yield! Radical.口(24y,-59y)

        PenUp
        Displacement(34y,59y)
        PenDown
        yield! Radical.躺巾 [64y;89y] 36y

        PenUp
        Displacement(-47y,33y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(-11y,54y)
        PenDown
        Displacement(-9y,-25y)
        PenUp
        Displacement(-10y,33y)
        PenDown
        Displacement(0y,-23y)
        Displacement(-3y,-13y)
        Displacement(-9y,-15y)
        Displacement(-9y,-10y)
        PenUp
        Displacement(60y,54y)
        PenDown
        Displacement(15y,-23y)
        PenUp
        Displacement(9y,31y)
        PenDown
        Displacement(0y,-61y)
    ]
    // 笑
    53414us, [
        PenUp
        Displacement(31y,124y)
        PenDown
        Displacement(-24y,-36y)
        PenUp
        Displacement(18y,20y)
        PenDown
        Displacement(38y,0y)
        PenUp
        Displacement(-27y,0y)
        PenDown
        Displacement(11y,-20y)
        PenUp
        Displacement(38y,36y)
        PenDown
        Displacement(-25y,-33y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(45y,0y)
        PenUp
        Displacement(-28y,-3y)
        PenDown
        Displacement(13y,-15y)
        PenUp
        Displacement(-4y,-8y)
        PenDown
        Displacement(-41y,-8y)
        Displacement(-41y,0y)
        PenUp
        Displacement(-9y,-23y)
        PenDown
        Displacement(107y,0y)
        PenUp
        Displacement(-55y,23y)
        PenDown
        Displacement(-3y,-23y)
        Displacement(-5y,-15y)
        Displacement(-13y,-13y)
        Displacement(-10y,-8y)
        Displacement(-22y,-10y)
        PenUp
        Displacement(51y,46y)
        PenDown
        Displacement(29y,-30y)
        Displacement(28y,-15y)
    ]
    // 效
    53415us, [
        PenUp
        Displacement(22y,121y)
        PenDown
        Displacement(17y,-20y)
        PenUp
        Displacement(-36y,-8y)
        PenDown
        Displacement(59y,0y)
        PenUp
        Displacement(-36y,-13y)
        PenDown
        Displacement(-22y,-23y)
        PenUp
        Displacement(34y,31y)
        PenDown
        Displacement(22y,-25y)
        PenUp
        Displacement(-14y,-3y)
        PenDown
        Displacement(-11y,-31y)
        Displacement(-28y,-25y)
        PenUp
        Displacement(8y,48y)
        PenDown
        Displacement(41y,-38y)
        PenUp
        Displacement(28y,107y)
        PenDown
        Displacement(-23y,-48y)
        PenUp
        Displacement(10y,13y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(-14y,-3y)
        PenDown
        Displacement(-6y,-38y)
        Displacement(-13y,-20y)
        Displacement(-20y,-15y)
        Displacement(-17y,-8y)
        PenUp
        Displacement(23y,69y)
        PenDown
        Displacement(5y,-18y)
        Displacement(9y,-25y)
        Displacement(23y,-13y)
        Displacement(14y,-8y)
    ]
    // 楔
    53416us, [
        PenUp
        Displacement(6y,96y)
        PenDown
        yield! Radical.十 33y [31y; 122y]

        PenUp
        Displacement(-23y,41y)
        PenDown
        Displacement(8y,15y)
        Displacement(6y,10y)
        Displacement(9y,18y)
        PenUp
        Displacement(3y,-5y)
        PenDown
        Displacement(11y,-13y)
        PenUp
        Displacement(1y,43y)
        PenDown
        yield! Radical.多横中竖丰 [38y;33y;38y] [20y;54y;71y]

        PenUp
        Displacement(23y,61y)
        PenDown
        Displacement(31y,0y)
        Displacement(0y,-43y)
        Displacement(-5y,-8y)
        Displacement(-8y,0y)
        PenUp
        Displacement(-5y,48y)
        PenDown
        Displacement(-3y,-23y)
        Displacement(-3y,-13y)
        Displacement(-6y,-13y)
        PenUp
        Displacement(-42y,-23y)
        PenDown
        Displacement(84y,0y)
        PenUp
        Displacement(-45y,18y)
        PenDown
        Displacement(0y,-20y)
        Displacement(-5y,-10y)
        Displacement(-6y,-8y)
        Displacement(-11y,-10y)
        Displacement(-17y,-10y)
        PenUp
        Displacement(42y,38y)
        PenDown
        Displacement(9y,-10y)
        Displacement(10y,-10y)
        Displacement(13y,-8y)
        Displacement(10y,-5y)
    ]
    // 些
    53417us, [
        PenUp
        Displacement(20y,108y)
        PenDown
        Displacement(0y,-54y)
        PenUp
        Displacement(23y,59y)
        PenDown
        Displacement(0y,-54y)
        PenUp
        Displacement(3y,31y)
        PenDown
        Displacement(23y,0y)
        PenUp
        Displacement(-62y,-43y)
        PenDown
        Displacement(60y,15y)
        PenUp
        Displacement(10y,54y)
        PenDown
        Displacement(0y,-56y)
        Displacement(4y,-8y)
        Displacement(6y,-3y)
        Displacement(27y,0y)
        Displacement(8y,16y)
        PenUp
        Displacement(-4y,38y)
        PenDown
        Displacement(-40y,-20y)
        PenUp
        Displacement(-50y,-51y)
        PenDown
        yield! Radical.中心对齐等距横 [75y;108y] 25y
    ]
    // 歇
    53418us, [
        PenUp
        Displacement(15y,113y)
        PenDown
        yield! Radical.日(43y,31y)

        PenUp
        Displacement(15y,-18y)
        PenDown
        Displacement(-24y,-31y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(40y,0y)
        Displacement(0y,-41y)
        Displacement(-4y,-8y)
        Displacement(-17y,-8y)
        PenUp
        Displacement(-27y,41y)
        PenDown
        Displacement(0y,-28y)
        Displacement(33y,0y)
        PenUp
        Displacement(-8y,36y)
        PenDown
        Displacement(-17y,-25y)
        PenUp
        Displacement(13y,15y)
        PenDown
        Displacement(13y,-15y)
        PenUp
        Displacement(37y,89y)
        PenDown
        Displacement(-20y,-51y)
        PenUp
        Displacement(14y,23y)
        PenDown
        Displacement(34y,0y)
        Displacement(-5y,-20y)
        PenUp
        Displacement(-20y,8y)
        PenDown
        Displacement(0y,-33y)
        Displacement(-5y,-18y)
        Displacement(-20y,-28y)
        PenUp
        Displacement(27y,56y)
        PenDown
        Displacement(9y,-23y)
        Displacement(8y,-15y)
        Displacement(14y,-15y)
    ]
    // 蝎
    53419us, [
        PenUp
        Displacement(10y,58y+41y)
        PenDown

        yield! Radical.中 37y [41y;28y;97y]
        PenUp
        Displacement(-25y,-8y)
        PenDown
        Displacement(42y,10y)
        PenUp
        Displacement(-5y,13y)
        PenDown
        Displacement(13y,-25y)
        PenUp
        Displacement(10y,97y)
        PenDown
        yield! Radical.日(46y,38y)

        PenUp
        Displacement(14y,-23y)
        PenDown
        Displacement(-25y,-23y)
        PenUp
        Displacement(15y,10y)
        PenDown
        Displacement(50y,0y)
        Displacement(0y,-43y)
        Displacement(-3y,-5y)
        Displacement(-5y,-5y)
        Displacement(-11y,-3y)
        PenUp
        Displacement(-9y,51y)
        PenDown
        Displacement(-19y,-25y)
        PenUp
        Displacement(17y,15y)
        PenDown
        Displacement(15y,-15y)
        PenUp
        Displacement(-41y,13y)
        PenDown
        Displacement(0y,-25y)
        Displacement(40y,0y)
    ]
    // 鞋
    53420us, [
        PenUp
        Displacement(0y,108y)
        PenDown
        yield!
            (id<革> {
                横 = 60y,18y
                凵 = 32y,36y
                口 = 40y,23y
                十 = 60y,82y
            }).toYield()
        PenUp
        Displacement(36y,99y)
        PenDown
        yield! Radical.多横中竖士 [52y;56y;51y;76y] [31y;110y]

    ]
    // 协
    53421us, [
        PenUp
        Displacement(0y,85y)
        PenDown
        yield! Radical.十 38y [36y; 120y]

        PenUp
        Displacement(19y,92y)
        PenDown
        Displacement(60y,0y)
        Displacement(0y,-76y)
        Displacement(-3y,-5y)
        Displacement(-8y,-3y)
        Displacement(-8y,0y)
        PenUp
        Displacement(-8y,115y)
        PenDown
        Displacement(-1y,-25y)
        Displacement(0y,-28y)
        Displacement(-5y,-28y)
        Displacement(-8y,-13y)
        Displacement(-10y,-13y)
        Displacement(-14y,-10y)
        PenUp
        Displacement(15y,64y)
        PenDown
        Displacement(-15y,-28y)
        PenUp
        Displacement(75y,20y)
        PenDown
        Displacement(11y,-23y)
    ]
    // 挟
    53422us, [
        PenUp
        Displacement(6y,93y)
        PenDown
        Displacement(42y,0y)
        PenUp
        Displacement(-18y,31y)
        PenDown
        Displacement(0y,-107y)
        Displacement(-3y,-5y)
        Displacement(-8y,-5y)
        Displacement(-8y,0y)
        PenUp
        Displacement(-9y,43y)
        PenDown
        Displacement(45y,20y)
        PenUp
        Displacement(3y,31y)
        PenDown
        yield! Radical.中心对齐等距横 [68y;83y] 46y

        PenUp
        Displacement(-68y,33y)
        PenDown
        Displacement(13y,-23y)
        PenUp
        Displacement(42y,23y)
        PenDown
        Displacement(-15y,-20y)
        PenUp
        Displacement(-11y,56y)
        PenDown
        Displacement(0y,-46y)
        Displacement(-3y,-25y)
        Displacement(-6y,-18y)
        Displacement(-14y,-15y)
        Displacement(-19y,-13y)
        PenUp
        Displacement(43y,46y)
        PenDown
        Displacement(8y,-15y)
        Displacement(11y,-15y)
        Displacement(18y,-15y)
    ]
    // 携
    53423us, [
        PenUp
        Displacement(6y,93y)
        PenDown
        Displacement(38y,0y)
        PenUp
        Displacement(-17y,31y)
        PenDown
        Displacement(0y,-107y)
        Displacement(-5y,-8y)
        Displacement(-14y,-3y)
        PenUp
        Displacement(-3y,38y)
        PenDown
        Displacement(41y,18y)
        PenUp
        Displacement(20y,61y)
        PenDown
        Displacement(-10y,-23y)
        Displacement(-14y,-20y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(0y,-43y)
        PenUp
        Displacement(22y,69y)
        PenDown
        Displacement(15y,-13y)
        PenUp
        Displacement(-5y-56y/2y,-3y)
        PenDown
        yield! Radical.多横中竖工 [56y;56y;56y;62y] 15y

        PenUp
        Displacement(-78y+62y/2y,-18y)
        PenDown
        Displacement(61y,0y)
        Displacement(-8y,-15y)
        Displacement(20y,0y)
        Displacement(-3y,-13y)
        Displacement(-4y,-10y)
        Displacement(-20y,-3y)
        PenUp
        Displacement(-23y,38y)
        PenDown
        Displacement(-6y,-18y)
        Displacement(-11y,-13y)
        Displacement(-13y,-8y)
    ]
    // 邪
    53424us, [
        PenUp
        Displacement(13y,119y)
        PenDown
        Displacement(62y,0y)
        PenUp
        Displacement(-43y,-10y)
        PenDown
        Displacement(-6y,-18y)
        Displacement(-8y,-20y)
        Displacement(59y,0y)
        PenUp
        Displacement(-22y,46y)
        PenDown
        Displacement(0y,-84y)
        Displacement(-3y,-8y)
        Displacement(-3y,-5y)
        Displacement(-6y,-5y)
        Displacement(-9y,0y)
        PenUp
        Displacement(13y,56y)
        PenDown
        Displacement(-9y,-18y)
        Displacement(-14y,-15y)
        Displacement(-11y,-10y)
        Displacement(-9y,-5y)
        PenUp
        Displacement(78y,-18y)
        PenDown
        Displacement(0y,115y)
        Displacement(40y,0y)
        Displacement(-10y,-18y)
        Displacement(-5y,-8y)
        Displacement(-6y,-8y)
        Displacement(-4y,-3y)
        Displacement(13y,-13y)
        Displacement(6y,-10y)
        Displacement(3y,-8y)
        Displacement(1y,-8y)
        Displacement(-3y,-5y)
        Displacement(-5y,-5y)
        Displacement(-6y-5y,-3y-3y)
        Displacement(-5y,0y)
    ]
    // 斜
    53425us, [
        PenUp
        Displacement(42y,124y)
        PenDown
        Displacement(-13y,-15y)
        Displacement(-24y,-25y)
        PenUp
        Displacement(33y,36y)
        PenDown
        Displacement(29y,-25y)
        PenUp
        Displacement(-50y,-10y)
        PenDown
        yield! Radical.中心对齐等距横 [43y;60y] 23y

        PenUp
        Displacement(-29y,23y)
        PenDown
        Displacement(0y,-69y)
        Displacement(-5y,-5y)
        Displacement(-14y,-5y)
        PenUp
        Displacement(8y,43y)
        PenDown
        Displacement(-23y,-31y)
        PenUp
        Displacement(47y,28y)
        PenDown
        Displacement(19y,-23y)
        PenUp
        Displacement(4y,89y)
        PenDown
        Displacement(19y,-25y)
        PenUp
        Displacement(-27y,-5y)
        PenDown
        Displacement(25y,-25y)
        PenUp
        Displacement(-27y,-13y)
        PenDown
        Displacement(61y,0y)
        PenUp
        Displacement(-20y,82y)
        PenDown
        Displacement(0y,-122y)
    ]
    // 胁
    53426us, [
        PenUp
        Displacement(3y,6y)
        PenDown
        Displacement(8y,15y)
        Displacement(3y,15y)
        Displacement(0y,76y)
        Displacement(31y,0y)
        Displacement(0y,-97y)
        Displacement(-3y,-5y)
        Displacement(-13y,-5y)
        PenUp
        Displacement(-11y,76y)
        PenDown
        Displacement(25y,0y)
        PenUp
        Displacement(-25y,-28y)
        PenDown
        Displacement(25y,0y)
        PenUp
        Displacement(11y,33y)
        PenDown
        Displacement(47y,0y)
        Displacement(0y,-71y)
        Displacement(-4y,-10y)
        Displacement(-15y,-3y)
        PenUp
        Displacement(1y,120y)
        PenDown
        Displacement(0y,-54y)
        Displacement(-3y,-18y)
        Displacement(-3y,-13y)
        Displacement(-9y,-15y)
        Displacement(-8y,-13y)
        Displacement(-13y,-10y)
        PenUp
        Displacement(17y,74y)
        PenDown
        Displacement(-13y,-33y)
        PenUp
        Displacement(59y,28y)
        PenDown
        Displacement(15y,-31y)
    ]
    // 谐
    53427us, [
        PenUp
        Displacement(14y,119y)
        PenDown
        Displacement(23y,-18y)
        PenUp
        Displacement(-37y,-20y)
        PenDown
        Displacement(25y,0y)
        Displacement(0y,-69y)
        Displacement(19y,25y)
        PenUp
        Displacement(6y,84y)
        PenDown
        Displacement(0y,-51y)
        Displacement(28y,15y)
        PenUp
        Displacement(-25y,15y)
        PenDown
        Displacement(24y,0y)
        PenUp
        Displacement(11y,20y)
        PenDown
        Displacement(0y,-33y-8y)
        Displacement(8y,-10y)
        Displacement(15y,0y)
        Displacement(6y,3y)
        Displacement(3y,8y)
        Displacement(0y,5y)
        PenUp
        Displacement(-6y,23y)
        PenDown
        Displacement(-24y,-8y)
        PenUp
        Displacement(-10y,-31y)
        PenDown
        Displacement(-8y,-13y)
        PenUp
        Displacement(-18y,-2y)
        PenDown
        yield! Radical.日(52y,54y)
    ]
    // 写
    53428us, [
        PenUp
        Displacement(11y,93y)
        PenDown
        Displacement(3y,20y)
        Displacement(98y,0y)
        Displacement(0y,-18y)
        PenUp
        Displacement(-78y,8y)
        PenDown
        Displacement(0y,-46y)
        Displacement(70y,0y)
        Displacement(-4y,-41y)
        Displacement(-6y,-5y)
        Displacement(-14y,-3y)
        PenUp
        Displacement(-41y,76y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-96y,-48y)
        PenDown
        Displacement(80y,0y)
    ]
    // 械
    53429us, [
        PenUp
        Displacement(3y,90y)
        PenDown
        yield! Radical.十 42y [33y; 122y]

        PenUp
        Displacement(-1y,87y)
        PenDown
        Displacement(-9y,-23y)
        Displacement(-11y,-23y)
        PenUp
        Displacement(22y,33y)
        PenDown
        Displacement(15y,-15y)
        PenUp
        Displacement(6y,36y)
        PenDown
        Displacement(73y,0y)
        PenUp
        Displacement(-29y,28y)
        PenDown
        Displacement(1y,-33y)
        Displacement(0y,-36y)
        Displacement(3y,-20y)
        Displacement(8y,-18y)
        Displacement(10y,-15y)
        Displacement(9y,20y)
        PenUp
        Displacement(-20y,97y)
        PenDown
        Displacement(15y,-13y)
        PenUp
        Displacement(-4y,-28y)
        PenDown
        Displacement(-6y,-28y)
        Displacement(-9y,-18y)
        Displacement(-13y,-15y)
        Displacement(-15y,-10y)
        PenUp
        Displacement(-24y,54y)
        PenDown
        Displacement(41y,0y)
        PenUp
        Displacement(-28y,25y)
        PenDown
        Displacement(0y,-25y)
        Displacement(-3y,-13y)
        Displacement(-3y,-15y)
        Displacement(-4y,-10y)
        Displacement(-9y,-10y)
        PenUp
        Displacement(36y,74y)
        PenDown
        Displacement(0y,-61y)
    ]
    // 卸
    53430us, [
        PenUp
        Displacement(33y,124y)
        PenDown
        Displacement(-10y,-18y)
        Displacement(-14y,-18y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(46y,0y)
        PenUp
        Displacement(-64y,-28y)
        PenDown
        Displacement(68y,0y)
        PenUp
        Displacement(-31y,25y)
        PenDown
        Displacement(0y,-76y)
        PenUp
        Displacement(3y,28y)
        PenDown
        Displacement(23y,0y)
        PenUp
        Displacement(-48y,5y)
        PenDown
        Displacement(0y,-36y)
        PenUp
        Displacement(-13y,-8y)
        PenDown
        Displacement(68y,10y)
        PenUp
        Displacement(5y,-25y)
        PenDown
        Displacement(0y,107y)
        Displacement(36y,0y)
        Displacement(0y,-79y)
        Displacement(-5y,-5y)
        Displacement(-8y,-3y)
        Displacement(-6y,0y)
    ]
    // 蟹
    53431us, [
        PenUp
        Displacement(34y,126y)
        PenDown
        Displacement(-11y,-15y)
        Displacement(-17y,-18y)
        PenUp
        Displacement(20y,18y)
        PenDown
        Displacement(27y,0y)
        Displacement(-8y,-10y)
        PenUp
        Displacement(-37y,-51y)
        PenDown
        Displacement(4y,5y)
        Displacement(5y,10y)
        Displacement(3y,8y)
        Displacement(0y,25y)
        Displacement(42y,0y)
        Displacement(0y,-36y)
        Displacement(-5y,-3y)
        Displacement(-8y,-3y)
        PenUp
        Displacement(-25y,28y)
        PenDown
        Displacement(36y,0y)
        PenUp
        Displacement(-36y,-15y)
        PenDown
        yield! Radical.十 37y [25y;38y]

        PenUp
        Displacement(29y,56y)
        PenDown
        Displacement(42y,0y)
        Displacement(0y,-8y)
        Displacement(-4y,-8y)
        Displacement(-5y,-3y)
        Displacement(-5y,0y)
        PenUp
        Displacement(-10y,15y)
        PenDown
        Displacement(-10y,-13y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(15y,0y)
        PenDown
        Displacement(-15y,-18y)
        PenUp
        Displacement(10y,8y)
        PenDown
        Displacement(38y,0y)
        PenUp
        Displacement(-47y,-15y)
        PenDown
        Displacement(51y,0y)
        PenUp
        Displacement(-25y,25y)
        PenDown
        Displacement(0y,-41y)
        PenUp
        Displacement(-73y,-21y+18y)
        PenDown

        yield! Radical.中 76y [18y;7y;38y]
        PenUp
        Displacement(-55y,-3y)
        PenDown
        Displacement(94y,0y)
        PenUp
        Displacement(-6y,10y)
        PenDown
        Displacement(20y,-18y)
    ]
    // 懈
    53432us, [
        PenUp
        Displacement(13y,96y)
        PenDown
        Displacement(-13y,-31y)
        PenUp
        Displacement(20y,59y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(8y,94y)
        PenDown
        Displacement(6y,-15y)
        PenUp
        Displacement(23y,43y)
        PenDown
        Displacement(-20y,-33y)
        PenUp
        Displacement(15y,15y)
        PenDown
        Displacement(18y,0y)
        Displacement(-11y,-18y)
        Displacement(0y,-71y)
        PenUp
        Displacement(-27y,-13y)
        PenDown
        Displacement(6y,15y)
        Displacement(3y,10y)
        Displacement(0y,54y)
        Displacement(36y,0y)
        Displacement(0y,-69y)
        Displacement(-5y,-5y)
        Displacement(-10y,-3y)
        PenUp
        Displacement(-15y,56y)
        PenDown
        Displacement(28y,0y)
        PenUp
        Displacement(-29y,-23y)
        PenDown
        Displacement(29y,0y)
        PenUp
        Displacement(8y,69y)
        PenDown
        Displacement(33y,0y)
        Displacement(0y,-18y)
        Displacement(-5y,-3y)
        Displacement(-9y,-3y)
        PenUp
        Displacement(-4y,23y)
        PenDown
        Displacement(-13y,-28y)
        PenUp
        Displacement(10y,-5y)
        PenDown
        Displacement(-11y,-25y)
        PenUp
        Displacement(9y,13y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-41y,-25y)
        PenDown
        yield! Radical.十 43y [41y;76y]
    ]
    // 泄
    53433us, [
        PenUp
        Displacement(14y,121y)
        PenDown
        Displacement(22y,-18y)
        PenUp
        Displacement(-33y,-15y)
        PenDown
        Displacement(25y,-18y)
        PenUp
        Displacement(1y,-13y)
        PenDown
        Displacement(-4y-17y,-23y-25y)
        PenUp
        Displacement(21y,71y)
        PenDown
        yield! (id<世> {
                凵 = 29y,87y
                七 = 96y,112y
            }).toYield()

    ]
    // 泻
    53434us, [
        PenUp
        Displacement(19y,116y)
        PenDown
        Displacement(20y,-13y)
        PenUp
        Displacement(-27y,-18y)
        PenDown
        Displacement(20y,-15y)
        PenUp
        Displacement(-1y,-15y)
        PenDown
        Displacement(-18y,-46y)
        PenUp
        Displacement(36y,84y)
        PenDown
        Displacement(3y,20y)
        Displacement(70y,0y)
        Displacement(-3y,-18y)
        PenUp
        Displacement(-1y,-15y)
        PenDown
        Displacement(-51y,0y)
        PenUp
        Displacement(-4y,18y)
        PenDown
        Displacement(0y,-41y)
        Displacement(51y,0y)
        Displacement(-5y,-48y)
        Displacement(-24y,-3y)
        PenUp
        Displacement(-43y,28y)
        PenDown
        Displacement(60y,0y)
    ]
    // 谢
    53435us, [
        PenUp
        Displacement(10y,116y)
        PenDown
        Displacement(19y,-23y)
        PenUp
        Displacement(-28y,-18y)
        PenDown
        Displacement(17y,0y)
        Displacement(0y,-64y)
        Displacement(20y,23y)
        PenUp
        Displacement(22y,87y)
        PenDown
        Displacement(-9y,-18y)
        PenUp
        Displacement(-19y,-54y)
        PenDown
        Displacement(40y,0y)
        PenUp
        Displacement(-5y,0y)
        PenDown
        Displacement(-8y,-15y)
        Displacement(-23y,-23y)
        PenUp
        Displacement(8y,74y)
        PenDown
        Displacement(28y,0y)
        PenUp
        Displacement(-29y,-15y)
        PenDown
        Displacement(28y,0y)
        PenUp
        Displacement(-27y,-15y)
        PenDown
        Displacement(0y,48y)
        Displacement(29y,0y)
        Displacement(0y,-94y)
        Displacement(-5y,-3y)
        Displacement(-9y,0y)
        PenUp
        Displacement(22y,76y)
        PenDown
        Displacement(42y,0y)
        PenUp
        Displacement(-41y,-15y)
        PenDown
        Displacement(14y,-25y)
        PenUp
        Displacement(10y,82y)
        PenDown
        Displacement(0y,-117y)
        Displacement(-19y,-3y)
    ]
    // 屑
    53436us, [
        PenUp
        Displacement(6y,11y)
        PenDown
        Displacement(8y,13y)
        Displacement(6y,18y)
        Displacement(3y,25y)
        Displacement(0y,54y)
        Displacement(90y,0y)
        Displacement(0y,-20y)
        Displacement(-89y,0y)
        PenUp
        Displacement(13y,-13y)
        PenDown
        Displacement(24y,-15y)
        PenUp
        Displacement(14y,25y)
        PenDown
        Displacement(0y,-33y)
        PenUp
        Displacement(42y,25y)
        PenDown
        Displacement(-27y,-15y)
        PenUp
        Displacement(-48y,-71y)
        PenDown
        yield! Radical.青月(73y,61y)

    ]
    // 薪
    53437us, [
        PenUp
        Displacement(4y,111y)
        PenDown
        yield! Radical.艹(38y,15y)(117y,31y)

        PenUp
        Displacement(-55y,0y)
        PenDown
        Displacement(14y,-10y)
        PenUp
        Displacement(-33y,-5y)
        PenDown
        Displacement(57y,0y)
        PenUp
        Displacement(-45y,-5y)
        PenDown
        Displacement(13y,-13y)
        PenUp
        Displacement(23y,15y)
        PenDown
        Displacement(-9y,-15y)
        PenUp
        Displacement(-45y,-5y)
        PenDown
        Displacement(66y,0y)
        PenUp
        Displacement(-59y,-15y)
        PenDown
        Displacement(55y,0y)
        PenUp
        Displacement(-27y,18y)
        PenDown
        Displacement(0y,-43y)
        Displacement(-1y,-5y)
        Displacement(-5y,-3y)
        Displacement(-6y,0y)
        PenUp
        Displacement(-5y,25y)
        PenDown
        Displacement(-6y,-10y)
        Displacement(-9y,-10y)
        PenUp
        Displacement(47y,20y)
        PenDown
        Displacement(10y,-15y)
        PenUp
        Displacement(-4y,-15y)
        PenDown
        Displacement(8y,10y)
        Displacement(6y,15y)
        Displacement(5y,20y)
        Displacement(0y,36y)
        Displacement(36y,10y)
        PenUp
        Displacement(-34y,-33y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-19y,-3y)
        PenDown
        Displacement(0y,-56y)
    ]
    // 芯
    53438us, [
        PenUp
        Displacement(5y,103y)
        PenDown
        yield! Radical.艹(43y,18y)(117y,43y)

        PenUp
        Displacement(-64y,-38y)
        PenDown
        Displacement(-17y,-25y)
        PenUp
        Displacement(31y,41y)
        PenDown
        Displacement(0y,-18y)
        Displacement(1y,-13y)
        Displacement(4y,-13y)
        Displacement(3y,-10y)
        Displacement(18y,0y)
        Displacement(25y,5y)
        Displacement(6y,13y)
        PenUp
        Displacement(-36y,43y)
        PenDown
        Displacement(19y,-33y)
        PenUp
        Displacement(24y,18y)
        PenDown
        Displacement(18y,-31y)
    ]
    // 锌
    53439us, [
        PenUp
        Displacement(29y,124y)
        PenDown
        Displacement(-11y,-20y)
        Displacement(-15y,-18y)
        PenUp
        Displacement(14y,15y)
        PenDown
        Displacement(34y,0y)
        PenUp
        Displacement(-40y,-23y)
        PenDown
        Displacement(36y,0y)
        PenUp
        Displacement(-41y,-25y)
        PenDown
        Displacement(45y,0y)
        PenUp
        Displacement(-25y,23y)
        PenDown
        Displacement(0y,-66y)
        Displacement(23y,20y)
        PenUp
        Displacement(29y,94y)
        PenDown
        Displacement(15y,-13y)
        PenUp
        Displacement(-34y,-8y)
        PenDown
        Displacement(60y,0y)
        PenUp
        Displacement(-54y,-8y)
        PenDown
        Displacement(17y,-20y)
        PenUp
        Displacement(25y,18y)
        PenDown
        Displacement(-14y,-23y)
        PenUp
        Displacement(-41y,-5y)
        PenDown
        Displacement(71y,0y)
        PenUp
        Displacement(-68y,-25y)
        PenDown
        yield! Radical.十 62y [25y;64y]

    ]
    // 欣
    53440us, [
        PenUp
        Displacement(60y,113y)
        PenDown
        Displacement(-41y,-5y)
        Displacement(0y,-54y)
        Displacement(-3y,-13y)
        Displacement(-3y-4y,-10y-10y)
        Displacement(-8y,-10y)
        PenUp
        Displacement(19y,66y)
        PenDown
        Displacement(42y,0y)
        PenUp
        Displacement(-20y,-3y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(42y,110y)
        PenDown
        Displacement(-4y,-18y)
        Displacement(-5y-5y,-13y-13y)
        Displacement(-6y,-10y)
        Displacement(-4y,-5y)
        PenUp
        Displacement(19y,31y)
        PenDown
        Displacement(38y,0y)
        Displacement(-9y,-20y)
        PenUp
        Displacement(-23y,5y)
        PenDown
        Displacement(0y,-23y)
        Displacement(-3y,-10y)
        Displacement(-6y-5y,-10y-10y)
        Displacement(-9y,-8y)
        Displacement(-10y,-8y)
        Displacement(-8y,-5y)
        PenUp
        Displacement(42y,56y)
        PenDown
        Displacement(4y,-15y)
        Displacement(4y,-8y)
        Displacement(6y,-10y)
        Displacement(6y,-8y)
        Displacement(5y,-8y)
        Displacement(6y,-5y)
    ]
    // 辛
    53441us, [
        PenUp
        Displacement(51y,121y)
        PenDown
        Displacement(23y,-15y)
        PenUp
        Displacement(-60y,-5y)
        PenDown
        Displacement(97y,0y)
        PenUp
        Displacement(-79y,-5y)
        PenDown
        Displacement(15y,-25y)
        PenUp
        Displacement(48y,25y)
        PenDown
        Displacement(-24y,-31y)
        PenUp
        Displacement(-68y,0y)
        PenDown
        Displacement(116y,0y)
        PenUp
        Displacement(-108y,-31y)
        PenDown
        yield! Radical.十 107y [31y;64y]

    ]
    // 新
    53442us, [
        PenUp
        Displacement(25y,124y)
        PenDown
        Displacement(15y,-13y)
        PenUp
        Displacement(-31y,-8y)
        PenDown
        Displacement(57y,0y)
        PenUp
        Displacement(-47y,-8y)
        PenDown
        Displacement(11y,-15y)
        PenUp
        Displacement(24y,15y)
        PenDown
        Displacement(-10y,-20y)
        PenUp
        Displacement(-38y,-3y)
        PenDown
        Displacement(62y,0y)
        PenUp
        Displacement(-61y,-20y)
        PenDown
        Displacement(59y,0y)
        PenUp
        Displacement(-28y,20y)
        PenDown
        Displacement(0y,-51y-8y)
        Displacement(-5y,-5y)
        Displacement(-10y,0y)
        PenUp
        Displacement(-1y,33y)
        PenDown
        Displacement(-14y,-23y)
        PenUp
        Displacement(45y,20y)
        PenDown
        Displacement(14y,-13y)
        PenUp
        Displacement(48y,92y)
        PenDown
        Displacement(-37y,-10y)
        Displacement(0y,-33y-28y)
        Displacement(-3y,-18y)
        Displacement(-9y,-18y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(22y,71y)
        PenDown
        Displacement(43y,0y)
        PenUp
        Displacement(-18y,-3y)
        PenDown
        Displacement(0y,-69y)
    ]
    // 忻
    53443us, [
        PenUp
        Displacement(13y,96y)
        PenDown
        Displacement(-10y,-31y)
        PenUp
        Displacement(29y,36y)
        PenDown
        Displacement(15y,-23y)
        PenUp
        Displacement(-22y,46y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(89y,120y)
        PenDown
        Displacement(-54y,-8y)
        Displacement(0y,-54y-18y)
        Displacement(-6y,-13y)
        Displacement(-5y,-10y)
        Displacement(-10y,-15y)
        PenUp
        Displacement(24y,74y)
        PenDown
        Displacement(57y,0y)
        PenUp
        Displacement(-25y,-3y)
        PenDown
        Displacement(0y,-74y)
    ]
    // 心
    53444us, [
        PenUp
        Displacement(19y,75y)
        PenDown
        Displacement(-13y,-48y)
        PenUp
        Displacement(43y,87y)
        PenDown
        Displacement(22y,-25y)
        PenUp
        Displacement(24y,-10y)
        PenDown
        Displacement(25y,-36y)
        PenUp
        Displacement(-78y,38y)
        PenDown
        Displacement(0y,-64y)
        Displacement(4y,-8y)
        Displacement(36y,0y)
        Displacement(5y,5y)
        Displacement(5y,20y)
    ]
    // 信
    53445us, [
        PenUp
        Displacement(34y,124y)
        PenDown
        Displacement(-10y,-23y)
        Displacement(-6y,-10y)
        Displacement(-13y,-15y)
        Displacement(-5y,-10y)
        PenUp
        Displacement(22y,25y)
        PenDown
        Displacement(0y,-89y)
        PenUp
        Displacement(45y,122y)
        PenDown
        Displacement(22y,-15y)
        PenUp
        Displacement(-54y,-8y)
        PenDown
        yield! Radical.中心对齐等距横 [89y;64y;66y] 20y

        PenUp
        Displacement(-60y,-21y)
        PenDown
        yield! Radical.口(57y,25y)

    ]
    // 衅
    53446us, [
        PenUp
        Displacement(37y,121y)
        PenDown
        Displacement(-10y,-23y)
        Displacement(0y,-76y)
        PenUp
        Displacement(14y,74y)
        PenDown
        Displacement(0y,-71y)
        PenUp
        Displacement(-41y,-5y)
        PenDown
        Displacement(70y,8y)
        PenUp
        Displacement(-60y,-5y)
        PenDown
        Displacement(0y,76y)
        Displacement(47y,0y)
        Displacement(0y,-71y)
        PenUp
        Displacement(8y,84y)
        PenDown
        Displacement(13y,-23y)
        PenUp
        Displacement(38y,23y)
        PenDown
        Displacement(-14y,-25y)
        PenUp
        Displacement(-37y,-15y)
        PenDown
        yield! Radical.多横中竖丰 [51y;61y] [33y;89y;125y]

    ]
    // 星
    53447us, [
        PenUp
        Displacement(20y,114y)
        PenDown
        yield! Radical.日(78y,41y)
        PenUp
        Displacement(8y,-25y)
        PenDown
        Displacement(-6y,-15y)
        Displacement(-9y,-10y)
        Displacement(-5y,-5y)
        PenUp
        Displacement(17y,18y)
        PenDown
        Displacement(87y,0y)
        PenUp
        Displacement(-85y,-20y)
        PenDown
        yield! Radical.多横中竖士 [79y;117y] [23y;61y]

    ]
    // 腥
    53448us, [
        PenUp
        Displacement(4y,9y)
        PenDown
        Displacement(8y,20y)
        Displacement(3y,28y)
        Displacement(0y,59y)
        Displacement(27y,0y)
        Displacement(0y,-89y)
        Displacement(-3y,-10y)
        Displacement(-13y,-5y)
        PenUp
        Displacement(-13y,71y)
        PenDown
        Displacement(28y,5y)
        PenUp
        Displacement(-23y,-28y)
        PenDown
        Displacement(22y,0y)
        PenUp
        Displacement(22y,58y)
        PenDown
        yield! Radical.日(50y,36y)
        PenUp
        Displacement(7y,-25y)
        PenDown
        Displacement(-18y,-25y)
        PenUp
        Displacement(10y,13y)
        PenDown
        Displacement(61y,0y)
        PenUp
        Displacement(-60y,-23y)
        PenDown
        yield! Radical.多横中竖士 [54y;75y] [25y;69y]

    ]
    // 猩
    53449us, [
        PenUp
        Displacement(38y,121y)
        PenDown
        Displacement(-33y,-41y)
        PenUp
        Displacement(-4y,36y)
        PenDown
        Displacement(17y,-15y)
        Displacement(10y,-13y)
        Displacement(4y,-23y)
        Displacement(0y,-48y)
        Displacement(-8y,-8y)
        Displacement(-15y,-3y)
        PenUp
        Displacement(22y,61y)
        PenDown
        Displacement(-27y,-28y)
        PenUp
        Displacement(51y,74y)
        PenDown
        yield! Radical.日(54y,36y)

        PenUp
        Displacement(7y,-28y)
        PenDown
        Displacement(-15y,-31y)
        PenUp
        Displacement(11y,15y)
        PenDown
        Displacement(61y,0y)
        PenUp
        Displacement(-62y,-23y)
        PenDown
        yield! Radical.多横中竖士 [57y;84y] [23y;66y]

    ]
    // 惺
    53450us, [
        PenUp
        Displacement(14y,98y)
        PenDown
        Displacement(-10y,-33y)
        PenUp
        Displacement(22y,61y)
        PenDown
        Displacement(0y,-125y)
        PenUp
        Displacement(11y,99y)
        PenDown
        Displacement(10y,-25y)
        PenUp
        Displacement(9y,41y)
        PenDown
        yield! Radical.日(54y,38y)

        PenUp
        Displacement(8y,-25y)
        PenDown
        Displacement(-19y,-28y)
        PenUp
        Displacement(15y,15y)
        PenDown
        Displacement(60y,0y)
        PenUp
        Displacement(-62y,-23y)
        PenDown
        yield! Radical.多横中竖士 [56y;88y] [23y;64y]
    ]
    // 兴
    53451us, [
        PenUp
        Displacement(14y,111y)
        PenDown
        Displacement(25y,-38y)
        PenUp
        Displacement(11y,51y)
        PenDown
        Displacement(18y,-41y)
        PenUp
        Displacement(38y,36y)
        PenDown
        Displacement(-31y,-59y)
        PenUp
        Displacement(-73y,-3y)
        PenDown
        Displacement(120y,0y)
        PenUp
        Displacement(-75y,-10y)
        PenDown
        Displacement(-38y,-38y)
        PenUp
        Displacement(64y,41y)
        PenDown
        Displacement(41y,-36y)
    ]
    ]
