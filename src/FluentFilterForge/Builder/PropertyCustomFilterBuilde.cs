using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyCustomNegatableFilterBuilder{T, TProperty, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal sealed class PropertyCustomFilterBuilder<T, TProperty, TGroupFilterBuilder> : IPropertyCustomNegatableFilterBuilder<T, TProperty, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilderInternal<T>
{
    private bool _not;

    private readonly TGroupFilterBuilder _groupFilterBuilder;
    private readonly Expression<Func<T, TProperty?>> _propertySelector;

    internal PropertyCustomFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, TProperty>> propertySelector)
    {
        _groupFilterBuilder = groupFilterBuilder;
        _propertySelector = Expression.Lambda<Func<T, TProperty?>>(propertySelector.Body, propertySelector.Parameters);
    }

    /// <inheritdoc/>
    public IPropertyCustomFilterBuilder<T, TProperty, TGroupFilterBuilder> Not()
    {
        _not = !_not;
        return this;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
    {
        FilterCondition<T, TProperty?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNull,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(TProperty? value)
    {
        FilterConditionValue<T, TProperty?> node = new()
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
