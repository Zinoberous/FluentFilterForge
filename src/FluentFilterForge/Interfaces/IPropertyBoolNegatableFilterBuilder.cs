namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyBoolFilterBuilder{T, TGroupFilterBuilder}" />
public interface IPropertyBoolNegatableFilterBuilder<T, out TGroupFilterBuilder> : IPropertyBoolFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// Negates the next condition. Can be chained once to invert a single condition.
    /// Calling <c>Not()</c> twice cancels out (double negation).
    /// </summary>
    /// <returns>The builder with negation applied to the next condition.</returns>
    IPropertyBoolFilterBuilder<T, TGroupFilterBuilder> Not();
}
