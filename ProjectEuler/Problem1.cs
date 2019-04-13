using System.Linq;

namespace ProjectEuler
{
    public class Problem1 : RunProblem<int>
    {
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
            var result = Enumerable.Range(0, 1000).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
            return result;
        }

        private int Solution2()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }
    }
}