using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class ToLowerCaseSoln
    {
        public string ToLowerCase(string str)
        {
            var charArr = str.ToCharArray();
            int diff = 'a' - 'A';
            for (int i = 0; i < str.Length; i++)
            {
                char ch = charArr[i];
                if (ch >= 65 && ch <= 90)
                    charArr[i] = (char)(ch + diff);
            }

            return new string(charArr);
        }
    }
}
