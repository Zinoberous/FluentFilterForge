using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public sealed class ArticleEntity
{
    public int Id { get; set; }
    public string? Category { get; set; }
    public string Title { get; set; } = string.Empty;
}

public sealed class StringFilterTestsDbContext(DbContextOptions<StringFilterTestsDbContext> options) : DbContext(options)
{
    public DbSet<ArticleEntity> Articles => Set<ArticleEntity>();
}

public sealed record Article(string? Category, string Title)
{
    internal static Article Map(ArticleEntity entity) => new(entity.Category, entity.Title);
}

public sealed class StringFilterTestsFixture : DatabaseTestsFixture<StringFilterTestsDbContext>
{
    public IEnumerable<Article> Articles { get; } = [
        new(null, "Introduction to C#"),
        new(null, "Getting Started with .NET"),
        new("Tech", "Advanced C# Patterns"),
        new("Tech", "Cloud Architecture"),
        new("Science", "Quantum Computing Basics"),
        new("Science", "Biology of Cells"),
        new("News", "Daily Update"),
    ];

    protected override async Task InitializeAsync(StringFilterTestsDbContext context)
    {
        context.Articles.AddRange(Articles.Select(a => new ArticleEntity
        {
            Category = a.Category,
            Title = a.Title
        }));

        await context.SaveChangesAsync();
    }
}

public sealed class StringFilterTests(StringFilterTestsFixture fixture) : DatabaseTests<StringFilterTestsDbContext, StringFilterTestsFixture>(fixture)
{
    private readonly StringFilterTestsFixture _fixture = fixture;

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var isNull = Filter.For<ArticleEntity>()
            .Where(x => x.Category).IsNull()
            .Build();

        var expected = _fixture.Articles.Where(a => a.Category == null);

        // Act

        var actual = await Context.Articles
            .Where(isNull)
            .Select(x => Article.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task IsNullOrEmpty_WhenApplied_ShouldReturnNullAndEmptyValues()
    {
        // Arrange

        await Context.Articles.ExecuteDeleteAsync(TestContext.Current.CancellationToken);

        Context.Articles.AddRange(
            new() { Category = null, Title = "A" },
            new() { Category = "", Title = "B" },
            new() { Category = "Tech", Title = "C" }
        );

        await Context.SaveChangesAsync(TestContext.Current.CancellationToken);

        var isNullOrEmpty = Filter.For<ArticleEntity>()
            .Where(x => x.Category).IsNullOrEmpty()
            .Build();

        var expected = new[] { "A", "B" };

        // Act

        var actual = await Context.Articles
            .Where(isNullOrEmpty)
            .Select(x => x.Title)
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task IsNullOrWhitespace_WhenApplied_ShouldReturnNullEmptyAndWhitespaceValues()
    {
        // Arrange

        await Context.Articles.ExecuteDeleteAsync(TestContext.Current.CancellationToken);

        Context.Articles.AddRange(
            new() { Category = null, Title = "A" },
            new() { Category = "", Title = "B" },
            new() { Category = "   ", Title = "C" },
            new() { Category = "Tech", Title = "D" }
        );

        await Context.SaveChangesAsync(TestContext.Current.CancellationToken);

        var isNullOrWhitespace = Filter.For<ArticleEntity>()
            .Where(x => x.Category).IsNullOrWhitespace()
            .Build();

        var expected = new[] { "A", "B", "C" };

        // Act

        var actual = await Context.Articles
            .Where(isNullOrWhitespace)
            .Select(x => x.Title)
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData("Tech")]
    [InlineData(null)]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(string? value)
    {
        // Arrange

        var equalValue = Filter.For<ArticleEntity>()
            .Where(x => x.Category).Equal(value)
            .Build();

        var expected = _fixture.Articles.Where(a => a.Category == value);

        // Act

        var actual = await Context.Articles
            .Where(equalValue)
            .Select(x => Article.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotTech = Filter.For<ArticleEntity>()
            .Where(x => x.Category).Not().Equal("Tech")
            .Build();

        var expected = _fixture.Articles.Where(a => a.Category != "Tech");

        // Act

        var actual = await Context.Articles
            .Where(isNotTech)
            .Select(x => Article.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task StartsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var startsWithAdv = Filter.For<ArticleEntity>()
            .Where(x => x.Title).StartsWith("Advanced")
            .Build();

        var expected = _fixture.Articles.Where(a => a.Title.StartsWith("Advanced", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await Context.Articles
            .Where(startsWithAdv)
            .Select(x => Article.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task EndsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var endsWithSharp = Filter.For<ArticleEntity>()
            .Where(x => x.Title).EndsWith("C#")
            .Build();

        var expected = _fixture.Articles.Where(a => a.Title.EndsWith("C#", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await Context.Articles
            .Where(endsWithSharp)
            .Select(x => Article.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Contains_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var containsNet = Filter.For<ArticleEntity>()
            .Where(x => x.Title).Contains(".NET")
            .Build();

        var expected = _fixture.Articles.Where(a => a.Title.Contains(".NET", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await Context.Articles
            .Where(containsNet)
            .Select(x => Article.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        string?[] set = ["Tech", "News"];

        var inSet = Filter.For<ArticleEntity>()
            .Where(x => x.Category).In(set)
            .Build();

        var expected = _fixture.Articles.Where(a => set.Contains(a.Category));

        // Act

        var actual = await Context.Articles
            .Where(inSet)
            .Select(x => Article.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<ArticleEntity>()
            .Where(x => x.Category).Equal("Tech")
            .And(x => x.Title).Contains("C#")
            .Build();

        var expected = _fixture.Articles.Where(a => a.Category == "Tech" && a.Title.Contains("C#", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await Context.Articles
            .Where(filter)
            .Select(x => Article.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<ArticleEntity>()
            .Where(x => x.Category).IsNull()
            .Or(x => x.Title).StartsWith("Daily")
            .Build();

        var expected = _fixture.Articles.Where(a =>
            a.Category == null
            || a.Title.StartsWith("Daily", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await Context.Articles
            .Where(filter)
            .Select(x => Article.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }
}
