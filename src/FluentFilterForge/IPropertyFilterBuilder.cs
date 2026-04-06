using System.Diagnostics.CodeAnalysis;

namespace FluentFilterForge;

/// <summary>
/// TODO: add documentation
/// </summary>
[SuppressMessage(Constants.SuppressMessageS2436Category, Constants.SuppressMessageS2436CheckId, Justification = Constants.SuppressMessageS2436Justification)]
public interface IPropertyFilterBuilder<T, in TProperty, out TGroupFilterBuilder>
    where TGroupFilterBuilder : IGroupFilterBuilder<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    TGroupFilterBuilder IsNull();

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder Equal(TProperty value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder GreaterThan(TProperty value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder GreaterThanOrEqual(TProperty value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder LessThan(TProperty value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder LessThanOrEqual(TProperty value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder StartsWith(TProperty value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder EndsWith(TProperty value);

    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    TGroupFilterBuilder Contains(TProperty value);
}
