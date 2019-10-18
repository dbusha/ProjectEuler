using System;

namespace ProjectEuler
{
    public class Problem3
    {
        /*
         * The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143 ?
         */
        private static readonly long Value = 600851475143;
       

        public long Solution1()
        {
            long max = -1;
            for (long i = 2; i< Math.Sqrt(Value); ++i)
            {
                if (i > max && IsFactor(i) && IsPrime(i))
                {
                    max = i;
                }
            }

            return max;
        }


        private bool IsFactor(long i)
        { return Value % i == 0; }


        private bool IsPrime(long value)
        {
            for (long i = 2; i < Math.Sqrt(value); ++i)
            {
                if (value % i == 0)
                    return false;
            }

            return true;
        }

    }
}