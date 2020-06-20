using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class NumEquivDominoPairsSolnTests
    {
        [TestMethod]
        public void NumEquivDominoPairsSoln_First()
        {
            var dominoes = new int[,]{
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 4 },
                    { 5, 6 }
                };      
            var expected = 1;

            var res = new NumEquivDominoPairsSoln().NumEquivDominoPairs(ArrayMapper(dominoes));
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void NumEquivDominoPairsSoln_Second()
        {
            var dominoes = new int[,]{
                    { 1, 1 },
                    { 2, 2 },
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 2 },
                    { 1, 1 }
                };
            var expected = 4;

            var res = new NumEquivDominoPairsSoln().NumEquivDominoPairs(ArrayMapper(dominoes));
            Assert.AreEqual(expected, res);
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
