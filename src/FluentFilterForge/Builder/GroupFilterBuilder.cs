using System.Linq.Expressions;
using System.Numerics;
using FluentFilterForge.Interfaces;
using FluentFilterForge.Interfaces.Builder;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IGroupStartFilterBuilder{TEntity}" />
internal sealed class GroupFilterBuilder<TEntity> : IGroupStartFilterBuilder<TEntity>
{
    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, bool>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, bool?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, sbyte>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, sbyte?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, byte>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, byte?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, short>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, short?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ushort>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ushort?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, int>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, int?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, uint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, uint?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nint?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nuint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, nuint?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, long>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, long?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ulong>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, ulong?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, BigInteger>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, BigInteger?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, float>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, float?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, double>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, double?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, decimal>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, decimal?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, char>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, char?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyStringNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, string?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, Guid>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, Guid?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateOnly>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateOnly?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeOnly>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeOnly?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTime>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTime?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTimeOffset>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, DateTimeOffset?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeSpan>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> And(Expression<Func<TEntity, TimeSpan?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, IGroupStartFilterBuilder<TEntity>> And<TProperty>(Expression<Func<TEntity, TProperty>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, IGroupStartFilterBuilder<TEntity>> And<TElement>(Expression<Func<TEntity, IEnumerable<TElement>>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IGroupAndFilterBuilder<TEntity> And(Action<IFilterBuilder<TEntity>> configure)
    {
        throw new NotImplementedException();
    }

    public IFilter<TEntity> Build()
    {
        throw new NotImplementedException();
    }

    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, bool>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, bool?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, sbyte>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, sbyte?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, byte>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, byte?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, short>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, short?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ushort>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ushort?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, int>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, int?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, uint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, uint?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nint?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nuint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, nuint?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, long>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, long?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ulong>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, ulong?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, BigInteger>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, BigInteger?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, float>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, float?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, double>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, double?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, decimal>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, decimal?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, char>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, char?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyStringNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, string?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, Guid>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, Guid?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateOnly>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateOnly?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeOnly>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeOnly?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTime>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTime?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTimeOffset>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, DateTimeOffset?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeSpan>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Or(Expression<Func<TEntity, TimeSpan?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, IGroupStartFilterBuilder<TEntity>> Or<TProperty>(Expression<Func<TEntity, TProperty>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, IGroupStartFilterBuilder<TEntity>> Or<TElement>(Expression<Func<TEntity, IEnumerable<TElement>>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IGroupOrFilterBuilder<TEntity> Or(Action<IFilterBuilder<TEntity>> configure)
    {
        throw new NotImplementedException();
    }
}
