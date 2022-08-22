[![NuGet](https://img.shields.io/nuget/v/Ardalis.Extensions.svg)](https://www.nuget.org/packages/Ardalis.Extensions)
[![NuGet](https://img.shields.io/nuget/dt/Ardalis.Extensions.svg)](https://www.nuget.org/packages/Ardalis.Extensions)
[![publish Ardalis.Extensions to nuget](https://github.com/ardalis/Ardalis.Extensions/actions/workflows/publish.yml/badge.svg)](https://github.com/ardalis/Ardalis.Extensions/actions/workflows/publish.yml)

# Ardalis.Extensions
Some random C# extension methods I've found useful. Published as Ardalis.Extensions on Nuget.


## Conventions

- Extension methods are grouped into folders based on similar purpose.
- Folder nesting should match class namespaces.
  - `Ardalis.Extensions.Parsing`
  -  `Ardalis.Extensions.Encoding.Base64`
- One extension method class per folder.
- Extension methods classes should have an `Extensions` suffix.
- Classes should be made [partial](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods#partial-classes).
- One extension method per file.
- Overloads should be placed in the same file.
- File names should be the contained extension method's name.
- Tests should be provided for each extension method and overload.
- Test classes should have a `Tests` suffix.
- Benchmark classe should have a `Benchmarks` suffix.

## Benchmarks

To run the all of the benchmarks, run the following command from the benchmarks project folder:

```ps
dotnet run -c Release
```

## Roadmap

For now as I gather different useful extensions there is a single [Ardalis.Extensions](https://www.nuget.org/packages/Ardalis.Extensions) package available on NuGet. Once there are more than a few, I will most likely break up the extensions into separate individual NuGet packages (for example: Ardalis.StringExtensions? Ardalis.Extensions.Strings?) and then the original Ardalis.Extensions would become a meta-package that would pull in all of the separate smaller packages.
