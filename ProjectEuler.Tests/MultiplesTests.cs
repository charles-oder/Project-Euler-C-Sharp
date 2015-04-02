using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProjectEuler.Tests {

    [TestFixture]
    class MultiplesTests {

        [Test]
        public void TestSumOfMultiples()
        {
            var value = Multiples.Sum(new List<int> {3, 5}, 10);
            Assert.AreEqual(23, value);
            var anotherValue = Multiples.Sum(new List<int> {3, 5}, 1000);
            Assert.AreEqual(233168, anotherValue);
        }
    }
}
