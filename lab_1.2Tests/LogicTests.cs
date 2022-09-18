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
            string checkNum = "5 6 -1 -5 3";

            var outMessage = Logic.Check(checkNum);

            Assert.AreEqual("Знак изменился 2 раз", outMessage );
        }

        [TestMethod()]
        public void SignChanges3Times()
        {
            string checkNum = "5 6 -1 5 -3";

            var outMessage = Logic.Check(checkNum);

            Assert.AreEqual("Знак изменился 3 раз", outMessage);
        }

        [TestMethod()]
        public void SignChanges1Times()
        {
            string checkNum = "5 6 1 5 -3";

            var outMessage = Logic.Check(checkNum);

            Assert.AreEqual("Знак изменился 1 раз", outMessage);
        }
    }
}