using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyBoolNegatableFilterBuilder{T, TGroupFilterBuilder}" />
internal sealed class PropertyBoolFilterBuilder<T, TGroupFilterBuilder> : IPropertyBoolNegatableFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilderInternal<T>
{
    private bool _not;

    private readonly TGroupFilterBuilder _groupFilterBuilder;
    private readonly Expression<Func<T, bool?>> _propertySelector;

    internal PropertyBoolFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, bool>> propertySelector)
        : this(groupFilterBuilder, Expression.Lambda<Func<T, bool?>>(Expression.Convert(propertySelector.Body, typeof(bool?)), propertySelector.Parameters))
    { }

    internal PropertyBoolFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, bool?>> propertySelector)
    {
        _groupFilterBuilder = groupFilterBuilder;
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
    {
        FilterCondition<T, bool?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNull,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsTrue()
        => Equal(true);

    /// <inheritdoc/>
    public TGroupFilterBuilder IsFalse()
        => Equal(false);

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(bool? value)
    {
        FilterConditionValue<T, bool?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.Equal,
            Not = _not,
            Value = value
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }
}
