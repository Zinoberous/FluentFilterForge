using FluentAssertions;
using FluentFilterForge;

namespace FluentFilterForge.Enumerable.Tests;

public class GuidFilterTests
{
    private sealed record Item(Guid? CategoryId, Guid OwnerId);

    private static readonly Guid _guidA = new("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
    private static readonly Guid _guidB = new("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
    private static readonly Guid _guidC = new("cccccccc-cccc-cccc-cccc-cccccccccccc");
    private static readonly Guid _guidD = new("dddddddd-dddd-dddd-dddd-dddddddddddd");

    private static readonly IEnumerable<Item> _items = [
        new(null, _guidA),
        new(null, _guidB),
        new(_guidA, _guidA),
        new(_guidA, _guidC),
        new(_guidB, _guidB),
        new(_guidC, _guidD),
    ];

    [Fact]
    public void IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var isNull = Filter.For<Item>()
            .Where(x => x.CategoryId).IsNull()
            .Build();

        var expected = _items.Where(i => i.CategoryId == null);

        // Act

        var actual = _items.Where(isNull);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var equalValue = Filter.For<Item>()
            .Where(x => x.CategoryId).Equal(_guidA)
            .Build();

        var expected = _items.Where(i => i.CategoryId == _guidA);

        // Act

        var actual = _items.Where(equalValue);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsNull_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var equalNull = Filter.For<Item>()
            .Where(x => x.CategoryId).Equal(null)
            .Build();

        var expected = _items.Where(i => i.CategoryId == null);

        // Act

        var actual = _items.Where(equalNull);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotA = Filter.For<Item>()
            .Where(x => x.CategoryId).Not().Equal(_guidA)
            .Build();

        var expected = _items.Where(i => i.CategoryId != _guidA);

        // Act

        var actual = _items.Where(isNotA);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void StartsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var startsWithA = Filter.For<Item>()
            .Where(x => x.CategoryId).StartsWith("aaaa")
            .Build();

        var expected = _items.Where(i => i.CategoryId?.ToString().StartsWith("aaaa") == true);

        // Act

        var actual = _items.Where(startsWithA);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void EndsWith_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var endsWithB = Filter.For<Item>()
            .Where(x => x.CategoryId).EndsWith("bbbbbbbb")
            .Build();

        var expected = _items.Where(i => i.CategoryId?.ToString().EndsWith("bbbbbbbb") == true);

        // Act

        var actual = _items.Where(endsWithB);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Contains_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var containsC = Filter.For<Item>()
            .Where(x => x.CategoryId).Contains("cccc-cccc")
            .Build();

        var expected = _items.Where(i => i.CategoryId?.ToString().Contains("cccc-cccc") == true);

        // Act

        var actual = _items.Where(containsC);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        Guid?[] set = [_guidA, _guidC];

        var inSet = Filter.For<Item>()
            .Where(x => x.CategoryId).In(set)
            .Build();

        var expected = _items.Where(i => set.Contains(i.CategoryId));

        // Act

        var actual = _items.Where(inSet);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Item>()
            .Where(x => x.CategoryId).Equal(_guidA)
            .And(x => x.OwnerId).Equal(_guidA)
            .Build();

        var expected = _items.Where(i =>
            i.CategoryId == _guidA
            && i.OwnerId == _guidA);

        // Act

        var actual = _items.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Item>()
            .Where(x => x.CategoryId).IsNull()
            .Or(x => x.OwnerId).Equal(_guidD)
            .Build();

        var expected = _items.Where(i =>
            i.CategoryId == null
            || i.OwnerId == _guidD);

        // Act

        var actual = _items.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }
}
