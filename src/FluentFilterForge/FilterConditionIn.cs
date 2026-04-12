using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionIn<T, TProperty> : FilterCondition<T, TProperty>, IFilterNode
{
    internal required IEnumerable<TProperty> Values { get; init; }
}
