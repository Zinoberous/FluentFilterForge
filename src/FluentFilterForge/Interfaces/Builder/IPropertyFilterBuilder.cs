using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces.Builder;

/// <summary>
/// TODO: add documentation
/// </summary>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyFilterBuilder<TEntity, in TProperty, out TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder IsNull();

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder Equal(TProperty value);
}
