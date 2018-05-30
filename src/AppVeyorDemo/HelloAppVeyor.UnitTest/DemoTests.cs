using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloVayor.Common.Tests
{
    [TestClass()]
    public class DemoTests
    {
        [TestMethod()]
        public void HelloTest()
        {
            var name = Demo.Hello("John Doe");
            Assert.IsNotNull(name, "Should not be null");
            Assert.AreEqual("John Doe", name, "Should be equal 'John Doe'");
        }
    }
}