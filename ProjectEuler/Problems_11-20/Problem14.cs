using System;
using System.Collections.Generic;
using ProjectEuler.Maths;

namespace ProjectEuler
{
    public class Problem14
    {
        /*
         * The following iterative sequence is defined for the set of positive integers:
         *
         * n → n/2 (n is even)
         * n → 3n + 1 (n is odd)
         *
         * Using the rule above and starting with 13, we generate the following sequence:
         *
         * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
         * 
         * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has
         * not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
         * Which starting number, under one million, produces the longest chain?
         *
         * NOTE: Once the chain starts the terms are allowed to go above one million.
         * 
         */

        private const int TopOfRange = 1_000_000;

        public int Solution1()
        {
            var maxLengthGenerator = 0;
            var maxLength = 0;
            var sequenceMap = new Dictionary<long, List<long>>();
            for (var i = 2; i < TopOfRange; i++)
            {
                if (sequenceMap.ContainsKey(i))
                {
                    if (sequenceMap[i].Count > maxLength)
                    {
                        maxLength = sequenceMap[i].Count;
                        maxLengthGenerator = i;
                    }

                    continue;
                }

                var length = MathLib.GetCollatzSequence(i, sequenceMap).Count;
                if (length > maxLength)
                {
                    maxLength = length;
                    maxLengthGenerator = i;
                }
            }
            
            return maxLengthGenerator;
        }


        
    }
}