using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public class NumberFilterTests
{
    private sealed class ProductEntity
    {
        public int Id { get; set; }
        public int? Rating { get; set; }
        public int Stock { get; set; }
    }

    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<ProductEntity> Products => Set<ProductEntity>();
    }

    private sealed record Product(int? Rating, int Stock)
    {
        internal static Product Map(ProductEntity entity) => new(entity.Rating, entity.Stock);
    }

    private static readonly Product[] _products = [
        new(null, 0),       // unrated, out of stock
        new(null, 10),      // unrated, in stock
        new(1, 0),          // poor, out of stock
        new(1, 5),          // poor, in stock
        new(2, 0),          // below average, out of stock
        new(2, 15),         // below average, in stock
        new(3, 0),          // average, out of stock
        new(3, 10),         // average, in stock
        new(4, 0),          // good, out of stock
        new(4, 20),         // good, in stock
        new(5, 0),          // excellent, out of stock
        new(5, 25),         // excellent, in stock
    ];

    private static void SeedProducts(TestDbContext context)
    {
        context.Products.AddRange(_products.Select((p, i) => new ProductEntity
        {
            Id = i + 1,
            Rating = p.Rating,
            Stock = p.Stock
        }));

        context.SaveChanges();
    }

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var isUnrated = Filter.For<ProductEntity>()
            .Where(x => x.Rating).IsNull()
            .Build();

        var expected = _products.Where(p => p.Rating == null);

        // Act

        var actual = await context.Products
            .Where(isUnrated)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(null)]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(int? value)
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var equalValue = Filter.For<ProductEntity>()
            .Where(x => x.Rating).Equal(value)
            .Build();

        var expected = _products.Where(p => p.Rating == value);

        // Act

        var actual = await context.Products
            .Where(equalValue)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var isNotThree = Filter.For<ProductEntity>()
            .Where(x => x.Rating).Not().Equal(3)
            .Build();

        var expected = _products.Where(p => p.Rating != 3);

        // Act

        var actual = await context.Products
            .Where(isNotThree)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task GreaterThan_WhenApplied_ShouldReturnOnlyGreaterValues()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var highlyRated = Filter.For<ProductEntity>()
            .Where(x => x.Rating).GreaterThan(3)
            .Build();

        var expected = _products.Where(p => p.Rating > 3);

        // Act

        var actual = await context.Products
            .Where(highlyRated)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task GreaterThanOrEqual_WhenApplied_ShouldReturnOnlyGreaterOrEqualValues()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var goodOrBetter = Filter.For<ProductEntity>()
            .Where(x => x.Rating).GreaterThanOrEqual(4)
            .Build();

        var expected = _products.Where(p => p.Rating >= 4);

        // Act

        var actual = await context.Products
            .Where(goodOrBetter)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task LessThan_WhenApplied_ShouldReturnOnlyLessValues()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var poorlyRated = Filter.For<ProductEntity>()
            .Where(x => x.Rating).LessThan(3)
            .Build();

        var expected = _products.Where(p => p.Rating < 3);

        // Act

        var actual = await context.Products
            .Where(poorlyRated)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task LessThanOrEqual_WhenApplied_ShouldReturnOnlyLessOrEqualValues()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var belowAverage = Filter.For<ProductEntity>()
            .Where(x => x.Rating).LessThanOrEqual(2)
            .Build();

        var expected = _products.Where(p => p.Rating <= 2);

        // Act

        var actual = await context.Products
            .Where(belowAverage)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Between_WhenApplied_ShouldReturnOnlyValuesInRange()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var midRange = Filter.For<ProductEntity>()
            .Where(x => x.Rating).Between(2, 4)
            .Build();

        var expected = _products.Where(p => p.Rating >= 2 && p.Rating <= 4);

        // Act

        var actual = await context.Products
            .Where(midRange)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        int?[] set = [1, 3, 5];

        var inSet = Filter.For<ProductEntity>()
            .Where(x => x.Rating).In(set)
            .Build();

        var expected = _products.Where(p => set.Contains(p.Rating));

        // Act

        var actual = await context.Products
            .Where(inSet)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var highRatedInStock = Filter.For<ProductEntity>()
            .Where(x => x.Rating).GreaterThanOrEqual(4)
            .And(x => x.Stock).GreaterThan(0)
            .Build();

        var expected = _products.Where(p => p.Rating >= 4 && p.Stock > 0);

        // Act

        var actual = await context.Products
            .Where(highRatedInStock)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var unavailable = Filter.For<ProductEntity>()
            .Where(x => x.Rating).IsNull()
            .Or(x => x.Stock).Equal(0)
            .Build();

        var expected = _products.Where(p => p.Rating == null || p.Stock == 0);

        // Act

        var actual = await context.Products
            .Where(unavailable)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task AndNestedOr_WhenApplied_ShouldReturnItemsMatchingAndWithNestedOr()
    {
        // Arrange
        // Filter: Rating >= 3 AND (Stock > 0 OR Rating == 5)

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var recommended = Filter.For<ProductEntity>()
            .Where(x => x.Rating).GreaterThanOrEqual(3)
            .AndGroup(products => products
                .Where(x => x.Stock).GreaterThan(0)
                .Or(x => x.Rating).Equal(5))
            .Build();

        var expected = _products.Where(p => p.Rating >= 3 && (p.Stock > 0 || p.Rating == 5));

        // Act

        var actual = await context.Products
            .Where(recommended)
            .Select(x => Product.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task OrNestedAnd_WhenApplied_ShouldReturnItemsMatchingOrWithNestedAnd()
    {
        // Arrange
        // Filter: Rating == null OR (Stock == 0 AND Rating >= 3)

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        SeedProducts(context);

        var skipListed = Filter.For<ProductEntity>()
            .Where(x => x.Rating).IsNull()
            .OrGroup(products => products
                .Where(x => x.Stock).Equal(0)
                .And(x => x.Rating).GreaterThanOrEqual(3))
            .Build();

        var expected = _products.Where(p => p.Rating == null || (p.Stock == 0 && p.Rating >= 3));

        // Act

        var actual = await context.Products
            .Where(skipListed)
            .Select(x => Product.Map(x))
            .ToListAsync();

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
