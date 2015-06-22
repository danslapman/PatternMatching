using System;
using Patterns;

namespace MatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var match = new Matcher<string, string>
            {
                { Case.Rx("\\d{3}"), a => a },
                { _ => true, (string _) => "nope" }
            }.ToFunc();

            Console.WriteLine(match("333"));
            Console.ReadKey();
        }
    }
}

