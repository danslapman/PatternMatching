using Patterns.Containers;

namespace Patterns
{
	public class ExprMatcher<T1, T2, T3> : ExprMatcher<T1, Union<T2, T3>> {}
	public class ExprMatcher<T1, T2, T3, T4> : ExprMatcher<T1, Union<T2, T3, T4>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5> : ExprMatcher<T1, Union<T2, T3, T4, T5>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7, T8> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7, T8>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7, T8, T9> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7, T8, T9>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7, T8, T9, T10>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> {}
	public class ExprMatcher<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : ExprMatcher<T1, Union<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> {}
}