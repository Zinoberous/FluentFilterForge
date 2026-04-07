using FluentFilterForge.Extensions;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Extensions;

/// <summary>
/// TODO: add documentation
/// </summary>
public static class QueryableExtensions
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="source"></param>
    /// <param name="filter"></param>
    /// <returns></returns>
    public static IQueryable<T> Where<T>(this IQueryable<T> source, IFilter<T> filter)
    {
        return source.Where(filter.ToExpression());
    }
}
