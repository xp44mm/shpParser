module DesignTestProject.Program
let [<EntryPoint>] main _ = 
    let shapes = [|
        yield! Design0 .chunk
        yield! Design1 .chunk
        yield! Design2 .chunk
        yield! Design3 .chunk
        yield! Design4 .chunk
        yield! Design5 .chunk
        yield! Design6 .chunk
        yield! Design7 .chunk
        yield! Design8 .chunk
        yield! Design9 .chunk
        yield! Design10.chunk
        yield! Design11.chunk
        yield! Design12.chunk
        yield! Design13.chunk
        yield! Design14.chunk
        yield! Design15.chunk    
        yield! Design16.chunk
        yield! Design17.chunk
        yield! Design18.chunk
        yield! Design19.chunk
    |]
    SHP.fromFSharp(shapes).Wait()
    0
