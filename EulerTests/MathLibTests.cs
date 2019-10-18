using System.Collections.Generic;
using System.Linq;
using ProjectEuler;
using ProjectEuler.Maths;
using Xunit;

namespace EulerTests
{
    public class MathLibTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        [InlineData(23)]
        public void IsPrimeTest(int value)
        {
            Assert.True(MathLib.IsPrime(value));
        }
        
        
        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(18)]
        [InlineData(21)]
        [InlineData(27)]
        [InlineData(28)]
        public void IsNotPrimeTest(int value)
        {
            Assert.False(MathLib.IsPrime(value));
        }


        [Theory]
        [InlineData(23)]
        [InlineData(25)]
        [InlineData(33)]
        [InlineData(99)]
        [InlineData(121)]
        [InlineData(123)]
        [InlineData(111)]
        public void ArePrimeFactorsTest(int value)
        {
            var factors = MathLib.GetPrimeFactors(value);
            foreach(var factor in factors)
                Assert.True(MathLib.IsPrime(factor));
        }


        [Theory]
        [InlineData(23, 2)]
        [InlineData(25, 3)]
        [InlineData(33, 4)]
        [InlineData(99, 6)]
        [InlineData(121, 3)]
        [InlineData(123, 4)]
        [InlineData(111, 4)]
        public void GetFactorsTest(int value, int factorCount)
        {
            var factors = MathLib.GetFactors(value).ToList();
            Assert.Equal(factorCount, factors.Count());
            foreach (var factor in factors)
                Assert.True(value % factor == 0);
        }


        [Theory]
        [InlineData("3", "4", "7")]
        [InlineData("4", "6", "10")]
        [InlineData("89", "99", "185")]
        public void BigIntAddTest(string value1, string value2, string result)
        {
            var int1 = new BigInt(value1);
            var int2 = new BigInt(value2);
            Assert.Equal(result, int1.Add(int2).ToString());
        }
        
        
        [Theory]
        [InlineData("3", "03", "7")]
        [InlineData("03", "3", "10")]
        [InlineData("11", "11", "185")]
        public void BigIntEqualsTest(string value1, string value2, string value3)
        {
            var int1 = new BigInt(value1);
            var int2 = new BigInt(value2);
            var int3 = new BigInt(value3);
            var int4 = int2;
            Assert.True(int1 == int2);
            Assert.True(int1 != int3);
            Assert.True(int1 == int4);
        }


        [Theory]
        [InlineData("11","3","33")]
        [InlineData("3","11","33")]
        public void BigIntMultiplyTest(string value1, string value2, string result)
        {
            var int1 = new BigInt(value1);
            var int2 = new BigInt(value2);
            var int3 = int1.Multiply(int2);
            Assert.True(int3 == new BigInt(result));
        }
        
        
        [Theory]
        [InlineData(13, 10)]
        [InlineData(25, 24)]
        public void CollatzSequenceTest(int value, int length)
        {
            var lookup = new Dictionary<long, List<long>>();
            var result = MathLib.GetCollatzSequence(value, lookup);
            Assert.Equal(length, result.Count);
        }
    }
}