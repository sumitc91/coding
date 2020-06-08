﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class CountNegativesSoln
    {
        public int CountNegatives(int[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] < 0)
                    {
                        count += grid[i].Length - j;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
