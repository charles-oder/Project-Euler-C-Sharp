using System.Collections.Generic;

namespace ProjectEuler {
    public class Fibonacci {
        private int count;
        public int Max { get; set; }

        public Fibonacci(int count)
        {
            this.count = count;
            Max = int.MaxValue;
        }

        public Fibonacci() : this(int.MaxValue) {}

        public IEnumerable<int> GetSequence()
        {
            var output = new List<int>();
            var previousValues = new[] { 0, 1 };
            var nextValue = previousValues[1];
            while (nextValue < Max && output.Count < count)
            {
                output.Add(nextValue);
                previousValues[0] = previousValues[1];
                previousValues[1] = nextValue;
                nextValue = previousValues[0] + previousValues[1];
            }
            return output;
        } 

        public static IEnumerable<int> GetSequenceForMax(int max)
        {
            var output = new List<int>();
            var previousValues = new[] { 0, 1 };
            var nextValue = 1;
            while (nextValue < max) {
                output.Add(nextValue);
                previousValues[0] = previousValues[1];
                previousValues[1] = nextValue;
                nextValue = previousValues[0] + previousValues[1];
            }
            return output;
        }
    }
}
