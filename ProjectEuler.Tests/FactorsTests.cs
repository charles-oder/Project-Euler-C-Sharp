using NUnit.Framework;

namespace ProjectEuler.Tests {
    [TestFixture]
    class FactorsTests {

        [Test]
        public void GenerateProductOfFactorsOneThroughTen() {
            const int expectedValue = 2520;
            var actualValue = Factors.GenerateSmallestDividendForSequence(1, 10);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GenerateProductOfFactorsOfWayTooBigNumbers() {
            const int expectedValue = 0;
            var actualValue = Factors.GenerateSmallestDividendForSequence(int.MaxValue - 10, int.MaxValue);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GenerateProductOfFactorsOneThroughTwenty() {
            const int expectedValue = 232792560;
            var actualValue = Factors.GenerateSmallestDividendForSequence(1, 20);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
