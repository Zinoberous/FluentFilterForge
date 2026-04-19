namespace FluentFilterForge.Interfaces;

/// <summary>
/// Provides filter conditions for a nullable boolean property.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
/// <typeparam name="TGroupFilterBuilder">The type of the builder returned after a condition is set.</typeparam>
public interface IPropertyBoolFilterBuilder<T, out TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>Matches items where the property value is <see langword="null"/>.</summary>
    TGroupFilterBuilder IsNull();

    /// <summary>Matches items where the property value is <see langword="true"/>.</summary>
    TGroupFilterBuilder IsTrue();

    /// <summary>Matches items where the property value is <see langword="false"/>.</summary>
    TGroupFilterBuilder IsFalse();

    /// <summary>Matches items where the property value equals <paramref name="value"/>.</summary>
    /// <param name="value">The value to compare against. Pass <see langword="null"/> to match null properties.</param>
    TGroupFilterBuilder Equal(bool? value);
}
