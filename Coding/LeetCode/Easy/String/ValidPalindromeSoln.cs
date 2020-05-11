using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class ValidPalindromeSoln
    {
        public bool ValidPalindrome(string s)
        {
            int diff = 0;
            for (int i = 0, j= s.Length-1; i < j;)
            {
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    return IsValid(s.Substring(i, j - i)) || IsValid(s.Substring(i + 1, j-i));
                }
            }
            return true;
        }

        private bool IsValid(string v)
        {
            for (int i = 0, j = v.Length-1; i < j; i++,j--)
            {
                if (v[i] != v[j])
                    return false;
            }
            return true;
        }
    }
}
