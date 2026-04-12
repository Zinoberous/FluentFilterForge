using System.Linq.Expressions;
using System.Numerics;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IFilterBuilder{TEntity}" />
internal sealed class FilterBuilder<TEntity> : IFilterBuilder<TEntity>
{
    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, bool>> propertySelector)
    {
        // TODO: implement Where for bool
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, bool?>> propertySelector)
    {
        // TODO: implement Where for bool?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, sbyte>> propertySelector)
    {
        // TODO: implement Where for sbyte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, sbyte?>> propertySelector)
    {
        // TODO: implement Where for sbyte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, byte>> propertySelector)
    {
        // TODO: implement Where for byte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, byte?>> propertySelector)
    {
        // TODO: implement Where for byte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, short>> propertySelector)
    {
        // TODO: implement Where for short
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, short?>> propertySelector)
    {
        // TODO: implement Where for short?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ushort>> propertySelector)
    {
        // TODO: implement Where for ushort
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ushort?>> propertySelector)
    {
        // TODO: implement Where for ushort?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, int>> propertySelector)
    {
        // TODO: implement Where for int
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, int?>> propertySelector)
    {
        // TODO: implement Where for int?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, uint>> propertySelector)
    {
        // TODO: implement Where for uint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, uint?>> propertySelector)
    {
        // TODO: implement Where for uint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nint>> propertySelector)
    {
        // TODO: implement Where for nint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nint?>> propertySelector)
    {
        // TODO: implement Where for nint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nuint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nuint?>> propertySelector)
    {
        // TODO: implement Where for nuint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, long>> propertySelector)
    {
        // TODO: implement Where for long
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, long?>> propertySelector)
    {
        // TODO: implement Where for long?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ulong>> propertySelector)
    {
        // TODO: implement Where for ulong
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ulong?>> propertySelector)
    {
        // TODO: implement Where for ulong?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, BigInteger>> propertySelector)
    {
        // TODO: implement Where for BigInteger
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, BigInteger?>> propertySelector)
    {
        // TODO: implement Where for BigInteger?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, float>> propertySelector)
    {
        // TODO: implement Where for float
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, float?>> propertySelector)
    {
        // TODO: implement Where for float?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, double>> propertySelector)
    {
        // TODO: implement Where for double
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, double?>> propertySelector)
    {
        // TODO: implement Where for double?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, decimal>> propertySelector)
    {
        // TODO: implement Where for decimal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, decimal?>> propertySelector)
    {
        // TODO: implement Where for decimal?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, char>> propertySelector)
    {
        // TODO: implement Where for char
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, char?>> propertySelector)
    {
        // TODO: implement Where for char?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, string?>> propertySelector)
    {
        // TODO: implement Where for string
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, Guid>> propertySelector)
    {
        // TODO: implement Where for Guid
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, Guid?>> propertySelector)
    {
        // TODO: implement Where for Guid?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateOnly>> propertySelector)
    {
        // TODO: implement Where for DateOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateOnly?>> propertySelector)
    {
        // TODO: implement Where for DateOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeOnly>> propertySelector)
    {
        // TODO: implement Where for TimeOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeOnly?>> propertySelector)
    {
        // TODO: implement Where for TimeOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTime>> propertySelector)
    {
        // TODO: implement Where for DateTime
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTime?>> propertySelector)
    {
        // TODO: implement Where for DateTime?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTimeOffset>> propertySelector)
    {
        // TODO: implement Where for DateTimeOffset
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTimeOffset?>> propertySelector)
    {
        // TODO: implement Where for DateTimeOffset?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeSpan>> propertySelector)
    {
        // TODO: implement Where for TimeSpan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeSpan?>> propertySelector)
    {
        // TODO: implement Where for TimeSpan?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, IGroupStartFilterBuilder<TEntity>> Where<TProperty>(Expression<Func<TEntity, TProperty>> propertySelector)
    {
        // TODO: implement Where for custom types
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, IGroupStartFilterBuilder<TEntity>> Where<TElement>(Expression<Func<TEntity, IEnumerable<TElement>>> propertySelector)
    {
        // TODO: implement Where for enumerable types
        throw new NotImplementedException();
    }
}
