namespace FluentFilterForge.Interfaces;

/// <summary>
/// TODO: add documentation
/// </summary>
internal interface IGroupFilterBuilderInternal<T> : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="filterNode"></param>
    void AddNode(IFilterNode filterNode);
}
