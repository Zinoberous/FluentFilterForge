using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace FluentFilterForge.Interfaces.Builder;

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
    TGroupFilterBuilder Any(Expression<Func<TElement, bool>> predicate);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder All(Expression<Func<TElement, bool>> predicate);
}
