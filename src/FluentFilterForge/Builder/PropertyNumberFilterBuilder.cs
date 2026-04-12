using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyNumberNegatableFilterBuilder{T, TNumber, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal class PropertyNumberFilterBuilder<T, TNumber, TGroupFilterBuilder> : IPropertyNumberNegatableFilterBuilder<T, TNumber, TGroupFilterBuilder>
    where TNumber : INumber<TNumber>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    private bool _not;

    /// <inheritdoc/>
    public IPropertyNumberFilterBuilder<T, TNumber, TGroupFilterBuilder> Not()
    {
        _not = !_not;
        return this;
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNull()
    {
        // TODO: implement IsNull
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(TNumber? value)
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
    public TGroupFilterBuilder In(params TNumber?[] values)
    {
        // TODO: implement In
        throw new NotImplementedException();
    }
}
