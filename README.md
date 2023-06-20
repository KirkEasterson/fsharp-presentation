### Create an F# project

- To create a basic `fsharp` console project, run the following command

```bash
dotnet new console --language "F#" --name MyFsharpBasics --output myfsharp
```

- To create a basic `Fable` project, run the following commands

```bash
dotnet new --install Fable.Template # install the fable template
dotnet new fable --name MyFable # create the fable project
```

## Running the code

- Run `dotnet run` in the directory of each dotnet project. You can also build and run the project:

```bash
dotnet build
./bin/Debug/net7.0/FSharpBasics
```

- To run the `Fable` project, run the followings commands in the `Fable/` directory:

    - *NOTE*: You will need the .NET 6 SDK installed to run this project


```bash
npm install # install node dependencies
npm start
```
