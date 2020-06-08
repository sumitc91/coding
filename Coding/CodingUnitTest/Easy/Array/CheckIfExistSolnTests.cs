using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class CheckIfExistSolnTests
    {
        [TestMethod]
        public void CheckIfExistSoln_First()
        {
            var arr = new int[] { 10, 2, 5, 3 };
            var output = true;
            var res = new CheckIfExistSoln().CheckIfExist(arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CheckIfExistSoln_Second()
        {
            var arr = new int[] { 7, 1, 14, 11 };
            var output = true;
            var res = new CheckIfExistSoln().CheckIfExist(arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CheckIfExistSoln_Third()
        {
            var arr = new int[] { 3, 1, 7, 11 };
            var output = false;
            var res = new CheckIfExistSoln().CheckIfExist(arr);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CheckIfExistSoln_Fourth()
        {
            var arr = new int[] { -2, 0, 10, -19, 4, 6, -8 };
            var output = false;
            var res = new CheckIfExistSoln().CheckIfExist(arr);

            Assert.AreEqual(res, output);
        }
    }
}
