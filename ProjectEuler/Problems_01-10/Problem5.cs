using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ProjectEuler.Maths;

namespace ProjectEuler
{
    public class Problem5 
    {
        /*
         *   2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         *   What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         */
        
        
        private int TopOfRange = 20;
       

        public long Solution1()
        {
            var range = new HashSet<int>();
            for (var i = TopOfRange; i > 1; i--)
            {
                var factors = MathLib.GetPrimeFactors(i);
                foreach (var f in factors.Where(f => f != 1))
                    range.Add(f);
            }

            var results = new List<int>();
            foreach (var number in range.ToArray())
            {
                var i = number;
                var result = 1;
                while (i * result < TopOfRange)
                    result *= i;

                results.Add(result);
            }
            
            var final = results.Aggregate(1, (runningTotal, value) => runningTotal * value);
            return final;
        }
        

        public int Solution2()
        {
            int gcm = 1;
            for (int i = 2; i <= TopOfRange; i++)
                gcm *= i;


            var counter = TopOfRange;
            while (counter < gcm)
            {
                var matchFound = true;
                for (var i = 2; i <= TopOfRange; i++)
                {
                    if (counter % i != 0)
                    {
                        matchFound = false;
                        break;
                    }
                }

                if (matchFound)
                    return counter;
                
                counter++;
            }
            return gcm;
        }
    }
}