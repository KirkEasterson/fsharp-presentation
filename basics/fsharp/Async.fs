module Async

open System
open System.IO

let printTotalFileBytesNaive path =
    async {
        let! bytes = File.ReadAllBytesAsync(path) |> Async.AwaitTask
        let fileName = Path.GetFileName(path)
        printfn $"File {fileName} has %d{bytes.Length} bytes"
    }

let printTotalFileBytes path =
    async {
        let! bytes = File.ReadAllBytesAsync(path) |> Async.AwaitTask
        let fileName = Path.GetFileName(path)
        return $"File {fileName} has %d{bytes.Length} bytes"
    }

let run args =

    match args with
    | [||] -> printfn "specify a file to read"

    | files when (files[0] = "naive") -> // naive approach
        printfn "BEFORE"

        files[1..]
        |> Array.map printTotalFileBytesNaive
        |> Async.Parallel
        |> Async.Ignore
        |> Async.RunSynchronously

        printfn "AFTER"

    | files -> // "better" approach
        printfn "BEFORE"

        files
        |> Array.map printTotalFileBytes
        |> Async.Parallel
        |> Async.RunSynchronously
        |> Array.iter (printfn "%s")

        printfn "AFTER"
