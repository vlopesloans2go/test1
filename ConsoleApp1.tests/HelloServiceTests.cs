using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.tests
{
    [TestFixture]
    public class HelloServiceTests
    {
        HelloService _service = new HelloService();

        [Test]
        public void HelloService_ReturnsHelloMsg()
        {
            var expectedResult = "Hello !";

            var result = _service.GetSayHelloMsg();

            Assert.AreEqual(result, expectedResult);
        }
    }
}
