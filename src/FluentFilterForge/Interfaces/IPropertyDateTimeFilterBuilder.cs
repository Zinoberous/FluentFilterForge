using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// Provides filter conditions for a date/time property of type <typeparamref name="TDateTime"/>
/// (e.g. <see cref="DateTime"/>, <see cref="DateOnly"/>, <see cref="TimeOnly"/>,
/// <see cref="DateTimeOffset"/> or <see cref="TimeSpan"/>).
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
/// <typeparam name="TDateTime">The date/time value type.</typeparam>
/// <typeparam name="TGroupFilterBuilder">The type of the builder returned after a condition is set.</typeparam>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyDateTimeFilterBuilder<T, TDateTime, out TGroupFilterBuilder>
    where TDateTime : struct
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>Matches items where the property value is <see langword="null"/>.</summary>
    TGroupFilterBuilder IsNull();

    /// <summary>Matches items where the property value equals <paramref name="value"/>.</summary>
    /// <param name="value">The value to compare against. Pass <see langword="null"/> to match null properties.</param>
    TGroupFilterBuilder Equal(TDateTime? value);

    /// <summary>Matches items where the property value is after <paramref name="value"/>.</summary>
    /// <param name="value">The exclusive lower bound.</param>
    TGroupFilterBuilder GreaterThan(TDateTime value);

    /// <summary>Matches items where the property value is <paramref name="value"/> or later.</summary>
    /// <param name="value">The inclusive lower bound.</param>
    TGroupFilterBuilder GreaterThanOrEqual(TDateTime value);

    /// <summary>Matches items where the property value is before <paramref name="value"/>.</summary>
    /// <param name="value">The exclusive upper bound.</param>
    TGroupFilterBuilder LessThan(TDateTime value);

    /// <summary>Matches items where the property value is <paramref name="value"/> or earlier.</summary>
    /// <param name="value">The inclusive upper bound.</param>
    TGroupFilterBuilder LessThanOrEqual(TDateTime value);

    /// <summary>Matches items where the property value falls within the range [<paramref name="from"/>, <paramref name="to"/>] (inclusive).</summary>
    /// <param name="from">The inclusive lower bound.</param>
    /// <param name="to">The inclusive upper bound.</param>
    TGroupFilterBuilder Between(TDateTime from, TDateTime to);

    /// <summary>Matches items where the property value equals one of the specified <paramref name="values"/>.</summary>
    /// <param name="values">The set of allowed values.</param>
    TGroupFilterBuilder In(params TDateTime?[] values);
}
