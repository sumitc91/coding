using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class CountLargestGroupSoln
    {
        public int CountLargestGroup(int n)
        {
            var dict = new Dictionary<int, int>();
            int sum = 0;
            int max = int.MinValue;
            for(int i = 1; i <= n; i++)
            {
                sum = FindSum(i);
                if (dict.ContainsKey(sum))
                {
                    dict[sum]++;
                }
                else
                {
                    dict.Add(sum, 1);
                }

                if (max < dict[sum])
                {
                    max = dict[sum];
                }
            }

            int count = 0;
            foreach (var item in dict)
            {
                if (max == item.Value)
                {
                    count++;
                }
            }

            return count;
        }

        private int FindSum(int i)
        {            
            int sum=0;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }

            return sum;
        }
    }
}
