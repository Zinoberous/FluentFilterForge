using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyCharNegatableFilterBuilder{TEntity, TGroupFilterBuilder}" />
internal class PropertyCharFilterBuilder<TEntity, TGroupFilterBuilder> : IPropertyCharNegatableFilterBuilder<TEntity, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <inheritdoc/>
    public IPropertyCharFilterBuilder<TEntity, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder Equal(char value)
    {
        // TODO: implement Equal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder In(params char[] values)
    {
        // TODO: implement In
        throw new NotImplementedException();
    }
}
