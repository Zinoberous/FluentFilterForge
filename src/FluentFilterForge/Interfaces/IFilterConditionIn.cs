namespace FluentFilterForge.Interfaces;

internal interface IFilterConditionIn : IFilterCondition
{
    IEnumerable<object?> Values { get; }
}
