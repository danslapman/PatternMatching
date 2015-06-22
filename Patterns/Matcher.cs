using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Patterns
{
    public class Matcher<T> : IEnumerable<T>
    {
        private readonly List<BlockExpression> _caseExpressionsList = new List<BlockExpression>();

        private ParameterExpression _parameter;
        private ParameterExpression Parameter => _parameter ?? (_parameter = Expression.Parameter(typeof(T), "inputValue"));

        private LabelTarget _retPoint;

        private LabelTarget RetPoint => _retPoint ?? (_retPoint = Expression.Label());

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
            _caseExpressionsList.Add(caseExpr);
        }

        public void Add(Expression<Predicate<T>> condition, Expression<Action<T>> processor)
        {
            var caseExpr = Expression.Block(Expression.IfThen(
                        Expression.Invoke(condition, Parameter),
                        Expression.Return(RetPoint, Expression.Invoke(processor, Parameter))
                        ));
            _caseExpressionsList.Add(caseExpr);
        }

        private Action<T> CompileMatcher()
        {
            var finalExpressions = new Expression[]
            {
                Expression.Throw(Expression.Constant(new MatchException("Provided value was not matched with any case"))),
                Expression.Label(RetPoint)
            };

            var matcherExpression = Expression.Block(_caseExpressionsList.Concat(finalExpressions)
                );

            return Expression.Lambda<Action<T>>(matcherExpression, Parameter).Compile();
        }

        private Action<T> _matcher;

        private Action<T> MatcherFunc => _matcher ?? (_matcher = CompileMatcher());

        public void Match(T value)
        {
            MatcherFunc(value);
        }

        public static implicit operator Action<T>(Matcher<T> matcher)
        {
            return matcher.Match;
        }

        public Action<T> ToAction()
        {
            return Match;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new InvalidOperationException("This is a stub. There is nothing to enumerate in Matcher.");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Matcher <TIn, TOut> : IEnumerable<TOut>
    {
        private readonly List<BlockExpression> _caseExpressionsList = new List<BlockExpression>();

        private ParameterExpression _parameter;
        private ParameterExpression Parameter => _parameter ?? (_parameter = Expression.Parameter(typeof (TIn), "inputValue"));

        private LabelTarget _retPoint;

        private LabelTarget RetPoint => _retPoint ?? (_retPoint = Expression.Label(typeof (TOut)));

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
            _caseExpressionsList.Add(caseExpr);
        }

        public void Add(Expression<Predicate<TIn>> condition, Expression<Func<TIn, TOut>> processor)
        {
            var caseExpr = Expression.Block(Expression.IfThen(
                        Expression.Invoke(condition, Parameter),
                        Expression.Return(RetPoint, Expression.Invoke(processor, Parameter))
                        ));
            _caseExpressionsList.Add(caseExpr);
        }

        private Func<TIn, TOut> CompileMatcher()
        {
            var finalExpressions = new Expression[]
            {
                Expression.Throw(Expression.Constant(new MatchException("Provided value was not matched with any case"))),
                Expression.Label(RetPoint, Expression.Default(typeof(TOut)))
            };

            var matcherExpression = Expression.Block(_caseExpressionsList.Concat(finalExpressions));

            var lambda = Expression.Lambda<Func<TIn, TOut>>(matcherExpression, Parameter);
            var matcher = lambda.Compile();
            return matcher;
        }

        private Func<TIn, TOut> _matcher;

        private Func<TIn, TOut> MatcherFunc => _matcher ?? (_matcher = CompileMatcher());

        public TOut Match(TIn value)
        {
            return MatcherFunc(value);
        }

        public static implicit operator Func<TIn, TOut>(Matcher<TIn, TOut> matcher)
        {
            return matcher.Match;
        }

        public Func<TIn, TOut> ToFunc()
        {
            return Match;
        }

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
