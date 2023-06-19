module Variables

let run () =

    printfn "Hello, World!"

    // initializing variables
    let variable = "value"
    let mutable name: string = "Odo"
    let age: int = 18

    // printing
    printfn "%s is %d years old!" name age

    // quiz: why isn't this allowed
    // printfn name

    // assigning to a mutable variable
    name <- "Laas"

    // immutable variables cannot be reassigned
    // age <- 20000
