using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class StrStrSolnTests
    {
        [TestMethod]
        public void StrStrSoln_First()
        {
            var haystack = "hello";
            var needle = "ll";
            var output = 2;
            var res = new StrStrSoln().StrStr(haystack, needle);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void StrStrSoln_Second()
        {
            var haystack = "aaaaa";
            var needle = "bba";
            var output = -1;
            var res = new StrStrSoln().StrStr(haystack, needle);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void StrStrSoln_Third()
        {    
            var haystack = "mississippi";
            var needle = "pi";
            var output = 9;
            var res = new StrStrSoln().StrStr(haystack, needle);

            Assert.AreEqual(res, output);
        }
    }
}
