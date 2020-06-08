using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class FindLuckySolnTests
    {
        [TestMethod]
        public void FindLuckySoln_First()
        {
            var arr = new int[] { 2, 2, 3, 4 };
            var output = 2;
            var res = new FindLuckySoln().FindLucky(arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindLuckySoln_Second()
        {
            var arr = new int[] { 1, 2, 2, 3, 3, 3 };
            var output = 3;
            var res = new FindLuckySoln().FindLucky(arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindLuckySoln_Third()
        {
            var arr = new int[] { 2, 2, 2, 3, 3 };
            var output = -1;
            var res = new FindLuckySoln().FindLucky(arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindLuckySoln_Fourth()
        {
            var arr = new int[] { 5 };
            var output = -1;
            var res = new FindLuckySoln().FindLucky(arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindLuckySoln_Fifth()
        {
            var arr = new int[] { 7, 7, 7, 7, 7, 7, 7 };
            var output = 7;
            var res = new FindLuckySoln().FindLucky(arr);

            Assert.AreEqual(res, output);
        }
    }
}
