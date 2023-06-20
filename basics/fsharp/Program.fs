[<EntryPoint>]
let main args =

    for arg in args do
        match arg.ToLower() with
        | "variables" -> Variables.run args[1..]
        | "logic" -> Logic.run args[1..]
        | "functions" -> Functions.run args[1..]
        | "collections" -> Collections.run args[1..]
        | _ -> ()
    0

    // if args.Length < 2 then
    //     printfn "a module must be specified"
    //     return
    //
    // // let kArgs = args[1..]
    // // let rArgs = kArgs[1..]
    //
    // let moduleToRun =
    //     match args[1] with
    //     | "variables" -> Ok Variables.run
    //     | "logic" -> Ok Logic.run
    //     | "functions" -> Ok Functions.run
    //     | "collections" -> Ok Collections.run
    //     | _ -> Error "invalid module"
    //
    // match moduleToRun with
    // | Ok m ->
    //     m.run args[2..]
    //     0
    // | Error m ->
    //     printfn "%s" m
    //     1
