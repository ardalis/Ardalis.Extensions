[![NuGet](https://img.shields.io/nuget/v/Ardalis.Extensions.svg)](https://www.nuget.org/packages/Ardalis.Extensions)
[![NuGet](https://img.shields.io/nuget/dt/Ardalis.Extensions.svg)](https://www.nuget.org/packages/Ardalis.Extensions)
[![publish Ardalis.Extensions to nuget](https://github.com/ardalis/Ardalis.Extensions/actions/workflows/publish.yml/badge.svg)](https://github.com/ardalis/Ardalis.Extensions/actions/workflows/publish.yml)

# Ardalis.Extensions
Some random C# extension methods I've found useful. Published as Ardalis.Extensions on Nuget.


## Conventions

Methods that go together or have a common purpose should be placed into their own separate file named accordingly. All classes that have extension methods in them should have an `Extensions` suffix. Only one class per file.

## Roadmap

For now as I gather different useful extensions there is a single [Ardalis.Extensions](https://www.nuget.org/packages/Ardalis.Extensions) package available on NuGet. Once there are more than a few, I will most likely break up the extensions into separate individual NuGet packages (for example: Ardalis.StringExtensions? Ardalis.Extensions.Strings?) and then the original Ardalis.Extensions would become a meta-package that would pull in all of the separate smaller packages.
