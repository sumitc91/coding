using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class RunningSumSolnTests
    {
        [TestMethod]
        public void RunningSumSoln_First()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var expected = new int[] { 1, 3, 6, 10 };

            var res = new RunningSumSoln().RunningSum(nums);
            AreEqual(expected, res);
        }

        [TestMethod]
        public void RunningSumSoln_Second()
        {
            var nums = new[] { 1, 1, 1, 1, 1 };
            var expected = new int[] { 1, 2, 3, 4, 5 };

            var res = new RunningSumSoln().RunningSum(nums);
            AreEqual(expected, res);
        }

        [TestMethod]
        public void RunningSumSoln_Third()
        {
            var nums = new[] { 3, 1, 2, 10, 1 };
            var expected = new int[] { 3, 4, 6, 16, 17 };

            var res = new RunningSumSoln().RunningSum(nums);
            AreEqual(expected, res);
        }

        private void AreEqual(int[] res, int[] output)
        {
            Assert.AreEqual(res.Length, output.Length);
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], output[i]);
            }
        }

    }
}
