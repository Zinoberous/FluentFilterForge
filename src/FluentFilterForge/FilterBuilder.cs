using System.Linq.Expressions;

namespace FluentFilterForge;

/// <inheritdoc cref="IFilterBuilder{T}" />
internal sealed class FilterBuilder<T> : IFilterBuilder<T>
{
    /// <inheritdoc/>
    public INegatablePropertyFilterBuilder<T, TProperty, IStartGroupFilterBuilder<T>> Where<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        // TODO: implement Where
        throw new NotImplementedException();
    }
}
