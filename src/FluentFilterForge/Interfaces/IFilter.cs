using System.Linq.Expressions;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// Represents a compiled filter.
/// </summary>
public interface IFilter
{
    /// <summary>
    /// Converts the filter into an untyped lambda expression.
    /// </summary>
    LambdaExpression ToExpression();
}

/// <summary>
/// Represents a compiled filter for objects of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
public interface IFilter<T> : IFilter
{
    /// <summary>
    /// Converts the filter into a strongly-typed LINQ expression that can be used
    /// with <c>IEnumerable&lt;T&gt;.Where</c>, <c>IQueryable&lt;T&gt;.Where</c>, or any other predicate-based API.
    /// </summary>
    /// <returns>An <see cref="Expression{TDelegate}"/> that represents the filter predicate.</returns>
    new Expression<Func<T, bool>> ToExpression();
}
