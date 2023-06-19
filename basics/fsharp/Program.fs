open System

for arg in Environment.GetCommandLineArgs() do
    match arg with
    | "var" -> Variables.run ()
    | "logic" -> Logic.run ()
    | "functions" -> Functions.run ()
    | _ -> ()
