using FluentFilterForge.Enums;

namespace FluentFilterForge;

internal sealed record FilterGroup : IFilterNode
{
    internal LogicalOperator? LogicalOperator { get; set; }
    internal ICollection<IFilterNode> Nodes { get; } = [];
}
