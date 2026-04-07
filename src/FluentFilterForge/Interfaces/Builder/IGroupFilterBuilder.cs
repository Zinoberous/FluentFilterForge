namespace FluentFilterForge.Interfaces.Builder;

/// <summary>
/// TODO: add documentation
/// </summary>
public interface IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IFilter<TEntity> Build();
}
