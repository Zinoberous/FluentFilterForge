#pragma warning disable CS0419 // Zweideutige Referenz im cref-Attribut

using System.Linq.Expressions;
using System.Numerics;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// TODO: add documentation
/// </summary>
public interface IFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="propertySelector"></param>
    /// <returns></returns>
    IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, bool>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, bool?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, sbyte>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, sbyte?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, byte>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, byte?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, short>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, short?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ushort>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ushort?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, int>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, int?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, uint>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, uint?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nint>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nint?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nuint>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nuint?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, long>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, long?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ulong>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ulong?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, BigInteger>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, BigInteger?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, float>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, float?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, double>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, double?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, decimal>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, decimal?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, char>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, char?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, string?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, Guid>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, Guid?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateOnly>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateOnly?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeOnly>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeOnly?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTime>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTime?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTimeOffset>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTimeOffset?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeSpan>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeSpan?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> Where<TProperty>(Expression<Func<T, TProperty>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> Where<TElement>(Expression<Func<T, IEnumerable<TElement>>> propertySelector);
}
