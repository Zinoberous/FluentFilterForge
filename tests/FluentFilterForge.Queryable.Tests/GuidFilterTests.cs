using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public class GuidFilterTests
{
    private sealed class ItemEntity
    {
        public int Id { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid OwnerId { get; set; }
    }

    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<ItemEntity> Items => Set<ItemEntity>();
    }

    private sealed record Item(Guid? CategoryId, Guid OwnerId)
    {
        internal static Item Map(ItemEntity entity) => new(entity.CategoryId, entity.OwnerId);
    }

    private static readonly Guid _guidA = new("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
    private static readonly Guid _guidB = new("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
    private static readonly Guid _guidC = new("cccccccc-cccc-cccc-cccc-cccccccccccc");
    private static readonly Guid _guidD = new("dddddddd-dddd-dddd-dddd-dddddddddddd");

    private static readonly Item[] _items = [
        new(null, _guidA),
        new(null, _guidB),
        new(_guidA, _guidA),
        new(_guidA, _guidC),
        new(_guidB, _guidB),
        new(_guidC, _guidD),
    ];

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedItemsAsync(context);

        var isNull = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).IsNull()
            .Build();

        var expected = _items.Where(i => i.CategoryId == null);

        // Act

        var actual = await context.Items
            .Where(isNull)
            .Select(x => Item.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedItemsAsync(context);

        var equalValue = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).Equal(_guidA)
            .Build();

        var expected = _items.Where(i => i.CategoryId == _guidA);

        // Act

        var actual = await context.Items
            .Where(equalValue)
            .Select(x => Item.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedItemsAsync(context);

        var isNotA = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).Not().Equal(_guidA)
            .Build();

        var expected = _items.Where(i => i.CategoryId != _guidA);

        // Act

        var actual = await context.Items
            .Where(isNotA)
            .Select(x => Item.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task StartsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedItemsAsync(context);

        var startsWithA = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).StartsWith("aaaa")
            .Build();

        var expected = _items.Where(i => i.CategoryId?.ToString().StartsWith("aaaa") == true);

        // Act

        var actual = await context.Items
            .Where(startsWithA)
            .Select(x => Item.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task EndsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedItemsAsync(context);

        var endsWithB = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).EndsWith("bbbbbbbb")
            .Build();

        var expected = _items.Where(i => i.CategoryId?.ToString().EndsWith("bbbbbbbb") == true);

        // Act

        var actual = await context.Items
            .Where(endsWithB)
            .Select(x => Item.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Contains_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedItemsAsync(context);

        var containsC = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).Contains("cccc-cccc")
            .Build();

        var expected = _items.Where(i => i.CategoryId?.ToString().Contains("cccc-cccc") == true);

        // Act

        var actual = await context.Items
            .Where(containsC)
            .Select(x => Item.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedItemsAsync(context);

        Guid?[] set = [_guidA, _guidC];

        var inSet = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).In(set)
            .Build();

        var expected = _items.Where(i => set.Contains(i.CategoryId));

        // Act

        var actual = await context.Items
            .Where(inSet)
            .Select(x => Item.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedItemsAsync(context);

        var filter = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).Equal(_guidA)
            .And(x => x.OwnerId).Equal(_guidA)
            .Build();

        var expected = _items.Where(i =>
            i.CategoryId == _guidA
            && i.OwnerId == _guidA);

        // Act

        var actual = await context.Items
            .Where(filter)
            .Select(x => Item.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedItemsAsync(context);

        var filter = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).IsNull()
            .Or(x => x.OwnerId).Equal(_guidD)
            .Build();

        var expected = _items.Where(i =>
            i.CategoryId == null
            || i.OwnerId == _guidD);

        // Act

        var actual = await context.Items
            .Where(filter)
            .Select(x => Item.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    private static async Task<SqliteConnection> CreateOpenConnectionAsync()
    {
        SqliteConnection connection = new("Data Source=:memory:");
        await connection.OpenAsync();

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

    private static async Task SeedItemsAsync(TestDbContext context)
    {
        context.Items.AddRange(_items.Select((item, i) => new ItemEntity
        {
            Id = i + 1,
            CategoryId = item.CategoryId,
            OwnerId = item.OwnerId
        }));

        await context.SaveChangesAsync();
    }
}
