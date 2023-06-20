module Collections

let array1: array<int> = [| 1; 2; 3; 4 |]
let list1: list<int> = [ 4; 5; 5; 6 ]
let pets = [ "dog"; "cat"; "pig"; "chicken"; "parrot" ]


let add x y = x + y
let addOne = add 1
let isOdd i = i % 2 = 1
let printInt = printfn "%i"

let run args =

    Utils.separator ()

    printfn "accessing collections items"
    printfn "%i" array1[0]

    Utils.separator ()

    printfn "basic iterating an array"

    for i in array1 do
        printfn "%i" i

    Utils.separator ()

    printfn "functional iteratinon of an array"
    array1
    |> Array.iter (fun c -> printfn "%i" c)

    printfn "functional iteratinon of a list"
    list1
    |> List.iter (fun c -> printfn "%i" c)

    Utils.separator ()

    printfn "mapping an array"
    array1
    |> Array.map (fun i -> i + 1)
    |> Array.filter (fun i -> i % 2 = 1)
    |> Array.iter (fun c -> printfn "%i" c)

    Utils.separator ()

    printfn "more functional mapping"
    array1
    |> Array.map addOne
    |> Array.filter isOdd
    |> Array.iter printInt

    Utils.separator ()

    printfn "total of all unique elements"
    (Array.toList array1) @ list1
    |> List.distinct
    |> List.fold add 0
    |> printInt

    Utils.separator ()

    match args with
    | [||] -> printfn "pass a pet to try the last section"
    | rArgs ->
        pets
        |> List.tryFind args[0].Equals
        |> Option.map (fun pet -> sprintf "%s is a pet!" pet)
        |> Option.defaultWith (fun () -> sprintf "%s is not a pet" args[0])
        |> printfn "%s"
