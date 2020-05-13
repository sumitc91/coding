using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class CheckRecordSolnTests
    {
        [TestMethod]
        public void CheckRecordSoln_First()
        {
            var input = "PPALLP";
            var output = true;
            var res = new CheckRecordSoln().CheckRecord(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CheckRecordSoln_Second()
        {
            var input = "PPALLL";
            var output = false;
            var res = new CheckRecordSoln().CheckRecord(input);

            Assert.AreEqual(res, output);
        }
    }
}
