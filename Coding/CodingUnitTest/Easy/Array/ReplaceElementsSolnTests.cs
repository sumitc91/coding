using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class ReplaceElementsSolnTests
    {
        [TestMethod]
        public void ReplaceElementsSoln_First()
        {
            var arr = new int[] { 17, 18, 5, 4, 6, 1 };
            var output = new int[] { 18, 6, 6, 6, 1, -1 };
            var res = new ReplaceElementsSoln().ReplaceElements(arr);

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
