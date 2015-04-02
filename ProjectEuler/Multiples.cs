using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    public static class Multiples {

        public static int Sum(List<int> multiples, int max)
        {
            var total = 0;
            foreach (var multiple in GetMultiples(multiples, max))
            {
                total += multiple;
            }
            return total;
        }

        private static List<int> GetMultiples(List<int> multiples, int max)
        {
            var output = new List<int>();
            foreach ( var n in multiples )
            {
                for (var i = n; i < max; i += n)
                {
                    if (!output.Contains(i))
                    {
                        output.Add(i);
                    }
                }
            }
            return output;
        } 
    }
}
