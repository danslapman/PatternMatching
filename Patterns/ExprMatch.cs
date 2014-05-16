using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Patterns.Containers;

namespace Patterns
{
    public class ExprMatcher<T> : IEnumerable<Pair<Expression<Predicate<T>>, Expression<Action<T>>>>
    {
        private Action<T> _matcher;

        private Action<T> Matcher
        {
            get { return _matcher ?? (_matcher = CompileMatcher()); }
        }
        private readonly List<Pair<Expression<Predicate<T>>, Expression<Action<T>>>> _caseList = new List<Pair<Expression<Predicate<T>>, Expression<Action<T>>>>();

        public void Add(Expression<Predicate<T>> predicate, Expression<Action<T>> function)
        {
            _caseList.Add(new Pair<Expression<Predicate<T>>, Expression<Action<T>>>(predicate, function));
        }

        private Action<T> CompileMatcher()
        {
            var reverted = Enumerable.Reverse(_caseList).ToList();

            var arg = Expression.Parameter(typeof(T));
            var retVal = Expression.Label();
            var matcher = Expression.Block(
                        Expression.Throw(Expression.Constant(new MatchException("Provided value was not matched with any case"))),
                        Expression.Label(retVal)
                    );

            foreach (var pair in reverted)
            {
                retVal = Expression.Label();
                var condition = Expression.Invoke(pair.First, arg);
                var action = Expression.Return(retVal, Expression.Invoke(pair.Second, arg));

                matcher = Expression.Block(
                    Expression.IfThenElse(condition, action, Expression.Return(retVal, matcher)),
                    Expression.Label(retVal)
                    );
            }

            return Expression.Lambda<Action<T>>(matcher, arg).Compile();
        }

        public void Match(T value)
        {
            Matcher(value);
        }

        public static implicit operator Action<T>(ExprMatcher<T> matcher)
        {
            return matcher.Match;
        }

        public IEnumerator<Pair<Expression<Predicate<T>>, Expression<Action<T>>>> GetEnumerator()
        {
            return _caseList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Action<T> ToAction()
        {
            return Match;
        }
    }

    public class ExprMatcher<TIn, TOut> : IEnumerable<Pair<Expression<Predicate<TIn>>, Expression<Func<TIn, TOut>>>>
    {
        private Func<TIn, TOut> _matcher;

        private Func<TIn, TOut> Matcher
        {
            get { return _matcher ?? (_matcher = CompileMatcher()); }
        } 
        private readonly List<Pair<Expression<Predicate<TIn>>, Expression<Func<TIn, TOut>>>> _caseList = new List<Pair<Expression<Predicate<TIn>>, Expression<Func<TIn, TOut>>>>();

        public void Add(Expression<Predicate<TIn>> predicate, Expression<Func<TIn, TOut>> function)
        {
            _caseList.Add(new Pair<Expression<Predicate<TIn>>, Expression<Func<TIn, TOut>>>(predicate, function));
        }

        private Func<TIn, TOut> CompileMatcher()
        {
            var reverted = Enumerable.Reverse(_caseList).ToList();

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

        public Func<TIn, TOut> ToFunc()
        {
            return Match;
        }
    }
}
