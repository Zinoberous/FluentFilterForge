using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// Provides filter conditions for a numeric property of type <typeparamref name="TNumber"/>.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
/// <typeparam name="TNumber">The numeric value type (e.g. <see cref="int"/>, <see cref="decimal"/>, …).</typeparam>
/// <typeparam name="TGroupFilterBuilder">The type of the builder returned after a condition is set.</typeparam>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyNumberFilterBuilder<T, TNumber, out TGroupFilterBuilder>
    where TNumber : struct, INumber<TNumber>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>Matches items where the property value is <see langword="null"/>.</summary>
    TGroupFilterBuilder IsNull();

    /// <summary>Matches items where the property value equals <paramref name="value"/>.</summary>
    /// <param name="value">The value to compare against. Pass <see langword="null"/> to match null properties.</param>
    TGroupFilterBuilder Equal(TNumber? value);

    /// <summary>Matches items where the property value is greater than <paramref name="value"/>.</summary>
    /// <param name="value">The exclusive lower bound.</param>
    TGroupFilterBuilder GreaterThan(TNumber value);

    /// <summary>Matches items where the property value is greater than or equal to <paramref name="value"/>.</summary>
    /// <param name="value">The inclusive lower bound.</param>
    TGroupFilterBuilder GreaterThanOrEqual(TNumber value);

    /// <summary>Matches items where the property value is less than <paramref name="value"/>.</summary>
    /// <param name="value">The exclusive upper bound.</param>
    TGroupFilterBuilder LessThan(TNumber value);

    /// <summary>Matches items where the property value is less than or equal to <paramref name="value"/>.</summary>
    /// <param name="value">The inclusive upper bound.</param>
    TGroupFilterBuilder LessThanOrEqual(TNumber value);

    /// <summary>Matches items where the property value is between <paramref name="from"/> and <paramref name="to"/> (inclusive).</summary>
    /// <param name="from">The inclusive lower bound.</param>
    /// <param name="to">The inclusive upper bound.</param>
    TGroupFilterBuilder Between(TNumber from, TNumber to);

    /// <summary>Matches items where the property value equals one of the specified <paramref name="values"/>.</summary>
    /// <param name="values">The set of allowed values.</param>
    TGroupFilterBuilder In(params TNumber?[] values);
}
