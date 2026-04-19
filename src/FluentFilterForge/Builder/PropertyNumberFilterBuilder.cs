using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Numerics;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyNumberNegatableFilterBuilder{T, TNumber, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal sealed class PropertyNumberFilterBuilder<T, TNumber, TGroupFilterBuilder> : IPropertyNumberNegatableFilterBuilder<T, TNumber, TGroupFilterBuilder>
    where TNumber : struct, INumber<TNumber>
    where TGroupFilterBuilder : IGroupFilterBuilderInternal<T>
{
    private bool _not;

    private readonly TGroupFilterBuilder _groupFilterBuilder;
    private readonly Expression<Func<T, TNumber?>> _propertySelector;

    internal PropertyNumberFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, TNumber>> propertySelector)
        : this(groupFilterBuilder, Expression.Lambda<Func<T, TNumber?>>(Expression.Convert(propertySelector.Body, typeof(TNumber?)), propertySelector.Parameters))
    { }

    internal PropertyNumberFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, TNumber?>> propertySelector)
    {
        _groupFilterBuilder = groupFilterBuilder;
        _propertySelector = propertySelector;
    }

    /// <inheritdoc/>
    public IPropertyNumberFilterBuilder<T, TNumber, TGroupFilterBuilder> Not()
    {
        _not = !_not;
        return this;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
    {
        FilterCondition<T, TNumber?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNull,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(TNumber? value)
    {
        FilterConditionValue<T, TNumber?> node = new()
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
    public TGroupFilterBuilder GreaterThan(TNumber value)
    {
        FilterConditionValue<T, TNumber?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.GreaterThan,
            Not = _not,
            Value = value
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder GreaterThanOrEqual(TNumber value)
    {
        FilterConditionValue<T, TNumber?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.GreaterThanOrEqual,
            Not = _not,
            Value = value
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder LessThan(TNumber value)
    {
        FilterConditionValue<T, TNumber?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.LessThan,
            Not = _not,
            Value = value
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder LessThanOrEqual(TNumber value)
    {
        FilterConditionValue<T, TNumber?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.LessThanOrEqual,
            Not = _not,
            Value = value
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Between(TNumber from, TNumber to)
    {
        FilterConditionBetween<T, TNumber?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.Between,
            Not = _not,
            From = from,
            To = to
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params TNumber?[] values)
    {
        FilterConditionIn<T, TNumber?> node = new()
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
