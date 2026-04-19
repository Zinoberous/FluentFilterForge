using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// Provides filter conditions for a collection property of element type <typeparamref name="TElement"/>.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
/// <typeparam name="TElement">The element type of the collection.</typeparam>
/// <typeparam name="TGroupFilterBuilder">The type of the builder returned after a condition is set.</typeparam>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyEnumerableFilterBuilder<T, TElement, out TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>Matches items where the collection property is <see langword="null"/>.</summary>
    TGroupFilterBuilder IsNull();

    /// <summary>Matches items where the collection property is <see langword="null"/> or contains no elements.</summary>
    TGroupFilterBuilder IsNullOrEmpty();

    /// <summary>Matches items where the collection property equals <paramref name="value"/> by reference.</summary>
    /// <param name="value">The collection to compare against.</param>
    TGroupFilterBuilder Equal(IEnumerable<TElement>? value);

    /// <summary>
    /// Matches items where at least one element in the collection satisfies the sub-filter
    /// configured via <paramref name="configure"/>.
    /// </summary>
    /// <param name="configure">A delegate to configure a filter on elements of type <typeparamref name="TElement"/>.</param>
    TGroupFilterBuilder Any(Action<IFilterBuilder<TElement>> configure);

    /// <summary>
    /// Matches items where all elements in the collection satisfy the sub-filter
    /// configured via <paramref name="configure"/>.
    /// </summary>
    /// <param name="configure">A delegate to configure a filter on elements of type <typeparamref name="TElement"/>.</param>
    TGroupFilterBuilder All(Action<IFilterBuilder<TElement>> configure);
}
