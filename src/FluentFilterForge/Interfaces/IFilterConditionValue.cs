namespace FluentFilterForge.Interfaces;

internal interface IFilterConditionValue : IFilterCondition
{
    object? Value { get; }
}
