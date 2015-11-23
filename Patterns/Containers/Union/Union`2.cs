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
                return Value.Equals((other as Union).Value);
            }

            /// <summary>Determines whether the specified object is equal to the current object.</summary>
            /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
            /// <param name="obj">The object to compare with the current object. </param>
            public override bool Equals(object obj)
            {
                return Equals(obj as UnionCase<T1>) ? true : Equals(this, obj);
            }

            /// <summary>Serves as the default hash function. </summary>
            /// <returns>A hash code for the current object.</returns>
            public override int GetHashCode()
            {
                return Value.GetHashCode();
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
                return Value.Equals((other as Union).Value);
            }

            /// <summary>Determines whether the specified object is equal to the current object.</summary>
            /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
            /// <param name="obj">The object to compare with the current object. </param>
            public override bool Equals(object obj)
            {
                return Equals(obj as UnionCase<T2>) ? true : Equals(this, obj);
            }

            /// <summary>Serves as the default hash function. </summary>
            /// <returns>A hash code for the current object.</returns>
            public override int GetHashCode()
            {
                return Value.GetHashCode();
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
