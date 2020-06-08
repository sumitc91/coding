using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class CountLargestGroupSolnTests
    {
        [TestMethod]
        public void CountLargestGroupSoln_First()
        {
            var n = 13;
            var output = 4;
            var res = new CountLargestGroupSoln().CountLargestGroup(n);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountLargestGroupSoln_Second()
        {
            var n = 2;
            var output = 2;
            var res = new CountLargestGroupSoln().CountLargestGroup(n);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountLargestGroupSoln_Third()
        {
            var n = 15;
            var output = 6;
            var res = new CountLargestGroupSoln().CountLargestGroup(n);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountLargestGroupSoln_Fourth()
        {
            var n = 24;
            var output = 5;
            var res = new CountLargestGroupSoln().CountLargestGroup(n);

            Assert.AreEqual(res, output);
        }
    }
}
