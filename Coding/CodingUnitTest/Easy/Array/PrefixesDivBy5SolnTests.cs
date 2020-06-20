using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class PrefixesDivBy5SolnTests
    {
        [TestMethod]
        public void PrefixesDivBy5Soln_First()
        {
            var arr = new int[] { 0, 1, 1 };
            var expected = new bool[] { true, false, false };

            var res = new PrefixesDivBy5Soln().PrefixesDivBy5(arr);
            AreEqual(expected, res);
        }

        [TestMethod]
        public void PrefixesDivBy5Soln_Second()
        {
            var arr = new int[] { 1, 1, 1 };
            var expected = new bool[] { false, false, false };

            var res = new PrefixesDivBy5Soln().PrefixesDivBy5(arr);
            AreEqual(expected, res);
        }

        [TestMethod]
        public void PrefixesDivBy5Soln_Third()
        {
            var arr = new int[] { 0, 1, 1, 1, 1, 1 };
            var expected = new bool[] { true, false, false, false, true, false };

            var res = new PrefixesDivBy5Soln().PrefixesDivBy5(arr);
            AreEqual(expected, res);
        }

        [TestMethod]
        public void PrefixesDivBy5Soln_Fourth()
        {
            var arr = new int[] { 1, 1, 1, 0, 1 };
            var expected = new bool[] { false, false, false, false, false };

            var res = new PrefixesDivBy5Soln().PrefixesDivBy5(arr);
            AreEqual(expected, res);
        }

        [TestMethod]
        public void PrefixesDivBy5Soln_Fifth()
        {
            var arr = new int[] { 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1 };
            var expected = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, true, true, true, false };

            var res = new PrefixesDivBy5Soln().PrefixesDivBy5(arr);
            AreEqual(expected, res);
        }

        private void AreEqual(bool[] res, IList<bool> output)
        {
            Assert.AreEqual(res.Length, output.Count);
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], output[i]);
            }
        }
    }
}
