C# Pattern Matching 2.0
=======================

This is second a try to implement pattern matching in C# as-idiomatic-as-possible. The
idea was to avoid fluent matcher building and to provide a simple and clear
syntax.

Breaking changes agains 1.* branch:
-----------------------------------
- Matcher<..> now is ExpressionTree-based, ExprMatcher is removed. However,
lambda-functions (Func<..>, not Expression<Func<..>>) are no longer supported.
- Union-based Matcher overloads removed.
- Pair<T1, T2> class removed, builtin Tuple<T1, T2> class can be used instead.


Usage
=====

Matching w/o returning a value:
-------------------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var match = new Matcher<string>
{
    {s => s.Length == 1, s => Console.WriteLine("1")},
    {s => s.Length == 2, s => Console.WriteLine("2")},
    {s => true, s => Console.WriteLine("Many")}
}.ToAction();

match("a") // 1
match("aa") // 2
match("aaa") // Many
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Matching w returning a single-type value:
-----------------------------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var match = new Matcher<string, int>
{
    {s => string.IsNullOrEmpty(s), (string _) => 0},
    {s => true, s => s.Length}
}.ToFunc();

int len1 = match(null); // 0
int len2 = match("abc"); // 3
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Matching with Some/None:
------------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
string s1 = "Hello";
string s2 = null;

var match = new Matcher<Option<int>, int?>
{
    // Predicate matching requires explicit type annotation
    {i => i is None, (Option<int> _) => null},
    {i => i as Some<int>, i => i.Value},
}.ToFunc();

match(s1); // Hello
match(s2); // None
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Check tests for more examples.
