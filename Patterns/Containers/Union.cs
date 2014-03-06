namespace Patterns.Containers
{
	public sealed class Union<T1, T2>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		
		public static implicit operator T1(Union<T1, T2> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2> value)
        {
            return value.Value2;
        }
		
		public static implicit operator Union<T1, T2>(T1 value)
        {
            return new Union<T1, T2>(value);
        }
		public static implicit operator Union<T1, T2>(T2 value)
        {
            return new Union<T1, T2>(value);
        }
		}

	public sealed class Union<T1, T2, T3>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3> value)
        {
            return value.Value3;
        }
		
		public static implicit operator Union<T1, T2, T3>(T1 value)
        {
            return new Union<T1, T2, T3>(value);
        }
		public static implicit operator Union<T1, T2, T3>(T2 value)
        {
            return new Union<T1, T2, T3>(value);
        }
		public static implicit operator Union<T1, T2, T3>(T3 value)
        {
            return new Union<T1, T2, T3>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4> value)
        {
            return value.Value4;
        }
		
		public static implicit operator Union<T1, T2, T3, T4>(T1 value)
        {
            return new Union<T1, T2, T3, T4>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4>(T2 value)
        {
            return new Union<T1, T2, T3, T4>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4>(T3 value)
        {
            return new Union<T1, T2, T3, T4>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4>(T4 value)
        {
            return new Union<T1, T2, T3, T4>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5> value)
        {
            return value.Value5;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6> value)
        {
            return value.Value6;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6, T7>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		public Union(T7 value)
        {
            Value7 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return value.Value7;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		public T8 Value8 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		public Union(T7 value)
        {
            Value7 = value;
        }
		public Union(T8 value)
        {
            Value8 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value7;
        }
		public static implicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8> value)
        {
            return value.Value8;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		public T8 Value8 { get; private set; }
		public T9 Value9 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		public Union(T7 value)
        {
            Value7 = value;
        }
		public Union(T8 value)
        {
            Value8 = value;
        }
		public Union(T9 value)
        {
            Value9 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> value)
        {
            return value.Value7;
        }
		public static implicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> value)
        {
            return value.Value8;
        }
		public static implicit operator T9(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> value)
        {
            return value.Value9;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		public T8 Value8 { get; private set; }
		public T9 Value9 { get; private set; }
		public T10 Value10 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		public Union(T7 value)
        {
            Value7 = value;
        }
		public Union(T8 value)
        {
            Value8 = value;
        }
		public Union(T9 value)
        {
            Value9 = value;
        }
		public Union(T10 value)
        {
            Value10 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value7;
        }
		public static implicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value8;
        }
		public static implicit operator T9(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value9;
        }
		public static implicit operator T10(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value)
        {
            return value.Value10;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		public T8 Value8 { get; private set; }
		public T9 Value9 { get; private set; }
		public T10 Value10 { get; private set; }
		public T11 Value11 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		public Union(T7 value)
        {
            Value7 = value;
        }
		public Union(T8 value)
        {
            Value8 = value;
        }
		public Union(T9 value)
        {
            Value9 = value;
        }
		public Union(T10 value)
        {
            Value10 = value;
        }
		public Union(T11 value)
        {
            Value11 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value7;
        }
		public static implicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value8;
        }
		public static implicit operator T9(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value9;
        }
		public static implicit operator T10(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value10;
        }
		public static implicit operator T11(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value)
        {
            return value.Value11;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T9 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T10 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T11 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		public T8 Value8 { get; private set; }
		public T9 Value9 { get; private set; }
		public T10 Value10 { get; private set; }
		public T11 Value11 { get; private set; }
		public T12 Value12 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		public Union(T7 value)
        {
            Value7 = value;
        }
		public Union(T8 value)
        {
            Value8 = value;
        }
		public Union(T9 value)
        {
            Value9 = value;
        }
		public Union(T10 value)
        {
            Value10 = value;
        }
		public Union(T11 value)
        {
            Value11 = value;
        }
		public Union(T12 value)
        {
            Value12 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value7;
        }
		public static implicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value8;
        }
		public static implicit operator T9(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value9;
        }
		public static implicit operator T10(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value10;
        }
		public static implicit operator T11(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value11;
        }
		public static implicit operator T12(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value)
        {
            return value.Value12;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T9 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T10 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T11 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T12 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		public T8 Value8 { get; private set; }
		public T9 Value9 { get; private set; }
		public T10 Value10 { get; private set; }
		public T11 Value11 { get; private set; }
		public T12 Value12 { get; private set; }
		public T13 Value13 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		public Union(T7 value)
        {
            Value7 = value;
        }
		public Union(T8 value)
        {
            Value8 = value;
        }
		public Union(T9 value)
        {
            Value9 = value;
        }
		public Union(T10 value)
        {
            Value10 = value;
        }
		public Union(T11 value)
        {
            Value11 = value;
        }
		public Union(T12 value)
        {
            Value12 = value;
        }
		public Union(T13 value)
        {
            Value13 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value7;
        }
		public static implicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value8;
        }
		public static implicit operator T9(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value9;
        }
		public static implicit operator T10(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value10;
        }
		public static implicit operator T11(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value11;
        }
		public static implicit operator T12(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value12;
        }
		public static implicit operator T13(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value)
        {
            return value.Value13;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		public T8 Value8 { get; private set; }
		public T9 Value9 { get; private set; }
		public T10 Value10 { get; private set; }
		public T11 Value11 { get; private set; }
		public T12 Value12 { get; private set; }
		public T13 Value13 { get; private set; }
		public T14 Value14 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		public Union(T7 value)
        {
            Value7 = value;
        }
		public Union(T8 value)
        {
            Value8 = value;
        }
		public Union(T9 value)
        {
            Value9 = value;
        }
		public Union(T10 value)
        {
            Value10 = value;
        }
		public Union(T11 value)
        {
            Value11 = value;
        }
		public Union(T12 value)
        {
            Value12 = value;
        }
		public Union(T13 value)
        {
            Value13 = value;
        }
		public Union(T14 value)
        {
            Value14 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value7;
        }
		public static implicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value8;
        }
		public static implicit operator T9(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value9;
        }
		public static implicit operator T10(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value10;
        }
		public static implicit operator T11(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value11;
        }
		public static implicit operator T12(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value12;
        }
		public static implicit operator T13(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value13;
        }
		public static implicit operator T14(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value)
        {
            return value.Value14;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T9 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T10 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T11 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T12 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T13 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T14 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }
		}

	public sealed class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	{
		public T1 Value1 { get; private set; }
		public T2 Value2 { get; private set; }
		public T3 Value3 { get; private set; }
		public T4 Value4 { get; private set; }
		public T5 Value5 { get; private set; }
		public T6 Value6 { get; private set; }
		public T7 Value7 { get; private set; }
		public T8 Value8 { get; private set; }
		public T9 Value9 { get; private set; }
		public T10 Value10 { get; private set; }
		public T11 Value11 { get; private set; }
		public T12 Value12 { get; private set; }
		public T13 Value13 { get; private set; }
		public T14 Value14 { get; private set; }
		public T15 Value15 { get; private set; }
		
		public Union(T1 value)
        {
            Value1 = value;
        }
		public Union(T2 value)
        {
            Value2 = value;
        }
		public Union(T3 value)
        {
            Value3 = value;
        }
		public Union(T4 value)
        {
            Value4 = value;
        }
		public Union(T5 value)
        {
            Value5 = value;
        }
		public Union(T6 value)
        {
            Value6 = value;
        }
		public Union(T7 value)
        {
            Value7 = value;
        }
		public Union(T8 value)
        {
            Value8 = value;
        }
		public Union(T9 value)
        {
            Value9 = value;
        }
		public Union(T10 value)
        {
            Value10 = value;
        }
		public Union(T11 value)
        {
            Value11 = value;
        }
		public Union(T12 value)
        {
            Value12 = value;
        }
		public Union(T13 value)
        {
            Value13 = value;
        }
		public Union(T14 value)
        {
            Value14 = value;
        }
		public Union(T15 value)
        {
            Value15 = value;
        }
		
		public static implicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value1;
        }
		public static implicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value2;
        }
		public static implicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value3;
        }
		public static implicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value4;
        }
		public static implicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value5;
        }
		public static implicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value6;
        }
		public static implicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value7;
        }
		public static implicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value8;
        }
		public static implicit operator T9(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value9;
        }
		public static implicit operator T10(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value10;
        }
		public static implicit operator T11(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value11;
        }
		public static implicit operator T12(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value12;
        }
		public static implicit operator T13(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value13;
        }
		public static implicit operator T14(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value14;
        }
		public static implicit operator T15(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value)
        {
            return value.Value15;
        }
		
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }
		}

}