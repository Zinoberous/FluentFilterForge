using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// TODO: add documentation
/// </summary>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyEnumerableFilterBuilder<TEntity, TElement, out TGroupFilterBuilder> :
    IPropertyFilterBuilder<TEntity, TElement, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder IsNullOrEmpty();

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder Any(Action<IFilterBuilder<TElement>> configure);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder All(Action<IFilterBuilder<TElement>> configure);
}
