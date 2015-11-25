namespace Patterns.Containers.Union
{
    /// <summary>
    /// Represents union of nine types
    /// </summary>
    /// <typeparam name="T1">First type</typeparam>
    /// <typeparam name="T2">Second type</typeparam>
    /// <typeparam name="T3">Third type</typeparam>
    /// <typeparam name="T4">Fourth type</typeparam>
    /// <typeparam name="T5">Fifth type</typeparam>
    /// <typeparam name="T6">Sixth type</typeparam>
    /// <typeparam name="T7">Seventh type</typeparam>
    /// <typeparam name="T8">Eighth type</typeparam>
    /// <typeparam name="T9">Nineth type</typeparam>
    public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> : Union<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        /// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case9 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T9>
        {
            internal override object Value { get; }

            /// <summary>
            /// Initializes an instance of case
            /// </summary>
            public Case9(T9 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T9> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

        /// <summary>
        /// Converts T9 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value)
        {
            return new Case9(value);
        }
    }
}
