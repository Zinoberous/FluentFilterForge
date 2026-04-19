using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyCharNegatableFilterBuilder{T, TGroupFilterBuilder}" />
internal sealed class PropertyCharFilterBuilder<T, TGroupFilterBuilder> : IPropertyCharNegatableFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilderInternal<T>
{
    private bool _not;

    private readonly TGroupFilterBuilder _groupFilterBuilder;
    private readonly Expression<Func<T, char?>> _propertySelector;

    internal PropertyCharFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, char>> propertySelector)
        : this(groupFilterBuilder, Expression.Lambda<Func<T, char?>>(Expression.Convert(propertySelector.Body, typeof(char?)), propertySelector.Parameters))
    { }

    internal PropertyCharFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, char?>> propertySelector)
    {
        _groupFilterBuilder = groupFilterBuilder;
        _propertySelector = propertySelector;
    }

    /// <inheritdoc/>
    public IPropertyCharFilterBuilder<T, TGroupFilterBuilder> Not()
    {
        _not = !_not;
        return this;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
    {
        FilterCondition<T, char?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNull,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(char? value)
    {
        FilterConditionValue<T, char?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.Equal,
            Not = _not,
            Value = value
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params char?[] values)
    {
        FilterConditionIn<T, char?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.In,
            Not = _not,
            Values = values
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }
}
