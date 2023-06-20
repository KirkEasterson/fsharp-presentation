[<EntryPoint>]
let main args =

    for arg in args do
        match arg.ToLower() with
        | "variables" -> Variables.run args
        | "logic" -> Logic.run args
        | "functions" -> Functions.run args
        | "collections" -> Collections.run args
        | _ -> ()
    0
