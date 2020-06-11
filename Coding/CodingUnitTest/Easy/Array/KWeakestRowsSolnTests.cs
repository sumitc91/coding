using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class KWeakestRowsSolnTests
    {
        [TestMethod]
        public void KWeakestRowsSoln_First()
        {
            var mat = new int[,] {
                    { 1, 1, 0, 0, 0 },
                    { 1, 1, 1, 1, 0 },
                    { 1, 0, 0, 0, 0 },
                    { 1, 1, 0, 0, 0 },
                    { 1, 1, 1, 1, 1 }
                   };
            var k = 3;
            var output = new int[]{2, 0, 3};
            var res = new KWeakestRowsSoln().KWeakestRows(ArrayMapper(mat), k);

            AreEqual(res, output);
        }

        [TestMethod]
        public void KWeakestRowsSoln_Second()
        {
            var mat = new int[,] {
                     { 1, 0, 0, 0 },
                     { 1, 1, 1, 1 },
                     { 1, 0, 0, 0 },
                     { 1, 0, 0, 0 }
                   };
            var k = 2;
            var output = new int[] { 0, 2 };
            var res = new KWeakestRowsSoln().KWeakestRows(ArrayMapper(mat), k);

            AreEqual(res, output);
        }

        [TestMethod]
        public void KWeakestRowsSoln_Third()
        {
            var mat = new int[,] {
                     { 1, 0 },
                     { 0, 0 },
                     { 1, 0 }
                   };
            var k = 2;
            var output = new int[] { 1, 0 };
            var res = new KWeakestRowsSoln().KWeakestRows(ArrayMapper(mat), k);

            AreEqual(res, output);
        }

        [TestMethod]
        public void KWeakestRowsSoln_Fourth()
        {
            var mat = new int[,] {
                     { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                     { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
                   };
            var k = 17;
            var output = new int[] { 10, 12, 15, 4, 14, 16, 2, 7, 11, 3, 5, 0, 13, 1, 9, 17, 6 };
            var res = new KWeakestRowsSoln().KWeakestRows(ArrayMapper(mat), k);

            AreEqual(res, output);
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

        private void AreEqual(int[] res, int[] output)
        {
            Assert.AreEqual(res.Length, output.Length);
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], output[i]);
            }
        }
    }
}
