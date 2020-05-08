using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class ReverseOnlyLettersSoln
    {
        public void execute()
        {            
            var res = ReverseOnlyLetters("a-bC-dEf-ghIj");
        }

        public string ReverseOnlyLetters(string S)
        {
            char[] str = new char[S.Length];
            for (int i = 0, j = S.Length-1; i < S.Length;)
            {
                if (IsLetter(S[i]) && IsLetter(S[j]))
                {
                    str[i] = S[j];
                    i++;
                    j--;
                }
                else if (!IsLetter(S[i]))
                {
                    str[i] = S[i];
                    i++;
                }
                else if (!IsLetter(S[j]))
                {
                    j--;
                }
            }

            return new string(str);
        }

        private bool IsLetter(char v)
        {
            return (v >= 97 && v <= 122) || (v >= 65 && v <= 90);
        }
    }
}
