C# Pattern Matching
===================

This is a try to implement pattern matching in C# as-idiomatic-as-possible. The idea was to avoid fluent matcher building and to provide a simple and clear syntax.

Usage
=====

Matching w/o returning a value:
-------------------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Action<string> match = new Matcher<string>
{
    {s => s.Length == 1, s => Console.WriteLine("1")},
    {s => s.Length == 2, s => Console.WriteLine("2")},
    {s => true, s => Console.WriteLine("Many")}
};

match("a") // 1
match("aa") // 2
match("aaa") // Many
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Matching w returning a single-type value:
-----------------------------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Func<string, int> match = new Matcher<string, int>
{
    {string.IsNullOrEmpty, s => 0},
    {s => true, s => s.Length}
};

int len1 = match(null); // 0
int len2 = match("abc"); // 3
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



You can find more examples in MatchTest/Program.cs