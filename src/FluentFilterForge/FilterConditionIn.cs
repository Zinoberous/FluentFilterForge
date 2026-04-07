using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionIn<TEntity, TProperty> : FilterCondition<TEntity, TProperty>, IFilterNode
{
    internal required IEnumerable<TProperty> Values { get; init; }
}
