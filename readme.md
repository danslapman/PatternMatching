C# Pattern Matching 2.6.1
=======================

This is second a try to implement pattern matching in C# as-idiomatic-as-possible. The
idea was to avoid fluent matcher building and to provide a simple and clear
syntax.

New in 2.5:
-----------
- Case.Rx for matching with Regexes

Plans:
------
- Scala-like projections for Union

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
var match = new Matcher<Option<int>, int?>
{
    // Predicate matching requires explicit type annotation
    {i => i is None, (Option<int> _) => null},
    {i => i as Some<int>, i => i.Value},
}.ToFunc();

match(new None<int>()); // null
match(new Some<int>(10)); // 10
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Union<..> matching:
-------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var match = new Matcher<Union<string, StringBuilder>, string>
{
    {u => u.Value1, s => s},
    {u => u.Value2, sb => sb.ToString()}
}.ToFunc();

match("string"); // string
match(new StringBuilder("stringBuilder")); // stringBuider
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

or, if Your prefer explicit casts:
----------------------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var match = new Matcher<Union<string, StringBuilder>, string>
{
    {u => (string)u, s => s},
    {u => (StringBuilder)u, sb => sb.ToString()}
}.ToFunc();

match("string"); // string
match(new StringBuilder("stringBuilder")); // stringBuider
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Matching with Regexes:
----------------------

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var match = new Matcher<string, string>
{
    {Case.Rx(new Regex("\\d{2}")), s => s},
    {Case.Rx(new Regex("test\\s(\\d{3})")), s => s}
}.ToFunc();

match("12"); // 12
match("test 123"); // 123
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


Check out tests for more examples.
