using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

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
        
        
        public static List<int> GetCollatzSequence(int value, Dictionary<int, List<int>> sequenceMap)
        {
            if (value == 1)
                return new List<int> {1};
            var number = value % 2 == 0 ? TransformEven(value) : TransformOdd(value);
            if (sequenceMap.ContainsKey(number))
                return sequenceMap[number].ToList();
            
            var list = GetCollatzSequence(number, sequenceMap);
            sequenceMap.Add(number, list.ToList());
            list.Add(number);
            return list;
        }

        private static int TransformEven(int value) => value / 2;
        private static int TransformOdd(int value) => 3 * value + 1;
    }
}