module Logic

let run args =

    let foo: bool = true
    let bar = false // types can be inferred
    let baz: bool = false

    if (foo && bar) then
        printfn "AND is true"

    if foo || bar then
        printfn "OR is true"

    if bar = baz then
        printfn "bar equals baz"

    // quiz: what will be printed?
    match (foo, bar, baz) with
    | (true, _, false) -> "foo is true, but baz is false"
    | (true, false, _) -> "foo is true, but bar is false"
    | (false, false, false) -> "everything is false"
    | (_, _, _) -> "they all have some values"
    |> printfn "%s"
