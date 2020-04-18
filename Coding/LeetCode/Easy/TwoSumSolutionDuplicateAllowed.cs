//Given an array of integers, return indices of the two numbers such that they add up to a specific target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//Example:

//Given nums = [2, 7, 11, 15], target = 9,

//Because nums[0] + nums[1] = 2 + 7 = 9,
//return [0, 1].

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class TwoSumSolutionDuplicateAllowed
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            var sumSetIndex = new int[2];
            for (int i=0;i<nums.Length;i++)
            {                
                dict.Add(nums[i], i);                              
            }

            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {                    
                    if(dict.ContainsKey(target - num))
                    {
                        sumSetIndex[0] = dict[num];
                        sumSetIndex[1] = dict[target - num];                            
                    }                    
                }
            }

            return sumSetIndex;
        }
    }
}
