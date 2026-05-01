using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public class CharFilterTests
{
    private sealed class TokenEntity
    {
        public int Id { get; set; }
        public char? Category { get; set; }
        public char Grade { get; set; }
    }

    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<TokenEntity> Tokens => Set<TokenEntity>();
    }

    private sealed record Token(char? Category, char Grade)
    {
        internal static Token Map(TokenEntity entity) => new(entity.Category, entity.Grade);
    }

    private static readonly Token[] _tokens = [
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
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedTokensAsync(context);

        var isNull = Filter.For<TokenEntity>()
            .Where(x => x.Category).IsNull()
            .Build();

        var expected = _tokens.Where(t => t.Category == null);

        // Act

        var actual = await context.Tokens
            .Where(isNull)
            .Select(x => Token.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData('A')]
    [InlineData(null)]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(char? value)
    {
        // Arrange

        await using var connection = await CreateOpenConnectionAsync();
        await using var context = CreateContext(connection);

        await SeedTokensAsync(context);

        var equalValue = Filter.For<TokenEntity>()
            .Where(x => x.Category).Equal(value)
            .Build();

        var expected = _tokens.Where(t => t.Category == value);

        // Act

        var actual = await context.Tokens
            .Where(equalValue)
            .Select(x => Token.Map(x))
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

        await SeedTokensAsync(context);

        var isNotA = Filter.For<TokenEntity>()
            .Where(x => x.Category).Not().Equal('A')
            .Build();

        var expected = _tokens.Where(t => t.Category != 'A');

        // Act

        var actual = await context.Tokens
            .Where(isNotA)
            .Select(x => Token.Map(x))
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

        await SeedTokensAsync(context);

        char?[] set = ['A', 'C'];

        var inSet = Filter.For<TokenEntity>()
            .Where(x => x.Category).In(set)
            .Build();

        var expected = _tokens.Where(t => set.Contains(t.Category));

        // Act

        var actual = await context.Tokens
            .Where(inSet)
            .Select(x => Token.Map(x))
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

        await SeedTokensAsync(context);

        var filter = Filter.For<TokenEntity>()
            .Where(x => x.Category).Equal('A')
            .And(x => x.Grade).Equal('C')
            .Build();

        var expected = _tokens.Where(t =>
            t.Category == 'A'
            && t.Grade == 'C');

        // Act

        var actual = await context.Tokens
            .Where(filter)
            .Select(x => Token.Map(x))
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

        await SeedTokensAsync(context);

        var filter = Filter.For<TokenEntity>()
            .Where(x => x.Category).IsNull()
            .Or(x => x.Grade).Equal('A')
            .Build();

        var expected = _tokens.Where(t =>
            t.Category == null
            || t.Grade == 'A');

        // Act

        var actual = await context.Tokens
            .Where(filter)
            .Select(x => Token.Map(x))
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

    private static async Task SeedTokensAsync(TestDbContext context)
    {
        context.Tokens.AddRange(_tokens.Select((t, i) => new TokenEntity
        {
            Id = i + 1,
            Category = t.Category,
            Grade = t.Grade
        }));

        await context.SaveChangesAsync();
    }
}
