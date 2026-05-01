using System.Linq.Expressions;
using System.Numerics;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// Fluent builder for creating type-safe filters on objects of type <typeparamref name="T"/>.
/// Start a filter chain with <see cref="Filter.For{T}"/> and call <c>Where(…)</c> to select a property.
/// </summary>
/// <typeparam name="T">The type of object being filtered.</typeparam>
public interface IFilterBuilder<T>
{
    /// <summary>
    /// Starts a filter condition on the specified property.
    /// </summary>
    /// <param name="propertySelector">Expression selecting the property to filter on.</param>
    /// <returns>A builder to configure the condition for the selected property.</returns>
    IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, bool>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, bool?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, sbyte>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, sbyte?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, byte>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, byte?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, short>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, short?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ushort>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ushort?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, int>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, int?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, uint>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, uint?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nint>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nint?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nuint>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nuint?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, long>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, long?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ulong>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ulong?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, BigInteger>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, BigInteger?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, float>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, float?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, double>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, double?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, decimal>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, decimal?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, char>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, char?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, string?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, Guid>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, Guid?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateOnly>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateOnly?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeOnly>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeOnly?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTime>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTime?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTimeOffset>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTimeOffset?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeSpan>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeSpan?>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> Where<TProperty>(Expression<Func<T, TProperty>> propertySelector);

    /// <inheritdoc cref="Where(Expression{Func{T, bool}})" />
    IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> Where<TElement>(Expression<Func<T, IEnumerable<TElement>?>> propertySelector);
}
