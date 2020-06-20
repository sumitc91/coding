using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class HeightCheckerSolnTests
    {
        [TestMethod]
        public void HeightCheckerSoln_First()
        {
            var arr = new int[] { 1, 1, 4, 2, 1, 3 };
            var expected = 3;

            var res = new HeightCheckerSoln().HeightChecker(arr);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void HeightCheckerSoln_Second()
        {
            var arr = new int[] { 5, 1, 2, 3, 4 };
            var expected = 5;

            var res = new HeightCheckerSoln().HeightChecker(arr);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void HeightCheckerSoln_Third()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var expected = 0;

            var res = new HeightCheckerSoln().HeightChecker(arr);
            Assert.AreEqual(expected, res);
        }
    }
}
