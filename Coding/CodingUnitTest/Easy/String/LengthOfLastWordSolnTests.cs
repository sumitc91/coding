using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class LengthOfLastWordSolnTests
    {
        [TestMethod]
        public void LengthOfLastWordSoln_First()
        {
            var a = "Hello World";            
            var output = 5;
            var res = new LengthOfLastWordSoln().LengthOfLastWord(a);

            Assert.AreEqual(res, output);
        }
    }
}
