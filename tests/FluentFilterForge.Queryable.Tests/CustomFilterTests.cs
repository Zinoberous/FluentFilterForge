using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public enum Priority { Low, Medium, High }

public sealed class TaskEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public Priority? Priority { get; set; }
}

public sealed class CustomFilterTestsDbContext(DbContextOptions<CustomFilterTestsDbContext> options) : DbContext(options)
{
    public DbSet<TaskEntity> Tasks => Set<TaskEntity>();
}

public sealed record WorkTask(string Title, Priority? Priority)
{
    internal static WorkTask Map(TaskEntity entity) => new(entity.Title, entity.Priority);
}

public sealed class CustomFilterTestsFixture : DatabaseTestsFixture<CustomFilterTestsDbContext>
{
    public IEnumerable<WorkTask> Tasks { get; } = [
        new("Write docs", null),
        new("Fix bug", Priority.High),
        new("Refactor code", Priority.Medium),
        new("Add tests", Priority.High),
        new("Update deps", Priority.Low),
        new("Review PR", null),
    ];

    protected override async Task InitializeAsync(CustomFilterTestsDbContext context)
    {
        context.Tasks.AddRange(Tasks.Select(t => new TaskEntity
        {
            Title = t.Title,
            Priority = t.Priority
        }));

        await context.SaveChangesAsync();
    }
}

public sealed class CustomFilterTests(CustomFilterTestsFixture fixture) : DatabaseTests<CustomFilterTestsDbContext, CustomFilterTestsFixture>(fixture)
{
    private readonly CustomFilterTestsFixture _fixture = fixture;

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var isNull = Filter.For<TaskEntity>()
            .Where(x => x.Priority).IsNull()
            .Build();

        var expected = _fixture.Tasks.Where(t => t.Priority == null);

        // Act

        var actual = await Context.Tasks
            .Where(isNull)
            .Select(x => WorkTask.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData(Priority.High)]
    [InlineData(null)]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(Priority? value)
    {
        // Arrange

        var equalValue = Filter.For<TaskEntity>()
            .Where(x => x.Priority).Equal(value)
            .Build();

        var expected = _fixture.Tasks.Where(t => t.Priority == value);

        // Act

        var actual = await Context.Tasks
            .Where(equalValue)
            .Select(x => WorkTask.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotHigh = Filter.For<TaskEntity>()
            .Where(x => x.Priority).Not().Equal(Priority.High)
            .Build();

        var expected = _fixture.Tasks.Where(t => t.Priority != Priority.High);

        // Act

        var actual = await Context.Tasks
            .Where(isNotHigh)
            .Select(x => WorkTask.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<TaskEntity>()
            .Where(x => x.Priority).Equal(Priority.High)
            .And(x => x.Title).StartsWith("Fix")
            .Build();

        var expected = _fixture.Tasks.Where(t =>
            t.Priority == Priority.High
            && t.Title.StartsWith("Fix", StringComparison.OrdinalIgnoreCase));

        // Act

        var actual = await Context.Tasks
            .Where(filter)
            .Select(x => WorkTask.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<TaskEntity>()
            .Where(x => x.Priority).IsNull()
            .Or(x => x.Priority).Equal(Priority.Low)
            .Build();

        var expected = _fixture.Tasks.Where(t =>
            t.Priority == null
            || t.Priority == Priority.Low);

        // Act

        var actual = await Context.Tasks
            .Where(filter)
            .Select(x => WorkTask.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }
}
