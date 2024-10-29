module SimplexTestProject.Monors
open shpParser

let shapes = [
    10us, [
        PenUp
        Displacement(0y,-127y)
        // VerticalText(Displacement(127y,127y))
        EndOfShape
    ]
    //  
    32us, [
        PenUp
        Displacement(100y,0y)
        // VerticalText(Displacement(-100y,-115y))
        EndOfShape
    ]
    // !
    33us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(50y,8y)
        PenDown
        Displacement(4y,-4y)
        Displacement(-4y,-4y)
        Displacement(-4y,4y)
        Displacement(4y,4y)
        PenUp
        Displacement(0y,72y)
        PenDown
        Displacement(0y,-53y)
        PenUp
        Displacement(50y,-27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // "
    34us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(42y,91y)
        PenDown
        Displacement(-4y,-3y)
        Displacement(-3y,3y)
        Displacement(4y,4y)
        Displacement(3y,-4y)
        Displacement(0y,-7y)
        Displacement(-4y,-8y)
        Displacement(-3y,-3y)
        PenUp
        Displacement(30y,18y)
        PenDown
        Displacement(-4y,-3y)
        Displacement(-3y,4y)
        Displacement(3y,3y)
        Displacement(4y,-4y)
        Displacement(0y,-8y)
        Displacement(-3y,-7y)
        Displacement(-4y,-4y)
        PenUp
        Displacement(42y,-72y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // #
    35us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(21y,23y)
        PenDown
        Displacement(53y,0y)
        PenUp
        Displacement(-49y,23y)
        PenDown
        Displacement(53y,0y)
        PenUp
        Displacement(-3y,49y)
        PenDown
        Displacement(-27y,-122y)
        PenUp
        Displacement(4y,122y)
        PenDown
        Displacement(-27y,-122y)
        PenUp
        Displacement(75y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // $
    36us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(77y,69y)
        PenDown
        Displacement(-8y,7y)
        Displacement(-11y,4y)
        Displacement(-16y,0y)
        Displacement(-11y,-4y)
        Displacement(-8y,-7y)
        Displacement(0y,-8y)
        Displacement(4y,-7y)
        Displacement(4y,-5y)
        Displacement(8y,-3y)
        Displacement(22y,-8y)
        Displacement(8y,-4y)
        Displacement(4y,-3y)
        Displacement(4y,-8y)
        Displacement(0y,-11y)
        Displacement(-8y,-8y)
        Displacement(-11y,-4y)
        Displacement(-16y,0y)
        Displacement(-11y,4y)
        Displacement(-8y,8y)
        PenUp
        Displacement(19y,83y)
        PenDown
        Displacement(0y,-110y)
        PenUp
        Displacement(16y,110y)
        PenDown
        Displacement(0y,-110y)
        PenUp
        Displacement(42y,15y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // %
    37us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(16y,0y)
        PenDown
        Displacement(69y,80y)
        Displacement(-8y,-3y)
        Displacement(-10y,-4y)
        Displacement(-14y,0y)
        Displacement(-9y,3y)
        Displacement(-9y,4y)
        Displacement(-8y,0y)
        Displacement(-7y,-4y)
        Displacement(-4y,-7y)
        Displacement(0y,-8y)
        Displacement(7y,-8y)
        Displacement(8y,0y)
        Displacement(7y,4y)
        Displacement(4y,8y)
        Displacement(0y,7y)
        Displacement(-7y,8y)
        PenUp
        Displacement(42y,-53y)
        PenDown
        Displacement(-9y,0y)
        Displacement(-7y,-4y)
        Displacement(-3y,-8y)
        Displacement(0y,-7y)
        Displacement(7y,-8y)
        Displacement(8y,0y)
        Displacement(7y,4y)
        Displacement(5y,8y)
        Displacement(0y,7y)
        Displacement(-8y,8y)
        PenUp
        Displacement(23y,-27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // &
    38us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(88y,8y)
        PenDown
        Displacement(0y,-4y)
        Displacement(-3y,-4y)
        Displacement(-9y,0y)
        Displacement(-7y,4y)
        Displacement(-8y,8y)
        Displacement(-26y,37y)
        Displacement(-4y,12y)
        Displacement(0y,7y)
        Displacement(4y,9y)
        Displacement(7y,3y)
        Displacement(8y,-4y)
        Displacement(4y,-7y)
        Displacement(0y,-8y)
        Displacement(-4y,-7y)
        Displacement(-4y,-4y)
        Displacement(-26y,-15y)
        Displacement(-4y,-4y)
        Displacement(-4y,-8y)
        Displacement(0y,-8y)
        Displacement(4y,-7y)
        Displacement(4y,-4y)
        Displacement(7y,-4y)
        Displacement(16y,0y)
        Displacement(7y,4y)
        Displacement(8y,8y)
        Displacement(7y,11y)
        Displacement(8y,19y)
        Displacement(3y,7y)
        Displacement(4y,4y)
        Displacement(5y,0y)
        Displacement(3y,-3y)
        Displacement(0y,-4y)
        PenUp
        Displacement(12y,-46y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // '
    39us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(46y,58y)
        PenDown
        Displacement(4y,3y)
        Displacement(4y,7y)
        Displacement(0y,8y)
        Displacement(-4y,4y)
        Displacement(-4y,-4y)
        Displacement(4y,-4y)
        Displacement(4y,4y)
        PenUp
        Displacement(46y,-76y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // (
    40us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(64y,-27y)
        PenDown
        Displacement(-9y,8y)
        Displacement(-7y,12y)
        Displacement(-8y,15y)
        Displacement(-3y,19y)
        Displacement(0y,15y)
        Displacement(4y,19y)
        Displacement(7y,15y)
        Displacement(7y,11y)
        Displacement(9y,8y)
        PenUp
        Displacement(36y,-95y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // )
    41us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(37y,-27y)
        PenDown
        Displacement(8y,8y)
        Displacement(7y,11y)
        Displacement(7y,15y)
        Displacement(4y,19y)
        Displacement(0y,16y)
        Displacement(-4y,19y)
        Displacement(-7y,16y)
        Displacement(-7y,10y)
        Displacement(-8y,8y)
        PenUp
        Displacement(63y,-95y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // *
    42us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(31y,45y)
        PenDown
        Displacement(39y,-22y)
        PenUp
        Displacement(-20y,34y)
        PenDown
        Displacement(0y,-45y)
        PenUp
        Displacement(20y,33y)
        PenDown
        Displacement(-39y,-22y)
        PenUp
        Displacement(69y,-23y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // +
    43us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(16y,34y)
        PenDown
        Displacement(69y,0y)
        PenUp
        Displacement(-35y,-34y)
        PenDown
        Displacement(0y,69y)
        PenUp
        Displacement(50y,-69y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // ,
    44us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(46y,-15y)
        PenDown
        Displacement(4y,3y)
        Displacement(4y,8y)
        Displacement(0y,8y)
        Displacement(-4y,4y)
        Displacement(-4y,-4y)
        Displacement(4y,-4y)
        Displacement(4y,4y)
        PenUp
        Displacement(46y,-4y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // -
    45us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(16y,35y)
        PenDown
        Displacement(69y,0y)
        PenUp
        Displacement(15y,-35y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // .
    46us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(50y,0y)
        PenDown
        Displacement(-4y,4y)
        Displacement(4y,4y)
        Displacement(4y,-4y)
        Displacement(-4y,-4y)
        PenUp
        Displacement(50y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // /
    47us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(85y,95y)
        PenDown
        Displacement(-69y,-122y)
        PenUp
        Displacement(84y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 0
    48us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(46y,0y)
        PenDown
        Displacement(-11y,4y)
        Displacement(-8y,11y)
        Displacement(-4y,19y)
        Displacement(0y,12y)
        Displacement(4y,19y)
        Displacement(8y,11y)
        Displacement(11y,4y)
        Displacement(8y,0y)
        Displacement(11y,-4y)
        Displacement(8y,-11y)
        Displacement(4y,-19y)
        Displacement(0y,-12y)
        Displacement(-4y,-19y)
        Displacement(-8y,-11y)
        Displacement(-11y,-4y)
        Displacement(-8y,0y)
        PenUp
        Displacement(54y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 1
    49us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(40y,65y)
        PenDown
        Displacement(8y,4y)
        Displacement(11y,11y)
        Displacement(0y,-80y)
        PenUp
        Displacement(41y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 2
    50us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(27y,61y)
        PenDown
        Displacement(0y,4y)
        Displacement(4y,7y)
        Displacement(4y,4y)
        Displacement(7y,4y)
        Displacement(16y,0y)
        Displacement(7y,-4y)
        Displacement(4y,-4y)
        Displacement(4y,-7y)
        Displacement(0y,-8y)
        Displacement(-4y,-7y)
        Displacement(-8y,-12y)
        Displacement(-38y,-38y)
        Displacement(54y,0y)
        PenUp
        Displacement(23y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 3
    51us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,15y)
        PenDown
        Displacement(4y,-7y)
        Displacement(4y,-4y)
        Displacement(11y,-4y)
        Displacement(13y,0y)
        Displacement(10y,4y)
        Displacement(8y,7y)
        Displacement(3y,12y)
        Displacement(0y,8y)
        Displacement(-3y,11y)
        Displacement(-11y,8y)
        Displacement(-12y,0y)
        Displacement(23y,30y)
        Displacement(-42y,0y)
        PenUp
        Displacement(69y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 4
    52us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(59y,0y)
        PenDown
        Displacement(0y,80y)
        Displacement(-38y,-53y)
        Displacement(58y,0y)
        PenUp
        Displacement(21y,-27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 5
    53us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,15y)
        PenDown
        Displacement(4y,-7y)
        Displacement(4y,-4y)
        Displacement(11y,-4y)
        Displacement(12y,0y)
        Displacement(11y,4y)
        Displacement(8y,8y)
        Displacement(3y,10y)
        Displacement(0y,8y)
        Displacement(-3y,12y)
        Displacement(-8y,8y)
        Displacement(-11y,3y)
        Displacement(-12y,0y)
        Displacement(-11y,-4y)
        Displacement(-4y,-3y)
        Displacement(4y,34y)
        Displacement(38y,0y)
        PenUp
        Displacement(31y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 6
    54us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(26y,27y)
        PenDown
        Displacement(3y,11y)
        Displacement(8y,8y)
        Displacement(11y,3y)
        Displacement(4y,0y)
        Displacement(12y,-3y)
        Displacement(7y,-8y)
        Displacement(3y,-11y)
        Displacement(0y,-5y)
        Displacement(-3y,-10y)
        Displacement(-8y,-8y)
        Displacement(-11y,-4y)
        Displacement(-4y,0y)
        Displacement(-11y,3y)
        Displacement(-8y,9y)
        Displacement(-3y,15y)
        Displacement(0y,19y)
        Displacement(3y,19y)
        Displacement(7y,11y)
        Displacement(12y,4y)
        Displacement(8y,0y)
        Displacement(11y,-4y)
        Displacement(4y,-7y)
        PenUp
        Displacement(29y,-69y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 7
    55us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,80y)
        PenDown
        Displacement(54y,0y)
        Displacement(-39y,-80y)
        PenUp
        Displacement(62y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 8
    56us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(58y,80y)
        PenDown
        Displacement(11y,-4y)
        Displacement(4y,-7y)
        Displacement(0y,-8y)
        Displacement(-4y,-8y)
        Displacement(-7y,-3y)
        Displacement(-13y,-3y)
        Displacement(-14y,-5y)
        Displacement(-8y,-8y)
        Displacement(-4y,-7y)
        Displacement(0y,-12y)
        Displacement(4y,-7y)
        Displacement(4y,-5y)
        Displacement(11y,-3y)
        Displacement(16y,0y)
        Displacement(11y,3y)
        Displacement(4y,5y)
        Displacement(4y,7y)
        Displacement(0y,12y)
        Displacement(-4y,8y)
        Displacement(-8y,7y)
        Displacement(-10y,4y)
        Displacement(-16y,4y)
        Displacement(-8y,3y)
        Displacement(-4y,8y)
        Displacement(0y,8y)
        Displacement(4y,7y)
        Displacement(11y,4y)
        Displacement(16y,0y)
        PenUp
        Displacement(42y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // 9
    57us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(74y,54y)
        PenDown
        Displacement(-3y,-12y)
        Displacement(-8y,-8y)
        Displacement(-11y,-4y)
        Displacement(-4y,0y)
        Displacement(-12y,4y)
        Displacement(-7y,8y)
        Displacement(-3y,11y)
        Displacement(0y,5y)
        Displacement(3y,11y)
        Displacement(8y,7y)
        Displacement(11y,4y)
        Displacement(4y,0y)
        Displacement(11y,-4y)
        Displacement(8y,-7y)
        Displacement(3y,-15y)
        Displacement(0y,-20y)
        Displacement(-3y,-19y)
        Displacement(-8y,-11y)
        Displacement(-10y,-4y)
        Displacement(-9y,0y)
        Displacement(-11y,4y)
        Displacement(-4y,8y)
        PenUp
        Displacement(71y,-12y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // :
    58us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(50y,46y)
        PenDown
        Displacement(4y,4y)
        Displacement(-4y,3y)
        Displacement(-4y,-3y)
        Displacement(4y,-4y)
        PenUp
        Displacement(0y,-46y)
        PenDown
        Displacement(4y,4y)
        Displacement(-4y,4y)
        Displacement(-4y,-4y)
        Displacement(4y,-4y)
        PenUp
        Displacement(50y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // ;
    59us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(54y,50y)
        PenDown
        Displacement(-4y,-4y)
        Displacement(-4y,4y)
        Displacement(4y,3y)
        Displacement(4y,-3y)
        PenUp
        Displacement(0y,-46y)
        PenDown
        Displacement(-4y,-4y)
        Displacement(-4y,4y)
        Displacement(4y,4y)
        Displacement(4y,-4y)
        Displacement(0y,-8y)
        Displacement(-4y,-8y)
        Displacement(-4y,-3y)
        PenUp
        Displacement(54y,15y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // <
    60us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(81y,69y)
        PenDown
        Displacement(-62y,-35y)
        Displacement(62y,-34y)
        PenUp
        Displacement(19y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // =
    61us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(16y,46y)
        PenDown
        Displacement(69y,0y)
        PenUp
        Displacement(-69y,-23y)
        PenDown
        Displacement(69y,0y)
        PenUp
        Displacement(15y,-23y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // >
    62us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(20y,69y)
        PenDown
        Displacement(61y,-35y)
        Displacement(-62y,-34y)
        PenUp
        Displacement(81y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // ?
    63us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(50y,8y)
        PenDown
        Displacement(-4y,-4y)
        Displacement(4y,-4y)
        Displacement(4y,4y)
        Displacement(-4y,4y)
        PenUp
        Displacement(-23y,53y)
        PenDown
        Displacement(0y,4y)
        Displacement(4y,7y)
        Displacement(4y,5y)
        Displacement(7y,3y)
        Displacement(16y,0y)
        Displacement(7y,-4y)
        Displacement(4y,-4y)
        Displacement(4y,-7y)
        Displacement(0y,-8y)
        Displacement(-4y,-7y)
        Displacement(-4y,-4y)
        Displacement(-15y,-8y)
        Displacement(0y,-12y)
        PenUp
        Displacement(50y,-26y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // @
    64us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(44y,61y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(-3y,-11y)
        Displacement(0y,-12y)
        Displacement(4y,-7y)
        Displacement(3y,-4y)
        PenUp
        Displacement(23y,12y)
        PenDown
        Displacement(-4y,-8y)
        Displacement(-7y,-4y)
        Displacement(-12y,0y)
        Displacement(-7y,4y)
        Displacement(-4y,7y)
        Displacement(0y,12y)
        Displacement(4y,11y)
        Displacement(4y,5y)
        Displacement(7y,3y)
        Displacement(11y,0y)
        Displacement(9y,-4y)
        Displacement(2y,-5y)
        PenUp
        Displacement(5y,-33y)
        PenDown
        Displacement(-8y,4y)
        Displacement(0y,8y)
        Displacement(4y,30y)
        PenUp
        Displacement(4y,0y)
        PenDown
        Displacement(-4y,-30y)
        Displacement(0y,-8y)
        Displacement(4y,-4y)
        Displacement(7y,0y)
        Displacement(8y,8y)
        Displacement(4y,11y)
        Displacement(0y,8y)
        Displacement(-4y,11y)
        Displacement(-3y,8y)
        Displacement(-8y,7y)
        Displacement(-8y,4y)
        Displacement(-11y,4y)
        Displacement(-12y,0y)
        Displacement(-11y,-3y)
        Displacement(-7y,-4y)
        Displacement(-8y,-8y)
        Displacement(-4y,-8y)
        Displacement(-4y,-11y)
        Displacement(0y,-12y)
        Displacement(4y,-11y)
        Displacement(4y,-8y)
        Displacement(8y,-8y)
        Displacement(8y,-4y)
        Displacement(10y,-3y)
        Displacement(12y,0y)
        Displacement(11y,4y)
        Displacement(8y,4y)
        Displacement(3y,4y)
        PenUp
        Displacement(22y,-12y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // A
    65us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(19y,0y)
        PenDown
        Displacement(31y,79y)
        Displacement(31y,-79y)
        PenUp
        Displacement(-50y,27y)
        PenDown
        Displacement(38y,0y)
        PenUp
        Displacement(31y,-27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // B
    66us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,42y)
        PenDown
        Displacement(35y,0y)
        Displacement(11y,-4y)
        Displacement(4y,-4y)
        Displacement(4y,-7y)
        Displacement(0y,-12y)
        Displacement(-4y,-8y)
        Displacement(-4y,-3y)
        Displacement(-11y,-4y)
        Displacement(-35y,0y)
        Displacement(0y,80y)
        Displacement(35y,0y)
        Displacement(11y,-4y)
        Displacement(4y,-4y)
        Displacement(4y,-7y)
        Displacement(0y,-8y)
        Displacement(-4y,-7y)
        Displacement(-4y,-4y)
        Displacement(-11y,-4y)
        PenUp
        Displacement(42y,-42y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // C
    67us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(78y,19y)
        PenDown
        Displacement(-3y,-7y)
        Displacement(-8y,-8y)
        Displacement(-8y,-4y)
        Displacement(-15y,0y)
        Displacement(-8y,4y)
        Displacement(-7y,8y)
        Displacement(-4y,8y)
        Displacement(-4y,10y)
        Displacement(0y,20y)
        Displacement(4y,10y)
        Displacement(4y,9y)
        Displacement(7y,7y)
        Displacement(8y,4y)
        Displacement(15y,0y)
        Displacement(8y,-4y)
        Displacement(8y,-7y)
        Displacement(4y,-8y)
        PenUp
        Displacement(21y,-61y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // D
    68us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(50y,80y)
        PenDown
        Displacement(11y,-4y)
        Displacement(8y,-7y)
        Displacement(4y,-9y)
        Displacement(4y,-11y)
        Displacement(0y,-19y)
        Displacement(-3y,-9y)
        Displacement(-5y,-9y)
        Displacement(-8y,-8y)
        Displacement(-11y,-4y)
        Displacement(-27y,0y)
        Displacement(0y,80y)
        Displacement(27y,0y)
        PenUp
        Displacement(50y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // E
    69us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(74y,80y)
        PenDown
        Displacement(-49y,0y)
        Displacement(0y,-80y)
        Displacement(50y,0y)
        PenUp
        Displacement(-50y,42y)
        PenDown
        Displacement(30y,0y)
        PenUp
        Displacement(45y,-42y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // F
    70us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(74y,80y)
        PenDown
        Displacement(-49y,0y)
        Displacement(0y,-80y)
        PenUp
        Displacement(0y,42y)
        PenDown
        Displacement(31y,0y)
        PenUp
        Displacement(44y,-42y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // G
    71us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(79y,60y)
        PenDown
        Displacement(-5y,9y)
        Displacement(-7y,7y)
        Displacement(-8y,4y)
        Displacement(-15y,0y)
        Displacement(-8y,-4y)
        Displacement(-7y,-7y)
        Displacement(-4y,-8y)
        Displacement(-4y,-11y)
        Displacement(0y,-20y)
        Displacement(3y,-9y)
        Displacement(5y,-9y)
        Displacement(7y,-8y)
        Displacement(8y,-4y)
        Displacement(16y,0y)
        Displacement(8y,4y)
        Displacement(7y,8y)
        Displacement(4y,7y)
        Displacement(0y,12y)
        Displacement(-20y,0y)
        PenUp
        Displacement(41y,-31y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // H
    72us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,80y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(0y,42y)
        PenDown
        Displacement(54y,0y)
        PenUp
        Displacement(0y,38y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(23y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // I
    73us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(50y,80y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(50y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // J
    74us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(31y,27y)
        PenDown
        Displacement(0y,-8y)
        Displacement(4y,-11y)
        Displacement(4y,-4y)
        Displacement(7y,-4y)
        Displacement(8y,0y)
        Displacement(6y,3y)
        Displacement(5y,4y)
        Displacement(4y,12y)
        Displacement(0y,61y)
        PenUp
        Displacement(31y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // K
    75us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(42y,46y)
        PenDown
        Displacement(35y,-46y)
        PenUp
        Displacement(-54y,27y)
        PenDown
        Displacement(54y,53y)
        PenUp
        Displacement(-54y,0y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(77y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // L
    76us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(27y,80y)
        PenDown
        Displacement(0y,-80y)
        Displacement(46y,0y)
        PenUp
        Displacement(27y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // M
    77us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(19y,0y)
        PenDown
        Displacement(0y,80y)
        Displacement(31y,-80y)
        Displacement(31y,80y)
        Displacement(0y,-80y)
        PenUp
        Displacement(19y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // N
    78us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,0y)
        PenDown
        Displacement(0y,80y)
        Displacement(53y,-80y)
        Displacement(0y,80y)
        PenUp
        Displacement(24y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // O
    79us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(58y,80y)
        PenDown
        Displacement(8y,-4y)
        Displacement(7y,-8y)
        Displacement(4y,-7y)
        Displacement(4y,-11y)
        Displacement(0y,-20y)
        Displacement(-4y,-9y)
        Displacement(-4y,-9y)
        Displacement(-7y,-8y)
        Displacement(-8y,-4y)
        Displacement(-16y,0y)
        Displacement(-7y,4y)
        Displacement(-8y,8y)
        Displacement(-4y,8y)
        Displacement(-4y,10y)
        Displacement(0y,20y)
        Displacement(3y,10y)
        Displacement(5y,9y)
        Displacement(8y,7y)
        Displacement(7y,4y)
        Displacement(16y,0y)
        PenUp
        Displacement(42y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // P
    80us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,38y)
        PenDown
        Displacement(35y,0y)
        Displacement(10y,3y)
        Displacement(5y,5y)
        Displacement(3y,8y)
        Displacement(0y,11y)
        Displacement(-2y,7y)
        Displacement(-5y,5y)
        Displacement(-11y,3y)
        Displacement(-35y,0y)
        Displacement(0y,-80y)
        PenUp
        Displacement(77y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // Q
    81us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(58y,80y)
        PenDown
        Displacement(8y,-4y)
        Displacement(7y,-7y)
        Displacement(4y,-9y)
        Displacement(3y,-11y)
        Displacement(0y,-19y)
        Displacement(-2y,-9y)
        Displacement(-5y,-9y)
        Displacement(-7y,-8y)
        Displacement(-8y,-4y)
        Displacement(-15y,0y)
        Displacement(-8y,4y)
        Displacement(-8y,8y)
        Displacement(-4y,8y)
        Displacement(-4y,11y)
        Displacement(0y,19y)
        Displacement(4y,10y)
        Displacement(4y,9y)
        Displacement(8y,7y)
        Displacement(7y,4y)
        Displacement(16y,0y)
        PenUp
        Displacement(-4y,-65y)
        PenDown
        Displacement(23y,-22y)
        PenUp
        Displacement(23y,7y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // R
    82us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,42y)
        PenDown
        Displacement(35y,0y)
        Displacement(11y,4y)
        Displacement(4y,4y)
        Displacement(4y,7y)
        Displacement(0y,8y)
        Displacement(-4y,7y)
        Displacement(-4y,4y)
        Displacement(-11y,4y)
        Displacement(-35y,0y)
        Displacement(0y,-80y)
        PenUp
        Displacement(27y,42y)
        PenDown
        Displacement(27y,-42y)
        PenUp
        Displacement(23y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // S
    83us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,12y)
        PenDown
        Displacement(8y,-8y)
        Displacement(11y,-4y)
        Displacement(16y,0y)
        Displacement(11y,4y)
        Displacement(8y,8y)
        Displacement(0y,11y)
        Displacement(-4y,8y)
        Displacement(-4y,3y)
        Displacement(-7y,4y)
        Displacement(-24y,8y)
        Displacement(-6y,3y)
        Displacement(-5y,5y)
        Displacement(-4y,6y)
        Displacement(0y,9y)
        Displacement(8y,7y)
        Displacement(11y,4y)
        Displacement(16y,0y)
        Displacement(11y,-4y)
        Displacement(8y,-7y)
        PenUp
        Displacement(23y,-69y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // T
    84us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,80y)
        PenDown
        Displacement(54y,0y)
        PenUp
        Displacement(-27y,0y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(50y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // U
    85us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(77y,80y)
        PenDown
        Displacement(0y,-57y)
        Displacement(-4y,-11y)
        Displacement(-8y,-9y)
        Displacement(-11y,-3y)
        Displacement(-8y,0y)
        Displacement(-11y,4y)
        Displacement(-8y,8y)
        Displacement(-4y,11y)
        Displacement(0y,57y)
        PenUp
        Displacement(77y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // V
    86us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(19y,80y)
        PenDown
        Displacement(31y,-80y)
        Displacement(31y,80y)
        PenUp
        Displacement(19y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // W
    87us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(12y,80y)
        PenDown
        Displacement(19y,-80y)
        Displacement(19y,80y)
        Displacement(19y,-80y)
        Displacement(19y,80y)
        PenUp
        Displacement(12y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // X
    88us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(76y,80y)
        PenDown
        Displacement(-53y,-80y)
        PenUp
        Displacement(0y,80y)
        PenDown
        Displacement(54y,-80y)
        PenUp
        Displacement(23y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // Y
    89us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(20y,80y)
        PenDown
        Displacement(30y,-38y)
        Displacement(0y,-42y)
        PenUp
        Displacement(0y,42y)
        PenDown
        Displacement(31y,38y)
        PenUp
        Displacement(19y,-80y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // Z
    90us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(23y,80y)
        PenDown
        Displacement(54y,0y)
        Displacement(-54y,-80y)
        Displacement(54y,0y)
        PenUp
        Displacement(23y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // [
    91us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(40y,95y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(-3y,0y)
        PenDown
        Displacement(26y,0y)
        PenUp
        Displacement(-26y,122y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(27y,122y)
        PenDown
        Displacement(-27y,0y)
        PenUp
        Displacement(63y,-95y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // \
    92us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(16y,95y)
        PenDown
        Displacement(69y,-122y)
        PenUp
        Displacement(15y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // ]
    93us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(36y,95y)
        PenDown
        Displacement(27y,0y)
        Displacement(0y,-122y)
        Displacement(-26y,0y)
        PenUp
        Displacement(23y,122y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(40y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // ^
    94us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(19y,27y)
        PenDown
        Displacement(31y,19y)
        Displacement(31y,-19y)
        Displacement(-31y,15y)
        Displacement(-31y,-15y)
        PenUp
        Displacement(81y,-27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // _
    95us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(12y,-8y)
        PenDown
        Displacement(76y,0y)
        PenUp
        Displacement(12y,8y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // `
    96us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(54y,80y)
        PenDown
        Displacement(-4y,-4y)
        Displacement(-4y,-8y)
        Displacement(0y,-7y)
        Displacement(4y,-4y)
        Displacement(4y,4y)
        Displacement(-4y,4y)
        Displacement(-4y,-4y)
        PenUp
        Displacement(54y,-61y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // a
    97us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(73y,11y)
        PenDown
        Displacement(-8y,-7y)
        Displacement(-7y,-4y)
        Displacement(-12y,0y)
        Displacement(-8y,4y)
        Displacement(-7y,8y)
        Displacement(-4y,10y)
        Displacement(0y,9y)
        Displacement(4y,11y)
        Displacement(7y,8y)
        Displacement(8y,3y)
        Displacement(12y,0y)
        Displacement(8y,-4y)
        Displacement(7y,-7y)
        PenUp
        Displacement(0y,12y)
        PenDown
        Displacement(0y,-54y)
        PenUp
        Displacement(27y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // b
    98us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(27y,12y)
        PenDown
        Displacement(8y,-8y)
        Displacement(7y,-4y)
        Displacement(12y,0y)
        Displacement(8y,4y)
        Displacement(7y,8y)
        Displacement(4y,11y)
        Displacement(0y,8y)
        Displacement(-4y,11y)
        Displacement(-7y,7y)
        Displacement(-8y,4y)
        Displacement(-12y,0y)
        Displacement(-7y,-3y)
        Displacement(-8y,-8y)
        PenUp
        Displacement(0y,38y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(73y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // c
    99us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(73y,12y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(-7y,-4y)
        Displacement(-12y,0y)
        Displacement(-8y,4y)
        Displacement(-7y,8y)
        Displacement(-4y,11y)
        Displacement(0y,8y)
        Displacement(4y,11y)
        Displacement(7y,7y)
        Displacement(8y,4y)
        Displacement(12y,0y)
        Displacement(8y,-4y)
        Displacement(7y,-7y)
        PenUp
        Displacement(27y,-42y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // d
    100us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(73y,12y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(-7y,-4y)
        Displacement(-12y,0y)
        Displacement(-8y,4y)
        Displacement(-7y,7y)
        Displacement(-4y,12y)
        Displacement(0y,8y)
        Displacement(4y,11y)
        Displacement(7y,7y)
        Displacement(8y,4y)
        Displacement(12y,0y)
        Displacement(8y,-4y)
        Displacement(7y,-7y)
        PenUp
        Displacement(0y,38y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(27y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // e
    101us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(73y,12y)
        PenDown
        Displacement(-8y,-8y)
        Displacement(-7y,-4y)
        Displacement(-12y,0y)
        Displacement(-8y,4y)
        Displacement(-7y,8y)
        Displacement(-4y,10y)
        Displacement(0y,9y)
        Displacement(4y,11y)
        Displacement(7y,7y)
        Displacement(8y,5y)
        Displacement(12y,0y)
        Displacement(8y,-4y)
        Displacement(3y,-4y)
        Displacement(4y,-8y)
        Displacement(0y,-7y)
        Displacement(-46y,0y)
        PenUp
        Displacement(73y,-31y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // f
    102us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(66y,80y)
        PenDown
        Displacement(-8y,0y)
        Displacement(-8y,-4y)
        Displacement(-4y,-11y)
        Displacement(0y,-65y)
        PenUp
        Displacement(-11y,53y)
        PenDown
        Displacement(27y,0y)
        PenUp
        Displacement(38y,-53y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // g
    103us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(73y,42y)
        PenDown
        Displacement(-7y,7y)
        Displacement(-8y,4y)
        Displacement(-12y,0y)
        Displacement(-8y,-4y)
        Displacement(-7y,-7y)
        Displacement(-4y,-11y)
        Displacement(0y,-9y)
        Displacement(4y,-10y)
        Displacement(7y,-8y)
        Displacement(8y,-4y)
        Displacement(12y,0y)
        Displacement(7y,4y)
        Displacement(8y,8y)
        PenUp
        Displacement(0y,41y)
        PenDown
        Displacement(0y,-61y)
        Displacement(-4y,-11y)
        Displacement(-4y,-4y)
        Displacement(-7y,-4y)
        Displacement(-12y,0y)
        Displacement(-8y,4y)
        PenUp
        Displacement(62y,23y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // h
    104us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(71y,0y)
        PenDown
        Displacement(0y,38y)
        Displacement(-4y,11y)
        Displacement(-8y,4y)
        Displacement(-11y,0y)
        Displacement(-8y,-4y)
        Displacement(-11y,-11y)
        PenUp
        Displacement(0y,42y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(71y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // i
    105us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(50y,76y)
        PenDown
        Displacement(-4y,4y)
        Displacement(4y,4y)
        Displacement(4y,-4y)
        Displacement(-4y,-4y)
        PenUp
        Displacement(0y,-76y)
        PenDown
        Displacement(0y,53y)
        PenUp
        Displacement(50y,-53y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // j
    106us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(58y,76y)
        PenDown
        Displacement(3y,4y)
        Displacement(-3y,4y)
        Displacement(-4y,-4y)
        Displacement(4y,-4y)
        PenUp
        Displacement(0y,-23y)
        PenDown
        Displacement(0y,-65y)
        Displacement(-4y,-11y)
        Displacement(-8y,-4y)
        Displacement(-7y,0y)
        PenUp
        Displacement(61y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // k
    107us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(44y,31y)
        PenDown
        Displacement(27y,-31y)
        PenUp
        Displacement(-42y,15y)
        PenDown
        Displacement(38y,38y)
        PenUp
        Displacement(-38y,27y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(71y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // l
    108us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(50y,80y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(50y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // m
    109us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(8y,53y)
        PenDown
        Displacement(0y,-53y)
        PenUp
        Displacement(0y,38y)
        PenDown
        Displacement(11y,12y)
        Displacement(8y,4y)
        Displacement(12y,0y)
        Displacement(7y,-5y)
        Displacement(4y,-11y)
        Displacement(0y,-38y)
        PenUp
        Displacement(0y,38y)
        PenDown
        Displacement(11y,12y)
        Displacement(8y,4y)
        Displacement(12y,0y)
        Displacement(7y,-5y)
        Displacement(4y,-11y)
        Displacement(0y,-38y)
        PenUp
        Displacement(8y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // n
    110us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(29y,54y)
        PenDown
        Displacement(0y,-54y)
        PenUp
        Displacement(0y,38y)
        PenDown
        Displacement(11y,11y)
        Displacement(8y,4y)
        Displacement(12y,0y)
        Displacement(7y,-4y)
        Displacement(4y,-11y)
        Displacement(0y,-38y)
        PenUp
        Displacement(29y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // o
    111us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(56y,53y)
        PenDown
        Displacement(8y,-4y)
        Displacement(7y,-7y)
        Displacement(3y,-11y)
        Displacement(0y,-8y)
        Displacement(-3y,-11y)
        Displacement(-7y,-8y)
        Displacement(-8y,-4y)
        Displacement(-12y,0y)
        Displacement(-8y,4y)
        Displacement(-7y,8y)
        Displacement(-4y,10y)
        Displacement(0y,9y)
        Displacement(4y,11y)
        Displacement(7y,7y)
        Displacement(8y,4y)
        Displacement(12y,0y)
        PenUp
        Displacement(44y,-53y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // p
    112us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(27y,42y)
        PenDown
        Displacement(8y,8y)
        Displacement(7y,3y)
        Displacement(12y,0y)
        Displacement(8y,-4y)
        Displacement(7y,-7y)
        Displacement(4y,-11y)
        Displacement(0y,-9y)
        Displacement(-4y,-10y)
        Displacement(-8y,-8y)
        Displacement(-7y,-4y)
        Displacement(-12y,0y)
        Displacement(-7y,4y)
        Displacement(-8y,7y)
        PenUp
        Displacement(0y,43y)
        PenDown
        Displacement(0y,-81y)
        PenUp
        Displacement(73y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // q
    113us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(73y,11y)
        PenDown
        Displacement(-8y,-7y)
        Displacement(-7y,-4y)
        Displacement(-12y,0y)
        Displacement(-8y,4y)
        Displacement(-7y,8y)
        Displacement(-4y,10y)
        Displacement(0y,9y)
        Displacement(4y,11y)
        Displacement(7y,7y)
        Displacement(8y,4y)
        Displacement(12y,0y)
        Displacement(8y,-4y)
        Displacement(7y,-7y)
        PenUp
        Displacement(0y,11y)
        PenDown
        Displacement(0y,-80y)
        PenUp
        Displacement(27y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // r
    114us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(65y,53y)
        PenDown
        Displacement(-11y,0y)
        Displacement(-8y,-3y)
        Displacement(-8y,-8y)
        Displacement(-3y,-10y)
        PenUp
        Displacement(0y,22y)
        PenDown
        Displacement(0y,-54y)
        PenUp
        Displacement(65y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // s
    115us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(29y,12y)
        PenDown
        Displacement(4y,-8y)
        Displacement(11y,-4y)
        Displacement(12y,0y)
        Displacement(11y,4y)
        Displacement(4y,7y)
        Displacement(0y,4y)
        Displacement(-3y,8y)
        Displacement(-8y,3y)
        Displacement(-19y,5y)
        Displacement(-8y,3y)
        Displacement(-4y,8y)
        Displacement(4y,8y)
        Displacement(11y,3y)
        Displacement(12y,0y)
        Displacement(11y,-3y)
        Displacement(4y,-8y)
        PenUp
        Displacement(29y,-42y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // t
    116us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(65y,0y)
        PenDown
        Displacement(-8y,0y)
        Displacement(-7y,4y)
        Displacement(-4y,11y)
        Displacement(0y,65y)
        PenUp
        Displacement(-11y,-27y)
        PenDown
        Displacement(27y,0y)
        PenUp
        Displacement(38y,-53y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // u
    117us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(29y,53y)
        PenDown
        Displacement(0y,-38y)
        Displacement(4y,-11y)
        Displacement(7y,-4y)
        Displacement(12y,0y)
        Displacement(7y,4y)
        Displacement(12y,11y)
        PenUp
        Displacement(0y,38y)
        PenDown
        Displacement(0y,-53y)
        PenUp
        Displacement(29y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // v
    118us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(73y,53y)
        PenDown
        Displacement(-23y,-53y)
        Displacement(-23y,54y)
        PenUp
        Displacement(73y,-54y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // w
    119us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(81y,53y)
        PenDown
        Displacement(-16y,-53y)
        Displacement(-15y,53y)
        Displacement(-15y,-53y)
        Displacement(-16y,54y)
        PenUp
        Displacement(81y,-54y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // x
    120us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(71y,53y)
        PenDown
        Displacement(-42y,-53y)
        PenUp
        Displacement(0y,54y)
        PenDown
        Displacement(42y,-54y)
        PenUp
        Displacement(29y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // y
    121us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(26y,-27y)
        PenDown
        Displacement(3y,0y)
        Displacement(7y,4y)
        Displacement(8y,8y)
        Displacement(8y,15y)
        Displacement(23y,53y)
        PenUp
        Displacement(-23y,-53y)
        PenDown
        Displacement(-23y,54y)
        PenUp
        Displacement(71y,-54y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // z
    122us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(29y,53y)
        PenDown
        Displacement(42y,0y)
        Displacement(-42y,-53y)
        Displacement(42y,0y)
        PenUp
        Displacement(29y,0y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // {
    123us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(48y,38y)
        PenDown
        Displacement(8y,8y)
        Displacement(0y,8y)
        Displacement(-4y,7y)
        Displacement(-4y,4y)
        Displacement(-4y,7y)
        Displacement(0y,7y)
        Displacement(3y,8y)
        Displacement(5y,5y)
        Displacement(-4y,-8y)
        Displacement(0y,-8y)
        Displacement(4y,-7y)
        Displacement(3y,-4y)
        Displacement(4y,-8y)
        Displacement(0y,-8y)
        Displacement(-3y,-7y)
        Displacement(-15y,-8y)
        Displacement(15y,-7y)
        Displacement(3y,-8y)
        Displacement(0y,-7y)
        Displacement(-4y,-8y)
        Displacement(-3y,-4y)
        Displacement(-4y,-8y)
        Displacement(0y,-7y)
        Displacement(4y,-8y)
        Displacement(-5y,5y)
        Displacement(-3y,7y)
        Displacement(0y,7y)
        Displacement(4y,8y)
        Displacement(4y,4y)
        Displacement(4y,7y)
        Displacement(0y,8y)
        Displacement(-8y,7y)
        PenUp
        Displacement(4y,62y)
        PenDown
        Displacement(7y,3y)
        PenUp
        Displacement(-7y,-118y)
        PenDown
        Displacement(7y,-4y)
        PenUp
        Displacement(41y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // |
    124us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(50y,95y)
        PenDown
        Displacement(0y,-122y)
        PenUp
        Displacement(50y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // }
    125us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(51y,30y)
        PenDown
        Displacement(-6y,-7y)
        Displacement(0y,-8y)
        Displacement(2y,-7y)
        Displacement(5y,-4y)
        Displacement(4y,-8y)
        Displacement(0y,-8y)
        Displacement(-4y,-7y)
        Displacement(-4y,-4y)
        Displacement(4y,8y)
        Displacement(0y,8y)
        Displacement(-4y,7y)
        Displacement(-3y,3y)
        Displacement(-4y,8y)
        Displacement(0y,8y)
        Displacement(3y,8y)
        Displacement(15y,7y)
        Displacement(-14y,8y)
        Displacement(-4y,7y)
        Displacement(0y,8y)
        Displacement(3y,7y)
        Displacement(4y,5y)
        Displacement(4y,7y)
        Displacement(0y,8y)
        Displacement(-4y,8y)
        Displacement(4y,-4y)
        Displacement(4y,-8y)
        Displacement(0y,-7y)
        Displacement(-4y,-8y)
        Displacement(-4y,-4y)
        Displacement(-3y,-7y)
        Displacement(0y,-8y)
        Displacement(6y,-7y)
        PenUp
        Displacement(-3y,53y)
        PenDown
        Displacement(-7y,3y)
        PenUp
        Displacement(7y,-118y)
        PenDown
        Displacement(-7y,-4y)
        PenUp
        Displacement(59y,27y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    // ~
    126us, [
        PenUp
        // VerticalText(Displacement(-50y,-95y))
        Displacement(16y,31y)
        PenDown
        Displacement(4y,7y)
        Displacement(7y,4y)
        Displacement(8y,0y)
        Displacement(8y,-4y)
        Displacement(14y,-11y)
        Displacement(8y,-4y)
        Displacement(8y,0y)
        Displacement(8y,4y)
        Displacement(3y,11y)
        Displacement(-4y,-8y)
        Displacement(-7y,-3y)
        Displacement(-8y,0y)
        Displacement(-7y,4y)
        Displacement(-16y,11y)
        Displacement(-7y,4y)
        Displacement(-8y,0y)
        Displacement(-8y,-4y)
        Displacement(-3y,-11y)
        Displacement(0y,-8y)
        PenUp
        Displacement(68y,15y)
        PenDown
        Displacement(0y,7y)
        PenUp
        Displacement(16y,-45y)
        // VerticalText(Displacement(-50y,-20y))
        EndOfShape
    ]
    ]
