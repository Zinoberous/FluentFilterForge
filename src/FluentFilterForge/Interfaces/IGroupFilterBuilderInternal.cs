namespace FluentFilterForge.Interfaces;

/// <summary>
/// Internal extension of <see cref="IGroupFilterBuilder{T}"/> that exposes
/// <see cref="AddNode"/> so property builders can register their compiled conditions.
/// </summary>
internal interface IGroupFilterBuilderInternal<T> : IGroupFilterBuilder<T>
{
    /// <summary>
    /// Appends a compiled <see cref="IFilterNode"/> to the current filter group.
    /// </summary>
    /// <param name="filterNode">The node to add.</param>
    void AddNode(IFilterNode filterNode);
}
