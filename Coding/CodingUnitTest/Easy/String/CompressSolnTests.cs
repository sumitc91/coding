using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class CompressSolnTests
    {
        [TestMethod]
        public void RepeatedSubstringPatternSoln_First()
        {
            var input = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            var output = 6;
            var res = new CompressSoln().Compress(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RepeatedSubstringPatternSoln_Second()
        {
            var input = new char[] { 'a' };
            var output = 1;
            var res = new CompressSoln().Compress(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RepeatedSubstringPatternSoln_Third()
        {
            var input = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            var output = 4;
            var res = new CompressSoln().Compress(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RepeatedSubstringPatternSoln_Fourth()
        {
            var input = new char[] {'a', 'a', 'a', 'b', 'b', 'a', 'a'};
            var output = 6;
            var res = new CompressSoln().Compress(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RepeatedSubstringPatternSoln_Fifth()
        {
            var input = new char[]{'a', 'a', 'a', 'a', 'a', 'b'};
            var output = 3;
            var res = new CompressSoln().Compress(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RepeatedSubstringPatternSoln_Sixth()
        {
            var input = new char[] {'a', 'a', 'a', 'a', 'b', 'a'};
            var output = 4;
            var res = new CompressSoln().Compress(input);

            Assert.AreEqual(res, output);
        }
    }
}
