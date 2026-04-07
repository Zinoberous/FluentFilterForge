namespace FluentFilterForge.Interfaces.Builder;

/// <inheritdoc cref="IPropertyStringFilterBuilder{TEntity, TGroupFilterBuilder}" />
public interface IPropertyStringNegatableFilterBuilder<TEntity, out TGroupFilterBuilder> :
    IPropertyStringFilterBuilder<TEntity, TGroupFilterBuilder>,
    IPropertyNegatableFilterBuilder<TEntity, string, TGroupFilterBuilder, IPropertyStringFilterBuilder<TEntity, TGroupFilterBuilder>>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>;
