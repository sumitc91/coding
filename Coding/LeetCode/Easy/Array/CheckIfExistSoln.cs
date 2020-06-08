using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class CheckIfExistSoln
    {
        public bool CheckIfExist(int[] arr)
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

            if (map.ContainsKey(0) && map[0] == 2)
            {
                return true;
            }

            map.Remove(0);

            for (int i = 0; i < arr.Length; i++)
            {
                if(map.ContainsKey(arr[i] * 2))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
