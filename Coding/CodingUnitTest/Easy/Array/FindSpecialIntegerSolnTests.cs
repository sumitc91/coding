using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class FindSpecialIntegerSolnTests
    {
        [TestMethod]
        public void FindSpecialIntegerSoln_First()
        {
            var arr = new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 };
            var output = 6;
            var res = new FindSpecialIntegerSoln().FindSpecialInteger(arr);

            Assert.AreEqual(res, output);
        }
    }
}
