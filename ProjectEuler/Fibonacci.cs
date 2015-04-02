﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    public class Fibonacci {
        private int count;

        public Fibonacci(int count)
        {
            this.count = count;
        }

        public IEnumerable<int> GetSequence()
        {
            var output = new List<int>();
            var previousValues = new[] { 0, 1 };
            for (var i = 0; i < count; i++)
            {
                var nextValue = previousValues[0] + previousValues[1];
                output.Add(nextValue);
                previousValues[0] = previousValues[1];
                previousValues[1] = nextValue;
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
