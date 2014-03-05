using System;
using Patterns;
using Patterns.Containers;

namespace MatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, Either<int, float>> eiMatch = new Matcher<string, int, float>
            {
                {s => { int t; return int.TryParse(s, out t);}, s => int.Parse(s)},
                {s => { float t; return float.TryParse(s, out t);}, s => float.Parse(s)},
                {s => true, s => 0}
            };

            int res = eiMatch("100");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
