using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class DetectCapitalUseSoln
    {
        public bool DetectCapitalUse(string word)
        {
            var lower = 0;
            var upper = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (IsUpper(word[i]))
                {
                    upper++;
                }
                else
                {
                    lower++;
                }
            }

            if (upper == 1 && IsUpper(word[0]))
            {
                return true;
            }

            return lower == 0 || upper == 0;
        }

        private bool IsUpper(char v)
        {
            if (v >= 65 && v <= 90)
                return true;
            return false;
        }
    }
}
