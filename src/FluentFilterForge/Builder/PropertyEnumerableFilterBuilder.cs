using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyEnumerableNegatableFilterBuilder{T, TElement, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal sealed class PropertyEnumerableFilterBuilder<T, TElement, TGroupFilterBuilder> : IPropertyEnumerableNegatableFilterBuilder<T, TElement, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilderInternal<T>
{
    private bool _not;

    private readonly TGroupFilterBuilder _groupFilterBuilder;
    private readonly Expression<Func<T, IEnumerable<TElement>?>> _propertySelector;

    internal PropertyEnumerableFilterBuilder(TGroupFilterBuilder groupFilterBuilder, Expression<Func<T, IEnumerable<TElement>>> propertySelector)
    {
        _groupFilterBuilder = groupFilterBuilder;
        _propertySelector = Expression.Lambda<Func<T, IEnumerable<TElement>?>>(propertySelector.Body, propertySelector.Parameters);
    }

    /// <inheritdoc/>
    public IPropertyEnumerableFilterBuilder<T, TElement, TGroupFilterBuilder> Not()
    {
        _not = !_not;
        return this;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
    {
        FilterCondition<T, IEnumerable<TElement>?> node = new()
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
        FilterCondition<T, IEnumerable<TElement>?> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.IsNullOrEmpty,
            Not = _not
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(IEnumerable<TElement>? value)
    {
        FilterConditionValue<T, IEnumerable<TElement>?> node = new()
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
    public TGroupFilterBuilder Any(Action<IFilterBuilder<TElement>> configure)
    {
        var subFilter = BuildFilter(configure);

        FilterConditionEnumerable<T, TElement> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.Any,
            Not = _not,
            Filter = subFilter
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder All(Action<IFilterBuilder<TElement>> configure)
    {
        var filter = BuildFilter(configure);

        FilterConditionEnumerable<T, TElement> node = new()
        {
            PropertySelector = _propertySelector,
            ComparisonOperator = ComparisonOperator.All,
            Not = _not,
            Filter = filter
        };

        _groupFilterBuilder.AddNode(node);
        return _groupFilterBuilder;
    }

    private static IFilter<TElement> BuildFilter(Action<IFilterBuilder<TElement>> configure)
    {
        GroupFilterBuilder<TElement> groupBuilder = new();
        configure(new FilterBuilder<TElement>(groupBuilder));
        return groupBuilder.Build();
    }
}
