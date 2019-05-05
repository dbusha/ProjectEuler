using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ProjectEuler
{
    public class MathLib
    {
        public static IEnumerable<int> GetPrimeFactors(int value)
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

        
        public static bool IsPrime(long value)
        {
            for (var i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                    return false;
            }

            return true;
        }

        public static IEnumerable<long> GetFactors(long triangleNumber)
        {
            var factors = new List<long>{triangleNumber};
            for (long i = triangleNumber/2; i > 0; i--)
            {
                if (triangleNumber % i == 0)
                    factors.Add(i);
            }

            return factors;
        }
    }


    public class BigInt
    {
        private int[] array;


        private BigInt(int[] number)
        {
            array = number;
        }

        public BigInt(string number)
        {
            array = new int[number.Length];
            int index = 0;
            foreach (var c in number)
            {
                array[index] = c - 48;
                index++;
            }
        }
        
        public BigInt Add(BigInt other)
        {
            var thisIndex = array.Length - 1;
            var otherIndex = other.array.Length - 1;
            
            // Add check to see if I need to increase the length of the result array
            var sumIndex = Math.Max(array.Length, other.array.Length) - 1;
            
            var sum = new int[sumIndex + 1];
            var carry = 0;
            
            while(sumIndex >= 0)
            {
                var thisValue = GetValue(array, thisIndex);
                var otherValue = GetValue(other.array, otherIndex);
                
                var value = thisValue + otherValue + carry;
                carry = value > 9 ? 1 : 0;

                sum [sumIndex] = value % 10;
                thisIndex--;
                otherIndex--;
                sumIndex--;
            }

            if (carry == 0)
                return new BigInt(sum);
            
            var result = new int[sum.Length + 1];
            result[0] = carry;
            for (var i = 0; i < sum.Length; i++)
                result[i + 1] = sum[i];
            return new BigInt(result);
        }
        

        private static int GetValue(int[] array, int index)
        {
            if (index < 0 || index > array.Length-1)
                return 0;
            return array[index];
        }


        public override bool Equals(object obj)
        {
            if (!(obj is BigInt other))
                return false;
            var thisSize = array.Length - 1;
            var otherSize = other.array.Length - 1;
            while (thisSize > 0 || otherSize > 0)
            {
                if (GetValue(array, thisSize) != GetValue(other.array, otherSize))
                    return false;
                thisSize--;
                otherSize--;
            }

            return true;
        }


        public override int GetHashCode()
        { return ToString().GetHashCode(); }


        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (var car in array)
                builder.Append(car);
            return builder.ToString();
        }
        

        public static bool operator ==(BigInt a, BigInt b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            
            return a.Equals(b);
        }

        
        public static bool operator !=(BigInt a, BigInt b) => !(a == b);

        public static BigInt operator +(BigInt a, BigInt b) => a.Add(b);
        
    }
}