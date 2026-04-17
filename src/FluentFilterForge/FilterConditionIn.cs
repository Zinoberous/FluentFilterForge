using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionIn<T, TProperty> : FilterCondition<T, TProperty>, IFilterConditionIn
{
    internal required IEnumerable<TProperty> Values { get; init; }

    IEnumerable<object?> IFilterConditionIn.Values => Values.Cast<object?>();
}
