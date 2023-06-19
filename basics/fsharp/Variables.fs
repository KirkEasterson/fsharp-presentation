module Variables

let run () =

    let variable = "value"
    let mutable name: string = "Odo"
    let age: int = 18
    printfn "%s is %d years old!" name age
    name <- "Laas" // assignment operator
    // age <- 20000// not allowed, `age` is not mutable
