using System.Linq.Expressions;
using System.Numerics;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IGroupFilterBuilder{TEntity}" />
public interface IGroupAndFilterBuilder<TEntity> : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="propertySelector"></param>
    /// <returns></returns>
    IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, bool>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, bool?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, sbyte>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, sbyte?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, byte>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, byte?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, short>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, short?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ushort>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ushort?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, int>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, int?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, uint>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, uint?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nint>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nint?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nuint>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nuint?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, long>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, long?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ulong>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ulong?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, BigInteger>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, BigInteger?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, float>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, float?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, double>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, double?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, decimal>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, decimal?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, char>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, char?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyStringNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, string?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, Guid>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, Guid?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateOnly>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateOnly?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeOnly>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeOnly?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTime>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTime?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTimeOffset>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTimeOffset?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeSpan>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeSpan?>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, IGroupStartFilterBuilder<TEntity>> And<TProperty>(Expression<Func<TEntity, TProperty>> propertySelector);

    /// <inheritdoc cref="And" />
    IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, IGroupStartFilterBuilder<TEntity>> And<TElement>(Expression<Func<TEntity, IEnumerable<TElement>>> propertySelector);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="configure"></param>
    /// <returns></returns>
    IGroupAndFilterBuilder<TEntity> And(Action<IFilterBuilder<TEntity>> configure);
}
