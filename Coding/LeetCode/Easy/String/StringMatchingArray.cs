using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class StringMatchingArray
    {
        public void execute()
        {
            string[] words = new string[] { "mass", "as", "hero", "superhero" };

            var res = StringMatching(words);
        }

        public IList<string> StringMatching(string[] words)
        {
            //to Store unique solution.
            var ListStr = new HashSet<string>();
            for (int i = 0; i < words.Length-1; i++)
            {
                for(int j = i+1; j < words.Length; j++)
                {
                    string subStr;
                    if (words[i].Length>words[j].Length)
                        subStr = ReturnSubstring(words[i], words[j]);
                    else
                        subStr = ReturnSubstring(words[j], words[i]);
                    if (subStr != null)
                        ListStr.Add(subStr);
                }
            }

            var result = new List<string>();
            foreach (var item in ListStr)
            {
                result.Add(item);
            }
            return result;
        }

        private string ReturnSubstring(string word1, string word2)
        {
            for (int i = 0; i < word1.Length-word2.Length+1; i++)
            {
                for (int j = 0; j < word2.Length; j++)
                {
                    if (word1[i + j] != word2[j])
                        break;
                    if (j == word2.Length - 1)
                    {
                        return word2;
                    }
                }
            }
            return null;
        }
    }
}
