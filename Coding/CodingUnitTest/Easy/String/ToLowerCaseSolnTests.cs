using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class ToLowerCaseSolnTests
    {
        [TestMethod]
        public void ToLowerCaseSoln_Hello()
        {
            var input = "Hello";
            var output = "hello";
            var res = new ToLowerCaseSoln().ToLowerCase(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void ToLowerCaseSoln_here()
        {
            var input = "here";
            var output = "here";
            var res = new ToLowerCaseSoln().ToLowerCase(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void ToLowerCaseSoln_LOVELY()
        {
            var input = "LOVELY";
            var output = "lovely";
            var res = new ToLowerCaseSoln().ToLowerCase(input);

            Assert.AreEqual(res, output);
        }
    }
}
