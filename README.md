# FluentFilterForge

A fluent, strongly typed filter builder for .NET.

Build filters once and apply them to:
- IEnumerable (in-memory collections)
- IQueryable (e.g. Entity Framework Core)

---

## ✨ Goals

FluentFilterForge aims to provide:

- Strongly typed filters (no magic strings)
- A clean and fluent API
- Support for LINQ and Entity Framework Core
- Reusable filter definitions
- Easy testing and debugging

---

## 🚀 Example (planned API)

```csharp
var filter = Filter.For<Customer>()
    .Where(x => x.Name).Contains("Alex")
    .And(x => x.Age).GreaterThanOrEqual(18);

var customers = await context.Customers
    .Apply(filter)
    .ToListAsync();