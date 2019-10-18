using System.Linq;

namespace ProjectEuler
{
    public class Problem8
    {
        /*
         * The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
         *
         *      
         * 
         *   Find the thirteen adjacent digits in the 1000-digit number that have the greatest product.
         *   What is the value of this product?
         */

        private const string LargeNumber = "73167176531330624919225119674426574742355349194934969835203127745063262" +
                                           "39578318016984801869478851843858615607891129494954595017379583319528532" +
                                           "08805511125406987471585238630507156932909632952274430435576689664895044" +
                                           "52445231617318564030987111217223831136222989342338030813533627661428280" +
                                           "64444866452387493035890729629049156044077239071381051585930796086670172" +
                                           "42712188399879790879227492190169972088809377665727333001053367881220235" +
                                           "42180975125454059475224352584907711670556013604839586446706324415722155" +
                                           "39753697817977846174064955149290862569321978468622482839722413756570560" +
                                           "57490261407972968652414535100474821663704844031998900088952434506585412" +
                                           "27588666881164271714799244429282308634656748139191231628245861786645835" +
                                           "91245665294765456828489128831426076900422421902267105562632111110937054" +
                                           "42175069416589604080719840385096245544436298123098787992724428490918884" +
                                           "58015616609791913387549920052406368991256071760605886116467109405077541" +
                                           "00225698315520005593572972571636269561882670428252483600823257530420752" +
                                           "963450"; 

        public long Solution1()
        {
            int[] number = new int[LargeNumber.Length];
            for (int i = 0; i < LargeNumber.Length; i++)
                number[i] = LargeNumber[i] - 48;
            long max = 1;
            int startingIndex = 0;
            int endingIndex = 12;
            while (endingIndex < number.Length)
            {
                long current = 1;
                for (var i = startingIndex; i <= endingIndex; i++)
                    current *= number[i];
                if (current > max)
                    max = current;
                startingIndex++;
                endingIndex++;
            }

            return max;
        }
        
        
    }
}