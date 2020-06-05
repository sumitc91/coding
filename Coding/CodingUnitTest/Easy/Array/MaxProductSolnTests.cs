using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class MaxProductSolnTests
    {
        [TestMethod]
        public void MaxProductSoln_First()
        {
            var nums = new int[] { 3, 4, 5, 2 };
            var output = 12;
            var res = new MaxProductSoln().MaxProduct(nums);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void MaxProductSoln_Second()
        {
            var nums = new int[]{1, 5, 4, 5};
            var output = 16;
            var res = new MaxProductSoln().MaxProduct(nums);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void MaxProductSoln_Third()
        {
            var nums = new int[]{3, 7};
            var output = 12;
            var res = new MaxProductSoln().MaxProduct(nums);

            Assert.AreEqual(res, output);
        }
    }
}
