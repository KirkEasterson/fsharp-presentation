module Functions

// basic function definition
let add x y = x + y

// nested function calls
let addTwoVerbose x = add 2 x

// curried function
let addTwo = add 2

let run () =

    addTwoVerbose 8
    |> printfn "%i"

    addTwo 8
    |> printfn "%i"
