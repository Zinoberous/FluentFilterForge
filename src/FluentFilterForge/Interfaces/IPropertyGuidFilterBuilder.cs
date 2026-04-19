namespace FluentFilterForge.Interfaces;

/// <summary>
/// Provides filter conditions for a nullable <see cref="Guid"/> property.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
/// <typeparam name="TGroupFilterBuilder">The type of the builder returned after a condition is set.</typeparam>
public interface IPropertyGuidFilterBuilder<T, out TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>Matches items where the property value is <see langword="null"/>.</summary>
    TGroupFilterBuilder IsNull();

    /// <summary>Matches items where the property value equals <paramref name="value"/>.</summary>
    /// <param name="value">The GUID to compare against. Pass <see langword="null"/> to match null properties.</param>
    TGroupFilterBuilder Equal(Guid? value);

    /// <summary>Matches items where the string representation of the GUID starts with <paramref name="value"/>.</summary>
    /// <param name="value">The prefix to search for.</param>
    TGroupFilterBuilder StartsWith(string value);

    /// <summary>Matches items where the string representation of the GUID ends with <paramref name="value"/>.</summary>
    /// <param name="value">The suffix to search for.</param>
    TGroupFilterBuilder EndsWith(string value);

    /// <summary>Matches items where the string representation of the GUID contains <paramref name="value"/>.</summary>
    /// <param name="value">The substring to search for.</param>
    TGroupFilterBuilder Contains(string value);

    /// <summary>Matches items where the property value equals one of the specified <paramref name="values"/>.</summary>
    /// <param name="values">The set of allowed GUIDs.</param>
    TGroupFilterBuilder In(params Guid?[] values);
}
