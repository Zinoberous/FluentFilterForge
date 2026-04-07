namespace FluentFilterForge.Interfaces.Builder;

/// <inheritdoc cref="IPropertyBoolFilterBuilder{TEntity, TGroupFilterBuilder}" />
public interface IPropertyBoolNegatableFilterBuilder<TEntity, out TGroupFilterBuilder> :
    IPropertyBoolFilterBuilder<TEntity, TGroupFilterBuilder>,
    IPropertyNegatableFilterBuilder<TEntity, bool, TGroupFilterBuilder, IPropertyBoolFilterBuilder<TEntity, TGroupFilterBuilder>>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>;
