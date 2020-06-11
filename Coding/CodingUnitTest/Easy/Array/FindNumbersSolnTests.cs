using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class FindNumbersSolnTests
    {
        [TestMethod]
        public void FindNumbersSoln_First()
        {
            var arr = new int[] { 12, 345, 2, 6, 7896 };
            var output = 2;
            var res = new FindNumbersSoln().FindNumbers(arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void FindNumbersSoln_Second()
        {
            var arr = new int[] { 555, 901, 482, 1771 };
            var output = 1;
            var res = new FindNumbersSoln().FindNumbers(arr);

            Assert.AreEqual(res, output);
        }
    }
}
