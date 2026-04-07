namespace FluentFilterForge.Interfaces.Builder;

/// <summary>
/// TODO: add documentation
/// </summary>
public interface IPropertyBoolFilterBuilder<TEntity, out TGroupFilterBuilder> :
    IPropertyFilterBuilder<TEntity, bool, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder IsTrue();

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder IsFalse();
}
