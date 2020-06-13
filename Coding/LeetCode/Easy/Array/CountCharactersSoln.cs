using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class CountCharactersSoln
    {
        public int CountCharacters(string[] words, string chars)
        {
            var available = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (available.ContainsKey(chars[i]))
                {
                    available[chars[i]]++;
                }
                else
                {
                    available.Add(chars[i], 1);
                }
            }

            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var temp = new Dictionary<char,int>(available);
                bool possible = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (temp.ContainsKey(words[i][j])){
                        temp[words[i][j]]--;
                        if (temp[words[i][j]] == 0)
                        {
                            temp.Remove(words[i][j]);
                        }
                    }
                    else
                    {
                        possible = false;
                        break;
                    }
                }

                if (possible)
                {
                    sum += words[i].Length;
                }
            }

            return sum;
        }
    }
}
