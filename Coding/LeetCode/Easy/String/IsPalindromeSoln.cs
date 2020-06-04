using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class IsPalindromeSoln
    {
        public bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (!IsAlphaNumeric(s[i]))
                {
                    i++;
                    continue;
                }

                if (!IsAlphaNumeric(s[j]))
                {
                    j--;
                    continue;
                }

                if(char.ToLower(s[i]) != char.ToLower(s[j]))
                {
                    return false;                    
                }
                i++;
                j--;
            }

            return true;
        }

        private bool IsAlphaNumeric(char v)
        {
            if( ( v>= 48 && v <= 57 ) || (v >= 65 && v <= 90) || (v >= 97 && v <= 122))
            {
                return true;
            }
            return false;
        }
    }
}
