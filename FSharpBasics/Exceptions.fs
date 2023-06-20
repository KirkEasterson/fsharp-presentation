module Exceptions

// an example of catching an error and returning something else
let divide x y =
    try
        Some(x / y)
    with :? System.DivideByZeroException ->
        printfn "Division by zero!"
        None


exception EqualError of string
exception NotEqualError of string * int // * denotes a tuple

// using custom errors
let makeErrorFunction x y =
    try
        if x = y then
            raise (EqualError("Equal Number Error"))
        else
            raise (NotEqualError("Error Not detected", 100))
    with
    | EqualError(str) -> printfn "Error1 %s" str
    | NotEqualError(str, i) -> printfn "Error2 %s %d" str i



let run args =

    // we handle the error
    let divResult = divide 42 0
    match divResult with
    | Some x -> printfn "%i" x
    | None -> ()

    // the function handles the error
    makeErrorFunction 20 10
    makeErrorFunction 5 5
