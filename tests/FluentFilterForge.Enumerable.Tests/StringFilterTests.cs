using FluentAssertions;
using FluentFilterForge;

namespace FluentFilterForge.Enumerable.Tests;

public class StringFilterTests
{
    private sealed record Article(string? Category, string Title);

    private static readonly IEnumerable<Article> _articles = [
        new(null, "Introduction to C#"),
        new(null, "Getting Started with .NET"),
        new("Tech", "Advanced C# Patterns"),
        new("Tech", "Cloud Architecture"),
        new("Science", "Quantum Computing Basics"),
        new("Science", "Biology of Cells"),
        new("News", "Daily Update"),
    ];

    [Fact]
    public void IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        IEnumerable<string?> data = ["hello", null, "world", null];

        var isNull = Filter.For<string?>()
            .Where(x => x).IsNull()
            .Build();

        var expected = data.Where(x => x == null);

        // Act

        var actual = data.Where(isNull);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void IsNullOrEmpty_WhenApplied_ShouldReturnNullAndEmptyValues()
    {
        // Arrange

        IEnumerable<string?> data = ["hello", null, "", "world", ""];

        var isNullOrEmpty = Filter.For<string?>()
            .Where(x => x).IsNullOrEmpty()
            .Build();

        var expected = data.Where(x => string.IsNullOrEmpty(x));

        // Act

        var actual = data.Where(isNullOrEmpty);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void IsNullOrWhitespace_WhenApplied_ShouldReturnNullEmptyAndWhitespaceValues()
    {
        // Arrange

        IEnumerable<string?> data = ["hello", null, "", "   ", "world"];

        var isNullOrWhitespace = Filter.For<string?>()
            .Where(x => x).IsNullOrWhitespace()
            .Build();

        var expected = data.Where(x => string.IsNullOrWhiteSpace(x));

        // Act

        var actual = data.Where(isNullOrWhitespace);

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData("Tech")]
    [InlineData(null)]
    public void Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(string? value)
    {
        // Arrange

        var equalValue = Filter.For<Article>()
            .Where(x => x.Category).Equal(value)
            .Build();

        var expected = _articles.Where(a => a.Category == value);

        // Act

        var actual = _articles.Where(equalValue);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotTech = Filter.For<Article>()
            .Where(x => x.Category).Not().Equal("Tech")
            .Build();

        var expected = _articles.Where(a => a.Category != "Tech");

        // Act

        var actual = _articles.Where(isNotTech);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void StartsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var startsWithAdv = Filter.For<Article>()
            .Where(x => x.Title).StartsWith("Advanced")
            .Build();

        var expected = _articles.Where(a => a.Title.StartsWith("Advanced", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = _articles.Where(startsWithAdv);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void EndsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var endsWithSharp = Filter.For<Article>()
            .Where(x => x.Title).EndsWith("C#")
            .Build();

        var expected = _articles.Where(a => a.Title.EndsWith("C#", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = _articles.Where(endsWithSharp);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Contains_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var containsNet = Filter.For<Article>()
            .Where(x => x.Title).Contains(".NET")
            .Build();

        var expected = _articles.Where(a => a.Title.Contains(".NET", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = _articles.Where(containsNet);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        string?[] set = ["Tech", "News"];

        var inSet = Filter.For<Article>()
            .Where(x => x.Category).In(set)
            .Build();

        var expected = _articles.Where(a => set.Contains(a.Category));

        // Act

        var actual = _articles.Where(inSet);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Article>()
            .Where(x => x.Category).Equal("Tech")
            .And(x => x.Title).Contains("C#")
            .Build();

        var expected = _articles.Where(a =>
            a.Category == "Tech"
            && a.Title.Contains("C#", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = _articles.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Article>()
            .Where(x => x.Category).IsNull()
            .Or(x => x.Title).StartsWith("Daily")
            .Build();

        var expected = _articles.Where(a =>
            a.Category == null
            || a.Title.StartsWith("Daily", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = _articles.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }
}
