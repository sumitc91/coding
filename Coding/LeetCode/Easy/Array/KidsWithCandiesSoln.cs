using System.Collections.Generic;

namespace CodingUnitTest.Easy.Array
{
    public class KidsWithCandiesSoln
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var res = new List<bool>();
            int max = int.MinValue;
            for (int i = 0; i < candies.Length; i++)
            {
                if (max < candies[i])
                {
                    max = candies[i];
                }
            }

            for (int i = 0; i < candies.Length; i++)
            {
                res.Add((candies[i] + extraCandies) >= max);                
            }

            return res;
        }
    }
}
