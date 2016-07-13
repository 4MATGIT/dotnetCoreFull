using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace dotnetCoreFull.Test.xUnit
{
    public class Class1
    {
        [Fact]
        public void PassingTestAdd()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(100, 5, 95)]
        public void CanSubtract(int x, int y, int expected)
        {
            Assert.Equal(expected, Calculator.Subtract(x, y));
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, -1, 1)]
        [InlineData(100, 5, 500)]
        public void CanMultiply(int x, int y, int expected)
        {
            Assert.Equal(Calculator.Multiply(x, y), expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, -1, 1)]
        [InlineData(100, 5, 20)]
        public void CanDivide(int x, int y, int expected)
        {
            Assert.Equal(Calculator.Divide(x, y), expected);
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
