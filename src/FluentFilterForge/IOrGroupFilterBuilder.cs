using System.Linq.Expressions;

namespace FluentFilterForge;

/// <inheritdoc cref="IGroupFilterBuilder{T}" />
public interface IOrGroupFilterBuilder<T> : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="propertySelector"></param>
    /// <returns></returns>
    INegatablePropertyFilterBuilder<T, TProperty, IOrGroupFilterBuilder<T>> Or<TProperty>(Expression<Func<T, TProperty>> propertySelector);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="configure"></param>
    /// <returns></returns>
    IOrGroupFilterBuilder<T> Or(Action<IFilterBuilder<T>> configure);
}
