using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class CountCharactersSolnTests
    {
        [TestMethod]
        public void CountCharactersSoln_First()
        {
            var words = new string[] { "cat", "bt", "hat", "tree" };
            var chars = "atach";
            var expected = 6;

            var res = new CountCharactersSoln().CountCharacters(words, chars);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void CountCharactersSoln_Second()
        {
            var words = new string[] { "hello", "world", "leetcode" };
            var chars = "welldonehoneyr";
            var expected = 10;

            var res = new CountCharactersSoln().CountCharacters(words, chars);
            Assert.AreEqual(expected, res);
        }
    }
}
