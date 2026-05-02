using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public sealed class EventEntity
{
    public int Id { get; set; }
    public DateTime? ScheduledAt { get; set; }
    public DateTime OccurredAt { get; set; }
}

public sealed class DateTimeFilterTestsDbContext(DbContextOptions<DateTimeFilterTestsDbContext> options) : DbContext(options)
{
    public DbSet<EventEntity> Events => Set<EventEntity>();
}

public sealed record Event(DateTime? ScheduledAt, DateTime OccurredAt)
{
    internal static Event Map(EventEntity entity) => new(entity.ScheduledAt, entity.OccurredAt);
}

public sealed class DateTimeFilterTestsFixture : DatabaseTestsFixture<DateTimeFilterTestsDbContext>
{
    private static readonly DateTime _base = new(2024, 6, 15, 12, 0, 0, DateTimeKind.Utc);

    public DateTime Base { get; } = _base;

    public IEnumerable<Event> Events { get; } = [
        new(null, _base.AddDays(-10)),
        new(null, _base),
        new(_base.AddDays(-5), _base.AddDays(-5)),
        new(_base.AddDays(-1), _base.AddDays(-1)),
        new(_base, _base),
        new(_base.AddDays(1), _base),
        new(_base.AddDays(5), _base),
        new(_base.AddDays(10), _base.AddDays(10)),
    ];

    protected override async Task InitializeAsync(DateTimeFilterTestsDbContext context)
    {
        context.Events.AddRange(Events.Select(e => new EventEntity
        {
            ScheduledAt = e.ScheduledAt,
            OccurredAt = e.OccurredAt
        }));

        await context.SaveChangesAsync();
    }
}

public sealed class DateTimeFilterTests(DateTimeFilterTestsFixture fixture) : DatabaseTests<DateTimeFilterTestsDbContext, DateTimeFilterTestsFixture>(fixture)
{
    private readonly DateTimeFilterTestsFixture _fixture = fixture;

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var isUnscheduled = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).IsNull()
            .Build();

        var expected = _fixture.Events.Where(e => e.ScheduledAt == null);

        // Act

        var actual = await Context.Events
            .Where(isUnscheduled)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        var equalValue = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).Equal(_fixture.Base)
            .Build();

        var expected = _fixture.Events.Where(e => e.ScheduledAt == _fixture.Base);

        // Act

        var actual = await Context.Events
            .Where(equalValue)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotBase = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).Not().Equal(_fixture.Base)
            .Build();

        var expected = _fixture.Events.Where(e => e.ScheduledAt != _fixture.Base);

        // Act

        var actual = await Context.Events
            .Where(isNotBase)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task GreaterThan_WhenApplied_ShouldReturnOnlyGreaterValues()
    {
        // Arrange

        var future = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).GreaterThan(_fixture.Base)
            .Build();

        var expected = _fixture.Events.Where(e => e.OccurredAt > _fixture.Base);

        // Act

        var actual = await Context.Events
            .Where(future)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task GreaterThanOrEqual_WhenApplied_ShouldReturnOnlyGreaterOrEqualValues()
    {
        // Arrange

        var todayOrLater = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).GreaterThanOrEqual(_fixture.Base)
            .Build();

        var expected = _fixture.Events.Where(e => e.OccurredAt >= _fixture.Base);

        // Act

        var actual = await Context.Events
            .Where(todayOrLater)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task LessThan_WhenApplied_ShouldReturnOnlyLessValues()
    {
        // Arrange

        var past = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).LessThan(_fixture.Base)
            .Build();

        var expected = _fixture.Events.Where(e => e.OccurredAt < _fixture.Base);

        // Act

        var actual = await Context.Events
            .Where(past)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task LessThanOrEqual_WhenApplied_ShouldReturnOnlyLessOrEqualValues()
    {
        // Arrange

        var todayOrEarlier = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).LessThanOrEqual(_fixture.Base)
            .Build();

        var expected = _fixture.Events.Where(e => e.OccurredAt <= _fixture.Base);

        // Act

        var actual = await Context.Events
            .Where(todayOrEarlier)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Between_WhenApplied_ShouldReturnOnlyValuesInRange()
    {
        // Arrange

        var inRange = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).Between(_fixture.Base.AddDays(-5), _fixture.Base)
            .Build();

        var expected = _fixture.Events.Where(e => e.OccurredAt >= _fixture.Base.AddDays(-5) && e.OccurredAt <= _fixture.Base);

        // Act

        var actual = await Context.Events
            .Where(inRange)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        DateTime?[] set = [_fixture.Base.AddDays(-5), _fixture.Base, _fixture.Base.AddDays(10)];

        var inSet = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).In(set)
            .Build();

        var expected = _fixture.Events.Where(e => set.Contains(e.ScheduledAt));

        // Act

        var actual = await Context.Events
            .Where(inSet)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).GreaterThan(_fixture.Base)
            .And(x => x.OccurredAt).Equal(_fixture.Base)
            .Build();

        var expected = _fixture.Events.Where(e =>
            e.ScheduledAt > _fixture.Base
            && e.OccurredAt == _fixture.Base);

        // Act

        var actual = await Context.Events
            .Where(filter)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).IsNull()
            .Or(x => x.OccurredAt).GreaterThan(_fixture.Base)
            .Build();

        var expected = _fixture.Events.Where(e =>
            e.ScheduledAt == null
            || e.OccurredAt > _fixture.Base);

        // Act

        var actual = await Context.Events
            .Where(filter)
            .Select(x => Event.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }
}
