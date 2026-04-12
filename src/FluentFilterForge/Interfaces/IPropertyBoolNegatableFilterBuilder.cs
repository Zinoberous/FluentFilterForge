namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyBoolFilterBuilder{T, TGroupFilterBuilder}" />
public interface IPropertyBoolNegatableFilterBuilder<T, out TGroupFilterBuilder> : IPropertyBoolFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IPropertyBoolFilterBuilder<T, TGroupFilterBuilder> Not();
}
