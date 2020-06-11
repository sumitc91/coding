using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class SumZeroSoln
    {
        public int[] SumZero(int n)
        {
            var res = new int[n];
            if (n == 0)
            {
                return null;
            }

            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                res[i] = (i+1);
                res[j] = (i+1) * -1;
            }

            if (n % 2 != 0)
            {
                res[n / 2] = 0;
            }

            return res;
        }
    }
}
