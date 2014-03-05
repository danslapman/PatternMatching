namespace Patterns.Containers
{
	public sealed class Either<T1, T2>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		
		public Either(T1 value)
        {
            Value1 = value;
        }
		public Either(T2 value)
        {
            Value2 = value;
        }
		
		public static implicit operator T1(Either<T1, T2> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Either<T1, T2> value)
        {
            return value.Value2;
        }
		
		public static implicit operator Either<T1, T2>(T1 value)
        {
            return new Either<T1, T2>(value);
        }
		public static implicit operator Either<T1, T2>(T2 value)
        {
            return new Either<T1, T2>(value);
        }
		}

	public sealed class Either<T1, T2, T3>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		
		public Either(T1 value)
        {
            Value1 = value;
        }
		public Either(T2 value)
        {
            Value2 = value;
        }
		public Either(T3 value)
        {
            Value3 = value;
        }
		
		public static implicit operator T1(Either<T1, T2, T3> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Either<T1, T2, T3> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Either<T1, T2, T3> value)
        {
            return value.Value3;
        }
		
		public static implicit operator Either<T1, T2, T3>(T1 value)
        {
            return new Either<T1, T2, T3>(value);
        }
		public static implicit operator Either<T1, T2, T3>(T2 value)
        {
            return new Either<T1, T2, T3>(value);
        }
		public static implicit operator Either<T1, T2, T3>(T3 value)
        {
            return new Either<T1, T2, T3>(value);
        }
		}

	public sealed class Either<T1, T2, T3, T4>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		
		public Either(T1 value)
        {
            Value1 = value;
        }
		public Either(T2 value)
        {
            Value2 = value;
        }
		public Either(T3 value)
        {
            Value3 = value;
        }
		public Either(T4 value)
        {
            Value4 = value;
        }
		
		public static implicit operator T1(Either<T1, T2, T3, T4> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Either<T1, T2, T3, T4> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Either<T1, T2, T3, T4> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Either<T1, T2, T3, T4> value)
        {
            return value.Value4;
        }
		
		public static implicit operator Either<T1, T2, T3, T4>(T1 value)
        {
            return new Either<T1, T2, T3, T4>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4>(T2 value)
        {
            return new Either<T1, T2, T3, T4>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4>(T3 value)
        {
            return new Either<T1, T2, T3, T4>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4>(T4 value)
        {
            return new Either<T1, T2, T3, T4>(value);
        }
		}

	public sealed class Either<T1, T2, T3, T4, T5>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		
		public Either(T1 value)
        {
            Value1 = value;
        }
		public Either(T2 value)
        {
            Value2 = value;
        }
		public Either(T3 value)
        {
            Value3 = value;
        }
		public Either(T4 value)
        {
            Value4 = value;
        }
		public Either(T5 value)
        {
            Value5 = value;
        }
		
		public static implicit operator T1(Either<T1, T2, T3, T4, T5> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Either<T1, T2, T3, T4, T5> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Either<T1, T2, T3, T4, T5> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Either<T1, T2, T3, T4, T5> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Either<T1, T2, T3, T4, T5> value)
        {
            return value.Value5;
        }
		
		public static implicit operator Either<T1, T2, T3, T4, T5>(T1 value)
        {
            return new Either<T1, T2, T3, T4, T5>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5>(T2 value)
        {
            return new Either<T1, T2, T3, T4, T5>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5>(T3 value)
        {
            return new Either<T1, T2, T3, T4, T5>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5>(T4 value)
        {
            return new Either<T1, T2, T3, T4, T5>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5>(T5 value)
        {
            return new Either<T1, T2, T3, T4, T5>(value);
        }
		}

	public sealed class Either<T1, T2, T3, T4, T5, T6>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		
		public Either(T1 value)
        {
            Value1 = value;
        }
		public Either(T2 value)
        {
            Value2 = value;
        }
		public Either(T3 value)
        {
            Value3 = value;
        }
		public Either(T4 value)
        {
            Value4 = value;
        }
		public Either(T5 value)
        {
            Value5 = value;
        }
		public Either(T6 value)
        {
            Value6 = value;
        }
		
		public static implicit operator T1(Either<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Either<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Either<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Either<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Either<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Either<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value6;
        }
		
		public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T1 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T2 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T3 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T4 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T5 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T6 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6>(value);
        }
		}

	public sealed class Either<T1, T2, T3, T4, T5, T6, T7>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		
		public Either(T1 value)
        {
            Value1 = value;
        }
		public Either(T2 value)
        {
            Value2 = value;
        }
		public Either(T3 value)
        {
            Value3 = value;
        }
		public Either(T4 value)
        {
            Value4 = value;
        }
		public Either(T5 value)
        {
            Value5 = value;
        }
		public Either(T6 value)
        {
            Value6 = value;
        }
		public Either(T7 value)
        {
            Value7 = value;
        }
		
		public static implicit operator T1(Either<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Either<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Either<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Either<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Either<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Either<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Either<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value7;
        }
		
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T1 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T2 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T3 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T4 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T5 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T6 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T7 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		}

	public sealed class Either<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		public T8 Value8 { get; private set; }
		
		public Either(T1 value)
        {
            Value1 = value;
        }
		public Either(T2 value)
        {
            Value2 = value;
        }
		public Either(T3 value)
        {
            Value3 = value;
        }
		public Either(T4 value)
        {
            Value4 = value;
        }
		public Either(T5 value)
        {
            Value5 = value;
        }
		public Either(T6 value)
        {
            Value6 = value;
        }
		public Either(T7 value)
        {
            Value7 = value;
        }
		public Either(T8 value)
        {
            Value8 = value;
        }
		
		public static implicit operator T1(Either<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Either<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Either<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Either<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Either<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Either<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Either<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value7;
        }
		public static implicit operator T8(Either<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value8;
        }
		
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value)
        {
            return new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		}

}