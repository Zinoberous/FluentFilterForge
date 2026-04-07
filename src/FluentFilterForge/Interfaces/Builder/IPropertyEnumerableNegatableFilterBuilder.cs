using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces.Builder;

/// <inheritdoc cref="IPropertyEnumerableFilterBuilder{TEntity, TElement, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyEnumerableNegatableFilterBuilder<TEntity, TElement, out TGroupFilterBuilder> :
    IPropertyEnumerableFilterBuilder<TEntity, TElement, TGroupFilterBuilder>,
    IPropertyNegatableFilterBuilder<TEntity, TElement, TGroupFilterBuilder, IPropertyEnumerableFilterBuilder<TEntity, TElement, TGroupFilterBuilder>>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>;
