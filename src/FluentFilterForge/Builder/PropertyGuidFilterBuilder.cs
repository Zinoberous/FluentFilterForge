using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyGuidNegatableFilterBuilder{T, TGroupFilterBuilder}" />
internal sealed class PropertyGuidFilterBuilder<T, TGroupFilterBuilder> : IPropertyGuidNegatableFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilderInternal<T>
{
    private bool _not;

    private readonly TGroupFilterBuilder _groupFilterBuilder;
    private readonly Expression<Func<T, Guid?>> _propertySelector;

    internal PropertyGuidFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, Guid>> propertySelector)
        : this(groupFilterBuilder, Expression.Lambda<Func<T, Guid?>>(Expression.Convert(propertySelector.Body, typeof(Guid?)), propertySelector.Parameters))
    { }

    internal PropertyGuidFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, Guid?>> propertySelector)
    {
        _groupFilterBuilder = groupFilterBuilder;
        _propertySelector = propertySelector;
    }

    /// <inheritdoc/>
    public IPropertyGuidFilterBuilder<T, TGroupFilterBuilder> Not()
    {
        _not = !_not;
        return this;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
    {
        FilterCondition<T, Guid?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNull,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(Guid? value)
    {
        FilterConditionValue<T, Guid?> node = new()
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
            PropertySelector = Expression.Lambda<Func<T, string?>>(
                Expression.Call(Expression.Call(_propertySelector.Body, nameof(ToString), []), typeof(string).GetMethod(nameof(string.ToLower), [])!),
                _propertySelector.Parameters),
            ComparisonOperator = ComparisonOperator.StartsWith,
            Not = _not,
            Value = value.ToLower()
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder EndsWith(string value)
    {
        FilterConditionValue<T, string?> node = new()
        {
            PropertySelector = Expression.Lambda<Func<T, string?>>(
                Expression.Call(Expression.Call(_propertySelector.Body, nameof(ToString), []), typeof(string).GetMethod(nameof(string.ToLower), [])!),
                _propertySelector.Parameters),
            ComparisonOperator = ComparisonOperator.EndsWith,
            Not = _not,
            Value = value.ToLower()
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Contains(string value)
    {
        FilterConditionValue<T, string?> node = new()
        {
            PropertySelector = Expression.Lambda<Func<T, string?>>(
                Expression.Call(Expression.Call(_propertySelector.Body, nameof(ToString), []), typeof(string).GetMethod(nameof(string.ToLower), [])!),
                _propertySelector.Parameters),
            ComparisonOperator = ComparisonOperator.Contains,
            Not = _not,
            Value = value.ToLower()
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params Guid?[] values)
    {
        FilterConditionIn<T, Guid?> node = new()
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
