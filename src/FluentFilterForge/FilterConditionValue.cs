using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionValue<T, TProperty> : FilterCondition<T, TProperty>, IFilterConditionValue
{
    internal TProperty? Value { get; init; }

    object? IFilterConditionValue.Value => Value;
}
