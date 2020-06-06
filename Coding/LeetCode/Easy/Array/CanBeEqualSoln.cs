using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class CanBeEqualSoln
    {
        public bool CanBeEqual(int[] target, int[] arr)
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

            for (int i = 0; i < target.Length; i++)
            {
                if (!map.ContainsKey(target[i]))
                {
                    return false;
                }

                if (map[target[i]] == 1)
                {
                    map.Remove(target[i]);
                }
                else
                {
                    map[target[i]]--;
                }
            }

            return true;
        }
    }
}
