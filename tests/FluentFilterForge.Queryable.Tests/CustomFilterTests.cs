using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public class CustomFilterTests
{
    public enum Priority { Low, Medium, High }

    private sealed class TaskEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Priority? Priority { get; set; }
    }

    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<TaskEntity> Tasks => Set<TaskEntity>();
    }

    private sealed record WorkTask(string Title, Priority? Priority)
    {
        internal static WorkTask Map(TaskEntity entity) => new(entity.Title, entity.Priority);
    }

    private static readonly WorkTask[] _tasks = [
        new("Write docs", null),
        new("Fix bug", Priority.High),
        new("Refactor code", Priority.Medium),
        new("Add tests", Priority.High),
        new("Update deps", Priority.Low),
        new("Review PR", null),
    ];

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedTasksAsync(context);

        var isNull = Filter.For<TaskEntity>()
            .Where(x => x.Priority).IsNull()
            .Build();

        var expected = _tasks.Where(t => t.Priority == null);

        // Act

        var actual = await context.Tasks
            .Where(isNull)
            .Select(x => WorkTask.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData(Priority.High)]
    [InlineData(null)]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(Priority? value)
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedTasksAsync(context);

        var equalValue = Filter.For<TaskEntity>()
            .Where(x => x.Priority).Equal(value)
            .Build();

        var expected = _tasks.Where(t => t.Priority == value);

        // Act

        var actual = await context.Tasks
            .Where(equalValue)
            .Select(x => WorkTask.Map(x))
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

        await SeedTasksAsync(context);

        var isNotHigh = Filter.For<TaskEntity>()
            .Where(x => x.Priority).Not().Equal(Priority.High)
            .Build();

        var expected = _tasks.Where(t => t.Priority != Priority.High);

        // Act

        var actual = await context.Tasks
            .Where(isNotHigh)
            .Select(x => WorkTask.Map(x))
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

        await SeedTasksAsync(context);

        var filter = Filter.For<TaskEntity>()
            .Where(x => x.Priority).Equal(Priority.High)
            .And(x => x.Title).StartsWith("Fix")
            .Build();

        var expected = _tasks.Where(t =>
            t.Priority == Priority.High
            && t.Title.StartsWith("Fix", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await context.Tasks
            .Where(filter)
            .Select(x => WorkTask.Map(x))
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

        await SeedTasksAsync(context);

        var filter = Filter.For<TaskEntity>()
            .Where(x => x.Priority).IsNull()
            .Or(x => x.Priority).Equal(Priority.Low)
            .Build();

        var expected = _tasks.Where(t =>
            t.Priority == null
            || t.Priority == Priority.Low);

        // Act

        var actual = await context.Tasks
            .Where(filter)
            .Select(x => WorkTask.Map(x))
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

    private static async Task SeedTasksAsync(TestDbContext context)
    {
        context.Tasks.AddRange(_tasks.Select((t, i) => new TaskEntity
        {
            Id = i + 1,
            Title = t.Title,
            Priority = t.Priority
        }));

        await context.SaveChangesAsync();
    }
}
