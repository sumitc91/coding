using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class AddBinarySolnTests
    {
        [TestMethod]
        public void AddBinarySoln_First()
        {
            var a = "11";
            var b = "1";
            var output = "100";
            var res = new AddBinarySoln().AddBinary(a, b);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void AddBinarySoln_Second()
        {
            var a = "1010";
            var b = "1011";
            var output = "10101";
            var res = new AddBinarySoln().AddBinary(a, b);

            Assert.AreEqual(res, output);
        }
    }
}
