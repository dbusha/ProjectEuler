using System;
using ProjectEuler;
using Xunit;

namespace EulerTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var problem = new Problem1();
            var result = problem.Run(1);
            Assert.True(result == 233168);
            result = problem.Run(2);
            Assert.Equal(233168, result);
        }


        [Fact]
        public void Test2()
        {
            var problem = new Problem2();
            var result = problem.Run();
            Assert.Equal(4613732, result);

        }
        
        
        [Fact]
        public void Test3()
        {
            var problem = new Problem3();
            var result = problem.Run();
            Assert.Equal(6857,result );
        }
        
        
        [Fact]
        public void Test4()
        {
            var problem = new Problem4();
            var result = problem.Run();
            Assert.Equal(906609,result);
        }
        
        
        [Fact]
        public void Test5()
        {
            
            var problem = new Problem5();
            var result = problem.Run();
            Assert.Equal(2520, result);
        }

        
        [Fact]
        public void Factoring()
        {
            var p = new Problem5();
            var result = p.GetPrimeFactors(20);
            Assert.NotNull(result);
        }
    }
}