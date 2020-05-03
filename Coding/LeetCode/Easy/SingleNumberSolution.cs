using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class SingleNumberSolution
    {
        public void execute()
        {

            var input = new int[] { 2, 2, 1 };
            int res = SingleNumber(input);
        }

        public int SingleNumber(int[] nums)
        {
            int val = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                val = val ^ nums[i];
            }            
            return val;
        }
    }
}
