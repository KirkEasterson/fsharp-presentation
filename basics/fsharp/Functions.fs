module Functions

// basic function definition with typing
let add (x: int) (y: int) : int = x + y

// nested function calls
let addTwoVerbose x : int = add 2 x

// curried function
let addTwo = add 2

let printIntVerbose i : unit = printfn "%i" i
let printInt = printfn "%i"

let run args =

    addTwoVerbose 8
    |> printInt

    addTwo 8
    |> printInt
