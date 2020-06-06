using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class KidsWithCandiesSolnTests
    {
        [TestMethod]
        public void KidsWithCandiesSoln_First()
        {
            var candies = new int[] { 2, 3, 5, 1, 3 };
            var extraCandies = 3;
            var output = new bool[] { true, true, true, false, true };
            var res = new KidsWithCandiesSoln().KidsWithCandies(candies, extraCandies);

            Assert.AreEqual(res, output);
        }
    }
}
