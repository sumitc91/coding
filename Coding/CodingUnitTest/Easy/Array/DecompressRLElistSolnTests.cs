using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class DecompressRLElistSolnTests
    {
        [TestMethod]
        public void DecompressRLElistSoln_First()
        {
            var arr = new int[] { 1, 2, 3, 4 };
            var output = new int[] { 2, 4, 4, 4 };
            var res = new DecompressRLElistSoln().DecompressRLElist(arr);

            AreEqual(res, output);
        }

        [TestMethod]
        public void DecompressRLElistSoln_Second()
        {
            var arr = new int[] { 1, 1, 2, 3 };
            var output = new int[] { 1, 3, 3 };
            var res = new DecompressRLElistSoln().DecompressRLElist(arr);

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
