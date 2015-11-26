using ELI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class WebServiceAzure
    {
        [TestMethod]
        public void HelloWord()
        {
            string param = "test";
            string resShouldBe = "Hello World " + param;
            string resIs = ExampleAPIProxy.HelloWord(param);

            Assert.AreEqual(resShouldBe, resIs);
        }
    }
}
