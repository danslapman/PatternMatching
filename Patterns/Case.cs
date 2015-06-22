using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Patterns
{
    public static class Case
    {
        public static Expression<Func<string, string>> Rx(string regexPattern)
        {
            var parameterExpression = Expression.Parameter(typeof (string), "strArg");
            var regexExpression = Expression.Variable(typeof (Regex), "rx");
            var matchExpression = Expression.Variable(typeof (Match), "match");

            var retPoint = Expression.Label(typeof (string));

            var successProperty = Expression.Property(matchExpression, "Success");
            var resultProperty = Expression.Property(matchExpression, "Value");

            var block = Expression.Block(new[] { regexExpression, matchExpression},
                Expression.Assign(regexExpression, 
                Expression.New(typeof(Regex).GetConstructor(new[] { typeof(string) }), Expression.Constant(regexPattern, typeof(string)))),
                Expression.Assign(matchExpression,
                    Expression.Call(
                        regexExpression, 
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
    }
}
