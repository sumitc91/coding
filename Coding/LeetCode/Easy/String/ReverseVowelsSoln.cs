using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class ReverseVowelsSoln
    {
        public string ReverseVowels(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            var strChar = s.ToCharArray();
            while (i < j)
            {
                if (!IsVowel(s[i]))
                {
                    i++;
                    continue;
                }

                if (!IsVowel(s[j]))
                {
                    j--;
                    continue;
                }

                char temp = strChar[j];
                strChar[j] = s[i];
                strChar[i] = temp;

                i++;
                j--;
            }

            return new string(strChar);
        }

        private bool IsVowel(char v)
        {
            bool isVowel = false;
            switch (v)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':isVowel = true;
                    break;
            }

            return isVowel;
        }
    }
}
