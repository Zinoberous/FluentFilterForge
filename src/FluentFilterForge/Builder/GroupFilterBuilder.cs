using System.Linq.Expressions;
using System.Numerics;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IGroupStartFilterBuilder{TEntity}" />
internal sealed class GroupFilterBuilder<TEntity> : IGroupStartFilterBuilder<TEntity>
{
    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, bool>> propertySelector)
    {
        // TODO: implement And for bool
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, bool?>> propertySelector)
    {
        // TODO: implement And for bool?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, sbyte>> propertySelector)
    {
        // TODO: implement And for sbyte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, sbyte?>> propertySelector)
    {
        // TODO: implement And for sbyte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, byte>> propertySelector)
    {
        // TODO: implement And for byte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, byte?>> propertySelector)
    {
        // TODO: implement And for byte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, short>> propertySelector)
    {
        // TODO: implement And for short
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, short?>> propertySelector)
    {
        // TODO: implement And for short?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ushort>> propertySelector)
    {
        // TODO: implement And for ushort
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ushort?>> propertySelector)
    {
        // TODO: implement And for ushort?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, int>> propertySelector)
    {
        // TODO: implement And for int
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, int?>> propertySelector)
    {
        // TODO: implement And for int?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, uint>> propertySelector)
    {
        // TODO: implement And for uint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, uint?>> propertySelector)
    {
        // TODO: implement And for uint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nint>> propertySelector)
    {
        // TODO: implement And for nint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nint?>> propertySelector)
    {
        // TODO: implement And for nint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nuint>> propertySelector)
    {
        // TODO: implement And for nuint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nuint?>> propertySelector)
    {
        // TODO: implement And for nuint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, long>> propertySelector)
    {
        // TODO: implement And for long
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, long?>> propertySelector)
    {
        // TODO: implement And for long?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ulong>> propertySelector)
    {
        // TODO: implement And for ulong
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ulong?>> propertySelector)
    {
        // TODO: implement And for ulong?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, BigInteger>> propertySelector)
    {
        // TODO: implement And for BigInteger
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, BigInteger?>> propertySelector)
    {
        // TODO: implement And for BigInteger?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, float>> propertySelector)
    {
        // TODO: implement And for float
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, float?>> propertySelector)
    {
        // TODO: implement And for float?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, double>> propertySelector)
    {
        // TODO: implement And for double
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, double?>> propertySelector)
    {
        // TODO: implement And for double?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, decimal>> propertySelector)
    {
        // TODO: implement And for decimal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, decimal?>> propertySelector)
    {
        // TODO: implement And for decimal?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, char>> propertySelector)
    {
        // TODO: implement And for char
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, char?>> propertySelector)
    {
        // TODO: implement And for char?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, string?>> propertySelector)
    {
        // TODO: implement And for string
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, Guid>> propertySelector)
    {
        // TODO: implement And for Guid
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, Guid?>> propertySelector)
    {
        // TODO: implement And for Guid?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateOnly>> propertySelector)
    {
        // TODO: implement And for DateOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateOnly?>> propertySelector)
    {
        // TODO: implement And for DateOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeOnly>> propertySelector)
    {
        // TODO: implement And for TimeOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeOnly?>> propertySelector)
    {
        // TODO: implement And for TimeOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTime>> propertySelector)
    {
        // TODO: implement And for DateTime
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTime?>> propertySelector)
    {
        // TODO: implement And for DateTime?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTimeOffset>> propertySelector)
    {
        // TODO: implement And for DateTimeOffset
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTimeOffset?>> propertySelector)
    {
        // TODO: implement And for DateTimeOffset?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeSpan>> propertySelector)
    {
        // TODO: implement And for TimeSpan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeSpan?>> propertySelector)
    {
        // TODO: implement And for TimeSpan?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, IGroupStartFilterBuilder<TEntity>> And<TProperty>(Expression<Func<TEntity, TProperty>> propertySelector)
    {
        // TODO: implement And for custom types
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, IGroupStartFilterBuilder<TEntity>> And<TElement>(Expression<Func<TEntity, IEnumerable<TElement>>> propertySelector)
    {
        // TODO: implement And for enumerable types
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IGroupAndFilterBuilder<TEntity> And(Action<IFilterBuilder<TEntity>> configure)
    {
        // TODO: implement And for nested groups
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, bool>> propertySelector)
    {
        // TODO: implement Or for bool
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, bool?>> propertySelector)
    {
        // TODO: implement Or for bool?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, sbyte>> propertySelector)
    {
        // TODO: implement Or for sbyte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, sbyte?>> propertySelector)
    {
        // TODO: implement Or for sbyte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, byte>> propertySelector)
    {
        // TODO: implement Or for byte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, byte?>> propertySelector)
    {
        // TODO: implement Or for byte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, short>> propertySelector)
    {
        // TODO: implement Or for short
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, short?>> propertySelector)
    {
        // TODO: implement Or for short?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ushort>> propertySelector)
    {
        // TODO: implement Or for ushort
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ushort?>> propertySelector)
    {
        // TODO: implement Or for ushort?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, int>> propertySelector)
    {
        // TODO: implement Or for int
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, int?>> propertySelector)
    {
        // TODO: implement Or for int?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, uint>> propertySelector)
    {
        // TODO: implement Or for uint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, uint?>> propertySelector)
    {
        // TODO: implement Or for uint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nint>> propertySelector)
    {
        // TODO: implement Or for nint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nint?>> propertySelector)
    {
        // TODO: implement Or for nint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nuint>> propertySelector)
    {
        // TODO: implement Or for nuint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nuint?>> propertySelector)
    {
        // TODO: implement Or for nuint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, long>> propertySelector)
    {
        // TODO: implement Or for long
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, long?>> propertySelector)
    {
        // TODO: implement Or for long?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ulong>> propertySelector)
    {
        // TODO: implement Or for ulong
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ulong?>> propertySelector)
    {
        // TODO: implement Or for ulong?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, BigInteger>> propertySelector)
    {
        // TODO: implement Or for BigInteger
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, BigInteger?>> propertySelector)
    {
        // TODO: implement Or for BigInteger?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, float>> propertySelector)
    {
        // TODO: implement Or for float
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, float?>> propertySelector)
    {
        // TODO: implement Or for float?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, double>> propertySelector)
    {
        // TODO: implement Or for double
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, double?>> propertySelector)
    {
        // TODO: implement Or for double?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, decimal>> propertySelector)
    {
        // TODO: implement Or for decimal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, decimal?>> propertySelector)
    {
        // TODO: implement Or for decimal?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, char>> propertySelector)
    {
        // TODO: implement Or for char
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, char?>> propertySelector)
    {
        // TODO: implement Or for char?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, string?>> propertySelector)
    {
        // TODO: implement Or for string
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, Guid>> propertySelector)
    {
        // TODO: implement Or for Guid
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, Guid?>> propertySelector)
    {
        // TODO: implement Or for Guid?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateOnly>> propertySelector)
    {
        // TODO: implement Or for DateOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateOnly?>> propertySelector)
    {
        // TODO: implement Or for DateOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeOnly>> propertySelector)
    {
        // TODO: implement Or for TimeOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeOnly?>> propertySelector)
    {
        // TODO: implement Or for TimeOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTime>> propertySelector)
    {
        // TODO: implement Or for DateTime
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTime?>> propertySelector)
    {
        // TODO: implement Or for DateTime?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTimeOffset>> propertySelector)
    {
        // TODO: implement Or for DateTimeOffset
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTimeOffset?>> propertySelector)
    {
        // TODO: implement Or for DateTimeOffset?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeSpan>> propertySelector)
    {
        // TODO: implement Or for TimeSpan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeSpan?>> propertySelector)
    {
        // TODO: implement Or for TimeSpan?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, IGroupStartFilterBuilder<TEntity>> Or<TProperty>(Expression<Func<TEntity, TProperty>> propertySelector)
    {
        // TODO: implement Or for custom types
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, IGroupStartFilterBuilder<TEntity>> Or<TElement>(Expression<Func<TEntity, IEnumerable<TElement>>> propertySelector)
    {
        // TODO: implement Or for enumerable types
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IGroupOrFilterBuilder<TEntity> Or(Action<IFilterBuilder<TEntity>> configure)
    {
        // TODO: implement Or for nested groups
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IFilter<TEntity> Build()
    {
        // TODO: implement Build
        throw new NotImplementedException();
    }
}
