using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionValue<TEntity, TProperty> : FilterCondition<TEntity, TProperty>, IFilterNode
{
    internal TProperty? Value { get; init; }
}
