using System.Linq.Expressions;
using System.Numerics;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// Extends <see cref="IGroupFilterBuilder{T}"/> with <c>Or</c> chaining capabilities.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
public interface IGroupOrFilterBuilder<T> : IGroupFilterBuilder<T>
{
    /// <summary>
    /// Adds an additional <c>OR</c> condition on the specified boolean property.
    /// </summary>
    /// <param name="propertySelector">Expression selecting the property to filter on.</param>
    /// <returns>A builder to configure the condition for the selected property.</returns>
    IPropertyBoolNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, bool>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyBoolNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, bool?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, sbyte>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, sbyte?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, byte>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, byte?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, short>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, short?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, ushort>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, ushort?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, int>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, int?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, uint>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, uint?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, nint>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, nint?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, nuint>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, nuint?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, long>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, long?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, ulong>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, ulong?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, BigInteger>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, BigInteger?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, float>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, float?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, double>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, double?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, decimal>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, decimal?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyCharNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, char>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyCharNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, char?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyStringNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, string?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, Guid>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, Guid?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateOnly>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateOnly?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, TimeOnly>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, TimeOnly?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateTime>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateTime?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, TimeSpan>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, TimeSpan?>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupOrFilterBuilder<T>> Or<TProperty>(Expression<Func<T, TProperty>> propertySelector);

    /// <inheritdoc cref="Or(Expression{Func{T, bool}})" />
    IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupOrFilterBuilder<T>> Or<TElement>(Expression<Func<T, IEnumerable<TElement>?>> propertySelector);

    /// <summary>
    /// Adds a nested <c>OR</c> group. All conditions inside the delegate are evaluated
    /// together and their result is combined with the outer filter using <c>OR</c>.
    /// </summary>
    /// <param name="configure">A delegate to configure the conditions of the nested group.</param>
    /// <returns>The current builder to allow further chaining.</returns>
    IGroupOrFilterBuilder<T> OrGroup(Action<IFilterBuilder<T>> configure);
}
