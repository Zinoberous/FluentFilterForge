using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyGuidNegatableFilterBuilder{TEntity, TGroupFilterBuilder}" />
internal class PropertyGuidFilterBuilder<TEntity, TGroupFilterBuilder> : IPropertyGuidNegatableFilterBuilder<TEntity, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <inheritdoc/>
    IPropertyGuidFilterBuilder<TEntity, TGroupFilterBuilder> IPropertyNegatableFilterBuilder<TEntity, Guid, TGroupFilterBuilder, IPropertyGuidFilterBuilder<TEntity, TGroupFilterBuilder>>.Not()
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
    public TGroupFilterBuilder Equal(Guid value)
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
    public TGroupFilterBuilder In(params string[] values)
    {
        // TODO: implement In
        throw new NotImplementedException();
    }
}
