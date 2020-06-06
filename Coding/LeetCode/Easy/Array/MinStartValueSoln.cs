using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class MinStartValueSoln
    {
        public int MinStartValue(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            int minVal = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < 0 && (Math.Abs(sum) + 1 > minVal))
                {
                    minVal = Math.Abs(sum)+ 1;
                }
            }
            
            if(minVal == 0)
            {
                minVal = 1;
            }

            return minVal;
        }
    }
}
