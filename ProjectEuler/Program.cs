using System;
using System.Linq;

namespace ProjectEuler {
    class Program {
        static void Main(string[] args)
        {
            var fib = new Fibonacci(20);
            Func<int, bool> func = x => x%2 == 0;
            fib.Filter = func;
            var evenFibSeq = fib.GetSequence();
            foreach (var i in evenFibSeq)
            {
                Console.Out.WriteLine(string.Format("\t{0}", i));
            }
            Console.Out.WriteLine(string.Format("The sum of even Fibonacci NUmbers are {0}", evenFibSeq.Sum()));
            Console.ReadLine();
        }
    }
}
