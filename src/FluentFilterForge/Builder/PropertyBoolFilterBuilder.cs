using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyBoolNegatableFilterBuilder{T, TGroupFilterBuilder}" />
internal class PropertyBoolFilterBuilder<T, TGroupFilterBuilder> : IPropertyBoolNegatableFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    private bool _not;

    private readonly FilterGroup _filterGroup;
    private readonly Expression<Func<T, bool?>> _propertySelector;

    internal PropertyBoolFilterBuilder(FilterGroup filterGroup, Expression<Func<T, bool>> propertySelector)
        : this(filterGroup, Expression.Lambda<Func<T, bool?>>(Expression.Convert(propertySelector.Body, typeof(bool?)), propertySelector.Parameters))
    { }

    internal PropertyBoolFilterBuilder(FilterGroup filterGroup, Expression<Func<T, bool?>> propertySelector)
    {
        _filterGroup = filterGroup;
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
        _filterGroup.Nodes.Add(new FilterConditionValue<T, bool?>
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.Equal,
            Not = _not,
            Value = value
        });

        return (TGroupFilterBuilder)(object)new GroupFilterBuilder<T>(_filterGroup);
    }
}
