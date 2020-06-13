using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class MinCostToMoveChipsSoln
    {
        public int MinCostToMoveChips(int[] chips)
        {
            var map = new Dictionary<int, int>();
            int max = 0;
            int maxKey = 0;
            int count = 0;
            int evenCount = 0;                     
            int oddCount = 0;                       

            //Build the Hashmap and calculate even and odd position count.
            for (int i = 0; i < chips.Length; i++)
            {
                if (map.ContainsKey(chips[i]))
                {
                    map[chips[i]]++;                    
                }
                else
                {
                    map.Add(chips[i], 1);
                }

                if (chips[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            //will make collective point based on even and odd count 
            //and then by frequency.
            if (evenCount > oddCount)
            {
                foreach (var item in map)
                {
                    if(item.Key % 2 == 0)
                    {
                        if(item.Key > max)
                        {
                            max = item.Value;
                            maxKey = item.Key;
                        }
                    }
                }
            }
            else
            {
                foreach (var item in map)
                {
                    if (item.Key % 2 != 0)
                    {
                        if (item.Key > max)
                        {
                            max = item.Value;
                            maxKey = item.Key;
                        }
                    }
                }
            }

            //find the total count required
            foreach (var item in map)
            {
                if(item.Key != maxKey)
                {
                    if(item.Key > maxKey)
                    {
                        count += item.Value * ((item.Key - maxKey) % 2);
                    }
                    else
                    {
                        count += item.Value * ((maxKey - item.Key) % 2);
                    }
                }
            }
            
            return count;
        }
    }
}
