using LeetCode.AskGif.Surbhi.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Surbhi.Easy
{
    [TestClass]
    public class TwoSumSolnTests
    {
        [TestMethod]
        public void TwoSumSoln_First()
        {
            var nums = new int[]{2, 7, 11, 15};
            var target = 9;
            var output = new int[] { 0, 1 };
            var res = new TwoSumSoln().TwoSum(nums, target);

            Assert.AreEqual(res[0], output[0]);
            Assert.AreEqual(res[1], output[1]);
        }
    }
}
