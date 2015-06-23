using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Patterns
{
    public static class Case
    {
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
    }
}
