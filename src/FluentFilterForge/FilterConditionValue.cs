using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionValue<T, TProperty> : FilterCondition<T, TProperty>, IFilterNode
{
    internal TProperty? Value { get; init; }
}
