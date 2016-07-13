

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnetCoreFull.Test.MSTest
{
    [TestClass]
    public class TestClassed
    {
        [TestMethod]
        public void TestMethodPassingMSTest()
        {
            Assert.AreEqual(4, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
