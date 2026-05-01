using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public class StringFilterTests
{
    private sealed class ArticleEntity
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public string Title { get; set; } = string.Empty;
    }

    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<ArticleEntity> Articles => Set<ArticleEntity>();
    }

    private sealed record Article(string? Category, string Title)
    {
        internal static Article Map(ArticleEntity entity) => new(entity.Category, entity.Title);
    }

    private static readonly Article[] _articles = [
        new(null, "Introduction to C#"),
        new(null, "Getting Started with .NET"),
        new("Tech", "Advanced C# Patterns"),
        new("Tech", "Cloud Architecture"),
        new("Science", "Quantum Computing Basics"),
        new("Science", "Biology of Cells"),
        new("News", "Daily Update"),
    ];

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedArticlesAsync(context);

        var isNull = Filter.For<ArticleEntity>()
            .Where(x => x.Category).IsNull()
            .Build();

        var expected = _articles.Where(a => a.Category == null);

        // Act

        var actual = await context.Articles
            .Where(isNull)
            .Select(x => Article.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task IsNullOrEmpty_WhenApplied_ShouldReturnNullAndEmptyValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        context.Articles.AddRange(
            new() { Id = 1, Category = null, Title = "A" },
            new() { Id = 2, Category = "", Title = "B" },
            new() { Id = 3, Category = "Tech", Title = "C" }
        );

        await context.SaveChangesAsync();

        var isNullOrEmpty = Filter.For<ArticleEntity>()
            .Where(x => x.Category).IsNullOrEmpty()
            .Build();

        var expected = new[] { "A", "B" };

        // Act

        var actual = await context.Articles
            .Where(isNullOrEmpty)
            .Select(x => x.Title)
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task IsNullOrWhitespace_WhenApplied_ShouldReturnNullEmptyAndWhitespaceValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        context.Articles.AddRange(
            new() { Id = 1, Category = null, Title = "A" },
            new() { Id = 2, Category = "", Title = "B" },
            new() { Id = 3, Category = "   ", Title = "C" },
            new() { Id = 4, Category = "Tech", Title = "D" }
        );

        await context.SaveChangesAsync();

        var isNullOrWhitespace = Filter.For<ArticleEntity>()
            .Where(x => x.Category).IsNullOrWhitespace()
            .Build();

        var expected = new[] { "A", "B", "C" };

        // Act

        var actual = await context.Articles
            .Where(isNullOrWhitespace)
            .Select(x => x.Title)
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData("Tech")]
    [InlineData(null)]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(string? value)
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedArticlesAsync(context);

        var equalValue = Filter.For<ArticleEntity>()
            .Where(x => x.Category).Equal(value)
            .Build();

        var expected = _articles.Where(a => a.Category == value);

        // Act

        var actual = await context.Articles
            .Where(equalValue)
            .Select(x => Article.Map(x))
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

        await SeedArticlesAsync(context);

        var isNotTech = Filter.For<ArticleEntity>()
            .Where(x => x.Category).Not().Equal("Tech")
            .Build();

        var expected = _articles.Where(a => a.Category != "Tech");

        // Act

        var actual = await context.Articles
            .Where(isNotTech)
            .Select(x => Article.Map(x))
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

        await SeedArticlesAsync(context);

        var startsWithAdv = Filter.For<ArticleEntity>()
            .Where(x => x.Title).StartsWith("Advanced")
            .Build();

        var expected = _articles.Where(a => a.Title.StartsWith("Advanced", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await context.Articles
            .Where(startsWithAdv)
            .Select(x => Article.Map(x))
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

        await SeedArticlesAsync(context);

        var endsWithSharp = Filter.For<ArticleEntity>()
            .Where(x => x.Title).EndsWith("C#")
            .Build();

        var expected = _articles.Where(a => a.Title.EndsWith("C#", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await context.Articles
            .Where(endsWithSharp)
            .Select(x => Article.Map(x))
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

        await SeedArticlesAsync(context);

        var containsNet = Filter.For<ArticleEntity>()
            .Where(x => x.Title).Contains(".NET")
            .Build();

        var expected = _articles.Where(a => a.Title.Contains(".NET", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await context.Articles
            .Where(containsNet)
            .Select(x => Article.Map(x))
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

        await SeedArticlesAsync(context);

        string?[] set = ["Tech", "News"];

        var inSet = Filter.For<ArticleEntity>()
            .Where(x => x.Category).In(set)
            .Build();

        var expected = _articles.Where(a => set.Contains(a.Category));

        // Act

        var actual = await context.Articles
            .Where(inSet)
            .Select(x => Article.Map(x))
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

        await SeedArticlesAsync(context);

        var filter = Filter.For<ArticleEntity>()
            .Where(x => x.Category).Equal("Tech")
            .And(x => x.Title).Contains("C#")
            .Build();

        var expected = _articles.Where(a => a.Category == "Tech" && a.Title.Contains("C#", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await context.Articles
            .Where(filter)
            .Select(x => Article.Map(x))
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

        await SeedArticlesAsync(context);

        var filter = Filter.For<ArticleEntity>()
            .Where(x => x.Category).IsNull()
            .Or(x => x.Title).StartsWith("Daily")
            .Build();

        var expected = _articles.Where(a =>
            a.Category == null
            || a.Title.StartsWith("Daily", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await context.Articles
            .Where(filter)
            .Select(x => Article.Map(x))
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

    private static async Task SeedArticlesAsync(TestDbContext context)
    {
        context.Articles.AddRange(_articles.Select((a, i) => new ArticleEntity
        {
            Id = i + 1,
            Category = a.Category,
            Title = a.Title
        }));

        await context.SaveChangesAsync();
    }
}
