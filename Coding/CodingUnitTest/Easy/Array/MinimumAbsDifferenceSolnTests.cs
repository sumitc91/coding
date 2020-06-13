using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class MinimumAbsDifferenceSolnTests
    {
        [TestMethod]
        public void MinimumAbsDifferenceSoln_First()
        {
            var chips = new int[] { 4, 2, 1, 3 };
            var output = new int[,] {
                { 1, 2 },
                { 2, 3 },
                { 3, 4 }
            };

            var res = new MinimumAbsDifferenceSoln().MinimumAbsDifference(chips);

            AreEqual(output, res);
        }

        [TestMethod]
        public void MinimumAbsDifferenceSoln_Second()
        {
            var chips = new int[] { 1, 3, 6, 10, 15 };
            var output = new int[,] {
                { 1, 3 }
            };

            var res = new MinimumAbsDifferenceSoln().MinimumAbsDifference(chips);

            AreEqual(output, res);
        }

        [TestMethod]
        public void MinimumAbsDifferenceSoln_Third()
        {
            var chips = new int[] { 3, 8, -10, 23, 19, -4, -14, 27 };
            var output = new int[,] {
                { -14, -10 },
                { 19, 23 },
                { 23, 27 }
            };

            var res = new MinimumAbsDifferenceSoln().MinimumAbsDifference(chips);

            AreEqual(output, res);
        }

        private void AreEqual(int[,] output, IList<IList<int>> res)
        {
            for (int i = 0; i < output.GetLength(0); i++)
            {
                for (int j = 0; j < output.GetLength(1); j++)
                {
                    Assert.AreEqual(output[i, j], res[i][j]);
                }
            }
        }
    }
}
