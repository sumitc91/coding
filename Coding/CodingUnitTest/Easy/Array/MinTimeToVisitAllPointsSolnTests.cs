using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class MinTimeToVisitAllPointsSolnTests
    {
        [TestMethod]
        public void MinTimeToVisitAllPointsSoln_First()
        {
            var arr = new int[,] {
                    { 1, 1 },
                    { 3, 4 },
                    { -1, 0 }
                };
            var output = 7;
            var res = new MinTimeToVisitAllPointsSoln().MinTimeToVisitAllPoints(ArrayMapper(arr));

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void MinTimeToVisitAllPointsSoln_Second()
        {
            var arr = new int[,] {
                    { 3 , 2 },
                    { -2, 2 }
                };
            var output = 5;
            var res = new MinTimeToVisitAllPointsSoln().MinTimeToVisitAllPoints(ArrayMapper(arr));

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
