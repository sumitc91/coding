using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class RelativeSortArraySolnTests
    {
        [TestMethod]
        public void RelativeSortArraySoln_First()
        {
            var arr1 = new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            var arr2 = new int[] { 2, 1, 4, 3, 9, 6 };
            var expected = new int[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 };

            var res = new RelativeSortArraySoln().RelativeSortArray(arr1, arr2);
            AreEqual(expected, res);
        }

        [TestMethod]
        public void RelativeSortArraySoln_Second()
        {
            var arr1 = new int[] { 28, 6, 22, 8, 44, 17 };
            var arr2 = new int[] { 22, 28, 8, 6 };
            var expected = new int[] { 22, 28, 8, 6, 17, 44 };

            var res = new RelativeSortArraySoln().RelativeSortArray(arr1, arr2);
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
