﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class GcdOfStringsSln
    {
        public void execute()
        {
            var str1 = "ABABAB";
            var str2 = "ABAB";
            var res = GcdOfStrings(str1, str2);
        }

        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1) return "";
            if (str1 == str2) return str1;
            int len1 = str1.Length;
            int len2 = str2.Length;

            while (len2 > 0)
            {
                int temp = len2;
                len2 = len1 % len2;
                len1 = temp;
            }

            return str1.Substring(0, len1);
        }
    }
}
