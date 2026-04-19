namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyGuidFilterBuilder{T, TGroupFilterBuilder}" />
public interface IPropertyGuidNegatableFilterBuilder<T, out TGroupFilterBuilder> : IPropertyGuidFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// Negates the next condition. Can be chained once to invert a single condition.
    /// Calling <c>Not()</c> twice cancels out (double negation).
    /// </summary>
    /// <returns>The builder with negation applied to the next condition.</returns>
    IPropertyGuidFilterBuilder<T, TGroupFilterBuilder> Not();
}
