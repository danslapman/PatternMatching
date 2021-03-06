﻿using System.Text;
using System.Text.RegularExpressions;
using Patterns.Containers;
using Xunit;

namespace Patterns.Tests
{
    public class MatcherTests
    {
        [Fact]
        public void WildCardMatchTest()
        {
            var matcher = new Matcher<string, string>
            {
                {_ => true, s => s}
            }.ToFunc();

            Assert.Equal("test", matcher("test"));
        }

        [Fact]
        public void StringMatching()
        {
            var match = new Matcher<string, int>
            {
                {s => string.IsNullOrEmpty(s), (string _) => 0},
                {s => true, s => s.Length}
            }.ToFunc();

            Assert.Equal(0, match(null));
            Assert.Equal(4, match("test"));
        }

        [Fact]
        public void OptionTypeMatching()
        {
            var match = new Matcher<Option<int>, int?>
            {
                // Predicate matching requires explicit type annotation
                {i => i is None, (Option<int> _) => null},
                {i => i as Some<int>, i => i.Value},
            }.ToFunc();

            Assert.Null(match(new None<int>()));
            Assert.Equal(10, match(new Some<int>(10)));
        }

        [Fact]
        public void MultipleTypesMatching()
        {
            var match = new Matcher<object, string>
            {
                {s => s as string, s => s},
                {sb => sb as StringBuilder, sb => sb.ToString()},
                {o => true, (bool _) => "Unknown object"}
            }.ToFunc();

            Assert.Equal("string", match("string"));
            Assert.Equal(new StringBuilder("string builder").ToString(), match(new StringBuilder("string builder")));
            Assert.Equal("Unknown object", match(100500));
        }

        
        [Fact]
        public void UnionMatch()
        {
            var match = new UnionMatcher<Union<string, StringBuilder>, string>
            {
                {UnionCase._<string>(), s => s},
                {UnionCase._<StringBuilder>(), sb => sb.ToString()}
            }.ToFunc();

            Assert.Equal("string", match("string"));
            Assert.Equal(new StringBuilder("string builder").ToString(), match(new StringBuilder("string builder")));
        }
        
        [Fact]
        public void RegexCaseMatch()
        {
            var match = new Matcher<string, string>
            {
                { Case.Rx(new Regex("\\d{3}")), s => "Success" }
            }.ToFunc();

            Assert.Equal("Success", match("123"));
        }

        [Fact]
        public void RegexWithGroupMatchTest()
        {
            var match = new Matcher<string, string>
            {
                { Case.Rx(new Regex("this\\s(\\d{3})")), s => s }
            }.ToFunc();

            Assert.Equal("123", match("this 123"));
        }
    }
}
