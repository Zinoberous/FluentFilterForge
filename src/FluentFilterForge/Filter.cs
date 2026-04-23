using System.Linq.Expressions;
using FluentFilterForge.Builder;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

/// <summary>
/// Entry point for building filters using the fluent API.
/// </summary>
public static class Filter
{
    /// <summary>
    /// Creates a new filter builder for objects of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of object to filter.</typeparam>
    /// <returns>A <see cref="IFilterBuilder{T}"/> to configure conditions on.</returns>
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

    LambdaExpression IFilter.ToExpression() => ToExpression();

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
            IFilterConditionValue condition => BuildValueConditionExpression(condition, parameter),
            IFilterConditionBetween condition => BuildBetweenConditionExpression(condition, parameter),
            IFilterConditionIn condition => BuildInConditionExpression(condition, parameter),
            IFilterConditionEnumerable condition => BuildEnumerableConditionExpression(condition, parameter),
            IFilterCondition condition => BuildNoValueConditionExpression(condition, parameter),
            _ => throw new NotSupportedException($"Filter node '{node.GetType().Name}' is not supported yet.")
        };
    }

    private static Expression BuildNoValueConditionExpression(IFilterCondition condition, ParameterExpression parameter)
    {
        var propertyExpr = ReplaceParameter(condition.PropertySelector, parameter);
        var propertyType = condition.PropertySelector.ReturnType;

        var comparison = condition.ComparisonOperator switch
        {
            ComparisonOperator.IsNull => Expression.Equal(propertyExpr, Expression.Constant(null, propertyType)),
            ComparisonOperator.IsNullOrEmpty => BuildIsNullOrEmptyExpression(propertyExpr, propertyType),
            ComparisonOperator.IsNullOrWhitespace => BuildIsNullOrWhitespaceExpression(propertyExpr),
            _ => throw new NotSupportedException($"Comparison operator '{condition.ComparisonOperator}' is not supported for value-less conditions.")
        };

        return condition.Not ? Expression.Not(comparison) : comparison;
    }

    private static Expression BuildIsNullOrEmptyExpression(Expression propertyExpr, Type propertyType)
    {
        if (propertyType == typeof(string))
        {
            var method = typeof(string).GetMethod(nameof(string.IsNullOrEmpty), [typeof(string)])!;
            return Expression.Call(method, propertyExpr);
        }

        var elementType = propertyType.IsGenericType ? propertyType.GetGenericArguments()[0] : typeof(object);
        var anyMethod = typeof(Enumerable)
            .GetMethods()
            .First(m => m.Name == nameof(Enumerable.Any) && m.GetParameters().Length == 1)
            .MakeGenericMethod(elementType);

        var isNull = Expression.Equal(propertyExpr, Expression.Constant(null, propertyType));
        var isEmpty = Expression.Not(Expression.Call(anyMethod, propertyExpr));

        return Expression.OrElse(isNull, isEmpty);
    }

    private static MethodCallExpression BuildIsNullOrWhitespaceExpression(Expression propertyExpr)
    {
        var method = typeof(string).GetMethod(nameof(string.IsNullOrWhiteSpace), [typeof(string)])!;
        return Expression.Call(method, propertyExpr);
    }

    private static Expression BuildValueConditionExpression(IFilterConditionValue condition, ParameterExpression parameter)
    {
        var propertyExpr = ReplaceParameter(condition.PropertySelector, parameter);
        var propertyType = condition.PropertySelector.ReturnType;

        var comparison = condition.ComparisonOperator switch
        {
            ComparisonOperator.StartsWith or ComparisonOperator.EndsWith or ComparisonOperator.Contains
                => BuildStringMatchExpression(condition.ComparisonOperator, propertyExpr, condition.Value),
            _ => BuildScalarComparisonExpression(condition.ComparisonOperator, propertyExpr, condition.Value, propertyType)
        };

        return condition.Not ? Expression.Not(comparison) : comparison;
    }

    private static BinaryExpression BuildScalarComparisonExpression(ComparisonOperator op, Expression propertyExpr, object? value, Type propertyType)
    {
        var constExpr = Expression.Constant(value, propertyType);

        return op switch
        {
            ComparisonOperator.Equal => Expression.Equal(propertyExpr, constExpr),
            ComparisonOperator.GreaterThan => Expression.GreaterThan(propertyExpr, constExpr),
            ComparisonOperator.GreaterThanOrEqual => Expression.GreaterThanOrEqual(propertyExpr, constExpr),
            ComparisonOperator.LessThan => Expression.LessThan(propertyExpr, constExpr),
            ComparisonOperator.LessThanOrEqual => Expression.LessThanOrEqual(propertyExpr, constExpr),
            _ => throw new NotSupportedException($"Comparison operator '{op}' is not supported.")
        };
    }

    private static BinaryExpression BuildStringMatchExpression(ComparisonOperator op, Expression propertyExpr, object? value)
    {
        var methodName = op switch
        {
            ComparisonOperator.StartsWith => nameof(string.StartsWith),
            ComparisonOperator.EndsWith => nameof(string.EndsWith),
            _ => nameof(string.Contains)
        };
        var method = typeof(string).GetMethod(methodName, [typeof(string)])!;

        var nullCheck = Expression.NotEqual(propertyExpr, Expression.Constant(null, typeof(string)));

        var valueExpr = Expression.Constant(value, typeof(string));
        var call = Expression.Call(propertyExpr, method, valueExpr);

        return Expression.AndAlso(nullCheck, call);
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
        {
            addMethod.Invoke(typedList, [value]);
        }

        var listExpr = Expression.Constant(typedList);
        var containsMethod = listType.GetMethod("Contains")!;
        var comparison = Expression.Call(listExpr, containsMethod, propertyExpr);

        return condition.Not ? Expression.Not(comparison) : comparison;
    }

    private static Expression BuildEnumerableConditionExpression(IFilterConditionEnumerable condition, ParameterExpression parameter)
    {
        var collectionExpr = ReplaceParameter(condition.PropertySelector, parameter);
        var collectionType = condition.PropertySelector.ReturnType;
        var elementType = collectionType.GetGenericArguments()[0];

        // Pass the sub-filter as an inline lambda expression so EF Core can translate it to SQL.
        // Using Expression.Constant(compiled delegate) would prevent SQL translation.
        var subFilterExpression = condition.Filter.ToExpression();

        var methodName = condition.ComparisonOperator == ComparisonOperator.Any ? nameof(Enumerable.Any) : nameof(Enumerable.All);
        var method = typeof(Enumerable)
            .GetMethods()
            .First(m => m.Name == methodName && m.GetParameters().Length == 2)
            .MakeGenericMethod(elementType);

        Expression call;

        if (!collectionType.IsValueType)
        {
            var notNull = Expression.NotEqual(collectionExpr, Expression.Constant(null, collectionType));
            var methodCall = Expression.Call(method, collectionExpr, subFilterExpression);
            call = Expression.AndAlso(notNull, methodCall);
        }
        else
        {
            call = Expression.Call(method, collectionExpr, subFilterExpression);
        }

        return condition.Not ? Expression.Not(call) : call;
    }

    private static Expression ReplaceParameter(LambdaExpression lambda, ParameterExpression parameter)
        => new ReplaceParameterVisitor(lambda.Parameters[0], parameter).Visit(lambda.Body)!;

    private sealed class ReplaceParameterVisitor(ParameterExpression source, ParameterExpression target) : ExpressionVisitor
    {
        protected override Expression VisitParameter(ParameterExpression node)
            => node == source ? target : base.VisitParameter(node);
    }
}
