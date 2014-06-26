using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Patterns
{
    public class Matcher <TIn, TOut> : IEnumerable<TOut>
    {
        private readonly List<ConditionalExpression> _caseExpressionsList = new List<ConditionalExpression>();
        private IEnumerable<BlockExpression> MatchErrorExpression
        {
            get
            {
                yield return Expression.Block(
                    Expression.Throw(
                        Expression.Constant(new MatchException("Provided value was not matched with any case"))),
                    Expression.Label(RetPoint, Expression.Constant(default(TOut)))
                    );
            }
        } 

        private ParameterExpression _parameter;
        private ParameterExpression Parameter
        {
            get { return _parameter ?? (_parameter = Expression.Parameter(typeof (TIn))); }
        }

        private IEnumerable<ParameterExpression> _parameterExpressions
        {
            get { yield return Parameter; }
        }

        private LabelTarget _retPoint;

        private LabelTarget RetPoint
        {
            get { return _retPoint ?? (_retPoint = Expression.Label(typeof (TOut))); }
        }

        public void Add<TCtx>(Expression<Func<TIn, TCtx>> binder, Expression<Func<TCtx, TOut>> processor)
        {
            Expression<Func<TCtx, bool>> nullCheck = o => o != null;
            var binderRes = Expression.Invoke(binder, Parameter);
            var caseExpr = Expression.IfThen(
                Expression.Invoke(nullCheck, binderRes),
                Expression.Return(RetPoint, Expression.Invoke(processor, binderRes))
                );

            _caseExpressionsList.Add(caseExpr);
        }

        private Func<TIn, TOut> CompileMatcher()
        {
            var finalExpressions = new Expression[]
            {
                Expression.Throw(
                    Expression.Constant(new MatchException("Provided value was not matched with any case"))),
                Expression.Label(RetPoint, Expression.Constant(default(TOut)))
            };

            var matcherExpression = Expression.Block(
                    typeof(TOut), _caseExpressionsList.Concat(finalExpressions)
                );

            return Expression.Lambda<Func<TIn, TOut>>(matcherExpression, Parameter).Compile();
        }

        private Func<TIn, TOut> _matcher;

        private Func<TIn, TOut> MatcherFunc
        {
            get { return _matcher ?? (_matcher = CompileMatcher()); }
        }

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
            throw new NotImplementedException("This is a stub. There is nothing to enumerate in Matcher.");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
