namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyCharFilterBuilder{TEntity, TGroupFilterBuilder}" />
public interface IPropertyCharNegatableFilterBuilder<TEntity, out TGroupFilterBuilder> :
    IPropertyCharFilterBuilder<TEntity, TGroupFilterBuilder>,
    IPropertyNegatableFilterBuilder<TEntity, char, TGroupFilterBuilder, IPropertyCharFilterBuilder<TEntity, TGroupFilterBuilder>>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>;
