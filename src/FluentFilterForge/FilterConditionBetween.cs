using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal sealed record FilterConditionBetween<T, TProperty> : FilterCondition<T, TProperty>, IFilterConditionBetween
{
    internal required TProperty From { get; init; }
    internal required TProperty To { get; init; }

    object? IFilterConditionBetween.From => From;
    object? IFilterConditionBetween.To => To;
}
