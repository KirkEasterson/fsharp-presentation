module Logic

let run () =

    let foo: bool = true
    let bar = false // types can be inferred
    let baz: bool = false

    if (foo && bar) then
        printfn "AND is true"

    if foo || bar then
        printfn "OR is true"

    if bar = baz then
        printfn "bar equals baz"
