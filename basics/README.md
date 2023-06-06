There exists projects for the sake of this demonstration. But if you want to create your own follow the instructions below.

### Create your own projects

To create a basic `fsharp` console project, run the following command

```bash
dotnet new console --language "F#" --name FsharpBasics --output myfsharp
```

To create a basic `csharp` console project, run the following command

```bash
dotnet new console --language "C#" --name CsharpBasics --output mycsharp
```

## Running the code

Run `dotnet run` in the directory of each dotnet project. You can also build and run the project:

```bash
dotnet build
./bin/Debug/net7.0/[F|C]sharpBasics
```
