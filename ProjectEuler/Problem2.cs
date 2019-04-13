using System;

namespace ProjectEuler
{
    public class Problem2 : RunProblem<int>
    {
        private static readonly int UpperBound = 4 * (int) Math.Pow(10.0, 6.0);
        
        
        public override int Run(int solutionNumber)
        {
            switch (solutionNumber)
            {
                case 1: return Solution1();
                case 2: return Solution2();
                default: return -1;
            }
        }

        private int Solution1()
        {
            int term1 = 1;
            int term2 = 2;
            int sum = 0;
            while (term1 < UpperBound)
            {
                if (term1 % 2 == 0)
                {
                    sum += term1;
                }

                var temp = term1 + term2;
                term1 = term2;
                term2 = temp;
            }

            return sum;
        }

        private int Solution2()
        {
            return 0;
        }
    }
}