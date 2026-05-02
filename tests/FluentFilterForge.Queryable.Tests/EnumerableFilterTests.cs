using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public sealed class TagEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public OrderEntity Order { get; set; } = null!;
}

public sealed class OrderEntity
{
    public int Id { get; set; }
    public string OrderId { get; set; } = string.Empty;
    public IEnumerable<TagEntity> Tags { get; set; } = [];
}

public sealed class EnumerableFilterTestsDbContext(DbContextOptions<EnumerableFilterTestsDbContext> options) : DbContext(options)
{
    public DbSet<OrderEntity> Orders => Set<OrderEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderEntity>()
            .HasMany(o => o.Tags)
            .WithOne(t => t.Order);
    }
}

public sealed class EnumerableFilterTestsFixture : DatabaseTestsFixture<EnumerableFilterTestsDbContext>
{
    public IEnumerable<(string OrderId, string[] Tags)> SeedData { get; } = [
        ("O2", []),
        ("O3", ["urgent"]),
        ("O4", ["urgent", "review"]),
        ("O5", ["review"]),
        ("O6", ["bulk", "review"]),
    ];

    protected override async Task InitializeAsync(EnumerableFilterTestsDbContext context)
    {
        foreach (var (orderId, tags) in SeedData)
        {
            var order = new OrderEntity
            {
                OrderId = orderId,
                Tags = [.. tags.Select(t => new TagEntity { Name = t })]
            };

            context.Orders.Add(order);
        }

        await context.SaveChangesAsync();
    }
}

public sealed class EnumerableFilterTests(EnumerableFilterTestsFixture fixture) : DatabaseTests<EnumerableFilterTestsDbContext, EnumerableFilterTestsFixture>(fixture)
{
    private readonly EnumerableFilterTestsFixture _fixture = fixture;

    [Fact]
    public async Task IsNullOrEmpty_WhenApplied_ShouldReturnOrdersWithNoTags()
    {
        // Arrange

        var isNullOrEmpty = Filter.For<OrderEntity>()
            .Where(x => x.Tags).IsNullOrEmpty()
            .Build();

        var expected = _fixture.SeedData
            .Where(d => d.Tags.Length == 0)
            .Select(d => d.OrderId);

        // Act

        var actual = await Context.Orders
            .Include(o => o.Tags)
            .Where(isNullOrEmpty)
            .Select(x => x.OrderId)
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task IsNullOrEmpty_WhenNegated_ShouldReturnOrdersWithTags()
    {
        // Arrange

        var hasItems = Filter.For<OrderEntity>()
            .Where(x => x.Tags).Not().IsNullOrEmpty()
            .Build();

        var expected = _fixture.SeedData
            .Where(d => d.Tags.Length > 0)
            .Select(d => d.OrderId);

        // Act

        var actual = await Context.Orders
            .Include(o => o.Tags)
            .Where(hasItems)
            .Select(x => x.OrderId)
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Any_WhenApplied_ShouldReturnOnlyOrdersWithMatchingElement()
    {
        // Arrange

        var hasUrgentTag = Filter.For<OrderEntity>()
            .Where(x => x.Tags).Any(tags => tags
                .Where(t => t.Name).Equal("urgent"))
            .Build();

        var expected = _fixture.SeedData
            .Where(d => d.Tags.Contains("urgent"))
            .Select(d => d.OrderId);

        // Act

        var actual = await Context.Orders
            .Where(hasUrgentTag)
            .Select(x => x.OrderId)
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Any_WhenNegated_ShouldReturnOrdersWithNoMatchingElement()
    {
        // Arrange

        var noUrgentTag = Filter.For<OrderEntity>()
            .Where(x => x.Tags).Not().Any(tags => tags
                .Where(t => t.Name).Equal("urgent"))
            .Build();

        var expected = _fixture.SeedData
            .Where(d => !d.Tags.Contains("urgent"))
            .Select(d => d.OrderId);

        // Act

        var actual = await Context.Orders
            .Where(noUrgentTag)
            .Select(x => x.OrderId)
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task All_WhenApplied_ShouldReturnOnlyOrdersWhereAllElementsMatch()
    {
        // Arrange

        var allReview = Filter.For<OrderEntity>()
            .Where(x => x.Tags).All(tags => tags
                .Where(t => t.Name).Equal("review"))
            .Build();

        var expected = _fixture.SeedData
            .Where(d => d.Tags.All(t => t == "review"))
            .Select(d => d.OrderId);

        // Act

        var actual = await Context.Orders
            .Where(allReview)
            .Select(x => x.OrderId)
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<OrderEntity>()
            .Where(x => x.Tags).Any(tags => tags
                .Where(t => t.Name).Equal("urgent"))
            .And(x => x.Tags).Any(tags => tags
                .Where(t => t.Name).Equal("review"))
            .Build();

        var expected = _fixture.SeedData
            .Where(d =>
                d.Tags.Contains("urgent")
                && d.Tags.Contains("review"))
            .Select(d => d.OrderId);

        // Act

        var actual = await Context.Orders
            .Where(filter)
            .Select(x => x.OrderId)
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<OrderEntity>()
            .Where(x => x.Tags).IsNullOrEmpty()
            .Or(x => x.Tags).Any(tags => tags
                .Where(t => t.Name).Equal("bulk"))
            .Build();

        var expected = _fixture.SeedData
            .Where(d =>
                d.Tags.Length == 0
                || d.Tags.Contains("bulk"))
            .Select(d => d.OrderId);

        // Act

        var actual = await Context.Orders
            .Include(o => o.Tags)
            .Where(filter)
            .Select(x => x.OrderId)
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }
}
