module XdxHeirTestProject.Dir

open System.IO

let solutionPath = DirectoryInfo(__SOURCE_DIRECTORY__).Parent.FullName
let outputs = Path.Combine(__SOURCE_DIRECTORY__,"outputs")
