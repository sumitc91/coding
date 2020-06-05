using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class LongestCommonPrefixSolnTests
    {
        [TestMethod]
        public void LongestCommonPrefixSoln_First()
        {
            var input = new string[] { "flower", "flow", "flight" };
            var output = "fl";
            var res = new LongestCommonPrefixSoln().LongestCommonPrefix(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void LongestCommonPrefixSoln_Second()
        {
            var input = new string[]{"dog", "racecar", "car"};
            var output = "";
            var res = new LongestCommonPrefixSoln().LongestCommonPrefix(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void LongestCommonPrefixSoln_Third()
        {
            var input = new string[] { "c", "c" };
            var output = "c";
            var res = new LongestCommonPrefixSoln().LongestCommonPrefix(input);

            Assert.AreEqual(res, output);
        }
    }
}
