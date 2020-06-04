using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class MaxPowerSolnTests
    {
        [TestMethod]
        public void MaxPowerSoln_First()
        {
            var s = "leetcode";            
            var output = 2;
            var res = new MaxPowerSoln().MaxPower(s);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void MaxPowerSoln_Second()
        {
            var s = "abbcccddddeeeeedcba";
            var output = 5;
            var res = new MaxPowerSoln().MaxPower(s);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void MaxPowerSoln_Third()
        {
            var s = "triplepillooooow";
            var output = 5;
            var res = new MaxPowerSoln().MaxPower(s);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void MaxPowerSoln_Fourth()
        {
            var s = "hooraaaaaaaaaaay";
            var output = 11;
            var res = new MaxPowerSoln().MaxPower(s);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void MaxPowerSoln_Fifth()
        {
            var s = "tourist";
            var output = 1;
            var res = new MaxPowerSoln().MaxPower(s);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void MaxPowerSoln_Sixth()
        {
            var s = "cc";
            var output = 2;
            var res = new MaxPowerSoln().MaxPower(s);

            Assert.AreEqual(res, output);
        }
    }
}
