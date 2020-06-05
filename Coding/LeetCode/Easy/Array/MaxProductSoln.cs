using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class MaxProductSoln
    {
        public int MaxProduct(int[] nums)
        {
            int val = 0;
            int max = int.MinValue;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    val = (nums[i] - 1) * (nums[j] - 1);
                    if (val > max)
                    {
                        max = val;                        
                    }
                }
            }

            return max;
        }
    }
}
