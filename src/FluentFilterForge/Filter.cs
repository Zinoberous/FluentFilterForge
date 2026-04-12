using System.Linq.Expressions;
using FluentFilterForge.Builder;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

/// <inheritdoc cref="IFilter{T}" />
public static class Filter
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    public static IFilterBuilder<T> For<T>()
        => new FilterBuilder<T>();
}

/// <inheritdoc cref="IFilter{T}" />
internal sealed class Filter<T> : IFilter<T>
{
    internal FilterGroup Root { get; set; } = new();

    /// <inheritdoc/>
    public Expression<Func<T, bool>> ToExpression()
    {
        var parameter = Expression.Parameter(typeof(T));
        var body = BuildGroupExpression(Root, parameter);

        return Expression.Lambda<Func<T, bool>>(body, parameter);
    }

    private static Expression BuildGroupExpression(FilterGroup group, ParameterExpression parameter)
    {
        if (group.Nodes.Count == 0)
        {
            return Expression.Constant(true);
        }

        using var enumerator = group.Nodes.GetEnumerator();

        enumerator.MoveNext();
        var expression = BuildNodeExpression(enumerator.Current, parameter);

        while (enumerator.MoveNext())
        {
            var nextExpression = BuildNodeExpression(enumerator.Current, parameter);

            expression = group.LogicalOperator switch
            {
                LogicalOperator.And => Expression.AndAlso(expression, nextExpression),
                LogicalOperator.Or => Expression.OrElse(expression, nextExpression),
                _ => throw new NotSupportedException($"Logical operator '{group.LogicalOperator}' is not supported.")
            };
        }

        return expression;
    }

    private static Expression BuildNodeExpression(IFilterNode node, ParameterExpression parameter)
    {
        return node switch
        {
            FilterGroup group => BuildGroupExpression(group, parameter),
            FilterConditionValue<T, bool?> condition => BuildBoolConditionExpression(condition, parameter),
            _ => throw new NotSupportedException($"Filter node '{node.GetType().Name}' is not supported yet.")
        };
    }

    private static Expression BuildBoolConditionExpression(FilterConditionValue<T, bool?> condition, ParameterExpression parameter)
    {
        var propertyExpression = new ReplaceParameterVisitor(condition.PropertySelector.Parameters[0], parameter)
            .Visit(condition.PropertySelector.Body)!;

        var valueExpression = Expression.Constant(condition.Value, typeof(bool?));

        var comparison = condition.ComparisonOperator switch
        {
            ComparisonOperator.Equal => Expression.Equal(propertyExpression, valueExpression),
            _ => throw new NotSupportedException($"Comparison operator '{condition.ComparisonOperator}' is not supported for bool filters.")
        };

        return condition.Not
            ? Expression.Not(comparison)
            : comparison;
    }

    private sealed class ReplaceParameterVisitor(ParameterExpression source, ParameterExpression target) : ExpressionVisitor
    {
        protected override Expression VisitParameter(ParameterExpression node)
        {
            return node == source
                ? target
                : base.VisitParameter(node);
        }
    }
}
