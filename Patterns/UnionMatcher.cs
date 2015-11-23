using Patterns.Containers.Union;
using System;
using System.Linq.Expressions;

namespace Patterns
{
    /// <summary>
    /// Pattern matcher with specialized Union-matching capabilities with void return type
    /// </summary>
    /// <typeparam name="T">Matcher argument type</typeparam>
    public class UnionMatcher<T> : Matcher<T>
        where T : Union
    {
        /// <summary>
        /// Adds union case
        /// </summary>
        /// <typeparam name="TCtx">Context type</typeparam>
        public void Add<TCtx>(Expression<Func<Union, TCtx>> binder, Expression<Action<TCtx>> processor)
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

    /// <summary>
    /// Pattern matcher with specialized Union-matching capabilities
    /// </summary>
    /// <typeparam name="TIn">Argument type</typeparam>
    /// <typeparam name="TOut">Return type</typeparam>
    public class UnionMatcher<TIn, TOut> : Matcher<TIn, TOut>
        where TIn : Union
    {
        /// <summary>
        /// Adds union case
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
