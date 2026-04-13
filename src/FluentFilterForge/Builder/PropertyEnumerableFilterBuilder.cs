using System.Diagnostics.CodeAnalysis;
using FluentFilterForge.Interfaces;

namespace FluentFilterForge.Builder;

/// <inheritdoc cref="IPropertyEnumerableNegatableFilterBuilder{T, TEnumerable, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
internal sealed class PropertyEnumerableFilterBuilder<T, TEnumerable, TGroupFilterBuilder> : IPropertyEnumerableNegatableFilterBuilder<T, TEnumerable, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    private bool _not;

    /// <inheritdoc/>
    public IPropertyEnumerableFilterBuilder<T, TEnumerable, TGroupFilterBuilder> Not()
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
    public TGroupFilterBuilder Equal(TEnumerable? value)
    {
        // TODO: implement Equal
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder Any(Action<IFilterBuilder<TEnumerable>> configure)
    {
        // TODO: implement Any
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TGroupFilterBuilder All(Action<IFilterBuilder<TEnumerable>> configure)
    {
        // TODO: implement All
        throw new NotImplementedException();
    }
}
