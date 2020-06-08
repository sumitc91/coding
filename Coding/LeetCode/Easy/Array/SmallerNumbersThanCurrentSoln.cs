using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class SmallerNumbersThanCurrentSoln
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var res = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        res[i]++;
                    }
                }
            }

            return res;
        }
    }
}
