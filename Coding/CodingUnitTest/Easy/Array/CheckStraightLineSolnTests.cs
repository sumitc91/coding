using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class CheckStraightLineSolnTests
    {
        [TestMethod]
        public void CheckStraightLineSoln_First()
        {
            var coordinates = new int[,] {
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 4, 5 },
                    { 5, 6 },
                    { 6, 7 }
                };            
            var output = true;

            var res = new CheckStraightLineSoln().CheckStraightLine(ArrayMapper(coordinates));

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void CheckStraightLineSoln_Second()
        {
            var coordinates = new int[,] {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 4 },
                    { 4, 5 },
                    { 5, 6 },
                    { 7, 7 }
                };
            var output = false;

            var res = new CheckStraightLineSoln().CheckStraightLine(ArrayMapper(coordinates));

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void CheckStraightLineSoln_Third()
        {
            var coordinates = new int[,] {
                    { 0, 0 },
                    { 0, 1 },
                    { 0, -1 }
                };
            var output = true;

            var res = new CheckStraightLineSoln().CheckStraightLine(ArrayMapper(coordinates));

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void CheckStraightLineSoln_Fourth()
        {
            var coordinates = new int[,] {
                    { 2, 1 },
                    { 4, 2 },
                    { 6, 3 }
                };
            var output = true;

            var res = new CheckStraightLineSoln().CheckStraightLine(ArrayMapper(coordinates));

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
