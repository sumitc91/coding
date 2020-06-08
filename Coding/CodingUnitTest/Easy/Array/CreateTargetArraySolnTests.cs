using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class CreateTargetArraySolnTests
    {
        [TestMethod]
        public void CreateTargetArraySoln_First()
        {
            var nums = new int[] { 0, 1, 2, 3, 4 };
            var index = new int[] { 0, 1, 2, 2, 1 };
            var output = new int[] { 0, 4, 1, 3, 2 };
            var res = new CreateTargetArraySoln().CreateTargetArray(nums, index);

            AreEqual(res, output);
        }
        
        [TestMethod]
        public void CreateTargetArraySoln_Second()
        {
            var nums = new int[] { 1, 2, 3, 4, 0 };
            var index = new int[] { 0, 1, 2, 3, 0 };
            var output = new int[] { 0, 1, 2, 3, 4 };
            var res = new CreateTargetArraySoln().CreateTargetArray(nums, index);

            AreEqual(res, output);
        }

        [TestMethod]
        public void CreateTargetArraySoln_Third()
        {
            var nums = new int[] { 1 };
            var index = new int[] { 0 };
            var output = new int[] { 1 };
            var res = new CreateTargetArraySoln().CreateTargetArray(nums, index);

            AreEqual(res, output);
        }

        [TestMethod]
        public void CreateTargetArraySoln_Fourth()
        {

            var nums = new int[] { 4, 2, 4, 3, 2 };
            var index = new int[] { 0, 0, 1, 3, 1 };
            var output = new int[] { 2, 2, 4, 4, 3 };
            var res = new CreateTargetArraySoln().CreateTargetArray(nums, index);

            AreEqual(res, output);
        }

        private void AreEqual(int[] res, int[] output)
        {
            Assert.AreEqual(res.Length, output.Length);

            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], output[i]);
            }
        }
    }
}
