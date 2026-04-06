using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge;

/// <inheritdoc cref="IPropertyFilterBuilder{T, TProperty, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal sealed class PropertyFilterBuilder<T, TProperty, TGroupFilterBuilder> : INegatablePropertyFilterBuilder<T, TProperty, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <inheritdoc/>
    public IPropertyFilterBuilder<T, TProperty, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder StartsWith(TProperty value)
    {
        // TODO: implement StartsWith
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder EndsWith(TProperty value)
    {
        // TODO: implement EndsWith
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Contains(TProperty value)
    {
        // TODO: implement Contains
        throw new NotImplementedException();
    }
}
