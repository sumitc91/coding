using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class CreateTargetArraySoln
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var target = new int[nums.Length];
            var set = new HashSet<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(index[i]))
                {
                    for (int j = nums.Length-1; j > index[i]; j--)
                    {
                        target[j] = target[j - 1];
                        set.Add(j);
                    }
                }  
                
                target[index[i]] = nums[i];
                set.Add(index[i]);                
            }

            return target;
        }
    }
}
