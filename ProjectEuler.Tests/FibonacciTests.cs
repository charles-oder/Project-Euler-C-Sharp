﻿using System.Linq;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FibonacciSequenceIsCorrectFOrFirst10()
        {
            // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
            var expectedArray = new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            var fib = new Fibonacci(10);
            var actualArray = fib.GetSequence();
            Assert.IsTrue(expectedArray.SequenceEqual(actualArray), "Arrays do not match!");
        }

        [Test]
        public void FibonacciSequenceIsCorrectForValuesUnder100()
        {
            // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
            var expectedArray = new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            var fib = new Fibonacci();
            fib.Max = 100;
            var actualArray = fib.GetSequence();
            Assert.IsTrue(expectedArray.SequenceEqual(actualArray), "Arrays do not match!");
        }


    }

}