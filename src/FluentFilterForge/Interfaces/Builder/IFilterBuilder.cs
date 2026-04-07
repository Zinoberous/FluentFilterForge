using System.Linq.Expressions;
using System.Numerics;

namespace FluentFilterForge.Interfaces.Builder;

/// <summary>
/// TODO: add documentation
/// </summary>
public interface IFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="propertySelector"></param>
    /// <returns></returns>
    IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, bool>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, bool?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, sbyte>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, sbyte?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, byte>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, byte?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, short>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, short?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ushort>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ushort?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, int>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, int?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, uint>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, uint?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nint>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nint?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nuint>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nuint?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, long>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, long?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ulong>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ulong?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, BigInteger>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, BigInteger?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, float>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, float?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, double>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, double?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, decimal>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, decimal?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, char>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, char?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyStringNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, string?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, Guid>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, Guid?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateOnly>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateOnly?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeOnly>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeOnly?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTime>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTime?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTimeOffset>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTimeOffset?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeSpan>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeSpan?>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, IGroupStartFilterBuilder<TEntity>> Where<TProperty>(Expression<Func<TEntity, TProperty>> propertySelector);

    /// <inheritdoc cref="Where" />
    IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, IGroupStartFilterBuilder<TEntity>> Where<TElement>(Expression<Func<TEntity, IEnumerable<TElement>>> propertySelector);
}
