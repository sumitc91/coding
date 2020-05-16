using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class RepeatedSubstringPatternSolnTests
    {
        [TestMethod]
        public void RepeatedSubstringPatternSoln_First()
        {
            var a = "abab";
            var output = true;
            var res = new RepeatedSubstringPatternSoln().RepeatedSubstringPattern(a);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RepeatedSubstringPatternSoln_Second()
        {
            var a = "aba";
            var output = false;
            var res = new RepeatedSubstringPatternSoln().RepeatedSubstringPattern(a);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RepeatedSubstringPatternSoln_Third()
        {
            var a = "abcabcabcabc";
            var output = true;
            var res = new RepeatedSubstringPatternSoln().RepeatedSubstringPattern(a);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RepeatedSubstringPatternSoln_Fourth()
        {
            var a = "ababcababc";
            var output = true;
            var res = new RepeatedSubstringPatternSoln().RepeatedSubstringPattern(a);

            Assert.AreEqual(res, output);
        }
    }
}
