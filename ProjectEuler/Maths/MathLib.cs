using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Maths
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
            for (var i = 2; i <= System.Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                    return false;
            }

            return true;
        }

        public static IEnumerable<long> GetFactors(long number)
        {
            var factors = new List<long>{number};
            for (var i = number/2; i > 0; i--)
            {
                if (number % i == 0)
                    factors.Add(i);
            }

            return factors;
        }
        
        
        public static List<long> GetCollatzSequence(long value, Dictionary<long, List<long>> sequenceMap)
        {
            if (value == 1)
                return new List<long> {1};
            var number = value % 2 == 0 ? (value / 2) : (3 * value + 1);
            if (sequenceMap.ContainsKey(number))
                return sequenceMap[number].ToList();
            
            var list = GetCollatzSequence(number, sequenceMap);
            sequenceMap.Add(number, list.ToList());
            list.Add(number);
            return list;
        }

        
    }
}