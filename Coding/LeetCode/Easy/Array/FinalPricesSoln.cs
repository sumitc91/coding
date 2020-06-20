using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class FinalPricesSoln
    {
        public int[] FinalPrices(int[] prices)
        {
            var discount = new int[prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                discount[i] = prices[i];
                for (int j = i+1; j < prices.Length; j++)
                {
                    if(prices[j] <= prices[i])
                    {
                        discount[i] = prices[i] - prices[j];
                        break;
                    }
                }
            }

            return discount;
        }
    }
}
