using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// Provides filter conditions for a property of a custom type <typeparamref name="TProperty"/>.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
/// <typeparam name="TProperty">The type of the property being filtered.</typeparam>
/// <typeparam name="TGroupFilterBuilder">The type of the builder returned after a condition is set.</typeparam>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyCustomFilterBuilder<T, in TProperty, out TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>Matches items where the property value is <see langword="null"/>.</summary>
    TGroupFilterBuilder IsNull();

    /// <summary>Matches items where the property value equals <paramref name="value"/>.</summary>
    /// <param name="value">The value to compare against. Pass <see langword="null"/> to match null properties.</param>
    TGroupFilterBuilder Equal(TProperty? value);
}
