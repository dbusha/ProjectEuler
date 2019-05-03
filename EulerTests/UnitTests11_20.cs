using System;
using System.Linq;
using ProjectEuler;
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
    }
}