using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyEnumerableFilterBuilder{T, TEnumerable, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyEnumerableNegatableFilterBuilder<T, TEnumerable, out TGroupFilterBuilder> : IPropertyEnumerableFilterBuilder<T, TEnumerable, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IPropertyEnumerableFilterBuilder<T, TEnumerable, TGroupFilterBuilder> Not();
}
