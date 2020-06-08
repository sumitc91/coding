using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class FindTheDistanceValueSoln
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (Math.Abs(arr1[i] - arr2[j]) <= d)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
