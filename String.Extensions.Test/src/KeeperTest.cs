using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Extensions.Test.src
{
    [TestClass]
    public class KeeperTest
    {
        [TestMethod]
        public void RemoveAllNumberTest()
        {
            const string expectedValue = "21989";

            var stringTested = "February 2th, 1989";
            stringTested = stringTested.KeepOnlyNumbers();

            Assert.AreEqual(expectedValue, stringTested);
        }
    }
}
