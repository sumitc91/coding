using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class ReverseStrSolnTests
    {
        [TestMethod]
        public void ReverseStrSoln_First()
        {
            var s = "abcdefg";
            var k = 2;
            var output = "bacdfeg";
            var res = new ReverseStrSoln().ReverseStr(s, k);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void ReverseStrSoln_Second()
        {
            var s = "a";
            var k = 2;
            var output = "a";
            var res = new ReverseStrSoln().ReverseStr(s, k);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void ReverseStrSoln_Third()
        {
            var s = "abcdefg";
            var k = 3;
            var output = "cbadefg";
            var res = new ReverseStrSoln().ReverseStr(s, k);

            Assert.AreEqual(res, output);
        }
    }
}
