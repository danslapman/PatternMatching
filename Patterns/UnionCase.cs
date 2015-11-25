using System;
using System.Linq.Expressions;
using Patterns.Containers.Union;

namespace Patterns
{
    /// <summary>
    /// Class containing helper methods for case construction
    /// </summary>
    public static class UnionCase
    {
        /// <summary>
        /// Creates case that matches union case by type
        /// </summary>
        public static Expression<Func<Union, T>> _<T>()
            where T : class
        {
            return u => u.Value as T;
        }
    }
}
