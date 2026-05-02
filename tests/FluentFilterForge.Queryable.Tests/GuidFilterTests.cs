using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public sealed class ItemEntity
{
    public int Id { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid OwnerId { get; set; }
}

public sealed class GuidFilterTestsDbContext(DbContextOptions<GuidFilterTestsDbContext> options) : DbContext(options)
{
    public DbSet<ItemEntity> Items => Set<ItemEntity>();
}

public sealed record Item(Guid? CategoryId, Guid OwnerId)
{
    internal static Item Map(ItemEntity entity) => new(entity.CategoryId, entity.OwnerId);
}

public sealed class GuidFilterTestsFixture : DatabaseTestsFixture<GuidFilterTestsDbContext>
{
    private static readonly Guid _guidA = new("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
    private static readonly Guid _guidB = new("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
    private static readonly Guid _guidC = new("cccccccc-cccc-cccc-cccc-cccccccccccc");
    private static readonly Guid _guidD = new("dddddddd-dddd-dddd-dddd-dddddddddddd");

    public Guid GuidA { get; } = _guidA;
    public Guid GuidB { get; } = _guidB;
    public Guid GuidC { get; } = _guidC;
    public Guid GuidD { get; } = _guidD;

    public IEnumerable<Item> Items { get; } = [
        new(null, _guidA),
        new(null, _guidB),
        new(_guidA, _guidA),
        new(_guidA, _guidC),
        new(_guidB, _guidB),
        new(_guidC, _guidD),
    ];

    protected override async Task InitializeAsync(GuidFilterTestsDbContext context)
    {
        context.Items.AddRange(Items.Select(item => new ItemEntity
        {
            CategoryId = item.CategoryId,
            OwnerId = item.OwnerId
        }));

        await context.SaveChangesAsync();
    }
}

public sealed class GuidFilterTests(GuidFilterTestsFixture fixture) : DatabaseTests<GuidFilterTestsDbContext, GuidFilterTestsFixture>(fixture)
{
    private readonly GuidFilterTestsFixture _fixture = fixture;

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var isNull = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).IsNull()
            .Build();

        var expected = _fixture.Items.Where(i => i.CategoryId == null);

        // Act

        var actual = await Context.Items
            .Where(isNull)
            .Select(x => Item.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var equalValue = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).Equal(_fixture.GuidA)
            .Build();

        var expected = _fixture.Items.Where(i => i.CategoryId == _fixture.GuidA);

        // Act

        var actual = await Context.Items
            .Where(equalValue)
            .Select(x => Item.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotA = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).Not().Equal(_fixture.GuidA)
            .Build();

        var expected = _fixture.Items.Where(i => i.CategoryId != _fixture.GuidA);

        // Act

        var actual = await Context.Items
            .Where(isNotA)
            .Select(x => Item.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task StartsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var startsWithA = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).StartsWith("aaaa")
            .Build();

        var expected = _fixture.Items.Where(i => i.CategoryId?.ToString().StartsWith("aaaa") == true);

        // Act

        var actual = await Context.Items
            .Where(startsWithA)
            .Select(x => Item.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task EndsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var endsWithB = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).EndsWith("bbbbbbbb")
            .Build();

        var expected = _fixture.Items.Where(i => i.CategoryId?.ToString().EndsWith("bbbbbbbb") == true);

        // Act

        var actual = await Context.Items
            .Where(endsWithB)
            .Select(x => Item.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Contains_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var containsC = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).Contains("cccc-cccc")
            .Build();

        var expected = _fixture.Items.Where(i => i.CategoryId?.ToString().Contains("cccc-cccc") == true);

        // Act

        var actual = await Context.Items
            .Where(containsC)
            .Select(x => Item.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        Guid?[] set = [_fixture.GuidA, _fixture.GuidC];

        var inSet = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).In(set)
            .Build();

        var expected = _fixture.Items.Where(i => set.Contains(i.CategoryId));

        // Act

        var actual = await Context.Items
            .Where(inSet)
            .Select(x => Item.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).Equal(_fixture.GuidA)
            .And(x => x.OwnerId).Equal(_fixture.GuidA)
            .Build();

        var expected = _fixture.Items.Where(i =>
            i.CategoryId == _fixture.GuidA
            && i.OwnerId == _fixture.GuidA);

        // Act

        var actual = await Context.Items
            .Where(filter)
            .Select(x => Item.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<ItemEntity>()
            .Where(x => x.CategoryId).IsNull()
            .Or(x => x.OwnerId).Equal(_fixture.GuidD)
            .Build();

        var expected = _fixture.Items.Where(i =>
            i.CategoryId == null
            || i.OwnerId == _fixture.GuidD);

        // Act

        var actual = await Context.Items
            .Where(filter)
            .Select(x => Item.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }
}
