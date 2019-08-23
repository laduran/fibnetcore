using System;
using System.Diagnostics;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Printing the 10th and 40th item in the Fibonacci series...");
            Console.WriteLine(FibonacciCore.FibonacciCalc.CalculateFibonacci(10));
            stopWatch.Start();
            Console.WriteLine(FibonacciCore.FibonacciCalc.CalculateFibonacci(40));
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;
            Console.WriteLine("RunTime " + String.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10));

            // This is here because I first implemented the calculation recursively.
            // It is waaaayyy slower.
            Console.WriteLine(FibonacciCore.FibonacciCalc.CalcFibonacciRecursive(10));
            stopWatch.Reset();
            stopWatch.Start();
            Console.WriteLine(FibonacciCore.FibonacciCalc.CalcFibonacciRecursive(40));
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("RunTime " + String.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10));
        }
    }
}
