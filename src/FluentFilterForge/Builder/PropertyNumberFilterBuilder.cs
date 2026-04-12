using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyNumberNegatableFilterBuilder{TEntity, TNumber, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal class PropertyNumberFilterBuilder<TEntity, TNumber, TGroupFilterBuilder> : IPropertyNumberNegatableFilterBuilder<TEntity, TNumber, TGroupFilterBuilder>
    where TNumber : INumber<TNumber>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <inheritdoc/>
    public IPropertyNumberFilterBuilder<TEntity, TNumber, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder Equal(TNumber value)
    {
        // TODO: implement Equal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder GreaterThan(TNumber value)
    {
        // TODO: implement GreaterThan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder GreaterThanOrEqual(TNumber value)
    {
        // TODO: implement GreaterThanOrEqual
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder LessThan(TNumber value)
    {
        // TODO: implement LessThan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder LessThanOrEqual(TNumber value)
    {
        // TODO: implement LessThanOrEqual
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Between(TNumber from, TNumber to)
    {
        // TODO: implement Between
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params TNumber[] values)
    {
        // TODO: implement In
        throw new NotImplementedException();
    }
}
