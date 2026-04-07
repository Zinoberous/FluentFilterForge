using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionBase<TEntity, TProperty> : FilterCondition<TEntity, TProperty>, IFilterNode
{
    internal TProperty? Value { get; init; }
}
