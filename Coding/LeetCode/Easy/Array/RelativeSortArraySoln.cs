using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class RelativeSortArraySoln
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var map = new SortedDictionary<int, int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (map.ContainsKey(arr1[i]))
                {
                    map[arr1[i]]++;
                }
                else
                {
                    map.Add(arr1[i], 1);
                }
            }

            var res = new int[arr1.Length];
            int idx = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                for(int j = 0; j < map[arr2[i]]; j++)
                {
                    res[idx] = arr2[i];
                    idx++;                    
                }
                map.Remove(arr2[i]);
            }            

            foreach (var item in map)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    res[idx] = item.Key;
                    idx++;
                }
            }

            return res;
        }
    }
}
