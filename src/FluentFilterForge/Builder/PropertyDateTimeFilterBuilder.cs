using System.Diagnostics.CodeAnalysis;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyDateTimeNegatableFilterBuilder{T, TProperty, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal sealed class PropertyDateTimeFilterBuilder<T, TDateTime, TGroupFilterBuilder> : IPropertyDateTimeNegatableFilterBuilder<T, TDateTime, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    private bool _not;

    /// <inheritdoc/>
    public IPropertyDateTimeFilterBuilder<T, TDateTime, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder Equal(TDateTime? value)
    {
        // TODO: implement Equal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder GreaterThan(TDateTime value)
    {
        // TODO: implement GreaterThan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder GreaterThanOrEqual(TDateTime value)
    {
        // TODO: implement GreaterThanOrEqual
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder LessThan(TDateTime value)
    {
        // TODO: implement LessThan
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder LessThanOrEqual(TDateTime value)
    {
        // TODO: implement LessThanOrEqual
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Between(TDateTime from, TDateTime to)
    {
        // TODO: implement Between
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params TDateTime?[] values)
    {
        // TODO: implement In
        throw new NotImplementedException();
    }
}
