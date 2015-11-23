using Patterns.Containers.Union;
using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Patterns
{
    /// <summary>
    /// Class containing helper methods for case construction
    /// </summary>
    public static class Case
    {
        /// <summary>
        /// Creates regular expression case
        /// </summary>
        /// <param name="regexPattern">Regular expression instance</param>
        /// <returns>Case expression</returns>
        public static Expression<Func<string, string>> Rx(Regex regexPattern)
        {
            var parameterExpression = Expression.Parameter(typeof (string), "strArg");
            var matchExpression = Expression.Variable(typeof (Match), "match");

            var retPoint = Expression.Label(typeof (string));
            var successProperty = Expression.Property(matchExpression, "Success");
            var resultProperty = Expression.Property(
                regexPattern.GetGroupNames().Length > 1 ?
                (Expression)Expression.Property(Expression.Property(matchExpression, "Groups"), "Item", Expression.Constant(1)) : 
                matchExpression, "Value");
            
            var block = Expression.Block(new[] { matchExpression},
                Expression.Assign(matchExpression,
                    Expression.Call(
                        Expression.Constant(regexPattern, typeof(Regex)), 
                        typeof (Regex).GetMethod("Match", new[] {typeof (string)}),
                        parameterExpression)),
                Expression.IfThenElse(
                    successProperty,
                    Expression.Return(retPoint, resultProperty),
                    Expression.Return(retPoint, Expression.Convert(Expression.Constant(null), typeof(string)))),
                Expression.Label(retPoint, Expression.Default(typeof(string)))
                );
            return Expression.Lambda<Func<string, string>>(block, parameterExpression);
        }

        /// <summary>
        /// Creates case that matches union case by type
        /// </summary>
        public static Expression<Func<Union, T>> OfType<T>()
            where T : class
        {
            return u => u.Value as T;
        }
    }
}
