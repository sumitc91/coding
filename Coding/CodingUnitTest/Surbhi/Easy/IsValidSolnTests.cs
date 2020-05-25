using LeetCode.AskGif.Surbhi.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Surbhi.Easy
{
    [TestClass]
    public class IsValidSolnTests
    {
        [TestMethod]
        public void IsValidSoln_First()
        {
            var input = "()";
            var output = true;
            var res = new IsValidSoln().IsValid(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void IsValidSoln_Second()
        {
            var input = "()[]{}";
            var output = true;
            var res = new IsValidSoln().IsValid(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void IsValidSoln_Third()
        {
            var input = "(]";
            var output = false;
            var res = new IsValidSoln().IsValid(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void IsValidSoln_Fourth()
        {
            var input = "([)]";
            var output = false;
            var res = new IsValidSoln().IsValid(input);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void IsValidSoln_Fifth()
        {
            var input = "{[]}";
            var output = true;
            var res = new IsValidSoln().IsValid(input);

            Assert.AreEqual(res, output);
        }
    }
}
