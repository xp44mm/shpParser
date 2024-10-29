module SimplexTestProject.Simplex
open shpParser
let shapes = [
    10us, [
        PenUp
        Displacement(0y,-36y)
        // VerticalText(Displacement(30y,36y))
        EndOfShape
    ]
    //  
    32us, [
        PenUp
        Displacement(19y,0y)
        // VerticalText(Displacement(-19y,-30y))
        EndOfShape
    ]
    // !
    33us, [
        PenUp
        // VerticalText(Displacement(-1y,-21y))
        Displacement(1y,21y)
        PenDown
        Vector 0xECuy
        PenUp
        Vector 0x5Cuy
        PenDown // ae2b画单位菱形
        Vector 0x1Auy
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        PenUp
        Displacement(12y,-2y)
        // VerticalText(Displacement(-12y,-10y))
        EndOfShape
    ]
    // "
    34us, [
        PenUp
        // VerticalText(Displacement(-4y,-25y))
        Displacement(2y,24y)
        PenDown
        Vector 0x1Auy
        Vector 0x16uy
        Vector 0x12uy
        Vector 0x1Euy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        PenUp
        Displacement(8y,5y)
        PenDown
        Vector 0x1Auy
        Vector 0x16uy
        Vector 0x12uy
        Vector 0x1Euy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        PenUp
        Displacement(9y,-19y)
        // VerticalText(Displacement(-11y,9y))
        EndOfShape
    ]
    // #
    35us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-15y,-42y))
        // VerticalText(Multiply 2uy)
        Displacement(8y,21y)
        PenDown
        Displacement(-7y,-28y)
        PenUp
        Displacement(13y,28y)
        PenDown
        Displacement(-7y,-28y)
        PenUp
        Displacement(-6y,17y)
        PenDown
        Displacement(14y,0y)
        PenUp
        Displacement(-15y,-6y)
        PenDown
        Vector 0xE0uy
        PenUp
        Displacement(5y,-4y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-23y,-35y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // $
    36us, [
        PenUp
        // VerticalText(Displacement(-7y,-25y))
        Displacement(5y,25y)
        PenDown
        Displacement(0y,-29y)
        PenUp
        Displacement(4y,29y)
        PenDown
        Displacement(0y,-29y)
        PenUp
        Displacement(5y,22y)
        PenDown
        Vector 0x26uy
        Displacement(-3y,1y)
        Vector 0x48uy
        Displacement(-3y,-1y)
        Vector 0x2Auy
        Vector 0x2Cuy
        Vector 0x2Duy
        Vector 0x1Euy
        Vector 0x2Fuy
        Displacement(6y,-2y)
        Vector 0x2Fuy
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x3Cuy
        Vector 0x2Auy
        Displacement(-3y,-1y)
        Vector 0x48uy
        Displacement(-3y,1y)
        Vector 0x26uy
        PenUp
        Displacement(20y,-3y)
        // VerticalText(Displacement(-13y,-14y))
        EndOfShape
    ]
    // %
    37us, [
        PenUp
        // VerticalText(Displacement(-9y,-21y))
        PenDown
        Displacement(18y,21y)
        PenUp
        Vector 0xD8uy
        PenDown
        Vector 0x2Euy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x29uy
        Vector 0x28uy
        Vector 0x26uy
        Vector 0x24uy
        Vector 0x23uy
        Vector 0x21uy
        Vector 0x20uy
        Vector 0x2Fuy
        Displacement(3y,-1y)
        Vector 0x30uy
        Displacement(3y,1y)
        Vector 0x21uy
        PenUp
        Displacement(-4y,-14y)
        PenDown
        Vector 0x29uy
        Vector 0x2Buy
        Vector 0x2Cuy
        Vector 0x2Euy
        Vector 0x20uy
        Vector 0x21uy
        Vector 0x23uy
        Vector 0x24uy
        Vector 0x26uy
        Vector 0x28uy
        PenUp
        Displacement(8y,-7y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // &
    38us, [
        PenUp
        // VerticalText(Displacement(-10y,-21y))
        Displacement(20y,12y)
        PenDown
        Vector 0x14uy
        Vector 0x16uy
        Vector 0x18uy
        Vector 0x1Auy
        Vector 0x2Buy
        Displacement(-2y,-5y)
        Displacement(-2y,-3y)
        Vector 0x2Auy
        Vector 0x29uy
        Vector 0x48uy
        Vector 0x27uy
        Vector 0x16uy
        Vector 0x25uy
        Vector 0x24uy
        Vector 0x23uy
        Vector 0x12uy
        Displacement(7y,4y)
        Vector 0x12uy
        Vector 0x23uy
        Vector 0x24uy
        Vector 0x25uy
        Vector 0x27uy
        Vector 0x29uy
        Vector 0x2Buy
        Vector 0x2Cuy
        Displacement(1y,-3y)
        Displacement(2y,-3y)
        Displacement(5y,-7y)
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x20uy
        Vector 0x12uy
        Vector 0x14uy
        PenUp
        Displacement(6y,-2y)
        // VerticalText(Displacement(-16y,-10y))
        EndOfShape
    ]
    // '
    39us, [
        PenUp
        // VerticalText(Displacement(-1y,-25y))
        Displacement(2y,24y)
        PenDown
        Vector 0x1Auy
        Vector 0x16uy
        Vector 0x12uy
        Vector 0x1Euy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        PenUp
        Displacement(9y,-19y)
        // VerticalText(Displacement(-8y,9y))
        EndOfShape
    ]
    // (
    40us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-7y,-50y))
        // VerticalText(Multiply 2uy)
        Displacement(7y,25y)
        PenDown
        Vector 0x2Auy
        Displacement(-2y,-3y)
        Vector 0x4Buy
        Displacement(-1y,-5y)
        Vector 0x4Cuy
        Displacement(1y,-5y)
        Vector 0x4Duy
        Displacement(2y,-3y)
        Vector 0x2Euy
        PenUp
        Vector 0x72uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-21y,-35y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // )
    41us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-7y,-50y))
        // VerticalText(Multiply 2uy)
        Displacement(0y,25y)
        PenDown
        Vector 0x2Euy
        Displacement(2y,-3y)
        Vector 0x4Duy
        Displacement(1y,-5y)
        Vector 0x4Cuy
        Displacement(-1y,-5y)
        Vector 0x4Buy
        Displacement(-2y,-3y)
        Vector 0x2Auy
        PenUp
        Vector 0xE1uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-21y,-35y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // *
    42us, [
        PenUp
        // VerticalText(Displacement(-5y,-21y))
        Displacement(5y,21y)
        PenDown
        Vector 0xCCuy
        PenUp
        Displacement(-5y,9y)
        PenDown
        Displacement(10y,-6y)
        PenUp
        Displacement(0y,6y)
        PenDown
        Displacement(-10y,-6y)
        PenUp
        Displacement(16y,-12y)
        // VerticalText(Displacement(-11y,-7y))
        EndOfShape
    ]
    // +
    43us, [
        PenUp
        // VerticalText(Displacement(-9y,-18y))
        Displacement(9y,18y)
        PenDown
        Displacement(0y,-18y)
        PenUp
        Vector 0x96uy
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(8y,-9y)
        // VerticalText(Displacement(-17y,-10y))
        EndOfShape
    ]
    // ,
    44us, [
        PenUp
        // VerticalText(Vector 0x2Buy)
        Vector 0x21uy
        PenDown
        Vector 0x1Auy
        Vector 0x16uy
        Vector 0x12uy
        Vector 0x1Euy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        PenUp
        Displacement(10y,4y)
        // VerticalText(Displacement(-9y,-14y))
        EndOfShape
    ]
    // -
    45us, [
        PenUp
        // VerticalText(Vector 0x9Auy)
        Vector 0x94uy
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(8y,-9y)
        // VerticalText(Displacement(-17y,-1y))
        EndOfShape
    ]
    // .
    46us, [
        PenUp
        // VerticalText(Vector 0x2Buy)
        Vector 0x23uy
        PenDown
        Vector 0x1Auy
        Vector 0x1Euy
        Vector 0x12uy
        PenUp
        Displacement(8y,-1y)
        // VerticalText(Displacement(-9y,-10y))
        EndOfShape
    ]
    // /
    47us, [
        PenUp
        // VerticalText(Displacement(-9y,-25y))
        Displacement(18y,25y)
        PenDown
        Displacement(-18y,-32y)
        PenUp
        Displacement(22y,7y)
        // VerticalText(Displacement(-13y,-17y))
        EndOfShape
    ]
    // 0
    48us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(6y,21y)
        PenDown
        ManyDisplacements [-3y,-1y;-2y,-3y;-1y,-5y;0y,-3y;1y,-5y;2y,-3y;3y,-1y;2y,0y;3y,1y;2y,3y;1y,5y;0y,3y;-1y,5y;-2y,3y;-3y,1y;-2y,0y]
        PenUp
        Displacement(14y,-21y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // 1
    49us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-5y,-42y))
        // VerticalText(Multiply 2uy)
        Displacement(0y,17y)
        PenDown
        Vector 0x21uy
        Vector 0x32uy
        Displacement(0y,-21y)
        PenUp
        Vector 0xB0uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-27y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // 2
    50us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(1y,16y)
        PenDown
        Vector 0x14uy
        Vector 0x23uy
        Vector 0x12uy
        Vector 0x21uy
        Vector 0x40uy
        Vector 0x2Fuy
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x2Cuy
        Vector 0x2Buy
        Displacement(-2y,-3y)
        Vector 0xAAuy
        Vector 0xE0uy
        PenUp
        Vector 0x60uy
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // 3
    51us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(2y,21y)
        PenDown
        Vector 0xB0uy
        Displacement(-6y,-8y)
        Vector 0x30uy
        Vector 0x2Fuy
        Vector 0x1Euy
        Displacement(1y,-3y)
        Vector 0x2Cuy
        Displacement(-1y,-3y)
        Vector 0x2Auy
        Displacement(-3y,-1y)
        Vector 0x38uy
        Displacement(-3y,1y)
        Vector 0x16uy
        Vector 0x25uy
        PenUp
        Displacement(20y,-4y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // 4
    52us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-15y,-42y))
        // VerticalText(Multiply 2uy)
        Displacement(10y,21y)
        PenDown
        Displacement(-10y,-14y)
        Vector 0xF0uy
        PenUp
        Displacement(-5y,14y)
        PenDown
        Displacement(0y,-21y)
        PenUp
        Vector 0xA0uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-25y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // 5
    53us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(12y,21y)
        PenDown
        ManyDisplacements [-10y,0y;-1y,-9y;1y,1y;3y,1y;3y,0y;3y,-1y;2y,-2y;1y,-3y;0y,-2y;-1y,-3y;-2y,-2y;-3y,-1y;-3y,0y;-3y,1y;-1y,1y;-1y,2y]
        PenUp
        Displacement(20y,-4y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // 6
    54us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-13y,-42y))
        // VerticalText(Multiply 2uy)
        Displacement(12y,18y)
        PenDown
        ManyDisplacements [-1y,2y;-3y,1y;-2y,0y;-3y,-1y;-2y,-3y;-1y,-5y;0y,-5y;1y,-4y;2y,-2y;3y,-1y;1y,0y;3y,1y;2y,2y;1y,3y;0y,1y;-1y,3y;-2y,2y;-3y,1y;-1y,0y;-3y,-1y;-2y,-2y;-1y,-3y]
        PenUp
        Displacement(20y,-7y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-27y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // 7
    55us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(0y,21y)
        PenDown
        ManyDisplacements [14y,0y;-10y,-21y]
        PenUp
        Displacement(16y,0y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // 8
    56us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(5y,21y)
        PenDown
        Displacement(-3y,-1y)
        Vector 0x2Buy
        Vector 0x2Cuy
        Vector 0x2Duy
        Vector 0x2Fuy
        Displacement(4y,-1y)
        Displacement(3y,-1y)
        Vector 0x2Euy
        Vector 0x2Duy
        Vector 0x3Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Displacement(-3y,-1y)
        Vector 0x48uy
        Displacement(-3y,1y)
        Vector 0x16uy
        Vector 0x25uy
        Vector 0x34uy
        Vector 0x23uy
        Vector 0x22uy
        Displacement(3y,1y)
        Displacement(4y,1y)
        Vector 0x21uy
        Vector 0x23uy
        Vector 0x24uy
        Vector 0x25uy
        Displacement(-3y,1y)
        Vector 0x48uy
        PenUp
        Displacement(15y,-21y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // 9
    57us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-13y,-42y))
        // VerticalText(Multiply 2uy)
        Displacement(13y,14y)
        PenDown
        ManyDisplacements [-1y,-3y;-2y,-2y;-3y,-1y;-1y,0y;-3y,1y;-2y,2y;-1y,3y;0y,1y;1y,3y;2y,2y;3y,1y;1y,0y;3y,-1y;2y,-2y;1y,-4y;0y,-5y;-1y,-5y;-2y,-3y;-3y,-1y;-2y,0y;-3y,1y;-1y,2y]
        PenUp
        Displacement(19y,-3y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-27y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // :
    58us, [
        PenUp
        // VerticalText(Displacement(-1y,-14y))
        Displacement(1y,14y)
        PenDown
        Vector 0x1Auy
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        PenUp
        Vector 0xCCuy
        PenDown
        Vector 0x1Auy
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        PenUp
        Displacement(14y,-2y)
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // ;
    59us, [
        PenUp
        // VerticalText(Displacement(-1y,-14y))
        Displacement(1y,14y)
        PenDown
        Vector 0x1Auy
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        PenUp
        Vector 0xECuy
        PenDown
        Vector 0x16uy
        Vector 0x12uy
        Vector 0x1Euy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        PenUp
        Displacement(14y,4y)
        // VerticalText(Displacement(-13y,-14y))
        EndOfShape
    ]
    // <
    60us, [
        PenUp
        // VerticalText(Displacement(-8y,-18y))
        Displacement(16y,18y)
        PenDown
        Displacement(-16y,-9y)
        Displacement(16y,-9y)
        PenUp
        Vector 0x40uy
        // VerticalText(Displacement(-12y,-10y))
        EndOfShape
    ]
    // =
    61us, [
        PenUp
        // VerticalText(Displacement(-9y,-12y))
        Vector 0xC4uy
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(-18y,-6y)
        PenDown
        Displacement(18y,0y)
        PenUp
        Displacement(8y,-6y)
        // VerticalText(Displacement(-17y,-4y))
        EndOfShape
    ]
    // >
    62us, [
        PenUp
        // VerticalText(Displacement(-8y,-18y))
        Displacement(0y,18y)
        PenDown
        Displacement(16y,-9y)
        Displacement(-16y,-9y)
        PenUp
        Displacement(20y,0y)
        // VerticalText(Displacement(-12y,-10y))
        EndOfShape
    ]
    // ?
    63us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-11y,-42y))
        // VerticalText(Multiply 2uy)
        Displacement(1y,17y)
        PenDown
        Vector 0x1Euy
        Vector 0x1Auy
        Vector 0x16uy
        Vector 0x14uy
        Vector 0x23uy
        Vector 0x12uy
        Vector 0x21uy
        Vector 0x30uy
        Displacement(3y,-1y)
        Vector 0x2Duy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Vector 0x29uy
        Vector 0x2Auy
        Vector 0x3Cuy
        PenUp
        Vector 0x5Cuy
        PenDown
        Vector 0x1Auy
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        PenUp
        Displacement(13y,-2y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-25y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // @
    64us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-21y,-42y))
        // VerticalText(Multiply 2uy)
        Displacement(15y,13y)
        PenDown
        Vector 0x25uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x29uy
        Vector 0x1Auy
        Vector 0x2Buy
        Vector 0x3Cuy
        Vector 0x2Duy
        Vector 0x1Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x23uy
        PenUp
        Vector 0x84uy
        PenDown
        Vector 0xACuy
        Vector 0x1Euy
        Vector 0x20uy
        Vector 0x22uy
        Displacement(1y,3y)
        Vector 0x24uy
        Displacement(-1y,3y)
        Vector 0x25uy
        Vector 0x26uy
        Vector 0x27uy
        Displacement(-3y,1y)
        Vector 0x38uy
        Displacement(-3y,-1y)
        Vector 0x29uy
        Vector 0x2Auy
        Vector 0x2Buy
        Displacement(-1y,-3y)
        Vector 0x3Cuy
        Displacement(1y,-3y)
        Vector 0x2Duy
        Vector 0x2Euy
        Vector 0x2Fuy
        Displacement(3y,-1y)
        Vector 0x30uy
        Displacement(3y,1y)
        Vector 0x21uy
        Vector 0x12uy
        PenUp
        Displacement(6y,-3y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-27y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // A
    65us, [
        PenUp
        // VerticalText(Displacement(-8y,-21y))
        PenDown
        Displacement(8y,21y)
        Displacement(8y,-21y)
        PenUp
        Displacement(-13y,7y)
        PenDown
        Vector 0xA0uy
        PenUp
        Displacement(9y,-7y)
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // B
    66us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        PenDown
        Displacement(0y,21y)
        Vector 0x90uy
        Displacement(3y,-1y)
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Displacement(-3y,-1y)
        PenUp
        Vector 0x98uy
        PenDown
        Vector 0x90uy
        Displacement(3y,-1y)
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x3Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Displacement(-3y,-1y)
        Vector 0x98uy
        PenUp
        Displacement(21y,0y)
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // C
    67us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-15y,-42y))
        // VerticalText(Multiply 2uy)
        Displacement(15y,16y)
        PenDown
        Vector 0x25uy
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x48uy
        Vector 0x29uy
        Vector 0x2Auy
        Vector 0x2Buy
        Displacement(-1y,-3y)
        Vector 0x5Cuy
        Displacement(1y,-3y)
        Vector 0x2Duy
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x40uy
        Vector 0x21uy
        Vector 0x22uy
        Vector 0x23uy
        PenUp
        Displacement(6y,-5y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-27y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // D
    68us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        PenDown
        ManyDisplacements [0y,21y;7y,0y;3y,-1y;2y,-2y;1y,-2y;1y,-3y;0y,-5y;-1y,-3y;-1y,-2y;-2y,-2y;-3y,-1y;-7y,0y]
        PenUp
        Displacement(21y,0y)
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // E
    69us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-13y,-42y))
        // VerticalText(Multiply 2uy)
        PenDown
        Displacement(0y,21y)
        Vector 0xD0uy
        PenUp
        Displacement(-13y,-10y)
        PenDown
        Vector 0x80uy
        PenUp
        Displacement(-8y,-11y)
        PenDown
        Vector 0xD0uy
        PenUp
        Vector 0x60uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-25y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // F
    70us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-13y,-42y))
        // VerticalText(Multiply 2uy)
        PenDown
        Displacement(0y,21y)
        Vector 0xD0uy
        PenUp
        Displacement(-13y,-10y)
        PenDown
        Vector 0x80uy
        PenUp
        Displacement(10y,-11y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-23y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // G
    71us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-15y,-42y))
        // VerticalText(Multiply 2uy)
        Displacement(15y,16y)
        PenDown
        Vector 0x25uy
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x48uy
        Vector 0x29uy
        Vector 0x2Auy
        Vector 0x2Buy
        Displacement(-1y,-3y)
        Vector 0x5Cuy
        Displacement(1y,-3y)
        Vector 0x2Duy
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x40uy
        Vector 0x21uy
        Vector 0x22uy
        Vector 0x23uy
        Vector 0x34uy
        Vector 0x58uy
        PenUp
        Displacement(11y,-8y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-27y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // H
    72us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        PenDown
        Displacement(0y,21y)
        PenUp
        Vector 0xE0uy
        PenDown
        Displacement(0y,-21y)
        PenUp
        Displacement(-14y,11y)
        PenDown
        Vector 0xE0uy
        PenUp
        Displacement(8y,-11y)
        // VerticalText(Displacement(-15y,-10y))
        EndOfShape
    ]
    // I
    73us, [
        PenUp
        // VerticalText(Displacement(0y,-21y))
        PenDown
        Displacement(0y,21y)
        PenUp
        Displacement(8y,-21y)
        // VerticalText(Displacement(-8y,-10y))
        EndOfShape
    ]
    // J
    74us, [
        PenUp
        // VerticalText(Displacement(-5y,-21y))
        Displacement(10y,21y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-1y,-3y)
        Vector 0x1Auy
        Vector 0x29uy
        Vector 0x28uy
        Vector 0x27uy
        Vector 0x16uy
        Displacement(-1y,3y)
        Vector 0x24uy
        PenUp
        Displacement(16y,-7y)
        // VerticalText(Displacement(-11y,-10y))
        EndOfShape
    ]
    // K
    75us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        PenDown
        Displacement(0y,21y)
        PenUp
        Vector 0xE0uy
        PenDown
        Vector 0xEAuy
        PenUp
        Vector 0x52uy
        PenDown
        Displacement(9y,-12y)
        PenUp
        Vector 0x70uy
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // L
    76us, [
        PenUp
        // VerticalText(Displacement(-6y,-21y))
        Displacement(0y,21y)
        PenDown
        Displacement(0y,-21y)
        Vector 0xC0uy
        PenUp
        Vector 0x50uy
        // VerticalText(Displacement(-11y,-10y))
        EndOfShape
    ]
    // M
    77us, [
        PenUp
        // VerticalText(Displacement(-8y,-21y))
        PenDown
        ManyDisplacements [0y,21y;8y,-21y;8y,21y;0y,-21y]
        PenUp
        Vector 0x80uy
        // VerticalText(Displacement(-16y,-10y))
        EndOfShape
    ]
    // N
    78us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        PenDown
        ManyDisplacements [0y,21y;14y,-21y;0y,21y]
        PenUp
        Displacement(8y,-21y)
        // VerticalText(Displacement(-15y,-10y))
        EndOfShape
    ]
    // O
    79us, [
        PenUp
        // VerticalText(Displacement(-8y,-21y))
        Displacement(6y,21y)
        PenDown
        Vector 0x29uy
        Vector 0x2Auy
        Vector 0x2Buy
        Displacement(-1y,-3y)
        Vector 0x5Cuy
        Displacement(1y,-3y)
        Vector 0x2Duy
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x40uy
        Vector 0x21uy
        Vector 0x22uy
        Vector 0x23uy
        Displacement(1y,3y)
        Vector 0x54uy
        Displacement(-1y,3y)
        Vector 0x25uy
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x48uy
        PenUp
        Displacement(16y,-21y)
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // P
    80us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        PenDown
        Displacement(0y,21y)
        Vector 0x90uy
        Displacement(3y,-1y)
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x3Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Displacement(-3y,-1y)
        Vector 0x98uy
        PenUp
        Displacement(21y,-10y)
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // Q
    81us, [
        PenUp
        // VerticalText(Displacement(-8y,-21y))
        Displacement(6y,21y)
        PenDown
        Vector 0x29uy
        Vector 0x2Auy
        Vector 0x2Buy
        Displacement(-1y,-3y)
        Vector 0x5Cuy
        Displacement(1y,-3y)
        Vector 0x2Duy
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x40uy
        Vector 0x21uy
        Vector 0x22uy
        Vector 0x23uy
        Displacement(1y,3y)
        Vector 0x54uy
        Displacement(-1y,3y)
        Vector 0x25uy
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x48uy
        PenUp
        Displacement(3y,-17y)
        PenDown
        Vector 0x6Euy
        PenUp
        Displacement(7y,2y)
        // VerticalText(Displacement(-14y,-12y))
        EndOfShape
    ]
    // R
    82us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        PenDown
        Displacement(0y,21y)
        Vector 0x90uy
        Displacement(3y,-1y)
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Displacement(-3y,-1y)
        Vector 0x98uy
        PenUp
        Vector 0x70uy
        PenDown
        Displacement(7y,-11y)
        PenUp
        Vector 0x70uy
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // S
    83us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(14y,18y)
        PenDown
        ManyDisplacements [-2y,2y;-3y,1y;-4y,0y;-3y,-1y;-2y,-2y;0y,-2y;1y,-2y;1y,-1y;2y,-1y;6y,-2y;2y,-1y;1y,-1y;1y,-2y;0y,-3y;-2y,-2y;-3y,-1y;-4y,0y;-3y,1y;-2y,2y]
        PenUp
        Displacement(20y,-3y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // T
    84us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(7y,21y)
        PenDown
        Displacement(0y,-21y)
        PenUp
        Displacement(-7y,21y)
        PenDown
        Vector 0xE0uy
        PenUp
        Displacement(4y,-21y)
        // VerticalText(Displacement(-11y,-10y))
        EndOfShape
    ]
    // U
    85us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(0y,21y)
        PenDown
        ManyDisplacements [0y,-15y;1y,-3y;2y,-2y;3y,-1y;2y,0y;3y,1y;2y,2y;1y,3y;0y,15y]
        PenUp
        Displacement(8y,-21y)
        // VerticalText(Displacement(-15y,-10y))
        EndOfShape
    ]
    // V
    86us, [
        PenUp
        // VerticalText(Displacement(-8y,-21y))
        Displacement(0y,21y)
        PenDown
        ManyDisplacements [8y,-21y;8y,21y]
        PenUp
        Displacement(4y,-21y)
        // VerticalText(Displacement(-12y,-10y))
        EndOfShape
    ]
    // W
    87us, [
        PenUp
        // VerticalText(Displacement(-10y,-21y))
        Displacement(0y,21y)
        PenDown
        ManyDisplacements [5y,-21y;5y,21y;5y,-21y;5y,21y]
        PenUp
        Displacement(4y,-21y)
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // X
    88us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        PenDown
        Displacement(14y,21y)
        PenUp
        Vector 0xE8uy
        PenDown
        Displacement(14y,-21y)
        PenUp
        Vector 0x60uy
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // Y
    89us, [
        PenUp
        // VerticalText(Displacement(-8y,-21y))
        Displacement(0y,21y)
        PenDown
        Displacement(8y,-10y)
        Displacement(8y,10y)
        PenUp
        Displacement(-8y,-10y)
        PenDown
        Vector 0xBCuy
        PenUp
        Vector 0xC0uy
        // VerticalText(Displacement(-12y,-10y))
        EndOfShape
    ]
    // Z
    90us, [
        PenUp
        // VerticalText(Displacement(-7y,-21y))
        Displacement(0y,21y)
        PenDown
        Vector 0xE0uy
        Displacement(-14y,-21y)
        Vector 0xE0uy
        PenUp
        Vector 0x60uy
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // [
    91us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-7y,-50y))
        // VerticalText(Multiply 2uy)
        Displacement(7y,25y)
        PenDown
        Vector 0x78uy
        Displacement(0y,-32y)
        Vector 0x70uy
        PenUp
        Displacement(8y,7y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-23y,-35y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // \
    92us, [
        PenUp
        // VerticalText(Displacement(-9y,-25y))
        Displacement(0y,25y)
        PenDown
        Displacement(18y,-32y)
        PenUp
        Displacement(4y,7y)
        // VerticalText(Displacement(-13y,-17y))
        EndOfShape
    ]
    // ]
    93us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-7y,-50y))
        // VerticalText(Multiply 2uy)
        Displacement(0y,25y)
        PenDown
        Vector 0x70uy
        Displacement(0y,-32y)
        Vector 0x78uy
        PenUp
        Displacement(12y,7y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-17y,-35y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // ^
    94us, [
        PenUp
        // VerticalText(Displacement(-7y,-25y))
        Displacement(0y,18y)
        PenDown
        Vector 0x72uy
        Vector 0x7Euy
        PenUp
        Displacement(6y,-18y)
        // VerticalText(Displacement(-13y,8y))
        EndOfShape
    ]
    // _
    95us, [
        PenUp
        // VerticalText(Vector 0xA8uy)
        Vector 0x2Cuy
        PenDown
        Displacement(20y,0y)
        PenUp
        Vector 0x41uy
        // VerticalText(Displacement(-14y,-12y))
        EndOfShape
    ]
    // `
    96us, [
        PenUp
        // VerticalText(Displacement(-1y,-25y))
        Displacement(0y,24y)
        PenDown
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        Vector 0x1Auy
        Vector 0x2Cuy
        Vector 0x2Duy
        Vector 0x1Euy
        PenUp
        Displacement(7y,-19y)
        // VerticalText(Displacement(-8y,9y))
        EndOfShape
    ]
    // a
    97us, [
        PenUp
        // VerticalText(Displacement(-6y,-14y))
        Displacement(12y,14y)
        PenDown
        Vector 0xECuy
        PenUp
        Vector 0xB4uy
        PenDown
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x29uy
        Vector 0x2Auy
        Displacement(-1y,-3y)
        Vector 0x2Cuy
        Displacement(1y,-3y)
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x22uy
        PenUp
        Displacement(7y,-3y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // b
    98us, [
        PenUp
        // VerticalText(Displacement(-6y,-21y))
        PenDown
        Displacement(0y,21y)
        PenUp
        Vector 0xACuy
        PenDown
        Vector 0x22uy
        Vector 0x21uy
        Vector 0x30uy
        Vector 0x2Fuy
        Vector 0x2Euy
        Displacement(1y,-3y)
        Vector 0x2Cuy
        Displacement(-1y,-3y)
        Vector 0x2Auy
        Vector 0x29uy
        Vector 0x38uy
        Vector 0x27uy
        Vector 0x26uy
        PenUp
        Displacement(19y,-3y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // c
    99us, [
        PenUp
        // VerticalText(Displacement(-6y,-14y))
        Displacement(12y,11y)
        PenDown
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x29uy
        Vector 0x2Auy
        Displacement(-1y,-3y)
        Vector 0x2Cuy
        Displacement(1y,-3y)
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x22uy
        PenUp
        Vector 0x6Fuy
        // VerticalText(Displacement(-12y,-10y))
        EndOfShape
    ]
    // d
    100us, [
        PenUp
        // VerticalText(Displacement(-6y,-21y))
        Displacement(12y,21y)
        PenDown
        Displacement(0y,-21y)
        PenUp
        Vector 0xB4uy
        PenDown
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x29uy
        Vector 0x2Auy
        Displacement(-1y,-3y)
        Vector 0x2Cuy
        Displacement(1y,-3y)
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x22uy
        PenUp
        Displacement(7y,-3y)
        // VerticalText(Displacement(-13y,-10y))
        EndOfShape
    ]
    // e
    101us, [
        PenUp
        // VerticalText(Displacement(-6y,-14y))
        Vector 0x84uy
        PenDown
        Vector 0xC0uy
        Vector 0x24uy
        Vector 0x25uy
        Vector 0x16uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x29uy
        Vector 0x2Auy
        Displacement(-1y,-3y)
        Vector 0x2Cuy
        Displacement(1y,-3y)
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x22uy
        PenUp
        Vector 0x6Fuy
        // VerticalText(Displacement(-12y,-10y))
        EndOfShape
    ]
    // f
    102us, [
        PenUp
        // VerticalText(Displacement(-4y,-21y))
        Displacement(8y,21y)
        PenDown
        Vector 0x28uy
        Vector 0x29uy
        Displacement(-1y,-3y)
        Displacement(0y,-17y)
        PenUp
        Displacement(-3y,14y)
        PenDown
        Vector 0x70uy
        PenUp
        Displacement(5y,-14y)
        // VerticalText(Displacement(-8y,-10y))
        EndOfShape
    ]
    // g
    103us, [
        PenUp
        // VerticalText(Displacement(-6y,-14y))
        Displacement(12y,14y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-1y,-3y)
        Vector 0x1Auy
        Vector 0x29uy
        Vector 0x38uy
        Vector 0x27uy
        PenUp
        Displacement(9y,17y)
        PenDown
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x29uy
        Vector 0x2Auy
        Displacement(-1y,-3y)
        Vector 0x2Cuy
        Displacement(1y,-3y)
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x22uy
        PenUp
        Displacement(7y,-3y)
        // VerticalText(Displacement(-13y,-17y))
        EndOfShape
    ]
    // h
    104us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-11y,-42y))
        // VerticalText(Multiply 2uy)
        PenDown
        Displacement(0y,21y)
        PenUp
        Vector 0xBCuy
        PenDown
        Vector 0x32uy
        Vector 0x21uy
        Vector 0x30uy
        Vector 0x2Fuy
        Displacement(1y,-3y)
        Vector 0xACuy
        PenUp
        Vector 0x80uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-27y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // i
    105us, [
        PenUp
        // VerticalText(Displacement(-1y,-21y))
        Displacement(0y,20y)
        PenDown
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        Vector 0x1Auy
        PenUp
        Displacement(1y,-6y)
        PenDown
        Vector 0xECuy
        PenUp
        Vector 0x70uy
        // VerticalText(Displacement(-7y,-10y))
        EndOfShape
    ]
    // j
    106us, [
        PenUp
        // VerticalText(Displacement(-3y,-21y))
        Displacement(4y,20y)
        PenDown
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        Vector 0x1Auy
        PenUp
        Displacement(1y,-6y)
        PenDown
        Displacement(0y,-17y)
        Displacement(-1y,-3y)
        Vector 0x29uy
        Vector 0x28uy
        PenUp
        Displacement(10y,7y)
        // VerticalText(Displacement(-7y,-17y))
        EndOfShape
    ]
    // k
    107us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-11y,-42y))
        // VerticalText(Multiply 2uy)
        PenDown
        Displacement(0y,21y)
        PenUp
        Displacement(10y,-7y)
        PenDown
        Vector 0xAAuy
        PenUp
        Vector 0x42uy
        PenDown
        Displacement(7y,-8y)
        PenUp
        Vector 0x60uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-23y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // l
    108us, [
        PenUp
        // VerticalText(Displacement(0y,-21y))
        PenDown
        Displacement(0y,21y)
        PenUp
        Displacement(8y,-21y)
        // VerticalText(Displacement(-8y,-10y))
        EndOfShape
    ]
    // m
    109us, [
        PenUp
        // VerticalText(Displacement(-11y,-14y))
        PenDown
        Vector 0xE4uy
        PenUp
        Vector 0x4Cuy
        PenDown
        Vector 0x32uy
        Vector 0x21uy
        Vector 0x30uy
        Vector 0x2Fuy
        Displacement(1y,-3y)
        Vector 0xACuy
        PenUp
        Vector 0xA4uy
        PenDown
        Vector 0x32uy
        Vector 0x21uy
        Vector 0x30uy
        Vector 0x2Fuy
        Displacement(1y,-3y)
        Vector 0xACuy
        PenUp
        Vector 0x80uy
        // VerticalText(Displacement(-19y,-10y))
        EndOfShape
    ]
    // n
    110us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-11y,-28y))
        // VerticalText(Multiply 2uy)
        PenDown
        Vector 0xE4uy
        PenUp
        Vector 0x4Cuy
        PenDown
        Vector 0x32uy
        Vector 0x21uy
        Vector 0x30uy
        Vector 0x2Fuy
        Displacement(1y,-3y)
        Vector 0xACuy
        PenUp
        Vector 0x80uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-27y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // o
    111us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-13y,-28y))
        // VerticalText(Multiply 2uy)
        Displacement(5y,14y)
        PenDown
        Vector 0x29uy
        Vector 0x2Auy
        Displacement(-1y,-3y)
        Vector 0x2Cuy
        Displacement(1y,-3y)
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x22uy
        Displacement(1y,3y)
        Vector 0x24uy
        Displacement(-1y,3y)
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x38uy
        PenUp
        Vector 0xEEuy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-25y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // p
    112us, [
        PenUp
        // VerticalText(Displacement(-6y,-14y))
        Vector 0xE4uy
        PenDown
        Displacement(0y,-21y)
        PenUp
        Displacement(0y,18y)
        PenDown
        Vector 0x22uy
        Vector 0x21uy
        Vector 0x30uy
        Vector 0x2Fuy
        Vector 0x2Euy
        Displacement(1y,-3y)
        Vector 0x2Cuy
        Displacement(-1y,-3y)
        Vector 0x2Auy
        Vector 0x29uy
        Vector 0x38uy
        Vector 0x27uy
        Vector 0x26uy
        PenUp
        Displacement(19y,-3y)
        // VerticalText(Displacement(-13y,-17y))
        EndOfShape
    ]
    // q
    113us, [
        PenUp
        // VerticalText(Displacement(-6y,-14y))
        Displacement(12y,14y)
        PenDown
        Displacement(0y,-21y)
        PenUp
        Displacement(0y,18y)
        PenDown
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x29uy
        Vector 0x2Auy
        Displacement(-1y,-3y)
        Vector 0x2Cuy
        Displacement(1y,-3y)
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x22uy
        PenUp
        Displacement(7y,-3y)
        // VerticalText(Displacement(-13y,-17y))
        EndOfShape
    ]
    // r
    114us, [
        PenUp
        // VerticalText(Displacement(-4y,-14y))
        PenDown
        Vector 0xE4uy
        PenUp
        Vector 0x6Cuy
        PenDown
        Displacement(1y,3y)
        Vector 0x22uy
        Vector 0x21uy
        Vector 0x30uy
        PenUp
        Displacement(5y,-14y)
        // VerticalText(Displacement(-9y,-10y))
        EndOfShape
    ]
    // s
    115us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-11y,-28y))
        // VerticalText(Multiply 2uy)
        Vector 0xB2uy
        PenDown
        Vector 0x25uy
        Displacement(-3y,1y)
        Vector 0x38uy
        Displacement(-3y,-1y)
        Vector 0x2Buy
        Vector 0x2Duy
        Vector 0x2Fuy
        Displacement(5y,-1y)
        Vector 0x2Fuy
        Vector 0x2Duy
        Vector 0x1Cuy
        Vector 0x2Buy
        Displacement(-3y,-1y)
        Vector 0x38uy
        Displacement(-3y,1y)
        Vector 0x25uy
        PenUp
        Displacement(17y,-3y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-23y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // t
    116us, [
        PenUp
        // VerticalText(Displacement(-4y,-21y))
        Displacement(3y,21y)
        PenDown
        Displacement(0y,-17y)
        Displacement(1y,-3y)
        Vector 0x2Fuy
        Vector 0x20uy
        PenUp
        Displacement(-8y,14y)
        PenDown
        Vector 0x70uy
        PenUp
        Vector 0xEDuy
        // VerticalText(Vector 0xAAuy)
        EndOfShape
    ]
    // u
    117us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-11y,-28y))
        // VerticalText(Multiply 2uy)
        Vector 0xE4uy
        PenDown
        Vector 0xACuy
        Displacement(1y,-3y)
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x32uy
        PenUp
        Vector 0xA4uy
        PenDown
        Vector 0xECuy
        PenUp
        Vector 0x80uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-27y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // v
    118us, [
        PenUp
        // VerticalText(Displacement(-6y,-14y))
        Vector 0xE4uy
        PenDown
        Displacement(6y,-14y)
        Displacement(6y,14y)
        PenUp
        Displacement(4y,-14y)
        // VerticalText(Vector 0xAAuy)
        EndOfShape
    ]
    // w
    119us, [
        PenUp
        // VerticalText(Displacement(-8y,-14y))
        Vector 0xE4uy
        PenDown
        ManyDisplacements [4y,-14y;4y,14y;4y,-14y;4y,14y]
        PenUp
        Displacement(6y,-14y)
        // VerticalText(Displacement(-14y,-10y))
        EndOfShape
    ]
    // x
    120us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-11y,-28y))
        // VerticalText(Multiply 2uy)
        PenDown
        Displacement(11y,14y)
        PenUp
        Vector 0xECuy
        PenDown
        Displacement(-11y,14y)
        PenUp
        Displacement(17y,-14y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-23y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // y
    121us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-13y,-28y))
        // VerticalText(Multiply 2uy)
        Displacement(1y,14y)
        PenDown
        Displacement(6y,-14y)
        PenUp
        Displacement(6y,14y)
        PenDown
        Displacement(-6y,-14y)
        Vector 0x6Buy
        Vector 0x1Auy
        Vector 0x38uy
        PenUp
        Displacement(16y,7y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-19y,-35y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // z
    122us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-11y,-28y))
        // VerticalText(Multiply 2uy)
        Vector 0xE4uy
        PenDown
        Vector 0xB0uy
        Displacement(-11y,-14y)
        Vector 0xB0uy
        PenUp
        Vector 0x60uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-23y,-21y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // {
    123us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-5y,-50y))
        // VerticalText(Multiply 2uy)
        Displacement(5y,25y)
        PenDown
        Vector 0x29uy
        Vector 0x1Auy
        Vector 0x2Buy
        Vector 0x2Cuy
        Vector 0x2Duy
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x2Cuy
        Vector 0x2Auy
        Vector 0x29uy
        Vector 0x2Fuy
        Vector 0x2Euy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Vector 0x2Buy
        Vector 0x2Cuy
        Vector 0x2Duy
        Vector 0x1Euy
        Vector 0x2Fuy
        PenUp
        Vector 0x72uy
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-19y,-35y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // |
    124us, [
        PenUp
        // VerticalText(Displacement(0y,-25y))
        Displacement(0y,25y)
        PenDown
        Displacement(0y,-32y)
        PenUp
        Vector 0x72uy
        // VerticalText(Displacement(-7y,-17y))
        EndOfShape
    ]
    // }
    125us, [
        PenUp
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-5y,-50y))
        // VerticalText(Multiply 2uy)
        Displacement(0y,25y)
        PenDown
        Vector 0x2Fuy
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Vector 0x2Buy
        Vector 0x2Cuy
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x29uy
        Vector 0x2Auy
        Vector 0x2Cuy
        Vector 0x2Duy
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Vector 0x29uy
        PenUp
        Displacement(11y,7y)
        // VerticalText(Divide 2uy)
        // VerticalText(Displacement(-17y,-35y))
        // VerticalText(Multiply 2uy)
        EndOfShape
    ]
    // ~
    126us, [
        PenUp
        // VerticalText(Displacement(-9y,-12y))
        Vector 0x64uy
        PenDown
        Vector 0x24uy
        Displacement(1y,3y)
        Vector 0x21uy
        Vector 0x20uy
        Vector 0x2Fuy
        Displacement(4y,-3y)
        Vector 0x2Fuy
        Vector 0x20uy
        Vector 0x21uy
        Vector 0x23uy
        Vector 0x24uy
        PenUp
        Displacement(8y,-12y)
        // VerticalText(Displacement(-17y,-4y))
        EndOfShape
    ]
    ]
