using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionBetween<T, TProperty> : FilterCondition<T, TProperty>, IFilterNode
{
    internal required TProperty From { get; init; }
    internal required TProperty To { get; init; }
}
