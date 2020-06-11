using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class TictactoeSolnTests
    {
        [TestMethod]
        public void TictactoeSoln_First()
        {
            var moves = new int[,] {
                { 0, 0 },
                { 2, 0 },
                { 1, 1 },
                { 2, 1 },
                { 2, 2 }
            };

            var output = "A";
            var res = new TictactoeSoln().Tictactoe(ArrayMapper(moves));

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void TictactoeSoln_Second()
        {
            var moves = new int[,] {
                { 0, 0 },
                { 1, 1 },
                { 0, 1 },
                { 0, 2 },
                { 1, 0 },
                { 2, 0 }
            };

            var output = "B";
            var res = new TictactoeSoln().Tictactoe(ArrayMapper(moves));

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void TictactoeSoln_Third()
        {
            var moves = new int[,] {
                { 0, 0 },
                { 1, 1 },
                { 2, 0 },
                { 1, 0 },
                { 1, 2 },
                { 2, 1 },
                { 0, 1 },
                { 0, 2 },
                { 2, 2 }
            };

            var output = "Draw";
            var res = new TictactoeSoln().Tictactoe(ArrayMapper(moves));

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void TictactoeSoln_Fourth()
        {
            var moves = new int[,] {
                { 0, 0 },
                { 1, 1 }
            };

            var output = "Pending";
            var res = new TictactoeSoln().Tictactoe(ArrayMapper(moves));

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
