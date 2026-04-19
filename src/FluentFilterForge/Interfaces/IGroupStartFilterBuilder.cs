namespace FluentFilterForge.Interfaces;

/// <summary>
/// Represents a filter builder that supports both <c>And</c> and <c>Or</c> chaining
/// after an initial <c>Where</c> condition has been specified.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
public interface IGroupStartFilterBuilder<T> : IGroupAndFilterBuilder<T>, IGroupOrFilterBuilder<T>;
