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
    }
}
