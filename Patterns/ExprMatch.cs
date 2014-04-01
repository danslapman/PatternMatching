using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq.Expressions;
using Patterns.Containers;

namespace Patterns
{
    public class ExprMatcher<TIn, TOut> : IEnumerable<Pair<Expression<Predicate<TIn>>, Expression<Func<TIn, TOut>>>>
    {
        private Func<TIn, TOut> _matcher;

        private Func<TIn, TOut> Matcher
        {
            get { return _matcher ?? (_matcher = CompileMatcher()); }
        } 
        private ImmutableList<Pair<Expression<Predicate<TIn>>, Expression<Func<TIn, TOut>>>> _caseList = ImmutableList.Create<Pair<Expression<Predicate<TIn>>, Expression<Func<TIn, TOut>>>>();

        public void Add(Expression<Predicate<TIn>> predicate, Expression<Func<TIn, TOut>> function)
        {
            _caseList = _caseList.Add(new Pair<Expression<Predicate<TIn>>, Expression<Func<TIn, TOut>>>(predicate, function));
        }

        private Func<TIn, TOut> CompileMatcher()
        {
            var reverted = _caseList.Reverse();

            var arg = Expression.Parameter(typeof(TIn));
            var retVal = Expression.Label(typeof(TOut));
            var matcher = Expression.Block(
                        Expression.Throw(Expression.Constant(new MatchException("Provided value was not matched with any case"))),
                        Expression.Label(retVal, Expression.Constant(default(TOut)))
                    );
            
            foreach (var pair in reverted)
            {
                retVal = Expression.Label(typeof(TOut));
                var condition = Expression.Invoke(pair.First, arg);
                var action = Expression.Return(retVal, Expression.Invoke(pair.Second, arg));

                matcher = Expression.Block(
                    Expression.IfThenElse(condition, action, Expression.Return(retVal, matcher)),
                    Expression.Label(retVal, Expression.Constant(default(TOut)))
                    );
            }

            return Expression.Lambda<Func<TIn, TOut>>(matcher, arg).Compile();
        }

        public TOut Match(TIn value)
        {
            return Matcher(value);
        }

        public static implicit operator Func<TIn, TOut>(ExprMatcher<TIn, TOut> matcher)
        {
            return matcher.Match;
        }

        public IEnumerator<Pair<Expression<Predicate<TIn>>, Expression<Func<TIn, TOut>>>> GetEnumerator()
        {
            return _caseList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
