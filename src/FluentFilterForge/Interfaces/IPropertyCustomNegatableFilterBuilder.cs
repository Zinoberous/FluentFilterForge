using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyCustomFilterBuilder{T, TProperty, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyCustomNegatableFilterBuilder<T, TProperty, out TGroupFilterBuilder> : IPropertyCustomFilterBuilder<T, TProperty, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IPropertyCustomFilterBuilder<T, TProperty, TGroupFilterBuilder> Not();
}
