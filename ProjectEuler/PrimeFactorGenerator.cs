using System;

namespace ProjectEuler
{
    public class PrimeFactorGenerator
    {
        public static bool IsPrime(int value)
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
    }
}