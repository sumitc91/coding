using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class DuplicateZerosSolnTests
    {
        [TestMethod]
        public void DuplicateZerosSoln_First()
        {
            var arr = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };           
            var expected = new int[] { 1, 0, 0, 2, 3, 0, 0, 4 };

            new DuplicateZerosSoln().DuplicateZeros(ref arr);
            AreEqual(expected, arr);
        }

        [TestMethod]
        public void DuplicateZerosSoln_Second()
        {
            var arr = new int[] { 1, 2, 3 };
            var expected = new int[] { 1, 2, 3 };

            new DuplicateZerosSoln().DuplicateZeros(ref arr);
            AreEqual(expected, arr);
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
