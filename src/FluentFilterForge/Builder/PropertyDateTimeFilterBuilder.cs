using System.Diagnostics.CodeAnalysis;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyDateTimeNegatableFilterBuilder{TEntity, TProperty, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal class PropertyDateTimeFilterBuilder<TEntity, TProperty, TGroupFilterBuilder> : IPropertyDateTimeNegatableFilterBuilder<TEntity, TProperty, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <inheritdoc/>
    public IPropertyDateTimeFilterBuilder<TEntity, TProperty, TGroupFilterBuilder> Not()
    {
        // TODO: implement Not
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
    {
        // TODO: implement IsNull
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(TProperty value)
    {
        // TODO: implement Equal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder GreaterThan(TProperty value)
    {
        // TODO: implement GreaterThan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder GreaterThanOrEqual(TProperty value)
    {
        // TODO: implement GreaterThanOrEqual
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder LessThan(TProperty value)
    {
        // TODO: implement LessThan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder LessThanOrEqual(TProperty value)
    {
        // TODO: implement LessThanOrEqual
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Between(TProperty from, TProperty to)
    {
        // TODO: implement Between
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params TProperty[] values)
    {
        // TODO: implement In
        throw new NotImplementedException();
    }
}
