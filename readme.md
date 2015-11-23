C# Pattern Matching 3.0
=======================

This is second a try to implement pattern matching in C# as-idiomatic-as-possible. The
idea was to avoid fluent matcher building and to provide a simple and clear
syntax.

New in 3.0:
-----------
- Complete redesign of Union<..> type (more type-safe)
 
Breaking changes agains 2.* branch:
-----------------------------------
- Unions must be matched with UnionMatcher
- There is no more other way to extract value from Union<..> but pattern matching


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
var match = new UnionMatcher<Union<string, StringBuilder>, string>
{
    {Case.OfType<string>(), s => s},
    {Case.OfType<StringBuilder>(), sb => sb.ToString()}
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
