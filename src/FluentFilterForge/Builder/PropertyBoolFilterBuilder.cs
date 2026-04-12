using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyBoolNegatableFilterBuilder{TEntity, TGroupFilterBuilder}" />
internal class PropertyBoolFilterBuilder<TEntity, TGroupFilterBuilder> : IPropertyBoolNegatableFilterBuilder<TEntity, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <inheritdoc/>
    public IPropertyBoolFilterBuilder<TEntity, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder Equal(bool value)
    {
        // TODO: implement Equal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsTrue()
    {
        // TODO: implement IsTrue
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsFalse()
    {
        // TODO: implement IsFalse
        throw new NotImplementedException();
    }
}
