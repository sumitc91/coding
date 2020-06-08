using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class LuckyNumbersSolnTests
    {
        [TestMethod]
        public void LuckyNumbersSoln_First()
        {
            var matrix = new int[,] { 
                { 3, 7, 8 }, 
                { 9, 11, 13 }, 
                { 15, 16, 17 }
            };           
            var output = new List<int> { 15 };
            var res = new LuckyNumbersSoln().LuckyNumbers(ArrayMapper(matrix));

            AreEqual(res, output);
        }

        [TestMethod]
        public void LuckyNumbersSoln_Second()
        {
            var matrix = new int[,]{
                {1, 10, 4, 2 },
                {9, 3, 8, 7 },
                {15, 16, 17, 12 }
            };
            var output = new List<int> { 12 };
            var res = new LuckyNumbersSoln().LuckyNumbers(ArrayMapper(matrix));

            AreEqual(res, output);
        }
        
        [TestMethod]
        public void LuckyNumbersSoln_Third()
        {
            var matrix = new int[,]{
                {7, 8 },
                {1, 2 }
            };
            var output = new List<int> { 7 };
            var res = new LuckyNumbersSoln().LuckyNumbers(ArrayMapper(matrix));

            AreEqual(res, output);
        }

        [TestMethod]
        public void LuckyNumbersSoln_Fourth()
        {
            var matrix = new int[,]{
                { 36376, 85652, 21002, 4510 },
                { 68246, 64237, 42962, 9974 },
                { 32768, 97721, 47338, 5841 },
                { 55103, 18179, 79062, 46542 }
            };

            var output = new List<int> { };
            var res = new LuckyNumbersSoln().LuckyNumbers(ArrayMapper(matrix));

            AreEqual(res, output);
        }

        private void AreEqual(IList<int> res, List<int> output)
        {
            Assert.AreEqual(res.Count, output.Count);
            for (int i = 0; i < res.Count; i++)
            {
                Assert.AreEqual(res[0], output[0]);
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
                    arr[i][j] = matrix[i,j];
                }
            }

            return arr;
        }
    }
}
