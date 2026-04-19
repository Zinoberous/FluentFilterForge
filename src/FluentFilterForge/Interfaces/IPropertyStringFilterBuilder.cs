namespace FluentFilterForge.Interfaces;

/// <summary>
/// Provides filter conditions for a nullable string property.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
/// <typeparam name="TGroupFilterBuilder">The type of the builder returned after a condition is set.</typeparam>
public interface IPropertyStringFilterBuilder<T, out TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>Matches items where the property value is <see langword="null"/>.</summary>
    TGroupFilterBuilder IsNull();

    /// <summary>Matches items where the property value is <see langword="null"/> or an empty string.</summary>
    TGroupFilterBuilder IsNullOrEmpty();

    /// <summary>Matches items where the property value is <see langword="null"/>, empty, or consists only of white-space characters.</summary>
    TGroupFilterBuilder IsNullOrWhitespace();

    /// <summary>Matches items where the property value equals <paramref name="value"/> (case-sensitive).</summary>
    /// <param name="value">The value to compare against. Pass <see langword="null"/> to match null properties.</param>
    TGroupFilterBuilder Equal(string? value);

    /// <summary>Matches items where the property value starts with <paramref name="value"/> (case-insensitive).</summary>
    /// <param name="value">The prefix to search for.</param>
    TGroupFilterBuilder StartsWith(string value);

    /// <summary>Matches items where the property value ends with <paramref name="value"/> (case-insensitive).</summary>
    /// <param name="value">The suffix to search for.</param>
    TGroupFilterBuilder EndsWith(string value);

    /// <summary>Matches items where the property value contains <paramref name="value"/> (case-insensitive).</summary>
    /// <param name="value">The substring to search for.</param>
    TGroupFilterBuilder Contains(string value);

    /// <summary>Matches items where the property value equals one of the specified <paramref name="values"/>.</summary>
    /// <param name="values">The set of allowed values.</param>
    TGroupFilterBuilder In(params string?[] values);
}
