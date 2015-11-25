namespace Patterns.Containers.Union
{
    /// <summary>
    /// Represents union of two types
    /// </summary>
    /// <typeparam name="T1">First type</typeparam>
    /// <typeparam name="T2">Second type</typeparam>
    public abstract class Union<T1, T2> : Union
    {
        /// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2>, UnionCase<T1>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case1(T1 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T1> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

        /// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2>, UnionCase<T2>
        {
            internal override object Value { get; }

            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case2(T2 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            
            public bool Equals(UnionCase<T2> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

        /// <summary>
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2>(T1 value)
        {
            return new Case1(value);
        }

        /// <summary>
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2>(T2 value)
        {
            return new Case2(value);
        }
    }
}
