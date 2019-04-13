using System.Linq;

namespace ProjectEuler
{
    public class Problem4 : RunProblem<long>
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
            int max = -1;
            for (int i = 999; i >= 100; i--)
            {
                for (int j = i; j > 100; j--)
                {
                    var product = j * i;
                    if (product < max)
                        break;
                    if (IsPalindrome(product))
                    {
                        max = product;
                        break;
                    }
                }
                
            }
            return max;
        }

        private bool IsPalindrome(int product)
        {
            var str = product.ToString();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
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