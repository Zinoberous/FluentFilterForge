using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public class EnumerableFilterTests
{
    private sealed class TagEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public OrderEntity Order { get; set; } = null!;
    }

    private sealed class OrderEntity
    {
        public int Id { get; set; }
        public string OrderId { get; set; } = string.Empty;
        public IEnumerable<TagEntity> Tags { get; set; } = [];
    }

    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<OrderEntity> Orders => Set<OrderEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEntity>()
                .HasMany(o => o.Tags)
                .WithOne(t => t.Order);
        }
    }

    private static readonly (string OrderId, string[] Tags)[] _seedData = [
        ("O2", []),
        ("O3", ["urgent"]),
        ("O4", ["urgent", "review"]),
        ("O5", ["review"]),
        ("O6", ["bulk", "review"]),
    ];

    [Fact]
    public async Task IsNullOrEmpty_WhenApplied_ShouldReturnOrdersWithNoTags()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedOrdersAsync(context);

        var isNullOrEmpty = Filter.For<OrderEntity>()
            .Where(x => x.Tags).IsNullOrEmpty()
            .Build();

        var expected = _seedData
            .Where(d => d.Tags.Length == 0)
            .Select(d => d.OrderId);

        // Act

        var actual = await context.Orders
            .Include(o => o.Tags)
            .Where(isNullOrEmpty)
            .Select(x => x.OrderId)
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task IsNullOrEmpty_WhenNegated_ShouldReturnOrdersWithTags()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedOrdersAsync(context);

        var hasItems = Filter.For<OrderEntity>()
            .Where(x => x.Tags).Not().IsNullOrEmpty()
            .Build();

        var expected = _seedData
            .Where(d => d.Tags.Length > 0)
            .Select(d => d.OrderId);

        // Act

        var actual = await context.Orders
            .Include(o => o.Tags)
            .Where(hasItems)
            .Select(x => x.OrderId)
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Any_WhenApplied_ShouldReturnOnlyOrdersWithMatchingElement()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedOrdersAsync(context);

        var hasUrgentTag = Filter.For<OrderEntity>()
            .Where(x => x.Tags).Any(tags => tags
                .Where(t => t.Name).Equal("urgent"))
            .Build();

        var expected = _seedData
            .Where(d => d.Tags.Contains("urgent"))
            .Select(d => d.OrderId);

        // Act

        var actual = await context.Orders
            .Where(hasUrgentTag)
            .Select(x => x.OrderId)
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Any_WhenNegated_ShouldReturnOrdersWithNoMatchingElement()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedOrdersAsync(context);

        var noUrgentTag = Filter.For<OrderEntity>()
            .Where(x => x.Tags).Not().Any(tags => tags
                .Where(t => t.Name).Equal("urgent"))
            .Build();

        var expected = _seedData
            .Where(d => !d.Tags.Contains("urgent"))
            .Select(d => d.OrderId);

        // Act

        var actual = await context.Orders
            .Where(noUrgentTag)
            .Select(x => x.OrderId)
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task All_WhenApplied_ShouldReturnOnlyOrdersWhereAllElementsMatch()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedOrdersAsync(context);

        var allReview = Filter.For<OrderEntity>()
            .Where(x => x.Tags).All(tags => tags
                .Where(t => t.Name).Equal("review"))
            .Build();

        var expected = _seedData
            .Where(d => d.Tags.All(t => t == "review"))
            .Select(d => d.OrderId);

        // Act

        var actual = await context.Orders
            .Where(allReview)
            .Select(x => x.OrderId)
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

        await SeedOrdersAsync(context);

        var filter = Filter.For<OrderEntity>()
            .Where(x => x.Tags).Any(tags => tags
                .Where(t => t.Name).Equal("urgent"))
            .And(x => x.Tags).Any(tags => tags
                .Where(t => t.Name).Equal("review"))
            .Build();

        var expected = _seedData
            .Where(d =>
                d.Tags.Contains("urgent")
                && d.Tags.Contains("review"))
            .Select(d => d.OrderId);

        // Act

        var actual = await context.Orders
            .Where(filter)
            .Select(x => x.OrderId)
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

        await SeedOrdersAsync(context);

        var filter = Filter.For<OrderEntity>()
            .Where(x => x.Tags).IsNullOrEmpty()
            .Or(x => x.Tags).Any(tags => tags
                .Where(t => t.Name).Equal("bulk"))
            .Build();

        var expected = _seedData
            .Where(d =>
                d.Tags.Length == 0
                || d.Tags.Contains("bulk"))
            .Select(d => d.OrderId);

        // Act

        var actual = await context.Orders
            .Include(o => o.Tags)
            .Where(filter)
            .Select(x => x.OrderId)
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

    private static async Task SeedOrdersAsync(TestDbContext context)
    {
        var id = 1;
        var tagId = 1;

        foreach (var (orderId, tags) in _seedData)
        {
            var order = new OrderEntity
            {
                Id = id++,
                OrderId = orderId,
                Tags = [.. tags.Select(t => new TagEntity { Id = tagId++, Name = t })]
            };

            context.Orders.Add(order);
        }

        await context.SaveChangesAsync();
    }
}
