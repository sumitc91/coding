using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class FirstUniqCharSolnTests
    {
        [TestMethod]
        public void FirstUniqCharSoln_First()
        {
            var s = "leetcode";
            var output = 0;
            var res = new FirstUniqCharSoln().FirstUniqChar(s);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FirstUniqCharSoln_Second()
        {
            var s = "loveleetcode";
            var output = 2;
            var res = new FirstUniqCharSoln().FirstUniqChar(s);

            Assert.AreEqual(res, output);
        }
    }
}
