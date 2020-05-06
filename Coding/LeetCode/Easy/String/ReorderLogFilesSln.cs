using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class ReorderLogFilesSln
    {
        public void execute()
        {
            var logs = new string[]{
                "o 0331394079964851 4", 
                "hkkk 600490 9 00 2 0", 
                "7m3va 77480381100875", 
                "f9z3j tydfpvhks m a", 
                "k6 3592 10166 82395", 
                "z7o1 tpipcx b uykyn", 
                "k boowjmrfqlggprhk i", 
                "qoi lzygdsafhglymi n", 
                "h 3338586230095825 1", 
                "77gv7 8886961 21 32", 
                "er 739336634 62 048", 
                "vga vhz wckifxuep kv", 
                "03d 81356369 030 6 1", 
                "fms51 51433485791776", 
                "ldf4 lnm e iuiuoi k", 
                "2 570761582013 84 26", 
                "o5ccb 783786786782 6", 
                "33fj7 86283961878 10", 
                "t lsoqwcwgzlk obxhkd", 
                "x6w55 96799905961 3"};
            var res = ReorderLogFiles(logs);
        }

        public string[] ReorderLogFiles(string[] logs)
        {
            var letter_logs_map = new List<KeyValuePair<string,string>>();
            var digit_logs_map = new List<KeyValuePair<string, string>>();
            for(int i = 0; i < logs.Length; i++)
            {
                var identifier = logs[i].Split(" ")[0];
                var splitStr = logs[i].Split(" ");
                var value = string.Join(" ", splitStr.Skip(1)) + "--" + identifier;
                if (CheckIfDigitLogs(logs[i]))
                {
                    digit_logs_map.Add(new KeyValuePair<string, string>(identifier, value));                    
                }
                else
                {
                    letter_logs_map.Add(new KeyValuePair<string, string>(identifier, value));
                }
            }

            letter_logs_map.Sort(
                delegate (KeyValuePair<string, string> firstPair,
                KeyValuePair<string, string> nextPair)
                {
                    return firstPair.Value.CompareTo(nextPair.Value);
                }
            );

            var result = new string[logs.Length];
            int j = 0;
            foreach (var item in letter_logs_map)
            {
                result[j] = item.Key + " " + item.Value.Split("--")[0];
                j++;
            }

            foreach (var item in digit_logs_map)
            {
                result[j] = item.Key + " " + item.Value.Split("--")[0];
                j++;
            }

            return result;
        }

        private bool CheckIfDigitLogs(string v)
        {
            var split = v.Split(" ");
            return split[1][0] >= 48 && split[1][0] <= 57;
        }
    }
}
