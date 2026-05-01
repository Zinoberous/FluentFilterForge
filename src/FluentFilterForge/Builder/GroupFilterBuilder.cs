using System.Linq.Expressions;
using System.Numerics;
using FluentFilterForge.Enums;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IGroupStartFilterBuilder{T}" />
internal sealed class GroupFilterBuilder<T> : IGroupStartFilterBuilder<T>, IGroupFilterBuilderInternal<T>
{
    private readonly FilterGroup _filterGroup;

    internal GroupFilterBuilder() : this(new()) { }

    internal GroupFilterBuilder(FilterGroup filterGroup)
    {
        _filterGroup = filterGroup;
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, bool>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, bool?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupAndFilterBuilder<T>> And(Expression<Func<T, sbyte>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupAndFilterBuilder<T>> And(Expression<Func<T, sbyte?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupAndFilterBuilder<T>> And(Expression<Func<T, byte>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupAndFilterBuilder<T>> And(Expression<Func<T, byte?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupAndFilterBuilder<T>> And(Expression<Func<T, short>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupAndFilterBuilder<T>> And(Expression<Func<T, short?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupAndFilterBuilder<T>> And(Expression<Func<T, ushort>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupAndFilterBuilder<T>> And(Expression<Func<T, ushort?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupAndFilterBuilder<T>> And(Expression<Func<T, int>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupAndFilterBuilder<T>> And(Expression<Func<T, int?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, uint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, uint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, nint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, nint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, nuint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupAndFilterBuilder<T>> And(Expression<Func<T, nuint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupAndFilterBuilder<T>> And(Expression<Func<T, long>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupAndFilterBuilder<T>> And(Expression<Func<T, long?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupAndFilterBuilder<T>> And(Expression<Func<T, ulong>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupAndFilterBuilder<T>> And(Expression<Func<T, ulong?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupAndFilterBuilder<T>> And(Expression<Func<T, BigInteger>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupAndFilterBuilder<T>> And(Expression<Func<T, BigInteger?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupAndFilterBuilder<T>> And(Expression<Func<T, float>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupAndFilterBuilder<T>> And(Expression<Func<T, float?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupAndFilterBuilder<T>> And(Expression<Func<T, double>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupAndFilterBuilder<T>> And(Expression<Func<T, double?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupAndFilterBuilder<T>> And(Expression<Func<T, decimal>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupAndFilterBuilder<T>> And(Expression<Func<T, decimal?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, char>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, char?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, string?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyStringFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, Guid>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupAndFilterBuilder<T>> And(Expression<Func<T, Guid?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateOnly>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateOnly?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupAndFilterBuilder<T>> And(Expression<Func<T, TimeOnly>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupAndFilterBuilder<T>> And(Expression<Func<T, TimeOnly?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateTime>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateTime?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupAndFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupAndFilterBuilder<T>> And(Expression<Func<T, TimeSpan>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupAndFilterBuilder<T>> And(Expression<Func<T, TimeSpan?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupAndFilterBuilder<T>> And<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyCustomFilterBuilder<T, TProperty, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupAndFilterBuilder<T>> And<TElement>(Expression<Func<T, IEnumerable<TElement>?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyEnumerableFilterBuilder<T, TElement, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IGroupAndFilterBuilder<T> AndGroup(Action<IFilterBuilder<T>> configure)
    {
        SetLogicalOperator(LogicalOperator.And);
        return AddNestedGroup(configure);
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, bool>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, bool?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, sbyte>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, sbyte?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, byte>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, byte?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, short>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, short?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, ushort>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, ushort?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, int>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, int?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, uint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, uint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, nint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, nint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, nuint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, nuint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, long>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, long?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, ulong>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, ulong?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, BigInteger>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, BigInteger?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, float>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, float?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, double>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, double?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, decimal>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, decimal?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, char>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, char?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, string?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyStringFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, Guid>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, Guid?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateOnly>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateOnly?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, TimeOnly>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, TimeOnly?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateTime>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateTime?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, TimeSpan>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupOrFilterBuilder<T>> Or(Expression<Func<T, TimeSpan?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupOrFilterBuilder<T>> Or<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyCustomFilterBuilder<T, TProperty, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupOrFilterBuilder<T>> Or<TElement>(Expression<Func<T, IEnumerable<TElement>?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyEnumerableFilterBuilder<T, TElement, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IGroupOrFilterBuilder<T> OrGroup(Action<IFilterBuilder<T>> configure)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return AddNestedGroup(configure);
    }

    /// <inheritdoc/>
    public IFilter<T> Build()
    {
        return new Filter<T>() { Root = _filterGroup };
    }

    /// <inheritdoc/>
    public void AddNode(IFilterNode filterNode)
    {
        _filterGroup.Nodes.Add(filterNode);
    }

    private void SetLogicalOperator(LogicalOperator logicalOperator)
    {
        if (_filterGroup.LogicalOperator is null)
        {
            _filterGroup.LogicalOperator = logicalOperator;
            return;
        }

        if (_filterGroup.LogicalOperator != logicalOperator)
        {
            throw new InvalidOperationException($"Logical operator is already set to '{_filterGroup.LogicalOperator}' for this group. Cannot Set to '{logicalOperator}'.");
        }
    }

    private GroupFilterBuilder<T> AddNestedGroup(Action<IFilterBuilder<T>> configure)
    {
        FilterGroup nestedGroup = new();
        GroupFilterBuilder<T> nestedGroupBuilder = new(nestedGroup);
        FilterBuilder<T> nestedFilterBuilder = new(nestedGroupBuilder);

        configure(nestedFilterBuilder);

        _filterGroup.Nodes.Add(nestedGroup);

        return this;
    }
}
