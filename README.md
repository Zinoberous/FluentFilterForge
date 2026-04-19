# FluentFilterForge

[![NuGet](https://img.shields.io/nuget/v/FluentFilterForge)](https://www.nuget.org/packages/FluentFilterForge)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A strongly-typed, fluent filter builder for .NET. Build composable, null-safe filter predicates using a readable API and apply them to any `IEnumerable<T>` or `IQueryable<T>` source.

## Features

- **Fluent API** – chain `Where(…).And(…).Or(…)` conditions naturally
- **Type-safe** – dedicated builders for `bool`, numbers, `string`, `char`, `Guid`, date/time types, enums, and collections
- **Negation** – call `.Not()` before any condition to invert it
- **Nested groups** – pass a delegate to `And(…)` / `Or(…)` to create grouped sub-conditions
- **Collection filters** – `Any(…)` and `All(…)` with a full sub-filter on element level
- **IQueryable support** – expressions are handed directly to the query provider (e.g. Entity Framework Core) for server-side evaluation

## Installation

```
dotnet add package FluentFilterForge
```

## Quick start

```csharp
using FluentFilterForge.Extensions;

var filter = Filter.For<Product>()
    .Where(p => p.Price).GreaterThanOrEqual(10m)
    .And(p => p.Name).StartsWith("Pro")
    .And(p => p.IsActive).IsTrue()
    .Build();

// IEnumerable<T>
var results = products.Where(filter).ToList();

// IQueryable<T> (e.g. Entity Framework Core)
var results = await dbContext.Products.Where(filter).ToListAsync();
```

## Supported operators

### Boolean (`bool` / `bool?`)
| Method | Description |
|---|---|
| `IsNull()` | Property is `null` |
| `IsTrue()` | Property is `true` |
| `IsFalse()` | Property is `false` |
| `Equal(bool?)` | Property equals value |
| `Not()` | Negates the next condition |

### Numbers (`int`, `long`, `decimal`, `double`, … and their nullable counterparts)
| Method | Description |
|---|---|
| `IsNull()` | Property is `null` |
| `Equal(TNumber?)` | Property equals value |
| `GreaterThan(TNumber)` | Property > value |
| `GreaterThanOrEqual(TNumber)` | Property >= value |
| `LessThan(TNumber)` | Property < value |
| `LessThanOrEqual(TNumber)` | Property <= value |
| `Between(from, to)` | Property is within \[from, to\] (inclusive) |
| `In(params TNumber?[])` | Property matches one of the values |
| `Not()` | Negates the next condition |

### String (`string?`)
| Method | Description |
|---|---|
| `IsNull()` | Property is `null` |
| `IsNullOrEmpty()` | Property is `null` or `""` |
| `IsNullOrWhitespace()` | Property is `null`, empty, or whitespace |
| `Equal(string?)` | Property equals value (case-sensitive) |
| `StartsWith(string)` | Property starts with value |
| `EndsWith(string)` | Property ends with value |
| `Contains(string)` | Property contains value |
| `In(params string?[])` | Property matches one of the values |
| `Not()` | Negates the next condition |

### Guid (`Guid` / `Guid?`)
| Method | Description |
|---|---|
| `IsNull()` | Property is `null` |
| `Equal(Guid?)` | Property equals value |
| `StartsWith(string)` | String representation starts with value |
| `EndsWith(string)` | String representation ends with value |
| `Contains(string)` | String representation contains value |
| `In(params Guid?[])` | Property matches one of the values |
| `Not()` | Negates the next condition |

### Date/time types (`DateTime`, `DateOnly`, `TimeOnly`, `DateTimeOffset`, `TimeSpan` and nullable variants)
| Method | Description |
|---|---|
| `IsNull()` | Property is `null` |
| `Equal(TDateTime?)` | Property equals value |
| `GreaterThan(TDateTime)` | Property is after value |
| `GreaterThanOrEqual(TDateTime)` | Property is value or later |
| `LessThan(TDateTime)` | Property is before value |
| `LessThanOrEqual(TDateTime)` | Property is value or earlier |
| `Between(from, to)` | Property falls within \[from, to\] (inclusive) |
| `In(params TDateTime?[])` | Property matches one of the values |
| `Not()` | Negates the next condition |

### Custom types and enums
| Method | Description |
|---|---|
| `IsNull()` | Property is `null` |
| `Equal(TProperty?)` | Property equals value |
| `Not()` | Negates the next condition |

### Collections (`IEnumerable<TElement>`)
| Method | Description |
|---|---|
| `IsNull()` | Collection is `null` |
| `IsNullOrEmpty()` | Collection is `null` or has no elements |
| `Equal(IEnumerable<TElement>?)` | Collection reference equals value |
| `Any(configure)` | At least one element matches the sub-filter |
| `All(configure)` | All elements match the sub-filter |
| `Not()` | Negates the next condition |

## Negation

Call `.Not()` directly after `.Where(…)` before specifying the condition:

```csharp
var filter = Filter.For<Order>()
    .Where(o => o.Status).Not().Equal(OrderStatus.Cancelled)
    .And(o => o.Total).Not().LessThan(50m)
    .Build();
```

## Grouped sub-conditions

Pass a delegate to `And(…)` or `Or(…)` to create a nested group:

```csharp
var filter = Filter.For<Product>()
    .Where(p => p.IsActive).IsTrue()
    .And(nested => nested
        .Where(p => p.Category).Equal("Electronics")
        .Or(p => p.Category).Equal("Computers"))
    .Build();
// → IsActive == true AND (Category == "Electronics" OR Category == "Computers")
```

## Collection sub-filters

```csharp
var filter = Filter.For<Order>()
    .Where(o => o.Tags).Any(tags => tags
        .Where(tag => tag).Equal("priority"))
    .Build();
```

## Using with Entity Framework Core

`IFilter<T>` produces an `Expression<Func<T, bool>>` via `ToExpression()`, which EF Core translates to SQL:

```csharp
var filter = Filter.For<Customer>()
    .Where(c => c.Country).Equal("DE")
    .And(c => c.CreatedAt).GreaterThanOrEqual(DateTime.UtcNow.AddYears(-1))
    .Build();

var customers = await dbContext.Customers
    .Where(filter)
    .OrderBy(c => c.Name)
    .ToListAsync();
```

## License

MIT
