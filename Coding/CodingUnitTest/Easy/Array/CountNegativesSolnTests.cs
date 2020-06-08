using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class CountNegativesSolnTests
    {
        [TestMethod]
        public void CountNegativesSoln_First()
        {
            var grid = new int[,]{
                { 4, 3, 2, -1 },
                { 3, 2, 1, -1 },
                { 1, 1, -1, -2 },
                { -1, -1, -2, -3 }
            };
            var output = 8;
            var res = new CountNegativesSoln().CountNegatives(ArrayMapper(grid));

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountNegativesSoln_Second()
        {
            var grid = new int[,]{
                { 3, 2 },
                { 1, 0 }
            };
            var output = 0;
            var res = new CountNegativesSoln().CountNegatives(ArrayMapper(grid));

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountNegativesSoln_Third()
        {
            var grid = new int[,]{
                { 1, -1 },
                { -1, -1 }
            };
            var output = 3;
            var res = new CountNegativesSoln().CountNegatives(ArrayMapper(grid));

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountNegativesSoln_Fourth()
        {
            var grid = new int[,]{
                { -1 }
            };
            var output = 1;
            var res = new CountNegativesSoln().CountNegatives(ArrayMapper(grid));

            Assert.AreEqual(res, output);
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
