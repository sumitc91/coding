using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class FindLuckySoln
    {
        public int FindLucky(int[] arr)
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

            int max = -1;
            foreach (var item in map)
            {
                if(item.Key == item.Value && item.Key > max)
                {
                    max = item.Key;
                }
            }

            return max;
        }
    }
}
