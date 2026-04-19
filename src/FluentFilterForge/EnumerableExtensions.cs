using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

/// <summary>
/// Extension methods for applying <see cref="IFilter{T}"/> to <see cref="IEnumerable{T}"/> sequences.
/// </summary>
public static class EnumerableExtensions
{
    /// <summary>
    /// Filters a sequence using a <see cref="IFilter{T}"/>.
    /// The filter expression is compiled once and applied to every element.
    /// </summary>
    /// <typeparam name="T">The type of objects in the sequence.</typeparam>
    /// <param name="source">The source sequence to filter.</param>
    /// <param name="filter">The filter to apply.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> containing only the elements that satisfy the filter.</returns>
    public static IEnumerable<T> Where<T>(this IEnumerable<T> source, IFilter<T> filter)
    {
        return source.Where(filter.ToExpression().Compile());
    }
}
