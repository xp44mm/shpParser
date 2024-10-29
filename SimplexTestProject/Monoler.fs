module SimplexTestProject.Monoler
open shpParser
let shapes = [
    2us, [
        Divide 2uy
        FractionalArc(105uy,82uy,21us,-0x4y)
        FractionalArc(85uy,171uy,40us,-0x52y)
        FractionalArc(174uy,151uy,21us,-0x44y)
        Multiply 2uy
        EndOfShape
    ]
    10us, [
        PenUp
        Displacement(0y,-75y)
        VerticalText(Displacement(50y,75y))
        EndOfShape
    ]
    //  
    32us, [
        PenUp
        Displacement(46y,0y)
        VerticalText(Displacement(-46y,-50y))
        EndOfShape
    ]
    // !
    33us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,3y)
        PenDown
        Vector 0x74uy
        PenUp
        Vector 0x74uy
        PenDown
        Displacement(0y,30y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // "
    34us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(17y,41y)
        PenDown
        Displacement(0y,16y)
        PenUp
        Vector 0xC0uy
        PenDown
        Displacement(0y,-16y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // #
    35us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(6y,14y)
        PenDown
        Displacement(34y,0y)
        PenUp
        Displacement(0y,12y)
        PenDown
        Displacement(-34y,0y)
        PenUp
        Displacement(0y,-36y)
        PenDown
        Displacement(22y,60y)
        PenUp
        Vector 0xC0uy
        PenDown
        Displacement(-22y,-60y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // $
    36us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,13y)
        PenDown
        FractionalArc(140uy,194uy,17us,0x43y)
        FractionalArc(235uy,140uy,12us,0x63y)
        FractionalArc(185uy,218uy,11us,0x2y)
        FractionalArc(155uy,215uy,50us,0x11y)
        FractionalArc(41uy,113uy,10us,-0x64y)
        FractionalArc(130uy,80uy,17us,-0x33y)
        PenUp
        Displacement(-9y,14y)
        PenDown
        Displacement(0y,-56y)
        PenUp
        Vector 0xA8uy
        PenDown
        Displacement(0y,56y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // %
    37us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(6y,3y)
        PenDown
        Displacement(33y,44y)
        PenUp
        Displacement(-33y,-8y)
        PenDown
        OctantArc(8uy,0x40y)
        PenUp
        Displacement(17y,-28y)
        PenDown
        OctantArc(8uy,0x40y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // &
    38us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(42y,3y)
        PenDown
        FractionalArc(250uy,114uy,26us,0x73y)
        FractionalArc(176uy,42uy,46us,0x12y)
        Push
        FractionalArc(109uy,147uy,9us,-0x64y)
        FractionalArc(122uy,134uy,20us,-0x32y)
        FractionalArc(109uy,147uy,9us,-0x24y)
        Pop
        FractionalArc(158uy,98uy,13us,0x24y)
        FractionalArc(70uy,131uy,15us,0x53y)
        FractionalArc(117uy,217uy,60us,-0x41y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-29y,-25y))
        EndOfShape
    ]
    // '
    39us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(22y,41y)
        PenDown
        Displacement(0y,16y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // (
    40us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(27y,-5y)
        PenDown
        FractionalArc(70uy,186uy,51us,-0x52y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // )
    41us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(19y,-5y)
        PenDown
        FractionalArc(70uy,186uy,51us,0x72y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // *
    42us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,6y)
        PenDown
        Displacement(0y,38y)
        PenUp
        Displacement(-16y,-28y)
        PenDown
        Displacement(32y,19y)
        PenUp
        Displacement(0y,-19y)
        PenDown
        Displacement(-32y,19y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // +
    43us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(12y,25y)
        PenDown
        Displacement(22y,0y)
        PenUp
        Displacement(-11y,11y)
        PenDown
        Displacement(0y,-22y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // ,
    44us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(25y,5y)
        PenDown
        OctantArc(2uy,0x0y)
        FractionalArc(0uy,210uy,15us,-0x1y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // -
    45us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(12y,25y)
        PenDown
        Displacement(22y,0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // .
    46us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(24y,4y)
        PenDown
        OctantArc(1uy,0x0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // /
    47us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(6y,-5y)
        PenDown
        Displacement(34y,55y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 0
    48us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(37y,38y)
        PenDown
        FractionalArc(130uy,126uy,15us,0x4y)
        FractionalArc(99uy,157uy,28us,0x32y)
        FractionalArc(130uy,126uy,15us,0x44y)
        FractionalArc(99uy,157uy,28us,0x72y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 1
    49us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 2
    50us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(37y,3y)
        PenDown
        Displacement(-28y,0y)
        FractionalArc(0uy,163uy,25us,-0x42y)
        FractionalArc(63uy,155uy,10us,0x64y)
        FractionalArc(92uy,204uy,13us,0x13y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 3
    51us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,47y)
        PenDown
        Displacement(25y,0y)
        FractionalArc(78uy,160uy,25us,-0x2y)
        PenUp
        Displacement(6y,2y)
        PenDown
        FractionalArc(210uy,0uy,14us,-0x35y)
        FractionalArc(225uy,44uy,18us,-0x73y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 4
    52us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(32y,3y)
        PenDown
        ManyDisplacements [0y,44y;-4y,0y;-21y,-25y;0y,-4y;33y,0y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 5
    53us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(35y,47y)
        PenDown
        ManyDisplacements [-22y,0y;-2y,-19y]
        FractionalArc(230uy,114uy,15us,-0x40y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 6
    54us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(35y,42y)
        PenDown
        FractionalArc(235uy,75uy,15us,0x4y)
        FractionalArc(79uy,177uy,29us,0x32y)
        FractionalArc(188uy,50uy,16us,0x44y)
        FractionalArc(100uy,34uy,11us,0x73y)
        FractionalArc(24uy,110uy,17us,0x13y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 7
    55us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,47y)
        PenDown
        ManyDisplacements [30y,0y;0y,-4y]
        FractionalArc(212uy,24uy,46us,0x23y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 8
    56us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(15y,28y)
        PenDown
        FractionalArc(158uy,98uy,13us,0x24y)
        FractionalArc(105uy,151uy,19us,0x52y)
        FractionalArc(139uy,240uy,11us,0x64y)
        FractionalArc(245uy,171uy,30us,-0x72y)
        FractionalArc(249uy,7uy,9us,-0x64y)
        FractionalArc(27uy,229uy,17us,-0x32y)
        FractionalArc(250uy,192uy,10us,-0x24y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // 9
    57us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(10y,8y)
        PenDown
        FractionalArc(235uy,75uy,15us,0x44y)
        FractionalArc(79uy,177uy,29us,0x72y)
        FractionalArc(188uy,50uy,16us,0x4y)
        FractionalArc(100uy,34uy,11us,0x33y)
        FractionalArc(24uy,110uy,17us,0x53y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // :
    58us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(25y,5y)
        PenDown
        OctantArc(2uy,0x0y)
        PenUp
        Displacement(0y,24y)
        PenDown
        OctantArc(2uy,0x0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // ;
    59us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(25y,5y)
        PenDown
        OctantArc(2uy,0x0y)
        FractionalArc(0uy,210uy,15us,-0x1y)
        PenUp
        Displacement(3y,33y)
        PenDown
        OctantArc(2uy,0x0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // <
    60us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(34y,12y)
        PenDown
        ManyDisplacements [-22y,13y;22y,13y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // =
    61us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(16y,19y)
        PenDown
        Displacement(22y,0y)
        PenUp
        Displacement(0y,12y)
        PenDown
        Displacement(-22y,0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // >
    62us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(12y,12y)
        PenDown
        ManyDisplacements [22y,13y;-22y,13y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // ?
    63us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(12y,38y)
        PenDown
        OctantArc(1uy,0x40y)
        FractionalArc(83uy,85uy,12us,-0x44y)
        FractionalArc(112uy,58uy,12us,-0x13y)
        FractionalArc(156uy,12uy,13us,0x23y)
        PenUp
        Vector 0x8Cuy
        PenDown
        OctantArc(1uy,0x20y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // @
    64us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(37y,13y)
        PenDown
        FractionalArc(0uy,237uy,17us,-0x73y)
        FractionalArc(223uy,174uy,15us,-0x56y)
        FractionalArc(233uy,0uy,5us,-0x4y)
        Push
        PenUp
        Displacement(0y,-2y)
        PenDown
        FractionalArc(52uy,5uy,6us,-0x77y)
        Pop
        Displacement(1y,9y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // A
    65us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(6y,3y)
        PenDown
        ManyDisplacements [15y,44y;4y,0y;15y,-44y]
        PenUp
        Displacement(-4y,10y)
        PenDown
        Displacement(-26y,0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // B
    66us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,3y)
        PenDown
        Divide 2uy
        ManyDisplacements [0y,88y;34y,0y]
        OctantArc(21uy,-0x24y)
        Displacement(-34y,0y)
        PenUp
        Displacement(36y,0y)
        PenDown
        OctantArc(23uy,-0x24y)
        Displacement(-36y,0y)
        Multiply 2uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // C
    67us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(38y,12y)
        PenDown
        FractionalArc(134uy,0uy,15us,-0x2y)
        FractionalArc(235uy,138uy,14us,-0x73y)
        FractionalArc(147uy,109uy,38us,-0x52y)
        FractionalArc(111uy,0uy,15us,-0x42y)
        FractionalArc(0uy,78uy,16us,-0x22y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // D
    68us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,3y)
        PenDown
        Displacement(0y,44y)
        Vector 0xF0uy
        FractionalArc(240uy,85uy,12us,-0x33y)
        FractionalArc(96uy,160uy,34us,-0x12y)
        FractionalArc(170uy,16uy,12us,-0x3y)
        Vector 0xF8uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // E
    69us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(38y,3y)
        PenDown
        ManyDisplacements [-30y,0y;0y,44y;30y,0y]
        PenUp
        Displacement(-10y,-21y)
        PenDown
        Displacement(-20y,0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // F
    70us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,3y)
        PenDown
        ManyDisplacements [0y,44y;30y,0y]
        PenUp
        Displacement(-10y,-21y)
        PenDown
        Displacement(-20y,0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // G
    71us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(26y,23y)
        PenDown
        Vector 0xC0uy
        Vector 0xBCuy
        FractionalArc(134uy,0uy,15us,-0x2y)
        FractionalArc(235uy,138uy,14us,-0x73y)
        FractionalArc(147uy,109uy,38us,-0x52y)
        FractionalArc(111uy,0uy,15us,-0x42y)
        FractionalArc(0uy,78uy,16us,-0x22y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // H
    72us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Displacement(0y,-21y)
        PenDown
        Displacement(30y,0y)
        PenUp
        Displacement(0y,21y)
        PenDown
        Displacement(0y,-44y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // I
    73us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // J
    74us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(34y,47y)
        PenDown
        Displacement(0y,-33y)
        OctantArc(11uy,-0x4y)
        Vector 0x34uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // K
    75us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Displacement(0y,-24y)
        PenDown
        Displacement(30y,24y)
        PenUp
        Displacement(-20y,-16y)
        PenDown
        Displacement(20y,-28y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // L
    76us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(38y,3y)
        PenDown
        Displacement(-30y,0y)
        Displacement(0y,44y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // M
    77us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(4y,3y)
        PenDown
        ManyDisplacements [0y,44y;4y,0y;15y,-44y;15y,44y;4y,0y;0y,-44y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // N
    78us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,3y)
        PenDown
        ManyDisplacements [0y,44y;2y,0y;26y,-44y;2y,0y;0y,44y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // O
    79us, [
        Subshape 48uy
        EndOfShape
    ]
    // P
    80us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,3y)
        PenDown
        Displacement(0y,44y)
        Displacement(17y,0y)
        OctantArc(11uy,-0x24y)
        Displacement(-17y,0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // Q
    81us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(37y,38y)
        PenDown
        FractionalArc(130uy,126uy,15us,0x4y)
        FractionalArc(99uy,157uy,28us,0x32y)
        FractionalArc(130uy,126uy,15us,0x44y)
        FractionalArc(99uy,157uy,28us,0x72y)
        PenUp
        Displacement(-11y,-27y)
        PenDown
        FractionalArc(0uy,0uy,6us,-0x22y)
        FractionalArc(9uy,0uy,5us,0x42y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // R
    82us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,3y)
        PenDown
        Displacement(0y,44y)
        Displacement(19y,0y)
        OctantArc(11uy,-0x24y)
        Displacement(-19y,0y)
        PenUp
        Displacement(17y,0y)
        PenDown
        Displacement(13y,-22y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // S
    83us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,3y)
        Vector 0xA4uy
        PenDown
        FractionalArc(140uy,194uy,17us,0x43y)
        FractionalArc(235uy,140uy,12us,0x63y)
        FractionalArc(185uy,218uy,11us,0x2y)
        FractionalArc(155uy,215uy,50us,0x11y)
        FractionalArc(41uy,113uy,10us,-0x64y)
        FractionalArc(130uy,80uy,17us,-0x33y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // T
    84us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Displacement(-16y,0y)
        PenDown
        Displacement(32y,0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // U
    85us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,47y)
        PenDown
        Displacement(0y,-29y)
        OctantArc(15uy,0x44y)
        Displacement(0y,29y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // V
    86us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(6y,47y)
        PenDown
        ManyDisplacements [17y,-44y;17y,44y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // W
    87us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(3y,47y)
        PenDown
        ManyDisplacements [11y,-44y;9y,44y;9y,-44y;11y,44y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // X
    88us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,47y)
        PenDown
        Displacement(30y,-44y)
        PenUp
        Displacement(0y,44y)
        PenDown
        Displacement(-30y,-44y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // Y
    89us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(7y,47y)
        PenDown
        Displacement(16y,-20y)
        Displacement(16y,20y)
        PenUp
        Displacement(-16y,-20y)
        PenDown
        Displacement(0y,-24y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // Z
    90us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,47y)
        PenDown
        ManyDisplacements [30y,0y;-30y,-44y;30y,0y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // [
    91us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(27y,-5y)
        PenDown
        ManyDisplacements [-8y,0y;0y,55y;8y,0y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // \
    92us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(6y,50y)
        PenDown
        Displacement(34y,-55y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // ]
    93us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(19y,-5y)
        PenDown
        ManyDisplacements [8y,0y;0y,55y;-8y,0y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // ^
    94us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(6y,30y)
        PenDown
        ManyDisplacements [15y,17y;15y,-17y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // _
    95us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        PenDown
        Displacement(46y,0y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // `
    96us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,41y)
        PenDown
        Displacement(0y,16y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // a
    97us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(34y,10y)
        PenDown
        Subshape 2uy
        PenUp
        Vector 0x74uy
        PenDown
        Displacement(0y,-30y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // b
    98us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(12y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Displacement(0y,-21y)
        PenDown
        Divide 2uy
        FractionalArc(105uy,82uy,21us,-0x44y)
        FractionalArc(85uy,171uy,40us,-0x12y)
        FractionalArc(174uy,151uy,21us,-0x4y)
        Multiply 2uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // c
    99us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(34y,10y)
        PenDown
        Subshape 2uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // d
    100us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(34y,10y)
        PenDown
        Subshape 2uy
        PenUp
        Displacement(0y,21y)
        PenDown
        Displacement(0y,-44y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // e
    101us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(35y,9y)
        PenDown
        Divide 2uy
        FractionalArc(175uy,16uy,25us,-0x4y)
        FractionalArc(27uy,229uy,34us,-0x52y)
        FractionalArc(240uy,236uy,23us,-0x44y)
        Multiply 2uy
        ManyDisplacements [0y,-3y;-24y,0y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // f
    102us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,3y)
        PenDown
        Displacement(0y,39y)
        OctantArc(4uy,-0x43y)
        PenUp
        Vector 0xCCuy
        PenDown
        Vector 0xE8uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // g
    103us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(34y,10y)
        PenDown
        Subshape 2uy
        PenUp
        Vector 0x74uy
        PenDown
        Displacement(0y,-36y)
        FractionalArc(0uy,155uy,9us,-0x3y)
        Displacement(-4y,2y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // h
    104us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(13y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Displacement(0y,-18y)
        PenDown
        FractionalArc(64uy,240uy,24us,-0x31y)
        FractionalArc(0uy,0uy,8us,-0x22y)
        Displacement(0y,-22y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // i
    105us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,3y)
        PenDown
        Displacement(0y,30y)
        PenUp
        Vector 0xC4uy
        PenDown
        Vector 0x24uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // j
    106us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(19y,-11y)
        PenDown
        FractionalArc(145uy,0uy,6us,0x53y)
        Displacement(0y,38y)
        PenUp
        Vector 0xC4uy
        PenDown
        Vector 0x24uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // k
    107us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(13y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Displacement(0y,-32y)
        PenDown
        Displacement(18y,16y)
        PenUp
        Vector 0x8Auy
        PenDown
        Displacement(10y,-20y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // l
    108us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // m
    109us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(3y,3y)
        PenDown
        Displacement(0y,30y)
        PenUp
        Vector 0x4Cuy
        PenDown
        FractionalArc(64uy,240uy,24us,-0x31y)
        FractionalArc(0uy,0uy,8us,-0x22y)
        Displacement(0y,-22y)
        PenUp
        Displacement(0y,26y)
        PenDown
        FractionalArc(64uy,240uy,24us,-0x31y)
        FractionalArc(0uy,0uy,8us,-0x22y)
        Displacement(0y,-22y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // n
    110us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(13y,3y)
        PenDown
        Displacement(0y,30y)
        PenUp
        Vector 0x4Cuy
        PenDown
        FractionalArc(64uy,240uy,24us,-0x31y)
        FractionalArc(0uy,0uy,8us,-0x22y)
        Displacement(0y,-22y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // o
    111us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(32y,8y)
        PenDown
        Divide 2uy
        FractionalArc(176uy,80uy,21us,-0x4y)
        FractionalArc(85uy,171uy,40us,-0x52y)
        FractionalArc(176uy,80uy,21us,-0x44y)
        FractionalArc(85uy,171uy,40us,-0x12y)
        Multiply 2uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // p
    112us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(12y,-11y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Displacement(0y,-7y)
        PenDown
        Divide 2uy
        FractionalArc(105uy,82uy,21us,-0x44y)
        FractionalArc(85uy,171uy,40us,-0x12y)
        FractionalArc(174uy,151uy,21us,-0x4y)
        Multiply 2uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // q
    113us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(34y,10y)
        PenDown
        Subshape 2uy
        PenUp
        Vector 0x74uy
        PenDown
        Displacement(0y,-44y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // r
    114us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(16y,3y)
        PenDown
        Displacement(0y,30y)
        PenUp
        Vector 0xECuy
        PenDown
        OctantArc(14uy,-0x42y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // s
    115us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(13y,10y)
        PenDown
        FractionalArc(139uy,29uy,12us,0x43y)
        FractionalArc(0uy,0uy,8us,0x62y)
        FractionalArc(238uy,146uy,6us,0x73y)
        FractionalArc(155uy,215uy,50us,0x11y)
        FractionalArc(64uy,92uy,7us,-0x64y)
        FractionalArc(111uy,70uy,11us,-0x33y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // t
    116us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,3y)
        PenDown
        Displacement(0y,44y)
        PenUp
        Displacement(7y,-14y)
        PenDown
        Vector 0xE8uy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // u
    117us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(13y,33y)
        PenDown
        Displacement(0y,-22y)
        FractionalArc(0uy,0uy,8us,0x42y)
        FractionalArc(64uy,247uy,24us,0x61y)
        PenUp
        Vector 0x6Cuy
        PenDown
        Displacement(0y,30y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // v
    118us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(13y,33y)
        PenDown
        ManyDisplacements [10y,-30y;1y,0y;10y,30y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // w
    119us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(8y,33y)
        PenDown
        ManyDisplacements [9y,-30y;1y,0y;5y,26y;1y,0y;5y,-26y;1y,0y;9y,30y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // x
    120us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(13y,33y)
        PenDown
        Displacement(19y,-30y)
        PenUp
        Displacement(-20y,0y)
        PenDown
        Displacement(19y,30y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // y
    121us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(13y,33y)
        PenDown
        Displacement(10y,-30y)
        PenUp
        Displacement(10y,30y)
        PenDown
        Displacement(-13y,-39y)
        FractionalArc(150uy,0uy,9us,-0x2y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // z
    122us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(14y,33y)
        PenDown
        ManyDisplacements [18y,0y;-18y,-30y;18y,0y]
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // {
    123us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(28y,-5y)
        PenDown
        FractionalArc(74uy,51uy,9us,-0x64y)
        FractionalArc(51uy,0uy,7us,0x73y)
        FractionalArc(48uy,225uy,8us,0x63y)
        FractionalArc(0uy,182uy,9us,-0x53y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // |
    124us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(23y,-5y)
        PenDown
        Displacement(0y,55y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // }
    125us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(19y,-5y)
        PenDown
        FractionalArc(74uy,51uy,9us,0x64y)
        FractionalArc(51uy,0uy,7us,-0x53y)
        FractionalArc(48uy,225uy,8us,-0x63y)
        FractionalArc(0uy,182uy,9us,0x73y)
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    // ~
    126us, [
        PenUp
        VerticalText(Displacement(-23y,-50y))
        Push
        Displacement(9y,20y)
        PenDown
        FractionalArc(0uy,123uy,7us,-0x43y)
        Displacement(8y,-5y)
        FractionalArc(57uy,0uy,7us,0x53y)
        Vector 0x24uy
        FractionalArc(0uy,123uy,7us,-0x3y)
        Displacement(-8y,5y)
        FractionalArc(57uy,0uy,7us,0x13y)
        Vector 0x2Cuy
        PenUp
        Pop
        Displacement(46y,0y)
        VerticalText(Displacement(-23y,-25y))
        EndOfShape
    ]
    ]