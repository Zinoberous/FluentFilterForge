using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces;

/// <inheritdoc cref="IPropertyDateTimeFilterBuilder{T, TDateTime, TGroupFilterBuilder}" />
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyDateTimeNegatableFilterBuilder<T, in TDateTime, out TGroupFilterBuilder> : IPropertyDateTimeFilterBuilder<T, TDateTime, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    IPropertyDateTimeFilterBuilder<T, TDateTime, TGroupFilterBuilder> Not();
}
