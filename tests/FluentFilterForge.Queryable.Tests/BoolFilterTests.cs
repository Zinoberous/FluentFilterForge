using FluentAssertions;
using FluentFilterForge.Extensions;
using FluentFilterForge.Interfaces;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FluentFilterForge.Queryable.Tests;

public class BoolFilterTests
{
    private sealed class CustomerEntity
    {
        public int Id { get; set; }
        public bool? IsVerified { get; set; }
        public bool? IsInsured { get; set; }
        public bool IsDeleted { get; set; }
    }

    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<CustomerEntity> Customers => Set<CustomerEntity>();
    }

    private sealed record Customer(bool? IsVerified, bool? IsInsured, bool IsDeleted)
    {
        internal static Customer Map(CustomerEntity entity) => new(entity.IsVerified, entity.IsInsured, entity.IsDeleted);
    }

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
    public async Task IsTrue_WhenApplied_ShouldReturnOnlyTrueValues()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        await SeedCustomersAsync(context);

        var isVerified = Filter.For<CustomerEntity>()
            .Where(x => x.IsVerified).IsTrue()
            .Build();

        var expected = _customers.Where(c => c.IsVerified == true);

        // Act
        var actual = await context.Customers
            .Where(isVerified)
            .Select(x => Customer.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task IsFalse_WhenApplied_ShouldReturnOnlyFalseValues()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        await SeedCustomersAsync(context);

        var isNotVerified = Filter.For<CustomerEntity>()
            .Where(x => x.IsVerified).IsFalse()
            .Build();

        var expected = _customers.Where(c => c.IsVerified == false);

        // Act

        var actual = await context.Customers
            .Where(isNotVerified)
            .Select(x => Customer.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task IsNull_WhenApplied_ShouldReturnOnlyNullValues()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        await SeedCustomersAsync(context);

        var isPendingVerification = Filter.For<CustomerEntity>()
            .Where(x => x.IsVerified).IsNull()
            .Build();

        var expected = _customers.Where(c => c.IsVerified == null);

        // Act

        var actual = await context.Customers
            .Where(isPendingVerification)
            .Select(x => Customer.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    [InlineData(null)]
    public async Task Equal_WhenValueIsSpecified_ShouldReturnOnlyMatchingValues(bool? value)
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        await SeedCustomersAsync(context);

        var equalValue = Filter.For<CustomerEntity>()
            .Where(x => x.IsVerified).Equal(value)
            .Build();

        var expected = _customers.Where(c => c.IsVerified == value);

        // Act

        var actual = await context.Customers
            .Where(equalValue)
            .Select(x => Customer.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Equal_WhenNegated_ShouldReturnInverseMatches()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        await SeedCustomersAsync(context);

        var isNotVerified = Filter.For<CustomerEntity>()
            .Where(x => x.IsVerified).Not().Equal(true)
            .Build();

        var expected = _customers.Where(c => c.IsVerified != true);

        // Act

        var actual = await context.Customers
            .Where(isNotVerified)
            .Select(x => Customer.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task And_WhenBothConditionsMatch_ShouldReturnOnlyMatchingItems()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        await SeedCustomersAsync(context);

        var isActive = Filter.For<CustomerEntity>()
            .Where(x => x.IsVerified).IsTrue()
            .And(x => x.IsDeleted).IsFalse()
            .Build();

        var expected = _customers.Where(c => c.IsVerified == true && !c.IsDeleted);

        // Act

        var actual = await context.Customers
            .Where(isActive)
            .Select(x => Customer.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task Or_WhenAtLeastOneConditionMatches_ShouldReturnMatchingItems()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        await SeedCustomersAsync(context);

        var isNotActive = Filter.For<CustomerEntity>()
            .Where(x => x.IsVerified).IsNull()
            .Or(x => x.IsVerified).IsFalse()
            .Or(x => x.IsDeleted).IsTrue()
            .Build();

        var expected = _customers.Where(c => c.IsVerified == null || c.IsVerified == false || c.IsDeleted);

        // Act

        var actual = await context.Customers
            .Where(isNotActive)
            .Select(x => Customer.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task AndNestedOr_WhenApplied_ShouldReturnItemsMatchingAndWithNestedOr()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        await SeedCustomersAsync(context);

        var isRegistrationPendingWithoutInsurance = Filter.For<CustomerEntity>()
            .Where(x => x.IsVerified).IsNull()
            .And(x => x.IsDeleted).IsFalse()
            .And((IFilterBuilder<CustomerEntity> group) => group
                .Where(x => x.IsInsured).IsNull()
                .Or(x => x.IsInsured).IsFalse())
            .Build();

        var expected = _customers.Where(c =>
            c.IsVerified == null
            && !c.IsDeleted
            && (c.IsInsured == null
                || c.IsInsured == false));

        // Act

        var actual = await context.Customers
            .Where(isRegistrationPendingWithoutInsurance)
            .Select(x => Customer.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    [Fact]
    public async Task OrNestedAnd_WhenApplied_ShouldReturnItemsMatchingOrWithNestedAnd()
    {
        // Arrange

        await using var connection = CreateOpenConnection();
        await using var context = CreateContext(connection);

        await SeedCustomersAsync(context);

        var isNeverActivated = Filter.For<CustomerEntity>()
            .Where(x => x.IsVerified).IsFalse()
            .Or((IFilterBuilder<CustomerEntity> group) => group
                .Where(x => x.IsVerified).IsNull()
                .And(x => x.IsDeleted).IsTrue())
            .Build();

        var expected = _customers.Where(c =>
            c.IsVerified == false
            || (c.IsVerified == null
                && c.IsDeleted));

        // Act

        var actual = await context.Customers
            .Where(isNeverActivated)
            .Select(x => Customer.Map(x))
            .ToListAsync();

        // Assert

        actual.Should().Equal(expected);
    }

    private static SqliteConnection CreateOpenConnection()
    {
        SqliteConnection connection = new("Data Source=:memory:");
        connection.Open();

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

    private static async Task SeedCustomersAsync(TestDbContext context)
    {
        context.Customers.AddRange(_customers.Select((c, i) => new CustomerEntity
        {
            Id = i + 1,
            IsVerified = c.IsVerified,
            IsInsured = c.IsInsured,
            IsDeleted = c.IsDeleted
        }));

        await context.SaveChangesAsync();
    }
}
