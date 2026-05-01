using System.Linq.Expressions;
using System.Numerics;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// Extends <see cref="IGroupFilterBuilder{T}"/> with <c>And</c> chaining capabilities.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
public interface IGroupAndFilterBuilder<T> : IGroupFilterBuilder<T>
{
    /// <summary>
    /// Adds an additional <c>AND</c> condition on the specified boolean property.
    /// </summary>
    /// <param name="propertySelector">Expression selecting the property to filter on.</param>
    /// <returns>A builder to configure the condition for the selected property.</returns>
    IPropertyBoolNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, bool>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyBoolNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, bool?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupAndFilterBuilder<T>> And(Expression<Func<T, sbyte>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupAndFilterBuilder<T>> And(Expression<Func<T, sbyte?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupAndFilterBuilder<T>> And(Expression<Func<T, byte>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupAndFilterBuilder<T>> And(Expression<Func<T, byte?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupAndFilterBuilder<T>> And(Expression<Func<T, short>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupAndFilterBuilder<T>> And(Expression<Func<T, short?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupAndFilterBuilder<T>> And(Expression<Func<T, ushort>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupAndFilterBuilder<T>> And(Expression<Func<T, ushort?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupAndFilterBuilder<T>> And(Expression<Func<T, int>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupAndFilterBuilder<T>> And(Expression<Func<T, int?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, uint>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, uint?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, nint>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, nint?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, nuint>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, nuint?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupAndFilterBuilder<T>> And(Expression<Func<T, long>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupAndFilterBuilder<T>> And(Expression<Func<T, long?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupAndFilterBuilder<T>> And(Expression<Func<T, ulong>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupAndFilterBuilder<T>> And(Expression<Func<T, ulong?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupAndFilterBuilder<T>> And(Expression<Func<T, BigInteger>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupAndFilterBuilder<T>> And(Expression<Func<T, BigInteger?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupAndFilterBuilder<T>> And(Expression<Func<T, float>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupAndFilterBuilder<T>> And(Expression<Func<T, float?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupAndFilterBuilder<T>> And(Expression<Func<T, double>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupAndFilterBuilder<T>> And(Expression<Func<T, double?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupAndFilterBuilder<T>> And(Expression<Func<T, decimal>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupAndFilterBuilder<T>> And(Expression<Func<T, decimal?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyCharNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, char>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyCharNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, char?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyStringNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, string?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, Guid>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, Guid?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateOnly>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateOnly?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupAndFilterBuilder<T>> And(Expression<Func<T, TimeOnly>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupAndFilterBuilder<T>> And(Expression<Func<T, TimeOnly?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateTime>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateTime?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupAndFilterBuilder<T>> And(Expression<Func<T, TimeSpan>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupAndFilterBuilder<T>> And(Expression<Func<T, TimeSpan?>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupAndFilterBuilder<T>> And<TProperty>(Expression<Func<T, TProperty>> propertySelector);

    /// <inheritdoc cref="And(Expression{Func{T, bool}})" />
    IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupAndFilterBuilder<T>> And<TElement>(Expression<Func<T, IEnumerable<TElement>?>> propertySelector);

    /// <summary>
    /// Adds a nested <c>AND</c> group. All conditions inside the delegate are evaluated
    /// together and their result is combined with the outer filter using <c>AND</c>.
    /// </summary>
    /// <param name="configure">A delegate to configure the conditions of the nested group.</param>
    /// <returns>The current builder to allow further chaining.</returns>
    IGroupAndFilterBuilder<T> AndGroup(Action<IFilterBuilder<T>> configure);
}
