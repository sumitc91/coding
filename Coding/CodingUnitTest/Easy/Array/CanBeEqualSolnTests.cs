using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class CanBeEqualSolnTests
    {
        [TestMethod]
        public void CanBeEqualSoln_First()
        {
            var target = new int[] { 1, 2, 3, 4 };
            var arr = new int[] { 2, 4, 1, 3 };
            var output = true;
            var res = new CanBeEqualSoln().CanBeEqual(target, arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CanBeEqualSoln_Second()
        {
            var target = new int[] { 3, 7, 9 };
            var arr = new int[] { 3, 7, 11 };
            var output = false;
            var res = new CanBeEqualSoln().CanBeEqual(target, arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CanBeEqualSoln_Third()
        {
            var target = new int[] { 7 };
            var arr = new int[] { 7 };
            var output = true;
            var res = new CanBeEqualSoln().CanBeEqual(target, arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CanBeEqualSoln_Fourth()
        {
            var target = new int[] { 1, 12 };
            var arr = new int[] { 12, 1 };
            var output = true;
            var res = new CanBeEqualSoln().CanBeEqual(target, arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CanBeEqualSoln_Fifth()
        {
            var target = new int[] { 1, 1, 1, 1, 1 };
            var arr = new int[] { 1, 1, 1, 1, 1 };
            var output = true;
            var res = new CanBeEqualSoln().CanBeEqual(target, arr);

            Assert.AreEqual(res, output);
        }
    }
}
