using System;
using System.Collections;
using System.Collections.Generic;
using Patterns.Containers;

namespace Patterns
{
    public class Matcher<T> : IEnumerable<Pair<Predicate<T>, Action<T>>>
    {
        private readonly List<Pair<Predicate<T>, Action<T>>> _caseList;

        public Matcher()
        {
            _caseList = new List<Pair<Predicate<T>, Action<T>>>();
        } 

        public void Add(Predicate<T> predicate, Action<T> action)
        {
            _caseList.Add(new Pair<Predicate<T>, Action<T>>(predicate, action));
        }

        public void Match(T value)
        {
            foreach (var @case in _caseList)
            {
                if (@case.First(value))
                {
                    @case.Second(value);
                    return;
                }
            }
            throw new MatchException("Provided value was not matched with any case");
        }

        public static implicit operator Action<T>(Matcher<T> matcher)
        {
            return matcher.Match;
        }

        public IEnumerator<Pair<Predicate<T>, Action<T>>> GetEnumerator()
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

    public class Matcher<TIn, TOut> : IEnumerable<Pair<Predicate<TIn>, Func<TIn, TOut>>>
    {
        private readonly List<Pair<Predicate<TIn>, Func<TIn, TOut>>> _caseList;

        public Matcher()
        {
            _caseList = new List<Pair<Predicate<TIn>, Func<TIn, TOut>>>();
        }

        public void Add(Predicate<TIn> predicate, Func<TIn, TOut> function)
        {
            _caseList.Add(new Pair<Predicate<TIn>, Func<TIn, TOut>>(predicate, function));
        }

        public TOut Match(TIn value)
        {
            foreach (var @case in _caseList)
            {
                if (@case.First(value))
                    return @case.Second(value);
            }
            throw new MatchException("Provided value was not matched with any case");
        }

        public static implicit operator Func<TIn, TOut>(Matcher<TIn, TOut> matcher)
        {
            return matcher.Match;
        }

        public IEnumerator<Pair<Predicate<TIn>, Func<TIn, TOut>>> GetEnumerator()
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
