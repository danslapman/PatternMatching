using System;
using Patterns;
using Patterns.Containers;

namespace MatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var match = new Matcher<Option<int>, int?>
            {
                 {i => i is None, (Option<int> _) => null},
                {i => i as Some<int>, i => i.Value}
            }.ToFunc();
            
            Console.WriteLine(match(new None<int>()));
            Console.WriteLine(match(10));
            Console.ReadKey();
        }
    }
}

