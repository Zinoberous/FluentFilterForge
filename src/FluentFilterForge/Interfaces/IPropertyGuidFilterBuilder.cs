namespace FluentFilterForge.Interfaces;

/// <summary>
/// TODO: add documentation
/// </summary>
public interface IPropertyGuidFilterBuilder<TEntity, out TGroupFilterBuilder> :
    IPropertyFilterBuilder<TEntity, Guid, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder StartsWith(string value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder EndsWith(string value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder Contains(string value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    TGroupFilterBuilder In(params string[] values);
}
