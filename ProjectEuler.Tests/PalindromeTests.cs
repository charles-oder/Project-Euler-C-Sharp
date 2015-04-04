using System.Collections.Generic;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class PalindromeTests
    {

        [Test]
        public void GetDigitList()
        {
            const int testValue = 123456789;
            var expectedList = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var palindromeDigitList = Palindrome.CreateDigitList(testValue);

            Assert.AreEqual( expectedList, palindromeDigitList);
        }

    }
}