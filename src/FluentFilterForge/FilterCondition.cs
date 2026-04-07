using System.Linq.Expressions;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal record FilterCondition<TEntity, TProperty> : IFilterNode
{
    internal required Expression<Func<TEntity, TProperty>> PropertySelector { get; init; }
    internal required ComparisonOperator ComparisonOperator { get; init; }
    internal bool Not { get; init; }
}
