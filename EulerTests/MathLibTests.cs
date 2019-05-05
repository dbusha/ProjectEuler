using ProjectEuler;
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
        [InlineData(23)]
        [InlineData(25)]
        [InlineData(33)]
        [InlineData(99)]
        [InlineData(121)]
        [InlineData(123)]
        [InlineData(111)]
        public void AreFactorsTest(int value)
        {
            var factors = MathLib.GetFactors(value);
            foreach (var factor in factors)
                Assert.True(value % factor == 0);
        }


        [Fact]
        public void BigIntAddTest()
        {
            var int1 = new BigInt("3");
            var int2 = new BigInt("4");
            Assert.Equal("7", int1.Add(int2).ToString());
            
            var int3 = new BigInt("4");
            var int4 = new BigInt("6");
            Assert.Equal("10", int3.Add(int4).ToString());
            
            var int6 = new BigInt("99");
            var int5 = new BigInt("86");
            Assert.Equal("185", int5.Add(int6).ToString());
        }
        
        
        [Fact]
        public void BigIntEqualsTest()
        {
            var int1 = new BigInt("099");
            var int2 = new BigInt("99");
            var int3 = new BigInt("88");
            var int4 = int2;
            Assert.True(int1 == int2);
            Assert.True(int1 != int3);
            Assert.True(int1 == int4);
        }
    }
}