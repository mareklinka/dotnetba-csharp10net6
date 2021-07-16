---
theme : "black"
transition: "slide"
highlightTheme: "darkula"
separator: ^---$
verticalSeparator: ^--$
controls: false
progress: false
---

#### .NET BA #32

## What's new in C# 10 and .NET 6

#### by Marek Linka
###### https://github.com/mareklinka/dotnetba-csharp10net6

---

## About me

* Expert software engineer @ ERNI
* Microsoft Certified Expert - Azure Solutions Architect
* Focus on up-and-coming .NET
* CoreFX, ML.NET, DAPR, ASP.NET contributor

----

https://github.com/mareklinka

https://twitter.com/mareklinka

---

## Agenda - C#

* Boilerplate-related features
* Improvements to records
* Improvements to lambdas
* Other improvements

---

## Agenda - .NET

* Cross-platform enhancements
* System.Text.Json
* LINQ
* Date/time/time-zone improvements
* Source-gen
* Other improvements

---

# C# 10

--

## Boilerplate elimination

* C# 10 contains several features aiming to simplify code:
  * Global using statements
  * File-scoped namespaces
  * Simplification of auto-property syntax
  * Automatic null-checks

--

## DEMO

--

## Record structs

* New record syntax: `record class` and `record struct`
* `class` is the default, `struct` is new
  * Caveat: `record struct` is NOT immutable by default
* `with` expression is now allowed for all value types

--

## DEMO

--

## Improvements to lambdas and properties

* Lambdas will support:
  * Attributes
  * Explicit return types
  * [Natural types](https://github.com/dotnet/csharplang/blob/main/proposals/lambda-improvements.md) (no more delegate conversions)
* Properties can be declared as `required`

--

# ["DEMO"](https://github.com/dotnet/csharplang/blob/main/proposals/lambda-improvements.md)

--

## Release schedule

* C# 10 releases with .NET 6, in November
* New versions will release each year
* This should increase the cadence of new features

---

# .NET 6

--

## Cross-platform

* Portable thread-pool
* Apple Silicon support
* Crossgen2
* PGO

--

## System.Text.Json

* Writable DOM
* Zero-reflection de/serialization
* Support for `IAsyncEnumerable`
* `ReferenceHandler.IgnoreCycles`

--

# DEMO

--

## LINQ

* `DistinctBy`/`UnionBy`/`IntersectBy`/`ExceptBy`
* `MaxBy`/`MinBy`
* `Chunk`
* `XOrDefault` now accepts a default value
* Better support for ranges in `ElementAt`/`Take`

--

# DEMO

--

## Date/Time

* Two new structs: `DateOnly`/`TimeOnly`
* Improvements to time-zone support
  * Full support for both IANA and Windows TZ
  * Improvements to TZ name localization

--

# DEMO

--

## Logging source-gen

* A source generator for logging messages
* Increased performance
* More linker-friendly

--

# DEMO

--

## Trimming improvements

* Trim warnings enabled by default
* Large portions of the BCL annotated
  * NOT ASP.NET or WinForms
* Default trim mode = linking

--

## Miscelaneous

* Signifficantly improved `FileStream` perf on Windows ([link](https://devblogs.microsoft.com/dotnet/announcing-net-6-preview-4/#significantly-improved-filestream-performance-on-windows))
* Support for async DI scopes
* New collection - `PriorityQueue`

--

# DEMO

---

# Frameworks and libraries

--

## Entity Framework Core

* Dapper-comparable performance
* 70% faster
* 43% less memory
* 31% query performance

--

## ASP.NET Core

* HTTP 3 support
* HTTP logging middleware
* OpenTelemetry support
* Async streaming
* CSS isolation
* Performance improvements

--

## Other updates

* Hot reload
* .NET MAUI
* Blazor for desktop (with MAUI)
* Blazor AOT compilation, error boundaries, size decrease
* SOCKS proxy support
* Two metric tons of additional stuff

---

# Q&A

--

# Thank you