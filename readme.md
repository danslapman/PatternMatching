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

Union type matching:
--------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Func<string, Union<int, double>> match = new Matcher<string, int, double>
{
    {s => { int nih; return int.TryParse(s, out nih); }, s => int.Parse(s)},
    {s => { double nih; return double.TryParse(s, out nih); }, s => double.Parse(s)},
    {s => true, s => default(int)}
};

Action<Union<int, double>> proc = new Matcher<Union<int, double>>
{
    {u => u.Value1 != default(int), u => Console.WriteLine(u.Value1)},
    {u => u.Value2 != default(double), u => Console.WriteLine(u.Value2)},
    {u => true, u => Console.WriteLine("Empty union")}
};

proc(match("1")); // 1
proc(match("1,0")); // 1
proc(match("fff")); // Empty union
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Matching with Some/None:
------------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
string s1 = "Hello";
string s2 = null;

Func<Option<string>> match = new Matcher<Option<string>>
{
	{s => s is None, s => Console.WriteLine("None")},
	{s => s is Some, s => Console.WriteLine((string)s) // or s.Value
};

match(s1); // Hello
match(s2); // None
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

You can find more examples in MatchTest/Program.cs