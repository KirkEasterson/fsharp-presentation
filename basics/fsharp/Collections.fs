module Collections

let array1: array<int> = [| 1; 2; 3; 4 |]
let list1: list<int> = [ 4; 5; 5; 6 ]

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
    |> Array.iter (fun c -> printfn "%i" c)

    Utils.separator ()

    printfn "more functional mapping"
    let addOne i = 1 + i
    let printInt = printfn "%i"
    array1
    |> Array.map addOne
    |> Array.iter printInt

    Utils.separator ()

    printfn "total of all unique elements"
    let add x y = x + y
    let printInt = printfn "%i"
    (Array.toList array1) @ list1
    |> List.distinct
    |> List.fold add 0
    |> printInt

    Utils.separator ()
