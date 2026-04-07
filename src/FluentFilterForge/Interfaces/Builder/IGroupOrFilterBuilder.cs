using System.Linq.Expressions;
using System.Numerics;

namespace FluentFilterForge.Interfaces.Builder;

/// <inheritdoc cref="IGroupFilterBuilder{T}" />
public interface IGroupOrFilterBuilder<TEntity> : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="propertySelector"></param>
    /// <returns></returns>
    IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, bool>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, bool?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, sbyte>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, sbyte?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, byte>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, byte?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, short>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, short?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ushort>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ushort?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, int>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, int?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, uint>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, uint?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nint>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nint?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nuint>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nuint?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, long>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, long?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ulong>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ulong?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, BigInteger>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, BigInteger?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, float>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, float?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, double>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, double?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, decimal>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, decimal?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, char>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, char?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyStringNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, string?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, Guid>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, Guid?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateOnly>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateOnly?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeOnly>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeOnly?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTime>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTime?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTimeOffset>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTimeOffset?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeSpan>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeSpan?>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, IGroupStartFilterBuilder<TEntity>> Or<TProperty>(Expression<Func<TEntity, TProperty>> propertySelector);

    /// <inheritdoc cref="Or" />
    IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, IGroupStartFilterBuilder<TEntity>> Or<TElement>(Expression<Func<TEntity, IEnumerable<TElement>>> propertySelector);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="configure"></param>
    /// <returns></returns>
    IGroupOrFilterBuilder<TEntity> Or(Action<IFilterBuilder<TEntity>> configure);
}
