C# Pattern Matching
===================

This is a try to implement pattern matching in C# as-idiomatic-as-possible. The
idea was to avoid fluent matcher building and to provide a simple and clear
syntax.

New in 1.1:
-----------

Now, Patterns library comes with ExpressionTree-based matcher for ultimate
perfomance! Simply Replace new Matcher\<...\>{...} with new
ExprMatcher\<...\>{...} to use new implementation. ExprMatcher constructs true
lambda-function from the cases instead of foreach-looping. Note, that due to
expression tree limitations not every lambda function can be converted to
expression (see [lambda expression with statement body][1])

[1]: <http://stackoverflow.com/questions/5179341/a-lambda-expression-with-a-statement-body-cannot-be-converted-to-an-expression>



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
    {u => u.Value1 != default(int), u => Console.WriteLine((int)u)}, // or u.Value1
    {u => u.Value2 != default(double), u => Console.WriteLine((double)u)}, // or u.Value2
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
