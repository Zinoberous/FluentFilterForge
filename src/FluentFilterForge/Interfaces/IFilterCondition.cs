using System.Linq.Expressions;
using FluentFilterForge.Enums;

namespace FluentFilterForge.Interfaces;

internal interface IFilterCondition : IFilterNode
{
    LambdaExpression PropertySelector { get; }
    ComparisonOperator ComparisonOperator { get; }
    bool Not { get; }
}
