using System.Reflection.Emit;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyStringFilterBuilder{T, TGroupFilterBuilder}" />
public interface IPropertyStringNegatableFilterBuilder<T, out TGroupFilterBuilder> : IPropertyStringFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IPropertyStringFilterBuilder<T, TGroupFilterBuilder> Not();
}
