using System.Linq.Expressions;

namespace FluentFilterForge;

internal sealed record FilterCondition<T, TProperty> : IFilterNode
{
    internal required Expression<Func<T, TProperty>> PropertySelector { get; init; }
    internal required ComparisonOperator ComparisonOperator { get; init; }
    internal bool Not { get; init; }
    internal TProperty? Value { get; init; }
}
