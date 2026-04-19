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
    public IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, bool>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, bool?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, sbyte>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, sbyte?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, byte>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, byte?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> And(Expression<Func<T, short>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> And(Expression<Func<T, short?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ushort>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ushort?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> And(Expression<Func<T, int>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> And(Expression<Func<T, int?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, uint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, uint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nuint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nuint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> And(Expression<Func<T, long>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> And(Expression<Func<T, long?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ulong>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ulong?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> And(Expression<Func<T, BigInteger>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> And(Expression<Func<T, BigInteger?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> And(Expression<Func<T, float>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> And(Expression<Func<T, float?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> And(Expression<Func<T, double>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> And(Expression<Func<T, double?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> And(Expression<Func<T, decimal>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> And(Expression<Func<T, decimal?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, char>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, char?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, string?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyStringFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, Guid>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, Guid?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateOnly>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateOnly?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeOnly>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeOnly?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTime>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTime?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeSpan>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeSpan?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> And<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyCustomFilterBuilder<T, TProperty, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> And<TElement>(Expression<Func<T, IEnumerable<TElement>>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.And);
        return new PropertyEnumerableFilterBuilder<T, TElement, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IGroupAndFilterBuilder<T> And(Action<IFilterBuilder<T>> configure)
    {
        SetLogicalOperator(LogicalOperator.And);
        return AddNestedGroup(configure);
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, bool>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyBoolNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, bool?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyBoolFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, sbyte>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, sbyte?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, sbyte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, byte>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, byte?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, byte, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, short>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, short?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, short, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ushort>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ushort?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, ushort, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, int>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, int?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, int, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, uint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, uint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, uint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, nint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nuint>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nuint?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, nuint, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, long>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, long?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, long, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ulong>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ulong?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, ulong, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, BigInteger>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, BigInteger?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, BigInteger, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, float>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, float?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, float, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, double>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, double?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, double, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, decimal>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, decimal?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyNumberFilterBuilder<T, decimal, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, char>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, char?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyCharFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, string?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyStringFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, Guid>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, Guid?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyGuidFilterBuilder<T, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateOnly>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateOnly?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeOnly>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeOnly?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, TimeOnly, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTime>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTime?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateTime, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, DateTimeOffset, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeSpan>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeSpan?>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyDateTimeFilterBuilder<T, TimeSpan, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> Or<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyCustomFilterBuilder<T, TProperty, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> Or<TElement>(Expression<Func<T, IEnumerable<TElement>>> propertySelector)
    {
        SetLogicalOperator(LogicalOperator.Or);
        return new PropertyEnumerableFilterBuilder<T, TElement, GroupFilterBuilder<T>>(this, propertySelector);
    }

    /// <inheritdoc/>
    public IGroupOrFilterBuilder<T> Or(Action<IFilterBuilder<T>> configure)
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
