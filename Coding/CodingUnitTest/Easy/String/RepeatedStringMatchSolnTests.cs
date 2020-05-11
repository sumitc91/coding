using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class RepeatedStringMatchSolnTests
    {
        [TestMethod]
        public void RepeatedStringMatchSoln_abcd_cdabcdab()
        {
            var A = "abcd";
            var B = "cdabcdab";
            var output = 3;
            var res = new RepeatedStringMatchSoln().RepeatedStringMatch(A, B);

            Assert.AreEqual(res, output);
        }
    }
}
