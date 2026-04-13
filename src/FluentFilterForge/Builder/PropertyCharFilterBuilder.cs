using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyCharNegatableFilterBuilder{T, TGroupFilterBuilder}" />
internal sealed class PropertyCharFilterBuilder<T, TGroupFilterBuilder> : IPropertyCharNegatableFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    private bool _not;

    /// <inheritdoc/>
    public IPropertyCharFilterBuilder<T, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder Equal(char? value)
    {
        // TODO: implement Equal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params char?[] values)
    {
        // TODO: implement In
        throw new NotImplementedException();
    }
}
