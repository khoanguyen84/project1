using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example1.Example1;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator _cal = new Calculator();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(_cal.Add(1, 1), 2);
        }
    }
}
