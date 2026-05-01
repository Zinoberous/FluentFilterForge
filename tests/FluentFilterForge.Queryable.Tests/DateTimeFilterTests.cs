using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public class DateTimeFilterTests
{
    private sealed class EventEntity
    {
        public int Id { get; set; }
        public DateTime? ScheduledAt { get; set; }
        public DateTime OccurredAt { get; set; }
    }

    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<EventEntity> Events => Set<EventEntity>();
    }

    private sealed record Event(DateTime? ScheduledAt, DateTime OccurredAt)
    {
        internal static Event Map(EventEntity entity) => new(entity.ScheduledAt, entity.OccurredAt);
    }

    private static readonly DateTime _base = new(2024, 6, 15, 12, 0, 0, DateTimeKind.Utc);

    private static readonly Event[] _events = [
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
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var isUnscheduled = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).IsNull()
            .Build();

        var expected = _events.Where(e => e.ScheduledAt == null);

        // Act

        var actual = await context.Events
            .Where(isUnscheduled)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var equalValue = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).Equal(_base)
            .Build();

        var expected = _events.Where(e => e.ScheduledAt == _base);

        // Act

        var actual = await context.Events
            .Where(equalValue)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var isNotBase = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).Not().Equal(_base)
            .Build();

        var expected = _events.Where(e => e.ScheduledAt != _base);

        // Act

        var actual = await context.Events
            .Where(isNotBase)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task GreaterThan_WhenApplied_ShouldReturnOnlyGreaterValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var future = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).GreaterThan(_base)
            .Build();

        var expected = _events.Where(e => e.OccurredAt > _base);

        // Act

        var actual = await context.Events
            .Where(future)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task GreaterThanOrEqual_WhenApplied_ShouldReturnOnlyGreaterOrEqualValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var todayOrLater = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).GreaterThanOrEqual(_base)
            .Build();

        var expected = _events.Where(e => e.OccurredAt >= _base);

        // Act

        var actual = await context.Events
            .Where(todayOrLater)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task LessThan_WhenApplied_ShouldReturnOnlyLessValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var past = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).LessThan(_base)
            .Build();

        var expected = _events.Where(e => e.OccurredAt < _base);

        // Act

        var actual = await context.Events
            .Where(past)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task LessThanOrEqual_WhenApplied_ShouldReturnOnlyLessOrEqualValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var todayOrEarlier = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).LessThanOrEqual(_base)
            .Build();

        var expected = _events.Where(e => e.OccurredAt <= _base);

        // Act

        var actual = await context.Events
            .Where(todayOrEarlier)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Between_WhenApplied_ShouldReturnOnlyValuesInRange()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var inRange = Filter.For<EventEntity>()
            .Where(x => x.OccurredAt).Between(_base.AddDays(-5), _base)
            .Build();

        var expected = _events.Where(e => e.OccurredAt >= _base.AddDays(-5) && e.OccurredAt <= _base);

        // Act

        var actual = await context.Events
            .Where(inRange)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        DateTime?[] set = [_base.AddDays(-5), _base, _base.AddDays(10)];

        var inSet = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).In(set)
            .Build();

        var expected = _events.Where(e => set.Contains(e.ScheduledAt));

        // Act

        var actual = await context.Events
            .Where(inSet)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var filter = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).GreaterThan(_base)
            .And(x => x.OccurredAt).Equal(_base)
            .Build();

        var expected = _events.Where(e =>
            e.ScheduledAt > _base
            && e.OccurredAt == _base);

        // Act

        var actual = await context.Events
            .Where(filter)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedEventsAsync(context);

        var filter = Filter.For<EventEntity>()
            .Where(x => x.ScheduledAt).IsNull()
            .Or(x => x.OccurredAt).GreaterThan(_base)
            .Build();

        var expected = _events.Where(e =>
            e.ScheduledAt == null
            || e.OccurredAt > _base);

        // Act

        var actual = await context.Events
            .Where(filter)
            .Select(x => Event.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    private static async Task<SqliteConnection> CreateOpenConnectionAsync()
    {
        SqliteConnection connection = new("Data Source=:memory:");
        await connection.OpenAsync();

        return connection;
    }

    private static TestDbContext CreateContext(SqliteConnection connection)
    {
        var options = new DbContextOptionsBuilder<TestDbContext>()
            .UseSqlite(connection)
            .Options;

        TestDbContext context = new(options);
        context.Database.EnsureCreated();

        return context;
    }

    private static async Task SeedEventsAsync(TestDbContext context)
    {
        context.Events.AddRange(_events.Select((e, i) => new EventEntity
        {
            Id = i + 1,
            ScheduledAt = e.ScheduledAt,
            OccurredAt = e.OccurredAt
        }));

        await context.SaveChangesAsync();
    }
}
