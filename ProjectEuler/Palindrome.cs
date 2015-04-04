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

    }
}