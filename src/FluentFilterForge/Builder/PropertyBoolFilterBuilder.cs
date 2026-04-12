using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyBoolNegatableFilterBuilder{T, TGroupFilterBuilder}" />
internal class PropertyBoolFilterBuilder<T, TGroupFilterBuilder> : IPropertyBoolNegatableFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    private bool _not;

    private readonly Filter<T> _filter;
    private readonly Expression<Func<T, bool?>> _propertySelector;

    internal PropertyBoolFilterBuilder(Filter<T> filter, Expression<Func<T, bool>> propertySelector)
        : this(filter, Expression.Lambda<Func<T, bool?>>(Expression.Convert(propertySelector.Body, typeof(bool?)), propertySelector.Parameters))
    { }

    internal PropertyBoolFilterBuilder(Filter<T> filter, Expression<Func<T, bool?>> propertySelector)
    {
        _filter = filter;
        _propertySelector = propertySelector;
    }

    /// <inheritdoc/>
    public IPropertyBoolFilterBuilder<T, TGroupFilterBuilder> Not()
    {
        _not = !_not;
        return this;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
        => Equal(null);

    /// <inheritdoc/>
    public TGroupFilterBuilder IsTrue()
        => Equal(true);

    /// <inheritdoc/>
    public TGroupFilterBuilder IsFalse()
        => Equal(false);

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(bool? value)
    {
        _filter.Root.Nodes.Add(new FilterConditionValue<T, bool?>
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.Equal,
            Not = _not,
            Value = value
        });

        return (TGroupFilterBuilder)(object)new GroupFilterBuilder<T>(_filter);
    }
}
