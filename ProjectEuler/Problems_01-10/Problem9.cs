using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Problem9
    {
        /*
         * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which: a^2 + b^2 = c^2
         * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
         * There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.
         * 
         */

        private const int Top = 1000;

        public int Solution1()
        {
            for (var c = Top - 1; c > 0; c--)
            {
                for (var b = 1; b < c; b++)
                {
                    if (c + b > Top)
                        break;
                    for (var a = 1; a < b; a++)
                    {
                        if (c + b + a > Top)
                            break;
                        if(a+b+c == Top && a * a + b * b == c * c)
                            return a*b*c;
                    }
                }
            }

            return 0;
        }
    }
}