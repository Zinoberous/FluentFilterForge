using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public sealed class TokenEntity
{
    public int Id { get; set; }
    public char? Category { get; set; }
    public char Grade { get; set; }
}

public sealed class CharFilterTestsDbContext(DbContextOptions<CharFilterTestsDbContext> options) : DbContext(options)
{
    public DbSet<TokenEntity> Tokens => Set<TokenEntity>();
}

public sealed record Token(char? Category, char Grade)
{
    internal static Token Map(TokenEntity entity) => new(entity.Category, entity.Grade);
}

public sealed class CharFilterTestsFixture : DatabaseTestsFixture<CharFilterTestsDbContext>
{
    public Token[] Tokens { get; } = [
        new(null, 'F'),
        new(null, 'D'),
        new('A', 'F'),
        new('A', 'C'),
        new('B', 'D'),
        new('B', 'A'),
        new('C', 'B'),
        new('C', 'A'),
    ];

    protected override async Task InitializeAsync(CharFilterTestsDbContext context)
    {
        context.Tokens.AddRange(Tokens.Select(t => new TokenEntity
        {
            Category = t.Category,
            Grade = t.Grade
        }));

        await context.SaveChangesAsync();
    }
}

public sealed class CharFilterTests(CharFilterTestsFixture fixture) : DatabaseTests<CharFilterTestsDbContext, CharFilterTestsFixture>(fixture)
{
    private readonly CharFilterTestsFixture _fixture = fixture;

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        var isNull = Filter.For<TokenEntity>()
            .Where(x => x.Category).IsNull()
            .Build();

        var expected = _fixture.Tokens.Where(t => t.Category == null);

        // Act

        var actual = await Context.Tokens
            .Where(isNull)
            .Select(x => Token.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData('A')]
    [InlineData(null)]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(char? value)
    {
        // Arrange

        var equalValue = Filter.For<TokenEntity>()
            .Where(x => x.Category).Equal(value)
            .Build();

        var expected = _fixture.Tokens.Where(t => t.Category == value);

        // Act

        var actual = await Context.Tokens
            .Where(equalValue)
            .Select(x => Token.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        var isNotA = Filter.For<TokenEntity>()
            .Where(x => x.Category).Not().Equal('A')
            .Build();

        var expected = _fixture.Tokens.Where(t => t.Category != 'A');

        // Act

        var actual = await Context.Tokens
            .Where(isNotA)
            .Select(x => Token.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task In_WhenApplied_ShouldReturnOnlyMatchingValues()
    {
        // Arrange

        char?[] set = ['A', 'C'];

        var inSet = Filter.For<TokenEntity>()
            .Where(x => x.Category).In(set)
            .Build();

        var expected = _fixture.Tokens.Where(t => set.Contains(t.Category));

        // Act

        var actual = await Context.Tokens
            .Where(inSet)
            .Select(x => Token.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        var filter = Filter.For<TokenEntity>()
            .Where(x => x.Category).Equal('A')
            .And(x => x.Grade).Equal('C')
            .Build();

        var expected = _fixture.Tokens.Where(t =>
            t.Category == 'A'
            && t.Grade == 'C');

        // Act

        var actual = await Context.Tokens
            .Where(filter)
            .Select(x => Token.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        var filter = Filter.For<TokenEntity>()
            .Where(x => x.Category).IsNull()
            .Or(x => x.Grade).Equal('A')
            .Build();

        var expected = _fixture.Tokens.Where(t =>
            t.Category == null
            || t.Grade == 'A');

        // Act

        var actual = await Context.Tokens
            .Where(filter)
            .Select(x => Token.Map(x))
            .ToListAsync(TestContext.Current.CancellationToken);

        // Assert

        actual.Should().Equal(expected);
    }
}
