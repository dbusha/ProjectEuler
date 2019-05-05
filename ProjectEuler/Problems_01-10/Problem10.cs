using System.Collections.Generic;

namespace ProjectEuler
{
    public class Problem10
    {
        /*
         * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
         * Find the sum of all the primes below two million.
         */

        private const int TwoMillion = 2_000_000;
        private long sum = 0;

        public long Solution1()
        {
            var list = new List<int>();
            for (var i = 2; i < TwoMillion; i++)
            {
                if (MathLib.IsPrime(i))
                {
                    sum += i;
                    list.Add(i);
                }
            }

            return sum;
        }
            
    }
}