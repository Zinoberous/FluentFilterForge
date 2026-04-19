using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyStringNegatableFilterBuilder{T, TGroupFilterBuilder}" />
internal sealed class PropertyStringFilterBuilder<T, TGroupFilterBuilder> : IPropertyStringNegatableFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilderInternal<T>
{
    private bool _not;

    private readonly TGroupFilterBuilder _groupFilterBuilder;
    private readonly Expression<Func<T, string?>> _propertySelector;

    internal PropertyStringFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, string?>> propertySelector)
    {
        _groupFilterBuilder = groupFilterBuilder;
        _propertySelector = propertySelector;
    }

    /// <inheritdoc/>
    public IPropertyStringFilterBuilder<T, TGroupFilterBuilder> Not()
    {
        _not = !_not;
        return this;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
    {
        FilterCondition<T, string?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNull,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNullOrEmpty()
    {
        FilterCondition<T, string?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNullOrEmpty,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNullOrWhitespace()
    {
        FilterCondition<T, string?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNullOrWhitespace,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(string? value)
    {
        FilterConditionValue<T, string?> node = new()
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
    public TGroupFilterBuilder StartsWith(string value)
    {
        FilterConditionValue<T, string?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.StartsWith,
            Not = _not,
            Value = value
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder EndsWith(string value)
    {
        FilterConditionValue<T, string?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.EndsWith,
            Not = _not,
            Value = value
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Contains(string value)
    {
        FilterConditionValue<T, string?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.Contains,
            Not = _not,
            Value = value
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params string?[] values)
    {
        FilterConditionIn<T, string?> node = new()
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
