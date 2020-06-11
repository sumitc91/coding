using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class SumZeroSolnTests
    {
        [TestMethod]
        public void SumZeroSoln_First()
        {
            var n = 5;            
            var res = new SumZeroSoln().SumZero(n);

            IsSumZero(res);
        }

        private void IsSumZero(int[] res)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < res.Length; i++)
            {
                if (map.ContainsKey(res[i]))
                {
                    map[res[i]]++;
                }
                else
                {
                    map.Add(res[i], 1);
                }
            }

            foreach (var item in map)
            {
                Assert.AreEqual(item.Value, 1);
            }

            var sum = 0;
            for (int i = 0; i < res.Length; i++)
            {
                sum += res[i];
            }

            Assert.AreEqual(sum, 0);
        }
    }
}
