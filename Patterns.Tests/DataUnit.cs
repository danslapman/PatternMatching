namespace Patterns.Tests
{
    public class DataUnit
    {
        public int Amount { get; }

        public DataUnit(int amount)
        {
            Amount = amount;
        }

        protected bool Equals(DataUnit other)
        {
            return Amount == other.Amount;
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
            return Amount;
        }
    }
}
