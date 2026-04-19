#pragma warning disable CS0419 // Zweideutige Referenz im cref-Attribut

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
    IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, bool>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, bool?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, sbyte>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, sbyte?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, byte>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, byte?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> And(Expression<Func<T, short>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> And(Expression<Func<T, short?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ushort>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ushort?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> And(Expression<Func<T, int>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> And(Expression<Func<T, int?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, uint>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, uint?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nint>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nint?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nuint>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nuint?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> And(Expression<Func<T, long>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> And(Expression<Func<T, long?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ulong>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ulong?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> And(Expression<Func<T, BigInteger>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> And(Expression<Func<T, BigInteger?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> And(Expression<Func<T, float>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> And(Expression<Func<T, float?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> And(Expression<Func<T, double>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> And(Expression<Func<T, double?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> And(Expression<Func<T, decimal>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> And(Expression<Func<T, decimal?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, char>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, char?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, string?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, Guid>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, Guid?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateOnly>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateOnly?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeOnly>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeOnly?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTime>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTime?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeSpan>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeSpan?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> And<TProperty>(Expression<Func<T, TProperty>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> And<TElement>(Expression<Func<T, IEnumerable<TElement>>> propertySelector);

    /// <summary>
    /// Adds a nested <c>AND</c> group. All conditions inside the delegate are evaluated
    /// together and their result is combined with the outer filter using <c>AND</c>.
    /// </summary>
    /// <param name="configure">A delegate to configure the conditions of the nested group.</param>
    /// <returns>The current builder to allow further chaining.</returns>
    IGroupAndFilterBuilder<T> And(Action<IFilterBuilder<T>> configure);
}
