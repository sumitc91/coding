using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class CanConstructSolnTests
    {
        [TestMethod]
        public void CanConstructSoln_First()
        {
            var ransomNote = "a";
            var magazine = "b";
            var output = false;
            var res = new CanConstructSoln().CanConstruct(ransomNote, magazine);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CanConstructSoln_Second()
        {
            var ransomNote = "aa";
            var magazine = "ab";
            var output = false;
            var res = new CanConstructSoln().CanConstruct(ransomNote, magazine);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void CanConstructSoln_Third()
        {
            var ransomNote = "aa";
            var magazine = "aab";
            var output = true;
            var res = new CanConstructSoln().CanConstruct(ransomNote, magazine);

            Assert.AreEqual(res, output);
        }
    }
}
