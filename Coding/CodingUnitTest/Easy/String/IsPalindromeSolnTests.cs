using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class IsPalindromeSolnTests
    {
        [TestMethod]
        public void IsPalindromeSoln_First()
        {
            var s = "A man, a plan, a canal: Panama";            
            var output = true;
            var res = new IsPalindromeSoln().IsPalindrome(s);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void IsPalindromeSoln_Second()
        {
            var s = "race a car";
            var output = false;
            var res = new IsPalindromeSoln().IsPalindrome(s);

            Assert.AreEqual(res, output);
        }
    }
}
