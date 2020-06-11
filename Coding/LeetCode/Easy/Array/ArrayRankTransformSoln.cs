using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class ArrayRankTransformSoln
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            var map = new Dictionary<int, int>();
            var mapRank = new Dictionary<int, int>();
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

            var sorted = map.OrderBy(x => x.Key);
            var rank = 1;
            foreach (var item in sorted)
            {
                mapRank.Add(item.Key, rank);
                rank++;
            }

            var res = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = mapRank[arr[i]];
            }

            return res;
        }
    }
}
