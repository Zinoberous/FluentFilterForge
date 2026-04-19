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
    /// Negates the next condition. Can be chained once to invert a single condition.
    /// Calling <c>Not()</c> twice cancels out (double negation).
    /// </summary>
    /// <returns>The builder with negation applied to the next condition.</returns>
    IPropertyNumberFilterBuilder<T, TNumber, TGroupFilterBuilder> Not();
}
