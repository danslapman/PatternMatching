namespace Patterns.Containers
{
    public class Pair<T1, T2>
    {
        public T1 First { get; protected set; }
        public T2 Second { get; protected set; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public static implicit operator T1(Pair<T1, T2> pair)
        {
            return pair.First;
        }

        public static implicit operator T2(Pair<T1, T2> pair)
        {
            return pair.Second;
        }
    }
}
