using FluentAssertions;
using FluentFilterForge;

namespace FluentFilterForge.Enumerable.Tests;

public class EnumerableFilterTests
{
    private sealed record Order(string Id, IEnumerable<string>? Tags);

    private static readonly IEnumerable<Order> _orders = [
        new("O1", null),
        new("O2", []),
        new("O3", ["urgent"]),
        new("O4", ["urgent", "review"]),
        new("O5", ["review"]),
        new("O6", ["bulk", "review"]),
    ];

    [Fact]
    public void IsNullOrEmpty_WhenApplied_ShouldReturnOrdersWithNoTags()
    {
        // Arrange

        var isNullOrEmpty = Filter.For<Order>()
            .Where(x => x.Tags).IsNullOrEmpty()
            .Build();

        var expected = _orders.Where(o => o.Tags?.Any() != true);

        // Act

        var actual = _orders.Where(isNullOrEmpty);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void IsNullOrEmpty_WhenNegated_ShouldReturnNonEmptyCollections()
    {
        // Arrange

        var hasItems = Filter.For<Order>()
            .Where(x => x.Tags).Not().IsNullOrEmpty()
            .Build();

        var expected = _orders.Where(o => o.Tags?.Any() == true);

        // Act

        var actual = _orders.Where(hasItems);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Any_WhenApplied_ShouldReturnOnlyOrdersWithMatchingElement()
    {
        // Arrange

        var hasUrgentTag = Filter.For<Order>()
            .Where(x => x.Tags).Any(tags => tags
                .Where(t => t).Equal("urgent"))
            .Build();

        var expected = _orders.Where(o => o.Tags?.Any(t => t == "urgent") == true);

        // Act

        var actual = _orders.Where(hasUrgentTag);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Any_WhenNegated_ShouldReturnOrdersWithNoMatchingElement()
    {
        // Arrange

        var noUrgentTag = Filter.For<Order>()
            .Where(x => x.Tags).Not().Any(tags => tags
                .Where(t => t).Equal("urgent"))
            .Build();

        var expected = _orders.Where(o => o.Tags?.Any(t => t == "urgent") != true);

        // Act

        var actual = _orders.Where(noUrgentTag);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void All_WhenApplied_ShouldReturnOnlyOrdersWhereAllElementsMatch()
    {
        // Arrange

        var allReview = Filter.For<Order>()
            .Where(x => x.Tags).All(tags => tags
                .Where(t => t).Equal("review"))
            .Build();

        var expected = _orders.Where(o => o.Tags?.All(t => t == "review") == true);

        // Act

        var actual = _orders.Where(allReview);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Order>()
            .Where(x => x.Tags).Any(tags => tags
                .Where(t => t).Equal("urgent"))
            .And(x => x.Tags).Any(tags => tags
                .Where(t => t).Equal("review"))
            .Build();

        var expected = _orders.Where(o =>
            o.Tags?.Any(t => t == "urgent") == true
            && o.Tags.Any(t => t == "review"));

        // Act

        var actual = _orders.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Order>()
            .Where(x => x.Tags).IsNullOrEmpty()
            .Or(x => x.Tags).Any(tags => tags
                .Where(t => t).Equal("bulk"))
            .Build();

        var expected = _orders.Where(o =>
            o.Tags?.Any() != true
            || o.Tags.Any(t => t == "bulk"));

        // Act

        var actual = _orders.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }
}
