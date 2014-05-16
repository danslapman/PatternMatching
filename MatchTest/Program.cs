using System;
using Patterns;
using Patterns.Containers;

namespace MatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var match = new ExprMatcher<string>
            {
                {s => s.Length == 1, s => Console.WriteLine("1")},
                {s => s.Length == 2, s => Console.WriteLine("2")},
                {s => s.Length > 2, s => Console.WriteLine("Many")}
            }.ToAction();

            match("a"); // 1
            match("aa"); // 2
            match("aaa"); // Many


            var match2 = new ExprMatcher<string, int>
            {
                {s => string.IsNullOrEmpty(s), s => 0},
                {s => true, s => s.Length}
            }.ToFunc();

            var len1 = match2(null); // 0
            var len2 = match2("abc"); // 3

            var match3 = new Matcher<string, int, double>
            {
                {s => { int nih; return int.TryParse(s, out nih); }, s => int.Parse(s)},
                {s => { double nih; return double.TryParse(s, out nih); }, s => double.Parse(s)},
                {s => true, s => default(int)}
            }.ToFunc();

            var proc = new Matcher<Union<int, double>>
            {
                {u => u.Value1 != default(int), u => Console.WriteLine((int)u)},
                {u => u.Value2 != default(double), u => Console.WriteLine((double)u)},
                {u => true, u => Console.WriteLine("Empty union")}
            }.ToAction();

            proc(match3("1")); // 1
            proc(match3("1,0")); // 1
            proc(match3("fff")); // Empty union

            string s1 = "Hello";
            string s2 = null;

            var match4 = new ExprMatcher<Option<string>>
            {
                {s => s is None, s => Console.WriteLine("None")},
                {s => s is Some, s => Console.WriteLine((string) s)}
            }.ToAction();

            match4(s1); // Hello
            match4(s2); // None

            var match5 = new ExprMatcher<Union<int?, decimal?>>
            {
                {s => s.Value is int?, _ => Console.WriteLine("int")},
                {s => s.Value is decimal?, _ => Console.WriteLine("decimal")},
                {_ => true, _ => Console.WriteLine("empty")}
            }.ToAction();

            match5(42);
            match5(42m);
            match5((int?)null);

            Console.ReadKey();
        }
    }
}

