using Patterns.Containers; 
using Xunit;

namespace Patterns.Tests
{
    public class OptionStructuralEqualityTests
    {
        [Fact]
        public void NoneIsAlwaysEqualToNone()
        {
            var none1 = new None<int>();
            var none2 = new None<string>();
            Assert.True(none1.Equals(none2));
            Assert.True(none2.Equals(none1));
        }

        [Fact]
        public void SomeEqualsWorksOnValueTypes()
        {
            var some1 = new Some<int>(42);
            var some2 = new Some<int>(42);
            Assert.True(some1.Equals(some2));
            Assert.True(some2.Equals(some1));
        }

        [Fact]
        public void SomeEqualsWorkOnReferenceTypesWithCorrectEqualitySemantics()
        {
            var some1 = new Some<Item>(new Item(42));
            var some2 = new Some<Item>(new Item(42));
            Assert.True(some1.Equals(some2));
            Assert.True(some2.Equals(some1));
        }

        [Fact]
        public void NoneEqualsNoneOperatorTest()
        {
            var none1 = new None<int>();
            var none2 = new None<string>();
            Assert.True(none1 == none2);
            Assert.True(none2 == none1);
            Assert.False(none1 != none2);
            Assert.False(none2 != none1);
        }

        [Fact]
        public void NoneIsNotEqualToSome()
        {
            var none = new None<int>();
            var some = new Some<int>(42);
            Assert.False(none == some);
            Assert.False(some == none);
            Assert.True(none != some);
            Assert.True(some != none);
        }

        [Fact]
        public void SomeEqualitySemanticsTest()
        {
            var someInt1 = new Some<int>(42);
            var someInt2 = new Some<int>(42);
            var someInt3 = new Some<int>(100500);
            var someItem1 = new Some<Item>(new Item(42));
            var someItem2 = new Some<Item>(new Item(42));
            var someItem3 = new Some<Item>(new Item(100500));

            Assert.True(someInt1 == someInt2);
            Assert.False(someInt1 == someInt3);
            Assert.False(someInt2 == someInt3);
            Assert.True(someItem1 == someItem2);
            Assert.False(someItem1 == someItem3);
            Assert.False(someItem2 == someItem3);
            Assert.False(someInt1 == someItem1);
            Assert.True(someInt1 != someItem1);
        }
    }
}
