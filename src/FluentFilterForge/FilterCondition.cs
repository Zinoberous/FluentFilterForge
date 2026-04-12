using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal abstract record FilterCondition<T, TProperty> : IFilterNode
{
    internal required Expression<Func<T, TProperty>> PropertySelector { get; init; }
    internal required ComparisonOperator ComparisonOperator { get; init; }
    internal bool Not { get; init; }
}
