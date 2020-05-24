using CodingUnitTest.Util;
using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{    
    [TestClass]
    public class ReverseStringSolnTests
    {
        [TestMethod]
        public void ReverseStringSoln_First()
        {
            var input = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var output = new char[]{'o', 'l', 'l', 'e', 'h'};
            new ReverseStringSoln().ReverseString(ref input);

            ContractAssert.AreEqual(input, output);
        }
    }
}
