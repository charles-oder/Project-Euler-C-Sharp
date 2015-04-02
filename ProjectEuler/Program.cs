using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler {
    class Program {
        static void Main(string[] args)
        {
            var evenFibSeq = ArrayFilter.FilterByLambda(Fibonacci.GetSequence(20),x => x%2 == 0);
            Console.Out.WriteLine(string.Format("The sum of even Fibonacci NUmbers are {0}", evenFibSeq.Sum() ));
            Console.ReadLine();
        }
    }
}
