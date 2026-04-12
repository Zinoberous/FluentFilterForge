#pragma warning disable CS0419 // Zweideutige Referenz im cref-Attribut

using System.Linq.Expressions;
using System.Numerics;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IGroupFilterBuilder{T}" />
public interface IGroupOrFilterBuilder<T> : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="propertySelector"></param>
    /// <returns></returns>
    IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, bool>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, bool?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, sbyte>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, sbyte?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, byte>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, byte?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, short>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, short?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ushort>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ushort?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, int>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, int?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, uint>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, uint?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nint>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nint?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nuint>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nuint?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, long>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, long?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ulong>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ulong?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, BigInteger>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, BigInteger?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, float>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, float?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, double>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, double?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, decimal>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, decimal?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, char>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, char?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, string?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, Guid>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, Guid?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateOnly>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateOnly?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeOnly>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeOnly?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTime>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTime?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeSpan>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeSpan?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> Or<TProperty>(Expression<Func<T, TProperty>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> Or<TElement>(Expression<Func<T, IEnumerable<TElement>>> propertySelector);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="configure"></param>
    /// <returns></returns>
    IGroupOrFilterBuilder<T> Or(Action<IFilterBuilder<T>> configure);
}
