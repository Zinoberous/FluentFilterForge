using System.Linq.Expressions;
using System.Numerics;
using FluentFilterForge.Interfaces.Builder;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IFilterBuilder{TEntity}" />
internal sealed class FilterBuilder<TEntity> : IFilterBuilder<TEntity>
{
    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, bool>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyBoolNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, bool?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, sbyte>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, sbyte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, sbyte?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, byte>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, byte, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, byte?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, short>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, short, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, short?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ushort>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ushort, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ushort?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, int>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, int, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, int?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, uint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, uint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, uint?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nint?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nuint>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, nuint, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, nuint?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, long>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, long, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, long?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ulong>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, ulong, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, ulong?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, BigInteger>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, BigInteger, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, BigInteger?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, float>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, float, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, float?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, double>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, double, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, double?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, decimal>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyNumberNegatableFilterBuilder<TEntity, decimal, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, decimal?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, char>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyCharNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, char?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyStringNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, string?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, Guid>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyGuidNegatableFilterBuilder<TEntity, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, Guid?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateOnly>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateOnly?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeOnly>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeOnly, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeOnly?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTime>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTime, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTime?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTimeOffset>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, DateTimeOffset, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, DateTimeOffset?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeSpan>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyDateTimeNegatableFilterBuilder<TEntity, TimeSpan, IGroupStartFilterBuilder<TEntity>> Where(Expression<Func<TEntity, TimeSpan?>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, IGroupStartFilterBuilder<TEntity>> Where<TProperty>(Expression<Func<TEntity, TProperty>> propertySelector)
    {
        throw new NotImplementedException();
    }

    public IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, IGroupStartFilterBuilder<TEntity>> Where<TElement>(Expression<Func<TEntity, IEnumerable<TElement>>> propertySelector)
    {
        throw new NotImplementedException();
    }
}
