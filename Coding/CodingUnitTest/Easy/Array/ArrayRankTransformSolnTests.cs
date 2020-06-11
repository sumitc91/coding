using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class ArrayRankTransformSolnTests
    {
        [TestMethod]
        public void ArrayRankTransformSoln_First()
        {
            var arr = new int[] { 40, 10, 20, 30 };
            var output = new int[]{ 4, 1, 2, 3 };
            var res = new ArrayRankTransformSoln().ArrayRankTransform(arr);

            AreEqual(res, output);
        }

        [TestMethod]
        public void ArrayRankTransformSoln_Second()
        {
            var arr = new int[] { 100, 100, 100 };
            var output = new int[] { 1, 1, 1 };
            var res = new ArrayRankTransformSoln().ArrayRankTransform(arr);

            AreEqual(res, output);
        }

        [TestMethod]
        public void ArrayRankTransformSoln_Third()
        {
            var arr = new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 };
            var output = new int[] { 5, 3, 4, 2, 8, 6, 7, 1, 3 };
            var res = new ArrayRankTransformSoln().ArrayRankTransform(arr);

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
