using FluentAssertions;
using FluentFilterForge.Extensions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public class BoolFilterTests
{
    private sealed class BoolValueEntity
    {
        public int Id { get; set; }

        public bool? Value { get; set; }
    }

    private sealed class CustomerEntity
    {
        public int Id { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsVerified { get; set; }
    }

    private sealed record BoolValueResult(int Id, bool? Value);

    private sealed record CustomerResult(int Id, bool? IsActive, bool? IsVerified);

    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<BoolValueEntity> BoolValues => Set<BoolValueEntity>();

        public DbSet<CustomerEntity> Customers => Set<CustomerEntity>();
    }

    [Fact]
    public void IsTrue_WhenApplied_ShouldReturnOnlyTrueValues()
    {
        // Arrange

        using var connection = CreateOpenConnection();
        using var context = CreateContext(connection);

        context.BoolValues.AddRange(
            new() { Id = 1, Value = true },
            new() { Id = 2, Value = false },
            new() { Id = 3, Value = null },
            new() { Id = 4, Value = true });

        context.SaveChanges();

        var filter = Filter.For<BoolValueEntity>()
            .Where(x => x.Value)
            .IsTrue()
            .Build();

        IEnumerable<BoolValueResult> expected = [
            new(1, true),
            new(4, true)
        ];

        // Act

        var actual = context.BoolValues
            .Where(filter)
            .OrderBy(x => x.Id)
            .Select(x => new BoolValueResult(x.Id, x.Value))
            .ToList();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void IsFalse_WhenApplied_ShouldReturnOnlyFalseValues()
    {
        // Arrange

        using var connection = CreateOpenConnection();
        using var context = CreateContext(connection);

        context.BoolValues.AddRange(
            new() { Id = 1, Value = true },
            new() { Id = 2, Value = false },
            new() { Id = 3, Value = null },
            new() { Id = 4, Value = false });

        context.SaveChanges();

        var filter = Filter.For<BoolValueEntity>()
            .Where(x => x.Value)
            .IsFalse()
            .Build();

        IEnumerable<BoolValueResult> expected = [
            new(2, false),
            new(4, false)
        ];

        // Act

        var actual = context.BoolValues
            .Where(filter)
            .OrderBy(x => x.Id)
            .Select(x => new BoolValueResult(x.Id, x.Value))
            .ToList();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        using var connection = CreateOpenConnection();
        using var context = CreateContext(connection);

        context.BoolValues.AddRange(
            new() { Id = 1, Value = true },
            new() { Id = 2, Value = false },
            new() { Id = 3, Value = null },
            new() { Id = 4, Value = null });

        context.SaveChanges();

        var filter = Filter.For<BoolValueEntity>()
            .Where(x => x.Value)
            .IsNull()
            .Build();

        IEnumerable<BoolValueResult> expected = [
            new(3, null),
            new(4, null)
        ];

        // Act

        var actual = context.BoolValues
            .Where(filter)
            .OrderBy(x => x.Id)
            .Select(x => new BoolValueResult(x.Id, x.Value))
            .ToList();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsTrue_ShouldReturnOnlyTrueValues()
    {
        // Arrange

        using var connection = CreateOpenConnection();
        using var context = CreateContext(connection);

        context.BoolValues.AddRange(
            new() { Id = 1, Value = true },
            new() { Id = 2, Value = false },
            new() { Id = 3, Value = null },
            new() { Id = 4, Value = true });

        context.SaveChanges();

        var filter = Filter.For<BoolValueEntity>()
            .Where(x => x.Value)
            .Equal(true)
            .Build();

        IEnumerable<BoolValueResult> expected = [
            new(1, true),
            new(4, true)
        ];

        // Act

        var actual = context.BoolValues
            .Where(filter)
            .OrderBy(x => x.Id)
            .Select(x => new BoolValueResult(x.Id, x.Value))
            .ToList();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsFalse_ShouldReturnOnlyFalseValues()
    {
        // Arrange

        using var connection = CreateOpenConnection();
        using var context = CreateContext(connection);

        context.BoolValues.AddRange(
            new() { Id = 1, Value = true },
            new() { Id = 2, Value = false },
            new() { Id = 3, Value = null },
            new() { Id = 4, Value = false });

        context.SaveChanges();

        var filter = Filter.For<BoolValueEntity>()
            .Where(x => x.Value)
            .Equal(false)
            .Build();

        IEnumerable<BoolValueResult> expected = [
            new(2, false),
            new(4, false)
        ];

        // Act

        var actual = context.BoolValues
            .Where(filter)
            .OrderBy(x => x.Id)
            .Select(x => new BoolValueResult(x.Id, x.Value))
            .ToList();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsNull_ShouldReturnOnlyNullValues()
    {
        // Arrange

        using var connection = CreateOpenConnection();
        using var context = CreateContext(connection);

        context.BoolValues.AddRange(
            new() { Id = 1, Value = true },
            new() { Id = 2, Value = false },
            new() { Id = 3, Value = null },
            new() { Id = 4, Value = null });

        context.SaveChanges();

        var filter = Filter.For<BoolValueEntity>()
            .Where(x => x.Value)
            .Equal(null)
            .Build();

        IEnumerable<BoolValueResult> expected = [
            new(3, null),
            new(4, null)
        ];

        // Act

        var actual = context.BoolValues
            .Where(filter)
            .OrderBy(x => x.Id)
            .Select(x => new BoolValueResult(x.Id, x.Value))
            .ToList();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        using var connection = CreateOpenConnection();
        using var context = CreateContext(connection);

        context.BoolValues.AddRange(
            new() { Id = 1, Value = true },
            new() { Id = 2, Value = false },
            new() { Id = 3, Value = null });

        context.SaveChanges();

        var filter = Filter.For<BoolValueEntity>()
            .Where(x => x.Value)
            .Not()
            .Equal(true)
            .Build();

        IEnumerable<BoolValueResult> expected = [
            new(2, false),
            new(3, null)
        ];

        // Act

        var actual = context.BoolValues
            .Where(filter)
            .OrderBy(x => x.Id)
            .Select(x => new BoolValueResult(x.Id, x.Value))
            .ToList();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        using var connection = CreateOpenConnection();
        using var context = CreateContext(connection);

        context.Customers.AddRange(
            new() { Id = 1, IsActive = true, IsVerified = true },
            new() { Id = 2, IsActive = true, IsVerified = false },
            new() { Id = 3, IsActive = false, IsVerified = true },
            new() { Id = 4, IsActive = null, IsVerified = true });

        context.SaveChanges();

        var filter = Filter.For<CustomerEntity>()
            .Where(x => x.IsActive).IsTrue()
            .And(x => x.IsVerified).IsTrue()
            .Build();

        IEnumerable<CustomerResult> expected = [new(1, true, true)];

        // Act

        var actual = context.Customers
            .Where(filter)
            .OrderBy(x => x.Id)
            .Select(x => new CustomerResult(x.Id, x.IsActive, x.IsVerified))
            .ToList();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        using var connection = CreateOpenConnection();
        using var context = CreateContext(connection);

        context.Customers.AddRange(
            new() { Id = 1, IsActive = true, IsVerified = true },
            new() { Id = 2, IsActive = true, IsVerified = false },
            new() { Id = 3, IsActive = false, IsVerified = true },
            new() { Id = 4, IsActive = false, IsVerified = false },
            new() { Id = 5, IsActive = null, IsVerified = null });

        context.SaveChanges();

        var filter = Filter.For<CustomerEntity>()
            .Where(x => x.IsActive).IsTrue()
            .Or(x => x.IsVerified).IsTrue()
            .Build();

        IEnumerable<CustomerResult> expected = [
            new(1, true, true),
            new(2, true, false),
            new(3, false, true)
        ];

        // Act

        var actual = context.Customers
            .Where(filter)
            .OrderBy(x => x.Id)
            .Select(x => new CustomerResult(x.Id, x.IsActive, x.IsVerified))
            .ToList();

        // Assert

        actual.Should().Equal(expected);
    }

    private static SqliteConnection CreateOpenConnection()
    {
        SqliteConnection connection = new("Data Source=:memory:");
        connection.Open();

        return connection;
    }

    private static TestDbContext CreateContext(SqliteConnection connection)
    {
        var options = new DbContextOptionsBuilder<TestDbContext>()
            .UseSqlite(connection)
            .Options;

        TestDbContext context = new(options);
        context.Database.EnsureCreated();

        return context;
    }
}
