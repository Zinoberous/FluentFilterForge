namespace FluentFilterForge.Interfaces;

/// <summary>
/// TODO: add documentation
/// </summary>
public interface IPropertyCharFilterBuilder<TEntity, out TGroupFilterBuilder> :
    IPropertyFilterBuilder<TEntity, char, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    TGroupFilterBuilder In(params char[] values);
}
