using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class AddBinarySoln
    {
        public string AddBinary(string a, string b)
        {
            int len1 = a.Length;
            int len2 = b.Length;
            char carry = '0';
            var diffStr = new StringBuilder();
            int diff;
            if (len1 > len2)
            {
                diff = len1 - len2;
                while (diff-- > 0)
                {
                    diffStr.Append("0");
                }
                b = diffStr.ToString() + b;
            }
            else
            {
                diff = len2 - len1;
                while (diff-- > 0)
                {
                    diffStr.Append("0");
                }
                a = diffStr.ToString() + a;
            }

            var res = new StringBuilder();
            for (int i = a.Length-1; i >= 0 ; i--)
            {
                string sum = Addition(a[i], b[i], carry);                
                if(sum.Length == 2)
                {
                    res.Append(sum[1]);
                    carry = sum[0];
                }
                else
                {
                    res.Append(sum[0]);
                    carry = '0';
                }
            }

            if(carry == '1')
            {
                res.Append(carry);
            }

            return new string (res.ToString().Reverse().ToArray());
        }

        private string Addition(char v1, char v2, char carry)
        {
            if(carry == '0')
            {
                if (v1 == '1' && v2 == '1')
                {
                    return "10";
                }
                else if (v1 == '0' && v2 == '0')
                {
                    return "0";
                }
            }
            else
            {
                if (v1 == '1' && v2 == '1')
                {
                    return "11";
                }
                else if (v1 == '0' && v2 == '0')
                {
                    return "1";
                }
                else
                {
                    return "10";
                }
            }            
            return "1";            
        }
    }
}
