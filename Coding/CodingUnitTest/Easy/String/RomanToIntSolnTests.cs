using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class RomanToIntSolnTests
    {
        [TestMethod]
        public void RomanToIntSoln_First()
        {
            var input = "III";
            var output = 3;
            var res = new RomanToIntSoln().RomanToInt(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RomanToIntSoln_Second()
        {
            var input = "IV";
            var output = 4;
            var res = new RomanToIntSoln().RomanToInt(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RomanToIntSoln_Third()
        {
            var input = "IX";
            var output = 9;
            var res = new RomanToIntSoln().RomanToInt(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RomanToIntSoln_Fourth()
        {
            var input = "LVIII";
            var output = 58;
            var res = new RomanToIntSoln().RomanToInt(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void RomanToIntSoln_Fifth()
        {
            var input = "MCMXCIV";
            var output = 1994;
            var res = new RomanToIntSoln().RomanToInt(input);

            Assert.AreEqual(res, output);
        }
    }
}
