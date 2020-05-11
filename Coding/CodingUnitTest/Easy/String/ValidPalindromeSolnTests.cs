using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class ValidPalindromeSolnTests
    {
        [TestMethod]
        public void ValidPalindromeSoln_aba()
        {
            var input = "aba";
            var output = true;
            var res = new ValidPalindromeSoln().ValidPalindrome(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void ValidPalindromeSoln_abca()
        {
            var input = "abca";
            var output = true;
            var res = new ValidPalindromeSoln().ValidPalindrome(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void ValidPalindromeSoln_ebcbbececabbacecbbcbe()
        {
            var input = "ebcbbececabbacecbbcbe";
            var output = true;
            var res = new ValidPalindromeSoln().ValidPalindrome(input);

            Assert.AreEqual(res, output);
        }
    }
}
