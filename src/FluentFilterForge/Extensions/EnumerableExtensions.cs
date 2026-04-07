using FluentFilterForge.Extensions;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Extensions;

/// <summary>
/// TODO: add documentation
/// </summary>
public static class EnumerableExtensions
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="source"></param>
    /// <param name="filter"></param>
    /// <returns></returns>
    public static IEnumerable<T> Where<T>(this IEnumerable<T> source, IFilter<T> filter)
    {
        return source.Where(filter.ToExpression().Compile());
    }
}
