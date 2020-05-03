using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class RemovePalindromeSubSol
    {
        public void execute()
        {
            var res = RemovePalindromeSub("ababa");
        }
        public int RemovePalindromeSub(string s)
        {
            if (s == null || s == "")
                return 0;

            for (int i = 0,j = s.Length - 1; i <= j; i++, j--)
            {
                if (s[i] != s[j])
                    return 2;
            }
            return 1;
        }
    }
}
