using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProjectEuler.Maths;

namespace ProjectEuler
{
    public class Problem13
    {
        /*
         * Work out the first ten digits of the sum of the one-hundred numbers which are 50-digits in length.
         * See Problem13_numbers.txt 
         */

        public string Solution1()
        {
            var list = new List<BigInt>();
            var file = File.ReadAllLines(".\\HelperFiles\\Problem13_numbers.txt");
            foreach (var number in file)
                list.Add(new BigInt(number));
            BigInt total = new BigInt("0");
            foreach (var number in list)
                total += number;
            return total.ToString();

        }
        
        
        
        
        
    }
}