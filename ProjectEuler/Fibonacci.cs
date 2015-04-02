using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    public static class Fibonacci {
        public static IEnumerable<int> GetSequence(int count)
        {
            var output = new List<int>();
            var previousValues = new [] {0, 1};
            for (var i = 0; i < count; i++)
            {
                var nextValue = previousValues[0] + previousValues[1];
                output.Add(nextValue);
                previousValues[0] = previousValues[1];
                previousValues[1] = nextValue;
            }
            return output;
        }
    }
}
