using System.Linq.Expressions;

namespace FluentFilterForge;

/// <inheritdoc cref="IGroupFilterBuilder{T}" />
public interface IAndGroupFilterBuilder<T> : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="propertySelector"></param>
    /// <returns></returns>
    INegatablePropertyFilterBuilder<T, TProperty, IAndGroupFilterBuilder<T>> And<TProperty>(Expression<Func<T, TProperty>> propertySelector);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="configure"></param>
    /// <returns></returns>
    IAndGroupFilterBuilder<T> And(Action<IFilterBuilder<T>> configure);
}
