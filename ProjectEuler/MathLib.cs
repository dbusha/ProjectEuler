using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class MathLib
    {
        public static IEnumerable<int> GetPrimeFactors(int value)
        {
            var factors = new List<int>();
            for (var i = value-1; i > 1; i--)
            {
                if (value % i == 0)
                    factors.AddRange(GetPrimeFactors(i));
            }

            if (!factors.Any())
                factors.Add(value);

            return factors;
        }

        
        public static bool IsPrime(long value)
        {
            for (var i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                    return false;
            }

            return true;
        }

        public static IEnumerable<long> GetFactors(long triangleNumber)
        {
            var factors = new List<long>{triangleNumber};
            for (long i = triangleNumber/2; i > 0; i--)
            {
                if (triangleNumber % i == 0)
                    factors.Add(i);
            }

            return factors;
        }
    }
}