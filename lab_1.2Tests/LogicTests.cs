using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void SignChanges2Times()
        {
            List<int> list = new List<int>() { 1, -1, 2, 4};

            var outMessage = Logic.Check(list);

            Assert.AreEqual("Знак изменился 2 раз", outMessage );
        }

        [TestMethod()]
        public void SignChanges3Times()
        {
            List<int> list = new List<int>() { 1, -1, 2, -4};

            var outMessage = Logic.Check(list);

            Assert.AreEqual("Знак изменился 3 раз", outMessage);
        }

        [TestMethod()]
        public void SignChanges1Times()
        {
            List<int> list = new List<int>() { 1, -1};

            var outMessage = Logic.Check(list);

            Assert.AreEqual("Знак изменился 1 раз", outMessage);
        }
    }
}