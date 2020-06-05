using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class CountAndSaySolnTests
    {
        [TestMethod]
        public void CountAndSaySoln_First()
        {
            var n = 1;
            var output = "1";
            var res = new CountAndSaySoln().CountAndSay(n);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountAndSaySoln_Second()
        {
            var n = 4;
            var output = "1211";
            var res = new CountAndSaySoln().CountAndSay(n);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountAndSaySoln_Third()
        {
            var n = 5;
            var output = "111221";
            var res = new CountAndSaySoln().CountAndSay(n);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountAndSaySoln_fourth()
        {
            var n = 6;
            var output = "312211";
            var res = new CountAndSaySoln().CountAndSay(n);

            Assert.AreEqual(res, output);
        }
    }
}
