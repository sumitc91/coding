using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class MinStartValueSolnTests
    {
        [TestMethod]
        public void MinStartValueSoln_First()
        {
            var input = new int[] { -3, 2, -3, 4, 2 };            
            var output = 5;
            var res = new MinStartValueSoln().MinStartValue(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void MinStartValueSoln_Second()
        {
            var input = new int[] { 1, 2 };
            var output = 1;
            var res = new MinStartValueSoln().MinStartValue(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void MinStartValueSoln_Third()
        {
            var input = new int[] { 1, -2, -3 };
            var output = 5;
            var res = new MinStartValueSoln().MinStartValue(input);

            Assert.AreEqual(res, output);
        }
    }
}
