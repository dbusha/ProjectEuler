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
            var result = problem.Solution1();
            Assert.True(result == 233168);
            result = problem.Solution2();
            Assert.Equal(233168, result);
        }


        [Fact]
        public void Test2()
        {
            var problem = new Problem2();
            var result = problem.Solution1();
            Assert.Equal(4613732, result);

        }
        
        
        [Fact]
        public void Test3()
        {
            var problem = new Problem3();
            var result = problem.Solution1();
            Assert.Equal(6857,result );
        }
        
        
        [Fact]
        public void Test4()
        {
            var problem = new Problem4();
            var result = problem.Solution1();
            Assert.Equal(906609,result);
        }
        
        
        [Fact]
        public void Test5()
        {
            
            var problem = new Problem5();
            var result = problem.Solution1();
            Assert.Equal(232792560, result);
        }

        
        [Fact]
        public void Test6()
        {
            var p = new Problem6();
            var result = p.Solution1();
            Assert.Equal(25164150, result);
        }
        
        
        [Fact]
        public void Test7()
        {
            var p = new Problem7();
            var result = p.Solution1();
            Assert.Equal(0, result);
        }
    }
}