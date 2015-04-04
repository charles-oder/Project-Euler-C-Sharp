using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler {
    public class Fibonacci {
        private readonly int _count;
        public int Max { get; set; }
        public Func<int, bool> Filter { get; set; }

        public Fibonacci(int count)
        {
            _count = count;
            Max = int.MaxValue;
            Filter = x => true;
        }

        public Fibonacci() : this(int.MaxValue) {}

        public IEnumerable<int> GetSequence()
        {
            var output = new List<int>();
            var previousValues = new[] { 0, 1 };
            var nextValue = previousValues[1];
            while (nextValue < Max && output.Count < _count)
            {
                output.Add(nextValue);
                previousValues[0] = previousValues[1];
                previousValues[1] = nextValue;
                nextValue = previousValues[0] + previousValues[1];
            }
            return output.Where(Filter);
        } 

    }
}
