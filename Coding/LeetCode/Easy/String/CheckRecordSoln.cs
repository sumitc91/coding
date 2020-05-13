using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class CheckRecordSoln
    {
        public bool CheckRecord(string s)
        {
            int absent = 0;            
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == 'A')
                {
                    absent++;
                }
                else
                {
                    if (i < s.Length - 2)
                    {
                        if(s[i] == 'L' && s[i+1] == 'L' && s[i+2] == 'L')
                        {
                            return false;
                        }
                    }
                }
            }

            return absent <= 1;
        }
    }
}
