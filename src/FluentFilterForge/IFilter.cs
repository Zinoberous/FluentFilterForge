using System.Linq.Expressions;

namespace FluentFilterForge;

/// <summary>
/// TODO: add documentation
/// </summary>
public interface IFilter<T>
{
    /// <summary>
    /// TODO: add documentation
    /// </summary>
    /// <returns></returns>
    Expression<Func<T, bool>> ToExpression();
}
