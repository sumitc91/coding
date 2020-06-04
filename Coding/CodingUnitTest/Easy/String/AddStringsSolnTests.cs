using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class AddStringsSolnTests
    {
        [TestMethod]
        public void AddStringsSoln_First()
        {
            var num1 = "12";
            var num2 = "18";
            var output = "30";
            var res = new AddStringsSoln().AddStrings(num1, num2);

            Assert.AreEqual(res, output);
        }
    }
}
