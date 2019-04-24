using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler
{
    public class Problem5 : RunProblem<long>
    {
        int TopOfRange = 20;
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
            for (int i = TopOfRange; i > 1; i--)
            {
                var factors = GetPrimeFactors(i).ToArray();
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
            


            Trace.WriteLine(string.Join(",", results.OrderBy(i => i)));
            long value = 1;
            foreach (var item in results)
                value *= item;
            Trace.WriteLine(value);
            return value;
        }
        

        public IEnumerable<int> GetPrimeFactors(int value)
        {
            var factors = new List<int>();
            for (var i = value-1; i > 1; i--)
            {
                if (value % i == 0)
                    factors.AddRange(GetPrimeFactors(i));
            }

            if (!factors.Any())
                factors.Add(value);

            return factors;
        }
        

        private int Solution2()
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