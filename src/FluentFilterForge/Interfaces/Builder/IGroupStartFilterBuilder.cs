namespace FluentFilterForge.Interfaces.Builder;

/// <inheritdoc cref="IGroupFilterBuilder{T}" />
public interface IGroupStartFilterBuilder<TEntity> : IGroupAndFilterBuilder<TEntity>, IGroupOrFilterBuilder<TEntity>;
