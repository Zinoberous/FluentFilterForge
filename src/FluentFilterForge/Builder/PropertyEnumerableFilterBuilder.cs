using System.Diagnostics.CodeAnalysis;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyEnumerableNegatableFilterBuilder{TEntity, TElement, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal class PropertyEnumerableFilterBuilder<TEntity, TElement, TGroupFilterBuilder> : IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <inheritdoc/>
    public IPropertyEnumerableFilterBuilder<TEntity, TElement, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder Equal(TElement value)
    {
        // TODO: implement Equal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder IsNullOrEmpty()
    {
        // TODO: implement IsNullOrEmpty
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Any(Action<IFilterBuilder<TElement>> configure)
    {
        // TODO: implement Any
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder All(Action<IFilterBuilder<TElement>> configure)
    {
        // TODO: implement All
        throw new NotImplementedException();
    }
}
