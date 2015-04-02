using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class ArrayFilter
    {
        public static IEnumerable<T> FilterByLambda<T>(IEnumerable<T> e, Func<T, bool> func)
        {
            return e.Where(v => func(v)).ToList();
        }
    }
}