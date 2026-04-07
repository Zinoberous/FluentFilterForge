using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace FluentFilterForge.Interfaces.Builder;

/// <summary>
/// TODO: add documentation
/// </summary>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyCustomFilterBuilder<TEntity, TProperty, out TGroupFilterBuilder> :
    IPropertyFilterBuilder<TEntity, TProperty, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder Check(Expression<Func<TProperty, bool>> predicate);
}
