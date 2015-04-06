using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    public class Factors {
        public static int GenerateSmallestDividendForSequence(int sequenceStart, int sequenceEnd)
        {
            var intList = new List<int>();
            for (int i = sequenceStart; i <= sequenceEnd; i++)
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
            foreach (var i in intList)
            {
                if (value%i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
