using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class ReverseWordsSolnTests
    {
        [TestMethod]
        public void ReverseWordsSoln_First()
        {
            var input = "Let's take LeetCode contest";
            var output = "s'teL ekat edoCteeL tsetnoc";
            var res = new ReverseWordsSoln().ReverseWords(input);

            Assert.AreEqual(res, output);
        }
    }
}
