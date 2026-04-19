using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyDateTimeFilterBuilder{T, TDateTime, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyDateTimeNegatableFilterBuilder<T, TDateTime, out TGroupFilterBuilder> : IPropertyDateTimeFilterBuilder<T, TDateTime, TGroupFilterBuilder>
    where TDateTime : struct
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// Negates the next condition. Can be chained once to invert a single condition.
    /// Calling <c>Not()</c> twice cancels out (double negation).
    /// </summary>
    /// <returns>The builder with negation applied to the next condition.</returns>
    IPropertyDateTimeFilterBuilder<T, TDateTime, TGroupFilterBuilder> Not();
}
