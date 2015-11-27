namespace Patterns.Containers
{
	/// <summary>
/// Represents union of 2 types
/// </summary>
public abstract class Union<T1, T2>: Union
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2>(T1 value)
        {
            return new Case1(value);
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2>(T2 value)
        {
            return new Case2(value);
        }
		}
	/// <summary>
/// Represents union of 3 types
/// </summary>
public abstract class Union<T1, T2, T3>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
	/// <summary>
/// Represents union of 4 types
/// </summary>
public abstract class Union<T1, T2, T3, T4>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4>(T4 value)
        {
            return new Case4(value);
        }
		}
	/// <summary>
/// Represents union of 5 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5>(T5 value)
        {
            return new Case5(value);
        }
		}
	/// <summary>
/// Represents union of 6 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T6 value)
        {
            return new Case6(value);
        }
		}
	/// <summary>
/// Represents union of 7 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6, T7>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6, T7>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6, T7>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6, T7>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6, T7>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6, T7>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6, T7>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T6 value)
        {
            return new Case6(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case7 : Union<T1, T2, T3, T4, T5, T6, T7>, UnionCase<T7>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case7(T7 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T7> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T7 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T7 value)
        {
            return new Case7(value);
        }
		}
	/// <summary>
/// Represents union of 8 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6, T7, T8>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6, T7, T8>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6, T7, T8>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6, T7, T8>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6, T7, T8>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6, T7, T8>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value)
        {
            return new Case6(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case7 : Union<T1, T2, T3, T4, T5, T6, T7, T8>, UnionCase<T7>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case7(T7 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T7> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T7 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value)
        {
            return new Case7(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case8 : Union<T1, T2, T3, T4, T5, T6, T7, T8>, UnionCase<T8>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case8(T8 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T8> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T8 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value)
        {
            return new Case8(value);
        }
		}
	/// <summary>
/// Represents union of 9 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value)
        {
            return new Case6(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case7 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T7>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case7(T7 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T7> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T7 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value)
        {
            return new Case7(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case8 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T8>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case8(T8 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T8> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T8 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value)
        {
            return new Case8(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case9 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnionCase<T9>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
	/// <summary>
/// Represents union of 10 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value)
        {
            return new Case6(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case7 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T7>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case7(T7 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T7> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T7 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value)
        {
            return new Case7(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case8 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T8>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case8(T8 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T8> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T8 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value)
        {
            return new Case8(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case9 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T9>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value)
        {
            return new Case9(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case10 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnionCase<T10>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case10(T10 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T10> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T10 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value)
        {
            return new Case10(value);
        }
		}
	/// <summary>
/// Represents union of 11 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T6 value)
        {
            return new Case6(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case7 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T7>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case7(T7 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T7> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T7 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T7 value)
        {
            return new Case7(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case8 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T8>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case8(T8 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T8> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T8 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T8 value)
        {
            return new Case8(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case9 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T9>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T9 value)
        {
            return new Case9(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case10 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T10>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case10(T10 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T10> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T10 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T10 value)
        {
            return new Case10(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case11 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnionCase<T11>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case11(T11 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T11> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T11 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T11 value)
        {
            return new Case11(value);
        }
		}
	/// <summary>
/// Represents union of 12 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T6 value)
        {
            return new Case6(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case7 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T7>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case7(T7 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T7> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T7 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T7 value)
        {
            return new Case7(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case8 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T8>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case8(T8 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T8> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T8 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T8 value)
        {
            return new Case8(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case9 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T9>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T9 value)
        {
            return new Case9(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case10 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T10>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case10(T10 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T10> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T10 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T10 value)
        {
            return new Case10(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case11 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T11>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case11(T11 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T11> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T11 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T11 value)
        {
            return new Case11(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case12 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnionCase<T12>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case12(T12 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T12> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T12 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T12 value)
        {
            return new Case12(value);
        }
		}
	/// <summary>
/// Represents union of 13 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 value)
        {
            return new Case6(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case7 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T7>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case7(T7 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T7> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T7 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 value)
        {
            return new Case7(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case8 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T8>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case8(T8 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T8> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T8 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 value)
        {
            return new Case8(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case9 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T9>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 value)
        {
            return new Case9(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case10 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T10>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case10(T10 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T10> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T10 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 value)
        {
            return new Case10(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case11 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T11>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case11(T11 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T11> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T11 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 value)
        {
            return new Case11(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case12 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T12>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case12(T12 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T12> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T12 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 value)
        {
            return new Case12(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case13 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnionCase<T13>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case13(T13 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T13> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T13 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 value)
        {
            return new Case13(value);
        }
		}
	/// <summary>
/// Represents union of 14 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T6 value)
        {
            return new Case6(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case7 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T7>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case7(T7 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T7> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T7 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T7 value)
        {
            return new Case7(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case8 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T8>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case8(T8 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T8> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T8 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T8 value)
        {
            return new Case8(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case9 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T9>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T9 value)
        {
            return new Case9(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case10 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T10>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case10(T10 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T10> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T10 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T10 value)
        {
            return new Case10(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case11 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T11>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case11(T11 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T11> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T11 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T11 value)
        {
            return new Case11(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case12 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T12>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case12(T12 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T12> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T12 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T12 value)
        {
            return new Case12(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case13 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T13>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case13(T13 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T13> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T13 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T13 value)
        {
            return new Case13(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case14 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnionCase<T14>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case14(T14 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T14> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T14 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T14 value)
        {
            return new Case14(value);
        }
		}
	/// <summary>
/// Represents union of 15 types
/// </summary>
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>: Union
	{
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case1 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T1>
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
        /// Converts T1 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 value)
        {
            return new Case1(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case2 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T2>
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
        /// Converts T2 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 value)
        {
            return new Case2(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case3 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T3>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 value)
        {
            return new Case3(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case4 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T4>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case4(T4 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T4> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T4 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 value)
        {
            return new Case4(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T5>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 value)
        {
            return new Case5(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case6 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T6>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case6(T6 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T6> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T6 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 value)
        {
            return new Case6(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case7 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T7>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case7(T7 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T7> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T7 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 value)
        {
            return new Case7(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case8 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T8>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case8(T8 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T8> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T8 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 value)
        {
            return new Case8(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case9 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T9>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
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
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 value)
        {
            return new Case9(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case10 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T10>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case10(T10 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T10> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T10 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 value)
        {
            return new Case10(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case11 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T11>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case11(T11 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T11> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T11 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 value)
        {
            return new Case11(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case12 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T12>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case12(T12 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T12> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T12 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 value)
        {
            return new Case12(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case13 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T13>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case13(T13 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T13> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T13 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 value)
        {
            return new Case13(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case14 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T14>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case14(T14 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T14> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T14 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 value)
        {
            return new Case14(value);
        }
			/// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case15 : Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnionCase<T15>
        {
            internal override object Value { get; }
             
            /// <summary>
            /// Initializes case instance
            /// </summary>
            public Case15(T15 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T15> other)
            {
                if (other == null) return false;
                return Equals(other as Union);
            }
        }

		/// <summary>
        /// Converts T15 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 value)
        {
            return new Case15(value);
        }
		}
}