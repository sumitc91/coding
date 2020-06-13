using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class OddCellsSoln
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            var matrix = new int[n, m];

            //initialize matrix to zero.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            for (int i = 0; i < indices.Length; i++)
            {
                int x = indices[i][0];
                int y = indices[i][1];

                //increment x axis
                for (int a = 0; a < m; a++)
                {
                    matrix[x,a]++;
                }

                //increment y axis
                for (int b = 0; b < n; b++)
                {
                    matrix[b, y]++;
                }
            }

            int odd = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        odd++;
                    }
                }
            }

            return odd;
        }
    }
}
