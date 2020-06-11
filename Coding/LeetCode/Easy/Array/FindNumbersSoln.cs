using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class FindNumbersSoln
    {
        public int FindNumbers(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (IsEvenCount(nums[i]))
                {
                    res++;
                }
            }
            return res;
        }

        private bool IsEvenCount(int num)
        {
            int count = 0;
            while(num != 0)
            {
                count++;
                num = num / 10;
            }

            return count % 2 == 0;
        }
    }
}
