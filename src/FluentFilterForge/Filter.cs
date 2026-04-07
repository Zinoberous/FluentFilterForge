using System.Linq.Expressions;
using FluentFilterForge.Builder;
using FluentFilterForge.Interfaces;
using FluentFilterForge.Interfaces.Builder;

namespace FluentFilterForge;

/// <inheritdoc cref="IFilter{T}" />
public static class Filter
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    public static IFilterBuilder<T> For<T>()
        where T : class
        => new FilterBuilder<T>();
}

/// <inheritdoc cref="IFilter{T}" />
public sealed class Filter<T> : IFilter<T>
{
    internal FilterGroup Root { get; } = new();

    /// <inheritdoc/>
    public Expression<Func<T, bool>> ToExpression()
    {
        // TODO: implement ToExpression
        throw new NotImplementedException();
    }
}
