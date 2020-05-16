using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class DetectCapitalUseSolnTests
    {
        [TestMethod]
        public void DetectCapitalUseSoln_First()
        {
            var a = "USA";            
            var output = true;
            var res = new DetectCapitalUseSoln().DetectCapitalUse(a);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void DetectCapitalUseSoln_Second()
        {
            var a = "FlaG";
            var output = false;
            var res = new DetectCapitalUseSoln().DetectCapitalUse(a);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void DetectCapitalUseSoln_Third()
        {
            var a = "leetcode";
            var output = true;
            var res = new DetectCapitalUseSoln().DetectCapitalUse(a);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void DetectCapitalUseSoln_Fourth()
        {
            var a = "Google";
            var output = true;
            var res = new DetectCapitalUseSoln().DetectCapitalUse(a);

            Assert.AreEqual(res, output);
        }
    }
}
