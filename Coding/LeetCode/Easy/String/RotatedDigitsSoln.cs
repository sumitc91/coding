using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class RotatedDigitsSoln
    {
        public void execute()
        {
            var res = RotatedDigits(10);
        }

        public int RotatedDigits(int N)
        {
            int ans = 0;
            for (int i = 0; i <= N; i++)
            {
                if (IsRotatedValidNumber(i)) ans++;
            }
            return ans;
        }

        private bool IsRotatedValidNumber(int i)
        {
            bool flag = false;
            while (i != 0)
            {
                var remainder = i % 10;
                if (remainder == 3 || remainder == 4 || remainder == 7) return false;
                if (remainder == 2 || remainder == 5 || remainder == 6 || remainder == 9)
                    flag = true;
                i = i / 10;
            }
            return flag;
        }
    }
}
