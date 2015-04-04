using System.Collections.Generic;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class PrimeFactorGeneratorTests
    {

        [Test]
        public void IsPrimeWithPrimeNumbers() {
            Assert.IsTrue(PrimeFactorGenerator.IsPrime(3));
            Assert.IsTrue(PrimeFactorGenerator.IsPrime(5));
            Assert.IsTrue(PrimeFactorGenerator.IsPrime(7));
            Assert.IsTrue(PrimeFactorGenerator.IsPrime(11));
            Assert.IsTrue(PrimeFactorGenerator.IsPrime(17));
        }

        [Test]
        public void IsPrimeWithNonPrimeNumbers() {
            Assert.IsFalse(PrimeFactorGenerator.IsPrime(1));
            Assert.IsFalse(PrimeFactorGenerator.IsPrime(6));
            Assert.IsFalse(PrimeFactorGenerator.IsPrime(55));
            Assert.IsFalse(PrimeFactorGenerator.IsPrime(100));
            Assert.IsFalse(PrimeFactorGenerator.IsPrime(30000000));
        }

        [Test]
        public void GetPrimeFactorsOfPerfectSquare() {
            long testValue = 841;
            List<long> expectedList = new List<long> { 29 };
            PrimeFactorGenerator generator = new PrimeFactorGenerator(testValue);

            Assert.AreEqual(expectedList, generator.GetPrimeFactors());
        }

        [Test]
        public void GetPrimeFactorsOfProductOfPrimes() {
            long testValue = 55;
            List<long> expectedList = new List<long> { 5, 11 };
            PrimeFactorGenerator generator = new PrimeFactorGenerator(testValue);

            Assert.AreEqual(expectedList, generator.GetPrimeFactors());
        }

        [Test]
        public void GetPrimeFactors() {
            var testValue = 13195;
            List<long> expectedList = new List<long> { 5, 7, 13, 29 };
            PrimeFactorGenerator generator = new PrimeFactorGenerator(testValue);

            Assert.AreEqual(expectedList, generator.GetPrimeFactors());
        }

    }
}