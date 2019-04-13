using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class Problem5 : RunProblem<long>
    {
        int UpperBound = 10;
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
            var range = new HashSet<int>();
            for (int i = UpperBound; i > 1; i--)
            {
                var factors = GetFactors(i);
                if (factors.All(f => f == factors.First()))
                    range.Add(i);
                else
                    foreach (var factor in factors)
                        range.Add(factor);
                
            }

            Console.WriteLine(string.Join(",", range.OrderBy(i => i)));
            long value = 1;
            foreach (var item in range)
                value *= item;
            Console.WriteLine(value);
            return value;
        }

        private bool IsPerfectSquare(int value)
        {
            var temp = Math.Sqrt(value);
            return Math.Abs(temp % ((int) temp)) < .001;
        }
        

        private int[] GetFactors(int value)
        {
            for (var i = value/2; i > 1; i--)
            {
                for (var j = i; j > 1; j--)
                {
                    if (value == (i * j))
                        return GetFactors(i).Union(GetFactors(j)).ToArray();
                }
            }

            return new int[]{ value };
        }


        private bool IsPrime(int value)
        {
            for (int i = (int)Math.Sqrt(value); i > 1; i--)
            {
                if (value % i == 0)
                    return false;
            }

            return true;
        }
        


        private int Solution2()
        {
            int i = 0;
            while (true)
            {
                for (int j = UpperBound; j > 1; j++)
                {
                    if (i % j != 0)
                        break;
                    if (j == 2)
                        return i;
                }

                i++;
            }
            return 0;
        }
    }
}