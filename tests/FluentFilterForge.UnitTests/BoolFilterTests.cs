using FluentAssertions;
using FluentFilterForge.Extensions;

namespace FluentFilterForge.UnitTests;

public class BoolFilterTests
{
    private sealed record Customer(bool? IsActive, bool? IsVerified);

    [Fact]
    public void IsTrue_WhenApplied_ShouldReturnOnlyTrueValues()
    {
        // Arrange

        IEnumerable<bool?> data = [true, false, null, true];

        var filter = Filter.For<bool?>()
            .Where(x => x)
            .IsTrue()
            .Filter;

        IEnumerable<bool?> expected = [true, true];

        // Act

        var actual = data.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void IsFalse_WhenApplied_ShouldReturnOnlyFalseValues()
    {
        // Arrange

        IEnumerable<bool?> data = [true, false, null, false];

        var filter = Filter.For<bool?>()
            .Where(x => x)
            .IsFalse()
            .Filter;

        IEnumerable<bool?> expected = [false, false];

        // Act

        var actual = data.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        IEnumerable<bool?> data = [true, false, null, null];

        var filter = Filter.For<bool?>()
            .Where(x => x)
            .IsNull()
            .Filter;

        IEnumerable<bool?> expected = [null, null];

        // Act

        var actual = data.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsTrue_ShouldReturnOnlyTrueValues()
    {
        // Arrange

        IEnumerable<bool?> data = [true, false, null, true];

        var filter = Filter.For<bool?>()
            .Where(x => x)
            .Equal(true)
            .Filter;

        IEnumerable<bool?> expected = [true, true];

        // Act

        var actual = data.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsFalse_ShouldReturnOnlyFalseValues()
    {
        // Arrange

        IEnumerable<bool?> data = [true, false, null, false];

        var filter = Filter.For<bool?>()
            .Where(x => x)
            .Equal(false)
            .Filter;

        IEnumerable<bool?> expected = [false, false];

        // Act

        var actual = data.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsNull_ShouldReturnOnlyNullValues()
    {
        // Arrange

        IEnumerable<bool?> data = [true, false, null, null];

        var filter = Filter.For<bool?>()
            .Where(x => x)
            .Equal(null)
            .Filter;

        IEnumerable<bool?> expected = [null, null];

        // Act

        var actual = data.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        IEnumerable<bool?> data = [true, false, null];

        var filter = Filter.For<bool?>()
            .Where(x => x)
            .Not()
            .Equal(true)
            .Filter;

        IEnumerable<bool?> expected = [false, null];

        // Act

        var actual = data.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        IEnumerable<Customer> data = [
            new(true, true),
            new(true, false),
            new(false, true),
            new(null, true)
        ];

        var filter = Filter.For<Customer>()
            .Where(x => x.IsActive).IsTrue()
            .And(x => x.IsVerified).IsTrue()
            .Filter;

        IEnumerable<Customer> expected = [new(true, true)];

        // Act

        var actual = data.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        IEnumerable<Customer> data = [
            new(true, true),
            new(true, false),
            new(false, true),
            new(false, false),
            new(null, null)
        ];

        var filter = Filter.For<Customer>()
            .Where(x => x.IsActive).IsTrue()
            .Or(x => x.IsVerified).IsTrue()
            .Filter;

        IEnumerable<Customer> expected = [
            new(true, true),
            new(true, false),
            new(false, true)
        ];

        // Act

        var actual = data.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }
}
