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
        // TODO: implement And for sbyte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, sbyte?>> propertySelector)
    {
        // TODO: implement And for sbyte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, byte>> propertySelector)
    {
        // TODO: implement And for byte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> And(Expression<Func<T, byte?>> propertySelector)
    {
        // TODO: implement And for byte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> And(Expression<Func<T, short>> propertySelector)
    {
        // TODO: implement And for short
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> And(Expression<Func<T, short?>> propertySelector)
    {
        // TODO: implement And for short?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ushort>> propertySelector)
    {
        // TODO: implement And for ushort
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ushort?>> propertySelector)
    {
        // TODO: implement And for ushort?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> And(Expression<Func<T, int>> propertySelector)
    {
        // TODO: implement And for int
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> And(Expression<Func<T, int?>> propertySelector)
    {
        // TODO: implement And for int?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, uint>> propertySelector)
    {
        // TODO: implement And for uint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, uint?>> propertySelector)
    {
        // TODO: implement And for uint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nint>> propertySelector)
    {
        // TODO: implement And for nint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nint?>> propertySelector)
    {
        // TODO: implement And for nint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nuint>> propertySelector)
    {
        // TODO: implement And for nuint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> And(Expression<Func<T, nuint?>> propertySelector)
    {
        // TODO: implement And for nuint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> And(Expression<Func<T, long>> propertySelector)
    {
        // TODO: implement And for long
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> And(Expression<Func<T, long?>> propertySelector)
    {
        // TODO: implement And for long?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ulong>> propertySelector)
    {
        // TODO: implement And for ulong
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> And(Expression<Func<T, ulong?>> propertySelector)
    {
        // TODO: implement And for ulong?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> And(Expression<Func<T, BigInteger>> propertySelector)
    {
        // TODO: implement And for BigInteger
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> And(Expression<Func<T, BigInteger?>> propertySelector)
    {
        // TODO: implement And for BigInteger?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> And(Expression<Func<T, float>> propertySelector)
    {
        // TODO: implement And for float
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> And(Expression<Func<T, float?>> propertySelector)
    {
        // TODO: implement And for float?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> And(Expression<Func<T, double>> propertySelector)
    {
        // TODO: implement And for double
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> And(Expression<Func<T, double?>> propertySelector)
    {
        // TODO: implement And for double?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> And(Expression<Func<T, decimal>> propertySelector)
    {
        // TODO: implement And for decimal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> And(Expression<Func<T, decimal?>> propertySelector)
    {
        // TODO: implement And for decimal?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, char>> propertySelector)
    {
        // TODO: implement And for char
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, char?>> propertySelector)
    {
        // TODO: implement And for char?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, string?>> propertySelector)
    {
        // TODO: implement And for string
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, Guid>> propertySelector)
    {
        // TODO: implement And for Guid
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> And(Expression<Func<T, Guid?>> propertySelector)
    {
        // TODO: implement And for Guid?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateOnly>> propertySelector)
    {
        // TODO: implement And for DateOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateOnly?>> propertySelector)
    {
        // TODO: implement And for DateOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeOnly>> propertySelector)
    {
        // TODO: implement And for TimeOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeOnly?>> propertySelector)
    {
        // TODO: implement And for TimeOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTime>> propertySelector)
    {
        // TODO: implement And for DateTime
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTime?>> propertySelector)
    {
        // TODO: implement And for DateTime?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset>> propertySelector)
    {
        // TODO: implement And for DateTimeOffset
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> And(Expression<Func<T, DateTimeOffset?>> propertySelector)
    {
        // TODO: implement And for DateTimeOffset?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeSpan>> propertySelector)
    {
        // TODO: implement And for TimeSpan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> And(Expression<Func<T, TimeSpan?>> propertySelector)
    {
        // TODO: implement And for TimeSpan?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> And<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        // TODO: implement And for custom types
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> And<TElement>(Expression<Func<T, IEnumerable<TElement>>> propertySelector)
    {
        // TODO: implement And for enumerable types
        throw new NotImplementedException();
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
        // TODO: implement Or for sbyte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, sbyte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, sbyte?>> propertySelector)
    {
        // TODO: implement Or for sbyte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, byte>> propertySelector)
    {
        // TODO: implement Or for byte
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, byte, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, byte?>> propertySelector)
    {
        // TODO: implement Or for byte?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, short>> propertySelector)
    {
        // TODO: implement Or for short
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, short, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, short?>> propertySelector)
    {
        // TODO: implement Or for short?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ushort>> propertySelector)
    {
        // TODO: implement Or for ushort
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ushort, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ushort?>> propertySelector)
    {
        // TODO: implement Or for ushort?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, int>> propertySelector)
    {
        // TODO: implement Or for int
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, int, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, int?>> propertySelector)
    {
        // TODO: implement Or for int?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, uint>> propertySelector)
    {
        // TODO: implement Or for uint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, uint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, uint?>> propertySelector)
    {
        // TODO: implement Or for uint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nint>> propertySelector)
    {
        // TODO: implement Or for nint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nint?>> propertySelector)
    {
        // TODO: implement Or for nint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nuint>> propertySelector)
    {
        // TODO: implement Or for nuint
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, nuint, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, nuint?>> propertySelector)
    {
        // TODO: implement Or for nuint?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, long>> propertySelector)
    {
        // TODO: implement Or for long
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, long, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, long?>> propertySelector)
    {
        // TODO: implement Or for long?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ulong>> propertySelector)
    {
        // TODO: implement Or for ulong
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, ulong, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, ulong?>> propertySelector)
    {
        // TODO: implement Or for ulong?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, BigInteger>> propertySelector)
    {
        // TODO: implement Or for BigInteger
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, BigInteger, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, BigInteger?>> propertySelector)
    {
        // TODO: implement Or for BigInteger?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, float>> propertySelector)
    {
        // TODO: implement Or for float
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, float, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, float?>> propertySelector)
    {
        // TODO: implement Or for float?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, double>> propertySelector)
    {
        // TODO: implement Or for double
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, double, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, double?>> propertySelector)
    {
        // TODO: implement Or for double?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, decimal>> propertySelector)
    {
        // TODO: implement Or for decimal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyNumberNegatableFilterBuilder<T, decimal, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, decimal?>> propertySelector)
    {
        // TODO: implement Or for decimal?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, char>> propertySelector)
    {
        // TODO: implement Or for char
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCharNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, char?>> propertySelector)
    {
        // TODO: implement Or for char?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyStringNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, string?>> propertySelector)
    {
        // TODO: implement Or for string
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, Guid>> propertySelector)
    {
        // TODO: implement Or for Guid
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyGuidNegatableFilterBuilder<T, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, Guid?>> propertySelector)
    {
        // TODO: implement Or for Guid?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateOnly>> propertySelector)
    {
        // TODO: implement Or for DateOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateOnly?>> propertySelector)
    {
        // TODO: implement Or for DateOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeOnly>> propertySelector)
    {
        // TODO: implement Or for TimeOnly
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeOnly, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeOnly?>> propertySelector)
    {
        // TODO: implement Or for TimeOnly?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTime>> propertySelector)
    {
        // TODO: implement Or for DateTime
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTime, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTime?>> propertySelector)
    {
        // TODO: implement Or for DateTime?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset>> propertySelector)
    {
        // TODO: implement Or for DateTimeOffset
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, DateTimeOffset, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, DateTimeOffset?>> propertySelector)
    {
        // TODO: implement Or for DateTimeOffset?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeSpan>> propertySelector)
    {
        // TODO: implement Or for TimeSpan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyDateTimeNegatableFilterBuilder<T, TimeSpan, IGroupStartFilterBuilder<T>> Or(Expression<Func<T, TimeSpan?>> propertySelector)
    {
        // TODO: implement Or for TimeSpan?
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyCustomNegatableFilterBuilder<T, TProperty, IGroupStartFilterBuilder<T>> Or<TProperty>(Expression<Func<T, TProperty>> propertySelector)
    {
        // TODO: implement Or for custom types
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IPropertyEnumerableNegatableFilterBuilder<T, TElement, IGroupStartFilterBuilder<T>> Or<TElement>(Expression<Func<T, IEnumerable<TElement>>> propertySelector)
    {
        // TODO: implement Or for enumerable types
        throw new NotImplementedException();
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
