using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge.Interfaces;

/// <summary>
/// TODO: add documentation
/// </summary>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyDateTimeFilterBuilder<TEntity, in TDateTime, out TGroupFilterBuilder> :
    IPropertyFilterBuilder<TEntity, TDateTime, TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder GreaterThan(TDateTime value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder GreaterThanOrEqual(TDateTime value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder LessThan(TDateTime value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder LessThanOrEqual(TDateTime value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    TGroupFilterBuilder Between(TDateTime from, TDateTime to);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    TGroupFilterBuilder In(params TDateTime[] values);
}
