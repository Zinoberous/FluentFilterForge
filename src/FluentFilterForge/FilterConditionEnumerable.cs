using FluentFilterForge.Interfaces;

namespace FluentFilterForge;

internal interface IFilterConditionEnumerable : IFilterCondition
{
    IFilter Filter { get; }
}

internal sealed record FilterConditionEnumerable<T, TElement> : FilterCondition<T, IEnumerable<TElement>?>, IFilterConditionEnumerable
{
    internal required IFilter<TElement> Filter { get; init; }

    IFilter IFilterConditionEnumerable.Filter => Filter;
}
