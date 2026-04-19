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
        => new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, char?>> propertySelector)
        => new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, string?>> propertySelector)
        => new PropertyStringFilterBuilder<T, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, Guid>> propertySelector)
        => new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, Guid?>> propertySelector)
        => new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateOnly>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateOnly?>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeOnly>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeOnly?>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTime>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTime?>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTimeOffset>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, DateTimeOffset?>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeSpan>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Where(Expression<Func<T, TimeSpan?>> propertySelector)
        => new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> Where<TProperty>(Expression<Func<T, TProperty>> propertySelector)
        => new PropertyCustomFilterBuilder<T, TProperty, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> Where<TElement>(Expression<Func<T, IEnumerable<TElement>>> propertySelector)
        => new PropertyEnumerableFilterBuilder<T, TElement, GroupFilterBuilder<T>>(_groupFilterBuilder, propertySelector);
}
