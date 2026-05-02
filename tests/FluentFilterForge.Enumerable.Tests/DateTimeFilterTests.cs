using FluentAssertions;
using FluentFilterForge;

namespace FluentFilterForge.Enumerable.Tests;

public sealed class DateTimeFilterTests
{
    private sealed record Event(DateTime? ScheduledAt, DateTime OccurredAt);

    private static readonly DateTime _base = new(2024, 6, 15, 12, 0, 0, DateTimeKind.Utc);

    private static readonly IEnumerable<Event> _events = [
        new(null, _base.AddDays(-10)),
        new(null, _base),
        new(_base.AddDays(-5), _base.AddDays(-5)),
        new(_base.AddDays(-1), _base.AddDays(-1)),
        new(_base, _base),
        new(_base.AddDays(1), _base),
        new(_base.AddDays(5), _base),
        new(_base.AddDays(10), _base.AddDays(10)),
    ];

    [Fact]
    public void IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var isUnscheduled = Filter.For<Event>()
            .Where(x => x.ScheduledAt).IsNull()
            .Build();

        var expected = _events.Where(e => e.ScheduledAt == null);

        // Act

        var actual = _events.Where(isUnscheduled);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var equalValue = Filter.For<Event>()
            .Where(x => x.ScheduledAt).Equal(_base)
            .Build();

        var expected = _events.Where(e => e.ScheduledAt == _base);

        // Act

        var actual = _events.Where(equalValue);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenValueIsNull_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var equalNull = Filter.For<Event>()
            .Where(x => x.ScheduledAt).Equal(null)
            .Build();

        var expected = _events.Where(e => e.ScheduledAt == null);

        // Act

        var actual = _events.Where(equalNull);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotToday = Filter.For<Event>()
            .Where(x => x.ScheduledAt).Not().Equal(_base)
            .Build();

        var expected = _events.Where(e => e.ScheduledAt != _base);

        // Act

        var actual = _events.Where(isNotToday);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void GreaterThan_WhenApplied_ShouldReturnOnlyGreaterValues()
    {
        // Arrange

        var future = Filter.For<Event>()
            .Where(x => x.OccurredAt).GreaterThan(_base)
            .Build();

        var expected = _events.Where(e => e.OccurredAt > _base);

        // Act

        var actual = _events.Where(future);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void GreaterThanOrEqual_WhenApplied_ShouldReturnOnlyGreaterOrEqualValues()
    {
        // Arrange

        var todayOrLater = Filter.For<Event>()
            .Where(x => x.OccurredAt).GreaterThanOrEqual(_base)
            .Build();

        var expected = _events.Where(e => e.OccurredAt >= _base);

        // Act

        var actual = _events.Where(todayOrLater);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void LessThan_WhenApplied_ShouldReturnOnlyLessValues()
    {
        // Arrange

        var past = Filter.For<Event>()
            .Where(x => x.OccurredAt).LessThan(_base)
            .Build();

        var expected = _events.Where(e => e.OccurredAt < _base);

        // Act

        var actual = _events.Where(past);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void LessThanOrEqual_WhenApplied_ShouldReturnOnlyLessOrEqualValues()
    {
        // Arrange

        var todayOrEarlier = Filter.For<Event>()
            .Where(x => x.OccurredAt).LessThanOrEqual(_base)
            .Build();

        var expected = _events.Where(e => e.OccurredAt <= _base);

        // Act

        var actual = _events.Where(todayOrEarlier);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Between_WhenApplied_ShouldReturnOnlyValuesInRange()
    {
        // Arrange

        var inRange = Filter.For<Event>()
            .Where(x => x.OccurredAt).Between(_base.AddDays(-5), _base)
            .Build();

        var expected = _events.Where(e =>
            e.OccurredAt >= _base.AddDays(-5)
            && e.OccurredAt <= _base);

        // Act

        var actual = _events.Where(inRange);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        DateTime?[] set = [_base.AddDays(-5), _base, _base.AddDays(10)];

        var inSet = Filter.For<Event>()
            .Where(x => x.ScheduledAt).In(set)
            .Build();

        var expected = _events.Where(e => set.Contains(e.ScheduledAt));

        // Act

        var actual = _events.Where(inSet);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Event>()
            .Where(x => x.ScheduledAt).GreaterThan(_base)
            .And(x => x.OccurredAt).Equal(_base)
            .Build();

        var expected = _events.Where(e =>
            e.ScheduledAt > _base
            && e.OccurredAt == _base);

        // Act

        var actual = _events.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public void Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<Event>()
            .Where(x => x.ScheduledAt).IsNull()
            .Or(x => x.OccurredAt).GreaterThan(_base)
            .Build();

        var expected = _events.Where(e =>
            e.ScheduledAt == null
            || e.OccurredAt > _base);

        // Act

        var actual = _events.Where(filter);

        // Assert

        actual.Should().Equal(expected);
    }
}
