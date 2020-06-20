using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class CanThreePartsEqualSumSolnTests
    {
        [TestMethod]
        public void CanThreePartsEqualSumSoln_First()
        {
            var arr = new int[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 };
            var expected = true;

            var res = new CanThreePartsEqualSumSoln().CanThreePartsEqualSum(arr);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void CanThreePartsEqualSumSoln_Second()
        {
            var arr = new int[] { 0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1 };
            var expected = false;

            var res = new CanThreePartsEqualSumSoln().CanThreePartsEqualSum(arr);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void CanThreePartsEqualSumSoln_Third()
        {
            var arr = new int[] { 3, 3, 6, 5, -2, 2, 5, 1, -9, 4 };
            var expected = true;

            var res = new CanThreePartsEqualSumSoln().CanThreePartsEqualSum(arr);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void CanThreePartsEqualSumSoln_Fourth()
        {
            var arr = new int[] { 1, -1, 1, -1 };
            var expected = false;

            var res = new CanThreePartsEqualSumSoln().CanThreePartsEqualSum(arr);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void CanThreePartsEqualSumSoln_Fifth()
        {
            var arr = new int[] { 10, -10, 10, -10, 10, -10, 10, -10 };
            var expected = true;

            var res = new CanThreePartsEqualSumSoln().CanThreePartsEqualSum(arr);
            Assert.AreEqual(expected, res);
        }
    }
}
