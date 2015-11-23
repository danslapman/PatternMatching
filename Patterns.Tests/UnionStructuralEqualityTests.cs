using Patterns.Containers.Union;
using Xunit;

namespace Patterns.Tests
{
    public class UnionStructuralEqualityTests
    {
        [Fact]
        public void UnionEqualsItself()
        {
            Union<Item, DataUnit> union = new Union<Item, DataUnit>.Case1(new Item(42));
            Assert.True(union.Equals(union));
        }

        [Fact]
        public void UnionEqualsSameUnion()
        {
            Union<Item, DataUnit> union1 = new Union<Item, DataUnit>.Case1(new Item(42));
            Union<Item, DataUnit> union2 = new Union<Item, DataUnit>.Case1(new Item(42));
            Assert.True(union1.Equals(union2));
            Assert.True(union2.Equals(union1));
        }

        [Fact]
        public void UnionIsNotEqualToStructurallyInequalUnion()
        {
            Union<Item, DataUnit> union1 = new Union<Item, DataUnit>.Case1(new Item(42));
            Union<Item, DataUnit> union2 = new Union<Item, DataUnit>.Case2(new DataUnit(42));
            Assert.False(union1.Equals(union2));
            Assert.False(union2.Equals(union1));
        }
    }
}
