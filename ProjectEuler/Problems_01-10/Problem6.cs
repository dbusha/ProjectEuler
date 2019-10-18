using System;
using System.Linq;

namespace ProjectEuler
{
    public class Problem6
    {
        /*
            The sum of the squares of the first ten natural numbers is: 1^2 + 2^2 + ... + 10^2 = 385
            The square of the sum of the first ten natural numbers is: (1 + 2 + ... + 10)^2 = 55^2 = 3025
            Hence the difference between the sum of the squares of the first ten natural numbers and the 
            square of the sum is 3025 − 385 = 2640.

            Find the difference between the sum of the squares of the first one hundred natural numbers 
            and the square of the sum.
        */

        public long Solution1()
        {
            var range = Enumerable.Range(1, 100).ToArray();
            var squareOfSum = (long)Math.Pow(range.Sum(value => value),2);
            var sumOfSquares = range.Sum(value => value * value);
            return squareOfSum - sumOfSquares;
        }
    }
}