using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public sealed class ProductEntity
{
    public int Id { get; set; }
    public int? Rating { get; set; }
    public int Stock { get; set; }
}

public sealed class NumberFilterTestsDbContext(DbContextOptions<NumberFilterTestsDbContext> options) : DbContext(options)
{
    public DbSet<ProductEntity> Products => Set<ProductEntity>();
}

public sealed record Product(int? Rating, int Stock)
{
    internal static Product Map(ProductEntity entity) => new(entity.Rating, entity.Stock);
}

public sealed class NumberFilterTestsFixture : DatabaseTestsFixture<NumberFilterTestsDbContext>
{
    public IEnumerable<Product> Products { get; } = [
        new(null, 0),
        new(null, 10),
        new(1, 0),
        new(1, 5),
        new(2, 0),
        new(2, 15),
        new(3, 0),
        new(3, 10),
        new(4, 0),
        new(4, 20),
        new(5, 0),
        new(5, 25),
    ];

    protected override async Task InitializeAsync(NumberFilterTestsDbContext context)
    {
        context.Products.AddRange(Products.Select(p => new ProductEntity
        {
            Rating = p.Rating,
            Stock = p.Stock
        }));

        await context.SaveChangesAsync();
    }
}

public sealed class NumberFilterTests(NumberFilterTestsFixture fixture) : DatabaseTests<NumberFilterTestsDbContext, NumberFilterTestsFixture>(fixture)
{
    private readonly NumberFilterTestsFixture _fixture = fixture;

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var isUnrated = Filter.For<ProductEntity>()
            .Where(x => x.Rating).IsNull()
            .Build();

        var expected = _fixture.Products.Where(p => p.Rating == null);

        // Act

        var actual = await Context.Products
            .Where(isUnrated)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(null)]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(int? value)
    {
        // Arrange

        var equalValue = Filter.For<ProductEntity>()
            .Where(x => x.Rating).Equal(value)
            .Build();

        var expected = _fixture.Products.Where(p => p.Rating == value);

        // Act

        var actual = await Context.Products
            .Where(equalValue)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotThree = Filter.For<ProductEntity>()
            .Where(x => x.Rating).Not().Equal(3)
            .Build();

        var expected = _fixture.Products.Where(p => p.Rating != 3);

        // Act

        var actual = await Context.Products
            .Where(isNotThree)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task GreaterThan_WhenApplied_ShouldReturnOnlyGreaterValues()
    {
        // Arrange

        var highlyRated = Filter.For<ProductEntity>()
            .Where(x => x.Rating).GreaterThan(3)
            .Build();

        var expected = _fixture.Products.Where(p => p.Rating > 3);

        // Act

        var actual = await Context.Products
            .Where(highlyRated)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task GreaterThanOrEqual_WhenApplied_ShouldReturnOnlyGreaterOrEqualValues()
    {
        // Arrange

        var goodOrBetter = Filter.For<ProductEntity>()
            .Where(x => x.Rating).GreaterThanOrEqual(4)
            .Build();

        var expected = _fixture.Products.Where(p => p.Rating >= 4);

        // Act

        var actual = await Context.Products
            .Where(goodOrBetter)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task LessThan_WhenApplied_ShouldReturnOnlyLessValues()
    {
        // Arrange

        var poorlyRated = Filter.For<ProductEntity>()
            .Where(x => x.Rating).LessThan(3)
            .Build();

        var expected = _fixture.Products.Where(p => p.Rating < 3);

        // Act

        var actual = await Context.Products
            .Where(poorlyRated)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task LessThanOrEqual_WhenApplied_ShouldReturnOnlyLessOrEqualValues()
    {
        // Arrange

        var belowAverage = Filter.For<ProductEntity>()
            .Where(x => x.Rating).LessThanOrEqual(2)
            .Build();

        var expected = _fixture.Products.Where(p => p.Rating <= 2);

        // Act

        var actual = await Context.Products
            .Where(belowAverage)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Between_WhenApplied_ShouldReturnOnlyValuesInRange()
    {
        // Arrange

        var midRange = Filter.For<ProductEntity>()
            .Where(x => x.Rating).Between(2, 4)
            .Build();

        var expected = _fixture.Products.Where(p => p.Rating >= 2 && p.Rating <= 4);

        // Act

        var actual = await Context.Products
            .Where(midRange)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        int?[] set = [1, 3, 5];

        var inSet = Filter.For<ProductEntity>()
            .Where(x => x.Rating).In(set)
            .Build();

        var expected = _fixture.Products.Where(p => set.Contains(p.Rating));

        // Act

        var actual = await Context.Products
            .Where(inSet)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var highRatedInStock = Filter.For<ProductEntity>()
            .Where(x => x.Rating).GreaterThanOrEqual(4)
            .And(x => x.Stock).GreaterThan(0)
            .Build();

        var expected = _fixture.Products.Where(p =>
            p.Rating >= 4
            && p.Stock > 0);

        // Act

        var actual = await Context.Products
            .Where(highRatedInStock)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var unavailable = Filter.For<ProductEntity>()
            .Where(x => x.Rating).IsNull()
            .Or(x => x.Stock).Equal(0)
            .Build();

        var expected = _fixture.Products.Where(p =>
            p.Rating == null
            || p.Stock == 0);

        // Act

        var actual = await Context.Products
            .Where(unavailable)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task AndNestedOr_WhenApplied_ShouldReturnItemsMatchingAndWithNestedOr()
    {
        // Arrange

        var recommended = Filter.For<ProductEntity>()
            .Where(x => x.Rating).GreaterThanOrEqual(3)
            .AndGroup(products => products
                .Where(x => x.Stock).GreaterThan(0)
                .Or(x => x.Rating).Equal(5))
            .Build();

        var expected = _fixture.Products.Where(p =>
            p.Rating >= 3
            && (p.Stock > 0
                || p.Rating == 5));

        // Act

        var actual = await Context.Products
            .Where(recommended)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task OrNestedAnd_WhenApplied_ShouldReturnItemsMatchingOrWithNestedAnd()
    {
        // Arrange

        var skipListed = Filter.For<ProductEntity>()
            .Where(x => x.Rating).IsNull()
            .OrGroup(products => products
                .Where(x => x.Stock).Equal(0)
                .And(x => x.Rating).GreaterThanOrEqual(3))
            .Build();

        var expected = _fixture.Products.Where(p =>
            p.Rating == null
            || (p.Stock == 0
                && p.Rating >= 3));

        // Act

        var actual = await Context.Products
            .Where(skipListed)
            .Select(x => Product.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }
}
