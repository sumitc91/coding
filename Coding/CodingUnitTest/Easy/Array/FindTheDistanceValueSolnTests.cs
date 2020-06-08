using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class FindTheDistanceValueSolnTests
    {
        [TestMethod]
        public void FindTheDistanceValueSoln_First()
        {
            var arr1 = new int[] { 4, 5, 8 };
            var arr2 = new int[] { 10, 9, 1, 8 };
            var d = 2;
            var output = 2;
            var res = new FindTheDistanceValueSoln().FindTheDistanceValue(arr1, arr2, d);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindTheDistanceValueSoln_Second()
        {
            var arr1 = new int[] { 1, 4, 2, 3 };
            var arr2 = new int[] { -4, -3, 6, 10, 20, 30 };
            var d = 3;
            var output = 2;
            var res = new FindTheDistanceValueSoln().FindTheDistanceValue(arr1, arr2, d);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindTheDistanceValueSoln_Third()
        {
            var arr1 = new int[] { 2, 1, 100, 3 };
            var arr2 = new int[] { -5, -2, 10, -3, 7 };
            var d = 6;
            var output = 1;
            var res = new FindTheDistanceValueSoln().FindTheDistanceValue(arr1, arr2, d);

            Assert.AreEqual(res, output);
        }
    }
}
