using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class MinimumAbsDifferenceSoln
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            int minDiff = int.MaxValue;
            int diff = 0;
            var res = new List<IList<int>>();

            //Sort the array in ascending order
            arr = arr.OrderBy(x => x).ToArray();
            
            for (int i = 1; i < arr.Length; i++)
            {
                diff = arr[i] - arr[i - 1];
                if(diff < minDiff)
                {
                    res.Clear();
                    res.Add(new List<int>() { arr[i - 1], arr[i] });
                    minDiff = diff;
                }
                else if(diff == minDiff)
                {
                    res.Add(new List<int>() { arr[i - 1], arr[i] });
                }
            }

            return res;
        }
    }
}
