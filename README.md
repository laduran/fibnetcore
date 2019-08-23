# fibnetcore
FibonacciNetCore

There are 3 projects in the solution:

## FibonacciCore

This is a class library that implements two different ways of computing the Fibonacci sequence: Recursive (slow) and non-recursive.


## Fibonacci

This is a simple console app that uses FibonacciCore to display the i<sup>th</sup> item in the Fibonacci sequence.

I naively implemented the algorithm recursively. It is really slow. I used Stopwatch class to take high resolution timings.
The program uses both algorithms for computing to show performance comparisons.

## FibbTest

This is a unit test library to run tests.
It also shows a use of test attributes to fail tests that take too long.
