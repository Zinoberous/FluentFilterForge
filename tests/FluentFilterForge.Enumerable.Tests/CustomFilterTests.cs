using FluentAssertions;
using FluentFilterForge;

namespace FluentFilterForge.Enumerable.Tests;

public sealed class CustomFilterTests
{
    public enum Priority { Low, Medium, High }

    private sealed record Task(string Title, Priority? Priority);

    private static readonly IEnumerable<Task> _tasks = [
        new("Write docs", null),
        new("Fix bug", Priority.High),
        new("Refactor code", Priority.Medium),
        new("Add tests", Priority.High),
        new("Update deps", Priority.Low),
        new("Review PR", null),
    ];

    [Fact]
    public void IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var isNull = Filter.For<Task>()
            .Where(x => x.Priority).IsNull()
            .Build();

        var expected = _tasks.Where(t => t.Priority == null);

        // Act

        var actual = _tasks.Where(isNull);

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData(Priority.High)]
    [InlineData(null)]
    public void Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(Priority? value)
    {
        // Arrange

        var equalValue = Filter.For<Task>()
            .Where(x => x.Priority).Equal(value)
            .Build();

        var expected = _tasks.Where(t => t.Priority == value);

        // Act

        var actual = _tasks.Where(equalValue);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotHigh = Filter.For<Task>()
            .Where(x => x.Priority).Not().Equal(Priority.High)
            .Build();

        var expected = _tasks.Where(t => t.Priority != Priority.High);

        // Act

        var actual = _tasks.Where(isNotHigh);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Task>()
            .Where(x => x.Priority).Equal(Priority.High)
            .And(x => x.Title).StartsWith("Fix")
            .Build();

        var expected = _tasks.Where(t =>
            t.Priority == Priority.High
            && t.Title.StartsWith("Fix", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = _tasks.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Task>()
            .Where(x => x.Priority).IsNull()
            .Or(x => x.Priority).Equal(Priority.Low)
            .Build();

        var expected = _tasks.Where(t =>
            t.Priority == null
            || t.Priority == Priority.Low);

        // Act

        var actual = _tasks.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }
}
