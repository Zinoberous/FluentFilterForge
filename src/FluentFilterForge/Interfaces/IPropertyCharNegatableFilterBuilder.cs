namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyCharFilterBuilder{T, TGroupFilterBuilder}" />
public interface IPropertyCharNegatableFilterBuilder<T, out TGroupFilterBuilder> : IPropertyCharFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IPropertyCharFilterBuilder<T, TGroupFilterBuilder> Not();
}
