using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

            AreEqual(res, output);
        }

        [TestMethod]
        public void KidsWithCandiesSoln_Second()
        {
            var candies = new int[] { 4, 2, 1, 1, 2 };
            var extraCandies = 1;
            var output = new bool[] { true, false, false, false, false };
            var res = new KidsWithCandiesSoln().KidsWithCandies(candies, extraCandies);

            AreEqual(res, output);
        }

        [TestMethod]
        public void KidsWithCandiesSoln_Third()
        {
            var candies = new int[] { 12, 1, 12 };
            var extraCandies = 10;
            var output = new bool[] { true, false, true };
            var res = new KidsWithCandiesSoln().KidsWithCandies(candies, extraCandies);

            AreEqual(res, output);
        }

        public static void AreEqual(IList<bool> actual, bool[] expected)
        {
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
