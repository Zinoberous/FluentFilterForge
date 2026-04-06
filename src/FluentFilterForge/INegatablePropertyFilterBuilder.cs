using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge;

/// <inheritdoc cref="IPropertyFilterBuilder{T, TProperty, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface INegatablePropertyFilterBuilder<T, in TProperty, out TGroupFilterBuilder> : IPropertyFilterBuilder<T, TProperty, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IPropertyFilterBuilder<T, TProperty, TGroupFilterBuilder> Not();
}
