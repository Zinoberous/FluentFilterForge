namespace FluentFilterForge.Interfaces;

/// <summary>
/// Provides filter conditions for a nullable <see cref="char"/> property.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
/// <typeparam name="TGroupFilterBuilder">The type of the builder returned after a condition is set.</typeparam>
public interface IPropertyCharFilterBuilder<T, out TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>Matches items where the property value is <see langword="null"/>.</summary>
    TGroupFilterBuilder IsNull();

    /// <summary>Matches items where the property value equals <paramref name="value"/>.</summary>
    /// <param name="value">The character to compare against. Pass <see langword="null"/> to match null properties.</param>
    TGroupFilterBuilder Equal(char? value);

    /// <summary>Matches items where the property value equals one of the specified <paramref name="values"/>.</summary>
    /// <param name="values">The set of allowed characters.</param>
    TGroupFilterBuilder In(params char?[] values);
}
