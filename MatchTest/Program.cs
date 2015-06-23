using System;
using System.Text.RegularExpressions;
using Patterns;

namespace MatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var match = new Matcher<string, string>
            {
                { Case.Rx(new Regex("test\\s(\\d{3})")), a => a },
                { _ => true, (string _) => "nope" }
            }.ToFunc();

            Console.WriteLine(match("test 333"));
            Console.ReadKey();
        }
    }
}

