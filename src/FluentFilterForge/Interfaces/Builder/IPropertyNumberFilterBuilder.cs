using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace FluentFilterForge.Interfaces.Builder;

/// <summary>
/// TODO: add documentation
/// </summary>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyNumberFilterBuilder<TEntity, in TNumber, out TGroupFilterBuilder> :
    IPropertyFilterBuilder<TEntity, TNumber, TGroupFilterBuilder>
    where TNumber : INumber<TNumber>
    where TGroupFilterBuilder : IGroupFilterBuilder<TEntity>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder GreaterThan(TNumber value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder GreaterThanOrEqual(TNumber value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder LessThan(TNumber value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder LessThanOrEqual(TNumber value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    TGroupFilterBuilder Between(TNumber from, TNumber to);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    TGroupFilterBuilder In(params TNumber[] values);
}
