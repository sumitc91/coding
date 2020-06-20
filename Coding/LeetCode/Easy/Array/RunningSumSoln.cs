using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class RunningSumSoln
    {
        public int[] RunningSum(int[] nums)
        {
            var res = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                res[i] = sum;
            }

            return res;
        }
    }
}
