using System;
using System.Linq;
using ProjectEuler;
using ProjectEuler.Maths;
using Xunit;

namespace EulerTests
{
    public class UnitTests11_20
    {
        [Fact]
        public void Test11()
        {
            var p = new Problem11();
            
            Assert.Equal(1651104, p.GetDown(0,0));
            Assert.Equal(34144, p.GetRight(0,0));
            Assert.Equal(24468444, p.GetLeftDiagonal(0,3));
            Assert.Equal(279496, p.GetRightDiagonal(0,0));

            var result = p.Solution1();
            Assert.Equal(70_600_674, result);
        }
        
        [Fact]
        public void Test12()
        {
            var p = new Problem12();
            var factors = MathLib.GetFactors(28);
            Assert.Equal(6, factors.Count());
            var result = p.Solution1();
            Assert.Equal(76_576_500, result);
        }
        
        
        [Fact]
        public void Test13()
        {
            var p = new Problem13();
            var result = p.Solution1();
            var tenDigits = new String(result.Take(10).ToArray());
            Assert.Equal("5537376230", tenDigits);
        }


        [Fact]
        public void Test14()
        {
            var p = new Problem14();
            var value = p.Solution1();
            Assert.Equal(837799, value);
        }
        
        
        [Fact]
        public void Test15()
        {
            var p = new Problem15();
            var value = p.Solution1(20);
            Assert.Equal(137846528820, value);
        }
        
        
        [Fact]
        public void Test15_2()
        {
            var p = new Problem15();
            var value = p.Solution2(20);
            Assert.Equal(137846528820, value);
        }
        
        [Fact]
        public void Test20()
        {
            var p = new Problem20();
            p.Solution1();
            
        }
    }
}