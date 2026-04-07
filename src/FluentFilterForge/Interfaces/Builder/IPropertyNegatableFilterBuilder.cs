using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces.Builder;

/// <summary>
/// TODO: add documentation
/// </summary>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyNegatableFilterBuilder<TEntity, in TProperty, out TGroupFilterBuilder, out TPropertyBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
    where TPropertyBuilder : IPropertyFilterBuilder<TEntity, TProperty, TGroupFilterBuilder>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TPropertyBuilder Not();
}
