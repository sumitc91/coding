using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class LuckyNumbersSoln
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            var lOBList = new List<int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                int minNumber = matrix[i][0];
                int minIndex = 0;
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] < minNumber)
                    {
                        minNumber = matrix[i][j];
                        minIndex = j;
                    }
                }
                bool found = true;
                for (int k = 0; k < matrix.Length; k++)
                {
                    if (matrix[k][minIndex] > minNumber)
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    lOBList.Add(minNumber);
                    return lOBList;
                }
            }
            return new List<int>();
        }
    }
}
