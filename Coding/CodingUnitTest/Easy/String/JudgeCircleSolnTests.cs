using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class JudgeCircleSolnTests
    {
        [TestMethod]
        public void JudgeCircleSoln_UD()
        {
            var input = "UD";
            var output = true;
            var res = new JudgeCircleSoln().JudgeCircle(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void JudgeCircleSoln_LL()
        {
            var input = "LL";
            var output = false;
            var res = new JudgeCircleSoln().JudgeCircle(input);

            Assert.AreEqual(res, output);
        }
    }
}
