using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class DecompressRLElistSoln
    {
        public int[] DecompressRLElist(int[] nums)
        {
            var res = new List<int>();
            for (int i = 0; i < nums.Length-1; i+=2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    res.Add(nums[i + 1]);
                }
            }

            return res.ToArray();
        }
    }
}
