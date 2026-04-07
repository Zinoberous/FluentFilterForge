using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionBetween<TEntity, TProperty> : FilterCondition<TEntity, TProperty>, IFilterNode
{
    internal required TProperty From { get; init; }
    internal required TProperty To { get; init; }
}
