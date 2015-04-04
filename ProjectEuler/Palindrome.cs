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
    }
}