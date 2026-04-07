namespace FluentFilterForge.Interfaces.Builder;

/// <inheritdoc cref="IPropertyGuidFilterBuilder{TEntity, TGroupFilterBuilder}" />
public interface IPropertyGuidNegatableFilterBuilder<TEntity, out TGroupFilterBuilder> :
    IPropertyGuidFilterBuilder<TEntity, TGroupFilterBuilder>,
    IPropertyNegatableFilterBuilder<TEntity, Guid, TGroupFilterBuilder, IPropertyGuidFilterBuilder<TEntity, TGroupFilterBuilder>>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>;
