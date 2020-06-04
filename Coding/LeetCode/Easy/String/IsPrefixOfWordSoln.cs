using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class IsPrefixOfWordSoln
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var word = 1;
            bool isBeginingOfWord = true;
            for(int i = 0; i < sentence.Length; i++)
            {
                if (isBeginingOfWord)
                {
                    isBeginingOfWord = false;
                    if (IsWordAPrefix(sentence, searchWord, i))
                    {
                        return word;
                    }
                    word++;
                }
                if(sentence[i] == ' ')
                {
                    isBeginingOfWord = true;
                }
            }
            return -1;
        }

        private bool IsWordAPrefix(string sentence, string searchWord, int i)
        {
            for(int j = 0; j < searchWord.Length; j++)
            {
                if(sentence[i+j] != searchWord[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
