using FluentAssertions;
using FluentFilterForge.Extensions;

namespace FluentFilterForge.Enumerable.Tests;

public class NumberFilterTests
{
    private sealed record Product(int? Rating, int Stock);

    private static readonly IEnumerable<Product> _products = [
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

    [Fact]
    public void IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        IEnumerable<int?> data = [1, null, 2, null, 3];

        var isNull = Filter.For<int?>()
            .Where(x => x).IsNull()
            .Build();

        var expected = data.Where(x => x == null);

        // Act

        var actual = data.Where(isNull);

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(null)]
    public void Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(int? value)
    {
        // Arrange

        IEnumerable<int?> data = [1, 2, null, value];

        var equalValue = Filter.For<int?>()
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

        IEnumerable<int?> data = [1, 2, null];

        var isNotOne = Filter.For<int?>()
            .Where(x => x).Not().Equal(1)
            .Build();

        var expected = data.Where(x => x != 1);

        // Act

        var actual = data.Where(isNotOne);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void GreaterThan_WhenApplied_ShouldReturnOnlyGreaterValues()
    {
        // Arrange

        IEnumerable<int> data = [1, 2, 3, 4, 5];

        var greaterThanThree = Filter.For<int>()
            .Where(x => x).GreaterThan(3)
            .Build();

        var expected = data.Where(x => x > 3);

        // Act

        var actual = data.Where(greaterThanThree);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void GreaterThanOrEqual_WhenApplied_ShouldReturnOnlyGreaterOrEqualValues()
    {
        // Arrange

        IEnumerable<int> data = [1, 2, 3, 4, 5];

        var greaterThanOrEqualThree = Filter.For<int>()
            .Where(x => x).GreaterThanOrEqual(3)
            .Build();

        var expected = data.Where(x => x >= 3);

        // Act

        var actual = data.Where(greaterThanOrEqualThree);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void LessThan_WhenApplied_ShouldReturnOnlyLessValues()
    {
        // Arrange

        IEnumerable<int> data = [1, 2, 3, 4, 5];

        var lessThanThree = Filter.For<int>()
            .Where(x => x).LessThan(3)
            .Build();

        var expected = data.Where(x => x < 3);

        // Act

        var actual = data.Where(lessThanThree);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void LessThanOrEqual_WhenApplied_ShouldReturnOnlyLessOrEqualValues()
    {
        // Arrange

        IEnumerable<int> data = [1, 2, 3, 4, 5];

        var lessThanOrEqualThree = Filter.For<int>()
            .Where(x => x).LessThanOrEqual(3)
            .Build();

        var expected = data.Where(x => x <= 3);

        // Act

        var actual = data.Where(lessThanOrEqualThree);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Between_WhenApplied_ShouldReturnOnlyValuesInRange()
    {
        // Arrange

        IEnumerable<int> data = [1, 2, 3, 4, 5];

        var betweenTwoAndFour = Filter.For<int>()
            .Where(x => x).Between(2, 4)
            .Build();

        var expected = data.Where(x => x >= 2 && x <= 4);

        // Act

        var actual = data.Where(betweenTwoAndFour);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        IEnumerable<int> data = [1, 2, 3, 4, 5];

        int?[] set = [1, 3, 5];

        var inSet = Filter.For<int>()
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

        var highRatedInStock = Filter.For<Product>()
            .Where(x => x.Rating).GreaterThanOrEqual(4)
            .And(x => x.Stock).GreaterThan(0)
            .Build();

        var expected = _products.Where(p => p.Rating >= 4 && p.Stock > 0);

        // Act

        var actual = _products.Where(highRatedInStock);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var unavailable = Filter.For<Product>()
            .Where(x => x.Rating).IsNull()
            .Or(x => x.Stock).Equal(0)
            .Build();

        var expected = _products.Where(p => p.Rating == null || p.Stock == 0);

        // Act

        var actual = _products.Where(unavailable);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void AndNestedOr_WhenApplied_ShouldReturnItemsMatchingAndWithNestedOr()
    {
        // Arrange
        // Filter: Rating >= 3 AND (Stock > 0 OR Rating == 5)

        var recommended = Filter.For<Product>()
            .Where(x => x.Rating).GreaterThanOrEqual(3)
            .And(products => products
                .Where(x => x.Stock).GreaterThan(0)
                .Or(x => x.Rating).Equal(5))
            .Build();

        var expected = _products.Where(p => p.Rating >= 3 && (p.Stock > 0 || p.Rating == 5));

        // Act

        var actual = _products.Where(recommended);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void OrNestedAnd_WhenApplied_ShouldReturnItemsMatchingOrWithNestedAnd()
    {
        // Arrange
        // Filter: Rating == null OR (Stock == 0 AND Rating >= 3)

        var skipListed = Filter.For<Product>()
            .Where(x => x.Rating).IsNull()
            .Or(products => products
                .Where(x => x.Stock).Equal(0)
                .And(x => x.Rating).GreaterThanOrEqual(3))
            .Build();

        var expected = _products.Where(p => p.Rating == null || (p.Stock == 0 && p.Rating >= 3));

        // Act

        var actual = _products.Where(skipListed);

        // Assert

        actual.Should().Equal(expected);
    }
}
