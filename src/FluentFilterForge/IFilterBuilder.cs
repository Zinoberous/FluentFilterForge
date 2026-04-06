using System.Linq.Expressions;

namespace FluentFilterForge;

/// <summary>
/// TODO: add documentation
/// </summary>
public interface IFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="propertySelector"></param>
    /// <returns></returns>
    INegatablePropertyFilterBuilder<T, TProperty, IStartGroupFilterBuilder<T>> Where<TProperty>(Expression<Func<T, TProperty>> propertySelector);
}
