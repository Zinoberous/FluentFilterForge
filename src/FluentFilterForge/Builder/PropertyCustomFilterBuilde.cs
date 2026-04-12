using System.Diagnostics.CodeAnalysis;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyCustomNegatableFilterBuilder{TEntity, TProperty, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal class PropertyCustomFilterBuilder<TEntity, TProperty, TGroupFilterBuilder> : IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <inheritdoc/>
    public IPropertyCustomFilterBuilder<TEntity, TProperty, TGroupFilterBuilder> Not()
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
}
