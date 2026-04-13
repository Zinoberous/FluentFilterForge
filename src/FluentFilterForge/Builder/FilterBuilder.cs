using System.Linq.Expressions;
using System.Numerics;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IFilterBuilder{T}" />
internal sealed class FilterBuilder<T> : IFilterBuilder<T>
{
    private readonly FilterGroup _filterGroup;

    internal FilterBuilder() : this(new()) { }

    internal FilterBuilder(FilterGroup filterGroup)
    {
        _filterGroup = filterGroup;
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, bool>> propertySelector)
    {
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(_filterGroup, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, bool?>> propertySelector)
    {
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(_filterGroup, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, sbyte>> propertySelector)
    {
        // TODO: implement Where for sbyte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, sbyte?>> propertySelector)
    {
        // TODO: implement Where for sbyte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, byte>> propertySelector)
    {
        // TODO: implement Where for byte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, byte?>> propertySelector)
    {
        // TODO: implement Where for byte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, short>> propertySelector)
    {
        // TODO: implement Where for short
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, short?>> propertySelector)
    {
        // TODO: implement Where for short?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ushort>> propertySelector)
    {
        // TODO: implement Where for ushort
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ushort?>> propertySelector)
    {
        // TODO: implement Where for ushort?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, int>> propertySelector)
    {
        // TODO: implement Where for int
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, int?>> propertySelector)
    {
        // TODO: implement Where for int?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, uint>> propertySelector)
    {
        // TODO: implement Where for uint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, uint?>> propertySelector)
    {
        // TODO: implement Where for uint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nint>> propertySelector)
    {
        // TODO: implement Where for nint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nint?>> propertySelector)
    {
        // TODO: implement Where for nint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nuint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nuint?>> propertySelector)
    {
        // TODO: implement Where for nuint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, long>> propertySelector)
    {
        // TODO: implement Where for long
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, long?>> propertySelector)
    {
        // TODO: implement Where for long?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ulong>> propertySelector)
    {
        // TODO: implement Where for ulong
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ulong?>> propertySelector)
    {
        // TODO: implement Where for ulong?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, BigInteger>> propertySelector)
    {
        // TODO: implement Where for BigInteger
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, BigInteger?>> propertySelector)
    {
        // TODO: implement Where for BigInteger?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, float>> propertySelector)
    {
        // TODO: implement Where for float
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, float?>> propertySelector)
    {
        // TODO: implement Where for float?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, double>> propertySelector)
    {
        // TODO: implement Where for double
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, double?>> propertySelector)
    {
        // TODO: implement Where for double?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, decimal>> propertySelector)
    {
        // TODO: implement Where for decimal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, decimal?>> propertySelector)
    {
        // TODO: implement Where for decimal?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, char>> propertySelector)
    {
        // TODO: implement Where for char
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, char?>> propertySelector)
    {
        // TODO: implement Where for char?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, string?>> propertySelector)
    {
        // TODO: implement Where for string
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, Guid>> propertySelector)
    {
        // TODO: implement Where for Guid
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, Guid?>> propertySelector)
    {
        // TODO: implement Where for Guid?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateOnly>> propertySelector)
    {
        // TODO: implement Where for DateOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateOnly?>> propertySelector)
    {
        // TODO: implement Where for DateOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeOnly>> propertySelector)
    {
        // TODO: implement Where for TimeOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeOnly?>> propertySelector)
    {
        // TODO: implement Where for TimeOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTime>> propertySelector)
    {
        // TODO: implement Where for DateTime
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTime?>> propertySelector)
    {
        // TODO: implement Where for DateTime?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTimeOffset>> propertySelector)
    {
        // TODO: implement Where for DateTimeOffset
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTimeOffset?>> propertySelector)
    {
        // TODO: implement Where for DateTimeOffset?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeSpan>> propertySelector)
    {
        // TODO: implement Where for TimeSpan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeSpan?>> propertySelector)
    {
        // TODO: implement Where for TimeSpan?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> Where<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        // TODO: implement Where for custom types
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> Where<TElement>(Expression<Func<T, IEnumerable<TElement>>> propertySelector)
    {
        // TODO: implement Where for enumerable types
        throw new NotImplementedException();
    }
}
