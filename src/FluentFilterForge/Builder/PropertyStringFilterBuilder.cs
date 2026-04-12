using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyStringNegatableFilterBuilder{T, TGroupFilterBuilder}" />
internal class PropertyStringFilterBuilder<T, TGroupFilterBuilder> : IPropertyStringNegatableFilterBuilder<T, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    private bool _not;

    /// <inheritdoc/>
    public IPropertyStringFilterBuilder<T, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder IsNullOrEmpty()
    {
        // TODO: implement IsNullOrEmpty
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNullOrWhitespace()
    {
        // TODO: implement IsNullOrWhitespace
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Equal(string? value)
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
    public TGroupFilterBuilder In(params string?[] values)
    {
        // TODO: implement In
        throw new NotImplementedException();
    }
}
