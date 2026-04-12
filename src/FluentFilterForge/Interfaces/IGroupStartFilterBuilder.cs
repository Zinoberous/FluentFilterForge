namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IGroupFilterBuilder{T}" />
public interface IGroupStartFilterBuilder<T> : IGroupAndFilterBuilder<T>, IGroupOrFilterBuilder<T>;
