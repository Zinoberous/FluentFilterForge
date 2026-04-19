using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyDateTimeNegatableFilterBuilder{T, TProperty, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal sealed class PropertyDateTimeFilterBuilder<T, TDateTime, TGroupFilterBuilder> : IPropertyDateTimeNegatableFilterBuilder<T, TDateTime, TGroupFilterBuilder>
    where TDateTime : struct
    where TGroupFilterBuilder : IGroupFilterBuilderInternal<T>
{
    private bool _not;

    private readonly TGroupFilterBuilder _groupFilterBuilder;
    private readonly Expression<Func<T, TDateTime?>> _propertySelector;

    internal PropertyDateTimeFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, TDateTime>> propertySelector)
        : this(groupFilterBuilder, Expression.Lambda<Func<T, TDateTime?>>(Expression.Convert(propertySelector.Body, typeof(TDateTime?)), propertySelector.Parameters))
    { }

    internal PropertyDateTimeFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, TDateTime?>> propertySelector)
    {
        _groupFilterBuilder = groupFilterBuilder;
        _propertySelector = propertySelector;
    }

    /// <inheritdoc/>
    public IPropertyDateTimeFilterBuilder<T, TDateTime, TGroupFilterBuilder> Not()
    {
        _not = !_not;
        return this;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
    {
        FilterCondition<T, TDateTime?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNull,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(TDateTime? value)
    {
        FilterConditionValue<T, TDateTime?> node = new()
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
    public TGroupFilterBuilder GreaterThan(TDateTime value)
    {
        FilterConditionValue<T, TDateTime?> node = new()
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
    public TGroupFilterBuilder GreaterThanOrEqual(TDateTime value)
    {
        FilterConditionValue<T, TDateTime?> node = new()
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
    public TGroupFilterBuilder LessThan(TDateTime value)
    {
        FilterConditionValue<T, TDateTime?> node = new()
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
    public TGroupFilterBuilder LessThanOrEqual(TDateTime value)
    {
        FilterConditionValue<T, TDateTime?> node = new()
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
    public TGroupFilterBuilder Between(TDateTime from, TDateTime to)
    {
        FilterConditionBetween<T, TDateTime?> node = new()
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
    public TGroupFilterBuilder In(params TDateTime?[] values)
    {
        FilterConditionIn<T, TDateTime?> node = new()
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
