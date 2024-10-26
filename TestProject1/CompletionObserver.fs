namespace shpParser

open System

type CompletionObserver<'p>(complete) =
    interface IObserver<'p> with
        member this.OnNext i = ()
        member this.OnError err = ()
        member this.OnCompleted() = complete ()

