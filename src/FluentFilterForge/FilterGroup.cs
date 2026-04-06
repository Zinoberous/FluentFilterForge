namespace FluentFilterForge;

internal sealed record FilterGroup : IFilterNode
{
    internal LogicalOperator LogicalOperator { get; init; } = LogicalOperator.And;
    internal ICollection<IFilterNode> Nodes { get; } = [];
}
