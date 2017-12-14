using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using HelloWorld.Controllers;

namespace HelloWorld.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result);
        }

        [TestMethod]
        public void GetById_IndexWithinRangeTest()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            string result = controller.Get("1");

            // Assert
            Assert.AreEqual("HelloWorld 2", result);
        }

        [TestMethod]
        public void GetById_OutOfIndexTest()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            string result = controller.Get("blah");

            // Assert
            Assert.AreEqual("Sorry, no hello for you!", result);
        }
    }
}
