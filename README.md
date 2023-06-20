### Create an F# project

- To create a basic `fsharp` console project, run the following command:

    - https://learn.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-command-line

```bash
dotnet new console --language "F#" --name MyFsharpBasics --output myfsharp
```

- To create a basic `Fable` project, run the following commands:

    - https://fable.io/docs/2-steps/your-first-fable-project.html

```bash
dotnet new --install Fable.Template # install the fable template
dotnet new fable --name MyFable # create the fable project
```

- To create a `Fable React` project, run the following commands:

    - https://zaid-ajaj.github.io/Feliz/

```bash
dotnet new --install Feliz.Template # install the fable template
dotnet new feliz --name MyFeliz # create the fable project
```

## Running the code

- Run `dotnet run` in the directory of each dotnet project. You can also build and run the project:

```bash
dotnet build
./bin/Debug/net7.0/FSharpBasics
```

- To run the `Fable` projects, run the followings commands in the `Fable/` directory:

    - *NOTE*: You will need the .NET 6 SDK installed to run these projects


```bash
npm install
npm start
```
