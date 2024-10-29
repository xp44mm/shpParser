module gains.Punctuation
open shpParser

open System
open System.Collections.Generic
open System.Text.RegularExpressions

open FSharp.Idioms
open FSharp.Idioms.StringOps
open FSharp.Idioms.OrdinalIgnoreCase
open FSharp.Idioms.RegularExpressions

let punctuations = [
    // 　
    41377us, [
    ]
    // 、
    41378us, [
        PenUp
        Displacement(49y,17y)
        PenDown
        BulgeArc(-34y,30y,8y)
    ]
    // 。
    41379us, [
        PenUp
        Displacement(32y,32y)
        PenDown
        OctantArc(15uy,0x20y)
    ]
    // ·
    41380us, [
        PenUp
        Displacement(72y,50y)
        PenDown
        Displacement(-18y,0y)
        PenUp
        Displacement(-4y,4y)
        PenDown
        Displacement(26y,0y)
        PenUp
        Displacement(2y,4y)
        PenDown
        Displacement(-30y,0y)
        PenUp
        Displacement(31y,5y)
        PenDown
        Displacement(-32y,0y)
        PenUp
        Displacement(1y,5y)
        PenDown
        Displacement(30y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(-26y,0y)
        PenUp
        Displacement(4y,4y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(-9y,-29y)
        PenDown
        Displacement(2y,0y)
        Displacement(3y,1y)
        Displacement(2y,1y)
        Displacement(2y,1y)
        Displacement(4y,4y)
        Displacement(2y,4y)
        Displacement(1y,5y)
        Displacement(-1y,5y)
        Displacement(-2y,4y)
        Displacement(-4y,4y)
        Displacement(-2y,1y)
        Displacement(-2y,1y)
        Displacement(-3y,1y)
        Displacement(-2y,0y)
        Displacement(-2y,0y)
        Displacement(-3y,-1y)
        Displacement(-2y,-1y)
        Displacement(-2y,-1y)
        Displacement(-4y,-4y)
        Displacement(-2y,-4y)
        Displacement(-1y,-5y)
        Displacement(1y,-5y)
        Displacement(2y,-4y)
        Displacement(4y,-4y)
        Displacement(2y,-1y)
        Displacement(2y,-1y)
        Displacement(3y,-1y)
        Displacement(2y,0y)
    ]
    // ˉ
    41381us, [
        PenUp
        Displacement(48y,120y)
        PenDown
        Displacement(32y,0y)
    ]
    // ˇ
    41382us, [
        PenUp
        Displacement(34y,124y)
        PenDown
        Displacement(30y,-20y)
        Displacement(30y,20y)
    ]
    // ¨
    41383us, [
        PenUp
        Displacement(28y,116y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(52y,0y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(17y,7y)
        PenDown
        Displacement(-14y,0y)
        PenUp
        Displacement(-2y,-4y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(1y,-3y)
        PenDown
        Displacement(-20y,0y)
        PenUp
        Displacement(1y,-3y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(-2y,-4y)
        PenDown
        Displacement(-14y,0y)
        PenUp
        Displacement(-38y,0y)
        PenDown
        Displacement(-14y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(1y,3y)
        PenDown
        Displacement(-20y,0y)
        PenUp
        Displacement(1y,3y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(-14y,0y)
    ]
    // 〃
    41384us, [
        PenUp
        Displacement(36y,35y)
        PenDown
        Displacement(20y,45y)
        Displacement(-10y,3y)
        Displacement(-10y,-48y)
        PenUp
        Displacement(36y,0y)
        PenDown
        Displacement(20y,45y)
        Displacement(-10y,3y)
        Displacement(-10y,-48y)
        PenUp
        Displacement(-30y,19y)
        PenDown
        Displacement(9y,27y)
        PenUp
        Displacement(36y,0y)
        PenDown
        Displacement(-9y,-27y)
    ]
    // 々
    41385us, [
        PenUp
        Displacement(59y,105y)
        PenDown
        Displacement(2y,-9y)
        Displacement(-13y,-17y)
        Displacement(-8y,-8y)
        Displacement(-10y,-9y)
        PenUp
        Displacement(13y,12y)
        PenDown
        Displacement(47y,0y)
        PenUp
        Displacement(7y,5y)
        PenDown
        Displacement(-7y,-5y)
        Displacement(-31y,-40y)
        PenUp
        Displacement(-12y,11y)
        PenDown
        Displacement(8y,-7y)
        Displacement(8y,-9y)
        Displacement(3y,-7y)
    ]
    // —
    41386us, [
        PenUp
        Displacement(0y,63y)
        PenDown
        Displacement(127y,0y)
    ]
    // ～
    41387us, [
        PenUp
        Displacement(17y,56y)
        PenDown
        Displacement(10y,6y)
        Displacement(9y,4y)
        Displacement(9y,2y)
        Displacement(4y,0y)
        Displacement(7y,-2y)
        Displacement(18y,-6y)
        Displacement(5y,-1y)
        Displacement(4y,0y)
        Displacement(9y,2y)
        Displacement(9y,4y)
        Displacement(8y,6y)
    ]
    // ‖
    41388us, [
        PenUp
        Displacement(49y,109y)
        PenDown
        Displacement(0y,-90y)
        PenUp
        Displacement(30y,0y)
        PenDown
        Displacement(0y,90y)
    ]
    // …
    41389us, [
        PenUp
        Displacement(10y,63y)
        PenDown
        OctantArc(6uy,0x40y)
        PenUp
        Displacement(48y,0y)
        PenDown
        OctantArc(6uy,0x40y)
        PenUp
        Displacement(48y,0y)
        PenDown
        OctantArc(6uy,0x40y)
    ]
    // ‘
    41390us, [
        PenUp
        Displacement(98y,87y)
        PenDown
        OctantArc(6uy,0x40y)
        Displacement(0y,10y)
        BulgeArc(15y,26y,-32y)
    ]
    // ’
    41391us, [
        PenUp
        Displacement(22y,84y)
        PenDown
        BulgeArc(15y,26y,32y)
        Displacement(0y,10y)
        OctantArc(6uy,0x0y)
    ]
    // “
    41392us, [
        PenUp
        Displacement(88y,85y)
        Push
        PenDown
        OctantArc(6uy,0x40y)
        Displacement(0y,10y)
        BulgeArc(15y,26y,-32y)
        Pop
        PenUp
        Displacement(24y,0y)
        PenDown
        OctantArc(6uy,0x40y)
        Displacement(0y,10y)
        BulgeArc(15y,26y,-32y)
    ]
    // ”
    41393us, [
        PenUp
        Displacement(8y,85y)
        Push
        PenDown
        BulgeArc(15y,26y,32y)
        Displacement(0y,10y)
        OctantArc(6uy,0x0y)
        Pop
        PenUp
        Displacement(24y,0y)
        PenDown
        BulgeArc(15y,26y,32y)
        Displacement(0y,10y)
        OctantArc(6uy,0x0y)
    ]
    // 〔
    41394us, [
        PenUp
        Displacement(118y,118y)
        PenDown
        Displacement(-39y,-20y)
        Displacement(0y,-68y)
        Displacement(39y,-20y)
    ]
    // 〕
    41395us, [
        PenUp
        Displacement(10y,118y)
        PenDown
        Displacement(39y,-20y)
        Displacement(0y,-68y)
        Displacement(-39y,-20y)
    ]
    // 〈
    41396us, [
        PenUp
        Displacement(112y,111y)
        PenDown
        Displacement(-24y,-47y)
        Displacement(24y,-50y)
    ]
    // 〉
    41397us, [
        PenUp
        Displacement(16y,111y)
        PenDown
        Displacement(24y,-47y)
        Displacement(-24y,-50y)
    ]
    // 《
    41398us, [
        PenUp
        Displacement(118y,111y)
        PenDown
        Displacement(-26y,-48y)
        Displacement(26y,-51y)
        PenUp
        Displacement(-30y,99y)
        PenDown
        Displacement(-26y,-48y)
        Displacement(26y,-51y)
    ]
    // 》
    41399us, [
        PenUp
        Displacement(10y,111y)
        PenDown
        Displacement(26y,-48y)
        Displacement(-26y,-51y)
        PenUp
        Displacement(30y,99y)
        PenDown
        Displacement(26y,-48y)
        Displacement(-26y,-51y)
    ]
    // 「
    41400us, [
        PenUp
        Displacement(110y,124y)
        PenDown
        Displacement(-20y,0y)
        Displacement(0y,-79y)
    ]
    // 」
    41401us, [
        PenUp
        Displacement(15y,4y)
        PenDown
        Displacement(20y,0y)
        Displacement(0y,79y)
    ]
    // 『
    41402us, [
        PenUp
        Displacement(87y,48y)
        PenDown
        Displacement(0y,76y)
        Displacement(26y,0y)
        Displacement(0y,-8y)
        Displacement(-16y,0y)
        Displacement(0y,-68y)
        Displacement(-10y,0y)
    ]
    // 』
    41403us, [
        PenUp
        Displacement(15y,4y)
        PenDown
        Displacement(0y,8y)
        Displacement(18y,0y)
        Displacement(0y,68y)
        Displacement(10y,0y)
        Displacement(0y,-76y)
        Displacement(-28y,0y)
    ]
    // 〖
    41404us, [
        PenUp
        Displacement(71y,17y)
        PenDown
        Displacement(0y,94y)
        Displacement(42y,0y)
        Displacement(-11y,-20y)
        Displacement(-6y,-12y)
        Displacement(-3y,-8y)
        Displacement(-1y,-7y)
        Displacement(2y,-12y)
        Displacement(4y,-10y)
        Displacement(6y,-11y)
        Displacement(9y,-14y)
        Displacement(-42y,0y)
    ]
    // 〗
    41405us, [
        PenUp
        Displacement(57y,17y)
        PenDown
        Displacement(0y,94y)
        Displacement(-42y,0y)
        Displacement(11y,-20y)
        Displacement(6y,-12y)
        Displacement(3y,-8y)
        Displacement(1y,-7y)
        Displacement(-2y,-12y)
        Displacement(-4y,-10y)
        Displacement(-6y,-11y)
        Displacement(-9y,-14y)
        Displacement(42y,0y)
    ]
    // 【
    41406us, [
        PenUp
        Displacement(72y,117y)
        PenDown
        Displacement(41y,0y)
        Displacement(-11y,-13y)
        Displacement(-6y,-10y)
        Displacement(-6y,-11y)
        Displacement(-3y,-8y)
        Displacement(-1y,-7y)
        Displacement(1y,-8y)
        Displacement(4y,-12y)
        Displacement(5y,-11y)
        Displacement(17y,-25y)
        Displacement(-41y,0y)
        Displacement(0y,105y)
        PenUp
        Displacement(0y,-101y)
        PenDown
        Displacement(38y,0y)
        PenUp
        Displacement(-3y,4y)
        PenDown
        Displacement(-35y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(-30y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(27y,0y)
        PenUp
        Displacement(-27y,4y)
        PenDown
        Displacement(24y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(-22y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(21y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(-19y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(17y,0y)
        PenUp
        Displacement(-1y,4y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(15y,0y)
        PenUp
        Displacement(-1y,4y)
        PenDown
        Displacement(-14y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(14y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-14y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(15y,0y)
        PenUp
        Displacement(2y,4y)
        PenDown
        Displacement(-17y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(2y,4y)
        PenDown
        Displacement(-20y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(23y,0y)
        PenUp
        Displacement(2y,4y)
        PenDown
        Displacement(-25y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(27y,0y)
        PenUp
        Displacement(3y,4y)
        PenDown
        Displacement(-30y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(33y,0y)
        PenUp
        Displacement(3y,4y)
        PenDown
        Displacement(-36y,0y)
        PenUp
        Displacement(0y,3y)
        PenDown
        Displacement(39y,0y)
    ]
    // 】
    41407us, [
        PenUp
        Displacement(56y,117y)
        PenDown
        Displacement(-41y,0y)
        Displacement(11y,-13y)
        Displacement(6y,-10y)
        Displacement(6y,-11y)
        Displacement(3y,-8y)
        Displacement(1y,-7y)
        Displacement(-1y,-8y)
        Displacement(-4y,-12y)
        Displacement(-5y,-11y)
        Displacement(-17y,-25y)
        Displacement(41y,0y)
        Displacement(0y,105y)
        PenUp
        Displacement(0y,-101y)
        PenDown
        Displacement(-38y,0y)
        PenUp
        Displacement(3y,4y)
        PenDown
        Displacement(35y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-32y,0y)
        PenUp
        Displacement(2y,4y)
        PenDown
        Displacement(30y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-27y,0y)
        PenUp
        Displacement(27y,4y)
        PenDown
        Displacement(-24y,0y)
        PenUp
        Displacement(2y,4y)
        PenDown
        Displacement(22y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-21y,0y)
        PenUp
        Displacement(2y,4y)
        PenDown
        Displacement(19y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-17y,0y)
        PenUp
        Displacement(1y,4y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-15y,0y)
        PenUp
        Displacement(1y,4y)
        PenDown
        Displacement(14y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-14y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(14y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-15y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(17y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-18y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(20y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-23y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(25y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-27y,0y)
        PenUp
        Displacement(-3y,4y)
        PenDown
        Displacement(30y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-33y,0y)
        PenUp
        Displacement(-3y,4y)
        PenDown
        Displacement(36y,0y)
        PenUp
        Displacement(0y,3y)
        PenDown
        Displacement(-39y,0y)
    ]
    // ±
    41408us, [
        PenUp
        Displacement(20y,68y)
        PenDown
        Displacement(86y,0y)
        PenUp
        Displacement(-42y,36y)
        PenDown
        Displacement(0y,-66y)
        PenUp
        Displacement(-44y,-16y)
        PenDown
        Displacement(84y,0y)
    ]
    // ×
    41409us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(78y,-79y)
        PenUp
        Displacement(-78y,0y)
        PenDown
        Displacement(78y,79y)
    ]
    // ÷
    41410us, [
        PenUp
        Displacement(57y,95y)
        PenDown
        Displacement(1y,4y)
        Displacement(2y,2y)
        Displacement(2y,1y)
        Displacement(4y,0y)
        Displacement(2y,-1y)
        Displacement(2y,-2y)
        Displacement(1y,-4y)
        Displacement(-1y,-4y)
        Displacement(-2y,-2y)
        Displacement(-2y,-1y)
        Displacement(-4y,0y)
        Displacement(-2y,1y)
        Displacement(-2y,2y)
        Displacement(-1y,4y)
        PenUp
        Displacement(-40y,-31y)
        PenDown
        Displacement(90y,0y)
        PenUp
        Displacement(-47y,25y)
        PenDown
        Displacement(0y,12y)
        PenUp
        Displacement(4y,1y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(4y,1y)
        PenDown
        Displacement(0y,12y)
        PenUp
        Displacement(0y,-74y)
        PenDown
        Displacement(0y,12y)
        PenUp
        Displacement(-4y,1y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,1y)
        PenDown
        Displacement(0y,12y)
        PenUp
        Displacement(-3y,-6y)
        PenDown
        Displacement(1y,4y)
        Displacement(2y,2y)
        Displacement(2y,1y)
        Displacement(4y,0y)
        Displacement(2y,-1y)
        Displacement(2y,-2y)
        Displacement(1y,-4y)
        Displacement(-1y,-4y)
        Displacement(-2y,-2y)
        Displacement(-2y,-1y)
        Displacement(-4y,0y)
        Displacement(-2y,1y)
        Displacement(-2y,2y)
        Displacement(-1y,4y)
    ]
    // ∶
    41411us, [
        PenUp
        Displacement(54y,32y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(3y,-6y)
        PenDown
        Displacement(14y,0y)
        PenUp
        Displacement(2y,4y)
        PenDown
        Displacement(-18y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(-16y,4y)
        PenDown
        Displacement(14y,0y)
        PenUp
        Displacement(-14y,-64y)
        PenDown
        Displacement(14y,0y)
        PenUp
        Displacement(-16y,-4y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(0y,-4y)
        PenDown
        Displacement(-18y,0y)
        PenUp
        Displacement(2y,-4y)
        PenDown
        Displacement(14y,0y)
    ]
    // ∧
    41412us, [
        PenUp
        Displacement(15y,13y)
        PenDown
        Displacement(49y,102y)
        Displacement(49y,-102y)
    ]
    // ∨
    41413us, [
        PenUp
        Displacement(15y,115y)
        PenDown
        Displacement(49y,-102y)
        Displacement(49y,102y)
    ]
    // ∑
    41414us, [
        PenUp
        Displacement(110y,121y)
        PenDown
        Displacement(4y,-25y)
        Displacement(0y,25y)
        Displacement(-99y,0y)
        Displacement(55y,-56y)
        Displacement(-55y,-58y)
        Displacement(99y,0y)
        Displacement(0y,27y)
        Displacement(-4y,-23y)
        Displacement(-91y,0y)
        PenUp
        Displacement(2y,110y)
        PenDown
        Displacement(55y,-56y)
    ]
    // ∏
    41415us, [
        PenUp
        Displacement(8y,124y)
        PenDown
        Displacement(110y,0y)
        PenUp
        Displacement(-85y,0y)
        PenDown
        Displacement(0y,-121y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(0y,121y)
        PenUp
        Displacement(-14y,-121y)
        PenDown
        Displacement(24y,0y)
        PenUp
        Displacement(33y,0y)
        PenDown
        Displacement(24y,0y)
        PenUp
        Displacement(-10y,0y)
        PenDown
        Displacement(0y,121y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-121y)
    ]
    // ∪
    41416us, [
        PenUp
        Displacement(12y,125y)
        PenDown
        Displacement(0y,-68y)
        Displacement(3y,-18y)
        Displacement(8y,-14y)
        Displacement(11y,-10y)
        Displacement(11y,-7y)
        Displacement(19y,-4y)
        Displacement(19y,4y)
        Displacement(11y,7y)
        Displacement(11y,10y)
        Displacement(8y,14y)
        Displacement(3y,18y)
        Displacement(0y,68y)
    ]
    // ∩
    41417us, [
        PenUp
        Displacement(116y,1y)
        PenDown
        Displacement(0y,68y)
        Displacement(-3y,18y)
        Displacement(-8y,14y)
        Displacement(-11y,10y)
        Displacement(-11y,7y)
        Displacement(-19y,4y)
        Displacement(-19y,-4y)
        Displacement(-11y,-7y)
        Displacement(-11y,-10y)
        Displacement(-8y,-14y)
        Displacement(-3y,-18y)
        Displacement(0y,-68y)
    ]
    // ∈
    41418us, [
        PenUp
        Displacement(87y,18y)
        PenDown
        Displacement(-12y,2y)
        Displacement(-12y,4y)
        Displacement(-8y,6y)
        Displacement(-8y,10y)
        Displacement(-4y,10y)
        Displacement(-2y,14y)
        Displacement(2y,14y)
        Displacement(4y,10y)
        Displacement(8y,10y)
        Displacement(8y,6y)
        Displacement(12y,4y)
        Displacement(12y,2y)
        PenUp
        Displacement(-46y,-46y)
        PenDown
        Displacement(45y,0y)
    ]
    // ∷
    41419us, [
        PenUp
        Displacement(86y,93y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(-64y,0y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(0y,-59y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(-60y,-7y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(4y,2y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(4y,-2y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(0y,73y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(76y,0y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(12y,-59y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
    ]
    // √
    41420us, [
        PenUp
        Displacement(8y,36y)
        PenDown
        Displacement(17y,15y)
        Displacement(35y,-47y)
        Displacement(63y,123y)
    ]
    // ⊥
    41421us, [
        PenUp
        Displacement(18y,24y)
        PenDown
        Displacement(92y,0y)
        PenUp
        Displacement(-46y,0y)
        PenDown
        Displacement(0y,81y)
    ]
    // ∥
    41422us, [
        PenUp
        Displacement(23y,23y)
        PenDown
        Displacement(52y,85y)
        PenUp
        Displacement(30y,0y)
        PenDown
        Displacement(-52y,-85y)
    ]
    // ∠
    41423us, [
        PenUp
        Displacement(118y,107y)
        PenDown
        Displacement(-85y,-86y)
        Displacement(86y,0y)
    ]
    // ⌒
    41424us, [
        PenUp
        Displacement(103y,108y)
        PenDown
        Displacement(-11y,7y)
        Displacement(-8y,4y)
        Displacement(-11y,4y)
        Displacement(-9y,1y)
        Displacement(-9y,-1y)
        Displacement(-11y,-4y)
        Displacement(-8y,-4y)
        Displacement(-11y,-7y)
    ]
    // ⊙
    41425us, [
        PenUp
        Displacement(54y,64y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(-47y,0y)
        PenDown
        Displacement(2y,12y)
        Displacement(4y,12y)
        Displacement(8y,12y)
        Displacement(12y,11y)
        Displacement(16y,7y)
        Displacement(15y,3y)
        Displacement(15y,-3y)
        Displacement(16y,-7y)
        Displacement(12y,-11y)
        Displacement(8y,-12y)
        Displacement(4y,-12y)
        Displacement(2y,-12y)
        Displacement(-2y,-12y)
        Displacement(-4y,-12y)
        Displacement(-8y,-12y)
        Displacement(-12y,-11y)
        Displacement(-16y,-7y)
        Displacement(-15y,-3y)
        Displacement(-15y,3y)
        Displacement(-16y,7y)
        Displacement(-12y,11y)
        Displacement(-8y,12y)
        Displacement(-4y,12y)
        Displacement(-2y,12y)
        PenUp
        Displacement(50y,-6y)
        PenDown
        Displacement(14y,0y)
        PenUp
        Displacement(2y,4y)
        PenDown
        Displacement(-18y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(-2y,4y)
        PenDown
        Displacement(-14y,0y)
    ]
    // ∫
    41426us, [
        PenUp
        Displacement(109y,122y)
        PenDown
        Displacement(-3y,-1y)
        Displacement(-1y,-3y)
        Displacement(1y,-3y)
        Displacement(3y,-1y)
        Displacement(3y,1y)
        Displacement(1y,3y)
        Displacement(-1y,3y)
        Displacement(-6y,2y)
        Displacement(-4y,0y)
        Displacement(-7y,-3y)
        Displacement(-4y,-7y)
        Displacement(-3y,-12y)
        Displacement(-4y,-74y)
        Displacement(-3y,-12y)
        Displacement(-4y,-7y)
        Displacement(-7y,-3y)
        Displacement(-4y,0y)
        Displacement(-6y,2y)
        Displacement(-1y,3y)
        Displacement(1y,3y)
        Displacement(3y,1y)
        Displacement(3y,-1y)
        Displacement(1y,-3y)
        Displacement(-1y,-3y)
        Displacement(-3y,-1y)
    ]
    // ∮
    41427us, [
        PenUp
        Displacement(109y,122y)
        PenDown
        Displacement(-3y,-1y)
        Displacement(-1y,-3y)
        Displacement(1y,-3y)
        Displacement(3y,-1y)
        Displacement(3y,1y)
        Displacement(1y,3y)
        Displacement(-1y,3y)
        Displacement(-6y,2y)
        Displacement(-4y,0y)
        Displacement(-7y,-3y)
        Displacement(-4y,-7y)
        Displacement(-3y,-12y)
        Displacement(-4y,-74y)
        Displacement(-3y,-12y)
        Displacement(-4y,-7y)
        Displacement(-7y,-3y)
        Displacement(-4y,0y)
        Displacement(-6y,2y)
        Displacement(-1y,3y)
        Displacement(1y,3y)
        Displacement(3y,1y)
        Displacement(3y,-1y)
        Displacement(1y,-3y)
        Displacement(-1y,-3y)
        Displacement(-3y,-1y)
        PenUp
        Displacement(24y,71y)
        PenDown
        Displacement(-10y,-1y)
        Displacement(-6y,-3y)
        Displacement(-3y,-3y)
        Displacement(-2y,-4y)
        Displacement(0y,-4y)
        Displacement(2y,-4y)
        Displacement(3y,-3y)
        Displacement(6y,-3y)
        Displacement(10y,-1y)
        Displacement(10y,1y)
        Displacement(6y,3y)
        Displacement(3y,3y)
        Displacement(2y,4y)
        Displacement(0y,4y)
        Displacement(-2y,4y)
        Displacement(-3y,3y)
        Displacement(-6y,3y)
        Displacement(-10y,1y)
    ]
    // ≡
    41428us, [
        PenUp
        Displacement(20y,44y)
        PenDown
        Displacement(88y,0y)
        PenUp
        Displacement(-88y,20y)
        PenDown
        Displacement(88y,0y)
        PenUp
        Displacement(-88y,20y)
        PenDown
        Displacement(88y,0y)
    ]
    // ≌
    41429us, [
        PenUp
        Displacement(17y,29y)
        PenDown
        Displacement(98y,0y)
        PenUp
        Displacement(-98y,24y)
        PenDown
        Displacement(98y,0y)
        PenUp
        Displacement(-70y,45y)
        PenDown
        Displacement(-5y,0y)
        Displacement(-5y,-1y)
        Displacement(-6y,-3y)
        Displacement(-4y,-4y)
        Displacement(-3y,-6y)
        Displacement(0y,-8y)
        Displacement(3y,-7y)
        Displacement(4y,-3y)
        Displacement(7y,-3y)
        Displacement(7y,0y)
        Displacement(6y,3y)
        Displacement(7y,6y)
        Displacement(20y,17y)
        Displacement(7y,6y)
        Displacement(6y,3y)
        Displacement(7y,0y)
        Displacement(7y,-3y)
        Displacement(4y,-3y)
        Displacement(3y,-7y)
        Displacement(0y,-8y)
        Displacement(-3y,-6y)
        Displacement(-4y,-4y)
        Displacement(-6y,-3y)
        Displacement(-5y,-1y)
        Displacement(-5y,0y)
    ]
    // ≈
    41430us, [
        PenUp
        Displacement(16y,69y)
        PenDown
        Displacement(10y,11y)
        Displacement(9y,7y)
        Displacement(7y,2y)
        Displacement(7y,-2y)
        Displacement(28y,-16y)
        Displacement(7y,-2y)
        Displacement(7y,2y)
        Displacement(9y,6y)
        Displacement(10y,11y)
        PenUp
        Displacement(-94y,-48y)
        PenDown
        Displacement(10y,11y)
        Displacement(9y,7y)
        Displacement(7y,2y)
        Displacement(7y,-2y)
        Displacement(28y,-16y)
        Displacement(7y,-2y)
        Displacement(7y,2y)
        Displacement(9y,6y)
        Displacement(10y,11y)
    ]
    // ∽
    41431us, [
        PenUp
        Displacement(41y,41y)
        PenDown
        Displacement(-5y,0y)
        Displacement(-5y,1y)
        Displacement(-6y,3y)
        Displacement(-5y,4y)
        Displacement(-3y,5y)
        Displacement(-2y,8y)
        Displacement(0y,6y)
        Displacement(2y,6y)
        Displacement(4y,6y)
        Displacement(5y,4y)
        Displacement(6y,2y)
        Displacement(7y,0y)
        Displacement(6y,-2y)
        Displacement(7y,-7y)
        Displacement(25y,-27y)
        Displacement(7y,-7y)
        Displacement(6y,-2y)
        Displacement(7y,0y)
        Displacement(6y,2y)
        Displacement(5y,4y)
        Displacement(4y,6y)
        Displacement(2y,6y)
        Displacement(0y,6y)
        Displacement(-2y,8y)
        Displacement(-3y,5y)
        Displacement(-5y,4y)
        Displacement(-6y,3y)
        Displacement(-5y,1y)
        Displacement(-5y,0y)
    ]
    // ∝
    41432us, [
        PenUp
        Displacement(107y,47y)
        PenDown
        Displacement(-5y,-4y)
        Displacement(-6y,-2y)
        Displacement(-7y,0y)
        Displacement(-6y,2y)
        Displacement(-7y,5y)
        Displacement(-5y,5y)
        Displacement(-4y,6y)
        Displacement(-4y,6y)
        Displacement(-4y,6y)
        Displacement(-4y,6y)
        Displacement(-6y,6y)
        Displacement(-5y,3y)
        Displacement(-6y,2y)
        Displacement(-7y,0y)
        Displacement(-6y,-2y)
        Displacement(-5y,-4y)
        Displacement(-4y,-5y)
        Displacement(-3y,-6y)
        Displacement(-1y,-7y)
        Displacement(1y,-7y)
        Displacement(3y,-6y)
        Displacement(4y,-5y)
        Displacement(5y,-4y)
        Displacement(6y,-2y)
        Displacement(7y,0y)
        Displacement(6y,2y)
        Displacement(5y,3y)
        Displacement(6y,6y)
        Displacement(4y,6y)
        Displacement(4y,6y)
        Displacement(4y,6y)
        Displacement(4y,6y)
        Displacement(5y,5y)
        Displacement(7y,5y)
        Displacement(6y,2y)
        Displacement(7y,0y)
        Displacement(6y,-2y)
        Displacement(5y,-4y)
    ]
    // ≠
    41433us, [
        PenUp
        Displacement(10y,81y)
        PenDown
        Displacement(107y,0y)
        PenUp
        Displacement(-107y,-35y)
        PenDown
        Displacement(107y,0y)
        PenUp
        Displacement(-36y,68y)
        PenDown
        Displacement(-39y,-106y)
    ]
    // ≮
    41434us, [
        PenUp
        Displacement(64y,114y)
        PenDown
        Displacement(0y,-103y)
        PenUp
        Displacement(52y,102y)
        PenDown
        Displacement(-103y,-49y)
        Displacement(103y,-37y)
    ]
    // ≯
    41435us, [
        PenUp
        Displacement(64y,114y)
        PenDown
        Displacement(0y,-103y)
        PenUp
        Displacement(-52y,102y)
        PenDown
        Displacement(103y,-49y)
        Displacement(-103y,-37y)
    ]
    // ≤
    41436us, [
        PenUp
        Displacement(115y,113y)
        PenDown
        Displacement(-102y,-49y)
        Displacement(102y,-37y)
        PenUp
        Displacement(-101y,-13y)
        PenDown
        Displacement(101y,0y)
    ]
    // ≥
    41437us, [
        PenUp
        Displacement(11y,113y)
        PenDown
        Displacement(102y,-49y)
        Displacement(-102y,-37y)
        PenUp
        Displacement(0y,-13y)
        PenDown
        Displacement(102y,0y)
    ]
    // ∞
    41438us, [
        PenUp
        Displacement(70y,74y)
        PenDown
        Displacement(-12y,-20y)
        Displacement(-7y,-7y)
        Displacement(-8y,-5y)
        Displacement(-8y,-2y)
        Displacement(-2y,0y)
        Displacement(-7y,2y)
        Displacement(-7y,5y)
        Displacement(-5y,7y)
        Displacement(-2y,8y)
        Displacement(0y,4y)
        Displacement(2y,8y)
        Displacement(5y,7y)
        Displacement(7y,5y)
        Displacement(7y,2y)
        Displacement(2y,0y)
        Displacement(8y,-2y)
        Displacement(8y,-5y)
        Displacement(7y,-7y)
        Displacement(12y,-20y)
        Displacement(7y,-7y)
        Displacement(8y,-5y)
        Displacement(8y,-2y)
        Displacement(2y,0y)
        Displacement(7y,2y)
        Displacement(7y,5y)
        Displacement(5y,7y)
        Displacement(2y,8y)
        Displacement(0y,4y)
        Displacement(-2y,8y)
        Displacement(-5y,7y)
        Displacement(-7y,5y)
        Displacement(-7y,2y)
        Displacement(-2y,0y)
        Displacement(-8y,-2y)
        Displacement(-8y,-5y)
        Displacement(-7y,-7y)
    ]
    // ∵
    41439us, [
        PenUp
        Displacement(22y,92y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(-32y,-56y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(4y,-7y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(4y,2y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(4y,-2y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-32y,70y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(76y,0y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
    ]
    // ∴
    41440us, [
        PenUp
        Displacement(22y,36y)
        PenDown
        Displacement(1y,4y)
        Displacement(2y,3y)
        Displacement(3y,2y)
        Displacement(4y,1y)
        Displacement(4y,-1y)
        Displacement(3y,-2y)
        Displacement(2y,-3y)
        Displacement(1y,-4y)
        Displacement(-1y,-4y)
        Displacement(-2y,-3y)
        Displacement(-3y,-2y)
        Displacement(-4y,-1y)
        Displacement(-4y,1y)
        Displacement(-3y,2y)
        Displacement(-2y,3y)
        Displacement(-1y,4y)
        PenUp
        Displacement(32y,56y)
        PenDown
        Displacement(1y,4y)
        Displacement(2y,3y)
        Displacement(3y,2y)
        Displacement(4y,1y)
        Displacement(4y,-1y)
        Displacement(3y,-2y)
        Displacement(2y,-3y)
        Displacement(1y,-4y)
        Displacement(-1y,-4y)
        Displacement(-2y,-3y)
        Displacement(-3y,-2y)
        Displacement(-4y,-1y)
        Displacement(-4y,1y)
        Displacement(-3y,2y)
        Displacement(-2y,3y)
        Displacement(-1y,4y)
        PenUp
        Displacement(32y,-56y)
        PenDown
        Displacement(1y,4y)
        Displacement(2y,3y)
        Displacement(3y,2y)
        Displacement(4y,1y)
        Displacement(4y,-1y)
        Displacement(3y,-2y)
        Displacement(2y,-3y)
        Displacement(1y,-4y)
        Displacement(-1y,-4y)
        Displacement(-2y,-3y)
        Displacement(-3y,-2y)
        Displacement(-4y,-1y)
        Displacement(-4y,1y)
        Displacement(-3y,2y)
        Displacement(-2y,3y)
        Displacement(-1y,4y)
        PenUp
        Displacement(-60y,-7y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(4y,2y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(4y,-2y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(32y,70y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(44y,-56y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
    ]
    // ♂
    41441us, [
        PenUp
        Displacement(46y,79y)
        PenDown
        Displacement(18y,21y)
        Displacement(18y,-21y)
        PenUp
        Displacement(-18y,21y)
        PenDown
        Displacement(0y,-49y)
        Displacement(-6y,-1y)
        Displacement(-5y,-4y)
        Displacement(-3y,-5y)
        Displacement(-1y,-6y)
        Displacement(1y,-6y)
        Displacement(3y,-5y)
        Displacement(5y,-4y)
        Displacement(6y,-1y)
        Displacement(6y,1y)
        Displacement(5y,4y)
        Displacement(3y,5y)
        Displacement(1y,6y)
        Displacement(-1y,6y)
        Displacement(-3y,5y)
        Displacement(-5y,4y)
        Displacement(-6y,1y)
    ]
    // ♀
    41442us, [
        PenUp
        Displacement(64y,12y)
        PenDown
        Displacement(0y,63y)
        Displacement(-6y,1y)
        Displacement(-5y,4y)
        Displacement(-3y,5y)
        Displacement(-1y,6y)
        Displacement(1y,6y)
        Displacement(3y,5y)
        Displacement(5y,4y)
        Displacement(6y,1y)
        Displacement(6y,-1y)
        Displacement(5y,-4y)
        Displacement(3y,-5y)
        Displacement(1y,-6y)
        Displacement(-1y,-6y)
        Displacement(-3y,-5y)
        Displacement(-5y,-4y)
        Displacement(-6y,-1y)
        PenUp
        Displacement(-30y,-25y)
        PenDown
        Displacement(59y,0y)
    ]
    // °
    41443us, [
        PenUp
        Displacement(5y,111y)
        PenDown
        Displacement(2y,-6y)
        Displacement(5y,-5y)
        Displacement(6y,-2y)
        Displacement(6y,2y)
        Displacement(5y,5y)
        Displacement(2y,6y)
        Displacement(-2y,7y)
        Displacement(-5y,4y)
        Displacement(-6y,2y)
        Displacement(-6y,-2y)
        Displacement(-5y,-4y)
        Displacement(-2y,-7y)
    ]
    // ′
    41444us, [
        PenUp
        Displacement(22y,121y)
        PenDown
        Displacement(-1y,-2y)
        Displacement(-14y,-27y)
        Displacement(-2y,-1y)
        Displacement(0y,1y)
        Displacement(0y,1y)
        Displacement(9y,30y)
        Displacement(2y,1y)
        Displacement(1y,0y)
        Displacement(2y,0y)
        Displacement(2y,-1y)
        Displacement(1y,-2y)
        PenUp
        Displacement(-13y,-21y)
        PenDown
        Displacement(9y,23y)
    ]
    // ″
    41445us, [
        PenUp
        Displacement(39y,121y)
        PenDown
        Displacement(-1y,-2y)
        Displacement(-14y,-27y)
        Displacement(-2y,-1y)
        Displacement(0y,1y)
        Displacement(0y,1y)
        Displacement(9y,30y)
        Displacement(2y,1y)
        Displacement(1y,0y)
        Displacement(2y,0y)
        Displacement(2y,-1y)
        Displacement(1y,-2y)
        PenUp
        Displacement(-17y,0y)
        PenDown
        Displacement(-1y,-2y)
        Displacement(-14y,-27y)
        Displacement(-2y,-1y)
        Displacement(0y,1y)
        Displacement(0y,1y)
        Displacement(9y,30y)
        Displacement(2y,1y)
        Displacement(1y,0y)
        Displacement(2y,0y)
        Displacement(2y,-1y)
        Displacement(1y,-2y)
        PenUp
        Displacement(-12y,-19y)
        PenDown
        Displacement(8y,21y)
        PenUp
        Displacement(17y,0y)
        PenDown
        Displacement(-8y,-21y)
    ]
    // ℃
    41446us, [
        PenUp
        Displacement(10y,113y)
        PenDown
        Displacement(2y,-6y)
        Displacement(6y,-5y)
        Displacement(6y,0y)
        Displacement(6y,5y)
        Displacement(2y,6y)
        Displacement(-2y,7y)
        Displacement(-6y,4y)
        Displacement(-6y,0y)
        Displacement(-6y,-4y)
        Displacement(-2y,-7y)
        PenUp
        Displacement(100y,-11y)
        PenDown
        Displacement(6y,12y)
        Displacement(0y,-27y)
        Displacement(-6y,15y)
        Displacement(-4y,5y)
        Displacement(-8y,5y)
        Displacement(-8y,2y)
        Displacement(-11y,0y)
        Displacement(-9y,-5y)
        Displacement(-8y,-7y)
        Displacement(-7y,-12y)
        Displacement(-4y,-15y)
        Displacement(0y,-20y)
        Displacement(4y,-17y)
        Displacement(6y,-13y)
        Displacement(8y,-8y)
        Displacement(10y,-5y)
        Displacement(11y,0y)
        Displacement(7y,2y)
        Displacement(7y,5y)
        Displacement(5y,6y)
        Displacement(5y,13y)
        PenUp
        Displacement(-35y,76y)
        PenDown
        Displacement(-8y,-7y)
        Displacement(-5y,-6y)
        Displacement(-7y,-12y)
        Displacement(-3y,-14y)
        Displacement(0y,-20y)
        Displacement(3y,-16y)
        Displacement(6y,-14y)
        Displacement(6y,-7y)
        Displacement(8y,-6y)
    ]
    // ＄
    41447us, [
        PenUp
        Displacement(93y,94y)
        PenDown
        Displacement(-3y,1y)
        Displacement(-3y,-1y)
        Displacement(-1y,-3y)
        Displacement(1y,-3y)
        Displacement(3y,-1y)
        Displacement(3y,1y)
        Displacement(1y,3y)
        Displacement(-1y,3y)
        Displacement(-6y,7y)
        Displacement(-7y,4y)
        Displacement(-10y,2y)
        Displacement(-12y,0y)
        Displacement(-7y,-3y)
        Displacement(-6y,-6y)
        Displacement(-4y,-9y)
        Displacement(0y,-8y)
        Displacement(4y,-7y)
        Displacement(6y,-4y)
        Displacement(29y,-12y)
        Displacement(6y,-5y)
        Displacement(4y,-6y)
        Displacement(0y,-11y)
        Displacement(-4y,-7y)
        Displacement(-6y,-5y)
        Displacement(-7y,-3y)
        Displacement(-12y,0y)
        Displacement(-10y,2y)
        Displacement(-7y,4y)
        Displacement(-6y,7y)
        Displacement(-1y,3y)
        Displacement(1y,3y)
        Displacement(3y,1y)
        Displacement(3y,-1y)
        Displacement(1y,-3y)
        Displacement(-1y,-3y)
        Displacement(-3y,-1y)
        Displacement(-3y,1y)
        PenUp
        Displacement(26y,85y)
        PenDown
        Displacement(0y,-108y)
        PenUp
        Displacement(-6y,96y)
        PenDown
        Displacement(-4y,-3y)
        Displacement(-6y,-6y)
        Displacement(-3y,-9y)
        Displacement(0y,-8y)
        Displacement(2y,-5y)
        Displacement(4y,-6y)
        PenUp
        Displacement(29y,-12y)
        PenDown
        Displacement(7y,-3y)
        Displacement(7y,-8y)
        Displacement(0y,-11y)
        Displacement(-4y,-7y)
        Displacement(-6y,-5y)
        Displacement(-11y,-3y)
    ]
    // ¤
    41448us, [
        PenUp
        Displacement(64y,102y)
        PenDown
        Displacement(-15y,-3y)
        Displacement(-12y,-8y)
        Displacement(-8y,-12y)
        Displacement(-3y,-15y)
        Displacement(3y,-14y)
        Displacement(8y,-13y)
        Displacement(12y,-8y)
        Displacement(15y,-3y)
        Displacement(15y,3y)
        Displacement(12y,8y)
        Displacement(8y,13y)
        Displacement(3y,14y)
        Displacement(-3y,15y)
        Displacement(-8y,12y)
        Displacement(-12y,8y)
        Displacement(-15y,3y)
        PenUp
        Displacement(-39y,2y)
        PenDown
        Displacement(12y,-13y)
        PenUp
        Displacement(54y,-54y)
        PenDown
        Displacement(12y,-12y)
        PenUp
        Displacement(0y,79y)
        PenDown
        Displacement(-12y,-13y)
        PenUp
        Displacement(-54y,-54y)
        PenDown
        Displacement(-12y,-12y)
    ]
    // ￠
    41449us, [
        PenUp
        Displacement(65y,113y)
        PenDown
        Displacement(-28y,-102y)
        PenUp
        Displacement(35y,79y)
        PenDown
        Displacement(5y,9y)
        Displacement(0y,-20y)
        Displacement(-5y,11y)
        Displacement(-5y,7y)
        Displacement(-6y,3y)
        Displacement(-8y,2y)
        Displacement(-6y,0y)
        Displacement(-7y,-2y)
        Displacement(-7y,-6y)
        Displacement(-5y,-9y)
        Displacement(-3y,-14y)
        Displacement(0y,-19y)
        Displacement(3y,-14y)
        Displacement(5y,-10y)
        Displacement(7y,-6y)
        Displacement(7y,-3y)
        Displacement(8y,0y)
        Displacement(7y,1y)
        Displacement(6y,4y)
        Displacement(6y,6y)
        Displacement(3y,9y)
        PenUp
        Displacement(-30y,63y)
        PenDown
        Displacement(-7y,-4y)
        Displacement(-4y,-5y)
        Displacement(-4y,-8y)
        Displacement(-3y,-14y)
        Displacement(0y,-19y)
        Displacement(2y,-14y)
        Displacement(4y,-10y)
        Displacement(5y,-5y)
        Displacement(7y,-4y)
    ]
    // ￡
    41450us, [
        PenUp
        Displacement(20y,65y)
        PenDown
        Displacement(62y,0y)
        PenUp
        Displacement(-23y,43y)
        PenDown
        Displacement(-7y,-8y)
        Displacement(-4y,-8y)
        Displacement(-1y,-14y)
        Displacement(0y,-45y)
        Displacement(15y,-8y)
        Displacement(7y,-3y)
        Displacement(7y,0y)
        Displacement(8y,3y)
        Displacement(6y,4y)
        Displacement(5y,4y)
        PenUp
        Displacement(-52y,-5y)
        PenDown
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-4y,3y)
        Displacement(-4y,1y)
        Displacement(-5y,0y)
        Displacement(-4y,-2y)
        Displacement(-2y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        Displacement(0y,-3y)
        Displacement(1y,-4y)
        Displacement(2y,-4y)
        Displacement(3y,-2y)
        Displacement(3y,-1y)
        Displacement(5y,0y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(3y,4y)
        Displacement(1y,4y)
        Displacement(0y,3y)
        PenUp
        Displacement(56y,16y)
        PenDown
        Displacement(-4y,-11y)
        Displacement(-5y,-7y)
        Displacement(-6y,-5y)
        Displacement(-8y,-3y)
        Displacement(-7y,0y)
        Displacement(-7y,3y)
        Displacement(-15y,8y)
        Displacement(-1y,-6y)
        Displacement(-2y,-5y)
        Displacement(-3y,-4y)
        Displacement(-4y,-3y)
        Displacement(-6y,-1y)
        Displacement(-4y,0y)
        Displacement(-6y,2y)
        Displacement(-3y,3y)
        Displacement(-2y,4y)
        Displacement(-1y,5y)
        Displacement(0y,4y)
        Displacement(1y,5y)
        Displacement(2y,4y)
        Displacement(4y,3y)
        Displacement(4y,2y)
        Displacement(6y,0y)
        Displacement(6y,-2y)
        Displacement(5y,-4y)
        Displacement(0y,42y)
        Displacement(2y,14y)
        Displacement(5y,8y)
        Displacement(9y,8y)
        Displacement(8y,4y)
        Displacement(10y,0y)
        Displacement(8y,-4y)
        Displacement(3y,-3y)
        Displacement(2y,-7y)
        Displacement(-4y,3y)
        Displacement(-4y,-3y)
        Displacement(0y,-4y)
        Displacement(4y,-3y)
        Displacement(4y,3y)
        Displacement(0y,4y)
    ]
    // ‰
    41451us, [
        PenUp
        Displacement(41y,110y)
        PenDown
        Displacement(-3y,2y)
        Displacement(-5y,0y)
        Displacement(-5y,-2y)
        Displacement(-6y,-5y)
        Displacement(-5y,-6y)
        Displacement(-6y,-12y)
        Displacement(-2y,-9y)
        Displacement(0y,-7y)
        Displacement(1y,-5y)
        Displacement(3y,-3y)
        Displacement(4y,0y)
        Displacement(6y,1y)
        Displacement(5y,3y)
        Displacement(4y,4y)
        Displacement(6y,8y)
        Displacement(4y,10y)
        Displacement(1y,7y)
        Displacement(0y,7y)
        Displacement(-1y,5y)
        Displacement(-1y,2y)
        PenUp
        Displacement(34y,-50y)
        PenDown
        Displacement(-3y,2y)
        Displacement(-5y,0y)
        Displacement(-5y,-2y)
        Displacement(-6y,-5y)
        Displacement(-5y,-6y)
        Displacement(-6y,-12y)
        Displacement(-2y,-9y)
        Displacement(0y,-7y)
        Displacement(1y,-5y)
        Displacement(3y,-3y)
        Displacement(4y,0y)
        Displacement(6y,1y)
        Displacement(5y,3y)
        Displacement(4y,4y)
        Displacement(6y,8y)
        Displacement(4y,10y)
        Displacement(1y,7y)
        Displacement(0y,7y)
        Displacement(-1y,5y)
        Displacement(-1y,2y)
        PenUp
        Displacement(40y,0y)
        PenDown
        Displacement(-3y,2y)
        Displacement(-5y,0y)
        Displacement(-5y,-2y)
        Displacement(-6y,-5y)
        Displacement(-5y,-6y)
        Displacement(-6y,-12y)
        Displacement(-2y,-9y)
        Displacement(0y,-7y)
        Displacement(1y,-5y)
        Displacement(3y,-3y)
        Displacement(4y,0y)
        Displacement(6y,1y)
        Displacement(5y,3y)
        Displacement(4y,4y)
        Displacement(6y,8y)
        Displacement(4y,10y)
        Displacement(1y,7y)
        Displacement(0y,7y)
        Displacement(-1y,5y)
        Displacement(-1y,2y)
        PenUp
        Displacement(-39y,60y)
        PenDown
        Displacement(-66y,-111y)
    ]
    // §
    41452us, [
        PenUp
        Displacement(73y,19y)
        PenDown
        Displacement(3y,-1y)
        Displacement(3y,1y)
        Displacement(1y,3y)
        Displacement(-1y,3y)
        Displacement(-3y,1y)
        Displacement(-3y,-1y)
        Displacement(-1y,-3y)
        Displacement(2y,-7y)
        Displacement(3y,-4y)
        Displacement(6y,-3y)
        Displacement(7y,-1y)
        Displacement(7y,1y)
        Displacement(7y,4y)
        Displacement(2y,6y)
        Displacement(0y,5y)
        Displacement(-1y,4y)
        Displacement(-5y,6y)
        Displacement(-29y,26y)
        Displacement(-3y,6y)
        Displacement(-1y,5y)
        Displacement(0y,2y)
        Displacement(2y,4y)
        Displacement(4y,4y)
        Displacement(6y,2y)
        Displacement(4y,0y)
        Displacement(6y,-1y)
        Displacement(4y,-2y)
        PenUp
        Displacement(9y,30y)
        PenDown
        Displacement(-3y,1y)
        Displacement(-3y,-1y)
        Displacement(-1y,-3y)
        Displacement(1y,-3y)
        Displacement(3y,-1y)
        Displacement(3y,1y)
        Displacement(1y,3y)
        Displacement(-2y,7y)
        Displacement(-3y,4y)
        Displacement(-6y,3y)
        Displacement(-7y,1y)
        Displacement(-7y,-1y)
        Displacement(-7y,-4y)
        Displacement(-2y,-6y)
        Displacement(0y,-5y)
        Displacement(1y,-4y)
        Displacement(5y,-6y)
        Displacement(29y,-26y)
        Displacement(3y,-6y)
        Displacement(1y,-5y)
        Displacement(0y,-2y)
        Displacement(-2y,-4y)
        Displacement(-4y,-4y)
        Displacement(-6y,-2y)
        Displacement(-4y,0y)
        Displacement(-6y,1y)
        Displacement(-4y,2y)
    ]
    // №
    41453us, [
        PenUp
        Displacement(90y,88y)
        PenDown
        Displacement(5y,-2y)
        Displacement(4y,-4y)
        Displacement(2y,-6y)
        Displacement(1y,-9y)
        Displacement(0y,-35y)
        Displacement(-1y,-9y)
        Displacement(-2y,-6y)
        Displacement(-4y,-4y)
        Displacement(-5y,-2y)
        Displacement(-6y,0y)
        Displacement(-5y,2y)
        Displacement(-4y,4y)
        Displacement(-2y,6y)
        Displacement(-1y,9y)
        Displacement(0y,35y)
        Displacement(1y,9y)
        Displacement(2y,6y)
        Displacement(4y,4y)
        Displacement(5y,2y)
        Displacement(6y,0y)
        PenUp
        Displacement(-87y,28y)
        PenDown
        Displacement(16y,0y)
        Displacement(39y,-95y)
        PenUp
        Displacement(-44y,-10y)
        PenDown
        Displacement(0y,105y)
        Displacement(44y,-105y)
        Displacement(0y,105y)
        PenUp
        Displacement(-53y,-105y)
        PenDown
        Displacement(20y,0y)
        PenUp
        Displacement(45y,105y)
        PenDown
        Displacement(-24y,0y)
        PenUp
        Displacement(78y,-100y)
        PenDown
        Displacement(-1y,3y)
        Displacement(-4y,2y)
        Displacement(-4y,-2y)
        Displacement(-1y,-3y)
        Displacement(1y,-3y)
        Displacement(4y,-2y)
        Displacement(4y,2y)
        Displacement(1y,3y)
    ]
    // ☆
    41454us, [
        PenUp
        Displacement(64y,110y)
        PenDown
        Displacement(-14y,-34y)
        Displacement(-34y,0y)
        Displacement(26y,-20y)
        Displacement(-10y,-34y)
        Displacement(32y,19y)
        Displacement(32y,-19y)
        Displacement(-10y,34y)
        Displacement(26y,20y)
        Displacement(-34y,0y)
        Displacement(-14y,34y)
    ]
    // ★
    41455us, [
        PenUp
        Displacement(64y,110y)
        PenDown
        Displacement(-14y,-34y)
        Displacement(-34y,0y)
        Displacement(26y,-20y)
        Displacement(-10y,-34y)
        Displacement(32y,19y)
        Displacement(32y,-19y)
        Displacement(-10y,34y)
        Displacement(26y,20y)
        Displacement(-34y,0y)
        Displacement(-14y,34y)
        PenUp
        Displacement(0y,-1y)
        PenDown
        Displacement(0y,-68y)
        PenUp
        Displacement(4y,-2y)
        PenDown
        Displacement(0y,61y)
        PenUp
        Displacement(4y,-10y)
        PenDown
        Displacement(0y,-53y)
        PenUp
        Displacement(4y,-3y)
        PenDown
        Displacement(0y,46y)
        PenUp
        Displacement(4y,-4y)
        PenDown
        Displacement(0y,-44y)
        PenUp
        Displacement(4y,-2y)
        PenDown
        Displacement(0y,46y)
        PenUp
        Displacement(4y,-49y)
        PenDown
        Displacement(0y,21y)
        PenUp
        Displacement(0y,10y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(0y,-15y)
        PenUp
        Displacement(0y,-26y)
        PenDown
        Displacement(0y,-10y)
        PenUp
        Displacement(4y,51y)
        PenDown
        Displacement(0y,-12y)
        PenUp
        Displacement(4y,12y)
        PenDown
        Displacement(0y,-9y)
        PenUp
        Displacement(4y,3y)
        PenDown
        Displacement(0y,6y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(0y,-3y)
        PenUp
        Displacement(-88y,3y)
        PenDown
        Displacement(0y,-3y)
        PenUp
        Displacement(4y,-3y)
        PenDown
        Displacement(0y,6y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(0y,-9y)
        PenUp
        Displacement(4y,9y)
        PenDown
        Displacement(0y,-12y)
        PenUp
        Displacement(4y,-29y)
        PenDown
        Displacement(0y,-10y)
        PenUp
        Displacement(0y,51y)
        PenDown
        Displacement(0y,-15y)
        PenUp
        Displacement(4y,-3y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(0y,-49y)
        PenDown
        Displacement(0y,21y)
        PenUp
        Displacement(4y,-18y)
        PenDown
        Displacement(0y,46y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(0y,-44y)
        PenUp
        Displacement(4y,2y)
        PenDown
        Displacement(0y,46y)
        PenUp
        Displacement(4y,10y)
        PenDown
        Displacement(0y,-53y)
        PenUp
        Displacement(4y,2y)
        PenDown
        Displacement(0y,61y)
    ]
    // ○
    41456us, [
        PenUp
        Displacement(118y,64y)
        PenDown
        Displacement(-1y,11y)
        Displacement(-3y,10y)
        Displacement(-5y,9y)
        Displacement(-7y,8y)
        Displacement(-8y,7y)
        Displacement(-9y,5y)
        Displacement(-10y,3y)
        Displacement(-11y,1y)
        Displacement(-11y,-1y)
        Displacement(-10y,-3y)
        Displacement(-9y,-5y)
        Displacement(-8y,-7y)
        Displacement(-7y,-8y)
        Displacement(-5y,-9y)
        Displacement(-3y,-10y)
        Displacement(-1y,-11y)
        Displacement(1y,-11y)
        Displacement(3y,-10y)
        Displacement(5y,-9y)
        Displacement(7y,-8y)
        Displacement(8y,-7y)
        Displacement(9y,-5y)
        Displacement(10y,-3y)
        Displacement(11y,-1y)
        Displacement(11y,1y)
        Displacement(10y,3y)
        Displacement(9y,5y)
        Displacement(8y,7y)
        Displacement(7y,8y)
        Displacement(5y,9y)
        Displacement(3y,10y)
        Displacement(1y,11y)
    ]
    // ●
    41457us, [
        PenUp
        Displacement(104y,64y)
        PenDown
        Displacement(-1y,10y)
        Displacement(-4y,10y)
        Displacement(-7y,9y)
        Displacement(-8y,6y)
        Displacement(-10y,4y)
        Displacement(-10y,1y)
        Displacement(-10y,-1y)
        Displacement(-10y,-4y)
        Displacement(-8y,-6y)
        Displacement(-7y,-9y)
        Displacement(-4y,-10y)
        Displacement(-1y,-10y)
        Displacement(1y,-10y)
        Displacement(4y,-10y)
        Displacement(7y,-9y)
        Displacement(8y,-6y)
        Displacement(10y,-4y)
        Displacement(10y,-1y)
        Displacement(10y,1y)
        Displacement(10y,4y)
        Displacement(8y,6y)
        Displacement(7y,9y)
        Displacement(4y,10y)
        Displacement(1y,10y)
        Displacement(-80y,0y)
        PenUp
        Displacement(1y,-4y)
        PenDown
        Displacement(78y,0y)
        PenUp
        Displacement(-1y,-4y)
        PenDown
        Displacement(-76y,0y)
        PenUp
        Displacement(0y,-4y)
        PenDown
        Displacement(76y,0y)
        PenUp
        Displacement(-2y,-4y)
        PenDown
        Displacement(-72y,0y)
        PenUp
        Displacement(2y,-4y)
        PenDown
        Displacement(68y,0y)
        PenUp
        Displacement(-3y,-4y)
        PenDown
        Displacement(-62y,0y)
        PenUp
        Displacement(3y,-4y)
        PenDown
        Displacement(56y,0y)
        PenUp
        Displacement(-5y,-4y)
        PenDown
        Displacement(-46y,0y)
        PenUp
        Displacement(7y,-4y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-32y,72y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(7y,-4y)
        PenDown
        Displacement(-46y,0y)
        PenUp
        Displacement(-5y,-4y)
        PenDown
        Displacement(56y,0y)
        PenUp
        Displacement(3y,-4y)
        PenDown
        Displacement(-62y,0y)
        PenUp
        Displacement(-3y,-4y)
        PenDown
        Displacement(68y,0y)
        PenUp
        Displacement(2y,-4y)
        PenDown
        Displacement(-72y,0y)
        PenUp
        Displacement(-2y,-4y)
        PenDown
        Displacement(76y,0y)
        PenUp
        Displacement(0y,-4y)
        PenDown
        Displacement(-76y,0y)
        PenUp
        Displacement(-1y,-4y)
        PenDown
        Displacement(78y,0y)
    ]
    // ◎
    41458us, [
        PenUp
        Displacement(118y,64y)
        PenDown
        Displacement(-1y,11y)
        Displacement(-3y,10y)
        Displacement(-5y,9y)
        Displacement(-7y,8y)
        Displacement(-8y,7y)
        Displacement(-9y,5y)
        Displacement(-10y,3y)
        Displacement(-11y,1y)
        Displacement(-11y,-1y)
        Displacement(-10y,-3y)
        Displacement(-9y,-5y)
        Displacement(-8y,-7y)
        Displacement(-7y,-8y)
        Displacement(-5y,-9y)
        Displacement(-3y,-10y)
        Displacement(-1y,-11y)
        Displacement(1y,-11y)
        Displacement(3y,-10y)
        Displacement(5y,-9y)
        Displacement(7y,-8y)
        Displacement(8y,-7y)
        Displacement(9y,-5y)
        Displacement(10y,-3y)
        Displacement(11y,-1y)
        Displacement(11y,1y)
        Displacement(10y,3y)
        Displacement(9y,5y)
        Displacement(8y,7y)
        Displacement(7y,8y)
        Displacement(5y,9y)
        Displacement(3y,10y)
        Displacement(1y,11y)
        PenUp
        Displacement(-18y,0y)
        PenDown
        Displacement(-1y,8y)
        Displacement(-3y,8y)
        Displacement(-4y,7y)
        Displacement(-5y,5y)
        Displacement(-7y,4y)
        Displacement(-8y,3y)
        Displacement(-8y,1y)
        Displacement(-8y,-1y)
        Displacement(-8y,-3y)
        Displacement(-7y,-4y)
        Displacement(-5y,-5y)
        Displacement(-4y,-7y)
        Displacement(-3y,-8y)
        Displacement(-1y,-8y)
        Displacement(1y,-8y)
        Displacement(3y,-8y)
        Displacement(4y,-7y)
        Displacement(5y,-5y)
        Displacement(7y,-4y)
        Displacement(8y,-3y)
        Displacement(8y,-1y)
        Displacement(8y,1y)
        Displacement(8y,3y)
        Displacement(7y,4y)
        Displacement(5y,5y)
        Displacement(4y,7y)
        Displacement(3y,8y)
        Displacement(1y,8y)
    ]
    // ◇
    41459us, [
        PenUp
        Displacement(8y,64y)
        PenDown
        Displacement(56y,56y)
        Displacement(56y,-56y)
        Displacement(-56y,-56y)
        Displacement(-56y,56y)
    ]
    // ◆
    41460us, [
        PenUp
        Displacement(8y,64y)
        PenDown
        Displacement(56y,56y)
        Displacement(56y,-56y)
        Displacement(-56y,-56y)
        Displacement(-56y,56y)
        PenUp
        Displacement(56y,-56y)
        PenDown
        Displacement(0y,112y)
        PenUp
        Displacement(4y,-4y)
        PenDown
        Displacement(0y,-104y)
        PenUp
        Displacement(4y,100y)
        PenDown
        Displacement(0y,-96y)
        PenUp
        Displacement(4y,92y)
        PenDown
        Displacement(0y,-88y)
        PenUp
        Displacement(4y,84y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(4y,76y)
        PenDown
        Displacement(0y,-72y)
        PenUp
        Displacement(4y,68y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(4y,60y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(4y,52y)
        PenDown
        Displacement(0y,-48y)
        PenUp
        Displacement(4y,44y)
        PenDown
        Displacement(0y,-40y)
        PenUp
        Displacement(4y,36y)
        PenDown
        Displacement(0y,-32y)
        PenUp
        Displacement(4y,28y)
        PenDown
        Displacement(0y,-24y)
        PenUp
        Displacement(4y,20y)
        PenDown
        Displacement(0y,-16y)
        PenUp
        Displacement(4y,12y)
        PenDown
        Displacement(0y,-8y)
        PenUp
        Displacement(-104y,8y)
        PenDown
        Displacement(0y,-8y)
        PenUp
        Displacement(4y,12y)
        PenDown
        Displacement(0y,-16y)
        PenUp
        Displacement(4y,20y)
        PenDown
        Displacement(0y,-24y)
        PenUp
        Displacement(4y,28y)
        PenDown
        Displacement(0y,-32y)
        PenUp
        Displacement(4y,36y)
        PenDown
        Displacement(0y,-40y)
        PenUp
        Displacement(4y,44y)
        PenDown
        Displacement(0y,-48y)
        PenUp
        Displacement(4y,52y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(4y,60y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(4y,68y)
        PenDown
        Displacement(0y,-72y)
        PenUp
        Displacement(4y,76y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(4y,84y)
        PenDown
        Displacement(0y,-88y)
        PenUp
        Displacement(4y,92y)
        PenDown
        Displacement(0y,-96y)
        PenUp
        Displacement(4y,100y)
        PenDown
        Displacement(0y,-104y)
    ]
    // □
    41461us, [
        PenUp
        Displacement(11y,115y)
        PenDown
        Displacement(104y,0y)
        Displacement(0y,-104y)
        Displacement(-104y,0y)
        Displacement(0y,104y)
    ]
    // ■
    41462us, [
        PenUp
        Displacement(12y,117y)
        PenDown
        Displacement(104y,0y)
        Displacement(0y,-104y)
        Displacement(-104y,0y)
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
        PenUp
        Displacement(4y,-104y)
        PenDown
        Displacement(0y,104y)
    ]
    // △
    41463us, [
        PenUp
        Displacement(14y,18y)
        PenDown
        Displacement(100y,0y)
        Displacement(-50y,91y)
        Displacement(-50y,-91y)
    ]
    // ▲
    41464us, [
        PenUp
        Displacement(14y,18y)
        PenDown
        Displacement(100y,0y)
        Displacement(-50y,91y)
        Displacement(-50y,-91y)
        PenUp
        Displacement(50y,0y)
        PenDown
        Displacement(0y,91y)
        PenUp
        Displacement(4y,-91y)
        PenDown
        Displacement(0y,83y)
        PenUp
        Displacement(4y,-83y)
        PenDown
        Displacement(0y,75y)
        PenUp
        Displacement(4y,-75y)
        PenDown
        Displacement(0y,68y)
        PenUp
        Displacement(4y,-68y)
        PenDown
        Displacement(0y,61y)
        PenUp
        Displacement(4y,-61y)
        PenDown
        Displacement(0y,54y)
        PenUp
        Displacement(4y,-54y)
        PenDown
        Displacement(0y,46y)
        PenUp
        Displacement(4y,-46y)
        PenDown
        Displacement(0y,39y)
        PenUp
        Displacement(4y,-39y)
        PenDown
        Displacement(0y,32y)
        PenUp
        Displacement(4y,-32y)
        PenDown
        Displacement(0y,24y)
        PenUp
        Displacement(4y,-24y)
        PenDown
        Displacement(0y,17y)
        PenUp
        Displacement(4y,-17y)
        PenDown
        Displacement(0y,10y)
        PenUp
        Displacement(4y,-10y)
        PenDown
        Displacement(0y,3y)
        PenUp
        Displacement(-96y,-3y)
        PenDown
        Displacement(0y,3y)
        PenUp
        Displacement(4y,-3y)
        PenDown
        Displacement(0y,10y)
        PenUp
        Displacement(4y,-10y)
        PenDown
        Displacement(0y,17y)
        PenUp
        Displacement(4y,-17y)
        PenDown
        Displacement(0y,24y)
        PenUp
        Displacement(4y,-24y)
        PenDown
        Displacement(0y,32y)
        PenUp
        Displacement(4y,-32y)
        PenDown
        Displacement(0y,39y)
        PenUp
        Displacement(4y,-39y)
        PenDown
        Displacement(0y,46y)
        PenUp
        Displacement(4y,-46y)
        PenDown
        Displacement(0y,54y)
        PenUp
        Displacement(4y,-54y)
        PenDown
        Displacement(0y,61y)
        PenUp
        Displacement(4y,-61y)
        PenDown
        Displacement(0y,68y)
        PenUp
        Displacement(4y,-68y)
        PenDown
        Displacement(0y,75y)
        PenUp
        Displacement(4y,-75y)
        PenDown
        Displacement(0y,83y)
    ]
    // ※
    41465us, [
        PenUp
        Displacement(54y,32y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(-35y,32y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(35y,35y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(31y,-35y)
        PenDown
        Displacement(1y,-4y)
        Displacement(2y,-3y)
        Displacement(3y,-2y)
        Displacement(4y,-1y)
        Displacement(4y,1y)
        Displacement(3y,2y)
        Displacement(2y,3y)
        Displacement(1y,4y)
        Displacement(-1y,4y)
        Displacement(-2y,3y)
        Displacement(-3y,2y)
        Displacement(-4y,1y)
        Displacement(-4y,-1y)
        Displacement(-3y,-2y)
        Displacement(-2y,-3y)
        Displacement(-1y,-4y)
        PenUp
        Displacement(28y,49y)
        PenDown
        Displacement(-100y,-100y)
        PenUp
        Displacement(2y,100y)
        PenDown
        Displacement(100y,-100y)
        PenUp
        Displacement(-92y,44y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(4y,2y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(4y,-2y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(66y,14y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(-19y,35y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
        PenUp
        Displacement(12y,-67y)
        PenDown
        Displacement(0y,-14y)
        PenUp
        Displacement(-4y,-2y)
        PenDown
        Displacement(0y,18y)
        PenUp
        Displacement(-4y,0y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Displacement(-4y,2y)
        PenDown
        Displacement(0y,14y)
    ]
    // →
    41466us, [
        PenUp
        Displacement(5y,64y)
        PenDown
        Displacement(118y,0y)
        Displacement(-51y,17y)
        Displacement(11y,-17y)
        Displacement(-11y,-17y)
        Displacement(51y,17y)
    ]
    // ←
    41467us, [
        PenUp
        Displacement(121y,64y)
        PenDown
        Displacement(-118y,0y)
        Displacement(51y,17y)
        Displacement(-11y,-17y)
        Displacement(11y,-17y)
        Displacement(-51y,17y)
    ]
    // ↑
    41468us, [
        PenUp
        Displacement(64y,6y)
        PenDown
        Displacement(0y,118y)
        Displacement(17y,-51y)
        Displacement(-17y,11y)
        Displacement(-17y,-11y)
        Displacement(17y,51y)
    ]
    // ↓
    41469us, [
        PenUp
        Displacement(64y,123y)
        PenDown
        Displacement(0y,-118y)
        Displacement(-17y,51y)
        Displacement(17y,-11y)
        Displacement(17y,11y)
        Displacement(-17y,-51y)
    ]
    // 〓
    41470us, [
        PenUp
        Displacement(15y,40y)
        PenDown
        Displacement(98y,0y)
        Displacement(0y,-20y)
        Displacement(-98y,0y)
        Displacement(0y,20y)
        PenUp
        Displacement(0y,58y)
        PenDown
        Displacement(98y,0y)
        Displacement(0y,-20y)
        Displacement(-98y,0y)
        Displacement(0y,20y)
        PenUp
        Displacement(0y,-74y)
        PenDown
        Displacement(98y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-98y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(98y,0y)
        PenUp
        Displacement(0y,4y)
        PenDown
        Displacement(-98y,0y)
        PenUp
        Displacement(98y,58y)
        PenDown
        Displacement(-98y,0y)
        PenUp
        Displacement(0y,-4y)
        PenDown
        Displacement(98y,0y)
        PenUp
        Displacement(0y,-4y)
        PenDown
        Displacement(-98y,0y)
        PenUp
        Displacement(0y,-4y)
        PenDown
        Displacement(98y,0y)
    ]
    // ⒈
    41649us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(16y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,0y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-8y,-8y)
    ]
    // ⒉
    41650us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(8y,16y)
        Displacement(16y,8y)
        Displacement(16y,-8y)
        Displacement(8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-40y,-64y)
        Displacement(48y,0y)
        Displacement(0y,16y)
        PenUp
        Displacement(16y,-8y)
        PenDown
        Displacement(8y,-8y)
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        PenUp
        Displacement(0y,8y)
        PenDown
        Displacement(-8y,-8y)
    ]
    // ⒊
    41651us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(8y,16y)
        Displacement(16y,8y)
        Displacement(16y,-8y)
        Displacement(8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-24y,-16y)
        Displacement(24y,-16y)
        Displacement(8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-8y)
        Displacement(-16y,8y)
        Displacement(-8y,16y)
        PenUp
        Displacement(64y,-8y)
        PenDown
        Displacement(8y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(0y,8y)
        Displacement(8y,-8y)
        PenUp
        Displacement(0y,8y)
        PenDown
        Displacement(-8y,-8y)
    ]
    // ⒋
    41652us, [
        PenUp
        Displacement(56y,111y)
        PenDown
        Displacement(-40y,-64y)
        Displacement(64y,0y)
        PenUp
        Displacement(-24y,64y)
        PenDown
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(8y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(8y,8y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(8y,-8y)
    ]
    // ⒌
    41653us, [
        PenUp
        Displacement(79y,95y)
        Displacement(0y,8y)
        PenDown
        Displacement(0y,8y)
        Displacement(-48y,0y)
        Displacement(0y,-56y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-24y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,8y)
        PenUp
        Displacement(71y,-16y)
        PenDown
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(0y,8y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(0y,8y)
        PenDown
        Displacement(8y,-8y)
    ]
    // ⒍
    41654us, [
        PenUp
        Displacement(79y,95y)
        PenDown
        Displacement(-8y,16y)
        Displacement(-32y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-71y)
        Displacement(16y,-16y)
        Displacement(24y,0y)
        Displacement(16y,16y)
        Displacement(0y,24y)
        Displacement(-8y,16y)
        Displacement(-8y,8y)
        Displacement(-16y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(71y,-48y)
        PenDown
        Displacement(8y,0y)
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,8y)
        PenUp
        Displacement(0y,-8y)
        PenDown
        Displacement(-8y,8y)
    ]
    // ⒎
    41655us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(0y,8y)
        Displacement(56y,0y)
        Displacement(-16y,-32y)
        Displacement(-24y,-48y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(8y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(8y,8y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(8y,-8y)
    ]
    // ⒏
    41656us, [
        PenUp
        Displacement(40y,111y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(48y,-40y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,16y)
        Displacement(48y,40y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
    ]
    // ⒐
    41657us, [
        PenUp
        Displacement(24y,32y)
        PenDown
        Displacement(0y,-8y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,71y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-24y)
        Displacement(16y,-16y)
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(8y,8y)
        PenUp
        Displacement(24y,-56y)
        PenDown
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(0y,8y)
        Displacement(-8y,-8y)
    ]
    // ⒑
    41658us, [
        PenUp
        Displacement(16y,103y)
        Displacement(8y,0y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(-16y,16y)
        Displacement(0y,71y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-71y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        PenUp
        Displacement(48y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
    ]
    // ⒒
    41659us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        Displacement(8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,103y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(40y,-95y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
    ]
    // ⒓
    41660us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(71y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-8y,8y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-40y,0y)
        Displacement(32y,64y)
        Displacement(8y,16y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-8y)
    ]
    // ⒔
    41661us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,32y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-8y,8y)
        Displacement(-24y,8y)
        Displacement(24y,8y)
        Displacement(8y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        PenUp
        Displacement(56y,-71y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
    ]
    // ⒕
    41662us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,103y)
        Displacement(-40y,-79y)
        Displacement(56y,0y)
        PenUp
        Displacement(16y,-16y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(0y,8y)
        Displacement(8y,0y)
        Displacement(-8y,-8y)
    ]
    // ⒖
    41663us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(8y,24y)
        PenDown
        Displacement(0y,-8y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,56y)
        Displacement(48y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(16y,-95y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
    ]
    // ⒗
    41664us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(71y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-8y,79y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,8y)
        Displacement(-24y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-71y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-8y)
    ]
    // ⒘
    41665us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(-8y,16y)
        Displacement(0y,8y)
        Displacement(40y,79y)
        Displacement(-48y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(40y,-87y)
        PenDown
        Displacement(8y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(0y,8y)
        Displacement(8y,-8y)
    ]
    // ⒙
    41666us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(-16y,16y)
        Displacement(0y,16y)
        Displacement(48y,40y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(48y,-40y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        PenUp
        Displacement(48y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
    ]
    // ⒚
    41667us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-103y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(71y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-56y,24y)
        PenDown
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(8y,0y)
        Displacement(8y,0y)
        Displacement(16y,16y)
        Displacement(0y,71y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-24y)
        Displacement(16y,-16y)
        Displacement(8y,0y)
        Displacement(16y,8y)
    ]
    // ⒛
    41668us, [
        PenUp
        Displacement(8y,87y)
        PenDown
        Displacement(8y,16y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(0y,-32y)
        Displacement(-40y,-64y)
        Displacement(40y,0y)
        Displacement(0y,8y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(0y,87y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-87y)
        Displacement(-8y,-8y)
        Displacement(-16y,0y)
        Displacement(-8y,8y)
        PenUp
        Displacement(40y,0y)
        PenDown
        Displacement(8y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(0y,8y)
        Displacement(8y,-8y)
    ]
    // ⑴
    41669us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-40y,-16y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ⑵
    41670us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-56y,-32y)
        PenDown
        Displacement(0y,8y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-48y,-40y)
        Displacement(48y,0y)
        Displacement(0y,8y)
    ]
    // ⑶
    41671us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-48y)
        Displacement(0y,-8y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-56y,-32y)
        PenDown
        Displacement(0y,8y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-8y)
        Displacement(-24y,-16y)
        Displacement(24y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,8y)
    ]
    // ⑷
    41672us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(-40y,-64y)
        Displacement(56y,0y)
        PenUp
        Displacement(-24y,-24y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
    ]
    // ⑸
    41673us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-24y)
        PenDown
        Displacement(0y,8y)
        Displacement(-48y,0y)
        Displacement(0y,-40y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,8y)
        Displacement(0y,8y)
    ]
    // ⑹
    41674us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-24y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,8y)
        Displacement(-24y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-48y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-8y)
    ]
    // ⑺
    41675us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(0y,8y)
        Displacement(48y,0y)
        Displacement(-24y,-48y)
        Displacement(-8y,-32y)
        PenUp
        Displacement(-24y,-8y)
        PenDown
        Displacement(-16y,24y)
        Displacement(0y,56y)
        Displacement(16y,24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,-24y)
        Displacement(0y,-56y)
        Displacement(-16y,-24y)
    ]
    // ⑻
    41676us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-24y,-8y)
        PenDown
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-8y)
        Displacement(48y,-32y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,8y)
        Displacement(48y,32y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
    ]
    // ⑼
    41677us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-56y,-71y)
        PenDown
        Displacement(0y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,40y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,0y)
        Displacement(16y,8y)
    ]
    // ⑽
    41678us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(-16y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-64y)
        Displacement(8y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        Displacement(0y,64y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-48y,-8y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ⑾
    41679us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-16y,-16y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-79y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,79y)
        Displacement(-8y,-8y)
    ]
    // ⑿
    41680us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-56y,-16y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(40y,8y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-32y,0y)
        Displacement(32y,56y)
        Displacement(0y,16y)
        Displacement(-8y,8y)
        Displacement(-16y,0y)
        Displacement(-8y,-16y)
        Displacement(0y,-8y)
    ]
    // ⒀
    41681us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-40y,-24y)
        PenDown
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-24y,-16y)
        Displacement(24y,-8y)
        Displacement(0y,-24y)
        Displacement(-8y,-8y)
        Displacement(-16y,0y)
        Displacement(-8y,8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,79y)
        Displacement(-8y,-8y)
    ]
    // ⒁
    41682us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(-32y,-56y)
        Displacement(48y,0y)
        PenUp
        Displacement(-8y,-24y)
        PenDown
        Displacement(-16y,0y)
        Displacement(8y,0y)
        Displacement(0y,79y)
        PenUp
        Displacement(-48y,-8y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-79y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-16y,0y)
    ]
    // ⒂
    41683us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(8y,-24y)
        PenDown
        Displacement(0y,8y)
        Displacement(-40y,0y)
        Displacement(0y,-32y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-24y)
        Displacement(-8y,-16y)
        Displacement(-24y,0y)
        Displacement(-8y,16y)
        Displacement(0y,8y)
        PenUp
        Displacement(-8y,-24y)
        PenDown
        Displacement(-16y,0y)
        Displacement(8y,0y)
        Displacement(0y,79y)
        Displacement(-8y,-8y)
    ]
    // ⒃
    41684us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(0y,-24y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,8y)
        Displacement(-16y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-64y)
        Displacement(8y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        Displacement(0y,32y)
        Displacement(-8y,8y)
        Displacement(-8y,0y)
        Displacement(-16y,-8y)
        PenUp
        Displacement(-8y,-40y)
        PenDown
        Displacement(-16y,0y)
        Displacement(8y,0y)
        Displacement(0y,79y)
        Displacement(-8y,-8y)
    ]
    // ⒄
    41685us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-32y,-24y)
        PenDown
        Displacement(0y,8y)
        Displacement(32y,0y)
        Displacement(-24y,-56y)
        Displacement(0y,-16y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-16y,0y)
        Displacement(8y,0y)
        Displacement(0y,79y)
        Displacement(-8y,-8y)
    ]
    // ⒅
    41686us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(-16y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-24y)
        Displacement(32y,-16y)
        Displacement(0y,-24y)
        Displacement(-8y,-8y)
        Displacement(-16y,0y)
        Displacement(-8y,8y)
        Displacement(0y,24y)
        Displacement(32y,16y)
        Displacement(0y,24y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-48y,-8y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ⒆
    41687us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-64y)
        Displacement(16y,-16y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(-16y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-24y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
        Displacement(0y,32y)
        Displacement(-8y,8y)
        PenUp
        Displacement(8y,-16y)
        PenDown
        Displacement(0y,-56y)
        Displacement(-8y,-8y)
        Displacement(-16y,0y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        PenUp
        Displacement(-8y,-16y)
        PenDown
        Displacement(-16y,0y)
        Displacement(8y,0y)
        Displacement(0y,79y)
        Displacement(-8y,-8y)
    ]
    // ⒇
    41688us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(-16y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-64y)
        Displacement(8y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        Displacement(0y,64y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-64y,-8y)
        PenDown
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-24y)
        Displacement(-32y,-48y)
        Displacement(32y,0y)
        Displacement(0y,8y)
    ]
    // ①
    41689us, [
        PenUp
        Displacement(0y,48y)
        PenDown
        Displacement(16y,-24y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(32y,0y)
        Displacement(16y,8y)
        Displacement(16y,16y)
        Displacement(8y,16y)
        Displacement(0y,32y)
        Displacement(-8y,16y)
        Displacement(-16y,16y)
        Displacement(-16y,8y)
        Displacement(-32y,0y)
        Displacement(-24y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(0y,-24y)
        PenUp
        Displacement(56y,-16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,71y)
        Displacement(-8y,-8y)
    ]
    // ②
    41690us, [
        PenUp
        Displacement(8y,79y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-24y)
        Displacement(24y,-16y)
        Displacement(24y,0y)
        Displacement(24y,16y)
        Displacement(16y,24y)
        Displacement(0y,32y)
        Displacement(-16y,24y)
        Displacement(-24y,16y)
        Displacement(-24y,0y)
        Displacement(-24y,-16y)
        Displacement(-16y,-24y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-48y,-40y)
        Displacement(48y,0y)
        Displacement(0y,8y)
    ]
    // ③
    41691us, [
        PenUp
        Displacement(16y,95y)
        PenDown
        Displacement(-8y,-16y)
        Displacement(0y,-32y)
        Displacement(16y,-24y)
        Displacement(24y,-16y)
        Displacement(32y,0y)
        Displacement(24y,16y)
        Displacement(8y,24y)
        Displacement(0y,32y)
        Displacement(-16y,24y)
        Displacement(-16y,16y)
        Displacement(-32y,0y)
        Displacement(-24y,-16y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(24y,-16y)
        PenDown
        Displacement(0y,8y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-8y)
        Displacement(-24y,-16y)
        Displacement(24y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,8y)
    ]
    // ④
    41692us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-32y)
        Displacement(16y,-24y)
        Displacement(24y,-16y)
        Displacement(24y,0y)
        Displacement(24y,16y)
        Displacement(16y,24y)
        Displacement(0y,32y)
        Displacement(-16y,24y)
        Displacement(-32y,16y)
        Displacement(-16y,0y)
        Displacement(-24y,-16y)
        PenUp
        Displacement(48y,0y)
        PenDown
        Displacement(-40y,-56y)
        Displacement(56y,0y)
        PenUp
        Displacement(-8y,-24y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,79y)
    ]
    // ⑤
    41693us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-32y)
        Displacement(16y,-24y)
        Displacement(24y,-16y)
        Displacement(24y,0y)
        Displacement(24y,16y)
        Displacement(16y,24y)
        Displacement(0y,32y)
        Displacement(-16y,24y)
        Displacement(-24y,16y)
        Displacement(-24y,0y)
        Displacement(-24y,-16y)
        PenUp
        Displacement(64y,-16y)
        PenDown
        Displacement(0y,8y)
        Displacement(-48y,0y)
        Displacement(0y,-40y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
    ]
    // ⑥
    41694us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-32y)
        Displacement(16y,-24y)
        Displacement(24y,-16y)
        Displacement(24y,0y)
        Displacement(24y,16y)
        Displacement(16y,24y)
        Displacement(0y,32y)
        Displacement(-8y,16y)
        Displacement(-32y,24y)
        Displacement(-24y,0y)
        Displacement(-24y,-16y)
        PenUp
        Displacement(64y,-16y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,8y)
        Displacement(-24y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-48y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-8y,0y)
        Displacement(-8y,0y)
        Displacement(-16y,-8y)
    ]
    // ⑦
    41695us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-32y)
        Displacement(16y,-24y)
        Displacement(24y,-16y)
        Displacement(24y,0y)
        Displacement(24y,16y)
        Displacement(16y,24y)
        Displacement(0y,32y)
        Displacement(-8y,16y)
        Displacement(-24y,24y)
        Displacement(-32y,0y)
        Displacement(-24y,-16y)
        PenUp
        Displacement(16y,-16y)
        PenDown
        Displacement(0y,8y)
        Displacement(48y,0y)
        Displacement(-32y,-56y)
        Displacement(0y,-16y)
    ]
    // ⑧
    41696us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-32y)
        Displacement(16y,-24y)
        Displacement(24y,-16y)
        Displacement(24y,0y)
        Displacement(24y,16y)
        Displacement(16y,24y)
        Displacement(0y,32y)
        Displacement(-16y,24y)
        Displacement(-24y,16y)
        Displacement(-24y,0y)
        Displacement(-24y,-16y)
        PenUp
        Displacement(16y,-16y)
        PenDown
        Displacement(0y,-8y)
        Displacement(48y,-32y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,8y)
        Displacement(48y,32y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-8y)
    ]
    // ⑨
    41697us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-32y)
        Displacement(16y,-24y)
        Displacement(24y,-16y)
        Displacement(24y,0y)
        Displacement(24y,16y)
        Displacement(16y,24y)
        Displacement(0y,32y)
        Displacement(-16y,24y)
        Displacement(-24y,16y)
        Displacement(-24y,0y)
        Displacement(-24y,-16y)
        PenUp
        Displacement(16y,-64y)
        PenDown
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,40y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(24y,8y)
    ]
    // ⑩
    41698us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-32y)
        Displacement(16y,-24y)
        Displacement(24y,-16y)
        Displacement(24y,0y)
        Displacement(24y,16y)
        Displacement(16y,24y)
        Displacement(0y,32y)
        Displacement(-16y,24y)
        Displacement(-24y,16y)
        Displacement(-24y,0y)
        Displacement(-24y,-16y)
        PenUp
        Displacement(16y,-8y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-71y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(-8y,8y)
        Displacement(0y,56y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-56y)
        Displacement(-8y,-8y)
        Displacement(-16y,0y)
    ]
    // ㈠
    41701us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(0y,-48y)
        PenDown
        Displacement(-64y,0y)
    ]
    // ㈡
    41702us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-24y)
        PenDown
        Displacement(-48y,0y)
        PenUp
        Displacement(-8y,-56y)
        PenDown
        Displacement(64y,0y)
    ]
    // ㈢
    41703us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-16y)
        PenDown
        Displacement(-48y,0y)
        PenUp
        Displacement(8y,-32y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(16y,-32y)
        PenDown
        Displacement(-64y,0y)
    ]
    // ㈣
    41704us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(0y,-24y)
        PenDown
        Displacement(-64y,0y)
        Displacement(0y,-56y)
        Displacement(64y,0y)
        Displacement(0y,56y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(0y,-40y)
        Displacement(24y,0y)
        PenUp
        Displacement(-64y,0y)
        PenDown
        Displacement(24y,8y)
        Displacement(0y,32y)
    ]
    // ㈤
    41705us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-8y,-16y)
        PenDown
        Displacement(-48y,0y)
        PenUp
        Displacement(0y,-24y)
        PenDown
        Displacement(40y,0y)
        Displacement(0y,-40y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(-64y,0y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(0y,64y)
    ]
    // ㈥
    41706us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(0y,-24y)
        PenDown
        Displacement(-64y,0y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(8y,-16y)
        PenUp
        Displacement(8y,-24y)
        PenDown
        Displacement(16y,-48y)
        PenUp
        Displacement(-48y,0y)
        PenDown
        Displacement(8y,40y)
    ]
    // ㈦
    41707us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(0y,-32y)
        PenDown
        Displacement(-64y,-16y)
        PenUp
        Displacement(24y,40y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
        Displacement(8y,8y)
    ]
    // ㈧
    41708us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-24y,-8y)
        PenDown
        Displacement(24y,-79y)
        PenUp
        Displacement(-71y,0y)
        PenDown
        Displacement(16y,16y)
        Displacement(8y,32y)
        Displacement(0y,24y)
    ]
    // ㈨
    41709us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(-40y,0y)
        PenDown
        Displacement(0y,-64y)
        Displacement(-24y,-24y)
        PenUp
        Displacement(8y,64y)
        PenDown
        Displacement(48y,0y)
        Displacement(-16y,-64y)
        Displacement(24y,0y)
        Displacement(0y,8y)
    ]
    // ㈩
    41710us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-16y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-24y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(16y,24y)
        Displacement(0y,56y)
        Displacement(-16y,24y)
        PenUp
        Displacement(0y,-48y)
        PenDown
        Displacement(-64y,0y)
        PenUp
        Displacement(32y,40y)
        PenDown
        Displacement(0y,-87y)
    ]
    // Ⅰ
    41713us, [
        PenUp
        Displacement(40y,127y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(32y,0y)
    ]
    // Ⅱ
    41714us, [
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅲ
    41715us, [
        PenUp
        Displacement(16y,127y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅳ
    41716us, [
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(24y,-127y)
        Displacement(24y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅴ
    41717us, [
        PenUp
        Displacement(16y,127y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(32y,-127y)
        Displacement(32y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅵ
    41718us, [
        PenUp
        Displacement(8y,127y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(24y,-127y)
        Displacement(24y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅶ
    41719us, [
        PenUp
        Displacement(0y,127y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(24y,-127y)
        Displacement(24y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅷ
    41720us, [
        PenUp
        Displacement(0y,127y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,-127y)
        Displacement(16y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅸ
    41721us, [
        PenUp
        Displacement(8y,127y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(48y,127y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(48y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅹ
    41722us, [
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(64y,127y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(-48y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(64y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅺ
    41723us, [
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(48y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-48y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ⅻ
    41724us, [
        PenUp
        Displacement(0y,127y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(40y,-127y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(40y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,127y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ！
    41889us, [
        PenUp
        Displacement(30y,32y)
        PenDown
        OctantArc(5uy,0x20y)
        PenUp
        Displacement(0y,12y)
        PenDown
        Displacement(0y,76y)
    ]
    // ＂
    41890us, [
        PenUp
        Displacement(48y,87y)
        PenDown
        Displacement(0y,-56y)
        Displacement(8y,56y)
        Displacement(-8y,0y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(0y,-56y)
        Displacement(8y,56y)
        Displacement(-8y,0y)
    ]
    // ＃
    41891us, [
        PenUp
        Displacement(32y,79y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(0y,-32y)
        PenDown
        Displacement(-64y,0y)
        PenUp
        Displacement(16y,-32y)
        PenDown
        Displacement(0y,87y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(0y,-87y)
    ]
    // ￥
    41892us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,0y)
        Displacement(32y,-32y)
        Displacement(32y,32y)
        Displacement(8y,0y)
        PenUp
        Displacement(-40y,-32y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(16y,48y)
        PenDown
        Displacement(-48y,0y)
    ]
    // ％
    41893us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,0y)
        Displacement(8y,8y)
        Displacement(0y,8y)
        Displacement(-8y,8y)
        Displacement(-8y,0y)
        PenUp
        Displacement(56y,-56y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,0y)
        Displacement(8y,8y)
        Displacement(0y,8y)
        Displacement(-8y,8y)
        Displacement(-8y,0y)
        PenUp
        Displacement(-64y,-24y)
        PenDown
        Displacement(79y,79y)
    ]
    // ＆
    41894us, [
        PenUp
        Displacement(111y,16y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
        Displacement(-32y,40y)
        Displacement(-16y,32y)
        Displacement(8y,16y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-64y,-48y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,0y)
        Displacement(32y,24y)
        Displacement(24y,24y)
        Displacement(-8y,0y)
    ]
    // ＇
    41895us, [
        PenUp
        Displacement(79y,103y)
        PenDown
        Displacement(-24y,-48y)
        Displacement(32y,40y)
        Displacement(-8y,8y)
        PenUp
        Displacement(0y,-8y)
        PenDown
        Displacement(8y,0y)
        Displacement(-8y,8y)
        Displacement(0y,-8y)
        Displacement(-24y,-40y)
    ]
    // （
    41896us, [
        PenUp
        Displacement(95y,127y)
        PenDown
        BulgeArc(0y,-127y,64y)
    ]
    // ）
    41897us, [
        PenUp
        Displacement(32y,0y)
        PenDown
        BulgeArc(0y,127y,64y)
    ]
    // ＊
    41898us, [
        PenUp
        Displacement(8y,79y)
        PenDown
        Displacement(48y,-16y)
        Displacement(48y,16y)
        PenUp
        Displacement(-48y,32y)
        PenDown
        Displacement(0y,-48y)
        Displacement(-32y,-40y)
        PenUp
        Displacement(32y,40y)
        PenDown
        Displacement(32y,-40y)
    ]
    // ＋
    41899us, [
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(111y,0y)
        PenUp
        Displacement(-56y,48y)
        PenDown
        Displacement(0y,-95y)
    ]
    // ，
    41900us, [
        PenUp
        Displacement(21y,0y)
        PenDown
        BulgeArc(15y,18y,42y)
        Displacement(0y,10y)
        OctantArc(6uy,0x0y)
    ]
    // －
    41901us, [
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(111y,0y)
    ]
    // ．
    41902us, [
        PenUp
        Displacement(24y,32y)
        PenDown
        Displacement(8y,-16y)
        Displacement(-16y,0y)
        Displacement(8y,16y)
    ]
    // ／
    41903us, [
        PenUp
        Displacement(87y,127y)
        PenDown
        Displacement(-64y,-127y)
    ]
    // ０
    41904us, [
        PenUp
        Displacement(16y,32y)
        PenDown
        Displacement(24y,-24y)
        Displacement(32y,0y)
        Displacement(24y,24y)
        Displacement(0y,64y)
        Displacement(-24y,24y)
        Displacement(-32y,0y)
        Displacement(-24y,-24y)
        Displacement(0y,-64y)
    ]
    // １
    41905us, [
        PenUp
        Displacement(56y,119y)
        PenDown
        Displacement(0y,-111y)
    ]
    // ２
    41906us, [
        PenUp
        Displacement(16y,71y)
        PenDown
        Displacement(0y,32y)
        Displacement(16y,16y)
        Displacement(48y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-32y)
        Displacement(-24y,-24y)
        Displacement(-48y,-24y)
        Displacement(-16y,-16y)
        Displacement(95y,0y)
    ]
    // ３
    41907us, [
        PenUp
        Displacement(16y,119y)
        PenDown
        Displacement(79y,0y)
        Displacement(-40y,-40y)
        Displacement(16y,0y)
        Displacement(24y,-24y)
        Displacement(0y,-24y)
        Displacement(-24y,-24y)
        Displacement(-32y,0y)
        Displacement(-24y,24y)
        Displacement(0y,16y)
    ]
    // ４
    41908us, [
        PenUp
        Displacement(71y,8y)
        PenDown
        Displacement(0y,111y)
        Displacement(-64y,-79y)
        Displacement(95y,0y)
    ]
    // ５
    41909us, [
        PenUp
        Displacement(16y,32y)
        PenDown
        Displacement(0y,-8y)
        Displacement(16y,-16y)
        Displacement(48y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(-16y,16y)
        Displacement(-48y,0y)
        Displacement(-16y,-8y)
        Displacement(0y,56y)
        Displacement(79y,0y)
    ]
    // ６
    41910us, [
        PenUp
        Displacement(95y,119y)
        PenDown
        Displacement(-32y,-8y)
        Displacement(-32y,-24y)
        Displacement(-16y,-24y)
        Displacement(0y,-40y)
        Displacement(16y,-16y)
        Displacement(48y,0y)
        Displacement(16y,16y)
        Displacement(0y,24y)
        Displacement(-16y,16y)
        Displacement(-48y,0y)
        Displacement(-16y,-16y)
    ]
    // ７
    41911us, [
        PenUp
        Displacement(16y,119y)
        PenDown
        Displacement(79y,0y)
        Displacement(-40y,-64y)
        Displacement(-24y,-48y)
    ]
    // ８
    41912us, [
        PenUp
        Displacement(71y,71y)
        PenDown
        Displacement(16y,8y)
        Displacement(8y,16y)
        Displacement(-8y,16y)
        Displacement(-16y,8y)
        Displacement(-32y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-16y)
        Displacement(8y,-16y)
        Displacement(16y,-8y)
        Displacement(32y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-16y,-8y)
        Displacement(-32y,0y)
        Displacement(-16y,8y)
        Displacement(-8y,16y)
        Displacement(0y,8y)
        Displacement(8y,16y)
        Displacement(16y,8y)
        Displacement(32y,8y)
    ]
    // ９
    41913us, [
        PenUp
        Displacement(95y,71y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(-48y,0y)
        Displacement(-16y,16y)
        Displacement(0y,32y)
        Displacement(16y,16y)
        Displacement(48y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-32y)
        Displacement(-16y,-32y)
        Displacement(-48y,-40y)
    ]
    // ：
    41914us, [
        PenUp
        Displacement(30y,32y)
        PenDown
        OctantArc(6uy,0x20y)
        PenUp
        Displacement(0y,59y)
        PenDown
        OctantArc(6uy,0x20y)
    ]
    // ；
    41915us, [
        PenUp
        Displacement(21y,0y)
        PenDown
        BulgeArc(15y,18y,42y)
        Displacement(0y,10y)
        OctantArc(6uy,0x0y)
        PenUp
        Displacement(0y,57y)
        PenDown
        OctantArc(6uy,0x0y)
    ]
    // ＜
    41916us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-111y,-48y)
        Displacement(111y,-48y)
    ]
    // ＝
    41917us, [
        PenUp
        Displacement(0y,79y)
        PenDown
        Displacement(111y,0y)
        PenUp
        Displacement(0y,-40y)
        PenDown
        Displacement(-111y,0y)
    ]
    // ＞
    41918us, [
        PenUp
        Displacement(0y,111y)
        PenDown
        Displacement(111y,-48y)
        Displacement(-111y,-48y)
    ]
    // ？
    41919us, [
        PenUp
        Displacement(29y,30y)
        PenDown
        OctantArc(5uy,0x20y)
        PenUp
        Displacement(0y,14y)
        PenDown
        Displacement(0y,5y)
        BulgeArc(5y,14y,-23y)
        Displacement(15y,17y)
        BulgeArc(5y,25y,44y)
        BulgeArc(-46y,3y,58y)
        BulgeArc(-5y,-11y,23y)
    ]
    // ＠
    41920us, [
        PenUp
        Displacement(71y,56y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,24y)
        Displacement(16y,16y)
        Displacement(32y,0y)
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(-32y,32y)
        Displacement(-48y,0y)
        Displacement(-32y,-32y)
        Displacement(0y,-40y)
        Displacement(32y,-32y)
        Displacement(48y,0y)
        Displacement(24y,16y)
    ]
    // Ａ
    41921us, [
        PenDown
        Displacement(56y,127y)
        Displacement(56y,-127y)
        PenUp
        Displacement(-16y,32y)
        PenDown
        Displacement(-79y,0y)
    ]
    // Ｂ
    41922us, [
        PenUp
        Displacement(79y,64y)
        PenDown
        Displacement(24y,16y)
        Displacement(0y,32y)
        Displacement(-24y,16y)
        Displacement(-71y,0y)
        Displacement(0y,-127y)
        Displacement(71y,0y)
        Displacement(32y,16y)
        Displacement(0y,32y)
        Displacement(-32y,16y)
        Displacement(-71y,0y)
    ]
    // Ｃ
    41923us, [
        PenUp
        Displacement(111y,127y)
        PenDown
        Displacement(-71y,0y)
        Displacement(-32y,-32y)
        Displacement(0y,-64y)
        Displacement(32y,-32y)
        Displacement(71y,0y)
    ]
    // Ｄ
    41924us, [
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,127y)
        Displacement(71y,0y)
        Displacement(32y,-32y)
        Displacement(0y,-64y)
        Displacement(-32y,-32y)
        Displacement(-71y,0y)
    ]
    // Ｅ
    41925us, [
        PenUp
        Displacement(111y,127y)
        PenDown
        Displacement(-103y,0y)
        Displacement(0y,-127y)
        Displacement(103y,0y)
        PenUp
        Displacement(-24y,64y)
        PenDown
        Displacement(-79y,0y)
    ]
    // Ｆ
    41926us, [
        PenUp
        Displacement(111y,127y)
        PenDown
        Displacement(-103y,0y)
        Displacement(0y,-127y)
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(79y,0y)
    ]
    // Ｇ
    41927us, [
        PenUp
        Displacement(111y,127y)
        PenDown
        Displacement(-79y,0y)
        Displacement(-24y,-24y)
        Displacement(0y,-79y)
        Displacement(24y,-24y)
        Displacement(79y,0y)
        Displacement(0y,64y)
        Displacement(-32y,0y)
    ]
    // Ｈ
    41928us, [
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,127y)
        PenUp
        Displacement(103y,0y)
        PenDown
        Displacement(0y,-127y)
        PenUp
        Displacement(-103y,64y)
        PenDown
        Displacement(103y,0y)
    ]
    // Ｉ
    41929us, [
        PenUp
        Displacement(56y,127y)
        PenDown
        Displacement(0y,-127y)
    ]
    // Ｊ
    41930us, [
        PenUp
        Displacement(71y,127y)
        PenDown
        Displacement(0y,-103y)
        Displacement(-24y,-24y)
        Displacement(-32y,0y)
    ]
    // Ｋ
    41931us, [
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,127y)
        PenUp
        Displacement(103y,0y)
        PenDown
        Displacement(-103y,-64y)
        PenUp
        Displacement(16y,8y)
        PenDown
        Displacement(87y,-71y)
    ]
    // Ｌ
    41932us, [
        PenUp
        Displacement(16y,127y)
        PenDown
        Displacement(0y,-127y)
        Displacement(95y,0y)
    ]
    // Ｍ
    41933us, [
        PenDown
        Displacement(0y,127y)
        Displacement(56y,-56y)
        Displacement(56y,56y)
        Displacement(0y,-127y)
    ]
    // Ｎ
    41934us, [
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,127y)
        Displacement(103y,-127y)
        Displacement(0y,127y)
    ]
    // Ｏ
    41935us, [
        PenUp
        Displacement(8y,103y)
        PenDown
        Displacement(0y,-79y)
        Displacement(24y,-24y)
        Displacement(56y,0y)
        Displacement(24y,24y)
        Displacement(0y,79y)
        Displacement(-24y,24y)
        Displacement(-56y,0y)
        Displacement(-24y,-24y)
    ]
    // Ｐ
    41936us, [
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,127y)
        Displacement(71y,0y)
        Displacement(32y,-24y)
        Displacement(0y,-32y)
        Displacement(-32y,-16y)
        Displacement(-71y,0y)
    ]
    // Ｑ
    41937us, [
        PenUp
        Displacement(8y,103y)
        PenDown
        Displacement(0y,-79y)
        Displacement(24y,-24y)
        Displacement(56y,0y)
        Displacement(24y,24y)
        Displacement(0y,79y)
        Displacement(-24y,24y)
        Displacement(-56y,0y)
        Displacement(-24y,-24y)
        PenUp
        Displacement(56y,-64y)
        PenDown
        Displacement(48y,-40y)
    ]
    // Ｒ
    41938us, [
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,127y)
        Displacement(79y,0y)
        Displacement(24y,-16y)
        Displacement(0y,-32y)
        Displacement(-24y,-16y)
        Displacement(-79y,0y)
        PenUp
        Displacement(48y,0y)
        PenDown
        Displacement(56y,-64y)
    ]
    // Ｓ
    41939us, [
        PenUp
        Displacement(8y,16y)
        PenDown
        Displacement(24y,-16y)
        Displacement(56y,0y)
        Displacement(24y,16y)
        Displacement(0y,24y)
        Displacement(-24y,16y)
        Displacement(-56y,16y)
        Displacement(-24y,16y)
        Displacement(0y,24y)
        Displacement(24y,16y)
        Displacement(56y,0y)
        Displacement(24y,-16y)
    ]
    // Ｔ
    41940us, [
        PenUp
        Displacement(0y,127y)
        PenDown
        Displacement(111y,0y)
        PenUp
        Displacement(-56y,0y)
        PenDown
        Displacement(0y,-127y)
    ]
    // Ｕ
    41941us, [
        PenUp
        Displacement(8y,127y)
        PenDown
        Displacement(0y,-95y)
        Displacement(24y,-32y)
        Displacement(56y,0y)
        Displacement(24y,32y)
        Displacement(0y,95y)
    ]
    // Ｖ
    41942us, [
        PenUp
        Displacement(0y,127y)
        PenDown
        Displacement(56y,-127y)
        Displacement(56y,127y)
    ]
    // Ｗ
    41943us, [
        PenUp
        Displacement(0y,127y)
        PenDown
        Displacement(24y,-127y)
        Displacement(32y,64y)
        Displacement(32y,-64y)
        Displacement(24y,127y)
    ]
    // Ｘ
    41944us, [
        PenUp
        Displacement(0y,127y)
        PenDown
        Displacement(111y,-127y)
        PenUp
        Displacement(-111y,0y)
        PenDown
        Displacement(111y,127y)
    ]
    // Ｙ
    41945us, [
        PenUp
        Displacement(0y,127y)
        PenDown
        Displacement(56y,-48y)
        PenUp
        Displacement(56y,48y)
        PenDown
        Displacement(-56y,-48y)
        Displacement(0y,-79y)
    ]
    // Ｚ
    41946us, [
        PenUp
        Displacement(8y,127y)
        PenDown
        Displacement(95y,0y)
        Displacement(-103y,-127y)
        Displacement(111y,0y)
    ]
    // ［
    41947us, [
        PenUp
        Displacement(95y,111y)
        PenDown
        Displacement(-56y,0y)
        Displacement(0y,-103y)
        Displacement(56y,0y)
    ]
    // ＼
    41948us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(87y,-87y)
    ]
    // ］
    41949us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(56y,0y)
        Displacement(0y,-103y)
        Displacement(-56y,0y)
    ]
    // ＾
    41950us, [
        PenUp
        Displacement(64y,119y)
        PenDown
        Displacement(-32y,-56y)
        PenUp
        Displacement(64y,0y)
        PenDown
        Displacement(-32y,56y)
    ]
    // ＿
    41951us, [
        PenUp
        Displacement(32y,40y)
        PenDown
        Displacement(64y,0y)
    ]
    // ｀
    41952us, [
        PenUp
        Displacement(56y,119y)
        PenDown
        Displacement(16y,-48y)
        Displacement(-24y,40y)
        Displacement(8y,8y)
        PenUp
        Displacement(0y,-8y)
        PenDown
        Displacement(16y,-40y)
        Displacement(-16y,32y)
        Displacement(-8y,8y)
        Displacement(8y,0y)
        Displacement(0y,8y)
    ]
    // ａ
    41953us, [
        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(0y,8y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(8y,8y)
        Displacement(0y,8y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,8y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
    ]
    // ｂ
    41954us, [
        PenUp
        Displacement(48y,103y)
        PenDown
        Displacement(0y,-79y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-8y)
    ]
    // ｃ
    41955us, [
        PenUp
        Displacement(87y,79y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,8y)
        Displacement(-24y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        Displacement(0y,8y)
    ]
    // ｄ
    41956us, [
        PenUp
        Displacement(71y,103y)
        PenDown
        Displacement(0y,-71y)
        Displacement(-8y,-8y)
        Displacement(-16y,0y)
        Displacement(-8y,16y)
        Displacement(0y,16y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(0y,-24y)
        Displacement(8y,-8y)
    ]
    // ｅ
    41957us, [
        PenUp
        Displacement(40y,64y)
        PenDown
        Displacement(56y,0y)
        Displacement(0y,8y)
        Displacement(-8y,16y)
        Displacement(-32y,0y)
        Displacement(-16y,-24y)
        Displacement(0y,-16y)
        Displacement(8y,-16y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        Displacement(0y,8y)
    ]
    // ｆ
    41958us, [
        PenUp
        Displacement(40y,71y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(0y,24y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        PenUp
        Displacement(-16y,-71y)
        PenDown
        Displacement(-16y,0y)
        Displacement(8y,0y)
        Displacement(0y,71y)
    ]
    // ｇ
    41959us, [
        PenUp
        Displacement(79y,95y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(-16y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        Displacement(0y,16y)
        PenUp
        Displacement(-24y,-24y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,0y)
        Displacement(-16y,8y)
        Displacement(0y,16y)
        Displacement(8y,8y)
    ]
    // ｈ
    41960us, [
        PenUp
        Displacement(48y,103y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(0y,32y)
        PenDown
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(0y,-48y)
    ]
    // ｉ
    41961us, [
        PenUp
        Displacement(56y,95y)
        PenDown
        Displacement(8y,-8y)
        PenUp
        Displacement(-16y,-16y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-56y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ｊ
    41962us, [
        PenUp
        Displacement(56y,103y)
        PenDown
        Displacement(0y,8y)
        PenUp
        Displacement(-16y,-24y)
        PenDown
        Displacement(16y,0y)
        Displacement(0y,-64y)
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
    ]
    // ｋ
    41963us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(8y,0y)
        Displacement(-40y,40y)
        Displacement(40y,24y)
        Displacement(-8y,0y)
    ]
    // ｌ
    41964us, [
        PenUp
        Displacement(56y,95y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ｍ
    41965us, [
        PenUp
        Displacement(32y,24y)
        PenDown
        Displacement(0y,64y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-64y)
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-64y)
    ]
    // ｎ
    41966us, [
        PenUp
        Displacement(40y,24y)
        PenDown
        Displacement(0y,56y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,8y)
        Displacement(24y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-56y)
        Displacement(-8y,0y)
        Displacement(16y,0y)
        PenUp
        Displacement(-40y,0y)
        PenDown
        Displacement(-16y,0y)
    ]
    // ｏ
    41967us, [
        PenUp
        Displacement(71y,32y)
        PenDown
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,32y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-32y)
        Displacement(-16y,-16y)
    ]
    // ｐ
    41968us, [
        PenUp
        Displacement(48y,16y)
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,71y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-24y)
        Displacement(-16y,-8y)
        Displacement(-16y,0y)
        Displacement(-8y,8y)
    ]
    // ｑ
    41969us, [
        PenUp
        Displacement(87y,16y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,79y)
        Displacement(-16y,8y)
        Displacement(-8y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-24y)
        Displacement(16y,-16y)
        Displacement(8y,0y)
        Displacement(16y,8y)
    ]
    // ｒ
    41970us, [
        PenUp
        Displacement(48y,79y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,48y)
        PenDown
        Displacement(8y,8y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
    ]
    // ｓ
    41971us, [
        PenUp
        Displacement(87y,79y)
        PenDown
        Displacement(0y,16y)
        Displacement(0y,-16y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-8y)
        Displacement(16y,-8y)
        Displacement(32y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
    ]
    // ｔ
    41972us, [
        PenUp
        Displacement(40y,71y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(-24y,24y)
        PenDown
        Displacement(0y,-71y)
        Displacement(24y,8y)
    ]
    // ｕ
    41973us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-64y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
        Displacement(8y,8y)
        Displacement(0y,64y)
        PenUp
        Displacement(0y,-64y)
        PenDown
        Displacement(8y,-8y)
        Displacement(8y,0y)
    ]
    // ｖ
    41974us, [
        PenUp
        Displacement(95y,87y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-24y,-64y)
        Displacement(-24y,64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ｗ
    41975us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(24y,-64y)
        Displacement(24y,64y)
        Displacement(16y,-64y)
        Displacement(24y,64y)
    ]
    // ｘ
    41976us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-16y)
        Displacement(48y,-40y)
        Displacement(0y,-16y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(0y,71y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-48y,-40y)
        Displacement(0y,-16y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ｙ
    41977us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(24y,-48y)
        PenUp
        Displacement(24y,48y)
        PenDown
        Displacement(-8y,-32y)
        Displacement(-48y,-48y)
    ]
    // ｚ
    41978us, [
        PenUp
        Displacement(40y,79y)
        PenDown
        Displacement(0y,8y)
        Displacement(48y,0y)
        Displacement(0y,-8y)
        Displacement(-48y,-40y)
        Displacement(0y,-8y)
        Displacement(48y,0y)
        Displacement(0y,8y)
    ]
    // ｛
    41979us, [
        PenUp
        Displacement(71y,119y)
        PenDown
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-32y)
        Displacement(-16y,-16y)
        Displacement(16y,-16y)
        Displacement(0y,-32y)
        Displacement(8y,-8y)
        Displacement(8y,0y)
    ]
    // ｜
    41980us, [
        PenUp
        Displacement(64y,119y)
        PenDown
        Displacement(0y,-119y)
    ]
    // ｝
    41981us, [
        PenUp
        Displacement(56y,119y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(-16y,-16y)
        Displacement(0y,-32y)
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
    ]
    // ￣
    41982us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-95y,0y)
    ]
    // ぁ
    42145us, [
        PenUp
        Displacement(32y,79y)
        PenDown
        Displacement(56y,8y)
        PenUp
        Displacement(-32y,16y)
        PenDown
        Displacement(0y,-71y)
        PenUp
        Displacement(8y,24y)
        PenDown
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
        Displacement(-16y,0y)
        Displacement(0y,8y)
        Displacement(8y,8y)
        Displacement(8y,8y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
    ]
    // あ
    42146us, [
        PenUp
        Displacement(64y,111y)
        PenDown
        Displacement(-8y,-16y)
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        PenUp
        Displacement(0y,32y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(8y,8y)
        Displacement(16y,16y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        PenUp
        Displacement(-56y,79y)
        PenDown
        Displacement(71y,0y)
    ]
    // ぃ
    42147us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(24y,-16y)
        Displacement(0y,16y)
        PenUp
        Displacement(16y,48y)
        PenDown
        Displacement(16y,-24y)
    ]
    // い
    42148us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(0y,-32y)
        Displacement(8y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,-8y)
        Displacement(0y,16y)
        PenUp
        Displacement(16y,56y)
        PenDown
        Displacement(16y,-24y)
    ]
    // ぅ
    42149us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(32y,0y)
        Displacement(8y,-8y)
        Displacement(-32y,-16y)
        PenUp
        Displacement(-16y,-8y)
        PenDown
        Displacement(48y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-40y,-32y)
    ]
    // う
    42150us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(32y,0y)
        Displacement(8y,-8y)
        Displacement(-24y,-16y)
        PenUp
        Displacement(-24y,-8y)
        PenDown
        Displacement(48y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-32y,-32y)
    ]
    // ぇ
    42151us, [
        PenUp
        Displacement(48y,103y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(-16y,-8y)
        PenUp
        Displacement(-16y,-16y)
        PenDown
        Displacement(48y,0y)
        Displacement(-48y,-48y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
    ]
    // え
    42152us, [
        PenUp
        Displacement(48y,103y)
        PenDown
        Displacement(16y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(-24y,-16y)
        PenDown
        Displacement(48y,0y)
        Displacement(-56y,-56y)
        PenUp
        Displacement(32y,32y)
        PenDown
        Displacement(8y,-24y)
        Displacement(8y,-8y)
        Displacement(32y,0y)
        Displacement(0y,8y)
    ]
    // ぉ
    42153us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(24y,0y)
        PenUp
        Displacement(-16y,24y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-64y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(24y,24y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
        PenUp
        Displacement(8y,56y)
        PenDown
        Displacement(16y,-8y)
    ]
    // お
    42154us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-71y)
        Displacement(-16y,16y)
        Displacement(48y,40y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-8y,0y)
        Displacement(-16y,8y)
        PenUp
        Displacement(-8y,40y)
        PenDown
        Displacement(-32y,0y)
        PenUp
        Displacement(64y,24y)
        PenDown
        Displacement(16y,-8y)
    ]
    // か
    42155us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(16y,-8y)
        Displacement(24y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-8y,-24y)
        Displacement(-8y,-16y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-24y,-8y)
        PenDown
        Displacement(8y,16y)
        Displacement(8y,24y)
        Displacement(8y,32y)
        Displacement(-8y,16y)
        PenUp
        Displacement(48y,-16y)
        PenDown
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
    ]
    // が
    42156us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(16y,-8y)
        Displacement(24y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-24y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-24y,-8y)
        PenDown
        Displacement(8y,16y)
        Displacement(8y,16y)
        Displacement(8y,40y)
        Displacement(-8y,16y)
        PenUp
        Displacement(56y,8y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-24y)
        Displacement(-8y,-8y)
    ]
    // き
    42157us, [
        PenUp
        Displacement(32y,87y)
        PenDown
        Displacement(24y,0y)
        Displacement(32y,8y)
        PenUp
        Displacement(-40y,16y)
        PenDown
        Displacement(8y,-16y)
        Displacement(16y,-32y)
        Displacement(8y,-16y)
        Displacement(8y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,8y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        PenUp
        Displacement(-48y,56y)
        PenDown
        Displacement(24y,0y)
        Displacement(32y,8y)
    ]
    // ぎ
    42158us, [
        PenUp
        Displacement(32y,87y)
        PenDown
        Displacement(24y,0y)
        Displacement(32y,8y)
        PenUp
        Displacement(-40y,16y)
        PenDown
        Displacement(16y,-32y)
        Displacement(8y,-16y)
        Displacement(8y,-16y)
        Displacement(8y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,8y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        PenUp
        Displacement(-48y,56y)
        PenDown
        Displacement(24y,0y)
        Displacement(32y,8y)
        PenUp
        Displacement(8y,48y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // く
    42159us, [
        PenUp
        Displacement(71y,103y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-32y,-32y)
        Displacement(0y,-8y)
        Displacement(32y,-40y)
        Displacement(0y,-8y)
    ]
    // ぐ
    42160us, [
        PenUp
        Displacement(71y,103y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-32y,-32y)
        Displacement(0y,-8y)
        Displacement(32y,-48y)
        PenUp
        Displacement(16y,79y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(-16y,8y)
    ]
    // け
    42161us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-8y,-24y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
        Displacement(0y,16y)
        PenUp
        Displacement(24y,56y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-24y,24y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-56y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
    ]
    // げ
    42162us, [
        PenUp
        Displacement(16y,103y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(16y,-16y)
        Displacement(0y,24y)
        PenUp
        Displacement(24y,40y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-24y,24y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-56y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-16y,-8y)
        PenDown
        Displacement(16y,-8y)
    ]
    // こ
    42163us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(40y,0y)
        Displacement(8y,-8y)
        Displacement(-16y,-8y)
        PenUp
        Displacement(-40y,-32y)
        PenDown
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(40y,0y)
        Displacement(16y,8y)
    ]
    // ご
    42164us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(24y,0y)
        Displacement(8y,-8y)
        Displacement(-16y,-8y)
        PenUp
        Displacement(40y,16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(-56y,-40y)
        PenDown
        Displacement(8y,-16y)
        Displacement(16y,-8y)
        Displacement(32y,0y)
        Displacement(16y,8y)
    ]
    // さ
    42165us, [
        PenUp
        Displacement(32y,87y)
        PenDown
        Displacement(16y,-8y)
        Displacement(24y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(-40y,24y)
        PenDown
        Displacement(8y,-16y)
        Displacement(16y,-24y)
        Displacement(16y,-32y)
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(-24y,8y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
    ]
    // ざ
    42166us, [
        PenUp
        Displacement(32y,87y)
        PenDown
        Displacement(16y,-8y)
        Displacement(24y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(-40y,24y)
        PenDown
        Displacement(8y,-16y)
        Displacement(16y,-24y)
        Displacement(16y,-32y)
        Displacement(0y,-8y)
        Displacement(-16y,0y)
        Displacement(-16y,8y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        PenUp
        Displacement(16y,111y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-16y,-8y)
        PenDown
        Displacement(16y,-8y)
    ]
    // し
    42167us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(8y,16y)
    ]
    // じ
    42168us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(8y,16y)
        PenUp
        Displacement(-24y,64y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(-16y,8y)
    ]
    // す
    42169us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-40y,32y)
        PenDown
        Displacement(0y,-64y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
    ]
    // ず
    42170us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-40y,32y)
        PenDown
        Displacement(0y,-64y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(8y,8y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        PenUp
        Displacement(48y,111y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // せ
    42171us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-24y,24y)
        PenDown
        Displacement(0y,-56y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-16y,48y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-8y)
        Displacement(40y,0y)
    ]
    // ぜ
    42172us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-24y,24y)
        PenDown
        Displacement(0y,-56y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-16y,48y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-8y)
        Displacement(40y,0y)
        PenUp
        Displacement(0y,103y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-16y,-8y)
        PenDown
        Displacement(16y,-8y)
    ]
    // そ
    42173us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(32y,0y)
        Displacement(0y,-8y)
        Displacement(-48y,-48y)
        Displacement(64y,16y)
        Displacement(-24y,-8y)
        Displacement(-8y,-16y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
    ]
    // ぞ
    42174us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(32y,0y)
        Displacement(0y,-8y)
        Displacement(-48y,-48y)
        Displacement(64y,16y)
        Displacement(-24y,-8y)
        Displacement(-8y,-16y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
        PenUp
        Displacement(-8y,79y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(8y,8y)
        PenDown
        Displacement(-16y,8y)
    ]
    // た
    42175us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-16y,16y)
        PenDown
        Displacement(0y,-48y)
        Displacement(-8y,-24y)
        Displacement(-16y,-24y)
        PenUp
        Displacement(64y,71y)
        PenDown
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(-24y,-24y)
        PenDown
        Displacement(0y,-8y)
        Displacement(16y,-16y)
        Displacement(32y,0y)
    ]
    // だ
    42176us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-16y,16y)
        PenDown
        Displacement(0y,-56y)
        Displacement(-8y,-16y)
        Displacement(-16y,-24y)
        PenUp
        Displacement(56y,40y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        PenUp
        Displacement(-32y,79y)
        PenDown
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(-8y,-16y)
        PenUp
        Displacement(8y,32y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // ち
    42177us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(16y,-8y)
        Displacement(48y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(-40y,16y)
        PenDown
        Displacement(0y,-48y)
        Displacement(-16y,-32y)
        Displacement(16y,16y)
        Displacement(32y,0y)
        Displacement(16y,-8y)
        Displacement(0y,-8y)
        Displacement(-16y,-8y)
        Displacement(-16y,0y)
    ]
    // ぢ
    42178us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(16y,-8y)
        Displacement(32y,0y)
        Displacement(8y,8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-16y,8y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,8y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-16y,-8y)
        PenUp
        Displacement(24y,71y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // っ
    42179us, [
        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(24y,0y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-24y,0y)
    ]
    // つ
    42180us, [
        PenUp
        Displacement(16y,79y)
        PenDown
        Displacement(40y,0y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
        Displacement(-24y,0y)
    ]
    // づ
    42181us, [
        PenUp
        Displacement(16y,79y)
        PenDown
        Displacement(40y,0y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-16y,-8y)
        Displacement(-24y,-8y)
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-16y,-8y)
        PenDown
        Displacement(16y,-8y)
    ]
    // て
    42182us, [
        PenUp
        Displacement(103y,95y)
        PenDown
        Displacement(-8y,0y)
        Displacement(-64y,-16y)
        Displacement(-8y,0y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(-8y,-40y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
    ]
    // で
    42183us, [
        PenUp
        Displacement(16y,79y)
        PenDown
        Displacement(8y,0y)
        Displacement(56y,16y)
        Displacement(8y,0y)
        PenUp
        Displacement(-32y,-8y)
        PenDown
        Displacement(-8y,-48y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        PenUp
        Displacement(8y,87y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // と
    42184us, [
        PenUp
        Displacement(56y,103y)
        PenDown
        Displacement(0y,-40y)
        PenUp
        Displacement(16y,8y)
        PenDown
        Displacement(-24y,-16y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(8y,0y)
    ]
    // ど
    42185us, [
        PenUp
        Displacement(56y,103y)
        PenDown
        Displacement(0y,-40y)
        PenUp
        Displacement(16y,8y)
        PenDown
        Displacement(-32y,-24y)
        Displacement(-8y,-16y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(24y,0y)
        PenUp
        Displacement(0y,87y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // な
    42186us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-16y,16y)
        PenDown
        Displacement(0y,-40y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        PenUp
        Displacement(64y,64y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
        Displacement(-8y,8y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(24y,-8y)
        Displacement(8y,-8y)
    ]
    // に
    42187us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(0y,-24y)
        Displacement(16y,-24y)
        Displacement(0y,8y)
        Displacement(8y,16y)
        PenUp
        Displacement(16y,-16y)
        PenDown
        Displacement(16y,-8y)
        Displacement(24y,0y)
        PenUp
        Displacement(-8y,71y)
        PenDown
        Displacement(-16y,0y)
        Displacement(-16y,8y)
    ]
    // ぬ
    42188us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(0y,-24y)
        Displacement(8y,-16y)
        Displacement(24y,-24y)
        PenUp
        Displacement(-16y,71y)
        PenDown
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-24y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(8y,16y)
        Displacement(24y,16y)
        Displacement(24y,8y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
    ]
    // ね
    42189us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(0y,-95y)
        PenUp
        Displacement(-16y,71y)
        PenDown
        Displacement(24y,0y)
        Displacement(-24y,-56y)
        Displacement(24y,32y)
        Displacement(24y,16y)
        Displacement(24y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
    ]
    // の
    42190us, [
        PenUp
        Displacement(56y,87y)
        PenDown
        Displacement(-8y,-40y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
        Displacement(-8y,8y)
        Displacement(-8y,16y)
        Displacement(0y,16y)
        Displacement(16y,16y)
        Displacement(8y,8y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-16y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-24y,-24y)
    ]
    // は
    42191us, [
        PenUp
        Displacement(24y,111y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-32y)
        Displacement(-8y,-16y)
        Displacement(0y,-16y)
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(0y,24y)
        PenUp
        Displacement(16y,64y)
        PenDown
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(-24y,16y)
        PenDown
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(8y,-8y)
    ]
    // ば
    42192us, [
        PenUp
        Displacement(24y,111y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-32y)
        Displacement(-8y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-24y)
        Displacement(0y,16y)
        PenUp
        Displacement(16y,71y)
        PenDown
        Displacement(16y,-8y)
        Displacement(24y,0y)
        PenUp
        Displacement(-16y,24y)
        PenDown
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(8y,-8y)
        PenUp
        Displacement(-8y,87y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // ぱ
    42193us, [
        PenUp
        Displacement(24y,111y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-32y)
        Displacement(-8y,-16y)
        Displacement(0y,-24y)
        Displacement(16y,-16y)
        Displacement(0y,24y)
        PenUp
        Displacement(16y,64y)
        PenDown
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(-24y,16y)
        PenDown
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(8y,-8y)
        PenUp
        Displacement(-8y,95y)
        PenDown
        Displacement(8y,8y)
        Displacement(8y,-8y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
    ]
    // ひ
    42194us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(-8y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(0y,-16y)
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(8y,8y)
        Displacement(8y,16y)
        Displacement(0y,8y)
        Displacement(-8y,16y)
        Displacement(0y,40y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
    ]
    // び
    42195us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(-8y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-24y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(8y,8y)
        Displacement(8y,16y)
        Displacement(0y,8y)
        Displacement(-8y,16y)
        Displacement(0y,40y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
        PenUp
        Displacement(-16y,56y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // ぴ
    42196us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(-8y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-24y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(8y,8y)
        Displacement(8y,16y)
        Displacement(0y,8y)
        Displacement(-8y,16y)
        Displacement(0y,40y)
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(16y,-16y)
        PenUp
        Displacement(-8y,48y)
        PenDown
        Displacement(8y,-8y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(8y,8y)
    ]
    // ふ
    42197us, [
        PenUp
        Displacement(48y,95y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(-16y,-16y)
        Displacement(16y,-16y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(-8y,8y)
        Displacement(-16y,0y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        Displacement(8y,0y)
        Displacement(16y,16y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-16y)
    ]
    // ぶ
    42198us, [
        PenUp
        Displacement(48y,95y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(-16y,-16y)
        Displacement(16y,-16y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        Displacement(8y,0y)
        Displacement(8y,8y)
        Displacement(8y,8y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-16y)
        PenUp
        Displacement(-16y,87y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // ぷ
    42199us, [
        PenUp
        Displacement(48y,95y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(-16y,-16y)
        Displacement(16y,-16y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,16y)
        Displacement(-24y,0y)
        Displacement(-8y,-8y)
        Displacement(8y,0y)
        Displacement(16y,16y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-16y)
        PenUp
        Displacement(-8y,79y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,8y)
        Displacement(-8y,8y)
    ]
    // へ
    42200us, [
        PenUp
        Displacement(24y,56y)
        PenDown
        Displacement(16y,16y)
        Displacement(24y,-24y)
        Displacement(16y,-8y)
        Displacement(32y,-8y)
    ]
    // べ
    42201us, [
        PenUp
        Displacement(24y,56y)
        PenDown
        Displacement(16y,16y)
        Displacement(24y,-24y)
        Displacement(16y,-8y)
        Displacement(32y,-8y)
        PenUp
        Displacement(-24y,79y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // ぺ
    42202us, [
        PenUp
        Displacement(24y,56y)
        PenDown
        Displacement(16y,16y)
        Displacement(24y,-24y)
        Displacement(16y,-8y)
        Displacement(32y,-8y)
        PenUp
        Displacement(-16y,71y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,8y)
        Displacement(-8y,8y)
    ]
    // ほ
    42203us, [
        PenUp
        Displacement(24y,111y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-32y)
        Displacement(-8y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-24y)
        Displacement(0y,16y)
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(8y,-24y)
        PenDown
        Displacement(-48y,0y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(8y,-8y)
    ]
    // ぼ
    42204us, [
        PenUp
        Displacement(16y,111y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-32y)
        Displacement(-8y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-24y)
        Displacement(0y,16y)
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(8y,-24y)
        PenDown
        Displacement(-48y,0y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(8y,-8y)
        PenUp
        Displacement(0y,87y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // ぽ
    42205us, [
        PenUp
        Displacement(16y,111y)
        PenDown
        Displacement(8y,-16y)
        Displacement(0y,-32y)
        Displacement(-8y,-16y)
        Displacement(0y,-24y)
        Displacement(16y,-16y)
        Displacement(0y,16y)
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(8y,-24y)
        PenDown
        Displacement(-48y,0y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(0y,-48y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(8y,-8y)
        PenUp
        Displacement(8y,95y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,8y)
        Displacement(-8y,8y)
    ]
    // ま
    42206us, [
        PenUp
        Displacement(48y,87y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(8y,-24y)
        PenDown
        Displacement(-48y,0y)
        PenUp
        Displacement(24y,48y)
        PenDown
        Displacement(0y,-71y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
        Displacement(8y,8y)
        Displacement(16y,8y)
        Displacement(24y,-8y)
        Displacement(8y,-8y)
    ]
    // み
    42207us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(24y,0y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,-24y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(8y,16y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-8y)
        Displacement(24y,-16y)
        Displacement(8y,-8y)
        PenUp
        Displacement(-8y,56y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-24y,-24y)
    ]
    // む
    42208us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-16y,16y)
        PenDown
        Displacement(0y,-64y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(0y,8y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-8y,-8y)
        Displacement(0y,-16y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
        Displacement(16y,8y)
        Displacement(8y,16y)
        Displacement(0y,16y)
        Displacement(-8y,16y)
        Displacement(0y,8y)
        Displacement(0y,8y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
    ]
    // め
    42209us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(0y,-8y)
        Displacement(8y,-16y)
        Displacement(24y,-24y)
        Displacement(16y,-8y)
        PenUp
        Displacement(-8y,64y)
        PenDown
        Displacement(0y,-40y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
        Displacement(-8y,8y)
        Displacement(0y,16y)
        Displacement(8y,16y)
        Displacement(16y,24y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-16y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-24y,-16y)
    ]
    // も
    42210us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
        PenUp
        Displacement(-16y,64y)
        PenDown
        Displacement(0y,-79y)
        Displacement(8y,-16y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        Displacement(8y,16y)
        Displacement(0y,8y)
        Displacement(-8y,16y)
        Displacement(-8y,8y)
    ]
    // ゃ
    42211us, [
        PenUp
        Displacement(79y,87y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(-16y,8y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-16y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        PenUp
        Displacement(-56y,56y)
        PenDown
        Displacement(16y,-8y)
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
    ]
    // や
    42212us, [
        PenUp
        Displacement(16y,64y)
        PenDown
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        Displacement(8y,8y)
        Displacement(8y,8y)
        Displacement(16y,8y)
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
        PenUp
        Displacement(8y,40y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(-16y,8y)
        Displacement(-8y,0y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
    ]
    // ゅ
    42213us, [
        PenUp
        Displacement(32y,87y)
        PenDown
        Displacement(0y,-48y)
        Displacement(8y,-16y)
        Displacement(0y,8y)
        Displacement(8y,16y)
        Displacement(8y,16y)
        Displacement(0y,8y)
        Displacement(8y,16y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
        Displacement(-8y,16y)
        Displacement(0y,8y)
        Displacement(0y,8y)
        Displacement(8y,16y)
        Displacement(16y,16y)
        Displacement(0y,-71y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
    ]
    // ゆ
    42214us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(0y,-71y)
        Displacement(16y,-16y)
        Displacement(0y,8y)
        Displacement(16y,56y)
        Displacement(8y,16y)
        Displacement(32y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-32y)
        Displacement(-16y,-16y)
        Displacement(-24y,0y)
        Displacement(-16y,16y)
        Displacement(0y,48y)
        Displacement(16y,8y)
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-48y)
        Displacement(-8y,-16y)
        Displacement(-24y,-8y)
    ]
    // ょ
    42215us, [
        PenUp
        Displacement(64y,103y)
        PenDown
        Displacement(0y,-24y)
        Displacement(8y,-24y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,8y)
        Displacement(0y,8y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-8y)
        PenUp
        Displacement(-32y,64y)
        PenDown
        Displacement(16y,0y)
    ]
    // よ
    42216us, [
        PenUp
        Displacement(64y,111y)
        PenDown
        Displacement(0y,-32y)
        Displacement(8y,-32y)
        Displacement(8y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,8y)
        Displacement(0y,8y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(32y,-16y)
        PenUp
        Displacement(-32y,79y)
        PenDown
        Displacement(16y,0y)
    ]
    // ら
    42217us, [
        PenUp
        Displacement(64y,103y)
        PenDown
        Displacement(8y,-8y)
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        Displacement(0y,-40y)
        Displacement(16y,8y)
        Displacement(24y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-32y,-8y)
    ]
    // り
    42218us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(0y,-64y)
        Displacement(0y,24y)
        Displacement(16y,16y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
    ]
    // る
    42219us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(8y,-8y)
        Displacement(8y,0y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(-8y,-16y)
        Displacement(-24y,-32y)
        Displacement(-16y,-24y)
        Displacement(24y,24y)
        Displacement(16y,8y)
        Displacement(24y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-24y,-24y)
        Displacement(-16y,0y)
        Displacement(-16y,8y)
        Displacement(0y,8y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
    ]
    // れ
    42220us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(0y,-95y)
        Displacement(-16y,32y)
        PenUp
        Displacement(0y,40y)
        PenDown
        Displacement(24y,0y)
        Displacement(-32y,-56y)
        Displacement(32y,32y)
        PenUp
        Displacement(16y,24y)
        PenDown
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-8y,-40y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(8y,0y)
        Displacement(16y,16y)
    ]
    // ろ
    42221us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(8y,-8y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(0y,-8y)
        Displacement(-48y,-64y)
        Displacement(16y,16y)
        Displacement(24y,16y)
        Displacement(24y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-16y,-8y)
    ]
    // ゎ
    42222us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(24y,0y)
        PenUp
        Displacement(-16y,24y)
        PenDown
        Displacement(8y,-8y)
        Displacement(0y,-71y)
        Displacement(-16y,16y)
        Displacement(24y,24y)
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-8y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
    ]
    // わ
    42223us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-24y,24y)
        PenDown
        Displacement(8y,-8y)
        Displacement(0y,-79y)
        Displacement(-16y,16y)
        Displacement(24y,24y)
        Displacement(24y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
    ]
    // ゐ
    42224us, [
        PenUp
        Displacement(16y,95y)
        PenDown
        Displacement(32y,0y)
        Displacement(-8y,-56y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        Displacement(0y,16y)
        Displacement(16y,16y)
        Displacement(24y,8y)
        Displacement(32y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-8y)
        Displacement(-16y,8y)
        Displacement(0y,8y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        Displacement(16y,-8y)
    ]
    // ゑ
    42225us, [
        PenUp
        Displacement(48y,103y)
        PenDown
        Displacement(24y,0y)
        Displacement(-24y,-16y)
        Displacement(-8y,-16y)
        Displacement(16y,16y)
        Displacement(24y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(8y,8y)
        Displacement(8y,-8y)
        Displacement(-24y,-16y)
        Displacement(-32y,-32y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(24y,-24y)
        Displacement(24y,24y)
        Displacement(16y,-16y)
        Displacement(-8y,0y)
        Displacement(-8y,-8y)
    ]
    // を
    42226us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-16y,16y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-32y,-40y)
        Displacement(8y,8y)
        Displacement(24y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-32y)
        Displacement(0y,32y)
        Displacement(24y,24y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-8y)
        Displacement(-16y,-8y)
        Displacement(-40y,-16y)
        Displacement(-16y,-16y)
        Displacement(0y,-8y)
        Displacement(16y,-8y)
        Displacement(32y,0y)
        Displacement(8y,8y)
    ]
    // ん
    42227us, [
        PenUp
        Displacement(56y,103y)
        PenDown
        Displacement(-16y,-40y)
        Displacement(-16y,-48y)
        Displacement(16y,40y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-40y)
        Displacement(8y,-8y)
        Displacement(8y,0y)
        Displacement(8y,8y)
    ]
    // ァ
    42401us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(64y,0y)
        Displacement(0y,-8y)
        Displacement(-32y,-16y)
        Displacement(-8y,8y)
        Displacement(8y,-8y)
        Displacement(-8y,-24y)
        Displacement(-16y,-24y)
    ]
    // ア
    42402us, [
        PenUp
        Displacement(24y,111y)
        PenDown
        Displacement(87y,0y)
        Displacement(0y,-8y)
        Displacement(-48y,-16y)
        PenUp
        Displacement(0y,8y)
        PenDown
        Displacement(0y,-32y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-24y)
    ]
    // ィ
    42403us, [
        PenUp
        Displacement(79y,103y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(-24y,-16y)
        Displacement(-16y,-8y)
        PenUp
        Displacement(24y,8y)
        PenDown
        Displacement(0y,-56y)
    ]
    // イ
    42404us, [
        PenUp
        Displacement(95y,119y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(-24y,-16y)
        Displacement(-40y,-24y)
        PenUp
        Displacement(48y,24y)
        PenDown
        Displacement(0y,-79y)
    ]
    // ゥ
    42405us, [
        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(0y,16y)
        Displacement(64y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,-24y)
        Displacement(-32y,-32y)
        PenUp
        Displacement(8y,79y)
        PenDown
        Displacement(0y,-16y)
    ]
    // ウ
    42406us, [
        PenUp
        Displacement(32y,79y)
        PenDown
        Displacement(0y,16y)
        Displacement(79y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-32y,-32y)
        PenUp
        Displacement(16y,87y)
        PenDown
        Displacement(0y,16y)
    ]
    // ェ
    42407us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(0y,-48y)
        PenUp
        Displacement(-40y,0y)
        PenDown
        Displacement(79y,0y)
    ]
    // エ
    42408us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-48y,0y)
        PenDown
        Displacement(95y,0y)
    ]
    // ォ
    42409us, [
        PenUp
        Displacement(32y,79y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-16y,16y)
        PenDown
        Displacement(0y,-71y)
        Displacement(-16y,16y)
        PenUp
        Displacement(-32y,-8y)
        PenDown
        Displacement(48y,48y)
    ]
    // オ
    42410us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(87y,0y)
        PenUp
        Displacement(-24y,24y)
        PenDown
        Displacement(0y,-103y)
        Displacement(-16y,16y)
        PenUp
        Displacement(-48y,0y)
        PenDown
        Displacement(64y,64y)
    ]
    // カ
    42411us, [
        PenUp
        Displacement(16y,87y)
        PenDown
        Displacement(79y,0y)
        Displacement(0y,-32y)
        Displacement(-8y,-32y)
        Displacement(-16y,-16y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-48y,-8y)
        PenDown
        Displacement(24y,24y)
        Displacement(8y,16y)
        Displacement(8y,16y)
        Displacement(0y,48y)
    ]
    // ガ
    42412us, [
        PenUp
        Displacement(16y,87y)
        PenDown
        Displacement(79y,0y)
        Displacement(0y,-40y)
        Displacement(-8y,-24y)
        Displacement(-16y,-16y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-48y,-8y)
        PenDown
        Displacement(24y,24y)
        Displacement(8y,16y)
        Displacement(8y,16y)
        Displacement(0y,48y)
        PenUp
        Displacement(56y,0y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
    ]
    // キ
    42413us, [
        PenUp
        Displacement(32y,79y)
        PenDown
        Displacement(64y,8y)
        PenUp
        Displacement(0y,-32y)
        PenDown
        Displacement(-64y,-8y)
        PenUp
        Displacement(48y,-32y)
        PenDown
        Displacement(-32y,95y)
    ]
    // ギ
    42414us, [
        PenUp
        Displacement(95y,119y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-64y,-8y)
        PenUp
        Displacement(0y,-32y)
        PenDown
        Displacement(64y,8y)
        PenUp
        Displacement(-16y,-40y)
        PenDown
        Displacement(-32y,95y)
    ]
    // ク
    42415us, [
        PenUp
        Displacement(48y,111y)
        PenDown
        Displacement(0y,-8y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
        PenUp
        Displacement(32y,24y)
        PenDown
        Displacement(40y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-24y,-24y)
        Displacement(-16y,-8y)
        Displacement(-24y,-8y)
    ]
    // グ
    42416us, [
        PenUp
        Displacement(48y,111y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(40y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-48y,-48y)
        Displacement(-16y,-8y)
        PenUp
        Displacement(95y,103y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
    ]
    // ケ
    42417us, [
        PenUp
        Displacement(56y,111y)
        PenDown
        Displacement(-32y,-32y)
        PenUp
        Displacement(8y,8y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(0y,-8y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-40y,-40y)
    ]
    // ゲ
    42418us, [
        PenUp
        Displacement(56y,111y)
        PenDown
        Displacement(-40y,-40y)
        PenUp
        Displacement(16y,16y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-48y,-48y)
        PenUp
        Displacement(95y,103y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
    ]
    // コ
    42419us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(71y,0y)
        Displacement(0y,-56y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-87y,0y)
    ]
    // ゴ
    42420us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-87y,-8y)
        PenDown
        Displacement(71y,0y)
        Displacement(0y,-56y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-87y,0y)
    ]
    // サ
    42421us, [
        PenUp
        Displacement(16y,79y)
        PenDown
        Displacement(95y,0y)
        PenUp
        Displacement(-32y,32y)
        PenDown
        Displacement(0y,-79y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(-16y,40y)
        PenDown
        Displacement(0y,56y)
    ]
    // ザ
    42422us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-95y,0y)
        PenUp
        Displacement(32y,24y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(16y,-40y)
        PenDown
        Displacement(8y,8y)
        Displacement(8y,16y)
        Displacement(0y,79y)
    ]
    // シ
    42423us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-16y,-24y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-24y,-56y)
        PenDown
        Displacement(16y,8y)
        Displacement(64y,64y)
    ]
    // ジ
    42424us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-16y,-24y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-24y,-56y)
        PenDown
        Displacement(16y,8y)
        Displacement(64y,64y)
        PenUp
        Displacement(8y,16y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,16y)
        PenDown
        Displacement(16y,-8y)
    ]
    // ス
    42425us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(64y,0y)
        Displacement(-71y,-71y)
        PenUp
        Displacement(48y,32y)
        PenDown
        Displacement(32y,-32y)
    ]
    // ズ
    42426us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(56y,0y)
        Displacement(-8y,-16y)
        Displacement(-56y,-56y)
        PenUp
        Displacement(48y,32y)
        PenDown
        Displacement(32y,-32y)
        PenUp
        Displacement(-8y,95y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // セ
    42427us, [
        PenUp
        Displacement(16y,79y)
        PenDown
        Displacement(87y,8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(0y,-40y)
        PenDown
        Displacement(-40y,0y)
        Displacement(0y,79y)
    ]
    // ゼ
    42428us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-24y,-32y)
        PenDown
        Displacement(16y,24y)
        Displacement(-87y,-8y)
        PenUp
        Displacement(32y,24y)
        PenDown
        Displacement(0y,-79y)
        Displacement(40y,0y)
    ]
    // ソ
    42429us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(16y,-24y)
        PenUp
        Displacement(56y,32y)
        PenDown
        Displacement(-8y,-32y)
        Displacement(-16y,-24y)
        Displacement(-16y,-16y)
    ]
    // ゾ
    42430us, [
        PenUp
        Displacement(16y,95y)
        PenDown
        Displacement(16y,-24y)
        PenUp
        Displacement(48y,24y)
        PenDown
        Displacement(-8y,-40y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        PenUp
        Displacement(48y,95y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-16y,-8y)
        PenDown
        Displacement(16y,-8y)
    ]
    // タ
    42431us, [
        PenUp
        Displacement(48y,111y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(40y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-56y,-56y)
        PenUp
        Displacement(24y,56y)
        PenDown
        Displacement(32y,-32y)
    ]
    // ダ
    42432us, [
        PenUp
        Displacement(48y,111y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(40y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-56y,-56y)
        PenUp
        Displacement(16y,64y)
        PenDown
        Displacement(40y,-40y)
        PenUp
        Displacement(16y,87y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-16y,8y)
    ]
    // チ
    42433us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(56y,8y)
        PenUp
        Displacement(16y,-40y)
        PenDown
        Displacement(-87y,0y)
        PenUp
        Displacement(48y,32y)
        PenDown
        Displacement(0y,-32y)
        Displacement(-8y,-24y)
        Displacement(-32y,-32y)
    ]
    // ヂ
    42434us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-24y,8y)
        PenDown
        Displacement(-56y,-8y)
        PenUp
        Displacement(-16y,-32y)
        PenDown
        Displacement(87y,0y)
        PenUp
        Displacement(-40y,32y)
        PenDown
        Displacement(0y,-40y)
        Displacement(-8y,-16y)
        Displacement(-32y,-32y)
    ]
    // ッ
    42435us, [
        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(0y,-8y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(0y,8y)
        PenUp
        Displacement(24y,8y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
    ]
    // ツ
    42436us, [
        PenUp
        Displacement(16y,95y)
        PenDown
        Displacement(8y,-16y)
        PenUp
        Displacement(32y,16y)
        PenDown
        Displacement(8y,-16y)
        PenUp
        Displacement(32y,16y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-40y,-40y)
    ]
    // ヅ
    42437us, [
        PenUp
        Displacement(16y,95y)
        PenDown
        Displacement(8y,-16y)
        PenUp
        Displacement(24y,16y)
        PenDown
        Displacement(8y,-16y)
        PenUp
        Displacement(32y,16y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-32y,-32y)
        PenUp
        Displacement(48y,87y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-16y,-8y)
        PenDown
        Displacement(16y,-8y)
    ]
    // テ
    42438us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(56y,0y)
        PenUp
        Displacement(16y,-32y)
        PenDown
        Displacement(-87y,0y)
        PenUp
        Displacement(48y,0y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-32y,-32y)
    ]
    // デ
    42439us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-32y,8y)
        PenDown
        Displacement(-48y,0y)
        PenUp
        Displacement(-16y,-32y)
        PenDown
        Displacement(87y,0y)
        PenUp
        Displacement(-40y,0y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-32y,-32y)
    ]
    // ト
    42440us, [
        PenUp
        Displacement(48y,111y)
        PenDown
        Displacement(0y,-103y)
        PenUp
        Displacement(8y,71y)
        PenDown
        Displacement(24y,-24y)
    ]
    // ド
    42441us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-32y,-40y)
        PenDown
        Displacement(-24y,24y)
        PenUp
        Displacement(-8y,32y)
        PenDown
        Displacement(0y,-103y)
    ]
    // ナ
    42442us, [
        PenUp
        Displacement(16y,79y)
        PenDown
        Displacement(95y,0y)
        PenUp
        Displacement(-48y,24y)
        PenDown
        Displacement(0y,-32y)
        Displacement(-8y,-24y)
        Displacement(-8y,-16y)
        Displacement(-24y,-24y)
    ]
    // ニ
    42443us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(16y,-56y)
        PenDown
        Displacement(-95y,0y)
    ]
    // ヌ
    42444us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(64y,0y)
        Displacement(0y,-16y)
        Displacement(-8y,-24y)
        Displacement(-24y,-24y)
        Displacement(-40y,-24y)
        PenUp
        Displacement(16y,64y)
        PenDown
        Displacement(24y,-16y)
        Displacement(16y,-16y)
        Displacement(16y,-16y)
    ]
    // ネ
    42445us, [
        PenUp
        Displacement(48y,111y)
        PenDown
        Displacement(16y,-16y)
        PenUp
        Displacement(-32y,-8y)
        PenDown
        Displacement(48y,0y)
        Displacement(-8y,-16y)
        Displacement(-24y,-24y)
        Displacement(-32y,-16y)
        PenUp
        Displacement(48y,24y)
        PenDown
        Displacement(0y,-48y)
        PenUp
        Displacement(8y,56y)
        PenDown
        Displacement(24y,-24y)
    ]
    // ノ
    42446us, [
        PenUp
        Displacement(87y,103y)
        PenDown
        Displacement(-8y,-16y)
        Displacement(-56y,-56y)
    ]
    // ハ
    42447us, [
        PenUp
        Displacement(56y,95y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-32y,-32y)
        PenUp
        Displacement(64y,40y)
        PenDown
        Displacement(24y,-32y)
    ]
    // バ
    42448us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-56y,0y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-32y,-32y)
        PenUp
        Displacement(64y,40y)
        PenDown
        Displacement(24y,-32y)
    ]
    // パ
    42449us, [
        PenUp
        Displacement(103y,111y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-24y,-32y)
        PenDown
        Displacement(24y,-32y)
        PenUp
        Displacement(-87y,-8y)
        PenDown
        Displacement(32y,32y)
        Displacement(8y,16y)
        Displacement(0y,8y)
    ]
    // ヒ
    42450us, [
        PenUp
        Displacement(48y,103y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-8y)
        Displacement(32y,0y)
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(-40y,-16y)
    ]
    // ビ
    42451us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-24y,-8y)
        PenDown
        Displacement(-40y,-16y)
        PenUp
        Displacement(0y,32y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-8y)
        Displacement(32y,0y)
    ]
    // ピ
    42452us, [
        PenUp
        Displacement(103y,111y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-16y,-24y)
        PenDown
        Displacement(-40y,-16y)
        PenUp
        Displacement(0y,32y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-8y)
        Displacement(32y,0y)
    ]
    // フ
    42453us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(71y,0y)
        Displacement(-8y,-16y)
        Displacement(-64y,-64y)
    ]
    // ブ
    42454us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-87y,0y)
        PenDown
        Displacement(64y,0y)
        Displacement(8y,-8y)
        Displacement(-71y,-71y)
    ]
    // プ
    42455us, [
        PenUp
        Displacement(103y,111y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-87y,-16y)
        PenDown
        Displacement(71y,0y)
        Displacement(0y,-8y)
        Displacement(-71y,-71y)
    ]
    // ヘ
    42456us, [
        PenUp
        Displacement(24y,56y)
        PenDown
        Displacement(24y,24y)
        Displacement(56y,-56y)
    ]
    // ベ
    42457us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-87y,-32y)
        PenDown
        Displacement(24y,24y)
        Displacement(56y,-56y)
    ]
    // ペ
    42458us, [
        PenUp
        Displacement(95y,111y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-71y,-56y)
        PenDown
        Displacement(32y,32y)
        Displacement(48y,-48y)
    ]
    // ホ
    42459us, [
        PenUp
        Displacement(16y,87y)
        PenDown
        Displacement(95y,0y)
        PenUp
        Displacement(0y,-48y)
        PenDown
        Displacement(-40y,40y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-40y,-40y)
        PenUp
        Displacement(32y,-8y)
        PenDown
        Displacement(16y,-16y)
        Displacement(0y,87y)
    ]
    // ボ
    42460us, [
        PenUp
        Displacement(111y,111y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-95y,0y)
        PenUp
        Displacement(0y,-40y)
        PenDown
        Displacement(32y,32y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(32y,-32y)
        PenUp
        Displacement(-64y,-8y)
        PenDown
        Displacement(16y,-16y)
        Displacement(0y,87y)
    ]
    // ポ
    42461us, [
        PenUp
        Displacement(95y,111y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(16y,-32y)
        PenDown
        Displacement(-95y,0y)
        PenUp
        Displacement(0y,-40y)
        PenDown
        Displacement(32y,32y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(32y,-32y)
        PenUp
        Displacement(-64y,-8y)
        PenDown
        Displacement(16y,-16y)
        Displacement(0y,87y)
    ]
    // マ
    42462us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(79y,0y)
        Displacement(-48y,-48y)
        PenUp
        Displacement(-16y,8y)
        PenDown
        Displacement(32y,-24y)
    ]
    // ミ
    42463us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(48y,-8y)
        PenUp
        Displacement(0y,-32y)
        PenDown
        Displacement(-48y,8y)
        PenUp
        Displacement(-8y,-24y)
        PenDown
        Displacement(71y,-24y)
    ]
    // ム
    42464us, [
        PenUp
        Displacement(71y,103y)
        PenDown
        Displacement(-8y,-16y)
        Displacement(-24y,-40y)
        Displacement(-16y,-16y)
        Displacement(71y,8y)
        PenUp
        Displacement(-8y,8y)
        PenDown
        Displacement(24y,-24y)
    ]
    // メ
    42465us, [
        PenUp
        Displacement(95y,103y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-64y,-64y)
        PenUp
        Displacement(16y,64y)
        PenDown
        Displacement(40y,-40y)
    ]
    // モ
    42466us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(0y,-71y)
        Displacement(32y,0y)
        PenUp
        Displacement(8y,40y)
        PenDown
        Displacement(-87y,0y)
    ]
    // ャ
    42467us, [
        PenUp
        Displacement(48y,95y)
        PenDown
        Displacement(24y,-71y)
        PenUp
        Displacement(-40y,56y)
        PenDown
        Displacement(64y,0y)
        Displacement(-8y,-16y)
    ]
    // ヤ
    42468us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(24y,-87y)
        PenUp
        Displacement(-40y,71y)
        PenDown
        Displacement(79y,0y)
        Displacement(-16y,-16y)
    ]
    // ュ
    42469us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(40y,0y)
        Displacement(0y,-40y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(-71y,0y)
    ]
    // ユ
    42470us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(64y,0y)
        Displacement(-8y,-48y)
        PenUp
        Displacement(-64y,0y)
        PenDown
        Displacement(95y,0y)
    ]
    // ョ
    42471us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,-64y)
        Displacement(-48y,0y)
        PenUp
        Displacement(0y,32y)
        PenDown
        Displacement(48y,0y)
    ]
    // ヨ
    42472us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(79y,0y)
        Displacement(0y,-87y)
        Displacement(-79y,0y)
        PenUp
        Displacement(0y,48y)
        PenDown
        Displacement(79y,0y)
    ]
    // ラ
    42473us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(-64y,-24y)
        PenDown
        Displacement(79y,0y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-56y,-48y)
    ]
    // リ
    42474us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(0y,-48y)
        PenUp
        Displacement(0y,-40y)
        PenDown
        Displacement(24y,24y)
        Displacement(8y,16y)
        Displacement(0y,64y)
    ]
    // ル
    42475us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(0y,-56y)
        Displacement(-8y,-16y)
        Displacement(-24y,-24y)
        PenUp
        Displacement(64y,103y)
        PenDown
        Displacement(0y,-103y)
        Displacement(32y,32y)
    ]
    // レ
    42476us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(16y,8y)
        Displacement(56y,56y)
    ]
    // ロ
    42477us, [
        PenUp
        Displacement(32y,24y)
        PenDown
        Displacement(0y,71y)
        Displacement(71y,0y)
        Displacement(0y,-71y)
        Displacement(-71y,0y)
    ]
    // ヮ
    42478us, [
        PenUp
        Displacement(32y,64y)
        PenDown
        Displacement(0y,24y)
        Displacement(64y,0y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-40y,-40y)
    ]
    // ワ
    42479us, [
        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(0y,24y)
        Displacement(79y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-32y,-32y)
    ]
    // ヰ
    42480us, [
        PenUp
        Displacement(64y,111y)
        PenDown
        Displacement(0y,-95y)
        PenUp
        Displacement(-48y,32y)
        PenDown
        Displacement(95y,0y)
        PenUp
        Displacement(-24y,40y)
        PenDown
        Displacement(-56y,0y)
        Displacement(0y,-40y)
    ]
    // ヱ
    42481us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(64y,0y)
        Displacement(-32y,-16y)
        PenUp
        Displacement(-8y,8y)
        PenDown
        Displacement(8y,-8y)
        Displacement(0y,-48y)
        PenUp
        Displacement(-48y,0y)
        PenDown
        Displacement(95y,0y)
    ]
    // ヲ
    42482us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(71y,0y)
        PenUp
        Displacement(-71y,24y)
        PenDown
        Displacement(71y,0y)
        Displacement(0y,-24y)
        Displacement(-71y,-64y)
    ]
    // ン
    42483us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(16y,-8y)
        PenUp
        Displacement(-24y,-79y)
        PenDown
        Displacement(16y,8y)
        Displacement(64y,64y)
    ]
    // ヴ
    42484us, [
        PenUp
        Displacement(24y,63y)
        PenDown
        Displacement(0y,24y)
        Displacement(71y,0y)
        Displacement(0y,-16y)
        Displacement(-8y,-16y)
        Displacement(-16y,-24y)
        Displacement(-24y,-24y)
        PenUp
        Displacement(16y,95y)
        PenDown
        Displacement(0y,-16y)
        PenUp
        Displacement(48y,8y)
        PenDown
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,16y)
        PenDown
        Displacement(16y,-8y)
    ]
    // ヵ
    42485us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(56y,0y)
        Displacement(0y,-48y)
        Displacement(-8y,-8y)
        Displacement(-8y,8y)
        PenUp
        Displacement(-40y,-8y)
        PenDown
        Displacement(16y,16y)
        Displacement(8y,16y)
        Displacement(0y,40y)
    ]
    // ヶ
    42486us, [
        PenUp
        Displacement(56y,95y)
        PenDown
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        PenUp
        Displacement(16y,16y)
        PenDown
        Displacement(40y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(-24y,-24y)
    ]
    // Α
    42657us, [
        PenUp
        Displacement(24y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(32y,95y)
        Displacement(24y,-95y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-24y,40y)
        PenDown
        Displacement(-24y,0y)
    ]
    // Β
    42658us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(48y,0y)
        Displacement(16y,16y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-40y,8y)
        Displacement(40y,8y)
        Displacement(16y,16y)
        Displacement(0y,8y)
        Displacement(-8y,8y)
        Displacement(-48y,0y)
    ]
    // Γ
    42659us, [
        PenUp
        Displacement(95y,87y)
        PenDown
        Displacement(0y,16y)
        Displacement(-64y,0y)
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Δ
    42660us, [
        PenUp
        Displacement(64y,111y)
        PenDown
        Displacement(-40y,-95y)
        Displacement(79y,0y)
        Displacement(-40y,95y)
    ]
    // Ε
    42661us, [
        PenUp
        Displacement(95y,95y)
        PenDown
        Displacement(0y,8y)
        Displacement(-56y,0y)
        Displacement(0y,-87y)
        Displacement(56y,0y)
        Displacement(0y,8y)
        PenUp
        Displacement(-16y,32y)
        PenDown
        Displacement(0y,16y)
        PenUp
        Displacement(0y,-8y)
        PenDown
        Displacement(-40y,0y)
    ]
    // Ζ
    42662us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(0y,8y)
        Displacement(64y,0y)
        Displacement(0y,-24y)
        Displacement(-64y,-64y)
        Displacement(71y,0y)
        Displacement(0y,16y)
    ]
    // Η
    42663us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,-40y)
        PenDown
        Displacement(-48y,0y)
    ]
    // Θ
    42664us, [
        PenUp
        Displacement(32y,87y)
        PenDown
        Displacement(-8y,-16y)
        Displacement(0y,-16y)
        Displacement(8y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        Displacement(8y,8y)
        Displacement(8y,16y)
        Displacement(0y,16y)
        Displacement(-8y,16y)
        Displacement(-8y,8y)
        Displacement(-16y,8y)
        Displacement(-16y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(16y,-16y)
        PenDown
        Displacement(0y,-16y)
        Displacement(0y,8y)
        Displacement(32y,0y)
        Displacement(0y,-8y)
        Displacement(0y,16y)
    ]
    // Ι
    42665us, [
        PenUp
        Displacement(56y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Κ
    42666us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(40y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(-48y,48y)
        Displacement(40y,40y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Λ
    42667us, [
        PenUp
        Displacement(24y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(32y,95y)
        Displacement(24y,-95y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Μ
    42668us, [
        PenUp
        Displacement(16y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,79y)
        Displacement(40y,-64y)
        Displacement(32y,64y)
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ν
    42669us, [
        PenUp
        Displacement(24y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
        Displacement(64y,-87y)
        Displacement(0y,87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ξ
    42670us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(0y,8y)
        Displacement(64y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(-8y,-24y)
        PenDown
        Displacement(0y,-16y)
        PenUp
        Displacement(0y,8y)
        PenDown
        Displacement(-48y,0y)
        Displacement(0y,8y)
        Displacement(0y,-16y)
        PenUp
        Displacement(-8y,-24y)
        PenDown
        Displacement(0y,-8y)
        Displacement(64y,0y)
        Displacement(0y,8y)
    ]
    // Ο
    42671us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(0y,-40y)
        Displacement(24y,-24y)
        Displacement(32y,0y)
        Displacement(24y,24y)
        Displacement(0y,40y)
        Displacement(-24y,24y)
        Displacement(-32y,0y)
        Displacement(-24y,-24y)
    ]
    // Π
    42672us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-79y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
    ]
    // Ρ
    42673us, [
        PenUp
        Displacement(32y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
        Displacement(32y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-24y,0y)
        Displacement(-8y,8y)
    ]
    // Σ
    42674us, [
        PenUp
        Displacement(95y,95y)
        PenDown
        Displacement(0y,8y)
        Displacement(-64y,0y)
        Displacement(0y,-16y)
        Displacement(24y,-24y)
        Displacement(0y,-8y)
        Displacement(-24y,-24y)
        Displacement(0y,-16y)
        Displacement(64y,0y)
        Displacement(0y,8y)
    ]
    // Τ
    42675us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(0y,8y)
        Displacement(79y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(-40y,8y)
        PenDown
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Υ
    42676us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,79y)
        Displacement(8y,8y)
        Displacement(16y,8y)
        Displacement(8y,0y)
        Displacement(8y,-16y)
    ]
    // Φ
    42677us, [
        PenUp
        Displacement(8y,48y)
        PenDown
        Displacement(24y,-24y)
        Displacement(48y,0y)
        Displacement(24y,24y)
        Displacement(0y,32y)
        Displacement(-24y,24y)
        Displacement(-48y,0y)
        Displacement(-24y,-24y)
        Displacement(0y,-32y)
        PenUp
        Displacement(56y,71y)
        PenDown
        Displacement(-16y,-111y)
    ]
    // Χ
    42678us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(64y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(0y,87y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-64y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ψ
    42679us, [
        PenUp
        Displacement(16y,103y)
        PenDown
        Displacement(8y,-8y)
        Displacement(0y,-24y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(24y,0y)
        Displacement(16y,8y)
        Displacement(8y,8y)
        Displacement(0y,24y)
        Displacement(8y,8y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        Displacement(-24y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(24y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
        Displacement(-8y,-87y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-8y,87y)
    ]
    // Ω
    42680us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,-8y)
        Displacement(0y,-8y)
        Displacement(-32y,0y)
        Displacement(0y,8y)
        PenUp
        Displacement(79y,0y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-32y,0y)
        Displacement(0y,8y)
        Displacement(16y,8y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(-24y,24y)
        Displacement(-32y,0y)
        Displacement(-24y,-24y)
    ]
    // α
    42689us, [
        PenUp
        Displacement(79y,95y)
        PenDown
        Displacement(-16y,-56y)
        Displacement(-16y,-16y)
        Displacement(-8y,0y)
        Displacement(-16y,16y)
        Displacement(0y,32y)
        Displacement(8y,16y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(8y,-56y)
        Displacement(8y,-8y)
    ]
    // β
    42690us, [
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(16y,16y)
        Displacement(0y,79y)
        Displacement(8y,8y)
        Displacement(24y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-24y,0y)
        Displacement(24y,0y)
        Displacement(16y,-8y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
        Displacement(-16y,0y)
        Displacement(-8y,8y)
    ]
    // γ
    42691us, [
        PenUp
        Displacement(32y,79y)
        PenDown
        Displacement(8y,8y)
        Displacement(8y,-8y)
        Displacement(16y,-32y)
        Displacement(0y,-32y)
        PenUp
        Displacement(0y,24y)
        PenDown
        Displacement(32y,56y)
    ]
    // δ
    42692us, [
        PenUp
        Displacement(87y,95y)
        PenDown
        Displacement(-16y,8y)
        Displacement(-24y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-8y)
        Displacement(56y,-32y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-24y,0y)
        Displacement(-16y,16y)
        Displacement(0y,16y)
        Displacement(24y,16y)
    ]
    // ε
    42693us, [
        PenUp
        Displacement(87y,87y)
        PenDown
        Displacement(-16y,8y)
        Displacement(-24y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-8y)
        Displacement(24y,-8y)
        Displacement(16y,0y)
        Displacement(-16y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(16y,-16y)
        Displacement(24y,0y)
        Displacement(16y,16y)
    ]
    // ζ
    42694us, [
        PenUp
        Displacement(56y,103y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(-16y,-16y)
        Displacement(-16y,-8y)
        Displacement(-16y,-16y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(24y,0y)
        Displacement(8y,-8y)
        Displacement(-8y,-8y)
        Displacement(-24y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-8y)
    ]
    // η
    42695us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(8y,-8y)
        Displacement(0y,-48y)
        PenUp
        Displacement(0y,48y)
        PenDown
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-64y)
        Displacement(8y,-24y)
    ]
    // θ
    42696us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(0y,-56y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,56y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        PenUp
        Displacement(8y,-16y)
        PenDown
        Displacement(16y,-8y)
    ]
    // ι
    42697us, [
        PenUp
        Displacement(48y,95y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,-79y)
        Displacement(8y,-8y)
        Displacement(16y,16y)
    ]
    // κ
    42698us, [
        PenUp
        Displacement(16y,71y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-40y,40y)
        PenDown
        Displacement(0y,-40y)
        Displacement(-32y,-56y)
        Displacement(64y,8y)
        PenUp
        Displacement(-8y,8y)
        PenDown
        Displacement(16y,-16y)
    ]
    // λ
    42699us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(8y,8y)
        Displacement(24y,-32y)
        Displacement(24y,-48y)
        Displacement(8y,8y)
        Displacement(0y,8y)
        PenUp
        Displacement(-56y,-16y)
        PenDown
        Displacement(24y,48y)
    ]
    // μ
    42700us, [
        PenUp
        Displacement(32y,16y)
        PenDown
        Displacement(8y,32y)
        Displacement(0y,48y)
        Displacement(0y,-56y)
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
        Displacement(8y,8y)
        Displacement(0y,64y)
        Displacement(0y,-64y)
        Displacement(8y,-8y)
        Displacement(8y,0y)
    ]
    // ν
    42701us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(32y,-64y)
        Displacement(32y,64y)
    ]
    // ξ
    42702us, [
        PenUp
        Displacement(71y,111y)
        PenDown
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
        Displacement(-24y,-8y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
        Displacement(-24y,-8y)
        Displacement(-8y,-8y)
        Displacement(0y,-8y)
        Displacement(24y,-16y)
        Displacement(8y,0y)
        Displacement(8y,-8y)
        Displacement(-8y,-8y)
        Displacement(-24y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-8y)
    ]
    // ο
    42703us, [
        PenUp
        Displacement(40y,79y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
    ]
    // π
    42704us, [
        PenUp
        Displacement(32y,79y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(0y,-40y)
        Displacement(8y,-8y)
        Displacement(16y,0y)
        PenUp
        Displacement(-64y,0y)
        PenDown
        Displacement(16y,8y)
        Displacement(0y,40y)
    ]
    // ρ
    42705us, [
        PenUp
        Displacement(32y,24y)
        PenDown
        Displacement(16y,71y)
        Displacement(8y,8y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-16y,-8y)
        Displacement(-16y,0y)
        Displacement(-16y,8y)
    ]
    // σ
    42706us, [
        PenUp
        Displacement(103y,87y)
        Displacement(0y,8y)
        PenDown
        Displacement(-48y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(-16y,16y)
    ]
    // τ
    42707us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(48y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-8y)
        Displacement(16y,16y)
    ]
    // υ
    42708us, [
        PenUp
        Displacement(32y,87y)
        Displacement(0y,-8y)
        PenDown
        Displacement(16y,8y)
        Displacement(8y,-71y)
        Displacement(8y,0y)
        Displacement(16y,8y)
        Displacement(16y,16y)
        Displacement(-8y,48y)
    ]
    // φ
    42709us, [
        PenUp
        Displacement(56y,103y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(0y,24y)
        PenDown
        Displacement(-24y,0y)
        Displacement(-16y,16y)
        Displacement(0y,8y)
        Displacement(16y,16y)
        Displacement(48y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-24y,0y)
    ]
    // χ
    42710us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(8y,8y)
        Displacement(24y,-32y)
        Displacement(24y,-48y)
        Displacement(8y,8y)
        Displacement(0y,8y)
        PenUp
        Displacement(0y,64y)
        PenDown
        Displacement(-40y,-48y)
        Displacement(-24y,-32y)
    ]
    // ψ
    42711us, [
        PenUp
        Displacement(16y,87y)
        PenDown
        Displacement(8y,8y)
        Displacement(8y,-8y)
        Displacement(-8y,-16y)
        Displacement(0y,-24y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(24y,16y)
        Displacement(0y,24y)
        Displacement(-8y,16y)
        PenUp
        Displacement(-24y,32y)
        PenDown
        Displacement(0y,-119y)
    ]
    // ω
    42712us, [
        PenUp
        Displacement(48y,95y)
        PenDown
        Displacement(-24y,-24y)
        Displacement(0y,-24y)
        Displacement(16y,-16y)
        Displacement(16y,16y)
        Displacement(8y,24y)
        Displacement(8y,-24y)
        Displacement(16y,-16y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-8y,16y)
        Displacement(-16y,16y)
    ]
    // А
    42913us, [
        PenUp
        Displacement(24y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(32y,95y)
        Displacement(32y,-95y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-24y,40y)
        PenDown
        Displacement(-32y,0y)
    ]
    // Б
    42914us, [
        PenUp
        Displacement(95y,95y)
        PenDown
        Displacement(0y,8y)
        Displacement(-56y,0y)
        Displacement(0y,-87y)
        Displacement(40y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-40y,0y)
    ]
    // В
    42915us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(48y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,-8y)
        Displacement(-32y,0y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(16y,-8y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-40y,0y)
        Displacement(0y,87y)
    ]
    // Г
    42916us, [
        PenUp
        Displacement(32y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
        Displacement(56y,0y)
        Displacement(0y,-16y)
    ]
    // Д
    42917us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-79y)
        PenUp
        Displacement(16y,-8y)
        PenDown
        Displacement(0y,8y)
        Displacement(-87y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(16y,8y)
        PenDown
        Displacement(16y,79y)
    ]
    // Е
    42918us, [
        PenUp
        Displacement(95y,95y)
        PenDown
        Displacement(0y,8y)
        Displacement(-56y,0y)
        Displacement(0y,-87y)
        Displacement(56y,0y)
        Displacement(0y,8y)
        PenUp
        Displacement(-16y,32y)
        PenDown
        Displacement(0y,16y)
        PenUp
        Displacement(0y,-8y)
        PenDown
        Displacement(-40y,0y)
    ]
    // Ё
    42919us, [
        PenUp
        Displacement(95y,87y)
        PenDown
        Displacement(0y,8y)
        Displacement(-56y,0y)
        Displacement(0y,-87y)
        Displacement(56y,0y)
        Displacement(0y,8y)
        PenUp
        Displacement(-16y,32y)
        PenDown
        Displacement(0y,16y)
        PenUp
        Displacement(0y,-8y)
        PenDown
        Displacement(-40y,0y)
        PenUp
        Displacement(8y,56y)
        PenDown
        Displacement(8y,0y)
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,8y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(0y,8y)
        Displacement(8y,0y)
        Displacement(-8y,-8y)
    ]
    // Ж
    42920us, [
        PenUp
        Displacement(16y,103y)
        PenDown
        Displacement(16y,-16y)
        Displacement(8y,-16y)
        Displacement(8y,-16y)
        Displacement(32y,0y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        Displacement(-8y,-16y)
        Displacement(-16y,-16y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(40y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(40y,0y)
        PenDown
        Displacement(-24y,-16y)
        Displacement(-8y,-16y)
        Displacement(-8y,-16y)
        Displacement(8y,-8y)
        Displacement(8y,-16y)
        Displacement(24y,-16y)
    ]
    // З
    42921us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(0y,-16y)
        Displacement(24y,24y)
        Displacement(24y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-16y)
        Displacement(-16y,-16y)
        Displacement(-16y,-8y)
        Displacement(-16y,0y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(16y,-16y)
        Displacement(0y,-8y)
        Displacement(-24y,-16y)
        Displacement(-24y,0y)
        Displacement(-16y,8y)
        Displacement(-16y,16y)
    ]
    // И
    42922us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        Displacement(48y,87y)
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-48y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(64y,87y)
        PenDown
        Displacement(-16y,0y)
    ]
    // Й
    42923us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(48y,87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-16y,103y)
        PenDown
        Displacement(-16y,-8y)
        Displacement(8y,8y)
        Displacement(8y,0y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        Displacement(16y,-8y)
        Displacement(-8y,8y)
        Displacement(-8y,0y)
    ]
    // К
    42924us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,48y)
        PenDown
        Displacement(24y,0y)
        Displacement(8y,16y)
        Displacement(24y,24y)
        Displacement(8y,-8y)
        PenUp
        Displacement(-40y,-32y)
        PenDown
        Displacement(8y,-16y)
        Displacement(16y,-24y)
        Displacement(16y,-8y)
    ]
    // Л
    42925us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-71y,16y)
        PenDown
        Displacement(0y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,8y)
        Displacement(16y,79y)
    ]
    // М
    42926us, [
        PenUp
        Displacement(16y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,79y)
        Displacement(40y,-71y)
        Displacement(32y,71y)
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Н
    42927us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(32y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,-40y)
        PenDown
        Displacement(-48y,0y)
    ]
    // О
    42928us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(0y,-40y)
        Displacement(24y,-24y)
        Displacement(32y,0y)
        Displacement(24y,24y)
        Displacement(0y,40y)
        Displacement(-24y,24y)
        Displacement(-32y,0y)
        Displacement(-24y,-24y)
    ]
    // П
    42929us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-48y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,87y)
    ]
    // Р
    42930us, [
        PenUp
        Displacement(32y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
        Displacement(32y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-32y,0y)
    ]
    // С
    42931us, [
        PenUp
        Displacement(95y,87y)
        PenDown
        Displacement(-16y,16y)
        Displacement(-32y,0y)
        Displacement(-24y,-24y)
        Displacement(0y,-40y)
        Displacement(24y,-24y)
        Displacement(32y,0y)
        Displacement(16y,16y)
    ]
    // Т
    42932us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(0y,8y)
        Displacement(79y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(-40y,8y)
        PenDown
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // У
    42933us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(32y,-71y)
        PenUp
        Displacement(24y,71y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(-8y,-40y)
        Displacement(-32y,-40y)
        Displacement(-16y,-16y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
    ]
    // Ф
    42934us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(64y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(0y,87y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-64y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Х
    42935us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(0y,-24y)
        Displacement(16y,-16y)
        Displacement(48y,0y)
        Displacement(16y,16y)
        Displacement(0y,24y)
        Displacement(-16y,16y)
        Displacement(-48y,0y)
        PenUp
        Displacement(16y,16y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ц
    42936us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(87y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(0y,87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ч
    42937us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-48y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
        Displacement(16y,16y)
        PenUp
        Displacement(-8y,40y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ш
    42938us, [
        PenUp
        Displacement(16y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(103y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,87y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-87y)
    ]
    // Щ
    42939us, [
        PenUp
        Displacement(8y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-79y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(103y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(-16y,8y)
        PenDown
        Displacement(0y,79y)
        Displacement(-8y,0y)
        Displacement(8y,0y)
        Displacement(8y,0y)
        PenUp
        Displacement(-40y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-79y)
    ]
    // Ъ
    42940us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(0y,8y)
        Displacement(24y,0y)
        Displacement(0y,-87y)
        Displacement(32y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-32y,0y)
    ]
    // Ы
    42941us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,8y)
        Displacement(-16y,0y)
        PenUp
        Displacement(64y,48y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // Ь
    42942us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        Displacement(24y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-24y,0y)
    ]
    // Э
    42943us, [
        PenUp
        Displacement(32y,103y)
        Displacement(0y,-24y)
        PenDown
        Displacement(16y,24y)
        Displacement(32y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-40y,0y)
        Displacement(40y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-24y,-24y)
        Displacement(-24y,0y)
        Displacement(-16y,16y)
    ]
    // Ю
    42944us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,48y)
        PenDown
        Displacement(16y,0y)
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(32y,0y)
        Displacement(16y,16y)
        Displacement(0y,56y)
        Displacement(-16y,16y)
        Displacement(-32y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-24y)
    ]
    // Я
    42945us, [
        PenUp
        Displacement(95y,16y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,87y)
        Displacement(-40y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(8y,0y)
        Displacement(24y,8y)
        Displacement(-24y,-8y)
        Displacement(-40y,-40y)
        Displacement(-8y,8y)
    ]
    // а
    42961us, [
        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(0y,8y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-40y)
        Displacement(8y,-16y)
        Displacement(8y,8y)
        Displacement(0y,8y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,8y)
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
    ]
    // б
    42962us, [
        PenUp
        Displacement(87y,111y)
        PenDown
        Displacement(-48y,-24y)
        Displacement(0y,-56y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
    ]
    // в
    42963us, [
        PenUp
        Displacement(48y,95y)
        PenDown
        Displacement(0y,-71y)
        Displacement(32y,0y)
        Displacement(8y,8y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-24y,0y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(16y,16y)
        Displacement(0y,8y)
        Displacement(-8y,8y)
        Displacement(-32y,0y)
    ]
    // г
    42964us, [
        PenUp
        Displacement(40y,24y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,71y)
        Displacement(40y,0y)
        Displacement(0y,-8y)
    ]
    // д
    42965us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(16y,-8y)
        PenDown
        Displacement(0y,8y)
        Displacement(-71y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(8y,8y)
        PenDown
        Displacement(16y,56y)
    ]
    // е
    42966us, [
        PenUp
        Displacement(40y,64y)
        PenDown
        Displacement(56y,0y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-24y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-24y)
        Displacement(16y,-16y)
        Displacement(24y,0y)
        Displacement(16y,16y)
    ]
    // ё
    42967us, [
        PenUp
        Displacement(48y,56y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-24y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-24y)
        Displacement(16y,-16y)
        Displacement(24y,0y)
        Displacement(16y,16y)
        PenUp
        Displacement(-48y,16y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(16y,40y)
        PenDown
        Displacement(8y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(0y,8y)
        Displacement(8y,-8y)
        PenUp
        Displacement(16y,0y)
        PenDown
        Displacement(0y,8y)
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(-8y,8y)
    ]
    // ж
    42968us, [
        PenUp
        Displacement(24y,79y)
        PenDown
        Displacement(8y,8y)
        Displacement(8y,-16y)
        Displacement(8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-8y,-16y)
        Displacement(-8y,0y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,56y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-16y,-32y)
        PenDown
        Displacement(16y,0y)
        Displacement(8y,8y)
        Displacement(8y,16y)
        Displacement(0y,8y)
        Displacement(8y,-8y)
        PenUp
        Displacement(-24y,-24y)
        PenDown
        Displacement(24y,-24y)
        Displacement(8y,0y)
    ]
    // з
    42969us, [
        PenUp
        Displacement(40y,79y)
        PenDown
        Displacement(16y,16y)
        Displacement(16y,0y)
        Displacement(16y,-8y)
        Displacement(0y,-8y)
        Displacement(-24y,-16y)
        Displacement(24y,-16y)
        Displacement(0y,-8y)
        Displacement(-16y,-16y)
        Displacement(-24y,0y)
        Displacement(-16y,16y)
        PenUp
        Displacement(0y,32y)
        PenDown
        Displacement(8y,8y)
    ]
    // и
    42970us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(40y,64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(8y,0y)
        Displacement(8y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // й
    42971us, [
        PenUp
        Displacement(56y,79y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(40y,56y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-16y,64y)
        PenDown
        Displacement(0y,8y)
        Displacement(8y,0y)
        Displacement(0y,-8y)
        Displacement(-8y,0y)
        Displacement(8y,8y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        Displacement(-8y,0y)
        Displacement(0y,-8y)
        Displacement(8y,0y)
        Displacement(0y,8y)
        Displacement(-8y,-8y)
    ]
    // к
    42972us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(40y,0y)
        PenDown
        Displacement(-8y,0y)
        Displacement(-32y,40y)
        Displacement(32y,24y)
        Displacement(8y,-8y)
    ]
    // л
    42973us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-64y,8y)
        PenDown
        Displacement(8y,-8y)
        Displacement(8y,0y)
        Displacement(16y,64y)
    ]
    // м
    42974us, [
        PenUp
        Displacement(24y,32y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,56y)
        Displacement(32y,-48y)
        Displacement(32y,48y)
        Displacement(0y,-56y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // н
    42975us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(24y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,-32y)
        PenDown
        Displacement(-40y,0y)
    ]
    // о
    42976us, [
        PenUp
        Displacement(40y,79y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
    ]
    // п
    42977us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(64y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,64y)
    ]
    // р
    42978us, [
        PenUp
        Displacement(40y,24y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,71y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(16y,8y)
        Displacement(16y,0y)
        Displacement(8y,-8y)
        Displacement(0y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,0y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
    ]
    // с
    42979us, [
        PenUp
        Displacement(87y,79y)
        PenDown
        Displacement(-8y,16y)
        Displacement(-24y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
    ]
    // т
    42980us, [
        PenUp
        Displacement(32y,87y)
        PenDown
        Displacement(0y,8y)
        Displacement(64y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(-32y,8y)
        PenDown
        Displacement(0y,-71y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // у
    42981us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(24y,-48y)
        PenUp
        Displacement(16y,48y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(-16y,-40y)
        Displacement(-32y,-32y)
        Displacement(-8y,8y)
    ]
    // ф
    42982us, [
        PenUp
        Displacement(48y,103y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-87y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,32y)
        PenDown
        Displacement(-16y,0y)
        Displacement(-16y,8y)
        Displacement(0y,8y)
        Displacement(16y,8y)
        Displacement(32y,0y)
        Displacement(16y,-8y)
        Displacement(0y,-8y)
        Displacement(-16y,-8y)
        Displacement(-16y,0y)
    ]
    // х
    42983us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(48y,-71y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(0y,71y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-48y,-71y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ц
    42984us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(64y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(-16y,8y)
        PenDown
        Displacement(0y,64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ч
    42985us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-32y)
        Displacement(8y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        Displacement(0y,32y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-71y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ш
    42986us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-32y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-64y)
    ]
    // щ
    42987us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-64y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(79y,0y)
        Displacement(0y,-8y)
        PenUp
        Displacement(-8y,8y)
        PenDown
        Displacement(0y,64y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,-64y)
    ]
    // ъ
    42988us, [
        PenUp
        Displacement(24y,87y)
        PenDown
        Displacement(0y,8y)
        Displacement(24y,0y)
        Displacement(0y,-71y)
        Displacement(24y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,8y)
        Displacement(-24y,0y)
    ]
    // ы
    42989us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-71y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,8y)
        Displacement(-16y,0y)
        PenUp
        Displacement(56y,-40y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,71y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
    ]
    // ь
    42990us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-71y)
        Displacement(24y,0y)
        Displacement(16y,16y)
        Displacement(0y,8y)
        Displacement(-8y,16y)
        Displacement(-24y,0y)
        Displacement(-8y,-8y)
    ]
    // э
    42991us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(8y,8y)
        Displacement(24y,0y)
        Displacement(24y,-24y)
        Displacement(0y,-32y)
        Displacement(-24y,-16y)
        Displacement(-24y,0y)
        Displacement(-16y,16y)
        PenUp
        Displacement(24y,24y)
        PenDown
        Displacement(40y,0y)
    ]
    // ю
    42992us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(0y,-71y)
        PenUp
        Displacement(-8y,0y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-8y,40y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(0y,-24y)
        PenDown
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,40y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-40y)
    ]
    // я
    42993us, [
        PenUp
        Displacement(87y,24y)
        PenDown
        Displacement(-16y,0y)
        PenUp
        Displacement(8y,0y)
        PenDown
        Displacement(0y,71y)
        Displacement(-32y,0y)
        Displacement(-8y,-8y)
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(24y,0y)
        PenUp
        Displacement(-24y,0y)
        PenDown
        Displacement(-8y,-24y)
        Displacement(-8y,-8y)
        Displacement(-8y,0y)
        Displacement(-8y,8y)
    ]
    // ā
    43169us, [
        PenUp
        Displacement(79y,24y)
        PenDown
        Displacement(0y,48y)
        Displacement(-24y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        PenUp
        Displacement(0y,56y)
        PenDown
        Displacement(-48y,0y)
    ]
    // á
    43170us, [
        PenUp
        Displacement(79y,24y)
        PenDown
        Displacement(0y,48y)
        Displacement(-24y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        PenUp
        Displacement(-32y,48y)
        PenDown
        Displacement(24y,16y)
    ]
    // ǎ
    43171us, [
        PenUp
        Displacement(79y,24y)
        PenDown
        Displacement(0y,48y)
        Displacement(-24y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        PenUp
        Displacement(-40y,64y)
        PenDown
        Displacement(16y,-16y)
        Displacement(16y,16y)
    ]
    // à
    43172us, [
        PenUp
        Displacement(79y,24y)
        PenDown
        Displacement(0y,48y)
        Displacement(-24y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-8y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(16y,0y)
        Displacement(8y,8y)
        PenUp
        Displacement(-8y,48y)
        PenDown
        Displacement(-24y,8y)
    ]
    // ē
    43173us, [
        PenUp
        Displacement(32y,48y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(0y,56y)
        PenDown
        Displacement(-48y,0y)
    ]
    // é
    43174us, [
        PenUp
        Displacement(32y,48y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(-8y,64y)
        PenDown
        Displacement(-32y,-16y)
    ]
    // ě
    43175us, [
        PenUp
        Displacement(32y,48y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(-8y,64y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(-16y,16y)
    ]
    // è
    43176us, [
        PenUp
        Displacement(32y,48y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(-8y,48y)
        PenDown
        Displacement(-32y,16y)
    ]
    // ī
    43177us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-16y,-16y)
        PenDown
        Displacement(0y,-48y)
    ]
    // í
    43178us, [
        PenUp
        Displacement(40y,79y)
        PenDown
        Displacement(32y,16y)
        PenUp
        Displacement(-16y,-24y)
        PenDown
        Displacement(0y,-48y)
    ]
    // ǐ
    43179us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(16y,-16y)
        Displacement(16y,16y)
        PenUp
        Displacement(-16y,-24y)
        PenDown
        Displacement(0y,-48y)
    ]
    // ì
    43180us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(32y,-16y)
        PenUp
        Displacement(-16y,-8y)
        PenDown
        Displacement(0y,-48y)
    ]
    // ō
    43181us, [
        PenUp
        Displacement(48y,71y)
        PenDown
        Displacement(16y,0y)
        Displacement(16y,-16y)
        Displacement(0y,-16y)
        Displacement(-16y,-16y)
        Displacement(-16y,0y)
        Displacement(-16y,16y)
        Displacement(0y,16y)
        Displacement(16y,16y)
        PenUp
        Displacement(-8y,16y)
        PenDown
        Displacement(32y,0y)
    ]
    // ó
    43182us, [
        PenUp
        Displacement(48y,71y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        PenUp
        Displacement(-8y,8y)
        PenDown
        Displacement(32y,16y)
    ]
    // ǒ
    43183us, [
        PenUp
        Displacement(48y,71y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        PenUp
        Displacement(-8y,24y)
        PenDown
        Displacement(16y,-16y)
        Displacement(16y,16y)
    ]
    // ò
    43184us, [
        PenUp
        Displacement(48y,71y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,16y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        PenUp
        Displacement(24y,8y)
        PenDown
        Displacement(-32y,16y)
    ]
    // ū
    43185us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(-40y,-16y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(0y,-48y)
    ]
    // ú
    43186us, [
        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(0y,-48y)
        PenUp
        Displacement(-40y,56y)
        PenDown
        Displacement(32y,16y)
    ]
    // ǔ
    43187us, [
        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(0y,-48y)
        PenUp
        Displacement(-8y,71y)
        PenDown
        Displacement(-16y,-16y)
        Displacement(-16y,16y)
    ]
    // ù
    43188us, [
        PenUp
        Displacement(32y,71y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(0y,-48y)
        PenUp
        Displacement(-8y,56y)
        PenDown
        Displacement(-32y,16y)
    ]
    // ǖ
    43189us, [
        PenUp
        Displacement(40y,95y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Displacement(0y,-16y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(0y,-48y)
    ]
    // ǘ
    43190us, [
        PenUp
        Displacement(40y,87y)
        PenDown
        Displacement(32y,16y)
        PenUp
        Displacement(0y,-24y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(0y,-48y)
    ]
    // ǚ
    43191us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(16y,-16y)
        Displacement(16y,16y)
        PenUp
        Displacement(0y,-24y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(0y,-48y)
    ]
    // ǜ
    43192us, [
        PenUp
        Displacement(40y,103y)
        PenDown
        Displacement(32y,-16y)
        PenUp
        Displacement(0y,-8y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(0y,-48y)
    ]
    // ü
    43193us, [
        PenUp
        Displacement(71y,79y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(-8y,0y)
        PenUp
        Displacement(-8y,-8y)
        PenDown
        Displacement(0y,-32y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,16y)
        Displacement(0y,32y)
        Displacement(0y,-48y)
    ]
    // ê
    43194us, [
        PenUp
        Displacement(32y,48y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,8y)
        Displacement(-16y,16y)
        Displacement(-16y,0y)
        Displacement(-16y,-16y)
        Displacement(0y,-16y)
        Displacement(16y,-16y)
        Displacement(16y,0y)
        Displacement(16y,8y)
        PenUp
        Displacement(-8y,48y)
        PenDown
        Displacement(-16y,16y)
        Displacement(-16y,-16y)
    ]
    // ㄅ
    43205us, [
        PenUp
        Displacement(40y,111y)
        PenDown
        Displacement(-24y,-32y)
        Displacement(79y,0y)
        Displacement(-8y,-32y)
        Displacement(-8y,-24y)
        Displacement(-8y,-8y)
        Displacement(-16y,8y)
    ]
    // ㄆ
    43206us, [
        PenUp
        Displacement(40y,111y)
        PenDown
        Displacement(-16y,-32y)
        Displacement(71y,0y)
        Displacement(-16y,-32y)
        Displacement(-16y,-16y)
        Displacement(-24y,-16y)
        Displacement(-24y,-8y)
        PenUp
        Displacement(32y,40y)
        PenDown
        Displacement(32y,-32y)
    ]
    // ㄇ
    43207us, [
        PenUp
        Displacement(24y,16y)
        PenDown
        Displacement(-8y,71y)
        Displacement(79y,0y)
        Displacement(-8y,-71y)
    ]
    // ㄈ
    43208us, [
        PenUp
        Displacement(95y,95y)
        PenDown
        Displacement(-79y,0y)
        Displacement(0y,-64y)
        Displacement(8y,-16y)
        Displacement(16y,-8y)
        Displacement(64y,0y)
    ]
    // ㄉ
    43209us, [
        PenUp
        Displacement(48y,111y)
        PenDown
        Displacement(-24y,-32y)
        Displacement(71y,0y)
        Displacement(-8y,-32y)
        Displacement(-8y,-24y)
        Displacement(-8y,-8y)
        Displacement(-16y,8y)
        PenUp
        Displacement(-8y,56y)
        PenDown
        Displacement(-8y,-24y)
        Displacement(-16y,-24y)
        Displacement(-16y,-16y)
    ]
    // ㄊ
    43210us, [
        PenUp
        Displacement(16y,87y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-40y,24y)
        PenDown
        Displacement(0y,-24y)
        Displacement(-16y,-32y)
        Displacement(-24y,-32y)
        Displacement(71y,0y)
        PenUp
        Displacement(-16y,16y)
        PenDown
        Displacement(24y,-24y)
    ]
    // ㄋ
    43211us, [
        PenUp
        Displacement(16y,103y)
        PenDown
        Displacement(56y,0y)
        Displacement(-16y,-32y)
        Displacement(40y,0y)
        Displacement(-8y,-32y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,8y)
    ]
    // ㄌ
    43212us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(-16y,-32y)
        Displacement(79y,0y)
        Displacement(-8y,-32y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,8y)
        PenUp
        Displacement(8y,87y)
        PenDown
        Displacement(-8y,-40y)
        Displacement(-16y,-32y)
        Displacement(-16y,-16y)
        Displacement(-16y,-8y)
    ]
    // ㄍ
    43213us, [
        PenUp
        Displacement(40y,111y)
        PenDown
        Displacement(-24y,-48y)
        Displacement(24y,-48y)
        PenUp
        Displacement(56y,0y)
        PenDown
        Displacement(-24y,48y)
        Displacement(24y,48y)
    ]
    // ㄎ
    43214us, [
        PenUp
        Displacement(16y,103y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-40y,0y)
        PenDown
        Displacement(-24y,-40y)
        Displacement(56y,0y)
        Displacement(-16y,-40y)
        Displacement(-8y,-8y)
        Displacement(-16y,8y)
    ]
    // ㄏ
    43215us, [
        PenUp
        Displacement(95y,103y)
        PenDown
        Displacement(-71y,0y)
        Displacement(8y,0y)
        Displacement(-8y,-56y)
        Displacement(-8y,-32y)
    ]
    // ㄐ
    43216us, [
        PenUp
        Displacement(32y,95y)
        PenDown
        Displacement(-16y,-48y)
        Displacement(64y,8y)
        PenUp
        Displacement(0y,56y)
        PenDown
        Displacement(0y,-95y)
    ]
    // ㄑ
    43217us, [
        PenUp
        Displacement(64y,111y)
        PenDown
        Displacement(-24y,-48y)
        Displacement(24y,-48y)
    ]
    // ㄒ
    43218us, [
        PenUp
        Displacement(16y,103y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-40y,0y)
        PenDown
        Displacement(0y,-87y)
    ]
    // ㄓ
    43219us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(0y,-48y)
        Displacement(64y,0y)
        Displacement(0y,48y)
        PenUp
        Displacement(-32y,16y)
        PenDown
        Displacement(0y,-95y)
        PenUp
        Displacement(-40y,0y)
        PenDown
        Displacement(79y,0y)
    ]
    // ㄔ
    43220us, [
        PenUp
        Displacement(71y,111y)
        PenDown
        Displacement(-40y,-32y)
        PenUp
        Displacement(40y,-8y)
        PenDown
        Displacement(-40y,-32y)
        PenUp
        Displacement(24y,16y)
        PenDown
        Displacement(0y,-40y)
    ]
    // ㄕ
    43221us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(48y,0y)
        Displacement(0y,-24y)
        Displacement(-48y,0y)
        Displacement(0y,-24y)
        Displacement(-8y,-24y)
        Displacement(-8y,-16y)
    ]
    // ㄖ
    43222us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(0y,-87y)
        Displacement(0y,8y)
        Displacement(64y,0y)
        Displacement(0y,-8y)
        Displacement(0y,87y)
        Displacement(-64y,0y)
        PenUp
        Displacement(16y,-24y)
        PenDown
        Displacement(32y,-32y)
    ]
    // ㄗ
    43223us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(56y,0y)
        Displacement(-8y,-32y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
        Displacement(-16y,8y)
        PenUp
        Displacement(-8y,48y)
        PenDown
        Displacement(0y,-87y)
    ]
    // ㄘ
    43224us, [
        PenUp
        Displacement(16y,87y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-48y,24y)
        PenDown
        Displacement(-16y,-48y)
        Displacement(56y,0y)
        Displacement(-8y,-32y)
        Displacement(-8y,-16y)
        Displacement(-16y,8y)
    ]
    // ㄙ
    43225us, [
        PenUp
        Displacement(56y,111y)
        PenDown
        Displacement(-24y,-71y)
        Displacement(-16y,-24y)
        Displacement(71y,8y)
        PenUp
        Displacement(-16y,16y)
        PenDown
        Displacement(24y,-24y)
    ]
    // ㄚ
    43226us, [
        PenUp
        Displacement(24y,111y)
        PenDown
        Displacement(32y,-32y)
        Displacement(32y,32y)
        Displacement(-32y,-32y)
        Displacement(0y,-64y)
    ]
    // ㄛ
    43227us, [
        PenUp
        Displacement(16y,103y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-40y,0y)
        PenDown
        Displacement(0y,-24y)
        Displacement(-16y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-16y)
        Displacement(0y,-16y)
        Displacement(8y,-16y)
        Displacement(16y,-8y)
        Displacement(32y,0y)
        Displacement(16y,8y)
    ]
    // ㄜ
    43228us, [
        PenUp
        Displacement(16y,95y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-40y,24y)
        PenDown
        Displacement(0y,-48y)
        Displacement(-16y,0y)
        Displacement(-16y,-8y)
        Displacement(-8y,-16y)
        Displacement(0y,-16y)
        Displacement(8y,-8y)
        Displacement(16y,-8y)
        Displacement(32y,0y)
        Displacement(16y,8y)
    ]
    // ㄝ
    43229us, [
        PenUp
        Displacement(16y,64y)
        PenDown
        Displacement(79y,8y)
        PenUp
        Displacement(-24y,40y)
        PenDown
        Displacement(0y,-48y)
        Displacement(-8y,-24y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(-24y,79y)
        PenDown
        Displacement(0y,-71y)
        Displacement(8y,-16y)
        Displacement(16y,-8y)
        Displacement(40y,0y)
    ]
    // ㄞ
    43230us, [
        PenUp
        Displacement(95y,111y)
        PenDown
        Displacement(-79y,0y)
        Displacement(8y,0y)
        Displacement(-8y,-32y)
        Displacement(79y,0y)
        Displacement(-8y,-32y)
        Displacement(-8y,-24y)
        Displacement(-8y,-8y)
        Displacement(-16y,8y)
        PenUp
        Displacement(0y,87y)
        PenDown
        Displacement(-8y,-48y)
        Displacement(-16y,-32y)
        Displacement(-16y,-16y)
    ]
    // ㄟ
    43231us, [
        PenUp
        Displacement(32y,103y)
        PenDown
        Displacement(24y,0y)
        Displacement(0y,-16y)
        Displacement(8y,-32y)
        Displacement(8y,-16y)
        Displacement(24y,-24y)
    ]
    // ㄠ
    43232us, [
        PenUp
        Displacement(56y,111y)
        PenDown
        Displacement(-40y,-48y)
        Displacement(56y,0y)
        PenUp
        Displacement(16y,16y)
        PenDown
        Displacement(-71y,-56y)
        Displacement(71y,0y)
        PenUp
        Displacement(-16y,16y)
        PenDown
        Displacement(24y,-24y)
    ]
    // ㄡ
    43233us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(64y,0y)
        Displacement(-8y,-24y)
        Displacement(-24y,-32y)
        Displacement(-16y,-16y)
        Displacement(-24y,-16y)
        PenUp
        Displacement(24y,56y)
        PenDown
        Displacement(40y,-40y)
    ]
    // ㄢ
    43234us, [
        PenUp
        Displacement(24y,103y)
        PenDown
        Displacement(64y,0y)
        Displacement(-8y,-32y)
        PenUp
        Displacement(-48y,32y)
        PenDown
        Displacement(-8y,-32y)
        Displacement(71y,0y)
        Displacement(-8y,-32y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
    ]
    // ㄣ
    43235us, [
        PenUp
        Displacement(32y,111y)
        PenDown
        Displacement(-8y,-40y)
        Displacement(71y,0y)
        Displacement(-8y,-32y)
        Displacement(-8y,-16y)
        Displacement(-8y,-8y)
    ]
    // ㄤ
    43236us, [
        PenUp
        Displacement(16y,79y)
        PenDown
        Displacement(79y,0y)
        PenUp
        Displacement(-40y,32y)
        PenDown
        Displacement(-8y,-48y)
        Displacement(-8y,-24y)
        Displacement(-24y,-24y)
        PenUp
        Displacement(48y,64y)
        PenDown
        Displacement(0y,-56y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
    ]
    // ㄥ
    43237us, [
        PenUp
        Displacement(56y,111y)
        PenDown
        Displacement(-16y,-56y)
        Displacement(-24y,-40y)
        Displacement(79y,0y)
    ]
    // ㄦ
    43238us, [
        PenUp
        Displacement(40y,111y)
        PenDown
        Displacement(0y,-40y)
        Displacement(-8y,-32y)
        Displacement(-16y,-24y)
        PenUp
        Displacement(48y,95y)
        PenDown
        Displacement(0y,-87y)
        Displacement(8y,-8y)
        Displacement(24y,0y)
        Displacement(0y,8y)
    ]
    // ㄧ
    43239us, [
        PenUp
        Displacement(56y,111y)
        PenDown
        Displacement(0y,-95y)
    ]
    // ㄨ
    43240us, [
        PenUp
        Displacement(87y,111y)
        PenDown
        Displacement(-16y,-48y)
        Displacement(-24y,-32y)
        Displacement(-32y,-16y)
        PenUp
        Displacement(16y,79y)
        PenDown
        Displacement(32y,-40y)
        Displacement(24y,-40y)
    ]
    // ㄩ
    43241us, [
        PenUp
        Displacement(24y,95y)
        PenDown
        Displacement(-8y,-71y)
        Displacement(71y,0y)
        Displacement(0y,-8y)
        Displacement(0y,87y)
    ]
    ]

//let chin2 =
//    let dict = Dictionary<uint16,Specification list>()
//    // 　
//    dict.[41377us] <- [
//    ]
//    // 、
//    dict.[41378us] <- [
//        PenUp
//        Displacement(17y,24y)
//        PenDown
//        Displacement(8y,-5y)
//        Displacement(6y,-8y)
//        Displacement(3y,-8y)
//        PenUp
//        Displacement(-30y,26y)
//        PenDown
//        Displacement(11y,0y)
//        Displacement(6y,-1y)
//        Displacement(10y,-5y)
//        Displacement(4y,-3y)
//        Displacement(2y,-5y)
//        Displacement(1y,-6y)
//        Displacement(-2y,-5y)
//        Displacement(-4y,-2y)
//        Displacement(-5y,1y)
//        Displacement(-3y,3y)
//        Displacement(-5y,10y)
//        Displacement(-7y,6y)
//        Displacement(-9y,4y)
//        Displacement(-1y,2y)
//        Displacement(2y,1y)
//    ]
//    // 。
//    dict.[41379us] <- [
//        PenUp
//        Displacement(18y,2y)
//        PenDown
//        Displacement(2y,0y)
//        Displacement(3y,1y)
//        Displacement(2y,1y)
//        Displacement(2y,1y)
//        Displacement(4y,4y)
//        Displacement(2y,4y)
//        Displacement(1y,5y)
//        Displacement(-1y,5y)
//        Displacement(-2y,4y)
//        Displacement(-4y,4y)
//        Displacement(-2y,1y)
//        Displacement(-2y,1y)
//        Displacement(-3y,1y)
//        Displacement(-2y,0y)
//        Displacement(-2y,0y)
//        Displacement(-3y,-1y)
//        Displacement(-2y,-1y)
//        Displacement(-2y,-1y)
//        Displacement(-4y,-4y)
//        Displacement(-2y,-4y)
//        Displacement(-1y,-5y)
//        Displacement(1y,-5y)
//        Displacement(2y,-4y)
//        Displacement(4y,-4y)
//        Displacement(2y,-1y)
//        Displacement(2y,-1y)
//        Displacement(3y,-1y)
//        Displacement(2y,0y)
//    ]
//    // ·
//    dict.[41380us] <- [
//        PenUp
//        Displacement(72y,50y)
//        PenDown
//        Displacement(-18y,0y)
//        PenUp
//        Displacement(-4y,4y)
//        PenDown
//        Displacement(26y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(-30y,0y)
//        PenUp
//        Displacement(31y,5y)
//        PenDown
//        Displacement(-32y,0y)
//        PenUp
//        Displacement(1y,5y)
//        PenDown
//        Displacement(30y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(-26y,0y)
//        PenUp
//        Displacement(4y,4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(-9y,-29y)
//        PenDown
//        Displacement(2y,0y)
//        Displacement(3y,1y)
//        Displacement(2y,1y)
//        Displacement(2y,1y)
//        Displacement(4y,4y)
//        Displacement(2y,4y)
//        Displacement(1y,5y)
//        Displacement(-1y,5y)
//        Displacement(-2y,4y)
//        Displacement(-4y,4y)
//        Displacement(-2y,1y)
//        Displacement(-2y,1y)
//        Displacement(-3y,1y)
//        Displacement(-2y,0y)
//        Displacement(-2y,0y)
//        Displacement(-3y,-1y)
//        Displacement(-2y,-1y)
//        Displacement(-2y,-1y)
//        Displacement(-4y,-4y)
//        Displacement(-2y,-4y)
//        Displacement(-1y,-5y)
//        Displacement(1y,-5y)
//        Displacement(2y,-4y)
//        Displacement(4y,-4y)
//        Displacement(2y,-1y)
//        Displacement(2y,-1y)
//        Displacement(3y,-1y)
//        Displacement(2y,0y)
//    ]
//    // ˉ
//    dict.[41381us] <- [
//        PenUp
//        Displacement(48y,120y)
//        PenDown
//        Displacement(32y,0y)
//    ]
//    // ˇ
//    dict.[41382us] <- [
//        PenUp
//        Displacement(34y,124y)
//        PenDown
//        Displacement(30y,-20y)
//        Displacement(30y,20y)
//    ]
//    // ¨
//    dict.[41383us] <- [
//        PenUp
//        Displacement(28y,116y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(52y,0y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(17y,7y)
//        PenDown
//        Displacement(-14y,0y)
//        PenUp
//        Displacement(-2y,-4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(1y,-3y)
//        PenDown
//        Displacement(-20y,0y)
//        PenUp
//        Displacement(1y,-3y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(-2y,-4y)
//        PenDown
//        Displacement(-14y,0y)
//        PenUp
//        Displacement(-38y,0y)
//        PenDown
//        Displacement(-14y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(1y,3y)
//        PenDown
//        Displacement(-20y,0y)
//        PenUp
//        Displacement(1y,3y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(-14y,0y)
//    ]
//    // 〃
//    dict.[41384us] <- [
//        PenUp
//        Displacement(36y,35y)
//        PenDown
//        Displacement(20y,45y)
//        Displacement(-10y,3y)
//        Displacement(-10y,-48y)
//        PenUp
//        Displacement(36y,0y)
//        PenDown
//        Displacement(20y,45y)
//        Displacement(-10y,3y)
//        Displacement(-10y,-48y)
//        PenUp
//        Displacement(-30y,19y)
//        PenDown
//        Displacement(9y,27y)
//        PenUp
//        Displacement(36y,0y)
//        PenDown
//        Displacement(-9y,-27y)
//    ]
//    // 々
//    dict.[41385us] <- [
//        PenUp
//        Displacement(59y,105y)
//        PenDown
//        Displacement(2y,-9y)
//        Displacement(-13y,-17y)
//        Displacement(-8y,-8y)
//        Displacement(-10y,-9y)
//        PenUp
//        Displacement(13y,12y)
//        PenDown
//        Displacement(47y,0y)
//        PenUp
//        Displacement(7y,5y)
//        PenDown
//        Displacement(-7y,-5y)
//        Displacement(-31y,-40y)
//        PenUp
//        Displacement(-12y,11y)
//        PenDown
//        Displacement(8y,-7y)
//        Displacement(8y,-9y)
//        Displacement(3y,-7y)
//    ]
//    // —
//    dict.[41386us] <- [
//        PenUp
//        Displacement(1y,64y)
//        PenDown
//        Displacement(126y,0y)
//    ]
//    // ～
//    dict.[41387us] <- [
//        PenUp
//        Displacement(17y,56y)
//        PenDown
//        Displacement(10y,6y)
//        Displacement(9y,4y)
//        Displacement(9y,2y)
//        Displacement(4y,0y)
//        Displacement(7y,-2y)
//        Displacement(18y,-6y)
//        Displacement(5y,-1y)
//        Displacement(4y,0y)
//        Displacement(9y,2y)
//        Displacement(9y,4y)
//        Displacement(8y,6y)
//    ]
//    // ‖
//    dict.[41388us] <- [
//        PenUp
//        Displacement(49y,109y)
//        PenDown
//        Displacement(0y,-90y)
//        PenUp
//        Displacement(30y,0y)
//        PenDown
//        Displacement(0y,90y)
//    ]
//    // …
//    dict.[41389us] <- [
//        PenUp
//        Displacement(11y,64y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(43y,0y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(43y,0y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(-83y,-6y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(-18y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(-14y,0y)
//        PenUp
//        Displacement(57y,0y)
//        PenDown
//        Displacement(-14y,0y)
//        PenUp
//        Displacement(-2y,-4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(0y,-4y)
//        PenDown
//        Displacement(-18y,0y)
//        PenUp
//        Displacement(2y,-4y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(29y,0y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(0y,12y)
//        PenDown
//        Displacement(-14y,0y)
//        PenUp
//        Displacement(-2y,-4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(0y,-4y)
//        PenDown
//        Displacement(-18y,0y)
//    ]
//    // ‘
//    dict.[41390us] <- [
//        PenUp
//        Displacement(86y,101y)
//        PenDown
//        Displacement(0y,-6y)
//        PenUp
//        Displacement(12y,26y)
//        PenDown
//        Displacement(-7y,-13y)
//        PenUp
//        Displacement(11y,-17y)
//        PenDown
//        Displacement(0y,12y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(-4y,-1y)
//        PenDown
//        Displacement(0y,17y)
//        PenUp
//        Displacement(-4y,-16y)
//        PenDown
//        Displacement(0y,22y)
//        PenUp
//        Displacement(10y,14y)
//        PenDown
//        Displacement(-11y,-15y)
//        Displacement(-2y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(1y,-4y)
//        Displacement(4y,-5y)
//        Displacement(4y,-1y)
//        Displacement(2y,0y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(1y,3y)
//        Displacement(0y,6y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-6y,1y)
//        Displacement(2y,7y)
//        Displacement(2y,4y)
//        Displacement(2y,4y)
//        Displacement(1y,4y)
//    ]
//    // ’
//    dict.[41391us] <- [
//        PenUp
//        Displacement(27y,89y)
//        PenDown
//        Displacement(12y,14y)
//        Displacement(2y,4y)
//        Displacement(1y,3y)
//        Displacement(1y,4y)
//        Displacement(0y,4y)
//        Displacement(-4y,6y)
//        Displacement(-4y,1y)
//        Displacement(-2y,0y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-1y)
//        Displacement(-2y,-4y)
//        Displacement(0y,-5y)
//        Displacement(2y,-3y)
//        Displacement(3y,-3y)
//        Displacement(6y,-1y)
//        Displacement(-3y,-7y)
//        Displacement(-2y,-4y)
//        Displacement(-1y,-2y)
//        Displacement(-2y,-5y)
//        PenUp
//        Displacement(1y,20y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(4y,1y)
//        PenDown
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(4y,16y)
//        PenDown
//        Displacement(0y,-24y)
//        PenUp
//        Displacement(4y,5y)
//        PenDown
//        Displacement(0y,17y)
//        PenUp
//        Displacement(-10y,-28y)
//        PenDown
//        Displacement(8y,13y)
//    ]
//    // “
//    dict.[41392us] <- [
//        PenUp
//        Displacement(83y,126y)
//        PenDown
//        Displacement(-11y,-15y)
//        Displacement(-2y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(1y,-4y)
//        Displacement(4y,-5y)
//        Displacement(4y,-1y)
//        Displacement(2y,0y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(1y,3y)
//        Displacement(0y,6y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-6y,1y)
//        Displacement(2y,7y)
//        Displacement(2y,4y)
//        Displacement(2y,4y)
//        Displacement(1y,4y)
//        PenUp
//        Displacement(-11y,-34y)
//        PenDown
//        Displacement(0y,19y)
//        PenUp
//        Displacement(4y,5y)
//        PenDown
//        Displacement(0y,-26y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,16y)
//        PenUp
//        Displacement(4y,-2y)
//        PenDown
//        Displacement(0y,-13y)
//        PenUp
//        Displacement(-3y,31y)
//        PenDown
//        Displacement(-4y,-7y)
//        PenUp
//        Displacement(30y,7y)
//        PenDown
//        Displacement(-4y,-7y)
//        PenUp
//        Displacement(-5y,-23y)
//        PenDown
//        Displacement(0y,19y)
//        PenUp
//        Displacement(4y,5y)
//        PenDown
//        Displacement(0y,-26y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,16y)
//        PenUp
//        Displacement(4y,-2y)
//        PenDown
//        Displacement(0y,-13y)
//        PenUp
//        Displacement(-1y,35y)
//        PenDown
//        Displacement(-11y,-15y)
//        Displacement(-2y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(1y,-4y)
//        Displacement(4y,-5y)
//        Displacement(4y,-1y)
//        Displacement(2y,0y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(1y,3y)
//        Displacement(0y,6y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-6y,1y)
//        Displacement(2y,7y)
//        Displacement(2y,4y)
//        Displacement(2y,4y)
//        Displacement(1y,4y)
//    ]
//    // ”
//    dict.[41393us] <- [
//        PenUp
//        Displacement(46y,89y)
//        PenDown
//        Displacement(12y,14y)
//        Displacement(2y,4y)
//        Displacement(1y,3y)
//        Displacement(1y,4y)
//        Displacement(0y,4y)
//        Displacement(-4y,6y)
//        Displacement(-4y,1y)
//        Displacement(-2y,0y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-1y)
//        Displacement(-2y,-4y)
//        Displacement(0y,-5y)
//        Displacement(2y,-3y)
//        Displacement(3y,-3y)
//        Displacement(6y,-1y)
//        Displacement(-3y,-7y)
//        Displacement(-2y,-4y)
//        Displacement(-1y,-2y)
//        Displacement(-2y,-5y)
//        PenUp
//        Displacement(-28y,0y)
//        PenDown
//        Displacement(12y,14y)
//        Displacement(2y,4y)
//        Displacement(1y,3y)
//        Displacement(1y,4y)
//        Displacement(0y,4y)
//        Displacement(-4y,6y)
//        Displacement(-4y,1y)
//        Displacement(-2y,0y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-1y)
//        Displacement(-2y,-4y)
//        Displacement(0y,-5y)
//        Displacement(2y,-3y)
//        Displacement(3y,-3y)
//        Displacement(6y,-1y)
//        Displacement(-3y,-7y)
//        Displacement(-2y,-4y)
//        Displacement(-1y,-2y)
//        Displacement(-2y,-5y)
//        PenUp
//        Displacement(1y,20y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(4y,1y)
//        PenDown
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(4y,-8y)
//        PenDown
//        Displacement(0y,24y)
//        PenUp
//        Displacement(4y,-2y)
//        PenDown
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(-8y,-9y)
//        PenDown
//        Displacement(4y,6y)
//        PenUp
//        Displacement(24y,-6y)
//        PenDown
//        Displacement(4y,6y)
//        PenUp
//        Displacement(0y,-3y)
//        PenDown
//        Displacement(0y,24y)
//        PenUp
//        Displacement(-8y,-15y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(4y,1y)
//        PenDown
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(8y,14y)
//        PenDown
//        Displacement(0y,-16y)
//    ]
//    // 〔
//    dict.[41394us] <- [
//        PenUp
//        Displacement(118y,118y)
//        PenDown
//        Displacement(-39y,-20y)
//        Displacement(0y,-68y)
//        Displacement(39y,-20y)
//    ]
//    // 〕
//    dict.[41395us] <- [
//        PenUp
//        Displacement(10y,118y)
//        PenDown
//        Displacement(39y,-20y)
//        Displacement(0y,-68y)
//        Displacement(-39y,-20y)
//    ]
//    // 〈
//    dict.[41396us] <- [
//        PenUp
//        Displacement(112y,111y)
//        PenDown
//        Displacement(-24y,-47y)
//        Displacement(24y,-50y)
//    ]
//    // 〉
//    dict.[41397us] <- [
//        PenUp
//        Displacement(16y,111y)
//        PenDown
//        Displacement(24y,-47y)
//        Displacement(-24y,-50y)
//    ]
//    // 《
//    dict.[41398us] <- [
//        PenUp
//        Displacement(118y,111y)
//        PenDown
//        Displacement(-26y,-48y)
//        Displacement(26y,-51y)
//        PenUp
//        Displacement(-30y,99y)
//        PenDown
//        Displacement(-26y,-48y)
//        Displacement(26y,-51y)
//    ]
//    // 》
//    dict.[41399us] <- [
//        PenUp
//        Displacement(10y,111y)
//        PenDown
//        Displacement(26y,-48y)
//        Displacement(-26y,-51y)
//        PenUp
//        Displacement(30y,99y)
//        PenDown
//        Displacement(26y,-48y)
//        Displacement(-26y,-51y)
//    ]
//    // 「
//    dict.[41400us] <- [
//        PenUp
//        Displacement(110y,124y)
//        PenDown
//        Displacement(-20y,0y)
//        Displacement(0y,-79y)
//    ]
//    // 」
//    dict.[41401us] <- [
//        PenUp
//        Displacement(15y,4y)
//        PenDown
//        Displacement(20y,0y)
//        Displacement(0y,79y)
//    ]
//    // 『
//    dict.[41402us] <- [
//        PenUp
//        Displacement(87y,48y)
//        PenDown
//        Displacement(0y,76y)
//        Displacement(26y,0y)
//        Displacement(0y,-8y)
//        Displacement(-16y,0y)
//        Displacement(0y,-68y)
//        Displacement(-10y,0y)
//    ]
//    // 』
//    dict.[41403us] <- [
//        PenUp
//        Displacement(15y,4y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(18y,0y)
//        Displacement(0y,68y)
//        Displacement(10y,0y)
//        Displacement(0y,-76y)
//        Displacement(-28y,0y)
//    ]
//    // 〖
//    dict.[41404us] <- [
//        PenUp
//        Displacement(71y,17y)
//        PenDown
//        Displacement(0y,94y)
//        Displacement(42y,0y)
//        Displacement(-11y,-20y)
//        Displacement(-6y,-12y)
//        Displacement(-3y,-8y)
//        Displacement(-1y,-7y)
//        Displacement(2y,-12y)
//        Displacement(4y,-10y)
//        Displacement(6y,-11y)
//        Displacement(9y,-14y)
//        Displacement(-42y,0y)
//    ]
//    // 〗
//    dict.[41405us] <- [
//        PenUp
//        Displacement(57y,17y)
//        PenDown
//        Displacement(0y,94y)
//        Displacement(-42y,0y)
//        Displacement(11y,-20y)
//        Displacement(6y,-12y)
//        Displacement(3y,-8y)
//        Displacement(1y,-7y)
//        Displacement(-2y,-12y)
//        Displacement(-4y,-10y)
//        Displacement(-6y,-11y)
//        Displacement(-9y,-14y)
//        Displacement(42y,0y)
//    ]
//    // 【
//    dict.[41406us] <- [
//        PenUp
//        Displacement(72y,117y)
//        PenDown
//        Displacement(41y,0y)
//        Displacement(-11y,-13y)
//        Displacement(-6y,-10y)
//        Displacement(-6y,-11y)
//        Displacement(-3y,-8y)
//        Displacement(-1y,-7y)
//        Displacement(1y,-8y)
//        Displacement(4y,-12y)
//        Displacement(5y,-11y)
//        Displacement(17y,-25y)
//        Displacement(-41y,0y)
//        Displacement(0y,105y)
//        PenUp
//        Displacement(0y,-101y)
//        PenDown
//        Displacement(38y,0y)
//        PenUp
//        Displacement(-3y,4y)
//        PenDown
//        Displacement(-35y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(-30y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(27y,0y)
//        PenUp
//        Displacement(-27y,4y)
//        PenDown
//        Displacement(24y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(-22y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(21y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(-19y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(17y,0y)
//        PenUp
//        Displacement(-1y,4y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(15y,0y)
//        PenUp
//        Displacement(-1y,4y)
//        PenDown
//        Displacement(-14y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-14y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(15y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(-17y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(-20y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(23y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(-25y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(27y,0y)
//        PenUp
//        Displacement(3y,4y)
//        PenDown
//        Displacement(-30y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(33y,0y)
//        PenUp
//        Displacement(3y,4y)
//        PenDown
//        Displacement(-36y,0y)
//        PenUp
//        Displacement(0y,3y)
//        PenDown
//        Displacement(39y,0y)
//    ]
//    // 】
//    dict.[41407us] <- [
//        PenUp
//        Displacement(56y,117y)
//        PenDown
//        Displacement(-41y,0y)
//        Displacement(11y,-13y)
//        Displacement(6y,-10y)
//        Displacement(6y,-11y)
//        Displacement(3y,-8y)
//        Displacement(1y,-7y)
//        Displacement(-1y,-8y)
//        Displacement(-4y,-12y)
//        Displacement(-5y,-11y)
//        Displacement(-17y,-25y)
//        Displacement(41y,0y)
//        Displacement(0y,105y)
//        PenUp
//        Displacement(0y,-101y)
//        PenDown
//        Displacement(-38y,0y)
//        PenUp
//        Displacement(3y,4y)
//        PenDown
//        Displacement(35y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-32y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(30y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-27y,0y)
//        PenUp
//        Displacement(27y,4y)
//        PenDown
//        Displacement(-24y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(22y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-21y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(19y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-17y,0y)
//        PenUp
//        Displacement(1y,4y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-15y,0y)
//        PenUp
//        Displacement(1y,4y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-14y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-15y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(17y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-18y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(20y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-23y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(25y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-27y,0y)
//        PenUp
//        Displacement(-3y,4y)
//        PenDown
//        Displacement(30y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-33y,0y)
//        PenUp
//        Displacement(-3y,4y)
//        PenDown
//        Displacement(36y,0y)
//        PenUp
//        Displacement(0y,3y)
//        PenDown
//        Displacement(-39y,0y)
//    ]
//    // ±
//    dict.[41408us] <- [
//        PenUp
//        Displacement(20y,68y)
//        PenDown
//        Displacement(86y,0y)
//        PenUp
//        Displacement(-42y,36y)
//        PenDown
//        Displacement(0y,-66y)
//        PenUp
//        Displacement(-44y,-16y)
//        PenDown
//        Displacement(84y,0y)
//    ]
//    // ×
//    dict.[41409us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(78y,-79y)
//        PenUp
//        Displacement(-78y,0y)
//        PenDown
//        Displacement(78y,79y)
//    ]
//    // ÷
//    dict.[41410us] <- [
//        PenUp
//        Displacement(57y,95y)
//        PenDown
//        Displacement(1y,4y)
//        Displacement(2y,2y)
//        Displacement(2y,1y)
//        Displacement(4y,0y)
//        Displacement(2y,-1y)
//        Displacement(2y,-2y)
//        Displacement(1y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(-2y,-2y)
//        Displacement(-2y,-1y)
//        Displacement(-4y,0y)
//        Displacement(-2y,1y)
//        Displacement(-2y,2y)
//        Displacement(-1y,4y)
//        PenUp
//        Displacement(-40y,-31y)
//        PenDown
//        Displacement(90y,0y)
//        PenUp
//        Displacement(-47y,25y)
//        PenDown
//        Displacement(0y,12y)
//        PenUp
//        Displacement(4y,1y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(4y,1y)
//        PenDown
//        Displacement(0y,12y)
//        PenUp
//        Displacement(0y,-74y)
//        PenDown
//        Displacement(0y,12y)
//        PenUp
//        Displacement(-4y,1y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,1y)
//        PenDown
//        Displacement(0y,12y)
//        PenUp
//        Displacement(-3y,-6y)
//        PenDown
//        Displacement(1y,4y)
//        Displacement(2y,2y)
//        Displacement(2y,1y)
//        Displacement(4y,0y)
//        Displacement(2y,-1y)
//        Displacement(2y,-2y)
//        Displacement(1y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(-2y,-2y)
//        Displacement(-2y,-1y)
//        Displacement(-4y,0y)
//        Displacement(-2y,1y)
//        Displacement(-2y,2y)
//        Displacement(-1y,4y)
//    ]
//    // ∶
//    dict.[41411us] <- [
//        PenUp
//        Displacement(54y,32y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(0y,64y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(3y,-6y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(-18y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(-16y,4y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(-14y,-64y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(-16y,-4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(0y,-4y)
//        PenDown
//        Displacement(-18y,0y)
//        PenUp
//        Displacement(2y,-4y)
//        PenDown
//        Displacement(14y,0y)
//    ]
//    // ∧
//    dict.[41412us] <- [
//        PenUp
//        Displacement(15y,13y)
//        PenDown
//        Displacement(49y,102y)
//        Displacement(49y,-102y)
//    ]
//    // ∨
//    dict.[41413us] <- [
//        PenUp
//        Displacement(15y,115y)
//        PenDown
//        Displacement(49y,-102y)
//        Displacement(49y,102y)
//    ]
//    // ∑
//    dict.[41414us] <- [
//        PenUp
//        Displacement(110y,121y)
//        PenDown
//        Displacement(4y,-25y)
//        Displacement(0y,25y)
//        Displacement(-99y,0y)
//        Displacement(55y,-56y)
//        Displacement(-55y,-58y)
//        Displacement(99y,0y)
//        Displacement(0y,27y)
//        Displacement(-4y,-23y)
//        Displacement(-91y,0y)
//        PenUp
//        Displacement(2y,110y)
//        PenDown
//        Displacement(55y,-56y)
//    ]
//    // ∏
//    dict.[41415us] <- [
//        PenUp
//        Displacement(8y,124y)
//        PenDown
//        Displacement(110y,0y)
//        PenUp
//        Displacement(-85y,0y)
//        PenDown
//        Displacement(0y,-121y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,121y)
//        PenUp
//        Displacement(-14y,-121y)
//        PenDown
//        Displacement(24y,0y)
//        PenUp
//        Displacement(33y,0y)
//        PenDown
//        Displacement(24y,0y)
//        PenUp
//        Displacement(-10y,0y)
//        PenDown
//        Displacement(0y,121y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-121y)
//    ]
//    // ∪
//    dict.[41416us] <- [
//        PenUp
//        Displacement(12y,125y)
//        PenDown
//        Displacement(0y,-68y)
//        Displacement(3y,-18y)
//        Displacement(8y,-14y)
//        Displacement(11y,-10y)
//        Displacement(11y,-7y)
//        Displacement(19y,-4y)
//        Displacement(19y,4y)
//        Displacement(11y,7y)
//        Displacement(11y,10y)
//        Displacement(8y,14y)
//        Displacement(3y,18y)
//        Displacement(0y,68y)
//    ]
//    // ∩
//    dict.[41417us] <- [
//        PenUp
//        Displacement(116y,1y)
//        PenDown
//        Displacement(0y,68y)
//        Displacement(-3y,18y)
//        Displacement(-8y,14y)
//        Displacement(-11y,10y)
//        Displacement(-11y,7y)
//        Displacement(-19y,4y)
//        Displacement(-19y,-4y)
//        Displacement(-11y,-7y)
//        Displacement(-11y,-10y)
//        Displacement(-8y,-14y)
//        Displacement(-3y,-18y)
//        Displacement(0y,-68y)
//    ]
//    // ∈
//    dict.[41418us] <- [
//        PenUp
//        Displacement(87y,18y)
//        PenDown
//        Displacement(-12y,2y)
//        Displacement(-12y,4y)
//        Displacement(-8y,6y)
//        Displacement(-8y,10y)
//        Displacement(-4y,10y)
//        Displacement(-2y,14y)
//        Displacement(2y,14y)
//        Displacement(4y,10y)
//        Displacement(8y,10y)
//        Displacement(8y,6y)
//        Displacement(12y,4y)
//        Displacement(12y,2y)
//        PenUp
//        Displacement(-46y,-46y)
//        PenDown
//        Displacement(45y,0y)
//    ]
//    // ∷
//    dict.[41419us] <- [
//        PenUp
//        Displacement(86y,93y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(-64y,0y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(0y,-59y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(-60y,-7y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(4y,2y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(4y,-2y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(0y,73y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(76y,0y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(12y,-59y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//    ]
//    // √
//    dict.[41420us] <- [
//        PenUp
//        Displacement(8y,36y)
//        PenDown
//        Displacement(17y,15y)
//        Displacement(35y,-47y)
//        Displacement(63y,123y)
//    ]
//    // ⊥
//    dict.[41421us] <- [
//        PenUp
//        Displacement(18y,24y)
//        PenDown
//        Displacement(92y,0y)
//        PenUp
//        Displacement(-46y,0y)
//        PenDown
//        Displacement(0y,81y)
//    ]
//    // ∥
//    dict.[41422us] <- [
//        PenUp
//        Displacement(23y,23y)
//        PenDown
//        Displacement(52y,85y)
//        PenUp
//        Displacement(30y,0y)
//        PenDown
//        Displacement(-52y,-85y)
//    ]
//    // ∠
//    dict.[41423us] <- [
//        PenUp
//        Displacement(118y,107y)
//        PenDown
//        Displacement(-85y,-86y)
//        Displacement(86y,0y)
//    ]
//    // ⌒
//    dict.[41424us] <- [
//        PenUp
//        Displacement(103y,108y)
//        PenDown
//        Displacement(-11y,7y)
//        Displacement(-8y,4y)
//        Displacement(-11y,4y)
//        Displacement(-9y,1y)
//        Displacement(-9y,-1y)
//        Displacement(-11y,-4y)
//        Displacement(-8y,-4y)
//        Displacement(-11y,-7y)
//    ]
//    // ⊙
//    dict.[41425us] <- [
//        PenUp
//        Displacement(54y,64y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(-47y,0y)
//        PenDown
//        Displacement(2y,12y)
//        Displacement(4y,12y)
//        Displacement(8y,12y)
//        Displacement(12y,11y)
//        Displacement(16y,7y)
//        Displacement(15y,3y)
//        Displacement(15y,-3y)
//        Displacement(16y,-7y)
//        Displacement(12y,-11y)
//        Displacement(8y,-12y)
//        Displacement(4y,-12y)
//        Displacement(2y,-12y)
//        Displacement(-2y,-12y)
//        Displacement(-4y,-12y)
//        Displacement(-8y,-12y)
//        Displacement(-12y,-11y)
//        Displacement(-16y,-7y)
//        Displacement(-15y,-3y)
//        Displacement(-15y,3y)
//        Displacement(-16y,7y)
//        Displacement(-12y,11y)
//        Displacement(-8y,12y)
//        Displacement(-4y,12y)
//        Displacement(-2y,12y)
//        PenUp
//        Displacement(50y,-6y)
//        PenDown
//        Displacement(14y,0y)
//        PenUp
//        Displacement(2y,4y)
//        PenDown
//        Displacement(-18y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(18y,0y)
//        PenUp
//        Displacement(-2y,4y)
//        PenDown
//        Displacement(-14y,0y)
//    ]
//    // ∫
//    dict.[41426us] <- [
//        PenUp
//        Displacement(109y,122y)
//        PenDown
//        Displacement(-3y,-1y)
//        Displacement(-1y,-3y)
//        Displacement(1y,-3y)
//        Displacement(3y,-1y)
//        Displacement(3y,1y)
//        Displacement(1y,3y)
//        Displacement(-1y,3y)
//        Displacement(-6y,2y)
//        Displacement(-4y,0y)
//        Displacement(-7y,-3y)
//        Displacement(-4y,-7y)
//        Displacement(-3y,-12y)
//        Displacement(-4y,-74y)
//        Displacement(-3y,-12y)
//        Displacement(-4y,-7y)
//        Displacement(-7y,-3y)
//        Displacement(-4y,0y)
//        Displacement(-6y,2y)
//        Displacement(-1y,3y)
//        Displacement(1y,3y)
//        Displacement(3y,1y)
//        Displacement(3y,-1y)
//        Displacement(1y,-3y)
//        Displacement(-1y,-3y)
//        Displacement(-3y,-1y)
//    ]
//    // ∮
//    dict.[41427us] <- [
//        PenUp
//        Displacement(109y,122y)
//        PenDown
//        Displacement(-3y,-1y)
//        Displacement(-1y,-3y)
//        Displacement(1y,-3y)
//        Displacement(3y,-1y)
//        Displacement(3y,1y)
//        Displacement(1y,3y)
//        Displacement(-1y,3y)
//        Displacement(-6y,2y)
//        Displacement(-4y,0y)
//        Displacement(-7y,-3y)
//        Displacement(-4y,-7y)
//        Displacement(-3y,-12y)
//        Displacement(-4y,-74y)
//        Displacement(-3y,-12y)
//        Displacement(-4y,-7y)
//        Displacement(-7y,-3y)
//        Displacement(-4y,0y)
//        Displacement(-6y,2y)
//        Displacement(-1y,3y)
//        Displacement(1y,3y)
//        Displacement(3y,1y)
//        Displacement(3y,-1y)
//        Displacement(1y,-3y)
//        Displacement(-1y,-3y)
//        Displacement(-3y,-1y)
//        PenUp
//        Displacement(24y,71y)
//        PenDown
//        Displacement(-10y,-1y)
//        Displacement(-6y,-3y)
//        Displacement(-3y,-3y)
//        Displacement(-2y,-4y)
//        Displacement(0y,-4y)
//        Displacement(2y,-4y)
//        Displacement(3y,-3y)
//        Displacement(6y,-3y)
//        Displacement(10y,-1y)
//        Displacement(10y,1y)
//        Displacement(6y,3y)
//        Displacement(3y,3y)
//        Displacement(2y,4y)
//        Displacement(0y,4y)
//        Displacement(-2y,4y)
//        Displacement(-3y,3y)
//        Displacement(-6y,3y)
//        Displacement(-10y,1y)
//    ]
//    // ≡
//    dict.[41428us] <- [
//        PenUp
//        Displacement(20y,44y)
//        PenDown
//        Displacement(88y,0y)
//        PenUp
//        Displacement(-88y,20y)
//        PenDown
//        Displacement(88y,0y)
//        PenUp
//        Displacement(-88y,20y)
//        PenDown
//        Displacement(88y,0y)
//    ]
//    // ≌
//    dict.[41429us] <- [
//        PenUp
//        Displacement(17y,29y)
//        PenDown
//        Displacement(98y,0y)
//        PenUp
//        Displacement(-98y,24y)
//        PenDown
//        Displacement(98y,0y)
//        PenUp
//        Displacement(-70y,45y)
//        PenDown
//        Displacement(-5y,0y)
//        Displacement(-5y,-1y)
//        Displacement(-6y,-3y)
//        Displacement(-4y,-4y)
//        Displacement(-3y,-6y)
//        Displacement(0y,-8y)
//        Displacement(3y,-7y)
//        Displacement(4y,-3y)
//        Displacement(7y,-3y)
//        Displacement(7y,0y)
//        Displacement(6y,3y)
//        Displacement(7y,6y)
//        Displacement(20y,17y)
//        Displacement(7y,6y)
//        Displacement(6y,3y)
//        Displacement(7y,0y)
//        Displacement(7y,-3y)
//        Displacement(4y,-3y)
//        Displacement(3y,-7y)
//        Displacement(0y,-8y)
//        Displacement(-3y,-6y)
//        Displacement(-4y,-4y)
//        Displacement(-6y,-3y)
//        Displacement(-5y,-1y)
//        Displacement(-5y,0y)
//    ]
//    // ≈
//    dict.[41430us] <- [
//        PenUp
//        Displacement(16y,69y)
//        PenDown
//        Displacement(10y,11y)
//        Displacement(9y,7y)
//        Displacement(7y,2y)
//        Displacement(7y,-2y)
//        Displacement(28y,-16y)
//        Displacement(7y,-2y)
//        Displacement(7y,2y)
//        Displacement(9y,6y)
//        Displacement(10y,11y)
//        PenUp
//        Displacement(-94y,-48y)
//        PenDown
//        Displacement(10y,11y)
//        Displacement(9y,7y)
//        Displacement(7y,2y)
//        Displacement(7y,-2y)
//        Displacement(28y,-16y)
//        Displacement(7y,-2y)
//        Displacement(7y,2y)
//        Displacement(9y,6y)
//        Displacement(10y,11y)
//    ]
//    // ∽
//    dict.[41431us] <- [
//        PenUp
//        Displacement(41y,41y)
//        PenDown
//        Displacement(-5y,0y)
//        Displacement(-5y,1y)
//        Displacement(-6y,3y)
//        Displacement(-5y,4y)
//        Displacement(-3y,5y)
//        Displacement(-2y,8y)
//        Displacement(0y,6y)
//        Displacement(2y,6y)
//        Displacement(4y,6y)
//        Displacement(5y,4y)
//        Displacement(6y,2y)
//        Displacement(7y,0y)
//        Displacement(6y,-2y)
//        Displacement(7y,-7y)
//        Displacement(25y,-27y)
//        Displacement(7y,-7y)
//        Displacement(6y,-2y)
//        Displacement(7y,0y)
//        Displacement(6y,2y)
//        Displacement(5y,4y)
//        Displacement(4y,6y)
//        Displacement(2y,6y)
//        Displacement(0y,6y)
//        Displacement(-2y,8y)
//        Displacement(-3y,5y)
//        Displacement(-5y,4y)
//        Displacement(-6y,3y)
//        Displacement(-5y,1y)
//        Displacement(-5y,0y)
//    ]
//    // ∝
//    dict.[41432us] <- [
//        PenUp
//        Displacement(107y,47y)
//        PenDown
//        Displacement(-5y,-4y)
//        Displacement(-6y,-2y)
//        Displacement(-7y,0y)
//        Displacement(-6y,2y)
//        Displacement(-7y,5y)
//        Displacement(-5y,5y)
//        Displacement(-4y,6y)
//        Displacement(-4y,6y)
//        Displacement(-4y,6y)
//        Displacement(-4y,6y)
//        Displacement(-6y,6y)
//        Displacement(-5y,3y)
//        Displacement(-6y,2y)
//        Displacement(-7y,0y)
//        Displacement(-6y,-2y)
//        Displacement(-5y,-4y)
//        Displacement(-4y,-5y)
//        Displacement(-3y,-6y)
//        Displacement(-1y,-7y)
//        Displacement(1y,-7y)
//        Displacement(3y,-6y)
//        Displacement(4y,-5y)
//        Displacement(5y,-4y)
//        Displacement(6y,-2y)
//        Displacement(7y,0y)
//        Displacement(6y,2y)
//        Displacement(5y,3y)
//        Displacement(6y,6y)
//        Displacement(4y,6y)
//        Displacement(4y,6y)
//        Displacement(4y,6y)
//        Displacement(4y,6y)
//        Displacement(5y,5y)
//        Displacement(7y,5y)
//        Displacement(6y,2y)
//        Displacement(7y,0y)
//        Displacement(6y,-2y)
//        Displacement(5y,-4y)
//    ]
//    // ≠
//    dict.[41433us] <- [
//        PenUp
//        Displacement(10y,81y)
//        PenDown
//        Displacement(107y,0y)
//        PenUp
//        Displacement(-107y,-35y)
//        PenDown
//        Displacement(107y,0y)
//        PenUp
//        Displacement(-36y,68y)
//        PenDown
//        Displacement(-39y,-106y)
//    ]
//    // ≮
//    dict.[41434us] <- [
//        PenUp
//        Displacement(64y,114y)
//        PenDown
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(52y,102y)
//        PenDown
//        Displacement(-103y,-49y)
//        Displacement(103y,-37y)
//    ]
//    // ≯
//    dict.[41435us] <- [
//        PenUp
//        Displacement(64y,114y)
//        PenDown
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-52y,102y)
//        PenDown
//        Displacement(103y,-49y)
//        Displacement(-103y,-37y)
//    ]
//    // ≤
//    dict.[41436us] <- [
//        PenUp
//        Displacement(115y,113y)
//        PenDown
//        Displacement(-102y,-49y)
//        Displacement(102y,-37y)
//        PenUp
//        Displacement(-101y,-13y)
//        PenDown
//        Displacement(101y,0y)
//    ]
//    // ≥
//    dict.[41437us] <- [
//        PenUp
//        Displacement(11y,113y)
//        PenDown
//        Displacement(102y,-49y)
//        Displacement(-102y,-37y)
//        PenUp
//        Displacement(0y,-13y)
//        PenDown
//        Displacement(102y,0y)
//    ]
//    // ∞
//    dict.[41438us] <- [
//        PenUp
//        Displacement(70y,74y)
//        PenDown
//        Displacement(-12y,-20y)
//        Displacement(-7y,-7y)
//        Displacement(-8y,-5y)
//        Displacement(-8y,-2y)
//        Displacement(-2y,0y)
//        Displacement(-7y,2y)
//        Displacement(-7y,5y)
//        Displacement(-5y,7y)
//        Displacement(-2y,8y)
//        Displacement(0y,4y)
//        Displacement(2y,8y)
//        Displacement(5y,7y)
//        Displacement(7y,5y)
//        Displacement(7y,2y)
//        Displacement(2y,0y)
//        Displacement(8y,-2y)
//        Displacement(8y,-5y)
//        Displacement(7y,-7y)
//        Displacement(12y,-20y)
//        Displacement(7y,-7y)
//        Displacement(8y,-5y)
//        Displacement(8y,-2y)
//        Displacement(2y,0y)
//        Displacement(7y,2y)
//        Displacement(7y,5y)
//        Displacement(5y,7y)
//        Displacement(2y,8y)
//        Displacement(0y,4y)
//        Displacement(-2y,8y)
//        Displacement(-5y,7y)
//        Displacement(-7y,5y)
//        Displacement(-7y,2y)
//        Displacement(-2y,0y)
//        Displacement(-8y,-2y)
//        Displacement(-8y,-5y)
//        Displacement(-7y,-7y)
//    ]
//    // ∵
//    dict.[41439us] <- [
//        PenUp
//        Displacement(22y,92y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(-32y,-56y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(4y,-7y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(4y,2y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(4y,-2y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-32y,70y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(76y,0y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//    ]
//    // ∴
//    dict.[41440us] <- [
//        PenUp
//        Displacement(22y,36y)
//        PenDown
//        Displacement(1y,4y)
//        Displacement(2y,3y)
//        Displacement(3y,2y)
//        Displacement(4y,1y)
//        Displacement(4y,-1y)
//        Displacement(3y,-2y)
//        Displacement(2y,-3y)
//        Displacement(1y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(-2y,-3y)
//        Displacement(-3y,-2y)
//        Displacement(-4y,-1y)
//        Displacement(-4y,1y)
//        Displacement(-3y,2y)
//        Displacement(-2y,3y)
//        Displacement(-1y,4y)
//        PenUp
//        Displacement(32y,56y)
//        PenDown
//        Displacement(1y,4y)
//        Displacement(2y,3y)
//        Displacement(3y,2y)
//        Displacement(4y,1y)
//        Displacement(4y,-1y)
//        Displacement(3y,-2y)
//        Displacement(2y,-3y)
//        Displacement(1y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(-2y,-3y)
//        Displacement(-3y,-2y)
//        Displacement(-4y,-1y)
//        Displacement(-4y,1y)
//        Displacement(-3y,2y)
//        Displacement(-2y,3y)
//        Displacement(-1y,4y)
//        PenUp
//        Displacement(32y,-56y)
//        PenDown
//        Displacement(1y,4y)
//        Displacement(2y,3y)
//        Displacement(3y,2y)
//        Displacement(4y,1y)
//        Displacement(4y,-1y)
//        Displacement(3y,-2y)
//        Displacement(2y,-3y)
//        Displacement(1y,-4y)
//        Displacement(-1y,-4y)
//        Displacement(-2y,-3y)
//        Displacement(-3y,-2y)
//        Displacement(-4y,-1y)
//        Displacement(-4y,1y)
//        Displacement(-3y,2y)
//        Displacement(-2y,3y)
//        Displacement(-1y,4y)
//        PenUp
//        Displacement(-60y,-7y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(4y,2y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(4y,-2y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(32y,70y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(44y,-56y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//    ]
//    // ♂
//    dict.[41441us] <- [
//        PenUp
//        Displacement(46y,79y)
//        PenDown
//        Displacement(18y,21y)
//        Displacement(18y,-21y)
//        PenUp
//        Displacement(-18y,21y)
//        PenDown
//        Displacement(0y,-49y)
//        Displacement(-6y,-1y)
//        Displacement(-5y,-4y)
//        Displacement(-3y,-5y)
//        Displacement(-1y,-6y)
//        Displacement(1y,-6y)
//        Displacement(3y,-5y)
//        Displacement(5y,-4y)
//        Displacement(6y,-1y)
//        Displacement(6y,1y)
//        Displacement(5y,4y)
//        Displacement(3y,5y)
//        Displacement(1y,6y)
//        Displacement(-1y,6y)
//        Displacement(-3y,5y)
//        Displacement(-5y,4y)
//        Displacement(-6y,1y)
//    ]
//    // ♀
//    dict.[41442us] <- [
//        PenUp
//        Displacement(64y,12y)
//        PenDown
//        Displacement(0y,63y)
//        Displacement(-6y,1y)
//        Displacement(-5y,4y)
//        Displacement(-3y,5y)
//        Displacement(-1y,6y)
//        Displacement(1y,6y)
//        Displacement(3y,5y)
//        Displacement(5y,4y)
//        Displacement(6y,1y)
//        Displacement(6y,-1y)
//        Displacement(5y,-4y)
//        Displacement(3y,-5y)
//        Displacement(1y,-6y)
//        Displacement(-1y,-6y)
//        Displacement(-3y,-5y)
//        Displacement(-5y,-4y)
//        Displacement(-6y,-1y)
//        PenUp
//        Displacement(-30y,-25y)
//        PenDown
//        Displacement(59y,0y)
//    ]
//    // °
//    dict.[41443us] <- [
//        PenUp
//        Displacement(5y,111y)
//        PenDown
//        Displacement(2y,-6y)
//        Displacement(5y,-5y)
//        Displacement(6y,-2y)
//        Displacement(6y,2y)
//        Displacement(5y,5y)
//        Displacement(2y,6y)
//        Displacement(-2y,7y)
//        Displacement(-5y,4y)
//        Displacement(-6y,2y)
//        Displacement(-6y,-2y)
//        Displacement(-5y,-4y)
//        Displacement(-2y,-7y)
//    ]
//    // ′
//    dict.[41444us] <- [
//        PenUp
//        Displacement(22y,121y)
//        PenDown
//        Displacement(-1y,-2y)
//        Displacement(-14y,-27y)
//        Displacement(-2y,-1y)
//        Displacement(0y,1y)
//        Displacement(0y,1y)
//        Displacement(9y,30y)
//        Displacement(2y,1y)
//        Displacement(1y,0y)
//        Displacement(2y,0y)
//        Displacement(2y,-1y)
//        Displacement(1y,-2y)
//        PenUp
//        Displacement(-13y,-21y)
//        PenDown
//        Displacement(9y,23y)
//    ]
//    // ″
//    dict.[41445us] <- [
//        PenUp
//        Displacement(39y,121y)
//        PenDown
//        Displacement(-1y,-2y)
//        Displacement(-14y,-27y)
//        Displacement(-2y,-1y)
//        Displacement(0y,1y)
//        Displacement(0y,1y)
//        Displacement(9y,30y)
//        Displacement(2y,1y)
//        Displacement(1y,0y)
//        Displacement(2y,0y)
//        Displacement(2y,-1y)
//        Displacement(1y,-2y)
//        PenUp
//        Displacement(-17y,0y)
//        PenDown
//        Displacement(-1y,-2y)
//        Displacement(-14y,-27y)
//        Displacement(-2y,-1y)
//        Displacement(0y,1y)
//        Displacement(0y,1y)
//        Displacement(9y,30y)
//        Displacement(2y,1y)
//        Displacement(1y,0y)
//        Displacement(2y,0y)
//        Displacement(2y,-1y)
//        Displacement(1y,-2y)
//        PenUp
//        Displacement(-12y,-19y)
//        PenDown
//        Displacement(8y,21y)
//        PenUp
//        Displacement(17y,0y)
//        PenDown
//        Displacement(-8y,-21y)
//    ]
//    // ℃
//    dict.[41446us] <- [
//        PenUp
//        Displacement(10y,113y)
//        PenDown
//        Displacement(2y,-6y)
//        Displacement(6y,-5y)
//        Displacement(6y,0y)
//        Displacement(6y,5y)
//        Displacement(2y,6y)
//        Displacement(-2y,7y)
//        Displacement(-6y,4y)
//        Displacement(-6y,0y)
//        Displacement(-6y,-4y)
//        Displacement(-2y,-7y)
//        PenUp
//        Displacement(100y,-11y)
//        PenDown
//        Displacement(6y,12y)
//        Displacement(0y,-27y)
//        Displacement(-6y,15y)
//        Displacement(-4y,5y)
//        Displacement(-8y,5y)
//        Displacement(-8y,2y)
//        Displacement(-11y,0y)
//        Displacement(-9y,-5y)
//        Displacement(-8y,-7y)
//        Displacement(-7y,-12y)
//        Displacement(-4y,-15y)
//        Displacement(0y,-20y)
//        Displacement(4y,-17y)
//        Displacement(6y,-13y)
//        Displacement(8y,-8y)
//        Displacement(10y,-5y)
//        Displacement(11y,0y)
//        Displacement(7y,2y)
//        Displacement(7y,5y)
//        Displacement(5y,6y)
//        Displacement(5y,13y)
//        PenUp
//        Displacement(-35y,76y)
//        PenDown
//        Displacement(-8y,-7y)
//        Displacement(-5y,-6y)
//        Displacement(-7y,-12y)
//        Displacement(-3y,-14y)
//        Displacement(0y,-20y)
//        Displacement(3y,-16y)
//        Displacement(6y,-14y)
//        Displacement(6y,-7y)
//        Displacement(8y,-6y)
//    ]
//    // ＄
//    dict.[41447us] <- [
//        PenUp
//        Displacement(93y,94y)
//        PenDown
//        Displacement(-3y,1y)
//        Displacement(-3y,-1y)
//        Displacement(-1y,-3y)
//        Displacement(1y,-3y)
//        Displacement(3y,-1y)
//        Displacement(3y,1y)
//        Displacement(1y,3y)
//        Displacement(-1y,3y)
//        Displacement(-6y,7y)
//        Displacement(-7y,4y)
//        Displacement(-10y,2y)
//        Displacement(-12y,0y)
//        Displacement(-7y,-3y)
//        Displacement(-6y,-6y)
//        Displacement(-4y,-9y)
//        Displacement(0y,-8y)
//        Displacement(4y,-7y)
//        Displacement(6y,-4y)
//        Displacement(29y,-12y)
//        Displacement(6y,-5y)
//        Displacement(4y,-6y)
//        Displacement(0y,-11y)
//        Displacement(-4y,-7y)
//        Displacement(-6y,-5y)
//        Displacement(-7y,-3y)
//        Displacement(-12y,0y)
//        Displacement(-10y,2y)
//        Displacement(-7y,4y)
//        Displacement(-6y,7y)
//        Displacement(-1y,3y)
//        Displacement(1y,3y)
//        Displacement(3y,1y)
//        Displacement(3y,-1y)
//        Displacement(1y,-3y)
//        Displacement(-1y,-3y)
//        Displacement(-3y,-1y)
//        Displacement(-3y,1y)
//        PenUp
//        Displacement(26y,85y)
//        PenDown
//        Displacement(0y,-108y)
//        PenUp
//        Displacement(-6y,96y)
//        PenDown
//        Displacement(-4y,-3y)
//        Displacement(-6y,-6y)
//        Displacement(-3y,-9y)
//        Displacement(0y,-8y)
//        Displacement(2y,-5y)
//        Displacement(4y,-6y)
//        PenUp
//        Displacement(29y,-12y)
//        PenDown
//        Displacement(7y,-3y)
//        Displacement(7y,-8y)
//        Displacement(0y,-11y)
//        Displacement(-4y,-7y)
//        Displacement(-6y,-5y)
//        Displacement(-11y,-3y)
//    ]
//    // ¤
//    dict.[41448us] <- [
//        PenUp
//        Displacement(64y,102y)
//        PenDown
//        Displacement(-15y,-3y)
//        Displacement(-12y,-8y)
//        Displacement(-8y,-12y)
//        Displacement(-3y,-15y)
//        Displacement(3y,-14y)
//        Displacement(8y,-13y)
//        Displacement(12y,-8y)
//        Displacement(15y,-3y)
//        Displacement(15y,3y)
//        Displacement(12y,8y)
//        Displacement(8y,13y)
//        Displacement(3y,14y)
//        Displacement(-3y,15y)
//        Displacement(-8y,12y)
//        Displacement(-12y,8y)
//        Displacement(-15y,3y)
//        PenUp
//        Displacement(-39y,2y)
//        PenDown
//        Displacement(12y,-13y)
//        PenUp
//        Displacement(54y,-54y)
//        PenDown
//        Displacement(12y,-12y)
//        PenUp
//        Displacement(0y,79y)
//        PenDown
//        Displacement(-12y,-13y)
//        PenUp
//        Displacement(-54y,-54y)
//        PenDown
//        Displacement(-12y,-12y)
//    ]
//    // ￠
//    dict.[41449us] <- [
//        PenUp
//        Displacement(65y,113y)
//        PenDown
//        Displacement(-28y,-102y)
//        PenUp
//        Displacement(35y,79y)
//        PenDown
//        Displacement(5y,9y)
//        Displacement(0y,-20y)
//        Displacement(-5y,11y)
//        Displacement(-5y,7y)
//        Displacement(-6y,3y)
//        Displacement(-8y,2y)
//        Displacement(-6y,0y)
//        Displacement(-7y,-2y)
//        Displacement(-7y,-6y)
//        Displacement(-5y,-9y)
//        Displacement(-3y,-14y)
//        Displacement(0y,-19y)
//        Displacement(3y,-14y)
//        Displacement(5y,-10y)
//        Displacement(7y,-6y)
//        Displacement(7y,-3y)
//        Displacement(8y,0y)
//        Displacement(7y,1y)
//        Displacement(6y,4y)
//        Displacement(6y,6y)
//        Displacement(3y,9y)
//        PenUp
//        Displacement(-30y,63y)
//        PenDown
//        Displacement(-7y,-4y)
//        Displacement(-4y,-5y)
//        Displacement(-4y,-8y)
//        Displacement(-3y,-14y)
//        Displacement(0y,-19y)
//        Displacement(2y,-14y)
//        Displacement(4y,-10y)
//        Displacement(5y,-5y)
//        Displacement(7y,-4y)
//    ]
//    // ￡
//    dict.[41450us] <- [
//        PenUp
//        Displacement(20y,65y)
//        PenDown
//        Displacement(62y,0y)
//        PenUp
//        Displacement(-23y,43y)
//        PenDown
//        Displacement(-7y,-8y)
//        Displacement(-4y,-8y)
//        Displacement(-1y,-14y)
//        Displacement(0y,-45y)
//        Displacement(15y,-8y)
//        Displacement(7y,-3y)
//        Displacement(7y,0y)
//        Displacement(8y,3y)
//        Displacement(6y,4y)
//        Displacement(5y,4y)
//        PenUp
//        Displacement(-52y,-5y)
//        PenDown
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-4y,3y)
//        Displacement(-4y,1y)
//        Displacement(-5y,0y)
//        Displacement(-4y,-2y)
//        Displacement(-2y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        Displacement(0y,-3y)
//        Displacement(1y,-4y)
//        Displacement(2y,-4y)
//        Displacement(3y,-2y)
//        Displacement(3y,-1y)
//        Displacement(5y,0y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(3y,4y)
//        Displacement(1y,4y)
//        Displacement(0y,3y)
//        PenUp
//        Displacement(56y,16y)
//        PenDown
//        Displacement(-4y,-11y)
//        Displacement(-5y,-7y)
//        Displacement(-6y,-5y)
//        Displacement(-8y,-3y)
//        Displacement(-7y,0y)
//        Displacement(-7y,3y)
//        Displacement(-15y,8y)
//        Displacement(-1y,-6y)
//        Displacement(-2y,-5y)
//        Displacement(-3y,-4y)
//        Displacement(-4y,-3y)
//        Displacement(-6y,-1y)
//        Displacement(-4y,0y)
//        Displacement(-6y,2y)
//        Displacement(-3y,3y)
//        Displacement(-2y,4y)
//        Displacement(-1y,5y)
//        Displacement(0y,4y)
//        Displacement(1y,5y)
//        Displacement(2y,4y)
//        Displacement(4y,3y)
//        Displacement(4y,2y)
//        Displacement(6y,0y)
//        Displacement(6y,-2y)
//        Displacement(5y,-4y)
//        Displacement(0y,42y)
//        Displacement(2y,14y)
//        Displacement(5y,8y)
//        Displacement(9y,8y)
//        Displacement(8y,4y)
//        Displacement(10y,0y)
//        Displacement(8y,-4y)
//        Displacement(3y,-3y)
//        Displacement(2y,-7y)
//        Displacement(-4y,3y)
//        Displacement(-4y,-3y)
//        Displacement(0y,-4y)
//        Displacement(4y,-3y)
//        Displacement(4y,3y)
//        Displacement(0y,4y)
//    ]
//    // ‰
//    dict.[41451us] <- [
//        PenUp
//        Displacement(41y,110y)
//        PenDown
//        Displacement(-3y,2y)
//        Displacement(-5y,0y)
//        Displacement(-5y,-2y)
//        Displacement(-6y,-5y)
//        Displacement(-5y,-6y)
//        Displacement(-6y,-12y)
//        Displacement(-2y,-9y)
//        Displacement(0y,-7y)
//        Displacement(1y,-5y)
//        Displacement(3y,-3y)
//        Displacement(4y,0y)
//        Displacement(6y,1y)
//        Displacement(5y,3y)
//        Displacement(4y,4y)
//        Displacement(6y,8y)
//        Displacement(4y,10y)
//        Displacement(1y,7y)
//        Displacement(0y,7y)
//        Displacement(-1y,5y)
//        Displacement(-1y,2y)
//        PenUp
//        Displacement(34y,-50y)
//        PenDown
//        Displacement(-3y,2y)
//        Displacement(-5y,0y)
//        Displacement(-5y,-2y)
//        Displacement(-6y,-5y)
//        Displacement(-5y,-6y)
//        Displacement(-6y,-12y)
//        Displacement(-2y,-9y)
//        Displacement(0y,-7y)
//        Displacement(1y,-5y)
//        Displacement(3y,-3y)
//        Displacement(4y,0y)
//        Displacement(6y,1y)
//        Displacement(5y,3y)
//        Displacement(4y,4y)
//        Displacement(6y,8y)
//        Displacement(4y,10y)
//        Displacement(1y,7y)
//        Displacement(0y,7y)
//        Displacement(-1y,5y)
//        Displacement(-1y,2y)
//        PenUp
//        Displacement(40y,0y)
//        PenDown
//        Displacement(-3y,2y)
//        Displacement(-5y,0y)
//        Displacement(-5y,-2y)
//        Displacement(-6y,-5y)
//        Displacement(-5y,-6y)
//        Displacement(-6y,-12y)
//        Displacement(-2y,-9y)
//        Displacement(0y,-7y)
//        Displacement(1y,-5y)
//        Displacement(3y,-3y)
//        Displacement(4y,0y)
//        Displacement(6y,1y)
//        Displacement(5y,3y)
//        Displacement(4y,4y)
//        Displacement(6y,8y)
//        Displacement(4y,10y)
//        Displacement(1y,7y)
//        Displacement(0y,7y)
//        Displacement(-1y,5y)
//        Displacement(-1y,2y)
//        PenUp
//        Displacement(-39y,60y)
//        PenDown
//        Displacement(-66y,-111y)
//    ]
//    // §
//    dict.[41452us] <- [
//        PenUp
//        Displacement(73y,19y)
//        PenDown
//        Displacement(3y,-1y)
//        Displacement(3y,1y)
//        Displacement(1y,3y)
//        Displacement(-1y,3y)
//        Displacement(-3y,1y)
//        Displacement(-3y,-1y)
//        Displacement(-1y,-3y)
//        Displacement(2y,-7y)
//        Displacement(3y,-4y)
//        Displacement(6y,-3y)
//        Displacement(7y,-1y)
//        Displacement(7y,1y)
//        Displacement(7y,4y)
//        Displacement(2y,6y)
//        Displacement(0y,5y)
//        Displacement(-1y,4y)
//        Displacement(-5y,6y)
//        Displacement(-29y,26y)
//        Displacement(-3y,6y)
//        Displacement(-1y,5y)
//        Displacement(0y,2y)
//        Displacement(2y,4y)
//        Displacement(4y,4y)
//        Displacement(6y,2y)
//        Displacement(4y,0y)
//        Displacement(6y,-1y)
//        Displacement(4y,-2y)
//        PenUp
//        Displacement(9y,30y)
//        PenDown
//        Displacement(-3y,1y)
//        Displacement(-3y,-1y)
//        Displacement(-1y,-3y)
//        Displacement(1y,-3y)
//        Displacement(3y,-1y)
//        Displacement(3y,1y)
//        Displacement(1y,3y)
//        Displacement(-2y,7y)
//        Displacement(-3y,4y)
//        Displacement(-6y,3y)
//        Displacement(-7y,1y)
//        Displacement(-7y,-1y)
//        Displacement(-7y,-4y)
//        Displacement(-2y,-6y)
//        Displacement(0y,-5y)
//        Displacement(1y,-4y)
//        Displacement(5y,-6y)
//        Displacement(29y,-26y)
//        Displacement(3y,-6y)
//        Displacement(1y,-5y)
//        Displacement(0y,-2y)
//        Displacement(-2y,-4y)
//        Displacement(-4y,-4y)
//        Displacement(-6y,-2y)
//        Displacement(-4y,0y)
//        Displacement(-6y,1y)
//        Displacement(-4y,2y)
//    ]
//    // №
//    dict.[41453us] <- [
//        PenUp
//        Displacement(90y,88y)
//        PenDown
//        Displacement(5y,-2y)
//        Displacement(4y,-4y)
//        Displacement(2y,-6y)
//        Displacement(1y,-9y)
//        Displacement(0y,-35y)
//        Displacement(-1y,-9y)
//        Displacement(-2y,-6y)
//        Displacement(-4y,-4y)
//        Displacement(-5y,-2y)
//        Displacement(-6y,0y)
//        Displacement(-5y,2y)
//        Displacement(-4y,4y)
//        Displacement(-2y,6y)
//        Displacement(-1y,9y)
//        Displacement(0y,35y)
//        Displacement(1y,9y)
//        Displacement(2y,6y)
//        Displacement(4y,4y)
//        Displacement(5y,2y)
//        Displacement(6y,0y)
//        PenUp
//        Displacement(-87y,28y)
//        PenDown
//        Displacement(16y,0y)
//        Displacement(39y,-95y)
//        PenUp
//        Displacement(-44y,-10y)
//        PenDown
//        Displacement(0y,105y)
//        Displacement(44y,-105y)
//        Displacement(0y,105y)
//        PenUp
//        Displacement(-53y,-105y)
//        PenDown
//        Displacement(20y,0y)
//        PenUp
//        Displacement(45y,105y)
//        PenDown
//        Displacement(-24y,0y)
//        PenUp
//        Displacement(78y,-100y)
//        PenDown
//        Displacement(-1y,3y)
//        Displacement(-4y,2y)
//        Displacement(-4y,-2y)
//        Displacement(-1y,-3y)
//        Displacement(1y,-3y)
//        Displacement(4y,-2y)
//        Displacement(4y,2y)
//        Displacement(1y,3y)
//    ]
//    // ☆
//    dict.[41454us] <- [
//        PenUp
//        Displacement(64y,110y)
//        PenDown
//        Displacement(-14y,-34y)
//        Displacement(-34y,0y)
//        Displacement(26y,-20y)
//        Displacement(-10y,-34y)
//        Displacement(32y,19y)
//        Displacement(32y,-19y)
//        Displacement(-10y,34y)
//        Displacement(26y,20y)
//        Displacement(-34y,0y)
//        Displacement(-14y,34y)
//    ]
//    // ★
//    dict.[41455us] <- [
//        PenUp
//        Displacement(64y,110y)
//        PenDown
//        Displacement(-14y,-34y)
//        Displacement(-34y,0y)
//        Displacement(26y,-20y)
//        Displacement(-10y,-34y)
//        Displacement(32y,19y)
//        Displacement(32y,-19y)
//        Displacement(-10y,34y)
//        Displacement(26y,20y)
//        Displacement(-34y,0y)
//        Displacement(-14y,34y)
//        PenUp
//        Displacement(0y,-1y)
//        PenDown
//        Displacement(0y,-68y)
//        PenUp
//        Displacement(4y,-2y)
//        PenDown
//        Displacement(0y,61y)
//        PenUp
//        Displacement(4y,-10y)
//        PenDown
//        Displacement(0y,-53y)
//        PenUp
//        Displacement(4y,-3y)
//        PenDown
//        Displacement(0y,46y)
//        PenUp
//        Displacement(4y,-4y)
//        PenDown
//        Displacement(0y,-44y)
//        PenUp
//        Displacement(4y,-2y)
//        PenDown
//        Displacement(0y,46y)
//        PenUp
//        Displacement(4y,-49y)
//        PenDown
//        Displacement(0y,21y)
//        PenUp
//        Displacement(0y,10y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,-15y)
//        PenUp
//        Displacement(0y,-26y)
//        PenDown
//        Displacement(0y,-10y)
//        PenUp
//        Displacement(4y,51y)
//        PenDown
//        Displacement(0y,-12y)
//        PenUp
//        Displacement(4y,12y)
//        PenDown
//        Displacement(0y,-9y)
//        PenUp
//        Displacement(4y,3y)
//        PenDown
//        Displacement(0y,6y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,-3y)
//        PenUp
//        Displacement(-88y,3y)
//        PenDown
//        Displacement(0y,-3y)
//        PenUp
//        Displacement(4y,-3y)
//        PenDown
//        Displacement(0y,6y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,-9y)
//        PenUp
//        Displacement(4y,9y)
//        PenDown
//        Displacement(0y,-12y)
//        PenUp
//        Displacement(4y,-29y)
//        PenDown
//        Displacement(0y,-10y)
//        PenUp
//        Displacement(0y,51y)
//        PenDown
//        Displacement(0y,-15y)
//        PenUp
//        Displacement(4y,-3y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(0y,-49y)
//        PenDown
//        Displacement(0y,21y)
//        PenUp
//        Displacement(4y,-18y)
//        PenDown
//        Displacement(0y,46y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,-44y)
//        PenUp
//        Displacement(4y,2y)
//        PenDown
//        Displacement(0y,46y)
//        PenUp
//        Displacement(4y,10y)
//        PenDown
//        Displacement(0y,-53y)
//        PenUp
//        Displacement(4y,2y)
//        PenDown
//        Displacement(0y,61y)
//    ]
//    // ○
//    dict.[41456us] <- [
//        PenUp
//        Displacement(118y,64y)
//        PenDown
//        Displacement(-1y,11y)
//        Displacement(-3y,10y)
//        Displacement(-5y,9y)
//        Displacement(-7y,8y)
//        Displacement(-8y,7y)
//        Displacement(-9y,5y)
//        Displacement(-10y,3y)
//        Displacement(-11y,1y)
//        Displacement(-11y,-1y)
//        Displacement(-10y,-3y)
//        Displacement(-9y,-5y)
//        Displacement(-8y,-7y)
//        Displacement(-7y,-8y)
//        Displacement(-5y,-9y)
//        Displacement(-3y,-10y)
//        Displacement(-1y,-11y)
//        Displacement(1y,-11y)
//        Displacement(3y,-10y)
//        Displacement(5y,-9y)
//        Displacement(7y,-8y)
//        Displacement(8y,-7y)
//        Displacement(9y,-5y)
//        Displacement(10y,-3y)
//        Displacement(11y,-1y)
//        Displacement(11y,1y)
//        Displacement(10y,3y)
//        Displacement(9y,5y)
//        Displacement(8y,7y)
//        Displacement(7y,8y)
//        Displacement(5y,9y)
//        Displacement(3y,10y)
//        Displacement(1y,11y)
//    ]
//    // ●
//    dict.[41457us] <- [
//        PenUp
//        Displacement(104y,64y)
//        PenDown
//        Displacement(-1y,10y)
//        Displacement(-4y,10y)
//        Displacement(-7y,9y)
//        Displacement(-8y,6y)
//        Displacement(-10y,4y)
//        Displacement(-10y,1y)
//        Displacement(-10y,-1y)
//        Displacement(-10y,-4y)
//        Displacement(-8y,-6y)
//        Displacement(-7y,-9y)
//        Displacement(-4y,-10y)
//        Displacement(-1y,-10y)
//        Displacement(1y,-10y)
//        Displacement(4y,-10y)
//        Displacement(7y,-9y)
//        Displacement(8y,-6y)
//        Displacement(10y,-4y)
//        Displacement(10y,-1y)
//        Displacement(10y,1y)
//        Displacement(10y,4y)
//        Displacement(8y,6y)
//        Displacement(7y,9y)
//        Displacement(4y,10y)
//        Displacement(1y,10y)
//        PenUp
//        Displacement(0y,0y)
//        PenDown
//        Displacement(-80y,0y)
//        PenUp
//        Displacement(1y,-4y)
//        PenDown
//        Displacement(78y,0y)
//        PenUp
//        Displacement(-1y,-4y)
//        PenDown
//        Displacement(-76y,0y)
//        PenUp
//        Displacement(0y,-4y)
//        PenDown
//        Displacement(76y,0y)
//        PenUp
//        Displacement(-2y,-4y)
//        PenDown
//        Displacement(-72y,0y)
//        PenUp
//        Displacement(2y,-4y)
//        PenDown
//        Displacement(68y,0y)
//        PenUp
//        Displacement(-3y,-4y)
//        PenDown
//        Displacement(-62y,0y)
//        PenUp
//        Displacement(3y,-4y)
//        PenDown
//        Displacement(56y,0y)
//        PenUp
//        Displacement(-5y,-4y)
//        PenDown
//        Displacement(-46y,0y)
//        PenUp
//        Displacement(7y,-4y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-32y,72y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(7y,-4y)
//        PenDown
//        Displacement(-46y,0y)
//        PenUp
//        Displacement(-5y,-4y)
//        PenDown
//        Displacement(56y,0y)
//        PenUp
//        Displacement(3y,-4y)
//        PenDown
//        Displacement(-62y,0y)
//        PenUp
//        Displacement(-3y,-4y)
//        PenDown
//        Displacement(68y,0y)
//        PenUp
//        Displacement(2y,-4y)
//        PenDown
//        Displacement(-72y,0y)
//        PenUp
//        Displacement(-2y,-4y)
//        PenDown
//        Displacement(76y,0y)
//        PenUp
//        Displacement(0y,-4y)
//        PenDown
//        Displacement(-76y,0y)
//        PenUp
//        Displacement(-1y,-4y)
//        PenDown
//        Displacement(78y,0y)
//    ]
//    // ◎
//    dict.[41458us] <- [
//        PenUp
//        Displacement(118y,64y)
//        PenDown
//        Displacement(-1y,11y)
//        Displacement(-3y,10y)
//        Displacement(-5y,9y)
//        Displacement(-7y,8y)
//        Displacement(-8y,7y)
//        Displacement(-9y,5y)
//        Displacement(-10y,3y)
//        Displacement(-11y,1y)
//        Displacement(-11y,-1y)
//        Displacement(-10y,-3y)
//        Displacement(-9y,-5y)
//        Displacement(-8y,-7y)
//        Displacement(-7y,-8y)
//        Displacement(-5y,-9y)
//        Displacement(-3y,-10y)
//        Displacement(-1y,-11y)
//        Displacement(1y,-11y)
//        Displacement(3y,-10y)
//        Displacement(5y,-9y)
//        Displacement(7y,-8y)
//        Displacement(8y,-7y)
//        Displacement(9y,-5y)
//        Displacement(10y,-3y)
//        Displacement(11y,-1y)
//        Displacement(11y,1y)
//        Displacement(10y,3y)
//        Displacement(9y,5y)
//        Displacement(8y,7y)
//        Displacement(7y,8y)
//        Displacement(5y,9y)
//        Displacement(3y,10y)
//        Displacement(1y,11y)
//        PenUp
//        Displacement(-18y,0y)
//        PenDown
//        Displacement(-1y,8y)
//        Displacement(-3y,8y)
//        Displacement(-4y,7y)
//        Displacement(-5y,5y)
//        Displacement(-7y,4y)
//        Displacement(-8y,3y)
//        Displacement(-8y,1y)
//        Displacement(-8y,-1y)
//        Displacement(-8y,-3y)
//        Displacement(-7y,-4y)
//        Displacement(-5y,-5y)
//        Displacement(-4y,-7y)
//        Displacement(-3y,-8y)
//        Displacement(-1y,-8y)
//        Displacement(1y,-8y)
//        Displacement(3y,-8y)
//        Displacement(4y,-7y)
//        Displacement(5y,-5y)
//        Displacement(7y,-4y)
//        Displacement(8y,-3y)
//        Displacement(8y,-1y)
//        Displacement(8y,1y)
//        Displacement(8y,3y)
//        Displacement(7y,4y)
//        Displacement(5y,5y)
//        Displacement(4y,7y)
//        Displacement(3y,8y)
//        Displacement(1y,8y)
//    ]
//    // ◇
//    dict.[41459us] <- [
//        PenUp
//        Displacement(8y,64y)
//        PenDown
//        Displacement(56y,56y)
//        Displacement(56y,-56y)
//        Displacement(-56y,-56y)
//        Displacement(-56y,56y)
//    ]
//    // ◆
//    dict.[41460us] <- [
//        PenUp
//        Displacement(8y,64y)
//        PenDown
//        Displacement(56y,56y)
//        Displacement(56y,-56y)
//        Displacement(-56y,-56y)
//        Displacement(-56y,56y)
//        PenUp
//        Displacement(56y,-56y)
//        PenDown
//        Displacement(0y,112y)
//        PenUp
//        Displacement(4y,-4y)
//        PenDown
//        Displacement(0y,-104y)
//        PenUp
//        Displacement(4y,100y)
//        PenDown
//        Displacement(0y,-96y)
//        PenUp
//        Displacement(4y,92y)
//        PenDown
//        Displacement(0y,-88y)
//        PenUp
//        Displacement(4y,84y)
//        PenDown
//        Displacement(0y,-80y)
//        PenUp
//        Displacement(4y,76y)
//        PenDown
//        Displacement(0y,-72y)
//        PenUp
//        Displacement(4y,68y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(4y,60y)
//        PenDown
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(4y,52y)
//        PenDown
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(4y,44y)
//        PenDown
//        Displacement(0y,-40y)
//        PenUp
//        Displacement(4y,36y)
//        PenDown
//        Displacement(0y,-32y)
//        PenUp
//        Displacement(4y,28y)
//        PenDown
//        Displacement(0y,-24y)
//        PenUp
//        Displacement(4y,20y)
//        PenDown
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(4y,12y)
//        PenDown
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(-104y,8y)
//        PenDown
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(4y,12y)
//        PenDown
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(4y,20y)
//        PenDown
//        Displacement(0y,-24y)
//        PenUp
//        Displacement(4y,28y)
//        PenDown
//        Displacement(0y,-32y)
//        PenUp
//        Displacement(4y,36y)
//        PenDown
//        Displacement(0y,-40y)
//        PenUp
//        Displacement(4y,44y)
//        PenDown
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(4y,52y)
//        PenDown
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(4y,60y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(4y,68y)
//        PenDown
//        Displacement(0y,-72y)
//        PenUp
//        Displacement(4y,76y)
//        PenDown
//        Displacement(0y,-80y)
//        PenUp
//        Displacement(4y,84y)
//        PenDown
//        Displacement(0y,-88y)
//        PenUp
//        Displacement(4y,92y)
//        PenDown
//        Displacement(0y,-96y)
//        PenUp
//        Displacement(4y,100y)
//        PenDown
//        Displacement(0y,-104y)
//    ]
//    // □
//    dict.[41461us] <- [
//        PenUp
//        Displacement(11y,115y)
//        PenDown
//        Displacement(104y,0y)
//        Displacement(0y,-104y)
//        Displacement(-104y,0y)
//        Displacement(0y,104y)
//    ]
//    // ■
//    dict.[41462us] <- [
//        PenUp
//        Displacement(12y,117y)
//        PenDown
//        Displacement(104y,0y)
//        Displacement(0y,-104y)
//        Displacement(-104y,0y)
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//        PenUp
//        Displacement(4y,-104y)
//        PenDown
//        Displacement(0y,104y)
//    ]
//    // △
//    dict.[41463us] <- [
//        PenUp
//        Displacement(14y,18y)
//        PenDown
//        Displacement(100y,0y)
//        Displacement(-50y,91y)
//        Displacement(-50y,-91y)
//    ]
//    // ▲
//    dict.[41464us] <- [
//        PenUp
//        Displacement(14y,18y)
//        PenDown
//        Displacement(100y,0y)
//        Displacement(-50y,91y)
//        Displacement(-50y,-91y)
//        PenUp
//        Displacement(50y,0y)
//        PenDown
//        Displacement(0y,91y)
//        PenUp
//        Displacement(4y,-91y)
//        PenDown
//        Displacement(0y,83y)
//        PenUp
//        Displacement(4y,-83y)
//        PenDown
//        Displacement(0y,75y)
//        PenUp
//        Displacement(4y,-75y)
//        PenDown
//        Displacement(0y,68y)
//        PenUp
//        Displacement(4y,-68y)
//        PenDown
//        Displacement(0y,61y)
//        PenUp
//        Displacement(4y,-61y)
//        PenDown
//        Displacement(0y,54y)
//        PenUp
//        Displacement(4y,-54y)
//        PenDown
//        Displacement(0y,46y)
//        PenUp
//        Displacement(4y,-46y)
//        PenDown
//        Displacement(0y,39y)
//        PenUp
//        Displacement(4y,-39y)
//        PenDown
//        Displacement(0y,32y)
//        PenUp
//        Displacement(4y,-32y)
//        PenDown
//        Displacement(0y,24y)
//        PenUp
//        Displacement(4y,-24y)
//        PenDown
//        Displacement(0y,17y)
//        PenUp
//        Displacement(4y,-17y)
//        PenDown
//        Displacement(0y,10y)
//        PenUp
//        Displacement(4y,-10y)
//        PenDown
//        Displacement(0y,3y)
//        PenUp
//        Displacement(-96y,-3y)
//        PenDown
//        Displacement(0y,3y)
//        PenUp
//        Displacement(4y,-3y)
//        PenDown
//        Displacement(0y,10y)
//        PenUp
//        Displacement(4y,-10y)
//        PenDown
//        Displacement(0y,17y)
//        PenUp
//        Displacement(4y,-17y)
//        PenDown
//        Displacement(0y,24y)
//        PenUp
//        Displacement(4y,-24y)
//        PenDown
//        Displacement(0y,32y)
//        PenUp
//        Displacement(4y,-32y)
//        PenDown
//        Displacement(0y,39y)
//        PenUp
//        Displacement(4y,-39y)
//        PenDown
//        Displacement(0y,46y)
//        PenUp
//        Displacement(4y,-46y)
//        PenDown
//        Displacement(0y,54y)
//        PenUp
//        Displacement(4y,-54y)
//        PenDown
//        Displacement(0y,61y)
//        PenUp
//        Displacement(4y,-61y)
//        PenDown
//        Displacement(0y,68y)
//        PenUp
//        Displacement(4y,-68y)
//        PenDown
//        Displacement(0y,75y)
//        PenUp
//        Displacement(4y,-75y)
//        PenDown
//        Displacement(0y,83y)
//    ]
//    // ※
//    dict.[41465us] <- [
//        PenUp
//        Displacement(54y,32y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(-35y,32y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(35y,35y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(31y,-35y)
//        PenDown
//        Displacement(1y,-4y)
//        Displacement(2y,-3y)
//        Displacement(3y,-2y)
//        Displacement(4y,-1y)
//        Displacement(4y,1y)
//        Displacement(3y,2y)
//        Displacement(2y,3y)
//        Displacement(1y,4y)
//        Displacement(-1y,4y)
//        Displacement(-2y,3y)
//        Displacement(-3y,2y)
//        Displacement(-4y,1y)
//        Displacement(-4y,-1y)
//        Displacement(-3y,-2y)
//        Displacement(-2y,-3y)
//        Displacement(-1y,-4y)
//        PenUp
//        Displacement(28y,49y)
//        PenDown
//        Displacement(-100y,-100y)
//        PenUp
//        Displacement(2y,100y)
//        PenDown
//        Displacement(100y,-100y)
//        PenUp
//        Displacement(-92y,44y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(4y,2y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(4y,0y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(4y,-2y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(66y,14y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(-19y,35y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//        PenUp
//        Displacement(12y,-67y)
//        PenDown
//        Displacement(0y,-14y)
//        PenUp
//        Displacement(-4y,-2y)
//        PenDown
//        Displacement(0y,18y)
//        PenUp
//        Displacement(-4y,0y)
//        PenDown
//        Displacement(0y,-18y)
//        PenUp
//        Displacement(-4y,2y)
//        PenDown
//        Displacement(0y,14y)
//    ]
//    // →
//    dict.[41466us] <- [
//        PenUp
//        Displacement(5y,64y)
//        PenDown
//        Displacement(118y,0y)
//        Displacement(-51y,17y)
//        Displacement(11y,-17y)
//        Displacement(-11y,-17y)
//        Displacement(51y,17y)
//    ]
//    // ←
//    dict.[41467us] <- [
//        PenUp
//        Displacement(121y,64y)
//        PenDown
//        Displacement(-118y,0y)
//        Displacement(51y,17y)
//        Displacement(-11y,-17y)
//        Displacement(11y,-17y)
//        Displacement(-51y,17y)
//    ]
//    // ↑
//    dict.[41468us] <- [
//        PenUp
//        Displacement(64y,6y)
//        PenDown
//        Displacement(0y,118y)
//        Displacement(17y,-51y)
//        Displacement(-17y,11y)
//        Displacement(-17y,-11y)
//        Displacement(17y,51y)
//    ]
//    // ↓
//    dict.[41469us] <- [
//        PenUp
//        Displacement(64y,123y)
//        PenDown
//        Displacement(0y,-118y)
//        Displacement(-17y,51y)
//        Displacement(17y,-11y)
//        Displacement(17y,11y)
//        Displacement(-17y,-51y)
//    ]
//    // 〓
//    dict.[41470us] <- [
//        PenUp
//        Displacement(15y,40y)
//        PenDown
//        Displacement(98y,0y)
//        Displacement(0y,-20y)
//        Displacement(-98y,0y)
//        Displacement(0y,20y)
//        PenUp
//        Displacement(0y,58y)
//        PenDown
//        Displacement(98y,0y)
//        Displacement(0y,-20y)
//        Displacement(-98y,0y)
//        Displacement(0y,20y)
//        PenUp
//        Displacement(0y,-74y)
//        PenDown
//        Displacement(98y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-98y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(98y,0y)
//        PenUp
//        Displacement(0y,4y)
//        PenDown
//        Displacement(-98y,0y)
//        PenUp
//        Displacement(98y,58y)
//        PenDown
//        Displacement(-98y,0y)
//        PenUp
//        Displacement(0y,-4y)
//        PenDown
//        Displacement(98y,0y)
//        PenUp
//        Displacement(0y,-4y)
//        PenDown
//        Displacement(-98y,0y)
//        PenUp
//        Displacement(0y,-4y)
//        PenDown
//        Displacement(98y,0y)
//    ]
//    Map.fromInterface dict

//let sbhz =
//    let dict = Dictionary<uint16,Specification list>()
//    // ⒈
//    dict.[41649us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-8y,-8y)
//    ]
//    // ⒉
//    dict.[41650us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(8y,16y)
//        Displacement(16y,8y)
//        Displacement(16y,-8y)
//        Displacement(8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-40y,-64y)
//        Displacement(48y,0y)
//        Displacement(0y,16y)
//        PenUp
//        Displacement(16y,-8y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(0y,8y)
//        PenDown
//        Displacement(-8y,-8y)
//    ]
//    // ⒊
//    dict.[41651us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(8y,16y)
//        Displacement(16y,8y)
//        Displacement(16y,-8y)
//        Displacement(8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-16y)
//        Displacement(24y,-16y)
//        Displacement(8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-8y)
//        Displacement(-16y,8y)
//        Displacement(-8y,16y)
//        PenUp
//        Displacement(64y,-8y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(0y,8y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(0y,8y)
//        PenDown
//        Displacement(-8y,-8y)
//    ]
//    // ⒋
//    dict.[41652us] <- [
//        PenUp
//        Displacement(56y,111y)
//        PenDown
//        Displacement(-40y,-64y)
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-24y,64y)
//        PenDown
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(8y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(8y,-8y)
//    ]
//    // ⒌
//    dict.[41653us] <- [
//        PenUp
//        Displacement(79y,95y)
//        Displacement(0y,8y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-48y,0y)
//        Displacement(0y,-56y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-24y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(71y,-16y)
//        PenDown
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(0y,8y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(0y,8y)
//        PenDown
//        Displacement(8y,-8y)
//    ]
//    // ⒍
//    dict.[41654us] <- [
//        PenUp
//        Displacement(79y,95y)
//        PenDown
//        Displacement(-8y,16y)
//        Displacement(-32y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-71y)
//        Displacement(16y,-16y)
//        Displacement(24y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,24y)
//        Displacement(-8y,16y)
//        Displacement(-8y,8y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(71y,-48y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(0y,-8y)
//        PenDown
//        Displacement(-8y,8y)
//    ]
//    // ⒎
//    dict.[41655us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(56y,0y)
//        Displacement(-16y,-32y)
//        Displacement(-24y,-48y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(8y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(8y,-8y)
//    ]
//    // ⒏
//    dict.[41656us] <- [
//        PenUp
//        Displacement(40y,111y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(48y,-40y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,16y)
//        Displacement(48y,40y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//    ]
//    // ⒐
//    dict.[41657us] <- [
//        PenUp
//        Displacement(24y,32y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,71y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-24y)
//        Displacement(16y,-16y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(0y,0y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(24y,-56y)
//        PenDown
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(0y,8y)
//        Displacement(-8y,-8y)
//    ]
//    // ⒑
//    dict.[41658us] <- [
//        PenUp
//        Displacement(16y,103y)
//        Displacement(8y,0y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(-16y,16y)
//        Displacement(0y,71y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-71y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(48y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // ⒒
//    dict.[41659us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        Displacement(8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,103y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(40y,-95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // ⒓
//    dict.[41660us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(71y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-8y,8y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-40y,0y)
//        Displacement(32y,64y)
//        Displacement(8y,16y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-8y)
//    ]
//    // ⒔
//    dict.[41661us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,32y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-8y,8y)
//        Displacement(-24y,8y)
//        Displacement(24y,8y)
//        Displacement(8y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(56y,-71y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // ⒕
//    dict.[41662us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,103y)
//        Displacement(-40y,-79y)
//        Displacement(56y,0y)
//        PenUp
//        Displacement(16y,-16y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(0y,8y)
//        Displacement(8y,0y)
//        Displacement(-8y,-8y)
//    ]
//    // ⒖
//    dict.[41663us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(8y,24y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,56y)
//        Displacement(48y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(16y,-95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // ⒗
//    dict.[41664us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(71y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-8y,79y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,8y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-71y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-8y)
//    ]
//    // ⒘
//    dict.[41665us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(-8y,16y)
//        Displacement(0y,8y)
//        Displacement(40y,79y)
//        Displacement(-48y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(40y,-87y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(0y,8y)
//        Displacement(8y,-8y)
//    ]
//    // ⒙
//    dict.[41666us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(-16y,16y)
//        Displacement(0y,16y)
//        Displacement(48y,40y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(48y,-40y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(48y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // ⒚
//    dict.[41667us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(71y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-56y,24y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(8y,0y)
//        Displacement(8y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,71y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-24y)
//        Displacement(16y,-16y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//    ]
//    // ⒛
//    dict.[41668us] <- [
//        PenUp
//        Displacement(8y,87y)
//        PenDown
//        Displacement(8y,16y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(0y,-32y)
//        Displacement(-40y,-64y)
//        Displacement(40y,0y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(0y,87y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-87y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(40y,0y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(0y,8y)
//        Displacement(8y,-8y)
//    ]
//    // ⑴
//    dict.[41669us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-40y,-16y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ⑵
//    dict.[41670us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-56y,-32y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-48y,-40y)
//        Displacement(48y,0y)
//        Displacement(0y,8y)
//    ]
//    // ⑶
//    dict.[41671us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-48y)
//        Displacement(0y,-8y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-56y,-32y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-24y,-16y)
//        Displacement(24y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,8y)
//    ]
//    // ⑷
//    dict.[41672us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(-40y,-64y)
//        Displacement(56y,0y)
//        PenUp
//        Displacement(-24y,-24y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//    ]
//    // ⑸
//    dict.[41673us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-24y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-48y,0y)
//        Displacement(0y,-40y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//        Displacement(0y,8y)
//    ]
//    // ⑹
//    dict.[41674us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-24y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,8y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-48y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-8y)
//    ]
//    // ⑺
//    dict.[41675us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(48y,0y)
//        Displacement(-24y,-48y)
//        Displacement(-8y,-32y)
//        PenUp
//        Displacement(-24y,-8y)
//        PenDown
//        Displacement(-16y,24y)
//        Displacement(0y,56y)
//        Displacement(16y,24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(-16y,-24y)
//    ]
//    // ⑻
//    dict.[41676us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-24y,-8y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(48y,-32y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,8y)
//        Displacement(48y,32y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//    ]
//    // ⑼
//    dict.[41677us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-56y,-71y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,40y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//    ]
//    // ⑽
//    dict.[41678us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-64y)
//        Displacement(8y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,64y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-48y,-8y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ⑾
//    dict.[41679us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-16y,-16y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,79y)
//        Displacement(-8y,-8y)
//    ]
//    // ⑿
//    dict.[41680us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-56y,-16y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(40y,8y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-32y,0y)
//        Displacement(32y,56y)
//        Displacement(0y,16y)
//        Displacement(-8y,8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-8y)
//    ]
//    // ⒀
//    dict.[41681us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-40y,-24y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-24y,-16y)
//        Displacement(24y,-8y)
//        Displacement(0y,-24y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,79y)
//        Displacement(-8y,-8y)
//    ]
//    // ⒁
//    dict.[41682us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(-32y,-56y)
//        Displacement(48y,0y)
//        PenUp
//        Displacement(-8y,-24y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(8y,0y)
//        Displacement(0y,79y)
//        PenUp
//        Displacement(-48y,-8y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-16y,0y)
//    ]
//    // ⒂
//    dict.[41683us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(8y,-24y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-40y,0y)
//        Displacement(0y,-32y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-24y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,0y)
//        Displacement(-8y,16y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(-8y,-24y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(8y,0y)
//        Displacement(0y,79y)
//        PenUp
//        Displacement(0y,0y)
//        PenDown
//        Displacement(-8y,-8y)
//    ]
//    // ⒃
//    dict.[41684us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(0y,-24y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-64y)
//        Displacement(8y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,32y)
//        Displacement(-8y,8y)
//        Displacement(-8y,0y)
//        Displacement(-16y,-8y)
//        PenUp
//        Displacement(-8y,-40y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(8y,0y)
//        Displacement(0y,79y)
//        Displacement(-8y,-8y)
//    ]
//    // ⒄
//    dict.[41685us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-32y,-24y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(32y,0y)
//        Displacement(-24y,-56y)
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(8y,0y)
//        Displacement(0y,79y)
//        Displacement(-8y,-8y)
//    ]
//    // ⒅
//    dict.[41686us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-24y)
//        Displacement(32y,-16y)
//        Displacement(0y,-24y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,8y)
//        Displacement(0y,24y)
//        Displacement(32y,16y)
//        Displacement(0y,24y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-48y,-8y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ⒆
//    dict.[41687us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-64y)
//        Displacement(16y,-16y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-24y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//        Displacement(0y,32y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(8y,-16y)
//        PenDown
//        Displacement(0y,-56y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(-8y,-16y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(8y,0y)
//        Displacement(0y,79y)
//        Displacement(-8y,-8y)
//    ]
//    // ⒇
//    dict.[41688us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-64y)
//        Displacement(8y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,64y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-64y,-8y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-24y)
//        Displacement(-32y,-48y)
//        Displacement(32y,0y)
//        Displacement(0y,8y)
//    ]
//    // ①
//    dict.[41689us] <- [
//        PenUp
//        Displacement(0y,48y)
//        PenDown
//        Displacement(16y,-24y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(32y,0y)
//        Displacement(16y,8y)
//        Displacement(16y,16y)
//        Displacement(8y,16y)
//        Displacement(0y,32y)
//        Displacement(-8y,16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,8y)
//        Displacement(-32y,0y)
//        Displacement(-24y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-24y)
//        PenUp
//        Displacement(56y,-16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,71y)
//        Displacement(-8y,-8y)
//    ]
//    // ②
//    dict.[41690us] <- [
//        PenUp
//        Displacement(8y,79y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-16y)
//        Displacement(24y,0y)
//        Displacement(24y,16y)
//        Displacement(16y,24y)
//        Displacement(0y,32y)
//        Displacement(-16y,24y)
//        Displacement(-24y,16y)
//        Displacement(-24y,0y)
//        Displacement(-24y,-16y)
//        Displacement(-16y,-24y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-48y,-40y)
//        Displacement(48y,0y)
//        Displacement(0y,8y)
//    ]
//    // ③
//    dict.[41691us] <- [
//        PenUp
//        Displacement(16y,95y)
//        PenDown
//        Displacement(-8y,-16y)
//        Displacement(0y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-16y)
//        Displacement(32y,0y)
//        Displacement(24y,16y)
//        Displacement(8y,24y)
//        Displacement(0y,32y)
//        Displacement(-16y,24y)
//        Displacement(-16y,16y)
//        Displacement(-32y,0y)
//        Displacement(-24y,-16y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(24y,-16y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-24y,-16y)
//        Displacement(24y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,8y)
//    ]
//    // ④
//    dict.[41692us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-16y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(0y,0y)
//        PenUp
//        Displacement(0y,0y)
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(24y,16y)
//        Displacement(16y,24y)
//        Displacement(0y,32y)
//        Displacement(-16y,24y)
//        Displacement(-32y,16y)
//        Displacement(-16y,0y)
//        Displacement(-24y,-16y)
//        PenUp
//        Displacement(48y,0y)
//        PenDown
//        Displacement(-40y,-56y)
//        Displacement(56y,0y)
//        PenUp
//        Displacement(-8y,-24y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,79y)
//    ]
//    // ⑤
//    dict.[41693us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-16y)
//        Displacement(24y,0y)
//        Displacement(24y,16y)
//        Displacement(16y,24y)
//        Displacement(0y,32y)
//        Displacement(-16y,24y)
//        Displacement(-24y,16y)
//        Displacement(-24y,0y)
//        Displacement(-24y,-16y)
//        PenUp
//        Displacement(64y,-16y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-48y,0y)
//        Displacement(0y,-40y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//    ]
//    // ⑥
//    dict.[41694us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-16y)
//        Displacement(24y,0y)
//        Displacement(24y,16y)
//        Displacement(16y,24y)
//        Displacement(0y,32y)
//        Displacement(-8y,16y)
//        Displacement(-32y,24y)
//        Displacement(-24y,0y)
//        Displacement(-24y,-16y)
//        PenUp
//        Displacement(64y,-16y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,8y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-48y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-8y,0y)
//        Displacement(-8y,0y)
//        Displacement(-16y,-8y)
//    ]
//    // ⑦
//    dict.[41695us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-16y)
//        Displacement(24y,0y)
//        Displacement(24y,16y)
//        Displacement(16y,24y)
//        Displacement(0y,32y)
//        Displacement(-8y,16y)
//        Displacement(-24y,24y)
//        Displacement(-32y,0y)
//        Displacement(-24y,-16y)
//        PenUp
//        Displacement(16y,-16y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(48y,0y)
//        Displacement(-32y,-56y)
//        Displacement(0y,-16y)
//    ]
//    // ⑧
//    dict.[41696us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-16y)
//        Displacement(24y,0y)
//        Displacement(24y,16y)
//        Displacement(16y,24y)
//        Displacement(0y,32y)
//        Displacement(-16y,24y)
//        Displacement(-24y,16y)
//        Displacement(-24y,0y)
//        Displacement(-24y,-16y)
//        PenUp
//        Displacement(16y,-16y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(48y,-32y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,8y)
//        Displacement(48y,32y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-8y)
//    ]
//    // ⑨
//    dict.[41697us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-16y)
//        Displacement(24y,0y)
//        Displacement(24y,16y)
//        Displacement(16y,24y)
//        Displacement(0y,32y)
//        Displacement(-16y,24y)
//        Displacement(-24y,16y)
//        Displacement(-24y,0y)
//        Displacement(-24y,-16y)
//        PenUp
//        Displacement(16y,-64y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,40y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(24y,8y)
//    ]
//    // ⑩
//    dict.[41698us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-16y)
//        Displacement(24y,0y)
//        Displacement(24y,16y)
//        Displacement(16y,24y)
//        Displacement(0y,32y)
//        Displacement(-16y,24y)
//        Displacement(-24y,16y)
//        Displacement(-24y,0y)
//        Displacement(-24y,-16y)
//        PenUp
//        Displacement(16y,-8y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-71y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(-8y,8y)
//        Displacement(0y,56y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-56y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,0y)
//    ]
//    // ㈠
//    dict.[41701us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(0y,-48y)
//        PenDown
//        Displacement(-64y,0y)
//    ]
//    // ㈡
//    dict.[41702us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-24y)
//        PenDown
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(-8y,-56y)
//        PenDown
//        Displacement(64y,0y)
//    ]
//    // ㈢
//    dict.[41703us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-16y)
//        PenDown
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(8y,-32y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(16y,-32y)
//        PenDown
//        Displacement(-64y,0y)
//    ]
//    // ㈣
//    dict.[41704us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(0y,-24y)
//        PenDown
//        Displacement(-64y,0y)
//        Displacement(0y,-56y)
//        Displacement(64y,0y)
//        Displacement(0y,56y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(24y,0y)
//        PenUp
//        Displacement(-64y,0y)
//        PenDown
//        Displacement(24y,8y)
//        Displacement(0y,32y)
//    ]
//    // ㈤
//    dict.[41705us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-8y,-16y)
//        PenDown
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(0y,-24y)
//        PenDown
//        Displacement(40y,0y)
//        Displacement(0y,-40y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(-64y,0y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(0y,64y)
//    ]
//    // ㈥
//    dict.[41706us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(0y,-24y)
//        PenDown
//        Displacement(-64y,0y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(8y,-16y)
//        PenUp
//        Displacement(8y,-24y)
//        PenDown
//        Displacement(16y,-48y)
//        PenUp
//        Displacement(-48y,0y)
//        PenDown
//        Displacement(8y,40y)
//    ]
//    // ㈦
//    dict.[41707us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(0y,-32y)
//        PenDown
//        Displacement(-64y,-16y)
//        PenUp
//        Displacement(24y,40y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//        Displacement(8y,8y)
//    ]
//    // ㈧
//    dict.[41708us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-24y,-8y)
//        PenDown
//        Displacement(24y,-79y)
//        PenUp
//        Displacement(-71y,0y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(8y,32y)
//        Displacement(0y,24y)
//    ]
//    // ㈨
//    dict.[41709us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(-40y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        Displacement(-24y,-24y)
//        PenUp
//        Displacement(8y,64y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(-16y,-64y)
//        Displacement(24y,0y)
//        Displacement(0y,8y)
//    ]
//    // ㈩
//    dict.[41710us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-16y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(0y,56y)
//        Displacement(-16y,24y)
//        PenUp
//        Displacement(0y,-48y)
//        PenDown
//        Displacement(-64y,0y)
//        PenUp
//        Displacement(32y,40y)
//        PenDown
//        Displacement(0y,-87y)
//    ]
//    // Ⅰ
//    dict.[41713us] <- [
//        PenUp
//        Displacement(40y,127y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(32y,0y)
//    ]
//    // Ⅱ
//    dict.[41714us] <- [
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅲ
//    dict.[41715us] <- [
//        PenUp
//        Displacement(16y,127y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅳ
//    dict.[41716us] <- [
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(24y,-127y)
//        Displacement(24y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅴ
//    dict.[41717us] <- [
//        PenUp
//        Displacement(16y,127y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(32y,-127y)
//        Displacement(32y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅵ
//    dict.[41718us] <- [
//        PenUp
//        Displacement(8y,127y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(24y,-127y)
//        Displacement(24y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅶ
//    dict.[41719us] <- [
//        PenUp
//        Displacement(0y,127y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(24y,-127y)
//        Displacement(24y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅷ
//    dict.[41720us] <- [
//        PenUp
//        Displacement(0y,127y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,-127y)
//        Displacement(16y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅸ
//    dict.[41721us] <- [
//        PenUp
//        Displacement(8y,127y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(48y,127y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(-32y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(48y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅹ
//    dict.[41722us] <- [
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(64y,127y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(-48y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(64y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅺ
//    dict.[41723us] <- [
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(48y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-48y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ⅻ
//    dict.[41724us] <- [
//        PenUp
//        Displacement(0y,127y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(40y,-127y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(40y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ！
//    dict.[41889us] <- [
//        PenUp
//        Displacement(64y,111y)
//        PenDown
//        Displacement(-8y,-71y)
//        Displacement(0y,71y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(-8y,-87y)
//        PenDown
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(0y,8y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(0y,8y)
//        PenDown
//        Displacement(8y,-8y)
//    ]
//    // ＂
//    dict.[41890us] <- [
//        PenUp
//        Displacement(48y,87y)
//        PenDown
//        Displacement(0y,-56y)
//        Displacement(8y,56y)
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(0y,-56y)
//        Displacement(8y,56y)
//        Displacement(-8y,0y)
//    ]
//    // ＃
//    dict.[41891us] <- [
//        PenUp
//        Displacement(32y,79y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(0y,-32y)
//        PenDown
//        Displacement(-64y,0y)
//        PenUp
//        Displacement(16y,-32y)
//        PenDown
//        Displacement(0y,87y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(0y,-87y)
//    ]
//    // ￥
//    dict.[41892us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(32y,-32y)
//        Displacement(32y,32y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(-40y,-32y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,48y)
//        PenDown
//        Displacement(-48y,0y)
//    ]
//    // ％
//    dict.[41893us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,8y)
//        Displacement(-8y,8y)
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(56y,-56y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,8y)
//        Displacement(-8y,8y)
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-64y,-24y)
//        PenDown
//        Displacement(79y,79y)
//    ]
//    // ＆
//    dict.[41894us] <- [
//        PenUp
//        Displacement(111y,16y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-32y,40y)
//        Displacement(-16y,32y)
//        Displacement(8y,16y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-64y,-48y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,0y)
//        Displacement(32y,24y)
//        Displacement(24y,24y)
//        Displacement(-8y,0y)
//    ]
//    // ＇
//    dict.[41895us] <- [
//        PenUp
//        Displacement(79y,103y)
//        PenDown
//        Displacement(-24y,-48y)
//        Displacement(32y,40y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(0y,-8y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//        Displacement(0y,-8y)
//        Displacement(-24y,-40y)
//    ]
//    // （
//    dict.[41896us] <- [
//        PenUp
//        Displacement(79y,127y)
//        PenDown
//        Displacement(-24y,-8y)
//        Displacement(-16y,-24y)
//        Displacement(-8y,-32y)
//        Displacement(8y,-32y)
//        Displacement(16y,-24y)
//        Displacement(24y,-8y)
//    ]
//    // ）
//    dict.[41897us] <- [
//        PenUp
//        Displacement(32y,127y)
//        PenDown
//        Displacement(24y,-8y)
//        Displacement(24y,-24y)
//        Displacement(8y,-32y)
//        Displacement(-8y,-32y)
//        Displacement(-24y,-24y)
//        Displacement(-24y,-8y)
//    ]
//    // ＊
//    dict.[41898us] <- [
//        PenUp
//        Displacement(8y,79y)
//        PenDown
//        Displacement(48y,-16y)
//        Displacement(48y,16y)
//        PenUp
//        Displacement(-48y,32y)
//        PenDown
//        Displacement(0y,-48y)
//        Displacement(-32y,-40y)
//        PenUp
//        Displacement(32y,40y)
//        PenDown
//        Displacement(32y,-40y)
//    ]
//    // ＋
//    dict.[41899us] <- [
//        PenUp
//        Displacement(0y,64y)
//        PenDown
//        Displacement(111y,0y)
//        PenUp
//        Displacement(-56y,48y)
//        PenDown
//        Displacement(0y,-95y)
//    ]
//    // ，
//    dict.[41900us] <- [
//        PenUp
//        Displacement(24y,40y)
//        PenDown
//        Displacement(24y,-16y)
//        Displacement(-8y,0y)
//        Displacement(-24y,-16y)
//    ]
//    // －
//    dict.[41901us] <- [
//        PenUp
//        Displacement(0y,64y)
//        PenDown
//        Displacement(111y,0y)
//    ]
//    // ．
//    dict.[41902us] <- [
//        PenUp
//        Displacement(24y,32y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(-16y,0y)
//        Displacement(8y,16y)
//    ]
//    // ／
//    dict.[41903us] <- [
//        PenUp
//        Displacement(87y,127y)
//        PenDown
//        Displacement(-64y,-127y)
//    ]
//    // ０
//    dict.[41904us] <- [
//        PenUp
//        Displacement(16y,32y)
//        PenDown
//        Displacement(24y,-24y)
//        Displacement(32y,0y)
//        Displacement(24y,24y)
//        Displacement(0y,64y)
//        Displacement(-24y,24y)
//        Displacement(-32y,0y)
//        Displacement(-24y,-24y)
//        Displacement(0y,-64y)
//    ]
//    // １
//    dict.[41905us] <- [
//        PenUp
//        Displacement(56y,119y)
//        PenDown
//        Displacement(0y,-111y)
//    ]
//    // ２
//    dict.[41906us] <- [
//        PenUp
//        Displacement(16y,71y)
//        PenDown
//        Displacement(0y,32y)
//        Displacement(16y,16y)
//        Displacement(48y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-24y,-24y)
//        Displacement(-48y,-24y)
//        Displacement(-16y,-16y)
//        Displacement(95y,0y)
//    ]
//    // ３
//    dict.[41907us] <- [
//        PenUp
//        Displacement(16y,119y)
//        PenDown
//        Displacement(79y,0y)
//        Displacement(-40y,-40y)
//        Displacement(16y,0y)
//        Displacement(24y,-24y)
//        Displacement(0y,-24y)
//        Displacement(-24y,-24y)
//        Displacement(-32y,0y)
//        Displacement(-24y,24y)
//        Displacement(0y,16y)
//    ]
//    // ４
//    dict.[41908us] <- [
//        PenUp
//        Displacement(71y,8y)
//        PenDown
//        Displacement(0y,111y)
//        Displacement(-64y,-79y)
//        Displacement(95y,0y)
//    ]
//    // ５
//    dict.[41909us] <- [
//        PenUp
//        Displacement(16y,32y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(16y,-16y)
//        Displacement(48y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(-16y,16y)
//        Displacement(-48y,0y)
//        Displacement(-16y,-8y)
//        Displacement(0y,56y)
//        Displacement(79y,0y)
//    ]
//    // ６
//    dict.[41910us] <- [
//        PenUp
//        Displacement(95y,119y)
//        PenDown
//        Displacement(-32y,-8y)
//        Displacement(-32y,-24y)
//        Displacement(-16y,-24y)
//        Displacement(0y,-40y)
//        Displacement(16y,-16y)
//        Displacement(48y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,24y)
//        Displacement(-16y,16y)
//        Displacement(-48y,0y)
//        Displacement(-16y,-16y)
//    ]
//    // ７
//    dict.[41911us] <- [
//        PenUp
//        Displacement(16y,119y)
//        PenDown
//        Displacement(79y,0y)
//        Displacement(-40y,-64y)
//        Displacement(-24y,-48y)
//    ]
//    // ８
//    dict.[41912us] <- [
//        PenUp
//        Displacement(71y,71y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(8y,16y)
//        Displacement(-8y,16y)
//        Displacement(-16y,8y)
//        Displacement(-32y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(8y,-16y)
//        Displacement(16y,-8y)
//        Displacement(32y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-8y)
//        Displacement(-32y,0y)
//        Displacement(-16y,8y)
//        Displacement(-8y,16y)
//        Displacement(0y,8y)
//        Displacement(8y,16y)
//        Displacement(16y,8y)
//        Displacement(32y,8y)
//    ]
//    // ９
//    dict.[41913us] <- [
//        PenUp
//        Displacement(95y,71y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(-48y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,32y)
//        Displacement(16y,16y)
//        Displacement(48y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-16y,-32y)
//        Displacement(-48y,-40y)
//    ]
//    // ：
//    dict.[41914us] <- [
//        PenUp
//        Displacement(24y,71y)
//        PenDown
//        Displacement(16y,-16y)
//        PenUp
//        Displacement(-16y,-32y)
//        PenDown
//        Displacement(16y,-16y)
//    ]
//    // ；
//    dict.[41915us] <- [
//        PenUp
//        Displacement(24y,71y)
//        PenDown
//        Displacement(16y,-16y)
//        PenUp
//        Displacement(-16y,-24y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(-8y,0y)
//        Displacement(-16y,-16y)
//    ]
//    // ＜
//    dict.[41916us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-111y,-48y)
//        Displacement(111y,-48y)
//    ]
//    // ＝
//    dict.[41917us] <- [
//        PenUp
//        Displacement(0y,79y)
//        PenDown
//        Displacement(111y,0y)
//        PenUp
//        Displacement(0y,-40y)
//        PenDown
//        Displacement(-111y,0y)
//    ]
//    // ＞
//    dict.[41918us] <- [
//        PenUp
//        Displacement(0y,111y)
//        PenDown
//        Displacement(111y,-48y)
//        Displacement(-111y,-48y)
//    ]
//    // ？
//    dict.[41919us] <- [
//        PenUp
//        Displacement(32y,64y)
//        PenDown
//        Displacement(-16y,16y)
//        Displacement(0y,16y)
//        Displacement(16y,16y)
//        Displacement(24y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-24y)
//        Displacement(-24y,-16y)
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(-16y,-16y)
//        PenDown
//        Displacement(24y,-16y)
//    ]
//    // ＠
//    dict.[41920us] <- [
//        PenUp
//        Displacement(71y,56y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,24y)
//        Displacement(16y,16y)
//        Displacement(32y,0y)
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(-32y,32y)
//        Displacement(-48y,0y)
//        Displacement(-32y,-32y)
//        Displacement(0y,-40y)
//        Displacement(32y,-32y)
//        Displacement(48y,0y)
//        Displacement(24y,16y)
//    ]
//    // Ａ
//    dict.[41921us] <- [
//        PenUp
//        Displacement(0y,0y)
//        PenDown
//        Displacement(56y,127y)
//        Displacement(56y,-127y)
//        PenUp
//        Displacement(-16y,32y)
//        PenDown
//        Displacement(-79y,0y)
//    ]
//    // Ｂ
//    dict.[41922us] <- [
//        PenUp
//        Displacement(79y,64y)
//        PenDown
//        Displacement(24y,16y)
//        Displacement(0y,32y)
//        Displacement(-24y,16y)
//        Displacement(-71y,0y)
//        Displacement(0y,-127y)
//        Displacement(71y,0y)
//        Displacement(32y,16y)
//        Displacement(0y,32y)
//        Displacement(-32y,16y)
//        Displacement(-71y,0y)
//    ]
//    // Ｃ
//    dict.[41923us] <- [
//        PenUp
//        Displacement(111y,127y)
//        PenDown
//        Displacement(-71y,0y)
//        Displacement(-32y,-32y)
//        Displacement(0y,-64y)
//        Displacement(32y,-32y)
//        Displacement(71y,0y)
//    ]
//    // Ｄ
//    dict.[41924us] <- [
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        Displacement(71y,0y)
//        Displacement(32y,-32y)
//        Displacement(0y,-64y)
//        Displacement(-32y,-32y)
//        Displacement(-71y,0y)
//    ]
//    // Ｅ
//    dict.[41925us] <- [
//        PenUp
//        Displacement(111y,127y)
//        PenDown
//        Displacement(-103y,0y)
//        Displacement(0y,-127y)
//        Displacement(103y,0y)
//        PenUp
//        Displacement(-24y,64y)
//        PenDown
//        Displacement(-79y,0y)
//    ]
//    // Ｆ
//    dict.[41926us] <- [
//        PenUp
//        Displacement(111y,127y)
//        PenDown
//        Displacement(-103y,0y)
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(0y,64y)
//        PenDown
//        Displacement(79y,0y)
//    ]
//    // Ｇ
//    dict.[41927us] <- [
//        PenUp
//        Displacement(111y,127y)
//        PenDown
//        Displacement(-79y,0y)
//        Displacement(-24y,-24y)
//        Displacement(0y,-79y)
//        Displacement(24y,-24y)
//        Displacement(79y,0y)
//        Displacement(0y,64y)
//        Displacement(-32y,0y)
//    ]
//    // Ｈ
//    dict.[41928us] <- [
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        PenUp
//        Displacement(103y,0y)
//        PenDown
//        Displacement(0y,-127y)
//        PenUp
//        Displacement(-103y,64y)
//        PenDown
//        Displacement(103y,0y)
//    ]
//    // Ｉ
//    dict.[41929us] <- [
//        PenUp
//        Displacement(56y,127y)
//        PenDown
//        Displacement(0y,-127y)
//    ]
//    // Ｊ
//    dict.[41930us] <- [
//        PenUp
//        Displacement(71y,127y)
//        PenDown
//        Displacement(0y,-103y)
//        Displacement(-24y,-24y)
//        Displacement(-32y,0y)
//    ]
//    // Ｋ
//    dict.[41931us] <- [
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        PenUp
//        Displacement(103y,0y)
//        PenDown
//        Displacement(-103y,-64y)
//        PenUp
//        Displacement(16y,8y)
//        PenDown
//        Displacement(87y,-71y)
//    ]
//    // Ｌ
//    dict.[41932us] <- [
//        PenUp
//        Displacement(16y,127y)
//        PenDown
//        Displacement(0y,-127y)
//        Displacement(95y,0y)
//    ]
//    // Ｍ
//    dict.[41933us] <- [
//        PenUp
//        Displacement(0y,0y)
//        PenDown
//        Displacement(0y,127y)
//        Displacement(56y,-56y)
//        Displacement(56y,56y)
//        Displacement(0y,-127y)
//    ]
//    // Ｎ
//    dict.[41934us] <- [
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        Displacement(103y,-127y)
//        Displacement(0y,127y)
//    ]
//    // Ｏ
//    dict.[41935us] <- [
//        PenUp
//        Displacement(8y,103y)
//        PenDown
//        Displacement(0y,-79y)
//        Displacement(24y,-24y)
//        Displacement(56y,0y)
//        Displacement(24y,24y)
//        Displacement(0y,79y)
//        Displacement(-24y,24y)
//        Displacement(-56y,0y)
//        Displacement(-24y,-24y)
//    ]
//    // Ｐ
//    dict.[41936us] <- [
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        Displacement(71y,0y)
//        Displacement(32y,-24y)
//        Displacement(0y,-32y)
//        Displacement(-32y,-16y)
//        Displacement(-71y,0y)
//    ]
//    // Ｑ
//    dict.[41937us] <- [
//        PenUp
//        Displacement(8y,103y)
//        PenDown
//        Displacement(0y,-79y)
//        Displacement(24y,-24y)
//        Displacement(56y,0y)
//        Displacement(24y,24y)
//        Displacement(0y,79y)
//        Displacement(-24y,24y)
//        Displacement(-56y,0y)
//        Displacement(-24y,-24y)
//        PenUp
//        Displacement(56y,-64y)
//        PenDown
//        Displacement(48y,-40y)
//    ]
//    // Ｒ
//    dict.[41938us] <- [
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,127y)
//        Displacement(79y,0y)
//        Displacement(24y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-24y,-16y)
//        Displacement(-79y,0y)
//        PenUp
//        Displacement(48y,0y)
//        PenDown
//        Displacement(56y,-64y)
//    ]
//    // Ｓ
//    dict.[41939us] <- [
//        PenUp
//        Displacement(8y,16y)
//        PenDown
//        Displacement(24y,-16y)
//        Displacement(56y,0y)
//        Displacement(24y,16y)
//        Displacement(0y,24y)
//        Displacement(-24y,16y)
//        Displacement(-56y,16y)
//        Displacement(-24y,16y)
//        Displacement(0y,24y)
//        Displacement(24y,16y)
//        Displacement(56y,0y)
//        Displacement(24y,-16y)
//    ]
//    // Ｔ
//    dict.[41940us] <- [
//        PenUp
//        Displacement(0y,127y)
//        PenDown
//        Displacement(111y,0y)
//        PenUp
//        Displacement(-56y,0y)
//        PenDown
//        Displacement(0y,-127y)
//    ]
//    // Ｕ
//    dict.[41941us] <- [
//        PenUp
//        Displacement(8y,127y)
//        PenDown
//        Displacement(0y,-95y)
//        Displacement(24y,-32y)
//        Displacement(56y,0y)
//        Displacement(24y,32y)
//        Displacement(0y,95y)
//    ]
//    // Ｖ
//    dict.[41942us] <- [
//        PenUp
//        Displacement(0y,127y)
//        PenDown
//        Displacement(56y,-127y)
//        Displacement(56y,127y)
//    ]
//    // Ｗ
//    dict.[41943us] <- [
//        PenUp
//        Displacement(0y,127y)
//        PenDown
//        Displacement(24y,-127y)
//        Displacement(32y,64y)
//        Displacement(32y,-64y)
//        Displacement(24y,127y)
//    ]
//    // Ｘ
//    dict.[41944us] <- [
//        PenUp
//        Displacement(0y,127y)
//        Displacement(0y,0y)
//        PenDown
//        Displacement(111y,-127y)
//        PenUp
//        Displacement(-111y,0y)
//        PenDown
//        Displacement(111y,127y)
//    ]
//    // Ｙ
//    dict.[41945us] <- [
//        PenUp
//        Displacement(0y,127y)
//        PenDown
//        Displacement(56y,-48y)
//        PenUp
//        Displacement(56y,48y)
//        PenDown
//        Displacement(-56y,-48y)
//        Displacement(0y,-79y)
//    ]
//    // Ｚ
//    dict.[41946us] <- [
//        PenUp
//        Displacement(8y,127y)
//        PenDown
//        Displacement(95y,0y)
//        Displacement(-103y,-127y)
//        Displacement(111y,0y)
//    ]
//    // ［
//    dict.[41947us] <- [
//        PenUp
//        Displacement(95y,111y)
//        PenDown
//        Displacement(-56y,0y)
//        Displacement(0y,-103y)
//        Displacement(56y,0y)
//    ]
//    // ＼
//    dict.[41948us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(87y,-87y)
//    ]
//    // ］
//    dict.[41949us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(56y,0y)
//        Displacement(0y,-103y)
//        Displacement(-56y,0y)
//    ]
//    // ＾
//    dict.[41950us] <- [
//        PenUp
//        Displacement(64y,119y)
//        PenDown
//        Displacement(-32y,-56y)
//        PenUp
//        Displacement(64y,0y)
//        PenDown
//        Displacement(-32y,56y)
//    ]
//    // ＿
//    dict.[41951us] <- [
//        PenUp
//        Displacement(32y,40y)
//        PenDown
//        Displacement(64y,0y)
//    ]
//    // ｀
//    dict.[41952us] <- [
//        PenUp
//        Displacement(56y,119y)
//        PenDown
//        Displacement(16y,-48y)
//        Displacement(-24y,40y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(0y,-8y)
//        PenDown
//        Displacement(16y,-40y)
//        Displacement(-16y,32y)
//        Displacement(-8y,8y)
//        Displacement(8y,0y)
//        Displacement(0y,8y)
//    ]
//    // ａ
//    dict.[41953us] <- [
//        PenUp
//        Displacement(32y,71y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(8y,8y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,8y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//    ]
//    // ｂ
//    dict.[41954us] <- [
//        PenUp
//        Displacement(48y,103y)
//        PenDown
//        Displacement(0y,-79y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-8y)
//    ]
//    // ｃ
//    dict.[41955us] <- [
//        PenUp
//        Displacement(87y,79y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,8y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        Displacement(0y,8y)
//    ]
//    // ｄ
//    dict.[41956us] <- [
//        PenUp
//        Displacement(71y,103y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,16y)
//        Displacement(0y,16y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(0y,-24y)
//        Displacement(8y,-8y)
//    ]
//    // ｅ
//    dict.[41957us] <- [
//        PenUp
//        Displacement(40y,64y)
//        PenDown
//        Displacement(56y,0y)
//        Displacement(0y,8y)
//        Displacement(-8y,16y)
//        Displacement(-32y,0y)
//        Displacement(-16y,-24y)
//        Displacement(0y,-16y)
//        Displacement(8y,-16y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        Displacement(0y,8y)
//    ]
//    // ｆ
//    dict.[41958us] <- [
//        PenUp
//        Displacement(40y,71y)
//        PenDown
//        Displacement(48y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(0y,24y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(-16y,-71y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(8y,0y)
//        Displacement(0y,71y)
//    ]
//    // ｇ
//    dict.[41959us] <- [
//        PenUp
//        Displacement(79y,95y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,16y)
//        PenUp
//        Displacement(-24y,-24y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//        Displacement(0y,16y)
//        Displacement(8y,8y)
//    ]
//    // ｈ
//    dict.[41960us] <- [
//        PenUp
//        Displacement(48y,103y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(0y,32y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(0y,-48y)
//    ]
//    // ｉ
//    dict.[41961us] <- [
//        PenUp
//        Displacement(56y,95y)
//        PenDown
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(-16y,-16y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ｊ
//    dict.[41962us] <- [
//        PenUp
//        Displacement(56y,103y)
//        PenDown
//        Displacement(0y,8y)
//        PenUp
//        Displacement(-16y,-24y)
//        PenDown
//        Displacement(16y,0y)
//        Displacement(0y,-64y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // ｋ
//    dict.[41963us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(-40y,40y)
//        Displacement(40y,24y)
//        Displacement(-8y,0y)
//    ]
//    // ｌ
//    dict.[41964us] <- [
//        PenUp
//        Displacement(56y,95y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ｍ
//    dict.[41965us] <- [
//        PenUp
//        Displacement(32y,24y)
//        PenDown
//        Displacement(0y,64y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(0y,64y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-64y)
//    ]
//    // ｎ
//    dict.[41966us] <- [
//        PenUp
//        Displacement(40y,24y)
//        PenDown
//        Displacement(0y,56y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,8y)
//        Displacement(24y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-56y)
//        Displacement(-8y,0y)
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-40y,0y)
//        PenDown
//        Displacement(-16y,0y)
//    ]
//    // ｏ
//    dict.[41967us] <- [
//        PenUp
//        Displacement(71y,32y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,32y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-16y,-16y)
//    ]
//    // ｐ
//    dict.[41968us] <- [
//        PenUp
//        Displacement(48y,16y)
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,71y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-24y)
//        Displacement(-16y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,8y)
//    ]
//    // ｑ
//    dict.[41969us] <- [
//        PenUp
//        Displacement(87y,16y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,79y)
//        Displacement(-16y,8y)
//        Displacement(-8y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-24y)
//        Displacement(16y,-16y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//    ]
//    // ｒ
//    dict.[41970us] <- [
//        PenUp
//        Displacement(48y,79y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,48y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//    ]
//    // ｓ
//    dict.[41971us] <- [
//        PenUp
//        Displacement(87y,79y)
//        PenDown
//        Displacement(0y,16y)
//        Displacement(0y,-16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(16y,-8y)
//        Displacement(32y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//    ]
//    // ｔ
//    dict.[41972us] <- [
//        PenUp
//        Displacement(40y,71y)
//        PenDown
//        Displacement(48y,0y)
//        PenUp
//        Displacement(-24y,24y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(24y,8y)
//    ]
//    // ｕ
//    dict.[41973us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-64y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,64y)
//        PenUp
//        Displacement(0y,-64y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//    ]
//    // ｖ
//    dict.[41974us] <- [
//        PenUp
//        Displacement(95y,87y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-24y,-64y)
//        Displacement(-24y,64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ｗ
//    dict.[41975us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(24y,-64y)
//        Displacement(24y,64y)
//        Displacement(16y,-64y)
//        Displacement(24y,64y)
//    ]
//    // ｘ
//    dict.[41976us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(48y,-40y)
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(0y,71y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-48y,-40y)
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ｙ
//    dict.[41977us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(24y,-48y)
//        PenUp
//        Displacement(24y,48y)
//        PenDown
//        Displacement(-8y,-32y)
//        Displacement(-48y,-48y)
//    ]
//    // ｚ
//    dict.[41978us] <- [
//        PenUp
//        Displacement(40y,79y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(48y,0y)
//        Displacement(0y,-8y)
//        Displacement(-48y,-40y)
//        Displacement(0y,-8y)
//        Displacement(48y,0y)
//        Displacement(0y,8y)
//    ]
//    // ｛
//    dict.[41979us] <- [
//        PenUp
//        Displacement(71y,119y)
//        PenDown
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-32y)
//        Displacement(-16y,-16y)
//        Displacement(16y,-16y)
//        Displacement(0y,-32y)
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//    ]
//    // ｜
//    dict.[41980us] <- [
//        PenUp
//        Displacement(64y,119y)
//        PenDown
//        Displacement(0y,-119y)
//    ]
//    // ｝
//    dict.[41981us] <- [
//        PenUp
//        Displacement(56y,119y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//    ]
//    // ￣
//    dict.[41982us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-95y,0y)
//    ]
//    // ぁ
//    dict.[42145us] <- [
//        PenUp
//        Displacement(32y,79y)
//        PenDown
//        Displacement(56y,8y)
//        PenUp
//        Displacement(-32y,16y)
//        PenDown
//        Displacement(0y,-71y)
//        PenUp
//        Displacement(8y,24y)
//        PenDown
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-16y,0y)
//        Displacement(0y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,8y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//    ]
//    // あ
//    dict.[42146us] <- [
//        PenUp
//        Displacement(64y,111y)
//        PenDown
//        Displacement(-8y,-16y)
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(0y,32y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,8y)
//        Displacement(16y,16y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        PenUp
//        Displacement(-56y,79y)
//        PenDown
//        Displacement(71y,0y)
//    ]
//    // ぃ
//    dict.[42147us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(24y,-16y)
//        Displacement(0y,16y)
//        PenUp
//        Displacement(16y,48y)
//        PenDown
//        Displacement(16y,-24y)
//        Displacement(0y,0y)
//    ]
//    // い
//    dict.[42148us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(8y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,-8y)
//        Displacement(0y,16y)
//        PenUp
//        Displacement(16y,56y)
//        PenDown
//        Displacement(16y,-24y)
//    ]
//    // ぅ
//    dict.[42149us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(32y,0y)
//        Displacement(8y,-8y)
//        Displacement(-32y,-16y)
//        PenUp
//        Displacement(-16y,-8y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-40y,-32y)
//    ]
//    // う
//    dict.[42150us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(32y,0y)
//        Displacement(8y,-8y)
//        Displacement(-24y,-16y)
//        PenUp
//        Displacement(-24y,-8y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-32y,-32y)
//    ]
//    // ぇ
//    dict.[42151us] <- [
//        PenUp
//        Displacement(48y,103y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(-16y,-8y)
//        PenUp
//        Displacement(-16y,-16y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(-48y,-48y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//    ]
//    // え
//    dict.[42152us] <- [
//        PenUp
//        Displacement(48y,103y)
//        PenDown
//        Displacement(16y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(-24y,-16y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(-56y,-56y)
//        PenUp
//        Displacement(32y,32y)
//        PenDown
//        Displacement(8y,-24y)
//        Displacement(8y,-8y)
//        Displacement(32y,0y)
//        Displacement(0y,8y)
//    ]
//    // ぉ
//    dict.[42153us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(24y,0y)
//        PenUp
//        Displacement(-16y,24y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-64y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(24y,24y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(8y,56y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // お
//    dict.[42154us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-71y)
//        Displacement(-16y,16y)
//        Displacement(48y,40y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,0y)
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(-8y,40y)
//        PenDown
//        Displacement(-32y,0y)
//        PenUp
//        Displacement(64y,24y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // か
//    dict.[42155us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(24y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-24y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-24y,-8y)
//        PenDown
//        Displacement(8y,16y)
//        Displacement(8y,24y)
//        Displacement(8y,32y)
//        Displacement(-8y,16y)
//        PenUp
//        Displacement(48y,-16y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//    ]
//    // が
//    dict.[42156us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(24y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-24y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-24y,-8y)
//        PenDown
//        Displacement(8y,16y)
//        Displacement(8y,16y)
//        Displacement(8y,40y)
//        Displacement(-8y,16y)
//        PenUp
//        Displacement(56y,8y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-24y)
//        Displacement(-8y,-8y)
//    ]
//    // き
//    dict.[42157us] <- [
//        PenUp
//        Displacement(32y,87y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(32y,8y)
//        PenUp
//        Displacement(-40y,16y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(16y,-32y)
//        Displacement(8y,-16y)
//        Displacement(8y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-48y,56y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(32y,8y)
//    ]
//    // ぎ
//    dict.[42158us] <- [
//        PenUp
//        Displacement(32y,87y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(32y,8y)
//        PenUp
//        Displacement(-40y,16y)
//        PenDown
//        Displacement(16y,-32y)
//        Displacement(8y,-16y)
//        Displacement(8y,-16y)
//        Displacement(8y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-48y,56y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(32y,8y)
//        PenUp
//        Displacement(8y,48y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // く
//    dict.[42159us] <- [
//        PenUp
//        Displacement(71y,103y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-32y,-32y)
//        Displacement(0y,-8y)
//        Displacement(32y,-40y)
//        Displacement(0y,-8y)
//    ]
//    // ぐ
//    dict.[42160us] <- [
//        PenUp
//        Displacement(71y,103y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-32y,-32y)
//        Displacement(0y,-8y)
//        Displacement(32y,-48y)
//        PenUp
//        Displacement(16y,79y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // け
//    dict.[42161us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-24y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(0y,16y)
//        PenUp
//        Displacement(24y,56y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-24y,24y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-56y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//    ]
//    // げ
//    dict.[42162us] <- [
//        PenUp
//        Displacement(16y,103y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(16y,-16y)
//        Displacement(0y,24y)
//        PenUp
//        Displacement(24y,40y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-24y,24y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-56y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-16y,-8y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // こ
//    dict.[42163us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(40y,0y)
//        Displacement(8y,-8y)
//        Displacement(-16y,-8y)
//        PenUp
//        Displacement(-40y,-32y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(40y,0y)
//        Displacement(16y,8y)
//    ]
//    // ご
//    dict.[42164us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(8y,-8y)
//        Displacement(-16y,-8y)
//        PenUp
//        Displacement(40y,16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(-56y,-40y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(16y,-8y)
//        Displacement(32y,0y)
//        Displacement(16y,8y)
//    ]
//    // さ
//    dict.[42165us] <- [
//        PenUp
//        Displacement(32y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(24y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(-40y,24y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(16y,-24y)
//        Displacement(16y,-32y)
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-24y,8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//    ]
//    // ざ
//    dict.[42166us] <- [
//        PenUp
//        Displacement(32y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(24y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(-40y,24y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(16y,-24y)
//        Displacement(16y,-32y)
//        Displacement(0y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        PenUp
//        Displacement(16y,111y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-16y,-8y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // し
//    dict.[42167us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,16y)
//    ]
//    // じ
//    dict.[42168us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,16y)
//        PenUp
//        Displacement(-24y,64y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // す
//    dict.[42169us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-40y,32y)
//        PenDown
//        Displacement(0y,-64y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//    ]
//    // ず
//    dict.[42170us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-40y,32y)
//        PenDown
//        Displacement(0y,-64y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        PenUp
//        Displacement(48y,111y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // せ
//    dict.[42171us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-24y,24y)
//        PenDown
//        Displacement(0y,-56y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-16y,48y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-8y)
//        Displacement(40y,0y)
//    ]
//    // ぜ
//    dict.[42172us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-24y,24y)
//        PenDown
//        Displacement(0y,-56y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-16y,48y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-8y)
//        Displacement(40y,0y)
//        PenUp
//        Displacement(0y,103y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-16y,-8y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // そ
//    dict.[42173us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(32y,0y)
//        Displacement(0y,-8y)
//        Displacement(-48y,-48y)
//        Displacement(64y,16y)
//        Displacement(-24y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//    ]
//    // ぞ
//    dict.[42174us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(32y,0y)
//        Displacement(0y,-8y)
//        Displacement(-48y,-48y)
//        Displacement(64y,16y)
//        Displacement(-24y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(-8y,79y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(8y,8y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // た
//    dict.[42175us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-16y,16y)
//        PenDown
//        Displacement(0y,-48y)
//        Displacement(-8y,-24y)
//        Displacement(-16y,-24y)
//        PenUp
//        Displacement(64y,71y)
//        PenDown
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(-24y,-24y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(16y,-16y)
//        Displacement(32y,0y)
//    ]
//    // だ
//    dict.[42176us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-16y,16y)
//        PenDown
//        Displacement(0y,-56y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-24y)
//        PenUp
//        Displacement(56y,40y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-32y,79y)
//        PenDown
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(-8y,-16y)
//        PenUp
//        Displacement(8y,32y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // ち
//    dict.[42177us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(48y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(-40y,16y)
//        PenDown
//        Displacement(0y,-48y)
//        Displacement(-16y,-32y)
//        Displacement(16y,16y)
//        Displacement(32y,0y)
//        Displacement(16y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-16y,0y)
//    ]
//    // ぢ
//    dict.[42178us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(32y,0y)
//        Displacement(8y,8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-16y,8y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,-8y)
//        PenUp
//        Displacement(24y,71y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // っ
//    dict.[42179us] <- [
//        PenUp
//        Displacement(32y,71y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,0y)
//    ]
//    // つ
//    dict.[42180us] <- [
//        PenUp
//        Displacement(16y,79y)
//        PenDown
//        Displacement(40y,0y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-24y,0y)
//    ]
//    // づ
//    dict.[42181us] <- [
//        PenUp
//        Displacement(16y,79y)
//        PenDown
//        Displacement(40y,0y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-8y)
//        Displacement(-24y,-8y)
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-16y,-8y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // て
//    dict.[42182us] <- [
//        PenUp
//        Displacement(103y,95y)
//        PenDown
//        Displacement(-8y,0y)
//        Displacement(-64y,-16y)
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(-8y,-40y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//    ]
//    // で
//    dict.[42183us] <- [
//        PenUp
//        Displacement(16y,79y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(56y,16y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(-32y,-8y)
//        PenDown
//        Displacement(-8y,-48y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        PenUp
//        Displacement(8y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // と
//    dict.[42184us] <- [
//        PenUp
//        Displacement(56y,103y)
//        PenDown
//        Displacement(0y,-40y)
//        PenUp
//        Displacement(16y,8y)
//        PenDown
//        Displacement(-24y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,0y)
//    ]
//    // ど
//    dict.[42185us] <- [
//        PenUp
//        Displacement(56y,103y)
//        PenDown
//        Displacement(0y,-40y)
//        PenUp
//        Displacement(16y,8y)
//        PenDown
//        Displacement(-32y,-24y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(24y,0y)
//        PenUp
//        Displacement(0y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // な
//    dict.[42186us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-16y,16y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        PenUp
//        Displacement(64y,64y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//        Displacement(-8y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(24y,-8y)
//        Displacement(8y,-8y)
//    ]
//    // に
//    dict.[42187us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-24y)
//        Displacement(16y,-24y)
//        Displacement(0y,8y)
//        Displacement(8y,16y)
//        PenUp
//        Displacement(16y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(24y,0y)
//        PenUp
//        Displacement(-8y,71y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//    ]
//    // ぬ
//    dict.[42188us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(0y,-24y)
//        Displacement(8y,-16y)
//        Displacement(24y,-24y)
//        PenUp
//        Displacement(-16y,71y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-24y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,16y)
//        Displacement(24y,16y)
//        Displacement(24y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//    ]
//    // ね
//    dict.[42189us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(0y,-95y)
//        PenUp
//        Displacement(-16y,71y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(-24y,-56y)
//        Displacement(24y,32y)
//        Displacement(24y,16y)
//        Displacement(24y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//    ]
//    // の
//    dict.[42190us] <- [
//        PenUp
//        Displacement(56y,87y)
//        PenDown
//        Displacement(-8y,-40y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,8y)
//        Displacement(-8y,16y)
//        Displacement(0y,16y)
//        Displacement(16y,16y)
//        Displacement(8y,8y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-16y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-24y)
//    ]
//    // は
//    dict.[42191us] <- [
//        PenUp
//        Displacement(24y,111y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(0y,24y)
//        PenUp
//        Displacement(16y,64y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(-24y,16y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//    ]
//    // ば
//    dict.[42192us] <- [
//        PenUp
//        Displacement(24y,111y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-24y)
//        Displacement(0y,16y)
//        PenUp
//        Displacement(16y,71y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(24y,0y)
//        PenUp
//        Displacement(-16y,24y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(-8y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // ぱ
//    dict.[42193us] <- [
//        PenUp
//        Displacement(24y,111y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-24y)
//        Displacement(16y,-16y)
//        Displacement(0y,24y)
//        PenUp
//        Displacement(16y,64y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(-24y,16y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(-8y,95y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(8y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//    ]
//    // ひ
//    dict.[42194us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,16y)
//        Displacement(0y,8y)
//        Displacement(-8y,16y)
//        Displacement(0y,40y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//    ]
//    // び
//    dict.[42195us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-24y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,16y)
//        Displacement(0y,8y)
//        Displacement(-8y,16y)
//        Displacement(0y,40y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(-16y,56y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // ぴ
//    dict.[42196us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-24y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,16y)
//        Displacement(0y,8y)
//        Displacement(-8y,16y)
//        Displacement(0y,40y)
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(16y,-16y)
//        PenUp
//        Displacement(-8y,48y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(8y,8y)
//    ]
//    // ふ
//    dict.[42197us] <- [
//        PenUp
//        Displacement(48y,95y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(16y,-16y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(-8y,8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,16y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-16y)
//    ]
//    // ぶ
//    dict.[42198us] <- [
//        PenUp
//        Displacement(48y,95y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(16y,-16y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        Displacement(8y,0y)
//        Displacement(8y,8y)
//        Displacement(8y,8y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-16y)
//        PenUp
//        Displacement(-16y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // ぷ
//    dict.[42199us] <- [
//        PenUp
//        Displacement(48y,95y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(16y,-16y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,16y)
//        Displacement(-24y,0y)
//        Displacement(-8y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,16y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-16y)
//        PenUp
//        Displacement(-8y,79y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,8y)
//        Displacement(-8y,8y)
//    ]
//    // へ
//    dict.[42200us] <- [
//        PenUp
//        Displacement(24y,56y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(24y,-24y)
//        Displacement(16y,-8y)
//        Displacement(32y,-8y)
//    ]
//    // べ
//    dict.[42201us] <- [
//        PenUp
//        Displacement(24y,56y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(24y,-24y)
//        Displacement(16y,-8y)
//        Displacement(32y,-8y)
//        PenUp
//        Displacement(-24y,79y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // ぺ
//    dict.[42202us] <- [
//        PenUp
//        Displacement(24y,56y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(24y,-24y)
//        Displacement(16y,-8y)
//        Displacement(32y,-8y)
//        PenUp
//        Displacement(-16y,71y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,8y)
//        Displacement(-8y,8y)
//    ]
//    // ほ
//    dict.[42203us] <- [
//        PenUp
//        Displacement(24y,111y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-24y)
//        Displacement(0y,16y)
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(8y,-24y)
//        PenDown
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//    ]
//    // ぼ
//    dict.[42204us] <- [
//        PenUp
//        Displacement(16y,111y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-24y)
//        Displacement(0y,16y)
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(8y,-24y)
//        PenDown
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(0y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // ぽ
//    dict.[42205us] <- [
//        PenUp
//        Displacement(16y,111y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-24y)
//        Displacement(16y,-16y)
//        Displacement(0y,16y)
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(8y,-24y)
//        PenDown
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(0y,-48y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(8y,95y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,8y)
//        Displacement(-8y,8y)
//    ]
//    // ま
//    dict.[42206us] <- [
//        PenUp
//        Displacement(48y,87y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(8y,-24y)
//        PenDown
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(24y,48y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//        Displacement(8y,8y)
//        Displacement(16y,8y)
//        Displacement(24y,-8y)
//        Displacement(8y,-8y)
//    ]
//    // み
//    dict.[42207us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-24y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,16y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-8y)
//        Displacement(24y,-16y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(-8y,56y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-24y)
//    ]
//    // む
//    dict.[42208us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-16y,16y)
//        PenDown
//        Displacement(0y,-64y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,16y)
//        Displacement(0y,16y)
//        Displacement(-8y,16y)
//        Displacement(0y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//    ]
//    // め
//    dict.[42209us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(8y,-16y)
//        Displacement(24y,-24y)
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-8y,64y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,8y)
//        Displacement(0y,16y)
//        Displacement(8y,16y)
//        Displacement(16y,24y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-16y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,-16y)
//    ]
//    // も
//    dict.[42210us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(-16y,64y)
//        PenDown
//        Displacement(0y,-79y)
//        Displacement(8y,-16y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        Displacement(8y,16y)
//        Displacement(0y,8y)
//        Displacement(-8y,16y)
//        Displacement(-8y,8y)
//    ]
//    // ゃ
//    dict.[42211us] <- [
//        PenUp
//        Displacement(79y,87y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(-16y,8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-16y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(-56y,56y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // や
//    dict.[42212us] <- [
//        PenUp
//        Displacement(16y,64y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,8y)
//        Displacement(16y,8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(8y,40y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(-16y,8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//    ]
//    // ゅ
//    dict.[42213us] <- [
//        PenUp
//        Displacement(32y,87y)
//        PenDown
//        Displacement(0y,-48y)
//        Displacement(8y,-16y)
//        Displacement(0y,8y)
//        Displacement(8y,16y)
//        Displacement(8y,16y)
//        Displacement(0y,8y)
//        Displacement(8y,16y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//        Displacement(-8y,16y)
//        Displacement(0y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,16y)
//        Displacement(16y,16y)
//        Displacement(0y,-71y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//    ]
//    // ゆ
//    dict.[42214us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(16y,-16y)
//        Displacement(0y,8y)
//        Displacement(16y,56y)
//        Displacement(8y,16y)
//        Displacement(32y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-32y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,48y)
//        Displacement(16y,8y)
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-48y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-8y)
//    ]
//    // ょ
//    dict.[42215us] <- [
//        PenUp
//        Displacement(64y,103y)
//        PenDown
//        Displacement(0y,-24y)
//        Displacement(8y,-24y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//        Displacement(0y,8y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-32y,64y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // よ
//    dict.[42216us] <- [
//        PenUp
//        Displacement(64y,111y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(8y,-32y)
//        Displacement(8y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//        Displacement(0y,8y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(32y,-16y)
//        PenUp
//        Displacement(-32y,79y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ら
//    dict.[42217us] <- [
//        PenUp
//        Displacement(64y,103y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-40y)
//        Displacement(16y,8y)
//        Displacement(24y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-32y,-8y)
//    ]
//    // り
//    dict.[42218us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(0y,-64y)
//        Displacement(0y,24y)
//        Displacement(16y,16y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//    ]
//    // る
//    dict.[42219us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-32y)
//        Displacement(-16y,-24y)
//        Displacement(24y,24y)
//        Displacement(16y,8y)
//        Displacement(24y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-24y,-24y)
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//        Displacement(0y,8y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//    ]
//    // れ
//    dict.[42220us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(0y,-95y)
//        Displacement(-16y,32y)
//        PenUp
//        Displacement(0y,40y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(-32y,-56y)
//        Displacement(32y,32y)
//        PenUp
//        Displacement(16y,24y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-40y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,16y)
//    ]
//    // ろ
//    dict.[42221us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(0y,-8y)
//        Displacement(-48y,-64y)
//        Displacement(16y,16y)
//        Displacement(24y,16y)
//        Displacement(24y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,-8y)
//    ]
//    // ゎ
//    dict.[42222us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(24y,0y)
//        PenUp
//        Displacement(-16y,24y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(0y,-71y)
//        Displacement(-16y,16y)
//        Displacement(24y,24y)
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//    ]
//    // わ
//    dict.[42223us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-24y,24y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(0y,-79y)
//        Displacement(-16y,16y)
//        Displacement(24y,24y)
//        Displacement(24y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//    ]
//    // ゐ
//    dict.[42224us] <- [
//        PenUp
//        Displacement(16y,95y)
//        PenDown
//        Displacement(32y,0y)
//        Displacement(-8y,-56y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        Displacement(0y,16y)
//        Displacement(16y,16y)
//        Displacement(24y,8y)
//        Displacement(32y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-8y)
//        Displacement(-16y,8y)
//        Displacement(0y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        Displacement(16y,-8y)
//    ]
//    // ゑ
//    dict.[42225us] <- [
//        PenUp
//        Displacement(48y,103y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(-24y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(16y,16y)
//        Displacement(24y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(8y,8y)
//        Displacement(8y,-8y)
//        Displacement(-24y,-16y)
//        Displacement(-32y,-32y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(24y,-24y)
//        Displacement(24y,24y)
//        Displacement(16y,-16y)
//        Displacement(-8y,0y)
//        Displacement(-8y,-8y)
//    ]
//    // を
//    dict.[42226us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-16y,16y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-32y,-40y)
//        Displacement(8y,8y)
//        Displacement(24y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-32y)
//        Displacement(0y,32y)
//        Displacement(24y,24y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-40y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(16y,-8y)
//        Displacement(32y,0y)
//        Displacement(8y,8y)
//    ]
//    // ん
//    dict.[42227us] <- [
//        PenUp
//        Displacement(56y,103y)
//        PenDown
//        Displacement(-16y,-40y)
//        Displacement(-16y,-48y)
//        Displacement(16y,40y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-40y)
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//        Displacement(8y,8y)
//    ]
//    // ァ
//    dict.[42401us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(0y,-8y)
//        Displacement(-32y,-16y)
//        PenUp
//        Displacement(0y,0y)
//        PenDown
//        Displacement(-8y,8y)
//        Displacement(8y,-8y)
//        Displacement(-8y,-24y)
//        Displacement(-16y,-24y)
//    ]
//    // ア
//    dict.[42402us] <- [
//        PenUp
//        Displacement(24y,111y)
//        PenDown
//        Displacement(87y,0y)
//        Displacement(0y,-8y)
//        Displacement(-48y,-16y)
//        PenUp
//        Displacement(0y,8y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-24y)
//    ]
//    // ィ
//    dict.[42403us] <- [
//        PenUp
//        Displacement(79y,103y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(-24y,-16y)
//        Displacement(-16y,-8y)
//        PenUp
//        Displacement(24y,8y)
//        PenDown
//        Displacement(0y,-56y)
//    ]
//    // イ
//    dict.[42404us] <- [
//        PenUp
//        Displacement(95y,119y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(-24y,-16y)
//        Displacement(-40y,-24y)
//        PenUp
//        Displacement(48y,24y)
//        PenDown
//        Displacement(0y,-79y)
//    ]
//    // ゥ
//    dict.[42405us] <- [
//        PenUp
//        Displacement(32y,71y)
//        PenDown
//        Displacement(0y,16y)
//        Displacement(64y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-24y)
//        Displacement(-32y,-32y)
//        PenUp
//        Displacement(8y,79y)
//        PenDown
//        Displacement(0y,-16y)
//    ]
//    // ウ
//    dict.[42406us] <- [
//        PenUp
//        Displacement(32y,79y)
//        PenDown
//        Displacement(0y,16y)
//        Displacement(79y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-32y,-32y)
//        PenUp
//        Displacement(16y,87y)
//        PenDown
//        Displacement(0y,16y)
//    ]
//    // ェ
//    dict.[42407us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(48y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(-40y,0y)
//        PenDown
//        Displacement(79y,0y)
//    ]
//    // エ
//    dict.[42408us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-32y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-48y,0y)
//        PenDown
//        Displacement(95y,0y)
//    ]
//    // ォ
//    dict.[42409us] <- [
//        PenUp
//        Displacement(32y,79y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-16y,16y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(-16y,16y)
//        PenUp
//        Displacement(-32y,-8y)
//        PenDown
//        Displacement(48y,48y)
//    ]
//    // オ
//    dict.[42410us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(87y,0y)
//        PenUp
//        Displacement(-24y,24y)
//        PenDown
//        Displacement(0y,-103y)
//        Displacement(-16y,16y)
//        PenUp
//        Displacement(-48y,0y)
//        PenDown
//        Displacement(64y,64y)
//    ]
//    // カ
//    dict.[42411us] <- [
//        PenUp
//        Displacement(16y,87y)
//        PenDown
//        Displacement(79y,0y)
//        Displacement(0y,-32y)
//        Displacement(-8y,-32y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-48y,-8y)
//        PenDown
//        Displacement(24y,24y)
//        Displacement(8y,16y)
//        Displacement(8y,16y)
//        Displacement(0y,48y)
//    ]
//    // ガ
//    dict.[42412us] <- [
//        PenUp
//        Displacement(16y,87y)
//        PenDown
//        Displacement(79y,0y)
//        Displacement(0y,-40y)
//        Displacement(-8y,-24y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-48y,-8y)
//        PenDown
//        Displacement(24y,24y)
//        Displacement(8y,16y)
//        Displacement(8y,16y)
//        Displacement(0y,48y)
//        PenUp
//        Displacement(56y,0y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // キ
//    dict.[42413us] <- [
//        PenUp
//        Displacement(32y,79y)
//        PenDown
//        Displacement(64y,8y)
//        PenUp
//        Displacement(0y,-32y)
//        PenDown
//        Displacement(-64y,-8y)
//        PenUp
//        Displacement(48y,-32y)
//        PenDown
//        Displacement(-32y,95y)
//    ]
//    // ギ
//    dict.[42414us] <- [
//        PenUp
//        Displacement(95y,119y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-64y,-8y)
//        PenUp
//        Displacement(0y,-32y)
//        PenDown
//        Displacement(64y,8y)
//        PenUp
//        Displacement(-16y,-40y)
//        PenDown
//        Displacement(-32y,95y)
//    ]
//    // ク
//    dict.[42415us] <- [
//        PenUp
//        Displacement(48y,111y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//        PenUp
//        Displacement(32y,24y)
//        PenDown
//        Displacement(40y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-24y)
//        Displacement(-16y,-8y)
//        Displacement(-24y,-8y)
//    ]
//    // グ
//    dict.[42416us] <- [
//        PenUp
//        Displacement(48y,111y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(40y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-48y,-48y)
//        Displacement(-16y,-8y)
//        PenUp
//        Displacement(95y,103y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // ケ
//    dict.[42417us] <- [
//        PenUp
//        Displacement(56y,111y)
//        PenDown
//        Displacement(-32y,-32y)
//        PenUp
//        Displacement(8y,8y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-40y,-40y)
//    ]
//    // ゲ
//    dict.[42418us] <- [
//        PenUp
//        Displacement(56y,111y)
//        PenDown
//        Displacement(-40y,-40y)
//        PenUp
//        Displacement(16y,16y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-48y,-48y)
//        PenUp
//        Displacement(95y,103y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // コ
//    dict.[42419us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(71y,0y)
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-87y,0y)
//    ]
//    // ゴ
//    dict.[42420us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-87y,-8y)
//        PenDown
//        Displacement(71y,0y)
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-87y,0y)
//    ]
//    // サ
//    dict.[42421us] <- [
//        PenUp
//        Displacement(16y,79y)
//        PenDown
//        Displacement(95y,0y)
//        PenUp
//        Displacement(-32y,32y)
//        PenDown
//        Displacement(0y,-79y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(-16y,40y)
//        PenDown
//        Displacement(0y,56y)
//    ]
//    // ザ
//    dict.[42422us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-95y,0y)
//        PenUp
//        Displacement(32y,24y)
//        PenDown
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(16y,-40y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(8y,16y)
//        Displacement(0y,79y)
//    ]
//    // シ
//    dict.[42423us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-16y,-24y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-24y,-56y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(64y,64y)
//    ]
//    // ジ
//    dict.[42424us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-16y,-24y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-24y,-56y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(64y,64y)
//        PenUp
//        Displacement(8y,16y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,16y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // ス
//    dict.[42425us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(-71y,-71y)
//        PenUp
//        Displacement(48y,32y)
//        PenDown
//        Displacement(32y,-32y)
//    ]
//    // ズ
//    dict.[42426us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(56y,0y)
//        Displacement(-8y,-16y)
//        Displacement(-56y,-56y)
//        PenUp
//        Displacement(48y,32y)
//        PenDown
//        Displacement(32y,-32y)
//        PenUp
//        Displacement(-8y,95y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // セ
//    dict.[42427us] <- [
//        PenUp
//        Displacement(16y,79y)
//        PenDown
//        Displacement(87y,8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(0y,-40y)
//        PenDown
//        Displacement(-40y,0y)
//        Displacement(0y,79y)
//    ]
//    // ゼ
//    dict.[42428us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-24y,-32y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(-87y,-8y)
//        PenUp
//        Displacement(32y,24y)
//        PenDown
//        Displacement(0y,-79y)
//        Displacement(40y,0y)
//    ]
//    // ソ
//    dict.[42429us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(56y,32y)
//        PenDown
//        Displacement(-8y,-32y)
//        Displacement(-16y,-24y)
//        Displacement(-16y,-16y)
//    ]
//    // ゾ
//    dict.[42430us] <- [
//        PenUp
//        Displacement(16y,95y)
//        PenDown
//        Displacement(16y,-24y)
//        PenUp
//        Displacement(48y,24y)
//        PenDown
//        Displacement(-8y,-40y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        PenUp
//        Displacement(48y,95y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-16y,-8y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // タ
//    dict.[42431us] <- [
//        PenUp
//        Displacement(48y,111y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(40y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-56y,-56y)
//        PenUp
//        Displacement(24y,56y)
//        PenDown
//        Displacement(32y,-32y)
//    ]
//    // ダ
//    dict.[42432us] <- [
//        PenUp
//        Displacement(48y,111y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(40y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-56y,-56y)
//        PenUp
//        Displacement(16y,64y)
//        PenDown
//        Displacement(40y,-40y)
//        PenUp
//        Displacement(16y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-16y,8y)
//    ]
//    // チ
//    dict.[42433us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(56y,8y)
//        PenUp
//        Displacement(16y,-40y)
//        PenDown
//        Displacement(-87y,0y)
//        PenUp
//        Displacement(48y,32y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(-8y,-24y)
//        Displacement(-32y,-32y)
//    ]
//    // ヂ
//    dict.[42434us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-24y,8y)
//        PenDown
//        Displacement(-56y,-8y)
//        PenUp
//        Displacement(-16y,-32y)
//        PenDown
//        Displacement(87y,0y)
//        PenUp
//        Displacement(-40y,32y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(-8y,-16y)
//        Displacement(-32y,-32y)
//    ]
//    // ッ
//    dict.[42435us] <- [
//        PenUp
//        Displacement(32y,71y)
//        PenDown
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(0y,8y)
//        PenUp
//        Displacement(24y,8y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//    ]
//    // ツ
//    dict.[42436us] <- [
//        PenUp
//        Displacement(16y,95y)
//        PenDown
//        Displacement(8y,-16y)
//        PenUp
//        Displacement(32y,16y)
//        PenDown
//        Displacement(8y,-16y)
//        PenUp
//        Displacement(32y,16y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-40y,-40y)
//    ]
//    // ヅ
//    dict.[42437us] <- [
//        PenUp
//        Displacement(16y,95y)
//        PenDown
//        Displacement(8y,-16y)
//        PenUp
//        Displacement(24y,16y)
//        PenDown
//        Displacement(8y,-16y)
//        PenUp
//        Displacement(32y,16y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-32y,-32y)
//        PenUp
//        Displacement(48y,87y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-16y,-8y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // テ
//    dict.[42438us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(56y,0y)
//        PenUp
//        Displacement(16y,-32y)
//        PenDown
//        Displacement(-87y,0y)
//        PenUp
//        Displacement(48y,0y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-32y,-32y)
//    ]
//    // デ
//    dict.[42439us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-32y,8y)
//        PenDown
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(-16y,-32y)
//        PenDown
//        Displacement(87y,0y)
//        PenUp
//        Displacement(-40y,0y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-32y,-32y)
//    ]
//    // ト
//    dict.[42440us] <- [
//        PenUp
//        Displacement(48y,111y)
//        PenDown
//        Displacement(0y,-103y)
//        PenUp
//        Displacement(8y,71y)
//        PenDown
//        Displacement(24y,-24y)
//    ]
//    // ド
//    dict.[42441us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-32y,-40y)
//        PenDown
//        Displacement(-24y,24y)
//        PenUp
//        Displacement(-8y,32y)
//        PenDown
//        Displacement(0y,-103y)
//    ]
//    // ナ
//    dict.[42442us] <- [
//        PenUp
//        Displacement(16y,79y)
//        PenDown
//        Displacement(95y,0y)
//        PenUp
//        Displacement(-48y,24y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(-8y,-24y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-24y)
//    ]
//    // ニ
//    dict.[42443us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(16y,-56y)
//        PenDown
//        Displacement(-95y,0y)
//    ]
//    // ヌ
//    dict.[42444us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-24y)
//        Displacement(-24y,-24y)
//        Displacement(-40y,-24y)
//        PenUp
//        Displacement(16y,64y)
//        PenDown
//        Displacement(24y,-16y)
//        Displacement(16y,-16y)
//        Displacement(16y,-16y)
//    ]
//    // ネ
//    dict.[42445us] <- [
//        PenUp
//        Displacement(48y,111y)
//        PenDown
//        Displacement(16y,-16y)
//        PenUp
//        Displacement(-32y,-8y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-24y)
//        Displacement(-32y,-16y)
//        PenUp
//        Displacement(48y,24y)
//        PenDown
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(8y,56y)
//        PenDown
//        Displacement(24y,-24y)
//    ]
//    // ノ
//    dict.[42446us] <- [
//        PenUp
//        Displacement(87y,103y)
//        PenDown
//        Displacement(-8y,-16y)
//        Displacement(-56y,-56y)
//    ]
//    // ハ
//    dict.[42447us] <- [
//        PenUp
//        Displacement(56y,95y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-32y,-32y)
//        PenUp
//        Displacement(64y,40y)
//        PenDown
//        Displacement(24y,-32y)
//    ]
//    // バ
//    dict.[42448us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-56y,0y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-32y,-32y)
//        PenUp
//        Displacement(64y,40y)
//        PenDown
//        Displacement(24y,-32y)
//    ]
//    // パ
//    dict.[42449us] <- [
//        PenUp
//        Displacement(103y,111y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-24y,-32y)
//        PenDown
//        Displacement(24y,-32y)
//        PenUp
//        Displacement(-87y,-8y)
//        PenDown
//        Displacement(32y,32y)
//        Displacement(8y,16y)
//        Displacement(0y,8y)
//    ]
//    // ヒ
//    dict.[42450us] <- [
//        PenUp
//        Displacement(48y,103y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-8y)
//        Displacement(32y,0y)
//        PenUp
//        Displacement(0y,64y)
//        PenDown
//        Displacement(-40y,-16y)
//    ]
//    // ビ
//    dict.[42451us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-24y,-8y)
//        PenDown
//        Displacement(-40y,-16y)
//        PenUp
//        Displacement(0y,32y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-8y)
//        Displacement(32y,0y)
//    ]
//    // ピ
//    dict.[42452us] <- [
//        PenUp
//        Displacement(103y,111y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-16y,-24y)
//        PenDown
//        Displacement(-40y,-16y)
//        PenUp
//        Displacement(0y,32y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-8y)
//        Displacement(32y,0y)
//    ]
//    // フ
//    dict.[42453us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(71y,0y)
//        Displacement(-8y,-16y)
//        Displacement(-64y,-64y)
//    ]
//    // ブ
//    dict.[42454us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-87y,0y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(8y,-8y)
//        Displacement(-71y,-71y)
//    ]
//    // プ
//    dict.[42455us] <- [
//        PenUp
//        Displacement(103y,111y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-87y,-16y)
//        PenDown
//        Displacement(71y,0y)
//        Displacement(0y,-8y)
//        Displacement(-71y,-71y)
//    ]
//    // ヘ
//    dict.[42456us] <- [
//        PenUp
//        Displacement(24y,56y)
//        PenDown
//        Displacement(24y,24y)
//        Displacement(56y,-56y)
//    ]
//    // ベ
//    dict.[42457us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-87y,-32y)
//        PenDown
//        Displacement(24y,24y)
//        Displacement(56y,-56y)
//    ]
//    // ペ
//    dict.[42458us] <- [
//        PenUp
//        Displacement(95y,111y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-71y,-56y)
//        PenDown
//        Displacement(32y,32y)
//        Displacement(48y,-48y)
//    ]
//    // ホ
//    dict.[42459us] <- [
//        PenUp
//        Displacement(16y,87y)
//        PenDown
//        Displacement(95y,0y)
//        PenUp
//        Displacement(0y,-48y)
//        PenDown
//        Displacement(-40y,40y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-40y,-40y)
//        PenUp
//        Displacement(32y,-8y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(0y,87y)
//    ]
//    // ボ
//    dict.[42460us] <- [
//        PenUp
//        Displacement(111y,111y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-95y,0y)
//        PenUp
//        Displacement(0y,-40y)
//        PenDown
//        Displacement(32y,32y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(32y,-32y)
//        PenUp
//        Displacement(-64y,-8y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(0y,87y)
//    ]
//    // ポ
//    dict.[42461us] <- [
//        PenUp
//        Displacement(95y,111y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(16y,-32y)
//        PenDown
//        Displacement(-95y,0y)
//        PenUp
//        Displacement(0y,-40y)
//        PenDown
//        Displacement(32y,32y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(32y,-32y)
//        PenUp
//        Displacement(-64y,-8y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(0y,87y)
//    ]
//    // マ
//    dict.[42462us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(79y,0y)
//        Displacement(-48y,-48y)
//        PenUp
//        Displacement(-16y,8y)
//        PenDown
//        Displacement(32y,-24y)
//    ]
//    // ミ
//    dict.[42463us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(48y,-8y)
//        PenUp
//        Displacement(0y,-32y)
//        PenDown
//        Displacement(-48y,8y)
//        PenUp
//        Displacement(-8y,-24y)
//        PenDown
//        Displacement(71y,-24y)
//    ]
//    // ム
//    dict.[42464us] <- [
//        PenUp
//        Displacement(71y,103y)
//        PenDown
//        Displacement(-8y,-16y)
//        Displacement(-24y,-40y)
//        Displacement(-16y,-16y)
//        Displacement(71y,8y)
//        PenUp
//        Displacement(-8y,8y)
//        PenDown
//        Displacement(24y,-24y)
//    ]
//    // メ
//    dict.[42465us] <- [
//        PenUp
//        Displacement(95y,103y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-64y,-64y)
//        PenUp
//        Displacement(16y,64y)
//        PenDown
//        Displacement(40y,-40y)
//    ]
//    // モ
//    dict.[42466us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(48y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(32y,0y)
//        PenUp
//        Displacement(8y,40y)
//        PenDown
//        Displacement(-87y,0y)
//    ]
//    // ャ
//    dict.[42467us] <- [
//        PenUp
//        Displacement(48y,95y)
//        PenDown
//        Displacement(24y,-71y)
//        PenUp
//        Displacement(-40y,56y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(-8y,-16y)
//    ]
//    // ヤ
//    dict.[42468us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(24y,-87y)
//        PenUp
//        Displacement(-40y,71y)
//        PenDown
//        Displacement(79y,0y)
//        Displacement(-16y,-16y)
//    ]
//    // ュ
//    dict.[42469us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(40y,0y)
//        Displacement(0y,-40y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(-71y,0y)
//    ]
//    // ユ
//    dict.[42470us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(-8y,-48y)
//        PenUp
//        Displacement(-64y,0y)
//        PenDown
//        Displacement(95y,0y)
//    ]
//    // ョ
//    dict.[42471us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(0y,-64y)
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(0y,32y)
//        PenDown
//        Displacement(48y,0y)
//    ]
//    // ヨ
//    dict.[42472us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(79y,0y)
//        Displacement(0y,-87y)
//        Displacement(-79y,0y)
//        PenUp
//        Displacement(0y,48y)
//        PenDown
//        Displacement(79y,0y)
//    ]
//    // ラ
//    dict.[42473us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(48y,0y)
//        PenUp
//        Displacement(-64y,-24y)
//        PenDown
//        Displacement(79y,0y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-56y,-48y)
//    ]
//    // リ
//    dict.[42474us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(0y,-40y)
//        PenDown
//        Displacement(24y,24y)
//        Displacement(8y,16y)
//        Displacement(0y,64y)
//    ]
//    // ル
//    dict.[42475us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(0y,-56y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-24y)
//        PenUp
//        Displacement(64y,103y)
//        PenDown
//        Displacement(0y,-103y)
//        Displacement(32y,32y)
//    ]
//    // レ
//    dict.[42476us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(56y,56y)
//    ]
//    // ロ
//    dict.[42477us] <- [
//        PenUp
//        Displacement(32y,24y)
//        PenDown
//        Displacement(0y,71y)
//        Displacement(71y,0y)
//        Displacement(0y,-71y)
//        Displacement(-71y,0y)
//    ]
//    // ヮ
//    dict.[42478us] <- [
//        PenUp
//        Displacement(32y,64y)
//        PenDown
//        Displacement(0y,24y)
//        Displacement(64y,0y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-40y,-40y)
//    ]
//    // ワ
//    dict.[42479us] <- [
//        PenUp
//        Displacement(32y,71y)
//        PenDown
//        Displacement(0y,24y)
//        Displacement(79y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-32y,-32y)
//    ]
//    // ヰ
//    dict.[42480us] <- [
//        PenUp
//        Displacement(64y,111y)
//        PenDown
//        Displacement(0y,-95y)
//        PenUp
//        Displacement(-48y,32y)
//        PenDown
//        Displacement(95y,0y)
//        PenUp
//        Displacement(-24y,40y)
//        PenDown
//        Displacement(-56y,0y)
//        Displacement(0y,-40y)
//    ]
//    // ヱ
//    dict.[42481us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(-32y,-16y)
//        PenUp
//        Displacement(-8y,8y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(-48y,0y)
//        PenDown
//        Displacement(95y,0y)
//    ]
//    // ヲ
//    dict.[42482us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(71y,0y)
//        PenUp
//        Displacement(-71y,24y)
//        PenDown
//        Displacement(71y,0y)
//        Displacement(0y,-24y)
//        Displacement(-71y,-64y)
//    ]
//    // ン
//    dict.[42483us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(16y,-8y)
//        PenUp
//        Displacement(-24y,-79y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(64y,64y)
//    ]
//    // ヴ
//    dict.[42484us] <- [
//        PenUp
//        Displacement(24y,79y)
//        Displacement(0y,0y)
//        Displacement(0y,0y)
//        Displacement(0y,0y)
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(0y,24y)
//        Displacement(71y,0y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,-24y)
//        Displacement(-24y,-24y)
//        PenUp
//        Displacement(16y,95y)
//        PenDown
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(48y,8y)
//        PenDown
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,16y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // ヵ
//    dict.[42485us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(56y,0y)
//        Displacement(0y,-48y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,8y)
//        PenUp
//        Displacement(-40y,-8y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(8y,16y)
//        Displacement(0y,40y)
//    ]
//    // ヶ
//    dict.[42486us] <- [
//        PenUp
//        Displacement(56y,95y)
//        PenDown
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        PenUp
//        Displacement(16y,16y)
//        PenDown
//        Displacement(40y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-24y,-24y)
//    ]
//    // Α
//    dict.[42657us] <- [
//        PenUp
//        Displacement(24y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(32y,95y)
//        Displacement(24y,-95y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-24y,40y)
//        PenDown
//        Displacement(-24y,0y)
//    ]
//    // Β
//    dict.[42658us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-40y,8y)
//        Displacement(40y,8y)
//        Displacement(16y,16y)
//        Displacement(0y,8y)
//        Displacement(-8y,8y)
//        Displacement(-48y,0y)
//    ]
//    // Γ
//    dict.[42659us] <- [
//        PenUp
//        Displacement(95y,87y)
//        PenDown
//        Displacement(0y,16y)
//        Displacement(-64y,0y)
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Δ
//    dict.[42660us] <- [
//        PenUp
//        Displacement(64y,111y)
//        PenDown
//        Displacement(-40y,-95y)
//        Displacement(79y,0y)
//        Displacement(-40y,95y)
//    ]
//    // Ε
//    dict.[42661us] <- [
//        PenUp
//        Displacement(95y,95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-56y,0y)
//        Displacement(0y,-87y)
//        Displacement(56y,0y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(-16y,32y)
//        PenDown
//        Displacement(0y,16y)
//        PenUp
//        Displacement(0y,-8y)
//        PenDown
//        Displacement(-40y,0y)
//    ]
//    // Ζ
//    dict.[42662us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(64y,0y)
//        Displacement(0y,-24y)
//        Displacement(-64y,-64y)
//        Displacement(71y,0y)
//        Displacement(0y,16y)
//    ]
//    // Η
//    dict.[42663us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,-40y)
//        PenDown
//        Displacement(-48y,0y)
//    ]
//    // Θ
//    dict.[42664us] <- [
//        PenUp
//        Displacement(32y,87y)
//        PenDown
//        Displacement(-8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,8y)
//        Displacement(8y,16y)
//        Displacement(0y,16y)
//        Displacement(-8y,16y)
//        Displacement(-8y,8y)
//        Displacement(-16y,8y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(16y,-16y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(0y,8y)
//        Displacement(32y,0y)
//        Displacement(0y,-8y)
//        Displacement(0y,16y)
//    ]
//    // Ι
//    dict.[42665us] <- [
//        PenUp
//        Displacement(56y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Κ
//    dict.[42666us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(40y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(-48y,48y)
//        Displacement(40y,40y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Λ
//    dict.[42667us] <- [
//        PenUp
//        Displacement(24y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(32y,95y)
//        Displacement(24y,-95y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Μ
//    dict.[42668us] <- [
//        PenUp
//        Displacement(16y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,79y)
//        Displacement(40y,-64y)
//        Displacement(32y,64y)
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ν
//    dict.[42669us] <- [
//        PenUp
//        Displacement(24y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        Displacement(64y,-87y)
//        Displacement(0y,87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ξ
//    dict.[42670us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(64y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(-8y,-24y)
//        PenDown
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(0y,8y)
//        PenDown
//        Displacement(-48y,0y)
//        Displacement(0y,8y)
//        Displacement(0y,-16y)
//        PenUp
//        Displacement(-8y,-24y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(64y,0y)
//        Displacement(0y,8y)
//    ]
//    // Ο
//    dict.[42671us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(24y,-24y)
//        Displacement(32y,0y)
//        Displacement(24y,24y)
//        Displacement(0y,40y)
//        Displacement(-24y,24y)
//        Displacement(-32y,0y)
//        Displacement(-24y,-24y)
//    ]
//    // Π
//    dict.[42672us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-79y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//    ]
//    // Ρ
//    dict.[42673us] <- [
//        PenUp
//        Displacement(32y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        Displacement(32y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,0y)
//        Displacement(-8y,8y)
//    ]
//    // Σ
//    dict.[42674us] <- [
//        PenUp
//        Displacement(95y,95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-64y,0y)
//        Displacement(0y,-16y)
//        Displacement(24y,-24y)
//        Displacement(0y,-8y)
//        Displacement(-24y,-24y)
//        Displacement(0y,-16y)
//        Displacement(64y,0y)
//        Displacement(0y,8y)
//    ]
//    // Τ
//    dict.[42675us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(79y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(-40y,8y)
//        PenDown
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Υ
//    dict.[42676us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,79y)
//        Displacement(8y,8y)
//        Displacement(16y,8y)
//        Displacement(8y,0y)
//        Displacement(8y,-16y)
//    ]
//    // Φ
//    dict.[42677us] <- [
//        PenUp
//        Displacement(8y,48y)
//        PenDown
//        Displacement(24y,-24y)
//        Displacement(48y,0y)
//        Displacement(24y,24y)
//        Displacement(0y,32y)
//        Displacement(-24y,24y)
//        Displacement(-48y,0y)
//        Displacement(-24y,-24y)
//        Displacement(0y,-32y)
//        PenUp
//        Displacement(56y,71y)
//        PenDown
//        Displacement(-16y,-111y)
//    ]
//    // Χ
//    dict.[42678us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(64y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(0y,87y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-64y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ψ
//    dict.[42679us] <- [
//        PenUp
//        Displacement(16y,103y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(0y,-24y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(24y,0y)
//        Displacement(16y,8y)
//        Displacement(8y,8y)
//        Displacement(0y,24y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(-32y,0y)
//        PenDown
//        Displacement(-24y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(24y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        Displacement(-8y,-87y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-8y,87y)
//    ]
//    // Ω
//    dict.[42680us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-32y,0y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(79y,0y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-32y,0y)
//        Displacement(0y,8y)
//        Displacement(16y,8y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(-24y,24y)
//        Displacement(-32y,0y)
//        Displacement(-24y,-24y)
//    ]
//    // α
//    dict.[42689us] <- [
//        PenUp
//        Displacement(79y,95y)
//        PenDown
//        Displacement(-16y,-56y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,32y)
//        Displacement(8y,16y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(8y,-56y)
//        Displacement(8y,-8y)
//    ]
//    // β
//    dict.[42690us] <- [
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(0y,79y)
//        Displacement(8y,8y)
//        Displacement(24y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,0y)
//        Displacement(24y,0y)
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,8y)
//    ]
//    // γ
//    dict.[42691us] <- [
//        PenUp
//        Displacement(32y,79y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-32y)
//        Displacement(0y,-32y)
//        PenUp
//        Displacement(0y,24y)
//        PenDown
//        Displacement(32y,56y)
//    ]
//    // δ
//    dict.[42692us] <- [
//        PenUp
//        Displacement(87y,95y)
//        PenDown
//        Displacement(-16y,8y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(56y,-32y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,16y)
//        Displacement(24y,16y)
//    ]
//    // ε
//    dict.[42693us] <- [
//        PenUp
//        Displacement(87y,87y)
//        PenDown
//        Displacement(-16y,8y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(24y,-8y)
//        Displacement(16y,0y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(16y,-16y)
//        Displacement(24y,0y)
//        Displacement(16y,16y)
//    ]
//    // ζ
//    dict.[42694us] <- [
//        PenUp
//        Displacement(56y,103y)
//        PenDown
//        Displacement(-8y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(24y,0y)
//        Displacement(8y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(-24y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-8y)
//    ]
//    // η
//    dict.[42695us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(0y,48y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-64y)
//        Displacement(8y,-24y)
//    ]
//    // θ
//    dict.[42696us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(0y,-56y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,56y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        PenUp
//        Displacement(8y,-16y)
//        PenDown
//        Displacement(16y,-8y)
//    ]
//    // ι
//    dict.[42697us] <- [
//        PenUp
//        Displacement(48y,95y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(0y,-79y)
//        Displacement(8y,-8y)
//        Displacement(16y,16y)
//    ]
//    // κ
//    dict.[42698us] <- [
//        PenUp
//        Displacement(16y,71y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-40y,40y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(-32y,-56y)
//        Displacement(64y,8y)
//        PenUp
//        Displacement(-8y,8y)
//        PenDown
//        Displacement(16y,-16y)
//    ]
//    // λ
//    dict.[42699us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(24y,-32y)
//        Displacement(24y,-48y)
//        Displacement(8y,8y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(-56y,-16y)
//        PenDown
//        Displacement(24y,48y)
//    ]
//    // μ
//    dict.[42700us] <- [
//        PenUp
//        Displacement(32y,16y)
//        PenDown
//        Displacement(8y,32y)
//        Displacement(0y,48y)
//        Displacement(0y,-56y)
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,64y)
//        Displacement(0y,-64y)
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//    ]
//    // ν
//    dict.[42701us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(32y,-64y)
//        Displacement(32y,64y)
//    ]
//    // ξ
//    dict.[42702us] <- [
//        PenUp
//        Displacement(71y,111y)
//        PenDown
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        Displacement(-24y,-8y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//        Displacement(-24y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-8y)
//        Displacement(24y,-16y)
//        Displacement(8y,0y)
//        Displacement(8y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(-24y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-8y)
//    ]
//    // ο
//    dict.[42703us] <- [
//        PenUp
//        Displacement(40y,79y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//    ]
//    // π
//    dict.[42704us] <- [
//        PenUp
//        Displacement(32y,79y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(8y,-8y)
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-64y,0y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(0y,40y)
//    ]
//    // ρ
//    dict.[42705us] <- [
//        PenUp
//        Displacement(32y,24y)
//        PenDown
//        Displacement(16y,71y)
//        Displacement(8y,8y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//    ]
//    // σ
//    dict.[42706us] <- [
//        PenUp
//        Displacement(103y,87y)
//        Displacement(0y,8y)
//        PenDown
//        Displacement(-48y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(-16y,16y)
//    ]
//    // τ
//    dict.[42707us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(48y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-8y)
//        Displacement(16y,16y)
//    ]
//    // υ
//    dict.[42708us] <- [
//        PenUp
//        Displacement(32y,87y)
//        Displacement(0y,-8y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(8y,-71y)
//        Displacement(8y,0y)
//        Displacement(16y,8y)
//        Displacement(16y,16y)
//        Displacement(-8y,48y)
//    ]
//    // φ
//    dict.[42709us] <- [
//        PenUp
//        Displacement(56y,103y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(0y,24y)
//        PenDown
//        Displacement(-24y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,8y)
//        Displacement(16y,16y)
//        Displacement(48y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,0y)
//    ]
//    // χ
//    dict.[42710us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(24y,-32y)
//        Displacement(24y,-48y)
//        Displacement(8y,8y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(0y,64y)
//        PenDown
//        Displacement(-40y,-48y)
//        Displacement(-24y,-32y)
//    ]
//    // ψ
//    dict.[42711us] <- [
//        PenUp
//        Displacement(16y,87y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(8y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-24y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(24y,16y)
//        Displacement(0y,24y)
//        Displacement(-8y,16y)
//        PenUp
//        Displacement(-24y,32y)
//        PenDown
//        Displacement(0y,-119y)
//    ]
//    // ω
//    dict.[42712us] <- [
//        PenUp
//        Displacement(48y,95y)
//        PenDown
//        Displacement(-24y,-24y)
//        Displacement(0y,-24y)
//        Displacement(16y,-16y)
//        Displacement(16y,16y)
//        Displacement(8y,24y)
//        Displacement(8y,-24y)
//        Displacement(16y,-16y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-8y,16y)
//        Displacement(-16y,16y)
//    ]
//    // А
//    dict.[42913us] <- [
//        PenUp
//        Displacement(24y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(32y,95y)
//        Displacement(32y,-95y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-24y,40y)
//        PenDown
//        Displacement(-32y,0y)
//    ]
//    // Б
//    dict.[42914us] <- [
//        PenUp
//        Displacement(95y,95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-56y,0y)
//        Displacement(0y,-87y)
//        Displacement(40y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-40y,0y)
//    ]
//    // В
//    dict.[42915us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-32y,0y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-40y,0y)
//        Displacement(0y,87y)
//    ]
//    // Г
//    dict.[42916us] <- [
//        PenUp
//        Displacement(32y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        Displacement(56y,0y)
//        Displacement(0y,-16y)
//    ]
//    // Д
//    dict.[42917us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(16y,-8y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-87y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(16y,8y)
//        PenDown
//        Displacement(16y,79y)
//    ]
//    // Е
//    dict.[42918us] <- [
//        PenUp
//        Displacement(95y,95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-56y,0y)
//        Displacement(0y,-87y)
//        Displacement(56y,0y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(-16y,32y)
//        PenDown
//        Displacement(0y,16y)
//        PenUp
//        Displacement(0y,-8y)
//        PenDown
//        Displacement(-40y,0y)
//    ]
//    // Ё
//    dict.[42919us] <- [
//        PenUp
//        Displacement(95y,87y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-56y,0y)
//        Displacement(0y,-87y)
//        Displacement(56y,0y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(-16y,32y)
//        PenDown
//        Displacement(0y,16y)
//        PenUp
//        Displacement(0y,-8y)
//        PenDown
//        Displacement(-40y,0y)
//        PenUp
//        Displacement(8y,56y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(0y,8y)
//        Displacement(8y,0y)
//        Displacement(-8y,-8y)
//    ]
//    // Ж
//    dict.[42920us] <- [
//        PenUp
//        Displacement(16y,103y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(8y,-16y)
//        PenUp
//        Displacement(0y,0y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-32y,0y)
//        PenDown
//        Displacement(-8y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(40y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(40y,0y)
//        PenDown
//        Displacement(-24y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-16y)
//        Displacement(8y,-8y)
//        Displacement(8y,-16y)
//        Displacement(24y,-16y)
//    ]
//    // З
//    dict.[42921us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(0y,-16y)
//        Displacement(24y,24y)
//        Displacement(24y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,-8y)
//        Displacement(-16y,0y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(16y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-24y,-16y)
//        Displacement(-24y,0y)
//        Displacement(-16y,8y)
//        Displacement(-16y,16y)
//    ]
//    // И
//    dict.[42922us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        Displacement(48y,87y)
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-48y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(64y,87y)
//        PenDown
//        Displacement(-16y,0y)
//    ]
//    // Й
//    dict.[42923us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(48y,87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-16y,103y)
//        PenDown
//        Displacement(-16y,-8y)
//        Displacement(8y,8y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(-32y,0y)
//        PenDown
//        Displacement(16y,-8y)
//        Displacement(-8y,8y)
//        Displacement(-8y,0y)
//    ]
//    // К
//    dict.[42924us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,48y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(8y,16y)
//        Displacement(24y,24y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(-40y,-32y)
//        PenDown
//        Displacement(8y,-16y)
//        Displacement(16y,-24y)
//        Displacement(16y,-8y)
//    ]
//    // Л
//    dict.[42925us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-71y,16y)
//        PenDown
//        Displacement(0y,-8y)
//        Displacement(8y,-8y)
//        Displacement(8y,8y)
//        Displacement(16y,79y)
//    ]
//    // М
//    dict.[42926us] <- [
//        PenUp
//        Displacement(16y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,79y)
//        Displacement(40y,-71y)
//        Displacement(32y,71y)
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Н
//    dict.[42927us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(32y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,-40y)
//        PenDown
//        Displacement(-48y,0y)
//    ]
//    // О
//    dict.[42928us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(24y,-24y)
//        Displacement(32y,0y)
//        Displacement(24y,24y)
//        Displacement(0y,40y)
//        Displacement(-24y,24y)
//        Displacement(-32y,0y)
//        Displacement(-24y,-24y)
//    ]
//    // П
//    dict.[42929us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-48y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,87y)
//    ]
//    // Р
//    dict.[42930us] <- [
//        PenUp
//        Displacement(32y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        Displacement(32y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-32y,0y)
//    ]
//    // С
//    dict.[42931us] <- [
//        PenUp
//        Displacement(95y,87y)
//        PenDown
//        Displacement(-16y,16y)
//        Displacement(-32y,0y)
//        Displacement(-24y,-24y)
//        Displacement(0y,-40y)
//        Displacement(24y,-24y)
//        Displacement(32y,0y)
//        Displacement(16y,16y)
//    ]
//    // Т
//    dict.[42932us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(79y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(-40y,8y)
//        PenDown
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // У
//    dict.[42933us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(32y,-71y)
//        PenUp
//        Displacement(24y,71y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(-8y,-40y)
//        Displacement(-32y,-40y)
//        Displacement(-16y,-16y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // Ф
//    dict.[42934us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(64y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(0y,87y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-64y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Х
//    dict.[42935us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(0y,-24y)
//        Displacement(16y,-16y)
//        Displacement(48y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,24y)
//        Displacement(-16y,16y)
//        Displacement(-48y,0y)
//        PenUp
//        Displacement(16y,16y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ц
//    dict.[42936us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(87y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(0y,87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ч
//    dict.[42937us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-48y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//        Displacement(16y,16y)
//        PenUp
//        Displacement(-8y,40y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ш
//    dict.[42938us] <- [
//        PenUp
//        Displacement(16y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(103y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//    ]
//    // Щ
//    dict.[42939us] <- [
//        PenUp
//        Displacement(8y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-79y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(103y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(-16y,8y)
//        PenDown
//        Displacement(0y,79y)
//        Displacement(-8y,0y)
//        Displacement(8y,0y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(-40y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-79y)
//    ]
//    // Ъ
//    dict.[42940us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(24y,0y)
//        Displacement(0y,-87y)
//        Displacement(32y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-32y,0y)
//    ]
//    // Ы
//    dict.[42941us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,8y)
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(64y,48y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // Ь
//    dict.[42942us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        Displacement(24y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-24y,0y)
//    ]
//    // Э
//    dict.[42943us] <- [
//        PenUp
//        Displacement(32y,103y)
//        Displacement(0y,-24y)
//        PenDown
//        Displacement(16y,24y)
//        Displacement(32y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-40y,0y)
//        Displacement(40y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-24y,-24y)
//        Displacement(-24y,0y)
//        Displacement(-16y,16y)
//    ]
//    // Ю
//    dict.[42944us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,48y)
//        PenDown
//        Displacement(16y,0y)
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(32y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,56y)
//        Displacement(-16y,16y)
//        Displacement(-32y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-24y)
//    ]
//    // Я
//    dict.[42945us] <- [
//        PenUp
//        Displacement(95y,16y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,87y)
//        Displacement(-40y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(8y,0y)
//        Displacement(24y,8y)
//        Displacement(-24y,-8y)
//        Displacement(-40y,-40y)
//        Displacement(-8y,8y)
//    ]
//    // а
//    dict.[42961us] <- [
//        PenUp
//        Displacement(32y,71y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-40y)
//        Displacement(8y,-16y)
//        Displacement(8y,8y)
//        Displacement(0y,8y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,8y)
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//    ]
//    // б
//    dict.[42962us] <- [
//        PenUp
//        Displacement(87y,111y)
//        PenDown
//        Displacement(-48y,-24y)
//        Displacement(0y,-56y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//    ]
//    // в
//    dict.[42963us] <- [
//        PenUp
//        Displacement(48y,95y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(32y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-24y,0y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(0y,8y)
//        Displacement(-8y,8y)
//        Displacement(-32y,0y)
//    ]
//    // г
//    dict.[42964us] <- [
//        PenUp
//        Displacement(40y,24y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,71y)
//        Displacement(40y,0y)
//        Displacement(0y,-8y)
//    ]
//    // д
//    dict.[42965us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(16y,-8y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-71y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(8y,8y)
//        PenDown
//        Displacement(16y,56y)
//    ]
//    // е
//    dict.[42966us] <- [
//        PenUp
//        Displacement(40y,64y)
//        PenDown
//        Displacement(56y,0y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-24y)
//        Displacement(16y,-16y)
//        Displacement(24y,0y)
//        Displacement(16y,16y)
//    ]
//    // ё
//    dict.[42967us] <- [
//        PenUp
//        Displacement(48y,56y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-24y)
//        Displacement(16y,-16y)
//        Displacement(24y,0y)
//        Displacement(16y,16y)
//        PenUp
//        Displacement(-48y,16y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(16y,40y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(0y,8y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(16y,0y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // ж
//    dict.[42968us] <- [
//        PenUp
//        Displacement(24y,79y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(8y,-16y)
//        Displacement(8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,56y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-16y,-32y)
//        PenDown
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        Displacement(8y,16y)
//        Displacement(0y,8y)
//        Displacement(8y,-8y)
//        PenUp
//        Displacement(-24y,-24y)
//        PenDown
//        Displacement(24y,-24y)
//        Displacement(8y,0y)
//    ]
//    // з
//    dict.[42969us] <- [
//        PenUp
//        Displacement(40y,79y)
//        PenDown
//        Displacement(16y,16y)
//        Displacement(16y,0y)
//        Displacement(16y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-24y,-16y)
//        Displacement(24y,-16y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,0y)
//        Displacement(-16y,16y)
//        PenUp
//        Displacement(0y,32y)
//        PenDown
//        Displacement(8y,8y)
//    ]
//    // и
//    dict.[42970us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(40y,64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(8y,0y)
//        Displacement(8y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // й
//    dict.[42971us] <- [
//        PenUp
//        Displacement(56y,79y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(40y,56y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-16y,64y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(8y,0y)
//        Displacement(0y,-8y)
//        Displacement(-8y,0y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(-32y,0y)
//        PenDown
//        Displacement(-8y,0y)
//        Displacement(0y,-8y)
//        Displacement(8y,0y)
//        Displacement(0y,8y)
//        Displacement(-8y,-8y)
//    ]
//    // к
//    dict.[42972us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(40y,0y)
//        PenDown
//        Displacement(-8y,0y)
//        Displacement(-32y,40y)
//        Displacement(32y,24y)
//        Displacement(8y,-8y)
//    ]
//    // л
//    dict.[42973us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-64y,8y)
//        PenDown
//        Displacement(8y,-8y)
//        Displacement(8y,0y)
//        Displacement(16y,64y)
//    ]
//    // м
//    dict.[42974us] <- [
//        PenUp
//        Displacement(24y,32y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,56y)
//        Displacement(32y,-48y)
//        Displacement(32y,48y)
//        Displacement(0y,-56y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // н
//    dict.[42975us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(24y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,-32y)
//        PenDown
//        Displacement(-40y,0y)
//    ]
//    // о
//    dict.[42976us] <- [
//        PenUp
//        Displacement(40y,79y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//    ]
//    // п
//    dict.[42977us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(64y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-32y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,64y)
//    ]
//    // р
//    dict.[42978us] <- [
//        PenUp
//        Displacement(40y,24y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,71y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(16y,8y)
//        Displacement(16y,0y)
//        Displacement(8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,0y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // с
//    dict.[42979us] <- [
//        PenUp
//        Displacement(87y,79y)
//        PenDown
//        Displacement(-8y,16y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//    ]
//    // т
//    dict.[42980us] <- [
//        PenUp
//        Displacement(32y,87y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(64y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(-32y,8y)
//        PenDown
//        Displacement(0y,-71y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // у
//    dict.[42981us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(24y,-48y)
//        PenUp
//        Displacement(16y,48y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(-16y,-40y)
//        Displacement(-32y,-32y)
//        Displacement(-8y,8y)
//    ]
//    // ф
//    dict.[42982us] <- [
//        PenUp
//        Displacement(48y,103y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-87y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,32y)
//        PenDown
//        Displacement(-16y,0y)
//        Displacement(-16y,8y)
//        Displacement(0y,8y)
//        Displacement(16y,8y)
//        Displacement(32y,0y)
//        Displacement(16y,-8y)
//        Displacement(0y,-8y)
//        Displacement(-16y,-8y)
//        Displacement(-16y,0y)
//    ]
//    // х
//    dict.[42983us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(48y,-71y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(0y,71y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-48y,-71y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ц
//    dict.[42984us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(-16y,8y)
//        PenDown
//        Displacement(0y,64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ч
//    dict.[42985us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(8y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        Displacement(0y,32y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-71y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ш
//    dict.[42986us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-32y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-64y)
//    ]
//    // щ
//    dict.[42987us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-64y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(79y,0y)
//        Displacement(0y,-8y)
//        PenUp
//        Displacement(-8y,8y)
//        PenDown
//        Displacement(0y,64y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,-64y)
//    ]
//    // ъ
//    dict.[42988us] <- [
//        PenUp
//        Displacement(24y,87y)
//        PenDown
//        Displacement(0y,8y)
//        Displacement(24y,0y)
//        Displacement(0y,-71y)
//        Displacement(24y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,8y)
//        Displacement(-24y,0y)
//    ]
//    // ы
//    dict.[42989us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,8y)
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(56y,-40y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,71y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//    ]
//    // ь
//    dict.[42990us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(24y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,8y)
//        Displacement(-8y,16y)
//        Displacement(-24y,0y)
//        Displacement(-8y,-8y)
//    ]
//    // э
//    dict.[42991us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(8y,8y)
//        Displacement(24y,0y)
//        Displacement(24y,-24y)
//        Displacement(0y,-32y)
//        Displacement(-24y,-16y)
//        Displacement(-24y,0y)
//        Displacement(-16y,16y)
//        PenUp
//        Displacement(24y,24y)
//        PenDown
//        Displacement(40y,0y)
//    ]
//    // ю
//    dict.[42992us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(0y,-71y)
//        PenUp
//        Displacement(-8y,0y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(-8y,40y)
//        PenDown
//        Displacement(16y,0y)
//        PenUp
//        Displacement(0y,-24y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,40y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-40y)
//    ]
//    // я
//    dict.[42993us] <- [
//        PenUp
//        Displacement(87y,24y)
//        PenDown
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(8y,0y)
//        PenDown
//        Displacement(0y,71y)
//        Displacement(-32y,0y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(24y,0y)
//        PenUp
//        Displacement(-24y,0y)
//        PenDown
//        Displacement(-8y,-24y)
//        Displacement(-8y,-8y)
//        Displacement(-8y,0y)
//        Displacement(-8y,8y)
//    ]
//    // ā
//    dict.[43169us] <- [
//        PenUp
//        Displacement(79y,24y)
//        PenDown
//        Displacement(0y,48y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(0y,56y)
//        PenDown
//        Displacement(-48y,0y)
//    ]
//    // á
//    dict.[43170us] <- [
//        PenUp
//        Displacement(79y,24y)
//        PenDown
//        Displacement(0y,48y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(-32y,48y)
//        PenDown
//        Displacement(24y,16y)
//    ]
//    // ǎ
//    dict.[43171us] <- [
//        PenUp
//        Displacement(79y,24y)
//        PenDown
//        Displacement(0y,48y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(-40y,64y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(16y,16y)
//    ]
//    // à
//    dict.[43172us] <- [
//        PenUp
//        Displacement(79y,24y)
//        PenDown
//        Displacement(0y,48y)
//        Displacement(-24y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-8y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(16y,0y)
//        Displacement(8y,8y)
//        PenUp
//        Displacement(-8y,48y)
//        PenDown
//        Displacement(-24y,8y)
//    ]
//    // ē
//    dict.[43173us] <- [
//        PenUp
//        Displacement(32y,48y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(0y,56y)
//        PenDown
//        Displacement(-48y,0y)
//    ]
//    // é
//    dict.[43174us] <- [
//        PenUp
//        Displacement(32y,48y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(-8y,64y)
//        PenDown
//        Displacement(-32y,-16y)
//    ]
//    // ě
//    dict.[43175us] <- [
//        PenUp
//        Displacement(32y,48y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(-8y,64y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(-16y,16y)
//    ]
//    // è
//    dict.[43176us] <- [
//        PenUp
//        Displacement(32y,48y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(-8y,48y)
//        PenDown
//        Displacement(-32y,16y)
//    ]
//    // ī
//    dict.[43177us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-16y,-16y)
//        PenDown
//        Displacement(0y,-48y)
//    ]
//    // í
//    dict.[43178us] <- [
//        PenUp
//        Displacement(40y,79y)
//        PenDown
//        Displacement(32y,16y)
//        PenUp
//        Displacement(-16y,-24y)
//        PenDown
//        Displacement(0y,-48y)
//    ]
//    // ǐ
//    dict.[43179us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(16y,16y)
//        PenUp
//        Displacement(-16y,-24y)
//        PenDown
//        Displacement(0y,-48y)
//    ]
//    // ì
//    dict.[43180us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(32y,-16y)
//        PenUp
//        Displacement(-16y,-8y)
//        PenDown
//        Displacement(0y,-48y)
//    ]
//    // ō
//    dict.[43181us] <- [
//        PenUp
//        Displacement(48y,71y)
//        PenDown
//        Displacement(16y,0y)
//        Displacement(16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,16y)
//        Displacement(0y,16y)
//        Displacement(16y,16y)
//        PenUp
//        Displacement(-8y,16y)
//        PenDown
//        Displacement(32y,0y)
//    ]
//    // ó
//    dict.[43182us] <- [
//        PenUp
//        Displacement(48y,71y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(-8y,8y)
//        PenDown
//        Displacement(32y,16y)
//    ]
//    // ǒ
//    dict.[43183us] <- [
//        PenUp
//        Displacement(48y,71y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(-8y,24y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(16y,16y)
//    ]
//    // ò
//    dict.[43184us] <- [
//        PenUp
//        Displacement(48y,71y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,16y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        PenUp
//        Displacement(24y,8y)
//        PenDown
//        Displacement(-32y,16y)
//    ]
//    // ū
//    dict.[43185us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(-40y,-16y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(0y,-48y)
//    ]
//    // ú
//    dict.[43186us] <- [
//        PenUp
//        Displacement(32y,71y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(-40y,56y)
//        PenDown
//        Displacement(32y,16y)
//    ]
//    // ǔ
//    dict.[43187us] <- [
//        PenUp
//        Displacement(32y,71y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(-8y,71y)
//        PenDown
//        Displacement(-16y,-16y)
//        Displacement(-16y,16y)
//    ]
//    // ù
//    dict.[43188us] <- [
//        PenUp
//        Displacement(32y,71y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(0y,-48y)
//        PenUp
//        Displacement(-8y,56y)
//        PenDown
//        Displacement(-32y,16y)
//    ]
//    // ǖ
//    dict.[43189us] <- [
//        PenUp
//        Displacement(40y,95y)
//        PenDown
//        Displacement(32y,0y)
//        PenUp
//        Displacement(0y,-16y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(0y,-48y)
//    ]
//    // ǘ
//    dict.[43190us] <- [
//        PenUp
//        Displacement(40y,87y)
//        PenDown
//        Displacement(32y,16y)
//        PenUp
//        Displacement(0y,-24y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(0y,-48y)
//    ]
//    // ǚ
//    dict.[43191us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(16y,-16y)
//        Displacement(16y,16y)
//        PenUp
//        Displacement(0y,-24y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(0y,-48y)
//    ]
//    // ǜ
//    dict.[43192us] <- [
//        PenUp
//        Displacement(40y,103y)
//        PenDown
//        Displacement(32y,-16y)
//        PenUp
//        Displacement(0y,-8y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(0y,-48y)
//    ]
//    // ü
//    dict.[43193us] <- [
//        PenUp
//        Displacement(71y,79y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-16y,0y)
//        PenDown
//        Displacement(-8y,0y)
//        PenUp
//        Displacement(-8y,-8y)
//        PenDown
//        Displacement(0y,-32y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,16y)
//        Displacement(0y,32y)
//        Displacement(0y,-48y)
//    ]
//    // ê
//    dict.[43194us] <- [
//        PenUp
//        Displacement(32y,48y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(0y,8y)
//        Displacement(-16y,16y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-16y)
//        Displacement(0y,-16y)
//        Displacement(16y,-16y)
//        Displacement(16y,0y)
//        Displacement(16y,8y)
//        PenUp
//        Displacement(-8y,48y)
//        PenDown
//        Displacement(-16y,16y)
//        Displacement(-16y,-16y)
//    ]
//    // ㄅ
//    dict.[43205us] <- [
//        PenUp
//        Displacement(40y,111y)
//        PenDown
//        Displacement(-24y,-32y)
//        Displacement(79y,0y)
//        Displacement(-8y,-32y)
//        Displacement(-8y,-24y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,8y)
//    ]
//    // ㄆ
//    dict.[43206us] <- [
//        PenUp
//        Displacement(40y,111y)
//        PenDown
//        Displacement(-16y,-32y)
//        Displacement(71y,0y)
//        Displacement(-16y,-32y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,-16y)
//        Displacement(-24y,-8y)
//        PenUp
//        Displacement(32y,40y)
//        PenDown
//        Displacement(32y,-32y)
//    ]
//    // ㄇ
//    dict.[43207us] <- [
//        PenUp
//        Displacement(24y,16y)
//        PenDown
//        Displacement(-8y,71y)
//        Displacement(79y,0y)
//        Displacement(-8y,-71y)
//    ]
//    // ㄈ
//    dict.[43208us] <- [
//        PenUp
//        Displacement(95y,95y)
//        PenDown
//        Displacement(-79y,0y)
//        Displacement(0y,-64y)
//        Displacement(8y,-16y)
//        Displacement(16y,-8y)
//        Displacement(64y,0y)
//    ]
//    // ㄉ
//    dict.[43209us] <- [
//        PenUp
//        Displacement(48y,111y)
//        PenDown
//        Displacement(-24y,-32y)
//        Displacement(71y,0y)
//        Displacement(-8y,-32y)
//        Displacement(-8y,-24y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(-8y,56y)
//        PenDown
//        Displacement(-8y,-24y)
//        Displacement(-16y,-24y)
//        Displacement(-16y,-16y)
//    ]
//    // ㄊ
//    dict.[43210us] <- [
//        PenUp
//        Displacement(16y,87y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-40y,24y)
//        PenDown
//        Displacement(0y,-24y)
//        Displacement(-16y,-32y)
//        Displacement(-24y,-32y)
//        Displacement(71y,0y)
//        PenUp
//        Displacement(-16y,16y)
//        PenDown
//        Displacement(24y,-24y)
//    ]
//    // ㄋ
//    dict.[43211us] <- [
//        PenUp
//        Displacement(16y,103y)
//        PenDown
//        Displacement(56y,0y)
//        Displacement(-16y,-32y)
//        Displacement(40y,0y)
//        Displacement(-8y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,8y)
//    ]
//    // ㄌ
//    dict.[43212us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(-16y,-32y)
//        Displacement(79y,0y)
//        Displacement(-8y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(8y,87y)
//        PenDown
//        Displacement(-8y,-40y)
//        Displacement(-16y,-32y)
//        Displacement(-16y,-16y)
//        Displacement(-16y,-8y)
//    ]
//    // ㄍ
//    dict.[43213us] <- [
//        PenUp
//        Displacement(40y,111y)
//        PenDown
//        Displacement(-24y,-48y)
//        Displacement(24y,-48y)
//        PenUp
//        Displacement(56y,0y)
//        PenDown
//        Displacement(-24y,48y)
//        Displacement(24y,48y)
//    ]
//    // ㄎ
//    dict.[43214us] <- [
//        PenUp
//        Displacement(16y,103y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-40y,0y)
//        PenDown
//        Displacement(-24y,-40y)
//        Displacement(56y,0y)
//        Displacement(-16y,-40y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,8y)
//    ]
//    // ㄏ
//    dict.[43215us] <- [
//        PenUp
//        Displacement(95y,103y)
//        PenDown
//        Displacement(-71y,0y)
//        Displacement(8y,0y)
//        Displacement(-8y,-56y)
//        Displacement(-8y,-32y)
//    ]
//    // ㄐ
//    dict.[43216us] <- [
//        PenUp
//        Displacement(32y,95y)
//        PenDown
//        Displacement(-16y,-48y)
//        Displacement(64y,8y)
//        PenUp
//        Displacement(0y,56y)
//        PenDown
//        Displacement(0y,-95y)
//    ]
//    // ㄑ
//    dict.[43217us] <- [
//        PenUp
//        Displacement(64y,111y)
//        PenDown
//        Displacement(-24y,-48y)
//        Displacement(24y,-48y)
//    ]
//    // ㄒ
//    dict.[43218us] <- [
//        PenUp
//        Displacement(16y,103y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-40y,0y)
//        PenDown
//        Displacement(0y,-87y)
//    ]
//    // ㄓ
//    dict.[43219us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(0y,-48y)
//        Displacement(64y,0y)
//        Displacement(0y,48y)
//        PenUp
//        Displacement(-32y,16y)
//        PenDown
//        Displacement(0y,-95y)
//        PenUp
//        Displacement(-40y,0y)
//        PenDown
//        Displacement(79y,0y)
//    ]
//    // ㄔ
//    dict.[43220us] <- [
//        PenUp
//        Displacement(71y,111y)
//        PenDown
//        Displacement(-40y,-32y)
//        PenUp
//        Displacement(40y,-8y)
//        PenDown
//        Displacement(-40y,-32y)
//        PenUp
//        Displacement(24y,16y)
//        PenDown
//        Displacement(0y,-40y)
//    ]
//    // ㄕ
//    dict.[43221us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(48y,0y)
//        Displacement(0y,-24y)
//        Displacement(-48y,0y)
//        Displacement(0y,-24y)
//        Displacement(-8y,-24y)
//        Displacement(-8y,-16y)
//    ]
//    // ㄖ
//    dict.[43222us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(0y,-87y)
//        Displacement(0y,8y)
//        Displacement(64y,0y)
//        Displacement(0y,-8y)
//        Displacement(0y,87y)
//        Displacement(-64y,0y)
//        PenUp
//        Displacement(16y,-24y)
//        PenDown
//        Displacement(32y,-32y)
//    ]
//    // ㄗ
//    dict.[43223us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(56y,0y)
//        Displacement(-8y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(-8y,48y)
//        PenDown
//        Displacement(0y,-87y)
//    ]
//    // ㄘ
//    dict.[43224us] <- [
//        PenUp
//        Displacement(16y,87y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-48y,24y)
//        PenDown
//        Displacement(-16y,-48y)
//        Displacement(56y,0y)
//        Displacement(-8y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(-16y,8y)
//    ]
//    // ㄙ
//    dict.[43225us] <- [
//        PenUp
//        Displacement(56y,111y)
//        PenDown
//        Displacement(-24y,-71y)
//        Displacement(-16y,-24y)
//        Displacement(71y,8y)
//        PenUp
//        Displacement(-16y,16y)
//        PenDown
//        Displacement(24y,-24y)
//    ]
//    // ㄚ
//    dict.[43226us] <- [
//        PenUp
//        Displacement(24y,111y)
//        PenDown
//        Displacement(32y,-32y)
//        Displacement(32y,32y)
//        Displacement(-32y,-32y)
//        Displacement(0y,-64y)
//    ]
//    // ㄛ
//    dict.[43227us] <- [
//        PenUp
//        Displacement(16y,103y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-40y,0y)
//        PenDown
//        Displacement(0y,-24y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(8y,-16y)
//        Displacement(16y,-8y)
//        Displacement(32y,0y)
//        Displacement(16y,8y)
//    ]
//    // ㄜ
//    dict.[43228us] <- [
//        PenUp
//        Displacement(16y,95y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-40y,24y)
//        PenDown
//        Displacement(0y,-48y)
//        Displacement(-16y,0y)
//        Displacement(-16y,-8y)
//        Displacement(-8y,-16y)
//        Displacement(0y,-16y)
//        Displacement(8y,-8y)
//        Displacement(16y,-8y)
//        Displacement(32y,0y)
//        Displacement(16y,8y)
//    ]
//    // ㄝ
//    dict.[43229us] <- [
//        PenUp
//        Displacement(16y,64y)
//        PenDown
//        Displacement(79y,8y)
//        PenUp
//        Displacement(-24y,40y)
//        PenDown
//        Displacement(0y,-48y)
//        Displacement(-8y,-24y)
//        Displacement(-8y,-8y)
//        PenUp
//        Displacement(-24y,79y)
//        PenDown
//        Displacement(0y,-71y)
//        Displacement(8y,-16y)
//        Displacement(16y,-8y)
//        Displacement(40y,0y)
//    ]
//    // ㄞ
//    dict.[43230us] <- [
//        PenUp
//        Displacement(95y,111y)
//        PenDown
//        Displacement(-79y,0y)
//        Displacement(8y,0y)
//        Displacement(-8y,-32y)
//        Displacement(79y,0y)
//        Displacement(-8y,-32y)
//        Displacement(-8y,-24y)
//        Displacement(-8y,-8y)
//        Displacement(-16y,8y)
//        PenUp
//        Displacement(0y,87y)
//        PenDown
//        Displacement(-8y,-48y)
//        Displacement(-16y,-32y)
//        Displacement(-16y,-16y)
//    ]
//    // ㄟ
//    dict.[43231us] <- [
//        PenUp
//        Displacement(32y,103y)
//        PenDown
//        Displacement(24y,0y)
//        Displacement(0y,-16y)
//        Displacement(8y,-32y)
//        Displacement(8y,-16y)
//        Displacement(24y,-24y)
//    ]
//    // ㄠ
//    dict.[43232us] <- [
//        PenUp
//        Displacement(56y,111y)
//        PenDown
//        Displacement(-40y,-48y)
//        Displacement(56y,0y)
//        PenUp
//        Displacement(16y,16y)
//        PenDown
//        Displacement(-71y,-56y)
//        Displacement(71y,0y)
//        PenUp
//        Displacement(-16y,16y)
//        PenDown
//        Displacement(24y,-24y)
//    ]
//    // ㄡ
//    dict.[43233us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(-8y,-24y)
//        Displacement(-24y,-32y)
//        Displacement(-16y,-16y)
//        Displacement(-24y,-16y)
//        PenUp
//        Displacement(24y,56y)
//        PenDown
//        Displacement(40y,-40y)
//    ]
//    // ㄢ
//    dict.[43234us] <- [
//        PenUp
//        Displacement(24y,103y)
//        PenDown
//        Displacement(64y,0y)
//        Displacement(-8y,-32y)
//        PenUp
//        Displacement(-48y,32y)
//        PenDown
//        Displacement(-8y,-32y)
//        Displacement(71y,0y)
//        Displacement(-8y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//    ]
//    // ㄣ
//    dict.[43235us] <- [
//        PenUp
//        Displacement(32y,111y)
//        PenDown
//        Displacement(-8y,-40y)
//        Displacement(71y,0y)
//        Displacement(-8y,-32y)
//        Displacement(-8y,-16y)
//        Displacement(-8y,-8y)
//    ]
//    // ㄤ
//    dict.[43236us] <- [
//        PenUp
//        Displacement(16y,79y)
//        PenDown
//        Displacement(79y,0y)
//        PenUp
//        Displacement(-40y,32y)
//        PenDown
//        Displacement(-8y,-48y)
//        Displacement(-8y,-24y)
//        Displacement(-24y,-24y)
//        PenUp
//        Displacement(48y,64y)
//        PenDown
//        Displacement(0y,-56y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//    ]
//    // ㄥ
//    dict.[43237us] <- [
//        PenUp
//        Displacement(56y,111y)
//        PenDown
//        Displacement(-16y,-56y)
//        Displacement(-24y,-40y)
//        Displacement(79y,0y)
//    ]
//    // ㄦ
//    dict.[43238us] <- [
//        PenUp
//        Displacement(40y,111y)
//        PenDown
//        Displacement(0y,-40y)
//        Displacement(-8y,-32y)
//        Displacement(-16y,-24y)
//        PenUp
//        Displacement(48y,95y)
//        PenDown
//        Displacement(0y,-87y)
//        Displacement(8y,-8y)
//        Displacement(24y,0y)
//        Displacement(0y,8y)
//    ]
//    // ㄧ
//    dict.[43239us] <- [
//        PenUp
//        Displacement(56y,111y)
//        PenDown
//        Displacement(0y,-95y)
//    ]
//    // ㄨ
//    dict.[43240us] <- [
//        PenUp
//        Displacement(87y,111y)
//        PenDown
//        Displacement(-16y,-48y)
//        Displacement(-24y,-32y)
//        Displacement(-32y,-16y)
//        PenUp
//        Displacement(16y,79y)
//        PenDown
//        Displacement(32y,-40y)
//        Displacement(24y,-40y)
//    ]
//    // ㄩ
//    dict.[43241us] <- [
//        PenUp
//        Displacement(24y,95y)
//        PenDown
//        Displacement(-8y,-71y)
//        Displacement(71y,0y)
//        Displacement(0y,-8y)
//        Displacement(0y,87y)
//    ]
//    Map.fromInterface dict

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


//let punctuations =
//    //后来者赢，不要改变顺序
//    [
//        chin2
//        sbhz
//        xxx
//    ]
//    |> Seq.collect(Map.toSeq)
//    |> Map.ofSeq
