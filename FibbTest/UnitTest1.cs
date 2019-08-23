using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibbTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFibonacciNonRecusive1()
        {
            var val = FibonacciCore.FibonacciCalc.CalculateFibonacci(1);

            Assert.AreEqual(val, 1);
        }

        [TestMethod]
        public void TestFibonacciNonRecusive55()
        {
            var val = FibonacciCore.FibonacciCalc.CalculateFibonacci(10);

            Assert.AreEqual(val, 55);
        }

        [TestMethod]
        public void TestFibonacciNonRecusiveTooLow()
        {
            var val = FibonacciCore.FibonacciCalc.CalculateFibonacci(0);

            Assert.AreEqual(val, -1);
        }

        [TestMethod]
        public void TestFibonacciNonRecusiveLong()
        {
            var val = FibonacciCore.FibonacciCalc.CalculateFibonacci(63);

            Assert.AreEqual(val, 6557470319842);
        }

        [TestMethod]
        public void TestFibonacciNonRecusiveTooHigh()
        {
            var val = FibonacciCore.FibonacciCalc.CalculateFibonacci(64);

            Assert.AreEqual(val, -1);
        }

        [TestMethod]
        public void TestFibonacciRecursive1()
        {
            var val = FibonacciCore.FibonacciCalc.CalcFibonacciRecursive(1);

            Assert.AreEqual(val, 1);
        }

        [TestMethod]
        public void TestFibonacciRecursive55()
        {
            var val = FibonacciCore.FibonacciCalc.CalcFibonacciRecursive(10);

            Assert.AreEqual(val, 55);
        }

        [TestMethod]
        [Timeout(1 * 60 * 1000)] // 1 Minute
        public void TestFibonacciRecursiveLong()
        {
            var val = FibonacciCore.FibonacciCalc.CalcFibonacciRecursive(63);

            Assert.AreEqual(val, 2178309);
        }
    }
}
