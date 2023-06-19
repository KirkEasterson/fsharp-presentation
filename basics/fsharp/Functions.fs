module Functions

// basic function definition with typing
let add (x: int) (y: int) : int = x + y

// nested function calls
let addTwoVerbose x : int = add 2 x

// curried function
let addTwo = add 2

let run () =

    addTwoVerbose 8
    |> printfn "%i"

    addTwo 8
    |> printfn "%i"
