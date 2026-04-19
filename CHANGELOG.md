# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.0]

### Added

- Fluent filter builder API via `Filter.For<T>()`
- `Where(…).And(…).Or(…)` chaining
- `Not()` negation support (double negation cancels out)
- Nested group conditions via `AndGroup(Action<IFilterBuilder<T>>)` / `OrGroup(Action<IFilterBuilder<T>>)`
- `IEnumerable<T>` extension method `Where(IFilter<T>)`
- `IQueryable<T>` extension method `Where(IFilter<T>)` for server-side evaluation (e.g. Entity Framework Core)
- Strongly-typed property builders for:
  - `bool` / `bool?` — `IsNull`, `IsTrue`, `IsFalse`, `Equal`
  - All numeric types (`sbyte` … `ulong`, `nint`, `nuint`, `BigInteger`, `float`, `double`, `decimal`) — `IsNull`, `Equal`, `GreaterThan`, `GreaterThanOrEqual`, `LessThan`, `LessThanOrEqual`, `Between`, `In`
  - `string?` — `IsNull`, `IsNullOrEmpty`, `IsNullOrWhitespace`, `Equal`, `StartsWith`, `EndsWith`, `Contains`, `In`
  - `char` / `char?` — `IsNull`, `Equal`, `In`
  - `Guid` / `Guid?` — `IsNull`, `Equal`, `StartsWith`, `EndsWith`, `Contains`, `In`
  - `DateTime`, `DateOnly`, `TimeOnly`, `DateTimeOffset`, `TimeSpan` (and nullable variants) — `IsNull`, `Equal`, `GreaterThan`, `GreaterThanOrEqual`, `LessThan`, `LessThanOrEqual`, `Between`, `In`
  - Custom types and enums — `IsNull`, `Equal`
  - `IEnumerable<TElement>` — `IsNull`, `IsNullOrEmpty`, `Equal`, `Any(configure)`, `All(configure)`
