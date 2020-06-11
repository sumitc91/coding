using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class SmallerNumbersThanCurrentSolnTests
    {
        [TestMethod]
        public void SmallerNumbersThanCurrentSoln_First()
        {
            var nums = new int[] { 8, 1, 2, 2, 3 };
            var output = new int[]{4, 0, 1, 1, 3};
            var res = new SmallerNumbersThanCurrentSoln().SmallerNumbersThanCurrent(nums);

            AreEqual(res, output);
        }

        [TestMethod]
        public void SmallerNumbersThanCurrentSoln_Second()
        {
            var nums = new int[] { 6, 5, 4, 8 };
            var output = new int[] { 2, 1, 0, 3 };
            var res = new SmallerNumbersThanCurrentSoln().SmallerNumbersThanCurrent(nums);

            AreEqual(res, output);
        }

        [TestMethod]
        public void SmallerNumbersThanCurrentSoln_Third()
        {
            var nums = new int[] { 7, 7, 7, 7 };
            var output = new int[] { 0, 0, 0, 0 };
            var res = new SmallerNumbersThanCurrentSoln().SmallerNumbersThanCurrent(nums);

            AreEqual(res, output);
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
