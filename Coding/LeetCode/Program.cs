using LeetCode.Easy;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoSum = new TwoSumSolutionDuplicateAllowed();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var res = twoSum.TwoSum(nums, target);
        }
    }
}
