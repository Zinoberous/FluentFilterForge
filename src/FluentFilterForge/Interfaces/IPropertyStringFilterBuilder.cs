namespace FluentFilterForge.Interfaces;

/// <summary>
/// TODO: add documentation
/// </summary>
public interface IPropertyStringFilterBuilder<TEntity, out TGroupFilterBuilder> :
    IPropertyFilterBuilder<TEntity, string, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder IsNullOrEmpty();

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder IsNullOrWhitespace();

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
