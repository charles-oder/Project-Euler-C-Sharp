﻿using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler {
    public class Factors {
        public static int GenerateSmallestDividendForSequence(int sequenceStart, int sequenceEnd)
        {
            var intList = new List<int>();
            for (var i = sequenceStart; i <= sequenceEnd && i > 0; i++)
            {
                intList.Add(i);
            }
            return GenerateSmallestDividendForSequence(intList);
        }

        private static int GenerateSmallestDividendForSequence(List<int> intList)
        {
            var increment = intList[intList.Count - 1];
            for (var output = increment; output < int.MaxValue; output += increment)
            {
                if (IsDivisibleByAllValues(output, intList))
                {
                    return output;
                }
            }
            return 0;
        }

        private static bool IsDivisibleByAllValues(int value, List<int> intList)
        {
            return intList.All(i => value%i == 0);
        }
    }
}
