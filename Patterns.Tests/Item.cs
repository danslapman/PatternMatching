namespace Patterns.Tests
{
    public class Item
    {
        private readonly int _amount;

        public int Amount { get { return _amount; } }

        public Item(int amount)
        {
            _amount = amount;
        }

        protected bool Equals(Item other)
        {
            return _amount == other._amount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Item) obj);
        }

        public override int GetHashCode()
        {
            return _amount;
        }
    }
}
