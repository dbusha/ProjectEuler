using System;
using System.Diagnostics;

namespace ProjectEuler
{
    public class Problem3 : RunProblem<long>
    {
        private static readonly long Value = 600851475143;
        public override long Run(int solutionNumber)
        {
            switch (solutionNumber)
            {
                case 1: return Solution1();
                case 2: return Solution2();
                default: return -1;
            }
        }

        private long Solution1()
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

        private int Solution2()
        {
            return 0;
        }
    }
}