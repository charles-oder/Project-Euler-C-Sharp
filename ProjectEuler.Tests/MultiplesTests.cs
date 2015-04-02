using System.Collections.Generic;
using NUnit.Framework;

namespace ProjectEuler.Tests {

    [TestFixture]
    class MultiplesTests {

        [Test]
        public void TestSumOfMultiples()
        {
            // Project Euler Problem 1: https://projecteuler.net/problem=1
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            var value = Multiples.Sum(new List<int> {3, 5}, 10);
            Assert.AreEqual(23, value);

            // Find the sum of all the multiples of 3 or 5 below 1000. A: 233168
            var anotherValue = Multiples.Sum(new List<int> {3, 5}, 1000);
            Assert.AreEqual(233168, anotherValue);
        }
    }
}
