using FluentAssertions;
using FluentFilterForge;

namespace FluentFilterForge.Enumerable.Tests;

public sealed class BoolFilterTests
{
    private sealed record Customer(bool? IsVerified, bool? IsInsured, bool IsDeleted);

    private static readonly IEnumerable<Customer> _customers = [
        new(null, null, false),     // registration pending, insured status unknown
        new(null, null, true),      // registration cancelled, insured status unknown
        new(null, false, false),    // registration pending, not insured
        new(null, false, true),     // registration cancelled, not insured
        new(null, true, false),     // registration pending, insured
        new(null, true, true),      // registration cancelled, insured
        new(false, null, false),    // denied, insured status unknown, waiting for deletion
        new(false, null, true),     // denied, insured status unknown, deleted
        new(false, false, false),   // denied, not insured, waiting for deletion
        new(false, false, true),    // denied, not insured, deleted
        new(false, true, false),    // denied, insured, waiting for deletion
        new(false, true, true),     // denied, insured, deleted
        new(true, null, false),     // accepted, insured status unknown
        new(true, null, true),      // deleted, insured status unknown
        new(true, false, false),    // accepted, not insured
        new(true, false, true),     // deleted, not insured
        new(true, true, false),     // accepted, insured
        new(true, true, true)       // deleted, insured
    ];

    [Fact]
    public void IsTrue_WhenApplied_ShouldReturnOnlyTrueValues()
    {
        // Arrange

        IEnumerable<bool> data = [true, false, true];

        var isTrue = Filter.For<bool>()
            .Where(x => x).IsTrue()
            .Build();

        var expected = data.Where(x => x);

        // Act

        var actual = data.Where(isTrue);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void IsFalse_WhenApplied_ShouldReturnOnlyFalseValues()
    {
        // Arrange

        IEnumerable<bool> data = [true, false, false];

        var isFalse = Filter.For<bool>()
            .Where(x => x).IsFalse()
            .Build();

        var expected = data.Where(x => !x);

        // Act

        var actual = data.Where(isFalse);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        IEnumerable<bool?> data = [true, false, null, null];

        var ísNull = Filter.For<bool?>()
            .Where(x => x).IsNull()
            .Build();

        var expected = data.Where(x => x is null);

        // Act

        var actual = data.Where(ísNull);

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    [InlineData(null)]
    public void Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(bool? value)
    {
        // Arrange

        IEnumerable<bool?> data = [true, false, null, value];

        var equalValue = Filter.For<bool?>()
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

        IEnumerable<bool?> data = [true, false, null];

        var isNotTrue = Filter.For<bool?>()
            .Where(x => x).Not().Equal(true)
            .Build();

        var expected = data.Where(x => x != true);

        // Act

        var actual = data.Where(isNotTrue);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var isActive = Filter.For<Customer>()
            .Where(x => x.IsVerified).IsTrue()
            .And(x => x.IsDeleted).IsFalse()
            .Build();

        var expected = _customers.Where(c => c.IsVerified == true && !c.IsDeleted);

        // Act

        var actual = _customers.Where(isActive);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var isNotActive = Filter.For<Customer>()
            .Where(x => x.IsVerified).IsNull()
            .Or(x => x.IsVerified).IsFalse()
            .Or(x => x.IsDeleted).IsTrue()
            .Build();

        var expected = _customers.Where(c => c.IsVerified is null || c.IsVerified == false || c.IsDeleted);

        // Act

        var actual = _customers.Where(isNotActive);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void AndNestedOr_WhenApplied_ShouldReturnItemsMatchingAndWithNestedOr()
    {
        // Arrange

        var isRegistrationPendingWithoutInsurance = Filter.For<Customer>()
            .Where(x => x.IsVerified).IsNull()
            .And(x => x.IsDeleted).IsFalse()
            .AndGroup(customers => customers
                .Where(x => x.IsInsured).IsNull()
                .Or(x => x.IsInsured).IsFalse())
            .Build();

        var expected = _customers.Where(c =>
            c.IsVerified is null
            && !c.IsDeleted
            && (c.IsInsured is null || c.IsInsured == false));

        // Act

        var actual = _customers.Where(isRegistrationPendingWithoutInsurance);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void OrNestedAnd_WhenApplied_ShouldReturnItemsMatchingOrWithNestedAnd()
    {
        // Arrange

        var isNeverActivated = Filter.For<Customer>()
            .Where(x => x.IsVerified).IsFalse()
            .OrGroup(customers => customers
                .Where(x => x.IsVerified).IsNull()
                .And(x => x.IsDeleted).IsTrue())
            .Build();

        var expected = _customers.Where(c =>
            c.IsVerified == false
            || (c.IsVerified is null && c.IsDeleted));

        // Act

        var actual = _customers.Where(isNeverActivated);

        // Assert

        actual.Should().Equal(expected);
    }
}
