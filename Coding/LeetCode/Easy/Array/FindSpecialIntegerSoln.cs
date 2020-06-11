using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class FindSpecialIntegerSoln
    {
        public int FindSpecialInteger(int[] arr)
        {
            var map = new Dictionary<int, int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else
                {
                    map.Add(arr[i], 1);
                }
            }

            // As it is mentioned that there will be at least one number
            // that will be having more than 25% frequency count.
            int max = 0;
            int value = 0;
            foreach (var item in map)
            {
                if (max < item.Value)
                {
                    max = item.Value;
                    value = item.Key;
                }
            }

            return value;
        }
    }
}
