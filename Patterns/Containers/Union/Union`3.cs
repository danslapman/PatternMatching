namespace Patterns.Containers.Union
{
    /// <summary>
    /// Represents union of three types
    /// </summary>
    /// <typeparam name="T1">First type</typeparam>
    /// <typeparam name="T2">Second type</typeparam>
    /// <typeparam name="T3">Third type</typeparam>
    public abstract class Union<T1, T2, T3> : Union<T1, T2>
    {
        /// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3>, UnionCase<T3>
        {
            internal override object Value { get; }

            /// <summary>
            /// Initializes an instance of case
            /// </summary>
            public Case3(T3 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T3> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

        /// <summary>
        /// Converts T3 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3>(T3 value)
        {
            return new Case3(value);
        }
    }
}
