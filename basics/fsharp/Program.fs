[<EntryPoint>]
let main args =

    for arg in args do
        match arg.ToLower() with
        | "variables" -> Variables.run args[1..]
        | "logic" -> Logic.run args[1..]
        | "functions" -> Functions.run args[1..]
        | "collections" -> Collections.run args[1..]
        | "records" -> Records.run args[1..]
        | _ -> ()
    0
