using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    class Program {
        static void Main(string[] args)
        {
            var x = Multiples.Sum(new List<int>{3, 5}, 1000);
            Console.Out.WriteLine(string.Format("The Multiples of 3 and 5 under 1000 is {0}", x ));
            Console.ReadLine();
        }
    }
}
