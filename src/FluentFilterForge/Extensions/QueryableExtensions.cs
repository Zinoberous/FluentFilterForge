using FluentFilterForge.Extensions;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Extensions;

/// <summary>
/// Extension methods for applying <see cref="IFilter{T}"/> to <see cref="IQueryable{T}"/> sources.
/// </summary>
public static class QueryableExtensions
{
    /// <summary>
    /// Filters a queryable source using a <see cref="IFilter{T}"/>.
    /// The expression is passed directly to the query provider (e.g. Entity Framework Core),
    /// enabling server-side evaluation.
    /// </summary>
    /// <typeparam name="T">The type of objects in the queryable source.</typeparam>
    /// <param name="source">The queryable source to filter.</param>
    /// <param name="filter">The filter to apply.</param>
    /// <returns>An <see cref="IQueryable{T}"/> with the filter predicate applied.</returns>
    public static IQueryable<T> Where<T>(this IQueryable<T> source, IFilter<T> filter)
    {
        return source.Where(filter.ToExpression());
    }
}
