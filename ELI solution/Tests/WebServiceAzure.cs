//using ELI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class WebServiceAzure
    {
        [TestMethod]
        public void HelloWord()
        {
            ////WebServiceShell wss = new WebServiceShell();
            ServiceReference12.ELIWebServiceSoapClient proxy = new ServiceReference12.ELIWebServiceSoapClient();

            string param = "new";
            string resShouldBe = "Hello World " + param;
            string resIs = proxy.HelloWorld("new");

            Assert.AreEqual(resShouldBe, resIs);
        }

        [TestMethod]
        public void getPatientWithOrderListBy()
        {
            ////WebServiceShell wss = new WebServiceShell();
            ServiceReference12.ELIWebServiceSoapClient proxy = new ServiceReference12.ELIWebServiceSoapClient();
            ServiceReference12.PatientIdVO pid = new ServiceReference12.PatientIdVO();

            ServiceReference12.PatientWithOrderListVO res = proxy.getPatientWithOrderListBy(pid);

            int resIs = res.orders.Length;
            int resShouldBe = 2;

            Assert.AreEqual(resShouldBe, resIs);
        }
    }
}
