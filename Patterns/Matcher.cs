using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Patterns
{
    /// <summary>
    /// Pattern matcher with void return type
    /// </summary>
    /// <typeparam name="T">Matcher argument type</typeparam>
    public class Matcher<T> : IEnumerable<T>
    {
        /// <summary>
        /// List of case expressions
        /// </summary>
        protected readonly List<BlockExpression> CaseExpressionsList = new List<BlockExpression>();

        private ParameterExpression _parameter;

        /// <summary>
        /// Expression representing matching parameter
        /// </summary>
        protected ParameterExpression Parameter => _parameter ?? (_parameter = Expression.Parameter(typeof(T), "inputValue"));

        private LabelTarget _retPoint;

        /// <summary>
        /// Expression representing return point
        /// </summary>
        protected LabelTarget RetPoint => _retPoint ?? (_retPoint = Expression.Label());

        /// <summary>
        /// Adds context-based matching case
        /// </summary>
        /// <typeparam name="TCtx">Context type</typeparam>
        public void Add<TCtx>(Expression<Func<T, TCtx>> binder, Expression<Action<TCtx>> processor)
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

        /// <summary>
        /// Adds predicated-based matching case
        /// </summary>
        public void Add(Expression<Predicate<T>> condition, Expression<Action<T>> processor)
        {
            var caseExpr = Expression.Block(Expression.IfThen(
                        Expression.Invoke(condition, Parameter),
                        Expression.Return(RetPoint, Expression.Invoke(processor, Parameter))
                        ));
            CaseExpressionsList.Add(caseExpr);
        }

        private Action<T> CompileMatcher()
        {
            var finalExpressions = new Expression[]
            {
                Expression.Throw(Expression.Constant(new MatchException("Provided value was not matched with any case"))),
                Expression.Label(RetPoint)
            };

            var matcherExpression = Expression.Block(CaseExpressionsList.Concat(finalExpressions)
                );

            return Expression.Lambda<Action<T>>(matcherExpression, Parameter).Compile();
        }

        private Action<T> _matcher;

        private Action<T> MatcherFunc => _matcher ?? (_matcher = CompileMatcher());

        /// <summary>
        /// Performs match on the given value
        /// </summary>
        public void Match(T value)
        {
            MatcherFunc(value);
        }

        /// <summary>
        /// Converts matcher into Action&lt;T&gt; instance
        /// </summary>
        public static implicit operator Action<T>(Matcher<T> matcher)
        {
            return matcher.Match;
        }

        /// <summary>
        /// Creates Action&lt;T&gt; instance
        /// </summary>
        public Action<T> ToAction()
        {
            return Match;
        }

        /// <summary>
        /// Stub
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            throw new InvalidOperationException("This is a stub. There is nothing to enumerate in Matcher.");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    /// <summary>
    /// Pattern matcher
    /// </summary>
    /// <typeparam name="TIn">Argument type</typeparam>
    /// <typeparam name="TOut">Return type</typeparam>
    public class Matcher <TIn, TOut> : IEnumerable<TOut>
    {
        /// <summary>
        /// List of case expressions
        /// </summary>
        protected readonly List<BlockExpression> CaseExpressionsList = new List<BlockExpression>();

        private ParameterExpression _parameter;

        /// <summary>
        /// Expression representing matching parameter
        /// </summary>
        protected ParameterExpression Parameter => _parameter ?? (_parameter = Expression.Parameter(typeof (TIn), "inputValue"));

        private LabelTarget _retPoint;

        /// <summary>
        /// Expression representing return point
        /// </summary>
        protected LabelTarget RetPoint => _retPoint ?? (_retPoint = Expression.Label(typeof (TOut)));

        /// <summary>
        /// Adds context-based matching case
        /// </summary>
        /// <typeparam name="TCtx">Context type</typeparam>
        public void Add<TCtx>(Expression<Func<TIn, TCtx>> binder, Expression<Func<TCtx, TOut>> processor)
        {
            var bindResult = Expression.Variable(typeof (TCtx), "binded");
            var caseExpr = Expression.Block(
                new []{bindResult},
                Expression.Assign(bindResult, Expression.Invoke(binder, Parameter)),
                Expression.IfThen(
                    Expression.NotEqual(Expression.Convert(bindResult, typeof(object)), Expression.Constant(null)),
                    Expression.Return(RetPoint, Expression.Invoke(processor, bindResult))
                ));
            CaseExpressionsList.Add(caseExpr);
        }

        /// <summary>
        /// Adds predicated-based matching case
        /// </summary>
        public void Add(Expression<Predicate<TIn>> condition, Expression<Func<TIn, TOut>> processor)
        {
            var caseExpr = Expression.Block(Expression.IfThen(
                        Expression.Invoke(condition, Parameter),
                        Expression.Return(RetPoint, Expression.Invoke(processor, Parameter))
                        ));
            CaseExpressionsList.Add(caseExpr);
        }

        private Func<TIn, TOut> CompileMatcher()
        {
            var finalExpressions = new Expression[]
            {
                Expression.Throw(Expression.Constant(new MatchException("Provided value was not matched with any case"))),
                Expression.Label(RetPoint, Expression.Default(typeof(TOut)))
            };

            var matcherExpression = Expression.Block(CaseExpressionsList.Concat(finalExpressions));

            var lambda = Expression.Lambda<Func<TIn, TOut>>(matcherExpression, Parameter);
            var matcher = lambda.Compile();
            return matcher;
        }

        private Func<TIn, TOut> _matcher;

        private Func<TIn, TOut> MatcherFunc => _matcher ?? (_matcher = CompileMatcher());

        /// <summary>
        /// Performs match on the given value
        /// </summary>
        public TOut Match(TIn value)
        {
            return MatcherFunc(value);
        }

        /// <summary>
        /// Converts matcher into Func&lt;T&gt; instance
        /// </summary>
        public static implicit operator Func<TIn, TOut>(Matcher<TIn, TOut> matcher)
        {
            return matcher.Match;
        }

        /// <summary>
        /// Creates Func&lt;T&gt; instance
        /// </summary>
        public Func<TIn, TOut> ToFunc()
        {
            return Match;
        }

        /// <summary>
        /// Stub
        /// </summary>
        public IEnumerator<TOut> GetEnumerator()
        {
            throw new InvalidOperationException("This is a stub. There is nothing to enumerate in Matcher.");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
