﻿using System.Collections.Generic;
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

        [Test]
        public void IsPalindromeOnPalindrome() {
            const int testValue = 9009;
            Assert.IsTrue(Palindrome.IsPalindrome(testValue));
        }

        [Test]
        public void IsPalindromeOnNonPalindrome() {
            const int testValue = 9019;
            Assert.IsFalse(Palindrome.IsPalindrome(testValue));
        }

        [Test]
        public void FindLargestPalidromeOfTwoDigitProducts() {
            const int expectedValue = 9009;
            var actualValue = Palindrome.FindLargestPalidromeOfProducts(2);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void FindLargestPalidromeOfThreeDigitProducts() {
            const int expectedValue = 906609;
            var actualValue = Palindrome.FindLargestPalidromeOfProducts(3);

            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}