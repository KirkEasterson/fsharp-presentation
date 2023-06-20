open System

[<EntryPoint>]
let main args =
    for arg in Environment.GetCommandLineArgs() do
        match arg.ToLower() with
        | "variables" -> Variables.run ()
        | "logic" -> Logic.run ()
        | "functions" -> Functions.run ()
        | "collections" -> Collections.run ()
        | _ -> ()
    0
