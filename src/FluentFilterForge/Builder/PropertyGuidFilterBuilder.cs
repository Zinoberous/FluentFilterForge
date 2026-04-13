using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyGuidNegatableFilterBuilder{T, TGroupFilterBuilder}" />
internal sealed class PropertyGuidFilterBuilder<T, TGroupFilterBuilder> : IPropertyGuidNegatableFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    private bool _not;

    /// <inheritdoc/>
    public IPropertyGuidFilterBuilder<T, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder Equal(Guid? value)
    {
        // TODO: implement Equal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder StartsWith(string value)
    {
        // TODO: implement StartsWith
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder EndsWith(string value)
    {
        // TODO: implement EndsWith
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Contains(string value)
    {
        // TODO: implement Contains
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params Guid?[] values)
    {
        // TODO: implement In
        throw new NotImplementedException();
    }
}
