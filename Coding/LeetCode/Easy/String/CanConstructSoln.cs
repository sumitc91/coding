using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class CanConstructSoln
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var map = new Dictionary<char, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if (map.ContainsKey(magazine[i]))
                {
                    map[magazine[i]]++;
                }
                else
                {
                    map.Add(magazine[i], 1);
                }
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (!map.ContainsKey(ransomNote[i]))
                {
                    return false;
                }
                else
                {
                    map[ransomNote[i]]--;
                    if (map[ransomNote[i]] == 0)
                    {
                        map.Remove(ransomNote[i]);
                    }
                }
            }

            return true;
        }
    }
}
