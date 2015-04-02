using System.Linq;
using System.Threading;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FibonacciSequenceIsCorrectFOrFirst10()
        {
            var expectedArray = new int[] {1, 2, 3, 5, 8, 13, 21, 34, 55, 89};
            var actualArray = Fibonacci.GetSequence(10);
            Assert.IsTrue(expectedArray.SequenceEqual(actualArray), "Arrays do not match!");
        }
    }
}