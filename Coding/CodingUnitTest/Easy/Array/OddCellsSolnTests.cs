using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    [TestCategory("AskGif.LeetCode.Array.Easy")]
    public class OddCellsSolnTests
    {
        [TestMethod]
        public void OddCellsSoln_First()
        {
            var indices = new int[,] {
                    { 0, 1 },
                    { 1, 1 }
                };
            var n = 2;
            var m = 3;
            var output = 6;

            var res = new OddCellsSoln().OddCells(n, m, ArrayMapper(indices));

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void OddCellsSoln_Second()
        {
            var indices = new int[,] {
                    { 1, 1 },
                    { 0, 0 }
                };
            var n = 2;
            var m = 2;
            var output = 0;

            var res = new OddCellsSoln().OddCells(n, m, ArrayMapper(indices));

            Assert.AreEqual(output, res);
        }

        private int[][] ArrayMapper(int[,] matrix)
        {
            var arr = new int[matrix.GetLength(0)][];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                arr[i] = new int[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    arr[i][j] = matrix[i, j];
                }
            }

            return arr;
        }
    }
}
