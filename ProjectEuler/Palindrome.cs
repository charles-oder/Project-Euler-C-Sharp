using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Palindrome
    {
        public static List<int> CreateDigitList(int value)
        {
            var list = new List<int>();
            while (value > 0)
            {
                var digit = value%10;
                list.Add(digit);
                value /= 10;
            }
            list.Reverse();
            return list;
        }

        public static bool IsPalindrome(int value)
        {
            var digits = CreateDigitList(value);
            for (var i = 0; i < digits.Count/2; i ++) 
            {
                if (digits[i] != digits[digits.Count - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static int FindLargestPalidromeOfProducts(int digitLength)
        {
            var max = Math.Pow(10, digitLength);
            var largestPalindrome = 0;
            for (var x = 1; x < max; x++)
            {
                for (var y = 1; y < max; y++)
                {
                    if (IsPalindrome(x*y) && x*y > largestPalindrome)
                    {
                        largestPalindrome = x*y;
                    }
                }
            }
            return largestPalindrome;
        }
    }
}