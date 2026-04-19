using System.Reflection.Emit;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyStringFilterBuilder{T, TGroupFilterBuilder}" />
public interface IPropertyStringNegatableFilterBuilder<T, out TGroupFilterBuilder> : IPropertyStringFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// Negates the next condition. Can be chained once to invert a single condition.
    /// Calling <c>Not()</c> twice cancels out (double negation).
    /// </summary>
    /// <returns>The builder with negation applied to the next condition.</returns>
    IPropertyStringFilterBuilder<T, TGroupFilterBuilder> Not();
}
