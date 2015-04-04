using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ProjectEuler
{
    public class PrimeFactorGenerator
    {
        private readonly long _value;

        private HashSet<long> _primeFactors;

        public PrimeFactorGenerator(long value)
        {
            _value = value;
        }

        public static bool IsPrime(long value)
        {
            for (var i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value%i == 0)
                {
                    return false;
                }
            }
            return (value != 1);  // 1 is not a prime number
        }

        public List<long> GetPrimeFactors()
        {
            _primeFactors = new HashSet<long>();
            for (long i = 2; i <= Math.Sqrt(_value); i++)
            {
                if ((_value % i == 0) && IsPrime(i))
                {
                    _primeFactors.Add(i);
                    if (IsPrime(_value/i))
                    {
                        _primeFactors.Add(_value/i);
                    }
                }
            }
            return _primeFactors.ToList();
        }
    }
}