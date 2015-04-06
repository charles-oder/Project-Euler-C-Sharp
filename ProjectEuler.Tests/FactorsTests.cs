﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProjectEuler.Tests {
    [TestFixture]
    class FactorsTests {

        [Test]
        public void GenerateProductOfFactorsOneThroughTen() {
            var expectedValue = 2520;
            var actualValue = Factors.GenerateSmallestDividendForSequence(1, 10);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GenerateProductOfFactorsOfWayTooBigNumbers() {
            var expectedValue = 0;
            var actualValue = Factors.GenerateSmallestDividendForSequence(int.MaxValue - 10, int.MaxValue);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GenerateProductOfFactorsOneThroughTwenty() {
            var expectedValue = 232792560;
            var actualValue = Factors.GenerateSmallestDividendForSequence(1, 20);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
