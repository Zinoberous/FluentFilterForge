namespace FluentFilterForge.Interfaces;

internal interface IFilterConditionBetween : IFilterCondition
{
    object? From { get; }
    object? To { get; }
}
