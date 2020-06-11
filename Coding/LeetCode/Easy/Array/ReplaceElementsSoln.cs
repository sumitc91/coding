using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class ReplaceElementsSoln
    {
        public int[] ReplaceElements(int[] arr)
        {
            var temp = new int[arr.Length];
            temp[arr.Length - 1] = arr[arr.Length - 1];
            for (int i = arr.Length-2; i >= 0; i--)
            {
                if (arr[i] > temp[i + 1])
                {
                    temp[i] = arr[i];
                }
                else
                {
                    temp[i] = temp[i + 1];
                }
            }

            var res = new int[arr.Length];
            for (int i = 0; i < arr.Length-1; i++)
            {
                res[i] = temp[i + 1];
            }
            res[arr.Length - 1] = -1;

            return res;
        }
    }
}
