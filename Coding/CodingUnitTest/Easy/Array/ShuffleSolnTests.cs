using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class ShuffleSolnTests
    {
        [TestMethod]
        public void ShuffleSoln_First()
        {
            var nums = new int[] { 2, 5, 1, 3, 4, 7 };
            var n = 3;
            var output = new int[] { 2, 3, 5, 4, 1, 7 };
            var res = new ShuffleSoln().Shuffle(nums, n);

            AreEqual(res, output);
        }

        [TestMethod]
        public void ShuffleSoln_Second()
        {
            var nums = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
            var n = 4;
            var output = new int[] { 1, 4, 2, 3, 3, 2, 4, 1 };
            var res = new ShuffleSoln().Shuffle(nums, n);

            AreEqual(res, output);
        }

        [TestMethod]
        public void ShuffleSoln_Third()
        {
            var nums = new int[] { 1, 1, 2, 2 };
            var n = 2;
            var output = new int[] { 1, 2, 1, 2 };
            var res = new ShuffleSoln().Shuffle(nums, n);

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
