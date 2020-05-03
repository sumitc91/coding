using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class ReformatString
    {
        public void execute()
        {
            string s = "covid2019";

            var res = Reformat(s);
        }

        public string Reformat(string s)
        {
            var number = new List<char>();
            var alphabet = new List<char>();
            for(int i = 0; i < s.Length; i++)
            {
                if (isNumber(s[i]))
                {
                    number.Add(s[i]);
                }
                else
                {
                    alphabet.Add(s[i]);
                }
            }

            if( Math.Abs(number.Count - alphabet.Count) > 1)
            {
                return "";
            }
            else
            {
                StringBuilder res = new StringBuilder();
                if(number.Count > alphabet.Count)
                {
                    for (int i = 0; i < (s.Length/2)+1; i++)
                    {
                        if (i < number.Count)
                        {
                            res.Append(number[i]);
                        }
                        if (i < alphabet.Count)
                        {
                            res.Append(alphabet[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < (s.Length/2)+1; i++)
                    {
                        if (i < alphabet.Count)
                        {
                            res.Append(alphabet[i]);
                        }
                        if (i < number.Count)
                        {
                            res.Append(number[i]);
                        }                        
                    }
                }
                return res.ToString();
            }
        }

        private bool isNumber(char v)
        {
            return v >= 48 && v <= 57;
        }
    }
}
