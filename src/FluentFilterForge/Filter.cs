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
    internal FilterGroup Root { get; init; } = new();

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
            IFilterConditionBetween condition => BuildBetweenConditionExpression(condition, parameter),
            IFilterConditionIn condition => BuildInConditionExpression(condition, parameter),
            IFilterConditionValue condition => BuildValueConditionExpression(condition, parameter),
            _ => throw new NotSupportedException($"Filter node '{node.GetType().Name}' is not supported yet.")
        };
    }

    private static Expression BuildValueConditionExpression(IFilterConditionValue condition, ParameterExpression parameter)
    {
        var propertyExpr = ReplaceParameter(condition.PropertySelector, parameter);
        var propertyType = condition.PropertySelector.ReturnType;
        var valueExpr = Expression.Constant(condition.Value, propertyType);

        Expression comparison = condition.ComparisonOperator switch
        {
            ComparisonOperator.Equal => Expression.Equal(propertyExpr, valueExpr),
            ComparisonOperator.GreaterThan => Expression.GreaterThan(propertyExpr, valueExpr),
            ComparisonOperator.GreaterThanOrEqual => Expression.GreaterThanOrEqual(propertyExpr, valueExpr),
            ComparisonOperator.LessThan => Expression.LessThan(propertyExpr, valueExpr),
            ComparisonOperator.LessThanOrEqual => Expression.LessThanOrEqual(propertyExpr, valueExpr),
            _ => throw new NotSupportedException($"Comparison operator '{condition.ComparisonOperator}' is not supported.")
        };

        return condition.Not ? Expression.Not(comparison) : comparison;
    }

    private static Expression BuildBetweenConditionExpression(IFilterConditionBetween condition, ParameterExpression parameter)
    {
        var propertyExpr = ReplaceParameter(condition.PropertySelector, parameter);
        var propertyType = condition.PropertySelector.ReturnType;

        var fromExpr = Expression.Constant(condition.From, propertyType);
        var toExpr = Expression.Constant(condition.To, propertyType);

        var lower = Expression.GreaterThanOrEqual(propertyExpr, fromExpr);
        var upper = Expression.LessThanOrEqual(propertyExpr, toExpr);
        var comparison = Expression.AndAlso(lower, upper);

        return condition.Not ? Expression.Not(comparison) : comparison;
    }

    private static Expression BuildInConditionExpression(IFilterConditionIn condition, ParameterExpression parameter)
    {
        var propertyExpr = ReplaceParameter(condition.PropertySelector, parameter);
        var propertyType = condition.PropertySelector.ReturnType;

        var listType = typeof(List<>).MakeGenericType(propertyType);
        var typedList = Activator.CreateInstance(listType)!;
        var addMethod = listType.GetMethod("Add")!;
        foreach (var value in condition.Values)
            addMethod.Invoke(typedList, [value]);

        var listExpr = Expression.Constant(typedList);
        var containsMethod = listType.GetMethod("Contains")!;
        var comparison = Expression.Call(listExpr, containsMethod, propertyExpr);

        return condition.Not ? Expression.Not(comparison) : comparison;
    }

    private static Expression ReplaceParameter(LambdaExpression lambda, ParameterExpression parameter)
        => new ReplaceParameterVisitor(lambda.Parameters[0], parameter).Visit(lambda.Body)!;

    private sealed class ReplaceParameterVisitor(ParameterExpression source, ParameterExpression target) : ExpressionVisitor
    {
        protected override Expression VisitParameter(ParameterExpression node)
            => node == source ? target : base.VisitParameter(node);
    }
}
