using System.Linq.Expressions;

namespace FluentFilterForge;

/// <inheritdoc cref="IStartGroupFilterBuilder{T}" />
internal sealed class GroupFilterBuilder<T> : IStartGroupFilterBuilder<T>
{
    /// <inheritdoc/>
    public INegatablePropertyFilterBuilder<T, TProperty, IAndGroupFilterBuilder<T>> And<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        // TODO: implement And
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IAndGroupFilterBuilder<T> And(Action<IFilterBuilder<T>> configure)
    {
        // TODO: implement And with nested configuration
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public INegatablePropertyFilterBuilder<T, TProperty, IOrGroupFilterBuilder<T>> Or<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        // TODO: implement Or
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IOrGroupFilterBuilder<T> Or(Action<IFilterBuilder<T>> configure)
    {
        // TODO: implement Or with nested configuration
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Filter<T> Build()
    {
        // TODO: implement Build
        throw new NotImplementedException();
    }
}
