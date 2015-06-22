using Patterns.Containers;
using Xunit;

namespace Patterns.Tests
{
    public class UnionStructuralEqualityTests
    {
        [Fact]
        public void UnionEqualsItself()
        {
            var union = new Union<Item, DataUnit>(new Item(42));
            Assert.True(union.Equals(union));
        }

        [Fact]
        public void UnionEqualsSameUnion()
        {
            var union1 = new Union<Item, DataUnit>(new Item(42));
            var union2 = new Union<Item, DataUnit>(new Item(42));
            Assert.True(union1.Equals(union2));
            Assert.True(union2.Equals(union1));
        }

        [Fact]
        public void UnionIsNotEqualToStructurallyInequalUnion()
        {
            var union1 = new Union<Item, DataUnit>(new Item(42));
            var union2 = new Union<Item, DataUnit>(new DataUnit(42));
            Assert.False(union1.Equals(union2));
            Assert.False(union2.Equals(union1));
        }
    }
}
