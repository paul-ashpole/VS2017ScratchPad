using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scratchpad.Tests
{
    [TestClass()]
    public class AdderTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(4, new Adder().Add(2, 2));
        }
    }
}