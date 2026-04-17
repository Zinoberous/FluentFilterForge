using System.Linq.Expressions;
using System.Numerics;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IFilterBuilder{T}" />
internal sealed class FilterBuilder<T> : IFilterBuilder<T>
{
    private readonly GroupFilterBuilder<T> _groupFilterBuilder;

    internal FilterBuilder() : this(new()) { }

    internal FilterBuilder(GroupFilterBuilder<T> groupFilterBuilder)
    {
        _groupFilterBuilder = groupFilterBuilder;
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, bool>> propertySelector)
        => new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, bool?>> propertySelector)
        => new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, sbyte>> propertySelector)
        => new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, sbyte?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, byte>> propertySelector)
        => new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, byte?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, short>> propertySelector)
        => new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, short?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ushort>> propertySelector)
        => new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ushort?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, int>> propertySelector)
        => new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, int?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, uint>> propertySelector)
        => new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, uint?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nint>> propertySelector)
        => new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nint?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nuint>> propertySelector)
        => new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, nuint?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, long>> propertySelector)
        => new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, long?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ulong>> propertySelector)
        => new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, ulong?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, BigInteger>> propertySelector)
        => new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, BigInteger?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, float>> propertySelector)
        => new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, float?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, double>> propertySelector)
        => new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, double?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, decimal>> propertySelector)
        => new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, decimal?>> propertySelector)
        => new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

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
