using Patterns.Containers;

namespace Patterns
{
    /// <summary>
    /// Utility extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Converts current value to Option&lt;T&gt;
        /// </summary>
        public static Option<T> ToOption<T>(this T instance)
        {
            return instance;
        }

        /// <summary>
        /// Converts current value to Result&lt;TSucc, TErr&gt;
        /// </summary>
        /// <typeparam name="TSucc">Success type</typeparam>
        /// <typeparam name="TErr">Failure type</typeparam>
        public static Result<TSucc, TErr> ToResult<TSucc, TErr>(this TSucc instance)
        {
            return instance;
        }

        /// <summary>
        /// Converts current value to Result&lt;TSucc, TErr&gt;
        /// </summary>
        /// <typeparam name="TSucc">Success type</typeparam>
        /// <typeparam name="TErr">Failure type</typeparam>
        public static Result<TSucc, TErr> ToResult<TSucc, TErr>(this TErr instance)
        {
            return instance;
        }
    }
}
