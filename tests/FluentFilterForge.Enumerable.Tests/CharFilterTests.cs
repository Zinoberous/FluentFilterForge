using FluentAssertions;
using FluentFilterForge;

namespace FluentFilterForge.Enumerable.Tests;

public sealed class CharFilterTests
{
    private sealed record Token(char? Category, char Grade);

    private static readonly IEnumerable<Token> _tokens = [
        new(null, 'F'),
        new(null, 'D'),
        new('A', 'F'),
        new('A', 'C'),
        new('B', 'D'),
        new('B', 'A'),
        new('C', 'B'),
        new('C', 'A'),
    ];

    [Fact]
    public void IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        IEnumerable<char?> data = ['a', null, 'b', null, 'c'];

        var isNull = Filter.For<char?>()
            .Where(x => x).IsNull()
            .Build();

        var expected = data.Where(x => x == null);

        // Act

        var actual = data.Where(isNull);

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData('A')]
    [InlineData(null)]
    public void Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(char? value)
    {
        // Arrange

        IEnumerable<char?> data = ['A', 'B', null, value];

        var equalValue = Filter.For<char?>()
            .Where(x => x).Equal(value)
            .Build();

        var expected = data.Where(x => x == value);

        // Act

        var actual = data.Where(equalValue);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        IEnumerable<char?> data = ['A', 'B', null];

        var isNotA = Filter.For<char?>()
            .Where(x => x).Not().Equal('A')
            .Build();

        var expected = data.Where(x => x != 'A');

        // Act

        var actual = data.Where(isNotA);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        IEnumerable<char?> data = ['A', 'B', 'C', null];

        char?[] set = ['A', 'C'];

        var inSet = Filter.For<char?>()
            .Where(x => x).In(set)
            .Build();

        var expected = data.Where(x => set.Contains(x));

        // Act

        var actual = data.Where(inSet);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Token>()
            .Where(x => x.Category).Equal('A')
            .And(x => x.Grade).Equal('C')
            .Build();

        var expected = _tokens.Where(t => t.Category == 'A' && t.Grade == 'C');

        // Act

        var actual = _tokens.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Token>()
            .Where(x => x.Category).IsNull()
            .Or(x => x.Grade).Equal('A')
            .Build();

        var expected = _tokens.Where(t => t.Category == null || t.Grade == 'A');

        // Act

        var actual = _tokens.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }
}
