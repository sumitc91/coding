using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class CountBinarySubstringsSolnTests
    {
        [TestMethod]
        public void CountBinarySubstringsSoln_00110011()
        {
            var input = "00110011";
            var output = 6;
            var res = new CountBinarySubstringsSoln().CountBinarySubstrings(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountBinarySubstringsSoln_10101()
        {
            var input = "10101";
            var output = 4;
            var res = new CountBinarySubstringsSoln().CountBinarySubstrings(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountBinarySubstringsSoln_00110()
        {
            var input = "00110";
            var output = 3;
            var res = new CountBinarySubstringsSoln().CountBinarySubstrings(input);

            Assert.AreEqual(res, output);
        }
    }
}
