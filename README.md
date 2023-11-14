[![NuGet](https://img.shields.io/nuget/v/Ardalis.Extensions.svg)](https://www.nuget.org/packages/Ardalis.Extensions)
[![NuGet](https://img.shields.io/nuget/dt/Ardalis.Extensions.svg)](https://www.nuget.org/packages/Ardalis.Extensions)
[![publish Ardalis.Extensions to nuget](https://github.com/ardalis/Ardalis.Extensions/actions/workflows/publish.yml/badge.svg)](https://github.com/ardalis/Ardalis.Extensions/actions/workflows/publish.yml)

# Ardalis.Extensions
Some random C# extension methods I've found useful. Published as Ardalis.Extensions on Nuget.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
   - [Enumerable](#enumerable)
   - [String checks](#string-checks)
- [Conventions for Contributors](#conventions-for-contributors)
- [Benchmarks](#benchmarks)
- [Roadmap](#roadmap)

## Installation

Just add a reference the the package and then anywhere you want to use the extensions, add the appropriate `using` statement.

```powershell
dotnet add package Ardalis.Extensions
```

## Usage

### Enumerable

RangeEnumerator allows you to loop over a range of integers up to and including the ending value.

```csharp
// replace
for(var i = 0; i <= 10; i++)

// with
foreach(var i in 0..10)
// or
foreach(var i in ..10)
// or 
foreach(var i in 10)
```

### String Checks

IsNull() checks whether a given string is null.

```csharp
// replace
if(someString is null)

// with
if(someString.IsNull())
```

IsNullOrEmpty() checks whether a given string is null or empty.

```csharp
// replace
if(String.IsNullOrEmpty(someString))

// with
if(someString.IsNullOrEmpty())
```

IsNullOrWhiteSpace checks whether a given string is null or empty or consists of only whitespace characters.

```csharp
// replace
if(String.IsNullOrWhiteSpace(someString))

// with
if(someString.IsNullOrWhiteSpace())
```

## Conventions for Contributors

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

To run all of the benchmarks, run the following command from the benchmarks project folder:

```ps
dotnet run -c Release
```

## Roadmap

For now as I gather different useful extensions there is a single [Ardalis.Extensions](https://www.nuget.org/packages/Ardalis.Extensions) package available on NuGet. Once there are more than a few, I will most likely break up the extensions into separate individual NuGet packages (for example: Ardalis.StringExtensions? Ardalis.Extensions.Strings?) and then the original Ardalis.Extensions would become a meta-package that would pull in all of the separate smaller packages.
