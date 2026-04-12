namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyGuidFilterBuilder{T, TGroupFilterBuilder}" />
public interface IPropertyGuidNegatableFilterBuilder<T, out TGroupFilterBuilder> : IPropertyGuidFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IPropertyGuidFilterBuilder<T, TGroupFilterBuilder> Not();
}
