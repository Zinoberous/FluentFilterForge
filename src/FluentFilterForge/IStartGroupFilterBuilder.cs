namespace FluentFilterForge;

/// <inheritdoc cref="IGroupFilterBuilder{T}" />
public interface IStartGroupFilterBuilder<T> : IAndGroupFilterBuilder<T>, IOrGroupFilterBuilder<T>;
