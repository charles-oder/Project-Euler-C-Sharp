using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class ArrayFilterTests
    {
        [Test]
        public void ArrayFilterProperlyFiltersOutEvenInts()
        {
            var expectedList = new[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};

            var actualList = ArrayFilter.FilterByLambda(expectedList , x => x%2 == 0);
            Assert.IsTrue(expectedList.SequenceEqual(actualList), "Lists do not match!");
        }
    }
}