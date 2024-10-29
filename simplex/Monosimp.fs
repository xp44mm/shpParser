module SimplexTestProject.Monosimp
open shpParser
let shapes = [
    10us, [
        PenUp
        Displacement(0y,-42y)
        EndOfShape
    ]
    //  
    32us, [
        PenUp
        Displacement(21y,0y)
        EndOfShape
    ]
    // !
    33us, [
        PenUp
        Displacement(1y,21y)
        PenDown
        Vector 0x2Buy
        ManyDisplacements [1y,-12y;1y,12y]
        Vector 0x25uy
        PenUp
        Vector 0x2Cuy
        PenDown
        Vector 0x6Cuy
        PenUp
        Vector 0xBCuy
        PenDown
        Vector 0x1Auy
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        PenUp
        Displacement(20y,-2y)
        EndOfShape
    ]
    // "
    34us, [
        PenUp
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
        Displacement(15y,-19y)
        EndOfShape
    ]
    // #
    35us, [
        PenUp
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
        Vector 0xE0uy
        PenUp
        Displacement(-15y,-6y)
        PenDown
        Vector 0xE0uy
        PenUp
        Displacement(7y,-4y)
        EndOfShape
    ]
    // $
    36us, [
        PenUp
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
        Displacement(21y,-3y)
        EndOfShape
    ]
    // %
    37us, [
        PenDown
        Displacement(14y,21y)
        PenUp
        Vector 0x98uy
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
        PenUp
        Displacement(5y,-14y)
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
        Displacement(11y,-7y)
        EndOfShape
    ]
    // &
    38us, [
        PenUp
        Displacement(14y,11y)
        PenDown
        Displacement(-2y,-5y)
        Displacement(-2y,-3y)
        Vector 0x2Auy
        Vector 0x29uy
        Vector 0x38uy
        Vector 0x27uy
        Vector 0x25uy
        Vector 0x34uy
        Vector 0x23uy
        Displacement(3y,2y)
        Vector 0x42uy
        Vector 0x23uy
        Vector 0x24uy
        Vector 0x25uy
        Vector 0x27uy
        Vector 0x29uy
        Vector 0x2Buy
        Vector 0x2Cuy
        ManyDisplacements [1y,-3y;7y,-10y]
        Vector 0x3Euy
        PenUp
        Displacement(7y,0y)
        EndOfShape
    ]
    // '
    39us, [
        PenUp
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
        Displacement(21y,-19y)
        EndOfShape
    ]
    // (
    40us, [
        PenUp
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
        Displacement(14y,7y)
        EndOfShape
    ]
    // )
    41us, [
        PenUp
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
        Displacement(21y,7y)
        EndOfShape
    ]
    // *
    42us, [
        PenUp
        Displacement(5y,15y)
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
        Displacement(21y,-6y)
        EndOfShape
    ]
    // +
    43us, [
        PenUp
        Displacement(8y,17y)
        PenDown
        Displacement(0y,-16y)
        PenUp
        Vector 0x86uy
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(5y,-9y)
        EndOfShape
    ]
    // ,
    44us, [
        PenUp
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
        Displacement(21y,4y)
        EndOfShape
    ]
    // -
    45us, [
        PenUp
        Vector 0x94uy
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(5y,-9y)
        EndOfShape
    ]
    // .
    46us, [
        PenUp
        Vector 0x10uy
        PenDown
        Vector 0x16uy
        Vector 0x12uy
        Vector 0x1Euy
        Vector 0x1Auy
        PenUp
        Displacement(20y,0y)
        EndOfShape
    ]
    // /
    47us, [
        PenUp
        Displacement(18y,25y)
        PenDown
        Displacement(-18y,-32y)
        PenUp
        Displacement(21y,7y)
        EndOfShape
    ]
    // 0
    48us, [
        PenUp
        Displacement(6y,21y)
        PenDown
        ManyDisplacements [-3y,-1y;-2y,-3y;-1y,-5y;0y,-3y;1y,-5y;2y,-3y;3y,-1y;2y,0y;3y,1y;2y,3y;1y,5y;0y,3y;-1y,5y;-2y,3y;-3y,1y;-2y,0y]
        PenUp
        Displacement(15y,-21y)
        EndOfShape
    ]
    // 1
    49us, [
        PenUp
        Displacement(3y,17y)
        PenDown
        Vector 0x21uy
        Vector 0x32uy
        Displacement(0y,-21y)
        PenUp
        Vector 0x38uy
        PenDown
        Vector 0x60uy
        PenUp
        Vector 0xA0uy
        EndOfShape
    ]
    // 2
    50us, [
        PenUp
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
        Vector 0x2Auy
        Displacement(-7y,-5y)
        Vector 0x2Auy
        Vector 0x2Buy
        Vector 0x2Cuy
        Vector 0xE0uy
        PenUp
        Vector 0x70uy
        EndOfShape
    ]
    // 3
    51us, [
        PenUp
        Displacement(2y,19y)
        PenDown
        Vector 0x12uy
        Vector 0x21uy
        Vector 0x40uy
        Vector 0x2Fuy
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x2Auy
        Vector 0x38uy
        PenUp
        Vector 0x30uy
        PenDown
        Vector 0x2Fuy
        Vector 0x1Euy
        Vector 0x2Duy
        Vector 0x2Cuy
        Displacement(-1y,-3y)
        Vector 0x1Auy
        Displacement(-3y,-1y)
        Vector 0x48uy
        Displacement(-3y,1y)
        Vector 0x16uy
        Vector 0x25uy
        PenUp
        Displacement(21y,-4y)
        EndOfShape
    ]
    // 4
    52us, [
        PenUp
        Displacement(10y,21y)
        PenDown
        Displacement(-10y,-14y)
        Vector 0xE0uy
        PenUp
        Displacement(-4y,14y)
        PenDown
        Displacement(0y,-21y)
        PenUp
        Vector 0xB0uy
        EndOfShape
    ]
    // 5
    53us, [
        PenUp
        Displacement(12y,21y)
        PenDown
        ManyDisplacements [-10y,0y;-1y,-9y;1y,1y;3y,1y;3y,0y;3y,-1y;2y,-2y;1y,-3y;0y,-2y;-1y,-3y;-2y,-2y;-3y,-1y;-3y,0y;-3y,1y;-1y,1y;-1y,2y]
        PenUp
        Displacement(21y,-4y)
        EndOfShape
    ]
    // 6
    54us, [
        PenUp
        Displacement(12y,18y)
        PenDown
        ManyDisplacements [-1y,2y;-3y,1y;-2y,0y;-3y,-1y;-2y,-3y;-1y,-5y;0y,-5y;1y,-4y;2y,-2y;3y,-1y;2y,0y;3y,1y;2y,2y;1y,3y;0y,1y;-1y,3y;-2y,2y;-3y,1y;-2y,0y;-3y,-1y;-2y,-2y;-1y,-3y]
        PenUp
        Displacement(21y,-7y)
        EndOfShape
    ]
    // 7
    55us, [
        PenUp
        Displacement(0y,21y)
        PenDown
        ManyDisplacements [14y,0y;-10y,-21y]
        PenUp
        Displacement(17y,0y)
        EndOfShape
    ]
    // 8
    56us, [
        PenUp
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
        Displacement(16y,-21y)
        EndOfShape
    ]
    // 9
    57us, [
        PenUp
        Displacement(14y,14y)
        PenDown
        ManyDisplacements [-1y,-3y;-2y,-2y;-3y,-1y;-2y,0y;-3y,1y;-2y,2y;-1y,3y;0y,1y;1y,3y;2y,2y;3y,1y;2y,0y;3y,-1y;2y,-2y;1y,-4y;0y,-5y;-1y,-5y;-2y,-3y;-3y,-1y;-2y,0y;-3y,1y;-1y,2y]
        PenUp
        Displacement(19y,-3y)
        EndOfShape
    ]
    // :
    58us, [
        PenUp
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
        Displacement(20y,-2y)
        EndOfShape
    ]
    // ;
    59us, [
        PenUp
        Displacement(2y,13y)
        PenDown
        Vector 0x1Auy
        Vector 0x16uy
        Vector 0x12uy
        Vector 0x1Euy
        PenUp
        Vector 0xDCuy
        PenDown
        Vector 0x1Auy
        Vector 0x16uy
        Vector 0x12uy
        Vector 0x1Euy
        Vector 0x2Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        PenUp
        Displacement(21y,5y)
        EndOfShape
    ]
    // <
    60us, [
        PenUp
        Displacement(16y,18y)
        PenDown
        Displacement(-16y,-9y)
        Displacement(16y,-9y)
        PenUp
        Vector 0x50uy
        EndOfShape
    ]
    // =
    61us, [
        PenUp
        Vector 0xC4uy
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(-16y,-6y)
        PenDown
        Displacement(16y,0y)
        PenUp
        Displacement(5y,-6y)
        EndOfShape
    ]
    // >
    62us, [
        PenUp
        Displacement(0y,18y)
        PenDown
        Displacement(16y,-9y)
        Displacement(-16y,-9y)
        PenUp
        Displacement(21y,0y)
        EndOfShape
    ]
    // ?
    63us, [
        PenUp
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
        Displacement(16y,-2y)
        EndOfShape
    ]
    // @
    64us, [
        PenUp
        Displacement(14y,2y)
        PenDown
        Vector 0x49uy
        Vector 0x38uy
        Displacement(-3y,1y)
        Vector 0x26uy
        Vector 0x25uy
        Displacement(-1y,3y)
        Vector 0x54uy
        Displacement(1y,3y)
        Vector 0x23uy
        Vector 0x22uy
        Displacement(3y,1y)
        Vector 0x20uy
        Displacement(3y,-1y)
        Vector 0x2Euy
        Vector 0x2Duy
        Displacement(1y,-3y)
        Vector 0x4Cuy
        Vector 0x2Buy
        Vector 0x1Auy
        Vector 0x18uy
        Vector 0x16uy
        Displacement(1y,7y)
        PenUp
        Displacement(0y,-1y)
        PenDown
        Vector 0x16uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x2Auy
        Vector 0x2Buy
        Vector 0x2Cuy
        Vector 0x2Duy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        PenUp
        Displacement(9y,-7y)
        EndOfShape
    ]
    // A
    65us, [
        PenDown
        Displacement(7y,21y)
        Displacement(7y,-21y)
        PenUp
        Displacement(-11y,9y)
        PenDown
        Vector 0x80uy
        PenUp
        Displacement(10y,-9y)
        EndOfShape
    ]
    // B
    66us, [
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
        EndOfShape
    ]
    // C
    67us, [
        PenUp
        Displacement(14y,16y)
        PenDown
        Vector 0x25uy
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x29uy
        Vector 0x2Auy
        Vector 0x2Buy
        Displacement(-1y,-3y)
        Vector 0x5Cuy
        Displacement(1y,-3y)
        Vector 0x2Duy
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x22uy
        Vector 0x23uy
        PenUp
        Displacement(7y,-5y)
        EndOfShape
    ]
    // D
    68us, [
        PenDown
        ManyDisplacements [0y,21y;7y,0y;3y,-1y;2y,-2y;1y,-2y;1y,-3y;0y,-5y;-1y,-3y;-1y,-2y;-2y,-2y;-3y,-1y;-7y,0y]
        PenUp
        Displacement(21y,0y)
        EndOfShape
    ]
    // E
    69us, [
        PenDown
        Displacement(0y,21y)
        Vector 0xE0uy
        PenUp
        Displacement(-14y,-10y)
        PenDown
        Vector 0x90uy
        PenUp
        Displacement(-9y,-11y)
        PenDown
        Vector 0xE0uy
        PenUp
        Vector 0x70uy
        EndOfShape
    ]
    // F
    70us, [
        PenDown
        Displacement(0y,21y)
        Vector 0xE0uy
        PenUp
        Displacement(-14y,-10y)
        PenDown
        Vector 0x90uy
        PenUp
        Displacement(12y,-11y)
        EndOfShape
    ]
    // G
    71us, [
        PenUp
        Displacement(14y,16y)
        PenDown
        Vector 0x25uy
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x38uy
        Vector 0x29uy
        Vector 0x2Auy
        Vector 0x2Buy
        Displacement(-1y,-3y)
        Vector 0x5Cuy
        Displacement(1y,-3y)
        Vector 0x2Duy
        Vector 0x2Euy
        Vector 0x2Fuy
        Vector 0x30uy
        Vector 0x21uy
        Vector 0x22uy
        Vector 0x23uy
        Vector 0x34uy
        Vector 0x58uy
        PenUp
        Displacement(12y,-8y)
        EndOfShape
    ]
    // H
    72us, [
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
        Displacement(7y,-11y)
        EndOfShape
    ]
    // I
    73us, [
        PenUp
        Vector 0x40uy
        PenDown
        Vector 0x60uy
        PenUp
        Displacement(-6y,21y)
        PenDown
        Vector 0x60uy
        PenUp
        Displacement(-3y,0y)
        PenDown
        Displacement(0y,-21y)
        PenUp
        Vector 0xE0uy
        EndOfShape
    ]
    // J
    74us, [
        PenUp
        Displacement(9y,21y)
        PenDown
        Vector 0x60uy
        PenUp
        Displacement(-3y,0y)
        PenDown
        Displacement(0y,-16y)
        Displacement(-1y,-3y)
        Vector 0x1Auy
        Displacement(-3y,-1y)
        Vector 0x28uy
        Displacement(-3y,1y)
        Vector 0x16uy
        Displacement(-1y,3y)
        Vector 0x24uy
        PenUp
        Displacement(21y,-7y)
        EndOfShape
    ]
    // K
    75us, [
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
        EndOfShape
    ]
    // L
    76us, [
        PenUp
        Displacement(0y,21y)
        PenDown
        Displacement(0y,-21y)
        Vector 0xE0uy
        PenUp
        Vector 0x70uy
        EndOfShape
    ]
    // M
    77us, [
        PenDown
        ManyDisplacements [0y,21y;7y,-21y;7y,21y;0y,-21y]
        PenUp
        Vector 0x70uy
        EndOfShape
    ]
    // N
    78us, [
        PenDown
        ManyDisplacements [0y,21y;14y,-21y;0y,21y]
        PenUp
        Displacement(7y,-21y)
        EndOfShape
    ]
    // O
    79us, [
        PenUp
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
        Vector 0x20uy
        Vector 0x21uy
        Vector 0x22uy
        Vector 0x23uy
        Displacement(1y,3y)
        Vector 0x54uy
        Displacement(-1y,3y)
        Vector 0x25uy
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x28uy
        PenUp
        Displacement(15y,-21y)
        EndOfShape
    ]
    // P
    80us, [
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
        EndOfShape
    ]
    // Q
    81us, [
        PenUp
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
        Vector 0x20uy
        Vector 0x21uy
        Vector 0x22uy
        Vector 0x23uy
        Displacement(1y,3y)
        Vector 0x54uy
        Displacement(-1y,3y)
        Vector 0x25uy
        Vector 0x26uy
        Vector 0x27uy
        Vector 0x28uy
        PenUp
        Displacement(1y,-17y)
        PenDown
        Vector 0x6Euy
        PenUp
        Displacement(8y,2y)
        EndOfShape
    ]
    // R
    82us, [
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
        EndOfShape
    ]
    // S
    83us, [
        PenUp
        Displacement(14y,18y)
        PenDown
        ManyDisplacements [-2y,2y;-3y,1y;-4y,0y;-3y,-1y;-2y,-2y;0y,-2y;1y,-2y;1y,-1y;2y,-1y;6y,-2y;2y,-1y;1y,-1y;1y,-2y;0y,-3y;-2y,-2y;-3y,-1y;-4y,0y;-3y,1y;-2y,2y]
        PenUp
        Displacement(21y,-3y)
        EndOfShape
    ]
    // T
    84us, [
        PenUp
        Displacement(0y,21y)
        PenDown
        Vector 0xE0uy
        PenUp
        Displacement(-7y,0y)
        PenDown
        Displacement(0y,-21y)
        PenUp
        Displacement(14y,0y)
        EndOfShape
    ]
    // U
    85us, [
        PenUp
        Displacement(0y,21y)
        PenDown
        ManyDisplacements [0y,-15y;1y,-3y;2y,-2y;3y,-1y;2y,0y;3y,1y;2y,2y;1y,3y;0y,15y]
        PenUp
        Displacement(7y,-21y)
        EndOfShape
    ]
    // V
    86us, [
        PenUp
        Displacement(0y,21y)
        PenDown
        Displacement(7y,-21y)
        Displacement(7y,21y)
        PenUp
        Displacement(7y,-21y)
        EndOfShape
    ]
    // W
    87us, [
        PenUp
        Displacement(0y,21y)
        PenDown
        ManyDisplacements [4y,-21y;4y,21y;4y,-21y;4y,21y]
        PenUp
        Displacement(5y,-21y)
        EndOfShape
    ]
    // X
    88us, [
        PenDown
        Displacement(14y,21y)
        PenUp
        Vector 0xE8uy
        PenDown
        Displacement(14y,-21y)
        PenUp
        Vector 0x70uy
        EndOfShape
    ]
    // Y
    89us, [
        PenUp
        Displacement(0y,21y)
        PenDown
        Displacement(7y,-10y)
        Displacement(7y,10y)
        PenUp
        Displacement(-7y,-10y)
        PenDown
        Vector 0xBCuy
        PenUp
        Vector 0xE0uy
        EndOfShape
    ]
    // Z
    90us, [
        PenUp
        Displacement(0y,21y)
        PenDown
        Vector 0xE0uy
        Displacement(-14y,-21y)
        Vector 0xE0uy
        PenUp
        Vector 0x70uy
        EndOfShape
    ]
    // [
    91us, [
        PenUp
        Displacement(7y,25y)
        PenDown
        Vector 0x78uy
        Displacement(0y,-32y)
        Vector 0x70uy
        PenUp
        Displacement(14y,7y)
        EndOfShape
    ]
    // \
    92us, [
        PenUp
        Displacement(0y,25y)
        PenDown
        Displacement(16y,-32y)
        PenUp
        Displacement(5y,7y)
        EndOfShape
    ]
    // ]
    93us, [
        PenUp
        Displacement(0y,25y)
        PenDown
        Vector 0x70uy
        Displacement(0y,-32y)
        Vector 0x78uy
        PenUp
        Displacement(21y,7y)
        EndOfShape
    ]
    // ^
    94us, [
        PenUp
        Displacement(0y,18y)
        PenDown
        Vector 0x72uy
        Vector 0x7Euy
        PenUp
        Displacement(7y,-18y)
        EndOfShape
    ]
    // _
    95us, [
        PenUp
        Vector 0x2Cuy
        PenDown
        Displacement(21y,0y)
        PenUp
        Vector 0x24uy
        EndOfShape
    ]
    // `
    96us, [
        PenUp
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
        Displacement(19y,-19y)
        EndOfShape
    ]
    // a
    97us, [
        PenUp
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
        Displacement(9y,-3y)
        EndOfShape
    ]
    // b
    98us, [
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
        Displacement(21y,-3y)
        EndOfShape
    ]
    // c
    99us, [
        PenUp
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
        Displacement(9y,-3y)
        EndOfShape
    ]
    // d
    100us, [
        PenUp
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
        Displacement(9y,-3y)
        EndOfShape
    ]
    // e
    101us, [
        PenUp
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
        Displacement(9y,-3y)
        EndOfShape
    ]
    // f
    102us, [
        PenUp
        Displacement(12y,20y)
        PenDown
        Vector 0x27uy
        Vector 0x28uy
        Vector 0x29uy
        Displacement(-1y,-3y)
        Displacement(0y,-17y)
        PenUp
        Displacement(-4y,13y)
        PenDown
        Vector 0x90uy
        PenUp
        Displacement(11y,-13y)
        EndOfShape
    ]
    // g
    103us, [
        PenUp
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
        Displacement(9y,-3y)
        EndOfShape
    ]
    // h
    104us, [
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
        Vector 0xA0uy
        EndOfShape
    ]
    // i
    105us, [
        PenUp
        Displacement(5y,20y)
        PenDown
        Vector 0x1Euy
        Vector 0x12uy
        Vector 0x16uy
        Vector 0x1Auy
        PenUp
        Displacement(-1y,-6y)
        PenDown
        Vector 0x20uy
        Vector 0xECuy
        PenUp
        Vector 0x38uy
        PenDown
        Vector 0x60uy
        PenUp
        Vector 0xC0uy
        EndOfShape
    ]
    // j
    106us, [
        PenUp
        Displacement(6y,20y)
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
        Vector 0x27uy
        PenUp
        Displacement(21y,6y)
        EndOfShape
    ]
    // k
    107us, [
        PenDown
        Displacement(0y,21y)
        PenUp
        Displacement(10y,-7y)
        PenDown
        Vector 0xAAuy
        PenUp
        Vector 0x42uy
        PenDown
        Vector 0x8Euy
        PenUp
        Vector 0x90uy
        EndOfShape
    ]
    // l
    108us, [
        PenUp
        Vector 0x30uy
        PenDown
        Vector 0x60uy
        PenUp
        Displacement(-3y,0y)
        PenDown
        Displacement(0y,21y)
        Vector 0x38uy
        PenUp
        Displacement(18y,-21y)
        EndOfShape
    ]
    // m
    109us, [
        PenDown
        Vector 0xE4uy
        PenUp
        Vector 0x3Cuy
        PenDown
        Vector 0x23uy
        Vector 0x21uy
        Vector 0x20uy
        Vector 0x2Fuy
        Vector 0x2Duy
        Vector 0xBCuy
        PenUp
        Vector 0xB4uy
        PenDown
        Vector 0x23uy
        Vector 0x21uy
        Vector 0x20uy
        Vector 0x2Fuy
        Vector 0x2Duy
        Vector 0xBCuy
        PenUp
        Vector 0x50uy
        EndOfShape
    ]
    // n
    110us, [
        PenDown
        Vector 0xE4uy
        PenUp
        Vector 0x4Cuy
        PenDown
        Vector 0x32uy
        Vector 0x21uy
        Vector 0x30uy
        Vector 0x2Fuy
        Displacement(2y,-3y)
        Vector 0xACuy
        PenUp
        Vector 0x90uy
        EndOfShape
    ]
    // o
    111us, [
        PenUp
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
        Displacement(16y,-14y)
        EndOfShape
    ]
    // p
    112us, [
        PenUp
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
        Displacement(21y,-3y)
        EndOfShape
    ]
    // q
    113us, [
        PenUp
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
        Displacement(9y,-3y)
        EndOfShape
    ]
    // r
    114us, [
        PenDown
        Vector 0xE4uy
        PenUp
        Vector 0x6Cuy
        PenDown
        Displacement(1y,3y)
        Vector 0x22uy
        Vector 0x21uy
        Vector 0x30uy
        Vector 0x2Fuy
        PenUp
        Displacement(11y,-13y)
        EndOfShape
    ]
    // s
    115us, [
        PenUp
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
        Displacement(21y,-3y)
        EndOfShape
    ]
    // t
    116us, [
        PenUp
        Displacement(5y,21y)
        PenDown
        Displacement(0y,-17y)
        Displacement(1y,-3y)
        Vector 0x2Fuy
        Vector 0x20uy
        Vector 0x21uy
        PenUp
        Displacement(-10y,14y)
        PenDown
        Vector 0x70uy
        PenUp
        Displacement(12y,-15y)
        EndOfShape
    ]
    // u
    117us, [
        PenUp
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
        Vector 0xA0uy
        EndOfShape
    ]
    // v
    118us, [
        PenUp
        Vector 0xE4uy
        PenDown
        Displacement(6y,-14y)
        Displacement(6y,14y)
        PenUp
        Displacement(9y,-14y)
        EndOfShape
    ]
    // w
    119us, [
        PenUp
        Vector 0xE4uy
        PenDown
        ManyDisplacements [4y,-14y;4y,14y;4y,-14y;4y,14y]
        PenUp
        Displacement(5y,-14y)
        EndOfShape
    ]
    // x
    120us, [
        PenDown
        Displacement(11y,14y)
        PenUp
        Vector 0xECuy
        PenDown
        Displacement(-11y,14y)
        PenUp
        Displacement(21y,-14y)
        EndOfShape
    ]
    // y
    121us, [
        PenUp
        Displacement(1y,14y)
        PenDown
        Displacement(6y,-14y)
        PenUp
        Displacement(6y,14y)
        PenDown
        Displacement(-6y,-14y)
        Vector 0x4Buy
        Vector 0x2Auy
        Vector 0x29uy
        Vector 0x18uy
        PenUp
        Displacement(21y,7y)
        EndOfShape
    ]
    // z
    122us, [
        PenUp
        Vector 0xE4uy
        PenDown
        Vector 0xB0uy
        Displacement(-11y,-14y)
        Vector 0xB0uy
        PenUp
        Vector 0xA0uy
        EndOfShape
    ]
    // {
    123us, [
        PenUp
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
        Displacement(16y,7y)
        EndOfShape
    ]
    // |
    124us, [
        PenUp
        Displacement(6y,25y)
        PenDown
        Displacement(0y,-32y)
        PenUp
        Displacement(15y,7y)
        EndOfShape
    ]
    // }
    125us, [
        PenUp
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
        Displacement(21y,7y)
        EndOfShape
    ]
    // ~
    126us, [
        PenUp
        Vector 0x84uy
        PenDown
        Vector 0x23uy
        Vector 0x21uy
        Vector 0x20uy
        Vector 0x6Fuy
        Vector 0x20uy
        Vector 0x21uy
        Vector 0x23uy
        PenUp
        Displacement(5y,-11y)
        EndOfShape
    ]
    ]