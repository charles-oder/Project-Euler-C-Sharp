using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler {
    public static class Multiples {

        public static int Sum(List<int> multiples, int max)
        {
            return CombineAllMultiples(multiples, max).Sum();
        }

        private static IEnumerable<int> CombineAllMultiples(IEnumerable<int> multiples, int max)
        {
            return multiples.Aggregate(new List<int>(), (current, n) => GetMultiples(max, n, current));
        }

        private static List<int> GetMultiples(int max, int multiple, List<int> list)
        {
            var output = new List<int>();
            if (list != null) output.AddRange(list);
            for (var i = multiple; i < max; i += multiple)
            {
                if (!output.Contains(i)) output.Add(i);
            }
            return output;
        }
    }
}
