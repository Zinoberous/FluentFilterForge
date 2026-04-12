using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyCustomFilterBuilder{TEntity, TProperty, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyCustomNegatableFilterBuilder<TEntity, TProperty, out TGroupFilterBuilder> :
    IPropertyCustomFilterBuilder<TEntity, TProperty, TGroupFilterBuilder>,
    IPropertyNegatableFilterBuilder<TEntity, TProperty, TGroupFilterBuilder, IPropertyCustomFilterBuilder<TEntity, TProperty, TGroupFilterBuilder>>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>;
