using System;
using Xunit;
using Example1.Example1;
namespace XUnitTestExample1
{
    public class UnitTest1
    {
        private readonly Calculator _cal = new Calculator();
        [Fact]
        public void Test1()
        {
            Assert.True(_cal.Add(1, 1) == 2);
        }
        [Theory]
        [InlineData(1,1, 2)]
        [InlineData(2,2,4)]
        [InlineData(4,1,5)]
        public void AddTest(int a, int b, int result)
        {
            Assert.True(_cal.Add(a, b) == result);
        }
    }
}
