using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class ShiftGridSolnTests
    {
        [TestMethod]
        public void ShiftGridSoln_First()
        {
            var arr = new int[,] {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };
            var k = 1;
            var output = new int[,] {
                    { 9, 1, 2 },
                    { 3, 4, 5 },
                    { 6, 7, 8 }
                };

            var res = new ShiftGridSoln().ShiftGrid(ArrayMapper(arr), k);

            AreEqual(output, res);
        }

        [TestMethod]
        public void ShiftGridSoln_Second()
        {
            var arr = new int[,] {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };
            var k = 9;
            var output = new int[,] {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };

            var res = new ShiftGridSoln().ShiftGrid(ArrayMapper(arr), k);

            AreEqual(output, res);
        }

        [TestMethod]
        public void ShiftGridSoln_Third()
        {
            var arr = new int[,] {
                    { 3, 8, 1, 9 },
                    { 19, 7, 2, 5 },
                    { 4, 6, 11, 10 },
                    { 12, 0, 21, 13 }
                };
            var k = 4;
            var output = new int[,] {
                    { 12, 0, 21, 13 },
                    { 3, 8, 1, 9 },
                    { 19, 7, 2, 5 },
                    { 4, 6, 11, 10 }
                };

            var res = new ShiftGridSoln().ShiftGrid(ArrayMapper(arr), k);

            AreEqual(output, res);
        }


        private void AreEqual(int[,] output, IList<IList<int>> res)
        {
            for (int i = 0; i < res.Count; i++)
            {
                for (int j = 0; j < res[i].Count; j++)
                {
                    Assert.AreEqual(output[i, j], res[i][j]);
                }
            }
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
