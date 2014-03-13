using System;
using Patterns;
using Patterns.Containers;

namespace MatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> match = new Matcher<string>
            {
                {s => s.Length == 1, s => Console.WriteLine("1")},
                {s => s.Length == 2, s => Console.WriteLine("2")},
                {s => s.Length > 2, s => Console.WriteLine("Many")}
            };

            match("a"); // 1
            match("aa"); // 2
            match("aaa"); // Many


            Func<string, int> match2 = new Matcher<string, int>
            {
                {string.IsNullOrEmpty, s => 0},
                {s => true, s => s.Length}
            };

            var len1 = match2(null); // 0
            var len2 = match2("abc"); // 3

            Func<string, Union<int, double>> match3 = new Matcher<string, int, double>
            {
                {s => { int nih; return int.TryParse(s, out nih); }, s => int.Parse(s)},
                {s => { double nih; return double.TryParse(s, out nih); }, s => double.Parse(s)},
                {s => true, s => default(int)}
            };

            Action<Union<int, double>> proc = new Matcher<Union<int, double>>
            {
                {u => u.Value1 != default(int), u => Console.WriteLine((int)u)},
                {u => u.Value2 != default(double), u => Console.WriteLine((double)u)},
                {u => true, u => Console.WriteLine("Empty union")}
            };

            proc(match3("1")); // 1
            proc(match3("1,0")); // 1
            proc(match3("fff")); // Empty union

            string s1 = "Hello";
            string s2 = null;

            Action<Option<string>> match4 = new Matcher<Option<string>>
            {
                {s => s is None, s => Console.WriteLine("None")},
                {s => s is Some, s => Console.WriteLine((string) s)}
            };

            match4(s1); // Hello
            match4(s2); // None

            Console.ReadKey();
        }
    }
}
