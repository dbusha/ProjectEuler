using System.Linq;

namespace ProjectEuler
{
    public class Problem4 
    {
        /*
         * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit
         * numbers is 9009 = 91 × 99. Find the largest palindrome made from the product of two 3-digit numbers.
         */
        
        private static readonly long Value = 600851475143;
       

        public long Solution1()
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
    }
}