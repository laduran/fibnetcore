using System;

namespace FibonacciCore
{
    public class FibonacciCalc
    {
        /// <summary>
        /// Calculate the nth position of the Fibonacci sequence given the position as an input.
        /// This method doesn't use recursion and is much faster than the recursive version
        /// </summary>
        /// <param name="position">Represents the index in the Fibonacci sequence. 
        /// Integer values between 1 and 63 are valid. All other values will return -1</param>
        /// <returns>The Fibonacci number in the input position. -1 if there is an error.</returns>
        public static long CalculateFibonacci(int position)
        {
            // can't calc for less than 1 or for very large values
            if (position < 1 || position > 63)
            {
                return -1;
            }
            long f = 1;
            long fPrev = 1;
            for (int i = 2; i < position; ++i)
            {
                long temp = f;
                f += fPrev;
                fPrev = temp;
            }
            return f;
        }

        /// <summary>
        /// Calculate the nth position of the Fibonacci sequence given the position as an input.
        /// Works for small values of input but breaks down due to recursio depth at larger numbers.
        /// Also the time to compute using recursion is far longer than the non-recursive method.
        /// </summary>
        /// <param name="position">Represents the index in the Fibonacci sequence. 
        /// Integer values between 1 and 63 are valid. All other values will return -1</param>
        /// <returns>The Fibonacci number in the input position. -1 if there is an error.</returns>
        public static long CalcFibonacciRecursive(int position)
        {
            if (position < 0 || position > 63)
                return -1;
            try
            {
                if (position <= 1)
                {
                    return position;
                }
                else
                {
                    return CalcFibonacciRecursive(position - 1) + CalcFibonacciRecursive(position - 2);
                }
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Recursion depth too high... Use a smaller input value.");
                return -1;
            }
        }
    }
}
