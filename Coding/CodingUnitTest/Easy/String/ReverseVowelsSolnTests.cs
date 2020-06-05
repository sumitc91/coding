using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class ReverseVowelsSolnTests
    {
        [TestMethod]
        public void ReverseVowelsSoln_First()
        {
            var a = "hello";            
            var output = "holle";
            var res = new ReverseVowelsSoln().ReverseVowels(a);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void ReverseVowelsSoln_Second()
        {
            var a = "leetcode";
            var output = "leotcede";
            var res = new ReverseVowelsSoln().ReverseVowels(a);

            Assert.AreEqual(res, output);
        }
    }
}
