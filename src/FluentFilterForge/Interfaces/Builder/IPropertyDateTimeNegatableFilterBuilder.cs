using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces.Builder;

/// <inheritdoc cref="IPropertyDateTimeFilterBuilder{TEntity, TDateTime, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyDateTimeNegatableFilterBuilder<TEntity, in TDateTime, out TGroupFilterBuilder> :
    IPropertyDateTimeFilterBuilder<TEntity, TDateTime, TGroupFilterBuilder>,
    IPropertyNegatableFilterBuilder<TEntity, TDateTime, TGroupFilterBuilder, IPropertyDateTimeFilterBuilder<TEntity, TDateTime, TGroupFilterBuilder>>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>;
