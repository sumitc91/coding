using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class IsValidSoln
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var map = new Dictionary<char, char>();
            map.Add('(', ')');
            map.Add('{', '}');
            map.Add('[', ']');

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if(stack.Count == 0)
                    {
                        return false;
                    }

                    var ch = stack.Pop();
                    if(map[ch] != s[i])
                    {
                        return false;
                    }
                }
            }

            if(stack.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
