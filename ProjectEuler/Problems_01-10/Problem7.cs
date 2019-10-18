using System.Collections.Generic;
using ProjectEuler.Maths;

namespace ProjectEuler
{
    public class Problem7
    {
        /*
         * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         * What is the 10,001st prime number?
         */

        public long Solution1()
        {
            int count = 0;
            long value = 0;
            while (count <= 10_001)
            {
                value++;
                if (MathLib.IsPrime(value))
                    count++;
            }

            return value;
        }
    }
}