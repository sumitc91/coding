using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class FindLUSlengthSolnTests
    {
        [TestMethod]
        public void FindLUSlengthSoln_First()
        {
            var a = "aba";
            var b = "cdc";
            var output = 3;
            var res = new FindLUSlengthSoln().FindLUSlength(a, b);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindLUSlengthSoln_Second()
        {
            var a = "aaa";
            var b = "bbb";
            var output = 3;
            var res = new FindLUSlengthSoln().FindLUSlength(a, b);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindLUSlengthSoln_Third()
        {
            var a = "aaa";
            var b = "aaa";
            var output = -1;
            var res = new FindLUSlengthSoln().FindLUSlength(a, b);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindLUSlengthSoln_Fourth()
        {
            var a = "aefawfawfawfaw";
            var b = "aefawfeawfwafwaef";
            var output = 17;
            var res = new FindLUSlengthSoln().FindLUSlength(a, b);

            Assert.AreEqual(res, output);
        }
    }
}
