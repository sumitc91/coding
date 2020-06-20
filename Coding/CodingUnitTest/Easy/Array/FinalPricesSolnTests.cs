using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class FinalPricesSolnTests
    {
        [TestMethod]
        public void FinalPricesSoln_First()
        {
            var prices = new[] { 8, 4, 6, 2, 3 };
            var expected = new int[] { 4, 2, 4, 2, 3 };

            var res = new FinalPricesSoln().FinalPrices(prices);
            AreEqual(expected, res);
        }

        [TestMethod]
        public void FinalPricesSoln_Second()
        {
            var prices = new[] { 1, 2, 3, 4, 5 };
            var expected = new int[] { 1, 2, 3, 4, 5 };

            var res = new FinalPricesSoln().FinalPrices(prices);
            AreEqual(expected, res);
        }

        [TestMethod]
        public void FinalPricesSoln_Third()
        {
            var prices = new[] { 10, 1, 1, 6 };
            var expected = new int[] { 9, 0, 1, 6 };

            var res = new FinalPricesSoln().FinalPrices(prices);
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
