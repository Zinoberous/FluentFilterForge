namespace FluentFilterForge.Interfaces;

/// <summary>
/// Base interface for filter builders that support building the final filter.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
public interface IGroupFilterBuilder<T>
{
    /// <summary>
    /// Builds and returns the configured <see cref="IFilter{T}"/>.
    /// </summary>
    /// <returns>The compiled <see cref="IFilter{T}"/>.</returns>
    IFilter<T> Build();
}
