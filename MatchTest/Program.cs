using System;
using System.Text;
using Patterns;

namespace MatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var matcher = new Matcher<object, string>
            {
                {s => s as string, s => s},
                {s => s as StringBuilder, s => s.ToString()},
                {_ => true, _ => string.Empty}
            };

            var m = matcher.ToFunc();
            
            Console.WriteLine(m(123));
            Console.WriteLine(m("yoba"));
            Console.ReadKey();
        }
    }
}

