using Example1.Example1;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private Calculator _cal;
        [SetUp]
        public void Setup()
        {
            _cal = new Calculator();
        }

        [Test]
        public void OnePlusOneEqualTwo()
        {
            Assert.AreEqual(2, _cal.Add(1,1));
        }
        [Test]
        public void TwoPlusTowEquaFour()
        {
            Assert.AreEqual(4, _cal.Add(2, 2));
        }

            [Test]
        public void FourPlusTwoEquaFive()
        {
            Assert.AreEqual(5, _cal.Add(4, 1));
        }
    }
}