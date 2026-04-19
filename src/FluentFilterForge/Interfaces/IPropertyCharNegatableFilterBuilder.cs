namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyCharFilterBuilder{T, TGroupFilterBuilder}" />
public interface IPropertyCharNegatableFilterBuilder<T, out TGroupFilterBuilder> : IPropertyCharFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// Negates the next condition. Can be chained once to invert a single condition.
    /// Calling <c>Not()</c> twice cancels out (double negation).
    /// </summary>
    /// <returns>The builder with negation applied to the next condition.</returns>
    IPropertyCharFilterBuilder<T, TGroupFilterBuilder> Not();
}
