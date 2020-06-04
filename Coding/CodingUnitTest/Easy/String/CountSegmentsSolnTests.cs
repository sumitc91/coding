using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class CountSegmentsSolnTests
    {
        [TestMethod]
        public void CountSegmentsSoln_First()
        {
            var s = "Hello, my name is John";
            var output = 5;
            var res = new CountSegmentsSoln().CountSegments(s);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountSegmentsSoln_Second()
        {
            var s = "                ";
            var output = 0;
            var res = new CountSegmentsSoln().CountSegments(s);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CountSegmentsSoln_Third()
        {
            var s = "Of all the gin joints in all the towns in all the world,   ";
            var output = 13;
            var res = new CountSegmentsSoln().CountSegments(s);

            Assert.AreEqual(res, output);
        }
    }
}
