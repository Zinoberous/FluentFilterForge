using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyNumberFilterBuilder{T, TNumber, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyNumberNegatableFilterBuilder<T, TNumber, out TGroupFilterBuilder> : IPropertyNumberFilterBuilder<T, TNumber, TGroupFilterBuilder>
    where TNumber : struct, INumber<TNumber>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IPropertyNumberFilterBuilder<T, TNumber, TGroupFilterBuilder> Not();
}
