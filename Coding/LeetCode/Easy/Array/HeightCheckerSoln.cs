using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class HeightCheckerSoln
    {
        public int HeightChecker(int[] heights)
        {
            var copy = new int[heights.Length];
            copy = heights;

            copy = copy.OrderBy(c => c).ToArray();

            int count = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (copy[i] != heights[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
