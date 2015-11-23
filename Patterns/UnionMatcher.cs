using Patterns.Containers.Union;
using System;
using System.Linq.Expressions;

namespace Patterns
{
    /// <summary>
    /// Pattern matcher with specialized Union-matching capabilities
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public class UnionMatcher<TIn, TOut> : Matcher<TIn, TOut>
        where TIn : Union
    {
        /// <summary>
        /// Adds context-based matching case
        /// </summary>
        /// <typeparam name="TCtx">Context type</typeparam>
        public void Add<TCtx>(Expression<Func<Union, TCtx>> binder, Expression<Func<TCtx, TOut>> processor)
        {
            var bindResult = Expression.Variable(typeof(TCtx), "binded");
            var caseExpr = Expression.Block(
                new[] { bindResult },
                Expression.Assign(bindResult, Expression.Invoke(binder, Parameter)),
                Expression.IfThen(
                    Expression.NotEqual(Expression.Convert(bindResult, typeof(object)), Expression.Constant(null)),
                    Expression.Return(RetPoint, Expression.Invoke(processor, bindResult))
                ));
            CaseExpressionsList.Add(caseExpr);
        }
    }
}
