using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class ShuffleSoln
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var res = new int[nums.Length];
            var index = 0;
            for (int i = 0, j = n; j < nums.Length; i++, j++)
            {
                res[index] = nums[i];
                index++;
                res[index] = nums[j];
                index++;
            }

            return res;
        }
    }
}
