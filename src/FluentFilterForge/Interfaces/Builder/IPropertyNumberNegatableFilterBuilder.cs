using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace FluentFilterForge.Interfaces.Builder;

/// <inheritdoc cref="IPropertyNumberFilterBuilder{TEntity, TNumber, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyNumberNegatableFilterBuilder<TEntity, in TNumber, out TGroupFilterBuilder> :
    IPropertyNumberFilterBuilder<TEntity, TNumber, TGroupFilterBuilder>,
    IPropertyNegatableFilterBuilder<TEntity, TNumber, TGroupFilterBuilder, IPropertyNumberFilterBuilder<TEntity, TNumber, TGroupFilterBuilder>>
    where TNumber : INumber<TNumber>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>;
