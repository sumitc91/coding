using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class SortStringSoln
    {
        public void execute()
        {
            var res = SortString("aaaabbbbcccc");
        }

        public string SortString(string s)
        {
            var dict = new Dictionary<char, int>();
            var set = new SortedSet<char>();
            var str = new StringBuilder();
            foreach (var c in s)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict[c] = 1;
                set.Add(c);
            }

            var prevStack = new Stack<char>();
            var currentStack = new Stack<char>();
            foreach (var item in set)
            {
                prevStack.Push(item);
            }

            while (prevStack.Count != 0)
            {
                currentStack.Push(prevStack.Pop());
            }

            while (dict.Count != 0)
            {
                while (currentStack.Count != 0)
                {
                    var item = currentStack.Pop();
                    if (!dict.ContainsKey(item)) continue;
                    str.Append(item);
                    if (dict[item] == 1)
                    {
                        dict.Remove(item);
                    }
                    else
                    {
                        dict[item]--;
                    }
                    prevStack.Push(item);
                }
                currentStack = prevStack;
                prevStack = new Stack<char>();
            }

            return str.ToString();
        }

    }
}
