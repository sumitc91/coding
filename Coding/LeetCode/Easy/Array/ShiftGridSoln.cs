using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class ShiftGridSoln
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            var res = new List<IList<int>>();

            //initialize list with dummy values
            for (int i = 0; i < grid.Length; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < grid[0].Length; j++)
                {
                    row.Add(0);
                }
                res.Add(row);
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    int[] pos = GenerateNewPosition(grid.Length, grid[0].Length, i, j, k);
                    res[pos[0]][pos[1]] = grid[i][j];
                }
            }

            return res;
        }

        private int[] GenerateNewPosition(int row, int column, int i, int j, int k)
        {
            if(j+k > column-1)
            {
                i = i + ((j + k) / column);
                j = (j + k) % column;                
                i = i % row;
            }
            else
            {
                j = j + k;
            }

            return new int[] { i, j };
        }
    }
}
